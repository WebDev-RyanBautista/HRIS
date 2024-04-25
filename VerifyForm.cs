using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS_Biometrics
{
    public partial class VerifyForm : CaptureForm
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        public VerifyForm()
        {
            InitializeComponent();
            comboBoxFullName.Enabled = false;
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }
        private Dictionary<string, DPFP.Template> GetAllTemplatesFromDatabase()
        {
            Dictionary<string, DPFP.Template> templates = new Dictionary<string, DPFP.Template>();

            // SQL query to retrieve all fingerprint templates and corresponding EMP_ID from the EMPLOYEES table
            string query = "SELECT EMP_ID, FINGERPRINT1 FROM EMPLOYEES";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string employeeID = reader["EMP_ID"].ToString();
                            byte[] templateBytes = reader["FINGERPRINT1"] as byte[];

                            if (templateBytes != null)
                            {
                                DPFP.Template template = new DPFP.Template();
                                template.DeSerialize(templateBytes);
                                templates.Add(employeeID, template);
                            }
                            else
                            {
                                Console.WriteLine($"Fingerprint template is null for employee ID: {employeeID}");
                            }
                        }
                    }
                }
            }
            return templates;
        }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the verification purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Retrieve all templates from the database
                Dictionary<string, DPFP.Template> allTemplates = GetAllTemplatesFromDatabase();

                // Iterate over each template and perform verification
                // Iterate over each template and perform verification
                bool foundMatch = false;
                string matchedEmployeeID = null;
                foreach (var kvp in allTemplates)
                {
                    string employeeID = kvp.Key;
                    DPFP.Template databaseTemplate = kvp.Value;

                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, databaseTemplate, ref result);
                    if (result.Verified)
                    {
                        foundMatch = true;
                        MakeReport($"The fingerprint was VERIFIED against the database for EMP_ID: {employeeID}");
                        matchedEmployeeID = employeeID;
                        break; // Exit the loop if a match is found
                    }
                }

                // Check if a match was found
                if (foundMatch)
                {
                    PopulateLabels(matchedEmployeeID);
                }
                else
                {
                    MakeReport("The fingerprint did not match any stored template in the database.");
                }

            }
        }
        private void PopulateLabels(string employeeID)
        {
            // Fetch employee information (e.g., full name) based on the employeeID from the database
            string fullName = GetFromDatabase(employeeID);

            // Use Invoke method to update UI controls on the UI thread
            if (comboBoxFullName.InvokeRequired)
            {
                comboBoxFullName.Invoke(new MethodInvoker(delegate
                {
                    // Add the full name to the comboBoxFullName
                    comboBoxFullName.Items.Add(fullName);
                    // Set the selected item to the newly added full name
                    comboBoxFullName.SelectedItem = fullName;
                }));
            }
            else
            {
                // If Invoke is not required (already on the UI thread), update UI controls directly
                // Add the full name to the comboBoxFullName
                comboBoxFullName.Items.Add(fullName);
                // Set the selected item to the newly added full name
                comboBoxFullName.SelectedItem = fullName;
            }
        }

        private void UpdateUIControls(string email, string department, string position, string timein, string timeout)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    Email.Text = email;
                    Deepartment.Text = department;
                    Position.Text = position;
                    TimeIn.Text = timein;
                    if (timein == timeout)
                        TimeOut.Text = "---";
                    else
                        TimeOut.Text = timeout;

                }));
            }
            else
            {
                Email.Text = email;
                Deepartment.Text = department;
                Position.Text = position;
                TimeIn.Text = timein;
                if (timein == timeout)
                    TimeOut.Text = "---";
                else
                    TimeOut.Text = timeout;
            }
        }
        private string GetFromDatabase(string employeeID)
        {
            string fullName = string.Empty;
            string query = "SELECT FNAME, MNAME, LNAME, SUFFIX, DEPARTMENT, POSITION, EMAIL FROM Employees WHERE EMP_ID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Concatenate the columns to form the full name
                            string firstName = reader["FNAME"].ToString();
                            string middleName = reader["MNAME"].ToString();
                            string lastName = reader["LNAME"].ToString();
                            string suffix = reader["SUFFIX"].ToString();
                            string email = reader["EMAIL"].ToString();
                            string department = reader["DEPARTMENT"].ToString();
                            string position = reader["POSITION"].ToString();

                            

                            bool hasTimedInToday = CheckTimedInToday(employeeID);
                            if (hasTimedInToday)
                            {
                                UpdateAttendance(employeeID);
                            }
                            else
                            {
                                InsertAttendance(employeeID);
                            }

                            UpdateUIControls(email, department, position, CheckTimeIn(employeeID), CheckTimeOut(employeeID));

                            fullName = $"{firstName} {middleName} {lastName} {suffix}".Trim();
                        }
                    }
                }
            }

            

            return fullName;
        }

        private bool CheckTimedInToday(string employeeID)
        {
            string query = "SELECT COUNT(*) FROM Attendance WHERE EMP_ID = @EmployeeID AND CAST(CONVERT(date, TIME_IN) AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void UpdateAttendance(string employeeID)
        {
            DateTime currentTime = DateTime.Now;
            DateTime lastTimeIn = GetLastTimeIn(employeeID);

            double workedHours = (currentTime - lastTimeIn).TotalHours;

            string query = "UPDATE Attendance SET TIME_OUT = @TimeOut, WORK_HOUR = @WorkedHours WHERE EMP_ID = @EmployeeID AND CAST(TIME_IN AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@TimeOut", currentTime);
                    command.Parameters.AddWithValue("@WorkedHours", workedHours);
                    connection.Open();
                    command.ExecuteNonQuery();


                    bool hasSalaryArrangement = CheckSalaryArrangement(employeeID, currentTime.ToString());

                    if(hasSalaryArrangement)
                    {
                        int convertedWorkedHr = Convert.ToInt32(workedHours);
                        UpdateSalary(employeeID, convertedWorkedHr, GetSalaryArrangement(employeeID, currentTime.ToString()), currentTime.ToString());
                        
                    }
                    else
                    {
                        InsertSalaryArrangement(employeeID, workedHours, currentTime.ToString());
                    }
                }
            }

            
            //(iInsertSalaryArrangementnt emp_id, double worked_hour, string timein)
        }


        private void InsertAttendance(string employeeID)
        {
            DateTime currentTime = DateTime.Now;
            DateTime previousTime = GetLastTimeIn(employeeID);

            double workedHours = (currentTime - previousTime).TotalHours;

            string query = "INSERT INTO Attendance (EMP_ID, TIME_IN, TIME_OUT, WORK_HOUR) VALUES (@EmpID, @TimeIn, @Timeout, @WorkedHours)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpID", employeeID);
                    command.Parameters.AddWithValue("@TimeIn", currentTime);
                    command.Parameters.AddWithValue("@TimeOut", currentTime);
                    command.Parameters.AddWithValue("@WorkedHours", 0);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private string CheckTimeIn(string employeeID)
        {
            string timeIn = string.Empty;
            string query = "SELECT TIME_IN FROM Attendance WHERE EMP_ID = @EmployeeID AND CAST(TIME_IN AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        timeIn = result.ToString();
                    }
                }
            }

            return timeIn;
        }

        private string CheckTimeOut(string employeeID)
        {
            string timeOut = string.Empty;
            string query = "SELECT TIME_OUT FROM Attendance WHERE EMP_ID = @EmployeeID AND CAST(TIME_IN AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        timeOut = result.ToString();
                    }
                }
            }

            return timeOut;
        }

        private DateTime GetLastTimeIn(string employeeID)
        {
            DateTime lastTimeIn = DateTime.MinValue;
            string query = "SELECT TOP 1 TIME_IN FROM Attendance WHERE EMP_ID = @EmployeeID ORDER BY TIME_IN DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        lastTimeIn = Convert.ToDateTime(result);
                    }
                }
            }

            return lastTimeIn;
        }
        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }


        private void InsertSalaryArrangement(string emp_id, double worked_hour, string timeout)
        {
            string query = "INSERT INTO Salary(EMP_ID, HOURLY_RATE, WORKING_HR, HR_WORKED, DEDUCTION, FINAL_SALARY, PAY_DATE, STATUS) " +
                "VALUES (@EmpID, @hrRate, @workingHr, @hrWorked, @deduction, @finalSalary, @payDate, @status)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpID", emp_id);
                    command.Parameters.AddWithValue("@hrRate", GetHourllyrate(emp_id));
                    command.Parameters.AddWithValue("@workingHr", 0);
                    command.Parameters.AddWithValue("@hrWorked", GetSumWorkedHour(emp_id));
                    command.Parameters.AddWithValue("@deduction", 0);
                    command.Parameters.AddWithValue("@finalSalary", (GetHourllyrate(emp_id)*worked_hour));
                    DateTime _timeout = DateTime.Parse(timeout);
                    string formattedPayDate = _timeout.ToString("yyyy-MM");
                    command.Parameters.AddWithValue("@payDate", formattedPayDate);
                    command.Parameters.AddWithValue("@status", "Not Paid");
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private int GetHourllyrate(string employeeID)
        {
            int hourly_rate = 0;
            string query = "SELECT BASIC_SALARY FROM Employees WHERE EMP_ID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        hourly_rate = Convert.ToInt32(result);
                    }
                }
            }

            return hourly_rate;
        }

        private int GetSumWorkedHour(string employeeID)
        {
            int WORK_HOUR = 0;
            string query = "SELECT SUM(WORK_HOUR) FROM Attendance WHERE EMP_ID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        WORK_HOUR = Convert.ToInt32(result);
                    }
                }
            }

            return WORK_HOUR;
        }

        private int GetSalaryArrangement(string employeeID, string payDate)
        {
            int hourly_rate = 0;
            string query = "SELECT HOURLY_RATE FROM Salary WHERE EMP_ID = @EmployeeID AND PAY_DATE = @payDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    DateTime _paydate = DateTime.Parse(payDate);
                    string formattedPayDate = _paydate.ToString("yyyy-MM");
                    command.Parameters.AddWithValue("@payDate", formattedPayDate);
                    connection.Open();
                    object result = (int)command.ExecuteScalar();
                    if (result != null)
                    {
                        hourly_rate = Convert.ToInt32(result);
                    }
                }
            }

            return hourly_rate;
        }

        private bool CheckSalaryArrangement(string employeeID, string currentTime)
        {
            string query = "SELECT COUNT(*) FROM Salary WHERE EMP_ID = @EmployeeID AND PAY_DATE = @PayDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DateTime paydate = DateTime.Parse(currentTime);
                    string formattedPayDate = paydate.ToString("yyyy-MM");
                    command.Parameters.AddWithValue("@PayDate", formattedPayDate);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void UpdateSalary(string employeeID, int workedhr, int hourlyRate, string payDate)
        {
           

            string query = "UPDATE Salary SET HR_WORKED = @hrWorked, FINAL_SALARY = @finalSalary WHERE EMP_ID = @EmployeeID AND PAY_DATE = @payDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@hrWorked", GetSumWorkedHour(employeeID));
                    command.Parameters.AddWithValue("@finalSalary", (workedhr * hourlyRate) - GetDeduction(employeeID));
                    DateTime paydate = DateTime.Parse(payDate);
                    string formattedPayDate = paydate.ToString("yyyy-MM");
                    command.Parameters.AddWithValue("@payDate", formattedPayDate);
                    connection.Open();
                    command.ExecuteNonQuery();


                }
            }


            //(iInsertSalaryArrangementnt emp_id, double worked_hour, string timein)
        }

        private int GetDeduction(string employeeID)
        {
            int deduction = 0;
            string query = "SELECT DEDUCTION FROM Salary WHERE EMP_ID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    object result = (int)command.ExecuteScalar();
                    if (result != null)
                    {
                        deduction = Convert.ToInt32(result);
                    }
                }
            }

            return deduction;
        }
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
    }
}
