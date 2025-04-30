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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmBookingPage : Form
    {
        public frmBookingPage()
        {
            InitializeComponent();
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHome = new frmHomePage();
            frmToHome.Show();
            this.Close();
        }

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();
            frmToGreenEnergyProducts.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            frmCarbonFootprintCalculator frmToCarbonFootprint = new frmCarbonFootprintCalculator();
            frmToCarbonFootprint.Show();
            this.Close();
        }

        private void btnCheckTOS_Click(object sender, EventArgs e)
        {
            var frmTerms = new frmTOS();
            frmTerms.Location = this.Location;
            frmTerms.StartPosition = FormStartPosition.Manual;
            frmTerms.FormClosing += delegate { this.Show(); };
            frmTerms.Show();
            this.Hide();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == 0)
            {
                txtService.Text = "Consultation";
            }
            else
            {
                txtService.Text = "Installation";
            }
        }

        private void dtpDateToBook_ValueChanged_1(object sender, EventArgs e)
        {
            string date = dtpDateToBook.Value.ToShortDateString();
            txtDate.Text = date.ToString();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            //Declaring database 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string fullName = txtFullName.Text;
            string service = txtService.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            //Creating new command to search through stored dates
            SqlCommand checkDateCommand = new SqlCommand("SELECT COUNT(*) FROM BookedAppointments WHERE date = @Date", sqlConnection);
            checkDateCommand.Parameters.AddWithValue("@Date", date);

            //Opening database connection
            sqlConnection.Open();
            int dateCount = (int)checkDateCommand.ExecuteScalar();
            //Closing database connection
            sqlConnection.Close();

            if (dateCount > 0) //If username >0, means username already exists
            {
                txtError.Text = "Appointment slot has already been taken, please try again!";
                txtError.Visible = true;
            }
            else
            {
                //Calling the 'CreateNewBookingRecord' procedure
                SqlCommand command = new SqlCommand("CreateNewBookingRecord", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;


                //validating email
                int countEmail = 0;
                //Checking if email ends in ".com"
                string hasDotCom = email.Substring(email.Length - 4);



                //Checking to see if the email has an @ symbol in it
                foreach (char c in email)
                {
                    if (c == '@')
                    {
                        countEmail = countEmail + 1;
                    }
                }

                //Checking to see if phone number is made up of integers
                int countPhoneNumDigits = 0;
                foreach (char character in phoneNumber)
                {
                    if (character <= 0 || character >= 9)
                    {
                        countPhoneNumDigits = countPhoneNumDigits + 1;
                    }
                }

                bool allDigits = false;

                if (countPhoneNumDigits == phoneNumber.Length)
                {
                    allDigits = true;
                }
                else
                {
                    allDigits = false;
                }

                if (countEmail == 1 && hasDotCom == ".com")
                {
                    if (phoneNumber.Length == 11 && allDigits == true)
                    {
                        if (cbConfirmInfo.Checked == true && cbTermsOfService.Checked == true)
                        {
                            command.Parameters.AddWithValue("@FullName", fullName);
                            command.Parameters.AddWithValue("@Service", service);
                            command.Parameters.AddWithValue("@Date", date);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            sqlConnection.Open();
                            command.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("Successfully booked");
                            txtError.Visible = false;
                        }
                        else
                        {
                            txtError.Text = "Please read our terms of service and confirm your details!";
                            txtError.Visible = true;
                        }
                    }
                    else
                    {
                        txtError.Text = "Phone number is not valid, please try again!";
                        txtError.Visible = true;
                    }
                }
                else
                {
                    txtError.Text = "Email is not valid, please try again!";
                    txtError.Visible = true;
                }
            }
        }

        private void btnEnergyUsage_Click(object sender, EventArgs e)
        {
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            frmToEnergyUsageCalculator.Show();
            this.Close();
        }
    }
}
