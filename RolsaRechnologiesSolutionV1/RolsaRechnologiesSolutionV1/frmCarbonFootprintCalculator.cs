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
        }

        //Declare green energy producuts page
        private frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();

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
                txtCarbonFootprintInformation.BackColor = Color.Pink; //set to pink
            }
            else if (userChosenColour == "Yellow")
            {
                txtCarbonFootprintInformation.BackColor = Color.Yellow; //set to yellow
            }
            else if (userChosenColour == "Blue")
            {
                txtCarbonFootprintInformation.BackColor = Color.Blue; //set to blue
            }
            else if (userChosenColour == "Cyan")
            {
                txtCarbonFootprintInformation.BackColor = Color.Cyan; //set to cyan
            }
            else if (userChosenColour == "Green")
            {
                txtCarbonFootprintInformation.BackColor = Color.Green; //set to green
            }
            else
            {
                MessageBox.Show("Error");
            }

            if (userChosenFont == "Arial")
            {
                txtCarbonFootprintInformation.Font = new Font("Arial", userChosenFontSize); //set font to Arial 
            }
            else if (userChosenFont == "Tahoma")
            {
                txtCarbonFootprintInformation.Font = new Font("Tahoma", userChosenFontSize); //set font to Tahoma
            }
            else if (userChosenFont == "Calibri")
            {
                txtCarbonFootprintInformation.Font = new Font("Calibri", userChosenFontSize); //set font to Calibri
            }
            else if (userChosenFont == "Verdana")
            {
                txtCarbonFootprintInformation.Font = new Font("Verdana", userChosenFontSize); //set font to Verdana
            }
            else if (userChosenFont == "Times New Roman")
            {
                txtCarbonFootprintInformation.Font = new Font("Times New Roman", userChosenFontSize); //set font to Times New Roman
            }
            else if (userChosenFont == "Century Gothic")
            {
                txtCarbonFootprintInformation.Font = new Font("Century Gothic", userChosenFontSize); //set font to Century Gothic
            }
            else if (userChosenFont == "Microsoft Sans Serif")
            {
                txtCarbonFootprintInformation.Font = new Font("Microsoft Sans Serif", userChosenFontSize); //set font to Microsoft Sans Serif
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnGreenEnergyProducts_Click(object sender, EventArgs e)
        {
            frmGreenEnergyProducts frmToGreenEnergyProducts = new frmGreenEnergyProducts();
            frmToGreenEnergyProducts.Show();
            this.Close();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            string electricBill, gasBill, oilBill, mileage, numFlightsUnderFour, numFlightsOverFour, recycleNewspaper, recycleAluminumTin;
            decimal calculation = 0;
            bool validInputs = true;

            electricBill = txtElectricBill.Text;
            gasBill = txtGasBill.Text;
            oilBill = txtOilBill.Text;
            mileage = txtMileage.Text;
            numFlightsUnderFour = txtNumOfFlightsUnderFour.Text;
            numFlightsOverFour = txtNumOfFlightsOverFour.Text;
            recycleNewspaper = cmbRecycleNewspaper.Text;
            recycleAluminumTin = cmbRecycleAluminumTin.Text;

            decimal newElectricBill, newGasBill, newOilBill;
            int newMileage, newFlightsUnderFour, newFlightsOverFour;

            //Checking if electric bill is number
            if (decimal.TryParse(electricBill, out decimal electricValue)){
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
                                                    if (recycleAluminumTin == "Yes")
                                                    {
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
                                                        calculation = calculation + 166;
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
                                                }
                                                else
                                                {
                                                    calculation = calculation + 184;
                                                    if (recycleAluminumTin == "Yes")
                                                    {
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
                                                        calculation = calculation + 166;
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
            frmHomePage frmToHomePage = new frmHomePage();
            frmToHomePage.Show();
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
