using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        //Declaring high contrast - automatically set to false
        bool highContrast = false;

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            //Buttons change colour when hovered over, only if high contrast mode is turned off
            if (highContrast == false)
            {
                btnSignUp.BackColor = Color.FromArgb(103, 173, 136);
                btnSignUp.ForeColor = Color.FromArgb(179, 214, 196);
            }
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            // When mouse moves away, sign up button will revert back to original colour
            if (highContrast == false)
            {
                btnSignUp.BackColor = Color.FromArgb(179, 214, 196);
                btnSignUp.ForeColor = Color.FromArgb(103, 173, 136);
            }
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            if (highContrast == false)
            {
                btnLogIn.BackColor = Color.FromArgb(179, 214, 196);
                btnLogIn.ForeColor = Color.FromArgb(103, 173, 136);
            }
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            if (highContrast == false)
            {
                btnLogIn.BackColor = Color.FromArgb(103, 173, 136);
                btnLogIn.ForeColor = Color.FromArgb(179, 214, 196);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Declaring sign up page
            frmSignUpPage frmSignUp = new frmSignUpPage();
            //Opening sign up, closing home page
            frmSignUp.Show();
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Declaring log in page
            frmLogIn frmLogInPage = new frmLogIn();
            //Opening log in, closing home page
            frmLogInPage.Show();
            this.Close();
        }

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            //Declaring green energy page
            frmGreenEnergyProducts frmGreenEnergyProductsPage = new frmGreenEnergyProducts();
            //Opening green energy products, closing home page
            frmGreenEnergyProductsPage.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            //Declaring carbon footprint page
            frmCarbonFootprintCalculator frmCarbonFootprintPage = new frmCarbonFootprintCalculator();
            //Opening carbon footprint, closing home page
            frmCarbonFootprintPage.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Declaring booking page
            frmBookingPage frmToBookingPage = new frmBookingPage();
            //Opening booking, closing home page
            frmToBookingPage.Show();
            this.Close();
        }

        private void btnEnergyUsage_Click(object sender, EventArgs e)
        {
            //Declaring energy usage page
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            //opening energy usage, closing home page
            frmToEnergyUsageCalculator.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Declaring settings page
            var frmToSettings = new frmSettingsRedo();
            //Settings page will open in same location
            frmToSettings.Location = this.Location;
            frmToSettings.StartPosition = FormStartPosition.Manual;
            //Home page will show again when settings page is closed
            frmToSettings.FormClosing += delegate { this.Show(); };
            //settings page is shown and home page is hidden - not completely closed
            frmToSettings.Show();
            this.Hide();
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
                btnEnergyUsage.BackColor = Color.FromArgb(103, 173, 136);
                btnSettings.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.ForeColor = Color.FromArgb(179, 214, 196);
                pbLogo.BackColor = Color.FromArgb(103, 173, 136);
                btnHighContrast.BackColor = SystemColors.Window;
                btnHighContrast.ForeColor = SystemColors.WindowText;
                lblRolsaTechnologies.BackColor = Color.FromArgb(103, 173, 136);
                lblHeader1.ForeColor = Color.FromArgb(65, 119, 91);
                lblHeader2.ForeColor = Color.FromArgb(103, 173, 136);
                lblHeader3.ForeColor = Color.White;
                btnSignUp.BackColor = Color.FromArgb(179, 214, 196);
                btnSignUp.ForeColor = Color.FromArgb(103, 173, 136);
                btnLogIn.BackColor = Color.FromArgb(103, 173, 136);
                btnLogIn.ForeColor = Color.FromArgb(179, 214, 196);
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
                btnEnergyUsage.BackColor = Color.Blue;
                btnSettings.BackColor = Color.Blue;
                lblSlogan.BackColor = Color.Blue;
                lblSlogan.ForeColor = Color.White;
                pbLogo.BackColor = Color.Blue;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                lblRolsaTechnologies.BackColor = Color.Blue;
                lblHeader1.ForeColor = Color.Black;
                lblHeader2.ForeColor = Color.Black;
                lblHeader3.ForeColor = Color.Black;
                btnSignUp.BackColor = Color.Black;
                btnSignUp.ForeColor = Color.Yellow;
                btnLogIn.BackColor = Color.Black;
                btnLogIn.ForeColor = Color.Yellow;
                highContrast = true;
            }
        }
    }
}
