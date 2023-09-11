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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PatientsForm
{
    public partial class EditForm : Form
    {
        private readonly int patientID;

        // Initialize the database connection and load patient data for editing
        private const string ConnectionString = "Data Source=DESKTOP-NLJJKJS\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True";


        public EditForm(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;

            // Initialize genderComboBox items
            genderComboBox.Items.AddRange(new string[] { "მამრობითი", "მდედრობითი" });

            //connection = new SqlConnection(ConnectionString);

            // Load patient data for editing
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Pacient_GetByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientID", patientID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate textboxes with patient data for editing
                            fullNameTextBox.Text = reader["FullName"].ToString();
                            dobdateTimePicker.Value = (DateTime)reader["Dob"];

                            // Set the selected gender in genderComboBox
                            int genderID = (int)reader["GenderID"];
                            string genderName = (genderID == 1) ? "მამრობითი" : "მდედრობითი";
                            genderComboBox.SelectedItem = genderName;

                            // Remove dashes from the phone number
                            phoneTextBox.Text = reader["Phone"].ToString().Replace("-", "");

                            addressTextBox.Text = reader["Address"].ToString();
                            personalIDTextBox.Text = reader["PersonalID"].ToString();
                            eMailTextBox.Text = reader["EMail"].ToString();
                        }
                    }
                }
            }
        }

        private int GetGenderIdByName(string genderName)
        {
            // Prepare and execute a query to get the gender ID by name
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetGenderIDByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GenderName", genderName);

                    SqlParameter returnParam = new SqlParameter("@GenderID", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(returnParam);

                    // Execute the stored procedure and obtain the output parameter
                    command.ExecuteNonQuery();
                    int genderID = (int)returnParam.Value;

                    // Check if the obtained GenderID is valid
                    if (genderID > 0)
                    {
                        return genderID;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        private bool ValidatePersonalID(string PersonalID)
        {
            // Validate the format of the Personal ID
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
            // Validate the format of the Email address
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
            // Check if a valid patient ID is available
            if (patientID == -1)
            {
                MessageBox.Show("Invalid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve user input from the form controls
            string editedFullName = fullNameTextBox.Text.Trim();
            DateTime editedDob = dobdateTimePicker.Value;
            string editedGender = genderComboBox.SelectedItem?.ToString();
            string editedPhoneNumber = phoneTextBox.Text.Trim();
            string editedAddress = addressTextBox.Text.Trim();
            string editedPersonalID = personalIDTextBox.Text.Trim();
            string editedEMail = eMailTextBox.Text.Trim();

            // Validate edited data
            // Validate the user input
            if (string.IsNullOrWhiteSpace(editedFullName) || editedDob == DateTime.MinValue || string.IsNullOrWhiteSpace(editedGender))
            {
                MessageBox.Show("გთცოვთ შეავსოთ ყველა სავალდებულო ველი (გვარი სახელი, დაბადების თარიღი, სქესი).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Split the full name into first name and last name
            string[] nameParts = editedFullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                MessageBox.Show("გთხოვთ მიუთითოთ პაციენტის გვარიც და სახელიც.", "Validation Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string firstName = nameParts[0];
            string lastName = string.Join(" ", nameParts.Skip(1));

            // Perform further validation on first name and last name
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("მითითებული უნდა იყოს აუცილებლად პაციენტის გვარიც და სახელიც.", "Validation Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number
            if (!string.IsNullOrEmpty(editedPhoneNumber))
            {
                if (!editedPhoneNumber.StartsWith("5") || editedPhoneNumber.Length != 9 || !editedPhoneNumber.All(char.IsDigit))
                {
                    MessageBox.Show("თვქენს მიერ მითითებული მობილურის ნომერი არასწორია. მობილური ნომერი უნდა იწყებოდეს 5-ით და უნდა შეიცავდეს 9 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate PersonalID using the ValidatePersonalID method
            if (!ValidatePersonalID(editedPersonalID))
            {
                MessageBox.Show("პირადი ნომერი უნდა შიეცავდეს 11 ციფრს", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Email using the vatidateEmail method
            if (!ValidateEmail(editedEMail))
            {
                MessageBox.Show("მითითებული იმეილი არ არის სწორი.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int genderId = GetGenderIdByName(editedGender);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Pacient_Edit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the procedure
                    command.Parameters.AddWithValue("@ID", patientID);
                    command.Parameters.AddWithValue("@EditedFullName", editedFullName);
                    command.Parameters.AddWithValue("@EditedDob", editedDob);
                    command.Parameters.AddWithValue("@EditedGenderID", genderId);
                    command.Parameters.AddWithValue("@EditedPhone", editedPhoneNumber); // Phone number without dashes
                    command.Parameters.AddWithValue("@EditedAddress", editedAddress);
                    command.Parameters.AddWithValue("@EditedPersonalID", editedPersonalID);
                    command.Parameters.AddWithValue("@EditedEMail", editedEMail);
                    command.Parameters.AddWithValue("@PatientID", patientID);

                    // Execute the SQL command to update the patient information
                    int rowAffected = command.ExecuteNonQuery();

                    // Check the number of rows affected to determine if the update was successful
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("პაციენტი ინფორმაციის რედაქტირება წარმატებით განხორციელდა!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("პაციენტის ინფორმაციის განახლებისას დაფიქსირდა შეცდომა!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Cancel, which will close the form
            DialogResult = DialogResult.Cancel;
        }
    }
}
