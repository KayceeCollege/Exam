using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmEnergyUsageCalculator : Form
    {
        public frmEnergyUsageCalculator()
        {
            InitializeComponent();
        }

        //declaring high contrast
        bool highContrast = false;

        private void btnToHome_Click(object sender, EventArgs e)
        {
            //Declaring home page
            frmHomePage frmToHomePage = new frmHomePage();
            //Opening home page, closing energy usage page 
            frmToHomePage.Show();
            this.Close();
        }

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            //Declaring green energy page
            frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();
            //Opening green energy page, closing energy usage page 
            frmToGreenEnergyProducts.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            //Declaring carbon footprint page
            frmCarbonFootprintCalculator frmToCarbonFootprintCalculator = new frmCarbonFootprintCalculator();
            //Opening carbon footprint page, closing energy usage page 
            frmToCarbonFootprintCalculator.Show();
            this.Close();  
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Declaring booking page
            frmBookingPage frmToBookingPage = new frmBookingPage();
            //Opening booking page, closing energy usage page 
            frmToBookingPage.Show();
            this.Close();
        }

        //declaring variables used for calculation
        double calculation = 0;
        double tempCalculation = 0;

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            //declaring variables and assigning corresponding inputs
            string appliance = txtAppliance.Text;
            string power = txtPower.Text;
            string hours = txtHoursUsed.Text;

            //making list of appliances visible and adding input
            txtListedAppliances.Visible = true;
            txtListedAppliances.AppendText(appliance + ", ");

            //Checking if power is a double
            if (double.TryParse(power, out double powerValue))
            {
                //declaring newPower and making it equal to power, converted to a double
                double newPower = double.Parse(power);
                //Checking if hours is a double
                if (double.TryParse(hours, out double hoursValue))
                {
                    //declaring newHours and making it equal to hours, converted to a double
                    double newHours = double.Parse(hours);
                    //multiplying power by hours
                    tempCalculation = newPower * newHours;
                    //adding the calculation into the overall calculation variable
                    calculation = calculation + tempCalculation;
                    //Clearing inputs
                    txtAppliance.Clear();
                    txtPower.Clear();
                    txtHoursUsed.Clear();
                }
                else
                {
                    //Error if hours isn't an integer/double
                    txtError.Text = "Please ensure that hours is a number";
                }
            }
            else
            {
                //Error if power isn't an integer/double
                txtError.Text = "Please ensure that power is a number";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Executes same code as btnAddAnother to ensure final input has been added to calculation
            string appliance = txtAppliance.Text;
            string power = txtPower.Text;
            string hours = txtHoursUsed.Text;

            txtListedAppliances.Visible = true;
            txtListedAppliances.AppendText(appliance + ", ");

            if (double.TryParse(power, out double powerValue))
            {
                double newPower = double.Parse(power);
                if (double.TryParse(hours, out double hoursValue))
                {
                    double newHours = double.Parse(hours);
                    tempCalculation = newPower * newHours;
                    calculation = calculation + tempCalculation;
                    double overallCalculation = calculation;
                    //Outputs final result in result text box
                    txtResult.Text = "Your overall energy consumption is, " + calculation + "kWh";

                    //Declaring database
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //Calling the 'CreateNewUserRecord' procedure
                    SqlCommand command = new SqlCommand("CreateNewEnergyUsageRecord", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    //Ensures only date is being stored from DateTime
                    string date = DateTime.Now.ToShortDateString();
                    //Get's the users username - would be carried over from log in but ran out of time
                    string username = txtUsername.Text;

                    //Adds parameters to the EnergyUsage database
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Result", overallCalculation);
                    command.Parameters.AddWithValue("@Date", date);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    
                }
                else
                {
                    //Error if hours isn't an integer/double
                    txtError.Text = "Please ensure that hours is a number";
                }
            }
            else
            {
                //Error if power isn't an integer/double
                txtError.Text = "Please ensure that power is a number";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                //Getting usernames from EnergyUsage database
                command.CommandText = "SELECT Username FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    txtUsernames.Text += reader["Username"].ToString() + Environment.NewLine; //Outputting all usernames on their own line in the usernames text box
                }
                connection.Close();
            }

            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                //Getting results from EnergyUsage database
                command.CommandText = "SELECT Result FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        txtResults.Text += reader["Result"].ToString() + Environment.NewLine; //Outputting all results on their own line in the results text box
                }
                connection.Close();
            }

            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                //Getting dates from EnergyUsage database
                command.CommandText = "SELECT Date FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        txtDates.Text += reader["Date"].ToString() + Environment.NewLine; //Outputting all dates on their own line in the results text box
                }
                connection.Close();
            }
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
                btnBooking.BackColor = Color.FromArgb(103, 173, 136);
                pbEnergyUsageCalculator.BackColor = Color.FromArgb(103, 173, 136);
                btnSettings.BackColor = Color.FromArgb(103, 173, 136);
                btnToHome.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.ForeColor = Color.FromArgb(179, 214, 196);
                pbLogo.BackColor = Color.FromArgb(103, 173, 136);
                btnHighContrast.BackColor = SystemColors.Window;
                btnHighContrast.ForeColor = SystemColors.WindowText;
                txtError.BackColor = SystemColors.Window;
                txtError.ForeColor = SystemColors.WindowText;
                lblEnergyUsageCalculator.ForeColor = Color.White;
                txtError.BackColor = SystemColors.Window;
                txtError.ForeColor = SystemColors.WindowText;
                grbCalculation.BackColor = SystemColors.Window;
                lblUsername.ForeColor = Color.Black;
                lblAppliance.ForeColor = Color.Black;
                lblPower.ForeColor = Color.Black;
                lblHoursUsed.ForeColor = Color.Black;
                lblOr.ForeColor = Color.Black;
                txtListedAppliances.BackColor = SystemColors.Window;
                txtListedAppliances.ForeColor = SystemColors.WindowText;
                btnUpdate.BackColor = SystemColors.Window;
                btnUpdate.ForeColor = SystemColors.WindowText;
                txtUsernames.BackColor = SystemColors.Window;
                txtUsernames.ForeColor = SystemColors.WindowText;
                txtResults.BackColor = SystemColors.Window;
                txtResults.ForeColor = SystemColors.WindowText;
                txtDates.BackColor = SystemColors.Window;
                txtDates.ForeColor = SystemColors.WindowText;
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                pbNavbar.BackColor = Color.Blue;
                btnGreenEnergyProducts.BackColor = Color.Blue;
                btnCarbonFootprint.BackColor = Color.Blue;
                btnBooking.BackColor = Color.Blue;
                pbEnergyUsageCalculator.BackColor = Color.Blue;
                btnSettings.BackColor = Color.Blue;
                btnToHome.BackColor = Color.Blue;
                lblSlogan.BackColor = Color.Blue;
                lblSlogan.ForeColor = Color.White;
                pbLogo.BackColor = Color.Blue;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                lblEnergyUsageCalculator.ForeColor = Color.Black;
                txtError.BackColor = Color.Black;
                txtError.ForeColor = Color.White;
                grbCalculation.BackColor = Color.Blue;
                lblUsername.ForeColor = Color.White;
                lblAppliance.ForeColor = Color.White;
                lblPower.ForeColor = Color.White;
                lblHoursUsed.ForeColor = Color.White;
                lblOr.ForeColor = Color.White;
                txtListedAppliances.BackColor = Color.Black;
                txtListedAppliances.ForeColor = Color.Yellow;
                btnUpdate.BackColor = Color.Black;
                btnUpdate.ForeColor = Color.Yellow;
                txtUsernames.BackColor = Color.Black;
                txtUsernames.ForeColor = Color.Yellow;
                txtResults.BackColor = Color.Black;
                txtResults.ForeColor = Color.Yellow;
                txtDates.BackColor = Color.Black;
                txtDates.ForeColor = Color.Yellow;
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
            //Energy usage page will show again when settings page is closed
            frmToSettings.FormClosing += delegate { this.Show(); };
            //Energy usage page is shown and booking page is hidden - not completely closed
            frmToSettings.Show();
            this.Hide();
        }
    }
}
