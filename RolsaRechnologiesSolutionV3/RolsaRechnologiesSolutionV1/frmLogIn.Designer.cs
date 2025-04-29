namespace RolsaRechnologiesSolutionV1
{
    partial class frmLogIn
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
            this.txtErrorMessage1 = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.btnToHome = new System.Windows.Forms.Button();
            this.pbBackground2 = new System.Windows.Forms.PictureBox();
            this.pbBackground1 = new System.Windows.Forms.PictureBox();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnToSignUp = new System.Windows.Forms.Button();
            this.btnHighContrast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtErrorMessage1
            // 
            this.txtErrorMessage1.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessage1.Location = new System.Drawing.Point(377, 390);
            this.txtErrorMessage1.Name = "txtErrorMessage1";
            this.txtErrorMessage1.ReadOnly = true;
            this.txtErrorMessage1.Size = new System.Drawing.Size(518, 20);
            this.txtErrorMessage1.TabIndex = 25;
            this.txtErrorMessage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtErrorMessage1.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(559, 352);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 32);
            this.btnLogIn.TabIndex = 24;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(377, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(518, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.lblPassword.Location = new System.Drawing.Point(376, 298);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.lblUsername.Location = new System.Drawing.Point(372, 247);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(377, 275);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(518, 20);
            this.txtUsername.TabIndex = 18;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(179)))));
            this.lblLogIn.Location = new System.Drawing.Point(565, 177);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(117, 39);
            this.lblLogIn.TabIndex = 17;
            this.lblLogIn.Text = "Log In";
            // 
            // btnToHome
            // 
            this.btnToHome.BackColor = System.Drawing.Color.Transparent;
            this.btnToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(173)))), ((int)(((byte)(136)))));
            this.btnToHome.Location = new System.Drawing.Point(434, 116);
            this.btnToHome.Name = "btnToHome";
            this.btnToHome.Size = new System.Drawing.Size(401, 58);
            this.btnToHome.TabIndex = 16;
            this.btnToHome.Text = "Rolsa Technologies";
            this.btnToHome.UseVisualStyleBackColor = false;
            this.btnToHome.Click += new System.EventHandler(this.btnToHome_Click);
            // 
            // pbBackground2
            // 
            this.pbBackground2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(179)))));
            this.pbBackground2.Location = new System.Drawing.Point(915, -8);
            this.pbBackground2.Name = "pbBackground2";
            this.pbBackground2.Size = new System.Drawing.Size(332, 704);
            this.pbBackground2.TabIndex = 15;
            this.pbBackground2.TabStop = false;
            // 
            // pbBackground1
            // 
            this.pbBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(179)))));
            this.pbBackground1.Location = new System.Drawing.Point(0, -8);
            this.pbBackground1.Name = "pbBackground1";
            this.pbBackground1.Size = new System.Drawing.Size(332, 704);
            this.pbBackground1.TabIndex = 14;
            this.pbBackground1.TabStop = false;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(202)))), ((int)(((byte)(179)))));
            this.lblNoAccount.Location = new System.Drawing.Point(395, 413);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(453, 33);
            this.lblNoAccount.TabIndex = 26;
            this.lblNoAccount.Text = "Don\'t already have an account?";
            // 
            // btnToSignUp
            // 
            this.btnToSignUp.Location = new System.Drawing.Point(559, 449);
            this.btnToSignUp.Name = "btnToSignUp";
            this.btnToSignUp.Size = new System.Drawing.Size(139, 32);
            this.btnToSignUp.TabIndex = 27;
            this.btnToSignUp.Text = "Sign Up Now!";
            this.btnToSignUp.UseVisualStyleBackColor = true;
            this.btnToSignUp.Click += new System.EventHandler(this.btnToSignUp_Click);
            // 
            // btnHighContrast
            // 
            this.btnHighContrast.Location = new System.Drawing.Point(12, 654);
            this.btnHighContrast.Name = "btnHighContrast";
            this.btnHighContrast.Size = new System.Drawing.Size(184, 23);
            this.btnHighContrast.TabIndex = 48;
            this.btnHighContrast.Text = "High Contrast Mode";
            this.btnHighContrast.UseVisualStyleBackColor = true;
            this.btnHighContrast.Click += new System.EventHandler(this.btnHighContrast_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 689);
            this.Controls.Add(this.btnHighContrast);
            this.Controls.Add(this.btnToSignUp);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.txtErrorMessage1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.btnToHome);
            this.Controls.Add(this.pbBackground2);
            this.Controls.Add(this.pbBackground1);
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErrorMessage1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Button btnToHome;
        private System.Windows.Forms.PictureBox pbBackground2;
        private System.Windows.Forms.PictureBox pbBackground1;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnToSignUp;
        private System.Windows.Forms.Button btnHighContrast;
    }
}