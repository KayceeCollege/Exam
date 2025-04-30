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

        // When hovered, sign up button will change colour
        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.FromArgb(103, 173, 136);
            btnSignUp.ForeColor = Color.FromArgb(179, 214, 196);
        }

        // When mouse moves away, sign up button will revert back to original colour
        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.FromArgb(179, 214, 196);
            btnSignUp.ForeColor = Color.FromArgb(103, 173, 136);
        }

        // When hovered, log in button will change colour
        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.FromArgb(179, 214, 196);
            btnLogIn.ForeColor = Color.FromArgb(103, 173, 136);
        }

        // When mouse moves away, log in button will revert back to original colour
        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.FromArgb(103, 173, 136);
            btnLogIn.ForeColor = Color.FromArgb(179, 214, 196);
        }

        //Opening sign up page
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
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            frmToEnergyUsageCalculator.Show();
            this.Close();
        }
    }
}
