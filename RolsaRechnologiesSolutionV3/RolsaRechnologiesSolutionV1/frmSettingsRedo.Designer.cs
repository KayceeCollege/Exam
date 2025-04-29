namespace RolsaRechnologiesSolutionV1
{
    partial class frmSettingsRedo
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
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(59, 44);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(155, 45);
            this.btnExitApplication.TabIndex = 0;
            this.btnExitApplication.Text = "Quit";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // frmSettingsRedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 134);
            this.Controls.Add(this.btnExitApplication);
            this.Name = "frmSettingsRedo";
            this.Text = "frmSettingsRedo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitApplication;
    }
}