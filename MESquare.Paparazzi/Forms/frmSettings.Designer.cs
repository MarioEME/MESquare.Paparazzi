namespace MESquare.Paparazzi.Forms
{
    partial class frmSettings
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
            this.ucSettings1 = new MESquare.Paparazzi.Controls.ucSettings();
            this.SuspendLayout();
            // 
            // ucSettings1
            // 
            this.ucSettings1.Location = new System.Drawing.Point(7, 7);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(465, 255);
            this.ucSettings1.TabIndex = 0;
            this.ucSettings1.AfterOkPressed += new System.Action(this.ucSettings1_AfterOkPressed);
            this.ucSettings1.AfterCancelPressed += new System.Action(this.ucSettings1_AfterCancelPressed);
            this.ucSettings1.Load += new System.EventHandler(this.ucSettings1_Load);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 264);
            this.Controls.Add(this.ucSettings1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paparazzi Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSettings ucSettings1;
    }
}