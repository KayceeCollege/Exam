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

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
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
            frmCarbonFootprintCalculator frmToCarbonFootprintCalculator = new frmCarbonFootprintCalculator();
            frmToCarbonFootprintCalculator.Show();
            this.Close();  
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBookingPage frmToBookingPage = new frmBookingPage();
            frmToBookingPage.Show();
            this.Close();
        }

        double calculation = 0;
        double tempCalculation = 0;

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
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
                    txtAppliance.Clear();
                    txtPower.Clear();
                    txtHoursUsed.Clear();
                }
                else
                {
                    txtError.Text = "Please ensure that hours is a number";
                }
            }
            else
            {
                txtError.Text = "Please ensure that power is a number";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
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
                    txtResult.Text = "Your overall energy consumption is, " + calculation + "kWh";

                    //Declaring database
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //Calling the 'CreateNewUserRecord' procedure
                    SqlCommand command = new SqlCommand("CreateNewEnergyUsageRecord", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    string date = DateTime.Now.ToShortDateString();
                    string username = txtUsername.Text;

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Result", overallCalculation);
                    command.Parameters.AddWithValue("@Date", date);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    
                }
                else
                {
                    txtError.Text = "Please ensure that hours is a number";
                }
            }
            else
            {
                txtError.Text = "Please ensure that power is a number";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Username FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    txtUsernames.Text += reader["Username"].ToString() + Environment.NewLine;
                }
                connection.Close();
            }

            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Result FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        txtResults.Text += reader["Result"].ToString() + Environment.NewLine;
                }
                connection.Close();
            }

            using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30"))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Date FROM EnergyUsage";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        txtDates.Text += reader["Date"].ToString() + Environment.NewLine;
                }
                connection.Close();
            }
        }
    }
}
