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

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Declaring username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlCommand checkUsernameAndPasswordCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", sqlConnection);
            checkUsernameAndPasswordCommand.Parameters.AddWithValue("@Username", username);
            checkUsernameAndPasswordCommand.Parameters.AddWithValue("@Password", password);

            sqlConnection.Open();
            int matchingCount = (int)checkUsernameAndPasswordCommand.ExecuteScalar();
            sqlConnection.Close();

            if (matchingCount == 1)
            {
                MessageBox.Show("Logged in");
                frmHomePage frmLoggedInHomepage = new frmHomePage();
                frmLoggedInHomepage.Show();
                this.Close();
            }
            else
            {
                txtErrorMessage1.Text = "Invalid credentials entered";
                txtErrorMessage1.Show();
            }
        }

        private void btnToSignUp_Click(object sender, EventArgs e)
        {
            frmSignUpPage frmToSignUp = new frmSignUpPage();
            frmToSignUp.Show();
            this.Close();
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
            this.Close();
        }
    }
}
