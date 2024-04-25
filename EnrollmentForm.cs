using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS_Biometrics
{
    public partial class EnrollmentForm : CaptureForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        public EnrollmentForm()
        {
            InitializeComponent();
            PopulateComboBox();
            comboBoxFullName.SelectedIndexChanged += ComboBoxFullName_SelectedIndexChanged;
        }

        private void PopulateComboBox()
        {
            // Clear existing items
            comboBoxFullName.Items.Clear();

            // Fetch data from the database
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EMP_ID, FNAME, MNAME, LNAME, SUFFIX FROM EMPLOYEES";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Populate the comboBoxFullName
                while (reader.Read())
                {
                    string fullName = $"{reader["EMP_ID"]} - {reader["FNAME"]} {reader["MNAME"]} {reader["LNAME"]} {reader["SUFFIX"]}".Trim();
                    comboBoxFullName.Items.Add(new KeyValuePair<int, string>((int)reader["EMP_ID"], fullName));
                }
            }
        }
        private void ComboBoxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFullName.SelectedItem != null && comboBoxFullName.SelectedItem is KeyValuePair<int, string> selectedEmployee)
            {
                int empId = selectedEmployee.Key;

                // Fetch additional details based on the selected employee ID
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT EMAIL, DEPARTMENT, POSITION FROM EMPLOYEES WHERE EMP_ID = @EmpId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmpId", empId);
                    SqlDataReader reader = command.ExecuteReader();

                    // Populate the textBoxDetails
                    if (reader.Read())
                    {
                        string email = reader["EMAIL"].ToString();
                        string department = reader["DEPARTMENT"].ToString();
                        string position = reader["POSITION"].ToString();
                        Email.Text = email;
                        Deepartment.Text = department;
                        Position.Text = position;
                    }
                }
            }
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Enrollment";
            Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null)
            {
                try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);

                    // Check if template has been created.
                    if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready)
                    {
                        // Serialize the template
                        MemoryStream ms = new MemoryStream();
                        Enroller.Template.Serialize(ms);
                        byte[] serializedTemplate = ms.ToArray();

                        // Get the selected employee ID
                        int empId = -1;
                        Invoke(new MethodInvoker(() =>
                        {
                            if (comboBoxFullName.SelectedItem != null && comboBoxFullName.SelectedItem is KeyValuePair<int, string> selectedEmployee)
                            {
                                empId = selectedEmployee.Key;
                            }
                        }));

                        if (empId != -1)
                        {
                            SaveTemplateToDatabase(serializedTemplate, empId); // Call the method with the selected employee ID

                            // Trigger the event with the template
                            OnTemplate(Enroller.Template);
                            SetPrompt("Click Close, and then click Fingerprint Verification.");
                            Stop();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    UpdateStatus();
                }
            }
        }


        private void SaveTemplateToDatabase(byte[] serializedTemplate, int empId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE EMPLOYEES SET FINGERPRINT1 = @TemplateData WHERE EMP_ID = @EmployeeId";

                    // Create a command with parameters
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TemplateData", serializedTemplate);
                        command.Parameters.AddWithValue("@EmployeeId", empId);
                        command.ExecuteNonQuery();
                    }

                    // If insertion successful, close the connection
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;
    }
}
