using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsForm
{
    public partial class InsertForm : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-NLJJKJS\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True";

        // Properties to access form control's values
        public string FullName
        {
            get { return fullNameTextBox.Text.Trim(); }
        }

        public DateTime DateOfBirth
        {
            get { return dobdateTimePicker.Value; }
        }

        public string Gender
        {
            get { return genderComboBox.SelectedItem?.ToString();}
        }

        public string PhoneNumber
        {
            get { return phoneTextBox.Text.Trim(); }
        }

        public string Address
        {
            get { return addressTextBox.Text.Trim(); }
        }

        public string PersonalID
        {
            get { return personalIDTextBox.Text.Trim(); }
        }

        public string EMail
        {
            get { return eMailTextBox.Text.Trim(); }
        }

        // Database connecton
        private readonly SqlConnection connection;

        public InsertForm()
        {
            InitializeComponent();
            // populate genderComboBox with gender options
            genderComboBox.Items.AddRange(new string[] { "მამრობითი", "მდედრობითი" });

            // Initialize the database connection
            connection = new SqlConnection(ConnectionString);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Cancel, which will close the form
            DialogResult = DialogResult.Cancel;
        }

        // Retrieve GenderID by GenderName from the database
        private int GetGenderIdByName(string genderName)
        {
            // Check and open the database connection if it's closed
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Prepare and execute a query to get the GenderID by GenderName 
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT GenderID FROM Gender WHERE GenderName = @GenderName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GenderName", genderName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Handle the case when the gender name is not found
                        return -1; // or throw an exception
                    }
                }
            }
        }

        // Validate PersonalID
        private bool ValidatePersonalID(string PersonalID)
        {
            // Validate the format of the PersonalID using a regular expression
            if (!string.IsNullOrEmpty(PersonalID))
            {
                string pattern = @"^\d{11}$";

                if (Regex.IsMatch(PersonalID, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // If PersonalID is null or empty, it's considered valid
            return true;
        }

        // Validate Email
        private bool ValidateEmail(string Email)
        {
            // Validate the format of the Email using System.Net.Mail.MailAddress
            if (!string.IsNullOrEmpty(Email))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(Email);
                    return addr.Address == Email;
                }
                catch
                {
                    return false;
                }
            }

            // If email is null or empty, it's Considered valid
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Retrieve user input from the form controls
            string fullName = fullNameTextBox.Text.Trim();
            DateTime dob = dobdateTimePicker.Value;
            string gender = genderComboBox.SelectedItem?.ToString();
            string phoneNumber = phoneTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string personalID = personalIDTextBox.Text.Trim();
            string eMail = eMailTextBox.Text.Trim();

            // Validate mandatory fields
            if (string.IsNullOrWhiteSpace(fullName) || dob == DateTime.MinValue || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("გთცოვთ შეავსოთ ყველა სავალდებულო ველი (გვარი სახელი, დაბადების თარიღი, სქესი).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Split the full name into first name and last name
            string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2 )
            {
                MessageBox.Show("გთხოვთ მიუთითოთ პაციენტის გვარიც და სახელიც.", "Validation Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string firstName = nameParts[0];
            string lastName = string.Join(" ", nameParts.Skip(1));

            // Perform further validation on first name and last name
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)) 
            {
                MessageBox.Show("მითითებული უნდა იყოს აუცილებლად პაციენტის გვარიც და სახელიც.", "Validation Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if(!phoneNumber.StartsWith("5") || phoneNumber.Length != 9 || !phoneNumber.All(char.IsDigit))
                {
                    MessageBox.Show("თვქენს მიერ მითითებული მობილურის ნომერი არასწორია. მობილური ნომერი უნდა იწყებოდეს 5-ით და უნდა შეიცავდეს 9 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate PersonalID using the ValidatePersonalID method
            if (!ValidatePersonalID(PersonalID))
            {
                MessageBox.Show("პირადი ნომერი უნდა შიეცავდეს 11 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Email using the vatidateEmail method
            if (!ValidateEmail(eMail))
            {
                MessageBox.Show("მითითებული იმეილი არ არის სწორი.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int genderId = GetGenderIdByName(gender);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // open the Connection
                connection.Open();

                // Create an INSERT command
                string insertQuery = "INSERT INTO Patients (FullName, Dob, GenderID, Phone, Address, PersonalID, EMail) " +
                                     "VALUES (@FullName, @Dob, @GenderID, @Phone, @Address, @PersonalID, @EMail); SELECT SCOPE_IDENTITY()";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Set parameters for the INSERT command 
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Dob", dob);
                    command.Parameters.AddWithValue("@GenderID", genderId); // Replace with actual GenderID
                    command.Parameters.AddWithValue("@Phone", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PersonalID", personalID);
                    command.Parameters.AddWithValue("@EMail", eMail);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("პაციენტი ინფორმაციის დამახსოვრება წარმატებით განხორციელდა!", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("შეცდომა დაფიქსირდა პაციენტის ინფორმაციის დამახსოვრებისას", "Save Data Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.FormClosed += (s, args) =>
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                };

                // Set DialogResult to Ok to close the form 
                DialogResult = DialogResult.OK;
            }
        }
    }
}
