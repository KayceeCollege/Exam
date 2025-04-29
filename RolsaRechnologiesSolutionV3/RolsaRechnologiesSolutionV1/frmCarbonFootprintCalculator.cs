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
    public partial class frmCarbonFootprintCalculator : Form
    {
        public frmCarbonFootprintCalculator()
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

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            //Declaring green energy page
            frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();
            //Opening green energy page, closing carbon footprint page
            frmToGreenEnergyProducts.Show();
            this.Close();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            //declaring following variables
            string electricBill, gasBill, oilBill, mileage, numFlightsUnderFour, numFlightsOverFour, recycleNewspaper, recycleAluminumTin;
            decimal calculation = 0;
            bool validInputs = true;

            //assigning all variables corresponding inputs
            electricBill = txtElectricBill.Text;
            gasBill = txtGasBill.Text;
            oilBill = txtOilBill.Text;
            mileage = txtMileage.Text;
            numFlightsUnderFour = txtNumOfFlightsUnderFour.Text;
            numFlightsOverFour = txtNumOfFlightsOverFour.Text;
            recycleNewspaper = cmbRecycleNewspaper.Text;
            recycleAluminumTin = cmbRecycleAluminumTin.Text;

            //declaring new variables used for calculations
            decimal newElectricBill, newGasBill, newOilBill;
            int newMileage, newFlightsUnderFour, newFlightsOverFour;

            //Checking if electric bill is number
            if (decimal.TryParse(electricBill, out decimal electricValue))
            {
                newElectricBill = decimal.Parse(electricBill);
                //Checking if gas bill is number
                if (decimal.TryParse(gasBill, out decimal gasValue))
                {
                    newGasBill = decimal.Parse(gasBill);
                    //Checking if oil bill is number
                    if (decimal.TryParse(oilBill, out decimal oilValue))
                    {
                        newOilBill = decimal.Parse(oilBill);
                        //Checking if mileage is whole number
                        if (int.TryParse(mileage, out int mileageValue))
                        {
                            newMileage = int.Parse(mileage);
                            //Checking if number of flights under four hours is a whole number
                            if (int.TryParse(numFlightsUnderFour, out int numFlightsUnderFourValue))
                            {
                                newFlightsUnderFour = int.Parse(numFlightsUnderFour);
                                //Checking if number of flights over four hours is a whole number
                                if (int.TryParse(numFlightsOverFour, out int numFlightsOverFourValue))
                                {
                                    newFlightsOverFour = int.Parse(numFlightsOverFour);
                                    //Checking if recycle newspaper combo box is empty
                                    if (recycleNewspaper != string.Empty)
                                    {
                                        //Checking if recycle aluminum and tin combo box is empty
                                        if (recycleAluminumTin != string.Empty)
                                        {
                                            txtErrorMessage.Hide();
                                            validInputs = true;
                                            if (validInputs == true)
                                            {
                                                //Starts calculation only if all inputs are valid 
                                                newElectricBill = newElectricBill * 105;
                                                calculation = calculation + newElectricBill;
                                                newGasBill = newGasBill * 105;
                                                calculation = calculation + newGasBill;
                                                newOilBill = newOilBill * 113;
                                                calculation = calculation + newOilBill;
                                                newMileage = (int)(newMileage * 0.79);
                                                calculation = calculation + newMileage;
                                                newFlightsUnderFour = newFlightsUnderFour * 1100;
                                                calculation = calculation + newFlightsUnderFour;
                                                newFlightsOverFour = newFlightsOverFour * 4400;
                                                calculation = calculation + newFlightsOverFour;
                                                if (recycleNewspaper == "Yes")
                                                {
                                                    //If newspaper is recycled, nothing is added to the calculation
                                                    if (recycleAluminumTin == "Yes")
                                                    {
                                                        //If aluminum and tin is recycled, nothing is added to the calculation
                                                        if (calculation >= 6000 && calculation <= 15999)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered ideal";
                                                        }
                                                        else if (calculation >= 16000 && calculation <= 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered average";
                                                        }
                                                        else if (calculation >= 0 && calculation < 6000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very low";
                                                        }
                                                        else if (calculation > 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very high";
                                                        }
                                                        else
                                                        {
                                                            txtErrorMessage.Text = "Error in calculation process";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //166 added if aluminum ans tin is not recycled
                                                        calculation = calculation + 166;
                                                        //Output for ideal carbon footprint
                                                        if (calculation >= 6000 && calculation <= 15999)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered ideal";
                                                        }
                                                        //Output for average carbon footprint
                                                        else if (calculation >= 16000 && calculation <= 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered average";
                                                        }
                                                        //Output for very low carbon footprint
                                                        else if (calculation >= 0 && calculation < 6000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very low";
                                                        }
                                                        //Output for very high carbon footprint
                                                        else if (calculation > 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very high";
                                                        }
                                                        else
                                                        {
                                                            //Error checking
                                                            txtErrorMessage.Text = "Error in calculation process";
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    //184 added to calculation if newspaper is not recycled
                                                    calculation = calculation + 184;
                                                    if (recycleAluminumTin == "Yes")
                                                    {
                                                        //Output for ideal carbon footprint
                                                        if (calculation >= 6000 && calculation <= 15999)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered ideal";
                                                        }
                                                        //Output for average carbon footprint
                                                        else if (calculation >= 16000 && calculation <= 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered average";
                                                        }
                                                        //Output for very low carbon footprint
                                                        else if (calculation >= 0 && calculation < 6000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very low";
                                                        }
                                                        //Output for very high carbon footprint
                                                        else if (calculation > 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very high";
                                                        }
                                                        else
                                                        {
                                                            //Error checking
                                                            txtErrorMessage.Text = "Error in calculation process";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //166 added if aluminum ans tin is not recycled
                                                        calculation = calculation + 166;
                                                        //Output for ideal carbon footprint
                                                        if (calculation >= 6000 && calculation <= 15999)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered ideal";
                                                        }
                                                        //Output for average carbon footprint
                                                        else if (calculation >= 16000 && calculation <= 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered average";
                                                        }
                                                        //Output for very low carbon footprint
                                                        else if (calculation >= 0 && calculation < 6000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very low";
                                                        }
                                                        //Output for very high carbon footprint
                                                        else if (calculation > 22000)
                                                        {
                                                            txtResult.Text = "Your carbon footprint = " + calculation + ", this is considered very high";
                                                        }
                                                        else
                                                        {
                                                            //Error checking
                                                            txtErrorMessage.Text = "Error in calculation process";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        //Error message if combo box is empty is empty
                                        else
                                        {
                                            txtErrorMessage.Text = "You can not leave boxes empty!";
                                            txtErrorMessage.Visible = true;
                                            validInputs = false;
                                        }
                                    }
                                    //Error message if combo box is empty is empty
                                    else
                                    {
                                        txtErrorMessage.Text = "You can not leave boxes empty!";
                                        txtErrorMessage.Visible = true;
                                        validInputs = false;
                                    }
                                }
                                //Error message if number of flights over four hours is wrong
                                else
                                {
                                    txtErrorMessage.Text = "Number of flights over four hours long must be a whole number, please try again!";
                                    txtErrorMessage.Visible = true;
                                    validInputs = false;
                                }
                            }
                            //Error message if number of flights under four hours is wrong
                            else
                            {
                                txtErrorMessage.Text = "Number of flights under four hours long must be a whole number, please try again!";
                                txtErrorMessage.Visible = true;
                                validInputs = false;
                            }
                        }
                        //Error message if mileage is wrong
                        else
                        {
                            txtErrorMessage.Text = "Mileage must be a whole number, please try again!";
                            txtErrorMessage.Visible = true;
                            validInputs = false;
                        }
                    }
                    //Error message if oil bill is wrong
                    else
                    {
                        txtErrorMessage.Text = "Oil bill must be a number, please try again!";
                        txtErrorMessage.Visible = true;
                        validInputs = false;
                    }
                }
                //Error message if gas bill is wrong
                else
                {
                    txtErrorMessage.Text = "Gas bill must be a number, please try again!";
                    txtErrorMessage.Visible = true;
                    validInputs = false;
                }
            }
            //Error message if electric bill is wrong
            else
            {
                txtErrorMessage.Text = "Electric bill must be a number, please try again!";
                txtErrorMessage.Visible = true;
                validInputs = false;
            }
        }

        private void btnToHome_Click(object sender, EventArgs e)
        {
            //Declaring home page
            frmHomePage frmToHomePage = new frmHomePage();
            //Opening home page, closing carbon footprint page
            frmToHomePage.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            //Declaring booking page
            frmBookingPage frmToBookingPage = new frmBookingPage();
            //Opening booking, closing carbon footprint page
            frmToBookingPage.Show();
            this.Close();
        }

        private void btnEnergyUsage_Click(object sender, EventArgs e)
        {
            //Declaring energy usage page
            frmEnergyUsageCalculator frmToEnergyUsageCalculator = new frmEnergyUsageCalculator();
            //Opening energy usage page, closing carbon footprint page
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
                txtCarbonFootprintInformation.Font = new Font("Arial", fontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtCarbonFootprintInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtCarbonFootprintInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtCarbonFootprintInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtCarbonFootprintInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtCarbonFootprintInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtCarbonFootprintInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
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
                    txtCarbonFootprintInformation.Font = new Font("Arial", fontSize); //set font to Arial 
                }
                else if (userChosenFont == "Tahoma")
                {
                    txtCarbonFootprintInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
                }
                else if (userChosenFont == "Calibri")
                {
                    txtCarbonFootprintInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
                }
                else if (userChosenFont == "Verdana")
                {
                    txtCarbonFootprintInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
                }
                else if (userChosenFont == "Times New Roman")
                {
                    txtCarbonFootprintInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
                }
                else if (userChosenFont == "Century Gothic")
                {
                    txtCarbonFootprintInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
                }
                else if (userChosenFont == "Microsoft Sans Serif")
                {
                    txtCarbonFootprintInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
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
                txtCarbonFootprintInformation.Font = new Font("Arial", fontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtCarbonFootprintInformation.Font = new Font("Tahoma", fontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtCarbonFootprintInformation.Font = new Font("Calibri", fontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtCarbonFootprintInformation.Font = new Font("Verdana", fontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtCarbonFootprintInformation.Font = new Font("Times New Roman", fontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtCarbonFootprintInformation.Font = new Font("Century Gothic", fontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtCarbonFootprintInformation.Font = new Font("Microsoft Sans Serif", fontSize); //set font to Microsoft Sans Serif
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
                txtCarbonFootprintInformation.BackColor = SystemColors.Window;
                txtCarbonFootprintInformation.ForeColor = SystemColors.WindowText;
                pbNavbar.BackColor = Color.FromArgb(103, 173, 136);
                btnGreenEnergyProducts.BackColor = Color.FromArgb(103, 173, 136);
                pbCarbonFootprint.BackColor = Color.FromArgb(103, 173, 136);
                btnBooking.BackColor = Color.FromArgb(103, 173, 136);
                btnEnergyUsage.BackColor = Color.FromArgb(103, 173, 136);
                btnSettings.BackColor = Color.FromArgb(103, 173, 136);
                btnToHome.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.BackColor = Color.FromArgb(103, 173, 136);
                lblSlogan.ForeColor = Color.FromArgb(179, 214, 196);
                pbLogo.BackColor = Color.FromArgb(103, 173, 136);
                lblHowToReduceCarbonFootprint.ForeColor = Color.White;
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
                //Group Box
                grbCarbonFootprintCalculator.BackColor = SystemColors.Window;
                grbCarbonFootprintCalculator.ForeColor = Color.FromArgb(103, 173, 136);
                lblElectricBill.ForeColor = Color.FromArgb(103, 173, 136);
                txtElectricBill.BackColor = SystemColors.Window;
                txtElectricBill.ForeColor = SystemColors.WindowText;
                lblGasBill.ForeColor = Color.FromArgb(103, 173, 136);
                txtGasBill.BackColor = SystemColors.Window;
                txtGasBill.ForeColor = SystemColors.WindowText;
                lblOilBill.ForeColor = Color.FromArgb(103, 173, 136);
                txtOilBill.BackColor = SystemColors.Window;
                txtOilBill.ForeColor = SystemColors.WindowText;
                lblNumOfFlightsUnderFour.ForeColor = Color.FromArgb(103, 173, 136);
                txtNumOfFlightsUnderFour.BackColor = SystemColors.Window;
                txtNumOfFlightsUnderFour.ForeColor = SystemColors.WindowText;
                lblNumOfFlightsOverFour.ForeColor = Color.FromArgb(103, 173, 136);
                txtNumOfFlightsOverFour.BackColor = SystemColors.Window;
                txtNumOfFlightsOverFour.ForeColor = SystemColors.WindowText;
                lblRecycleNewspaper.ForeColor = Color.FromArgb(103, 173, 136);
                cmbRecycleNewspaper.BackColor = SystemColors.Window;
                cmbRecycleNewspaper.ForeColor = SystemColors.WindowText;
                lblRecycleAluminumTin.ForeColor = Color.FromArgb(103, 173, 136);
                cmbRecycleAluminumTin.BackColor = SystemColors.Window;
                cmbRecycleAluminumTin.ForeColor = SystemColors.WindowText;
                btnGetResult.BackColor = SystemColors.Window;
                btnGetResult.ForeColor = Color.FromArgb(103, 173, 136);
                highContrast = false;
            }
            else
            {
                //Changing the colours of all assets to brighter colours (blue, yellow, black, white)
                BackColor = Color.Yellow;
                txtCarbonFootprintInformation.BackColor = Color.Black;
                txtCarbonFootprintInformation.ForeColor = Color.Yellow;
                pbNavbar.BackColor = Color.Blue;
                btnGreenEnergyProducts.BackColor = Color.Blue;
                pbCarbonFootprint.BackColor = Color.Blue;
                btnBooking.BackColor = Color.Blue;
                btnEnergyUsage.BackColor = Color.Blue;
                btnSettings.BackColor = Color.Blue;
                btnToHome.BackColor = Color.Blue;
                lblSlogan.BackColor = Color.Blue;
                lblSlogan.ForeColor = Color.White;
                pbLogo.BackColor = Color.Blue;
                lblHowToReduceCarbonFootprint.ForeColor = Color.Black;
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
                //Group Box
                grbCarbonFootprintCalculator.BackColor = Color.Blue;
                grbCarbonFootprintCalculator.ForeColor = Color.White;
                lblElectricBill.ForeColor = Color.White;
                txtElectricBill.BackColor = Color.White;
                txtElectricBill.ForeColor = Color.Black;
                lblGasBill.ForeColor = Color.White;
                txtGasBill.BackColor = Color.White;
                txtGasBill.ForeColor = Color.Black;
                lblOilBill.ForeColor = Color.White;
                txtOilBill.BackColor = Color.White;
                txtOilBill.ForeColor = Color.Black;
                lblNumOfFlightsUnderFour.ForeColor = Color.White;
                txtNumOfFlightsUnderFour.BackColor = Color.White;
                txtNumOfFlightsUnderFour.ForeColor = Color.Black;
                lblNumOfFlightsOverFour.ForeColor = Color.White;
                txtNumOfFlightsOverFour.BackColor = Color.White;
                txtNumOfFlightsOverFour.ForeColor = Color.Black;
                lblRecycleNewspaper.ForeColor = Color.White;
                cmbRecycleNewspaper.BackColor = Color.White;
                cmbRecycleNewspaper.ForeColor = Color.Black;
                lblRecycleAluminumTin.ForeColor = Color.White;
                cmbRecycleAluminumTin.BackColor = Color.White;
                cmbRecycleAluminumTin.ForeColor = Color.Black;
                btnGetResult.BackColor = Color.White;
                btnGetResult.ForeColor = Color.Black;
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
            //Carbon footprint page will show again when settings page is closed
            frmToSettings.FormClosing += delegate { this.Show(); };
            //settings page is shown and carbon footprint page is hidden - not completely closed
            frmToSettings.Show();
            this.Hide();
        }
    }
}