namespace RolsaRechnologiesSolutionV1
{
    partial class frmTOS
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
            this.txtTOS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTOS
            // 
            this.txtTOS.Location = new System.Drawing.Point(12, 12);
            this.txtTOS.Multiline = true;
            this.txtTOS.Name = "txtTOS";
            this.txtTOS.ReadOnly = true;
            this.txtTOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTOS.Size = new System.Drawing.Size(387, 426);
            this.txtTOS.TabIndex = 0;
            this.txtTOS.Text = "TOS will go here";
            // 
            // frmTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.txtTOS);
            this.Name = "frmTOS";
            this.Text = "Terms of Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTOS;
    }
}