namespace RolsaRechnologiesSolutionV1
{
    partial class frmEnergyUsageCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnergyUsageCalculator));
            this.pbNavbar = new System.Windows.Forms.PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCarbonFootprint = new System.Windows.Forms.Button();
            this.btnGreenEnergyProducts = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbEnergyUsageCalculator = new System.Windows.Forms.PictureBox();
            this.btnToHome = new System.Windows.Forms.Button();
            this.lblEnergyUsageCalculator = new System.Windows.Forms.Label();
            this.grbCalculation = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.txtHoursUsed = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtAppliance = new System.Windows.Forms.TextBox();
            this.lblHoursUsed = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblAppliance = new System.Windows.Forms.Label();
            this.txtListedAppliances = new System.Windows.Forms.TextBox();
            this.rolsaTechDBRedoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolsaTechDBRedoDataSet = new RolsaRechnologiesSolutionV1.RolsaTechDBRedoDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtDates = new System.Windows.Forms.TextBox();
            this.txtUsernames = new System.Windows.Forms.TextBox();
            this.btnHighContrast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbNavbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnergyUsageCalculator)).BeginInit();
            this.grbCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolsaTechDBRedoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolsaTechDBRedoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNavbar
            // 
            this.pbNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.pbNavbar.Location = new System.Drawing.Point(-3, -2);
            this.pbNavbar.Name = "pbNavbar";
            this.pbNavbar.Size = new System.Drawing.Size(1251, 78);
            this.pbNavbar.TabIndex = 1;
            this.pbNavbar.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(214)))), ((int)(((byte)(196)))));
            this.lblSlogan.Location = new System.Drawing.Point(63, 45);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(445, 18);
            this.lblSlogan.TabIndex = 30;
            this.lblSlogan.Text = "Powering the Future, Sustainably with Rolsa Technologies";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooking.BackgroundImage")));
            this.btnBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnBooking.Location = new System.Drawing.Point(1048, 13);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(58, 52);
            this.btnBooking.TabIndex = 29;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnSettings.Location = new System.Drawing.Point(1176, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(58, 52);
            this.btnSettings.TabIndex = 28;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCarbonFootprint
            // 
            this.btnCarbonFootprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnCarbonFootprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarbonFootprint.BackgroundImage")));
            this.btnCarbonFootprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarbonFootprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarbonFootprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnCarbonFootprint.Location = new System.Drawing.Point(984, 12);
            this.btnCarbonFootprint.Name = "btnCarbonFootprint";
            this.btnCarbonFootprint.Size = new System.Drawing.Size(58, 52);
            this.btnCarbonFootprint.TabIndex = 27;
            this.btnCarbonFootprint.UseVisualStyleBackColor = false;
            this.btnCarbonFootprint.Click += new System.EventHandler(this.btnCarbonFootprint_Click);
            // 
            // btnGreenEnergyProducts
            // 
            this.btnGreenEnergyProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnGreenEnergyProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreenEnergyProducts.BackgroundImage")));
            this.btnGreenEnergyProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreenEnergyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreenEnergyProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnGreenEnergyProducts.Location = new System.Drawing.Point(920, 12);
            this.btnGreenEnergyProducts.Name = "btnGreenEnergyProducts";
            this.btnGreenEnergyProducts.Size = new System.Drawing.Size(58, 52);
            this.btnGreenEnergyProducts.TabIndex = 26;
            this.btnGreenEnergyProducts.UseVisualStyleBackColor = false;
            this.btnGreenEnergyProducts.Click += new System.EventHandler(this.btnGreenEnergyProducts_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(-3, -2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(99, 67);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 25;
            this.pbLogo.TabStop = false;
            // 
            // pbEnergyUsageCalculator
            // 
            this.pbEnergyUsageCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.pbEnergyUsageCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pbEnergyUsageCalculator.Image")));
            this.pbEnergyUsageCalculator.Location = new System.Drawing.Point(1112, 12);
            this.pbEnergyUsageCalculator.Name = "pbEnergyUsageCalculator";
            this.pbEnergyUsageCalculator.Size = new System.Drawing.Size(58, 52);
            this.pbEnergyUsageCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnergyUsageCalculator.TabIndex = 32;
            this.pbEnergyUsageCalculator.TabStop = false;
            // 
            // btnToHome
            // 
            this.btnToHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnToHome.ForeColor = System.Drawing.Color.White;
            this.btnToHome.Location = new System.Drawing.Point(102, 6);
            this.btnToHome.Name = "btnToHome";
            this.btnToHome.Size = new System.Drawing.Size(352, 50);
            this.btnToHome.TabIndex = 36;
            this.btnToHome.Text = "Rolsa Technologies";
            this.btnToHome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnToHome.UseVisualStyleBackColor = false;
            this.btnToHome.Click += new System.EventHandler(this.btnToHome_Click);
            // 
            // lblEnergyUsageCalculator
            // 
            this.lblEnergyUsageCalculator.AutoSize = true;
            this.lblEnergyUsageCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyUsageCalculator.ForeColor = System.Drawing.Color.White;
            this.lblEnergyUsageCalculator.Location = new System.Drawing.Point(325, 79);
            this.lblEnergyUsageCalculator.Name = "lblEnergyUsageCalculator";
            this.lblEnergyUsageCalculator.Size = new System.Drawing.Size(582, 55);
            this.lblEnergyUsageCalculator.TabIndex = 47;
            this.lblEnergyUsageCalculator.Text = "Energy Usage Calculator";
            // 
            // grbCalculation
            // 
            this.grbCalculation.BackColor = System.Drawing.Color.White;
            this.grbCalculation.Controls.Add(this.txtUsername);
            this.grbCalculation.Controls.Add(this.lblUsername);
            this.grbCalculation.Controls.Add(this.txtError);
            this.grbCalculation.Controls.Add(this.txtResult);
            this.grbCalculation.Controls.Add(this.lblOr);
            this.grbCalculation.Controls.Add(this.btnCalculate);
            this.grbCalculation.Controls.Add(this.btnAddAnother);
            this.grbCalculation.Controls.Add(this.txtHoursUsed);
            this.grbCalculation.Controls.Add(this.txtPower);
            this.grbCalculation.Controls.Add(this.txtAppliance);
            this.grbCalculation.Controls.Add(this.lblHoursUsed);
            this.grbCalculation.Controls.Add(this.lblPower);
            this.grbCalculation.Controls.Add(this.lblAppliance);
            this.grbCalculation.Location = new System.Drawing.Point(25, 139);
            this.grbCalculation.Name = "grbCalculation";
            this.grbCalculation.Size = new System.Drawing.Size(503, 398);
            this.grbCalculation.TabIndex = 48;
            this.grbCalculation.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(10, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(473, 20);
            this.txtUsername.TabIndex = 12;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(10, 372);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(473, 20);
            this.txtError.TabIndex = 10;
            this.txtError.Visible = false;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(10, 346);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(473, 20);
            this.txtResult.TabIndex = 9;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(238, 301);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(18, 13);
            this.lblOr.TabIndex = 8;
            this.lblOr.Text = "Or";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(10, 317);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(473, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Get Result";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.Location = new System.Drawing.Point(10, 275);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Size = new System.Drawing.Size(473, 23);
            this.btnAddAnother.TabIndex = 6;
            this.btnAddAnother.Text = "Add Another Appliance";
            this.btnAddAnother.UseVisualStyleBackColor = true;
            this.btnAddAnother.Click += new System.EventHandler(this.btnAddAnother_Click);
            // 
            // txtHoursUsed
            // 
            this.txtHoursUsed.Location = new System.Drawing.Point(10, 249);
            this.txtHoursUsed.Name = "txtHoursUsed";
            this.txtHoursUsed.Size = new System.Drawing.Size(473, 20);
            this.txtHoursUsed.TabIndex = 5;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(10, 179);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(473, 20);
            this.txtPower.TabIndex = 4;
            // 
            // txtAppliance
            // 
            this.txtAppliance.Location = new System.Drawing.Point(10, 108);
            this.txtAppliance.Name = "txtAppliance";
            this.txtAppliance.Size = new System.Drawing.Size(473, 20);
            this.txtAppliance.TabIndex = 3;
            // 
            // lblHoursUsed
            // 
            this.lblHoursUsed.AutoSize = true;
            this.lblHoursUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursUsed.Location = new System.Drawing.Point(6, 211);
            this.lblHoursUsed.Name = "lblHoursUsed";
            this.lblHoursUsed.Size = new System.Drawing.Size(168, 24);
            this.lblHoursUsed.TabIndex = 2;
            this.lblHoursUsed.Text = "Hours Used Today";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(6, 141);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(104, 24);
            this.lblPower.TabIndex = 1;
            this.lblPower.Text = "Power (kw)";
            // 
            // lblAppliance
            // 
            this.lblAppliance.AutoSize = true;
            this.lblAppliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliance.Location = new System.Drawing.Point(6, 72);
            this.lblAppliance.Name = "lblAppliance";
            this.lblAppliance.Size = new System.Drawing.Size(95, 24);
            this.lblAppliance.TabIndex = 0;
            this.lblAppliance.Text = "Appliance";
            // 
            // txtListedAppliances
            // 
            this.txtListedAppliances.Location = new System.Drawing.Point(25, 543);
            this.txtListedAppliances.Multiline = true;
            this.txtListedAppliances.Name = "txtListedAppliances";
            this.txtListedAppliances.Size = new System.Drawing.Size(503, 144);
            this.txtListedAppliances.TabIndex = 49;
            this.txtListedAppliances.Visible = false;
            // 
            // rolsaTechDBRedoDataSetBindingSource
            // 
            this.rolsaTechDBRedoDataSetBindingSource.DataSource = this.rolsaTechDBRedoDataSet;
            this.rolsaTechDBRedoDataSetBindingSource.Position = 0;
            // 
            // rolsaTechDBRedoDataSet
            // 
            this.rolsaTechDBRedoDataSet.DataSetName = "RolsaTechDBRedoDataSet";
            this.rolsaTechDBRedoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(570, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 23);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update Database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(800, 168);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(178, 509);
            this.txtResults.TabIndex = 52;
            // 
            // txtDates
            // 
            this.txtDates.Location = new System.Drawing.Point(1028, 168);
            this.txtDates.Multiline = true;
            this.txtDates.Name = "txtDates";
            this.txtDates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDates.Size = new System.Drawing.Size(173, 509);
            this.txtDates.TabIndex = 53;
            // 
            // txtUsernames
            // 
            this.txtUsernames.Location = new System.Drawing.Point(570, 168);
            this.txtUsernames.Multiline = true;
            this.txtUsernames.Name = "txtUsernames";
            this.txtUsernames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUsernames.Size = new System.Drawing.Size(173, 509);
            this.txtUsernames.TabIndex = 54;
            // 
            // btnHighContrast
            // 
            this.btnHighContrast.Location = new System.Drawing.Point(25, 110);
            this.btnHighContrast.Name = "btnHighContrast";
            this.btnHighContrast.Size = new System.Drawing.Size(184, 23);
            this.btnHighContrast.TabIndex = 64;
            this.btnHighContrast.Text = "High Contrast Mode";
            this.btnHighContrast.UseVisualStyleBackColor = true;
            this.btnHighContrast.Click += new System.EventHandler(this.btnHighContrast_Click);
            // 
            // frmEnergyUsageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1246, 689);
            this.Controls.Add(this.btnHighContrast);
            this.Controls.Add(this.txtUsernames);
            this.Controls.Add(this.txtDates);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtListedAppliances);
            this.Controls.Add(this.grbCalculation);
            this.Controls.Add(this.lblEnergyUsageCalculator);
            this.Controls.Add(this.pbEnergyUsageCalculator);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCarbonFootprint);
            this.Controls.Add(this.btnGreenEnergyProducts);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnToHome);
            this.Controls.Add(this.pbNavbar);
            this.Name = "frmEnergyUsageCalculator";
            this.Text = "Energy Usage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pbNavbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnergyUsageCalculator)).EndInit();
            this.grbCalculation.ResumeLayout(false);
            this.grbCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolsaTechDBRedoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolsaTechDBRedoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNavbar;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCarbonFootprint;
        private System.Windows.Forms.Button btnGreenEnergyProducts;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbEnergyUsageCalculator;
        private System.Windows.Forms.Button btnToHome;
        private System.Windows.Forms.Label lblEnergyUsageCalculator;
        private System.Windows.Forms.GroupBox grbCalculation;
        private System.Windows.Forms.Label lblAppliance;
        private System.Windows.Forms.Label lblHoursUsed;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox txtHoursUsed;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtAppliance;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAddAnother;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtListedAppliances;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.BindingSource rolsaTechDBRedoDataSetBindingSource;
        private RolsaTechDBRedoDataSet rolsaTechDBRedoDataSet;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtDates;
        private System.Windows.Forms.TextBox txtUsernames;
        private System.Windows.Forms.Button btnHighContrast;
    }
}