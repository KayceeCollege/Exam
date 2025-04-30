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
    public partial class frmGreenEnergyProducts : Form
    {
        public frmGreenEnergyProducts()
        {
            InitializeComponent();
        }

        //Declare carbon footprint calculator page
        //private frmCarbonFootprintCalculator frmToCarbonFootprint = new frmCarbonFootprintCalculator();

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //Combo box, lets user choose font
            string userChosenFont = cmbFonts.Text;
            //Combo box, lets user choose background colour
            string userChosenColour = cmbBackgroundColours.Text;
            //Lets user choose font size
            int userChosenFontSize = int.Parse(txtFontSize.Text);

            if (userChosenColour == "Pink")
            {
                txtGreenEnergyInformation.BackColor = Color.Pink; //set to pink
            }
            else if (userChosenColour == "Yellow")
            {
                txtGreenEnergyInformation.BackColor = Color.Yellow; //set to yellow
            }
            else if (userChosenColour == "Blue")
            {
                txtGreenEnergyInformation.BackColor = Color.Blue; //set to blue
            }
            else if (userChosenColour == "Cyan")
            {
                txtGreenEnergyInformation.BackColor = Color.Cyan; //set to cyan
            }
            else if (userChosenColour == "Green")
            {
                txtGreenEnergyInformation.BackColor = Color.Green; //set to green
            }
            else
            {
                MessageBox.Show("Error");
            }

            if (userChosenFont == "Arial")
            {
                txtGreenEnergyInformation.Font = new Font("Arial", userChosenFontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtGreenEnergyInformation.Font = new Font("Tahoma", userChosenFontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtGreenEnergyInformation.Font = new Font("Calibri", userChosenFontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtGreenEnergyInformation.Font = new Font("Verdana", userChosenFontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtGreenEnergyInformation.Font = new Font("Times New Roman", userChosenFontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtGreenEnergyInformation.Font = new Font("Century Gothic", userChosenFontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtGreenEnergyInformation.Font = new Font("Microsoft Sans Serif", userChosenFontSize); //set font to Microsoft Sans Serif
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            frmCarbonFootprintCalculator frmToCarbonFootprint = new frmCarbonFootprintCalculator();
            frmToCarbonFootprint.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBookingPage frmToBookingPage = new frmBookingPage();
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
