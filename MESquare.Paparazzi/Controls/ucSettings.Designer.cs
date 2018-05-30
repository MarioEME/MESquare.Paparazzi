namespace MESquare.Paparazzi.Controls
{
    partial class ucSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTimerIntervalUnit = new System.Windows.Forms.ComboBox();
            this.nudTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseDestinyFolder = new System.Windows.Forms.Button();
            this.txtPaparazziDestinyFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTimerIntervalUnit);
            this.groupBox1.Controls.Add(this.nudTimerInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // cmbTimerIntervalUnit
            // 
            this.cmbTimerIntervalUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimerIntervalUnit.FormattingEnabled = true;
            this.cmbTimerIntervalUnit.Location = new System.Drawing.Point(171, 32);
            this.cmbTimerIntervalUnit.Name = "cmbTimerIntervalUnit";
            this.cmbTimerIntervalUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbTimerIntervalUnit.TabIndex = 5;
            // 
            // nudTimerInterval
            // 
            this.nudTimerInterval.Location = new System.Drawing.Point(92, 33);
            this.nudTimerInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTimerInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerInterval.Name = "nudTimerInterval";
            this.nudTimerInterval.Size = new System.Drawing.Size(73, 20);
            this.nudTimerInterval.TabIndex = 3;
            this.nudTimerInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerInterval.ValueChanged += new System.EventHandler(this.nudTimerInterval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 218);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseDestinyFolder);
            this.groupBox2.Controls.Add(this.txtPaparazziDestinyFolder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // btnBrowseDestinyFolder
            // 
            this.btnBrowseDestinyFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDestinyFolder.Location = new System.Drawing.Point(376, 35);
            this.btnBrowseDestinyFolder.Name = "btnBrowseDestinyFolder";
            this.btnBrowseDestinyFolder.Size = new System.Drawing.Size(51, 22);
            this.btnBrowseDestinyFolder.TabIndex = 7;
            this.btnBrowseDestinyFolder.Text = "Browse";
            this.btnBrowseDestinyFolder.UseVisualStyleBackColor = true;
            this.btnBrowseDestinyFolder.Click += new System.EventHandler(this.btnBrowseDestinyFolder_Click);
            // 
            // txtPaparazziDestinyFolder
            // 
            this.txtPaparazziDestinyFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaparazziDestinyFolder.Location = new System.Drawing.Point(92, 37);
            this.txtPaparazziDestinyFolder.Name = "txtPaparazziDestinyFolder";
            this.txtPaparazziDestinyFolder.Size = new System.Drawing.Size(278, 20);
            this.txtPaparazziDestinyFolder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destiny Folder";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(303, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(465, 255);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTimerIntervalUnit;
        private System.Windows.Forms.NumericUpDown nudTimerInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseDestinyFolder;
        private System.Windows.Forms.TextBox txtPaparazziDestinyFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
