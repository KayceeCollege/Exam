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

        //declaring high contrast
        bool highContrast = false;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Declaring username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlCommand checkUsernameAndPasswordCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", sqlConnection);
            //Comparing username and password to fields in the Users database
            checkUsernameAndPasswordCommand.Parameters.AddWithValue("@Username", username);
            checkUsernameAndPasswordCommand.Parameters.AddWithValue("@Password", password);

            sqlConnection.Open();
            int matchingCount = (int)checkUsernameAndPasswordCommand.ExecuteScalar();
            sqlConnection.Close();

            if (matchingCount == 1) //Means the system has found a match
            {
                txtErrorMessage1.Visible = false;
                MessageBox.Show("Logged in");
                //Declaring home page
                frmHomePage frmLoggedInHomepage = new frmHomePage();
                //Opening home page, closing log in page
                frmLoggedInHomepage.Show();
                this.Close();
            }
            else //Means the system has not found a match (or multiple which implies an error within the sign up system)
            {
                txtErrorMessage1.Text = "Invalid credentials entered";
                txtErrorMessage1.Show();
            }
        }

        private void btnToSignUp_Click(object sender, EventArgs e)
        {
            //Declaring sign up page
            frmSignUpPage frmToSignUp = new frmSignUpPage();
            //Opening sign up page, closing log in page
            frmToSignUp.Show();
            this.Close();
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
            this.Close();
        }

        private void btnHighContrast_Click(object sender, EventArgs e)
        {
            //if statement allows user to toggle between normal and high contrast
            if (highContrast == true)
            {
                //Setting all assets back to their original colours
                BackColor = SystemColors.Control;
                btnHighContrast.BackColor = SystemColors.Window;
                btnHighContrast.ForeColor = SystemColors.WindowText;
                btnToSignUp.BackColor = SystemColors.Window;
                btnToSignUp.ForeColor = SystemColors.WindowText;
                pbBackground1.BackColor = Color.FromArgb(158, 202, 179);
                pbBackground2.BackColor = Color.FromArgb(158, 202, 179);
                btnToHome.ForeColor = Color.FromArgb(103, 173, 136);
                lblLogIn.ForeColor = Color.FromArgb(158, 202, 179);
                lblUsername.ForeColor = Color.FromArgb(103, 173, 136);
                txtUsername.BackColor = SystemColors.Window;
                txtUsername.ForeColor = SystemColors.WindowText;
                lblPassword.ForeColor = Color.FromArgb(103, 173, 136);
                txtPassword.BackColor = SystemColors.Window;
                txtPassword.ForeColor = SystemColors.WindowText;
                txtErrorMessage1.BackColor = SystemColors.Window;
                txtErrorMessage1.ForeColor = SystemColors.WindowText;
                btnLogIn.BackColor = SystemColors.Window;
                btnLogIn.ForeColor = SystemColors.WindowText;
                lblNoAccount.ForeColor = Color.FromArgb(158, 202, 179);
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                btnToSignUp.BackColor = Color.Black;
                btnToSignUp.ForeColor = Color.Yellow;
                pbBackground1.BackColor = Color.Blue;
                pbBackground2.BackColor = Color.Blue;
                btnToHome.ForeColor = Color.Black;
                lblLogIn.ForeColor = Color.Black;
                lblUsername.ForeColor = Color.Black;
                txtUsername.BackColor = Color.Black;
                txtUsername.ForeColor = Color.Yellow;
                lblPassword.ForeColor = Color.Black;
                txtPassword.BackColor = Color.Black;
                txtPassword.ForeColor = Color.Yellow;
                txtErrorMessage1.BackColor = Color.Black;
                txtErrorMessage1.ForeColor = Color.Yellow;
                btnLogIn.BackColor = Color.Black;
                btnLogIn.ForeColor = Color.Yellow;
                lblNoAccount.ForeColor = Color.Black;
                highContrast = true;
            }
        }
    }
}
