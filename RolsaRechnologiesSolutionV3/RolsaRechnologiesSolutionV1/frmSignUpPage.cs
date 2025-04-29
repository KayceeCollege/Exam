using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmSignUpPage : Form
    {
        public frmSignUpPage()
        {
            InitializeComponent();

        }

        bool highContrast = false;

        private void btnCheckCredentials_Click(object sender, EventArgs e)
        {
            //Declaring database
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Declaring username and passwords
            string username = txtUsername.Text;
            string password1 = txtPassword.Text;
            string password2 = txtConfirmPassword.Text;

            //Creating new command to search through stored usernames
            SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", sqlConnection);
            checkUsernameCommand.Parameters.AddWithValue("@Username", username);

            //Opening database connection
            sqlConnection.Open();
            int usernameCount = (int)checkUsernameCommand.ExecuteScalar();
            //Closing database connection
            sqlConnection.Close();

            //Ensuring inputs can not be null
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)) 
            {
                txtErrorMessage1.Text = "Username and password can not be empty, please try again!";
                txtErrorMessage1.Visible = true;
                grbCorrectCredentials.Visible = false;
            }
            else
            {
                if (usernameCount > 0) //If username >0, means username already exists
                {
                    txtErrorMessage1.Text = "Username has already been taken, please try again!";
                    txtErrorMessage1.Visible = true;
                    grbCorrectCredentials.Visible = false;
                }
                else
                {
                    if (password1 != password2) //If password1 != password2, means passwords do not match
                    {
                        //Makes sets error message and makes it visible
                        txtErrorMessage1.Text = "Both passwords do not match, please try again!";
                        txtErrorMessage1.Visible = true;
                        grbCorrectCredentials.Enabled = false;
                        grbCorrectCredentials.Visible = false;
                    }
                    else
                    {
                        //Makes group box visible
                        string password = password1;
                        txtErrorMessage1.Visible = false;
                        grbCorrectCredentials.Visible = true;
                        txtUsername.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                        txtConfirmPassword.ReadOnly = true;
                    }
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhoneNum.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                txtErrorMessage2.Text = "An account can not be created without these details, please try again!";
                txtErrorMessage2.Visible = true;
            }
            else
            {
                //Declaring database again
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\EXAM1011\\OneDrive - Middlesbrough College\\Exams\\Task 2\\RolsaRechnologiesSolutionV1\\RolsaTechDBRedo.mdf\";Integrated Security=True;Connect Timeout=30";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Calling the 'CreateNewUserRecord' procedure
                SqlCommand command = new SqlCommand("CreateNewUserRecord", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string DOB = dtpDOB.Text;
                string email = txtEmail.Text;
                string phoneNum = txtPhoneNum.Text;
                string address = txtAddress.Text;

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
                foreach (char character in phoneNum)
                {
                    if (character <= 0 || character >= 9)
                    {
                        countPhoneNumDigits = countPhoneNumDigits + 1;
                    }
                }

                bool allDigits = false;

                if (countPhoneNumDigits == phoneNum.Length)
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
                    if (phoneNum.Length == 11 && allDigits == true)
                    {
                        //Adding all values to database
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                        command.Parameters.AddWithValue("@Address", address);

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        txtErrorMessage2.Visible = false;
                        MessageBox.Show("Account has been created successfully");
                        frmHomePage frmToHome = new frmHomePage();
                        frmToHome.Show();
                        this.Close();
                    }
                    else
                    {
                        //Show if phone num is not valid
                        txtErrorMessage2.Text = "Phone number is not valid, please try again!";
                        txtErrorMessage2.Visible = true;
                    }
                }
                else
                {
                    //Show if email is not valid 
                    txtErrorMessage2.Text = "Email is not valid, please try again!";
                    txtErrorMessage2.Visible = true;
                }
            }
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            //Declaring home page
            frmHomePage frmToHomePage = new frmHomePage();
            //Opening home page, closing sign up page
            frmToHomePage.Show();
            this.Close();
        }

        private void btnToLogIn_Click(object sender, EventArgs e)
        {
            //Declaring log in page
            frmLogIn frmToLogIn = new frmLogIn();
            //Opening home page, closing sign up page
            frmToLogIn.Show();
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
                btnToLogIn.BackColor = SystemColors.Window;
                btnToLogIn.ForeColor = SystemColors.WindowText;
                pbBackground1.BackColor = Color.FromArgb(158, 202, 179);
                pbBackground2.BackColor = Color.FromArgb(158, 202, 179);
                btnToHome.ForeColor = Color.FromArgb(103, 173, 136);
                lblSignUp.ForeColor = Color.FromArgb(158, 202, 179);
                lblUsername.ForeColor = Color.FromArgb(103, 173, 136);
                txtUsername.BackColor = SystemColors.Window;
                txtUsername.ForeColor = SystemColors.WindowText;
                lblPassword.ForeColor = Color.FromArgb(103, 173, 136);
                txtPassword.BackColor = SystemColors.Window;
                txtPassword.ForeColor = SystemColors.WindowText;
                lblConfirmPassword.ForeColor = Color.FromArgb(103, 173, 136);
                txtConfirmPassword.BackColor = SystemColors.Window;
                txtConfirmPassword.ForeColor = SystemColors.WindowText;
                btnCheckCredentials.BackColor = SystemColors.Window;
                btnCheckCredentials.ForeColor = SystemColors.WindowText;
                txtErrorMessage1.BackColor = SystemColors.Window;
                txtErrorMessage1.ForeColor = SystemColors.WindowText;
                //Group box
                lblDOB.ForeColor = Color.FromArgb(103, 173, 136);
                dtpDOB.CalendarMonthBackground = SystemColors.Window;
                dtpDOB.CalendarForeColor = SystemColors.WindowText;
                lblEmail.ForeColor = Color.FromArgb(103, 173, 136);
                txtEmail.BackColor = SystemColors.Window;
                txtEmail.ForeColor = SystemColors.WindowText;
                lblPhoneNum.ForeColor = Color.FromArgb(103, 173, 136);
                txtPhoneNum.BackColor = SystemColors.Window;
                txtPhoneNum.ForeColor = SystemColors.WindowText;
                lblAddress.ForeColor = Color.FromArgb(103, 173, 136);
                txtAddress.BackColor = SystemColors.Window;
                txtAddress.ForeColor = SystemColors.WindowText;
                btnCreateAccount.BackColor = SystemColors.Window;
                btnCreateAccount.ForeColor = SystemColors.WindowText;
                txtErrorMessage2.BackColor = SystemColors.Window;
                txtErrorMessage2.ForeColor = SystemColors.WindowText;
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                btnToLogIn.BackColor = Color.Black;
                btnToLogIn.ForeColor = Color.Yellow;
                pbBackground1.BackColor = Color.Blue;
                pbBackground2.BackColor = Color.Blue;
                btnToHome.ForeColor = Color.Black;
                lblSignUp.ForeColor = Color.Black;
                lblUsername.ForeColor = Color.Black;
                txtUsername.BackColor = Color.Black;
                txtUsername.ForeColor = Color.Yellow;
                lblPassword.ForeColor = Color.Black;
                txtPassword.BackColor = Color.Black;
                txtPassword.ForeColor = Color.Yellow; 
                lblConfirmPassword.ForeColor = Color.Black;
                txtConfirmPassword.BackColor = Color.Black;
                txtConfirmPassword.ForeColor = Color.Yellow;
                btnCheckCredentials.BackColor = Color.Black;
                btnCheckCredentials.ForeColor = Color.Yellow;
                txtErrorMessage1.BackColor = Color.Black;
                txtErrorMessage1.ForeColor = Color.Yellow;
                //Group Box
                lblDOB.ForeColor = Color.Black;
                dtpDOB.CalendarMonthBackground = Color.Black;
                dtpDOB.CalendarForeColor = Color.Yellow;
                lblEmail.ForeColor = Color.Black;
                txtEmail.BackColor = Color.Black;
                txtEmail.ForeColor = Color.Yellow;
                lblPhoneNum.ForeColor = Color.Black;
                txtPhoneNum.BackColor = Color.Black;
                txtPhoneNum.ForeColor = Color.Yellow;
                lblAddress.ForeColor = Color.Black;
                txtAddress.BackColor = Color.Black;
                txtAddress.ForeColor = Color.Yellow;
                btnCreateAccount.BackColor = Color.Black;
                btnCreateAccount.ForeColor = Color.Yellow;
                txtErrorMessage2.BackColor = Color.Black;
                txtErrorMessage2.ForeColor = Color.Yellow;
                highContrast = true;
            }
        }
    }
}