using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsForm
{
    public partial class MainForm : Form
    {
        // Add a BindingSource to help manage the data
        private readonly BindingSource BindingSource = new BindingSource();
        private const string ConnectionString = "Data Source=DESKTOP-NLJJKJS\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            using (InsertForm insertForm = new InsertForm())
            {
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve user inputfrom the insert form
                    string fullName = insertForm.FullName;
                    DateTime dob = insertForm.DateOfBirth;
                    string gender = insertForm.Gender;
                    string phoneNumber = insertForm.PhoneNumber;
                    string address = insertForm.Address;
                    string personalID = insertForm.PersonalID;
                    string email = insertForm.EMail;

                    // Validate mandatory fields
                    if (string.IsNullOrWhiteSpace(fullName) || dob == DateTime.MinValue || string.IsNullOrWhiteSpace(gender))
                    {
                        MessageBox.Show("გთცოვთ შეავსოთ ყველა სავალდებულო ველი (გვარი სახელი, დაბადების თარიღი, სქესი).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Split the full name into first name and last name
                    string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (nameParts.Length > 2)
                    {
                        MessageBox.Show("გთხოვთ მიუთითოთ პაციენტის გვარიც და სახელიც.", "Validation Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string firstName = nameParts[0];
                    string lastName = string.Join("", nameParts.Skip(1));

                    // Validate phone number 
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        if (!phoneNumber.StartsWith("5") || phoneNumber.Length != 9 || !phoneNumber.All(char.IsDigit))
                        {
                            MessageBox.Show("თვქენს მიერ მითითებული მობილურის ნომერი არასწორია. მობილური ნომერი უნდა იწყებოდეს 5-ით და უნდა შეიცავდეს 9 ციფრს.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // save the data or perform other actions 

                    string resultMessage = $"Last Name: {lastName}\nFirst Name: {firstName}\nDOB: {dob.ToShortDateString()}\nGender: {gender}\nPhone: {phoneNumber}\nAddress: {address}\nPersonal ID: {personalID}\nE-Mail: {email}";

                    // After saving, refresh the DataGridView
                    LoadPatientsDate();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientManagementDataSet.Patients' table. I can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientManagementDataSet.Patients);

            // Format the "Dob" column
            dataGridView1.Columns["Dob"].DefaultCellStyle.Format = "MM.d.yyyy";
            dataGridView1.Columns["Dob"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Load patient data initially
            LoadPatientsDate();
        }

        private void LoadPatientsDate()
        {
            string query = "SELECT P.ID, P.FullName, P.Dob, G.GenderName, P.Phone, P.Address, P.PersonalID, P.EMail " +
                           "FROM Patients P " +
                           "INNER JOIN Gender G ON P.GenderID = G.GenderID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                //connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    BindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = BindingSource;
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected patients's ID (assuming ID is in the first column)
                int PatientID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                // Open the EditForm and pass the patientID
                using (EditForm editForm = new EditForm(PatientID))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the DataGridView after editing
                        LoadPatientsDate();
                    }
                }
            }
            else
            {
                MessageBox.Show("გთხოვთ მონიშნოთ ის პაციენტი რომლის ინფორმაციის რედაქტირებაც გსურთ", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeletePatient(int patientID)
        {
            // Implement database deletion logic
            try
            {
                string deleteQuery = "DELETE FROM Patients WHERE ID = @PatientID";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                MessageBox.Show($"Error: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected patient's ID
                int patientID = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                // Promt the user for confirmation
                DialogResult result = MessageBox.Show("გსურთ მონიშნული ჩანაწერის წაშლა?", "confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call a method to delete the patient base on the ID
                    if (DeletePatient(patientID))
                    {
                        // If deletion is successful, refresh the DataGridView
                        LoadPatientsDate();
                        MessageBox.Show("ჩანაწერის წაშლა წარმატებით განხორციელდა.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("შეცდომა დაფიქსირდა ჩანაწერის შაშლისას.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("გთხოვთ მონიშნოთ პაციენტი რომლის ინფორმაციის წაშლაც გსურთ", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Phone"].Index && e.Value != null)
            {
                string phoneValue = e.Value.ToString();

                // Format the phone number with dashes
                if (phoneValue.Length == 9)
                {
                    e.Value = phoneValue.Insert(3, "-").Insert(7, "-");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
