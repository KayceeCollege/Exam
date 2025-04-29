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

        //declaring high contrast
        bool highContrast = false;

        private void btnToHome_Click(object sender, EventArgs e)
        {
            //Declaring home page
            frmHomePage frmToHome = new frmHomePage();
            //Opening home page, closing booking page
            frmToHome.Show();
            this.Close();
        }

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            //Declaring green energy page
            frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();
            //Opening green energy page, closing booking page
            frmToGreenEnergyProducts.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            //Declaring carbon footprint page
            frmCarbonFootprintCalculator frmToCarbonFootprint = new frmCarbonFootprintCalculator();
            //Opening carbon footprint page, closing booking page
            frmToCarbonFootprint.Show();
            this.Close();
        }

        private void btnCheckTOS_Click(object sender, EventArgs e)
        {
            //Declaring TOS page
            var frmTerms = new frmTOS();
            //TOS page will open in same location
            frmTerms.Location = this.Location;
            frmTerms.StartPosition = FormStartPosition.Manual;
            //Booking page will show again when TOS page is closed
            frmTerms.FormClosing += delegate { this.Show(); };
            //TOS page is shown and booking page is hidden - not completely closed
            frmTerms.Show();
            this.Hide();
        }

        //Executed as soon as value in combo box is changed
        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Index 0 in combo box is consultation
            if (cmbService.SelectedIndex == 0)
            {
                //will display chosen service as consultation in the booking info section
                txtService.Text = "Consultation";
            }
            //Index 1 in combo box is installation
            else
            {
                //will display chosen service as installation in the booking info section
                txtService.Text = "Installation";
            }
        }

        private void dtpDateToBook_ValueChanged_1(object sender, EventArgs e)
        {
            //Only date is stored from date time picker
            string date = dtpDateToBook.Value.ToShortDateString();
            //Displayig chosen date in text box in booking info section
            txtDate.Text = date.ToString();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            //Declaring database 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Declaring all variables that will be stored in database
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

            if (dateCount > 0) //If date >0, means date already exists in database
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
                    //Getting amount of digits in string
                    if (character <= 0 || character >= 9)
                    {
                        countPhoneNumDigits = countPhoneNumDigits + 1;
                    }
                }

                bool allDigits = false;

                if (countPhoneNumDigits == phoneNumber.Length)
                {
                    //if amount of digits counted in foreach loop is equal to number of characters in the string
                    allDigits = true;
                }
                else
                {
                    //if amount of digits counted in foreach loop is not equal to number of characters in the string
                    allDigits = false;
                }

                if (countEmail == 1 && hasDotCom == ".com")
                {
                    if (phoneNumber.Length == 11 && allDigits == true)
                    {
                        if (cbConfirmInfo.Checked == true && cbTermsOfService.Checked == true)
                        {
                            //Adding all values to database
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
                            //Shows if TOS checkbox not ticked
                            txtError.Text = "Please read our terms of service and confirm your details!";
                            txtError.Visible = true;
                        }
                    }
                    else
                    {
                        //Shows if phone number is not valid
                        txtError.Text = "Phone number is not valid, please try again!";
                        txtError.Visible = true;
                    }
                }
                else
                {
                    //Shows if email address is not valid
                    txtError.Text = "Email is not valid, please try again!";
                    txtError.Visible = true;
                }
            }
        }

        private void btnEnergyUsage_Click(object sender, EventArgs e)
        {
            //Declaring energy usage page
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            //Opening energy usage page, closing booking page
            frmToEnergyUsageCalculator.Show();
            this.Close();
        }

        private void btnHighContrast_Click(object sender, EventArgs e)
        {
            //if statement allows user to toggle between normal and high contrast
            if (highContrast == true)
            {
                //Setting all assets back to their original colours
                BackColor = Color.FromArgb(158, 202, 179);
                pbNavbar.BackColor = Color.FromArgb(103, 173, 136);
                btnGreenEnergyProducts.BackColor = Color.FromArgb(103, 173, 136);
                btnCarbonFootprint.BackColor = Color.FromArgb(103, 173, 136);
                pbCalender.BackColor = Color.FromArgb(103, 173, 136);
                btnEnergyUsage.BackColor = Color.FromArgb(103, 173, 136);
                btnSettings.BackColor = Color.FromArgb(103, 173, 136);
                btnToHome.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.ForeColor = Color.FromArgb(179, 214, 196);
                pbLogo.BackColor = Color.FromArgb(103, 173, 136);
                btnHighContrast.BackColor = SystemColors.Window;
                btnHighContrast.ForeColor = SystemColors.WindowText;
                lblBook.ForeColor = Color.FromArgb(65, 119, 91);
                lblInfo.ForeColor = Color.White;
                pbLine.BackColor = Color.FromArgb(65, 119, 91);
                lblService.ForeColor = Color.White;
                grbBookingInfo.BackColor = SystemColors.Window;
                lblBookingInfo.ForeColor = Color.FromArgb(65, 119, 91);
                lblFullName.ForeColor = Color.FromArgb(65, 119, 91);
                lblChosenService.ForeColor = Color.FromArgb(65, 119, 91);
                lblDate.ForeColor = Color.FromArgb(65, 119, 91);
                lblAddress.ForeColor = Color.FromArgb(65, 119, 91);
                lblEmail.ForeColor = Color.FromArgb(65, 119, 91);
                lblPhoneNum.ForeColor = Color.FromArgb(65, 119, 91);
                cbConfirmInfo.ForeColor = Color.Black;
                cbTermsOfService.ForeColor = Color.Black;
                btnCheckTOS.BackColor = Color.FromArgb(103, 173, 136);
                btnCheckTOS.ForeColor = Color.White;
                btnConfirmBooking.BackColor = Color.FromArgb(103, 173, 136);
                btnConfirmBooking.ForeColor = Color.White;
                txtError.BackColor = SystemColors.Window;
                txtError.ForeColor = SystemColors.WindowText;
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                pbNavbar.BackColor = Color.Blue;
                btnGreenEnergyProducts.BackColor = Color.Blue;
                btnCarbonFootprint.BackColor = Color.Blue;
                pbCalender.BackColor = Color.Blue;
                btnEnergyUsage.BackColor = Color.Blue;
                btnSettings.BackColor = Color.Blue;
                btnToHome.BackColor = Color.Blue;
                lblSlogan.BackColor = Color.Blue;
                lblSlogan.ForeColor = Color.White;
                pbLogo.BackColor = Color.Blue;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                lblBook.ForeColor = Color.Black;
                lblInfo.ForeColor = Color.Black;
                pbLine.BackColor = Color.Blue;
                lblService.ForeColor = Color.Black;
                grbBookingInfo.BackColor = Color.Blue;
                lblBookingInfo.ForeColor = Color.White;
                lblFullName.ForeColor = Color.White;
                lblChosenService.ForeColor = Color.White;
                lblDate.ForeColor = Color.White;
                lblAddress.ForeColor = Color.White;
                lblEmail.ForeColor = Color.White;
                lblPhoneNum.ForeColor = Color.White;
                cbConfirmInfo.ForeColor = Color.White;
                cbTermsOfService.ForeColor = Color.White;
                btnCheckTOS.BackColor = Color.White;
                btnCheckTOS.ForeColor = Color.Black;
                btnConfirmBooking.BackColor = Color.White;
                btnConfirmBooking.ForeColor = Color.Black;
                txtError.BackColor = Color.Black;
                txtError.ForeColor = Color.White;
                highContrast = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Declaring settings page
            var frmToSettings = new frmSettingsRedo();
            //Settings page will open in same location
            frmToSettings.Location = this.Location;
            frmToSettings.StartPosition = FormStartPosition.Manual;
            //Booking page will show again when settings page is closed
            frmToSettings.FormClosing += delegate { this.Show(); };
            //settings page is shown and booking page is hidden - not completely closed
            frmToSettings.Show();
            this.Hide();
        }
    }
}
