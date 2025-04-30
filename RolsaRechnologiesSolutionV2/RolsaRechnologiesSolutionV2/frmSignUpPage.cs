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

            if (usernameCount > 0) //If username >0, means username already exists
            {
                txtErrorMessage1.Text = "Username has already been taken, please try again!";
                txtErrorMessage1.Visible = true;
            }
            else
            {
                if(password1 != password2) //If password1 != password2, means passwords do not match
                {
                    //Makes sets error message and makes it visible
                    txtErrorMessage1.Text = "Both passwords do not match, please try again!";
                    txtErrorMessage1.Visible = true;
                    MessageBox.Show("Do not match");
                    grbCorrectCredentials.Enabled = false;
                }
                else
                {
                    //Makes group box visible
                    string password = password1;
                    txtErrorMessage1.Visible = false;
                    grbCorrectCredentials.Visible = true;
                    MessageBox.Show("Match");
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
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
                if (character <=0 || character >=9)
                {
                    countPhoneNumDigits = countPhoneNumDigits + 1;
                }
            }

            bool allDigits = false;

            if (countPhoneNumDigits == phoneNum.Length)
            {
                 allDigits = true; 
            }
            else
            {
                 allDigits = false;
            }

            if (countEmail == 1 && hasDotCom == ".com")
            {
                if(phoneNum.Length == 11 && allDigits == true)
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@DOB", DOB);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                    command.Parameters.AddWithValue("@Address", address);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Account has been created successfully");
                }
                else
                {
                    txtErrorMessage2.Text = "Phone number is not valid, please try again!";
                    txtErrorMessage2.Visible = false;
                }
            }
            else
            {
                txtErrorMessage2.Text = "Email is not valid, please try again!";
                txtErrorMessage2.Visible = true;
            }
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
            this.Close();
        }

        private void btnToLogIn_Click(object sender, EventArgs e)
        {
            frmLogIn frmToLogIn = new frmLogIn();
            frmToLogIn.Show();
            this.Close();
        }
    }
}