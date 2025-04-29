using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RolsaRechnologiesSolutionV1
{
    public partial class frmGreenEnergyProducts : Form
    {
        public frmGreenEnergyProducts()
        {
            InitializeComponent();
            //Combo box variable automatically set to sans serif
            cmbFonts.SelectedItem = "Microsoft Sans Serif";
            //font size automatically displayed in text box when page is opened
            txtTextSize.Text = fontSize.ToString();
        }

        //setting default font size to 8
        int fontSize = 8;
        //declaring high contrast
        bool highContrast = false;

        private void btnToHome_Click(object sender, EventArgs e)
        {
            //Declaring home page
            frmHomePage frmToHomePage = new frmHomePage();
            //Opening home, closing green energy page
            frmToHomePage.Show();
            this.Close();
        }

        private void btnCarbonFootprint_Click(object sender, EventArgs e)
        {
            //Declaring carbon footprint page
            frmCarbonFootprintCalculator frmToCarbonFootprint = new frmCarbonFootprintCalculator();
            //opening carbon footprint page, closing green energy page
            frmToCarbonFootprint.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Declaring booking page
            frmBookingPage frmToBookingPage = new frmBookingPage();
            //opening booking page, closing green energy page
            frmToBookingPage.Show();
            this.Close();  
        }

        private void btnEnergyUsage_Click(object sender, EventArgs e)
        {
            //Declaring energy usage page
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            //opening energy usage page, closing green energy page
            frmToEnergyUsageCalculator.Show();
            this.Close();
        }

        //Happens as soon as combo box value is changed
        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setting user chosen font to font chosen in combo box
            string userChosenFont = cmbFonts.Text;

            if (userChosenFont == "Arial")
            {
                txtGreenEnergyInformation.Font = new Font("Arial", fontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtGreenEnergyInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtGreenEnergyInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtGreenEnergyInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtGreenEnergyInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtGreenEnergyInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtGreenEnergyInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
            }
            else
            {
                //Error checking
                MessageBox.Show("Error");
            }
        }

        private void btnLowerFont_Click(object sender, EventArgs e)
        {
            //setting user chosen font to font chosen in combo box - "Font()" requires 2 parameteres, so font is required to change text size
            string userChosenFont = cmbFonts.Text;

            //Ensuring font size does not go below 1
            if (fontSize <= 1)
            {
                MessageBox.Show("Your font size can not be below 1");
            }
            else
            {
                //Subtracts 1 from font size
                fontSize = fontSize - 1;
                //displaying font size in text box 
                txtTextSize.Text = fontSize.ToString();
                if (userChosenFont == "Arial")
                {
                    txtGreenEnergyInformation.Font = new Font("Arial", fontSize); //set font to Arial 
                }
                else if (userChosenFont == "Tahoma")
                {
                    txtGreenEnergyInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
                }
                else if (userChosenFont == "Calibri")
                {
                    txtGreenEnergyInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
                }
                else if (userChosenFont == "Verdana")
                {
                    txtGreenEnergyInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
                }
                else if (userChosenFont == "Times New Roman")
                {
                    txtGreenEnergyInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
                }
                else if (userChosenFont == "Century Gothic")
                {
                    txtGreenEnergyInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
                }
                else if (userChosenFont == "Microsoft Sans Serif")
                {
                    txtGreenEnergyInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
                }
                else
                {
                    //Error checking
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnRaiseFont_Click(object sender, EventArgs e)
        {
            string userChosenFont = cmbFonts.Text;
            //Adding 1 to font size
            fontSize = fontSize + 1;
            //displaying font size in text box 
            txtTextSize.Text = fontSize.ToString();
            if (userChosenFont == "Arial")
            {
                txtGreenEnergyInformation.Font = new Font("Arial", fontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtGreenEnergyInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtGreenEnergyInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtGreenEnergyInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtGreenEnergyInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtGreenEnergyInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtGreenEnergyInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnHighContrast_Click(object sender, EventArgs e)
        {
            //if statement allows user to toggle between normal and high contrast
            if (highContrast == true)
            {
                //Setting all assets back to their original colours
                BackColor = Color.FromArgb(158, 202, 179);
                txtGreenEnergyInformation.BackColor = SystemColors.Window;
                txtGreenEnergyInformation.ForeColor = SystemColors.WindowText;
                pbNavbar.BackColor = Color.FromArgb(103, 173, 136);
                pbGreenEnergyProducts.BackColor = Color.FromArgb(103, 173, 136);
                btnCarbonFootprint.BackColor = Color.FromArgb(103, 173, 136);
                btnBooking.BackColor = Color.FromArgb(103, 173, 136);
                btnEnergyUsage.BackColor = Color.FromArgb(103, 173, 136);
                btnSettings.BackColor = Color.FromArgb(103, 173, 136);
                btnToHome.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.ForeColor = Color.FromArgb(179, 214, 196);
                pbLogo.BackColor = Color.FromArgb(103, 173, 136);
                lblGreenEnergyProducts.ForeColor = Color.White;
                cmbFonts.BackColor = SystemColors.Window;
                cmbFonts.ForeColor = SystemColors.WindowText;
                btnRaiseFont.BackColor = SystemColors.Window;
                btnRaiseFont.ForeColor = SystemColors.WindowText;
                btnLowerFont.BackColor = SystemColors.Window;
                btnLowerFont.ForeColor = SystemColors.WindowText;
                btnHighContrast.BackColor = SystemColors.Window;
                btnHighContrast.ForeColor = SystemColors.WindowText;
                txtTextSize.BackColor = SystemColors.Window;
                txtTextSize.ForeColor = SystemColors.WindowText;
                lblChangeFont.BackColor = Color.FromArgb(158, 202, 179);
                lblChangeFont.ForeColor = Color.White;
                lblTextSize.BackColor = Color.FromArgb(158, 202, 179);
                lblTextSize.ForeColor = Color.White;
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                txtGreenEnergyInformation.BackColor = Color.Black;
                txtGreenEnergyInformation.ForeColor = Color.Yellow;
                pbNavbar.BackColor = Color.Blue;
                pbGreenEnergyProducts.BackColor = Color.Blue;
                btnCarbonFootprint.BackColor = Color.Blue;
                btnBooking.BackColor = Color.Blue;
                btnEnergyUsage.BackColor = Color.Blue;
                btnSettings.BackColor = Color.Blue;
                btnToHome.BackColor = Color.Blue;
                lblSlogan.BackColor = Color.Blue;
                lblSlogan.ForeColor = Color.White;
                pbLogo.BackColor = Color.Blue;
                lblGreenEnergyProducts.ForeColor = Color.Black;
                cmbFonts.BackColor = Color.Black;
                cmbFonts.ForeColor = Color.Yellow;
                btnRaiseFont.BackColor = Color.Black;
                btnRaiseFont.ForeColor = Color.Yellow;
                btnLowerFont.BackColor = Color.Black;
                btnLowerFont.ForeColor = Color.Yellow;
                btnHighContrast.BackColor = Color.Black;
                btnHighContrast.ForeColor = Color.Yellow;
                txtTextSize.BackColor = Color.Black;
                txtTextSize.ForeColor = Color.Yellow;
                lblChangeFont.BackColor = Color.Black;
                lblChangeFont.ForeColor = Color.Yellow;
                lblTextSize.BackColor = Color.Black;
                lblTextSize.ForeColor = Color.Yellow;
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
            //Green energy page will show again when settings page is closed
            frmToSettings.FormClosing += delegate { this.Show(); };
            //settings page is shown and green energy page is hidden - not completely closed
            frmToSettings.Show();
            this.Hide();
        }
    }
}
