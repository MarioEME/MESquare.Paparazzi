namespace MESquare.Paparazzi
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTakeScreenshot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 75);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(170, 17);
            this.lblStatus.Text = "Press \'Start\' to start the process";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnStop,
            this.toolStripSeparator1,
            this.btnTakeScreenshot,
            this.toolStripSeparator2,
            this.btnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(317, 70);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = false;
            this.btnStart.Image = global::MESquare.Paparazzi.Properties.Resources.play_simple_48x48;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 67);
            this.btnStart.Text = "Start";
            this.btnStart.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = false;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::MESquare.Paparazzi.Properties.Resources.stop_simple_48x48;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 67);
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.AutoSize = false;
            this.btnTakeScreenshot.Image = global::MESquare.Paparazzi.Properties.Resources.camera_48x48;
            this.btnTakeScreenshot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(67, 67);
            this.btnTakeScreenshot.Text = "Capture";
            this.btnTakeScreenshot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = false;
            this.btnSettings.Image = global::MESquare.Paparazzi.Properties.Resources.gear_blue_48x48;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(67, 67);
            this.btnSettings.Text = "Options";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Paparazy";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItemStart,
            this.btnMenuItemStop,
            this.btnMenuItemOpen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // btnMenuItemStop
            // 
            this.btnMenuItemStop.Enabled = false;
            this.btnMenuItemStop.Image = global::MESquare.Paparazzi.Properties.Resources.stop_simple_48x48;
            this.btnMenuItemStop.Name = "btnMenuItemStop";
            this.btnMenuItemStop.Size = new System.Drawing.Size(180, 22);
            this.btnMenuItemStop.Text = "Stop";
            this.btnMenuItemStop.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // btnMenuItemStart
            // 
            this.btnMenuItemStart.Image = global::MESquare.Paparazzi.Properties.Resources.play_simple_48x48;
            this.btnMenuItemStart.Name = "btnMenuItemStart";
            this.btnMenuItemStart.Size = new System.Drawing.Size(180, 22);
            this.btnMenuItemStart.Text = "Start";
            this.btnMenuItemStart.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // btnMenuItemOpen
            // 
            this.btnMenuItemOpen.Name = "btnMenuItemOpen";
            this.btnMenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.btnMenuItemOpen.Text = "Open";
            this.btnMenuItemOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 97);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paparazzi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnTakeScreenshot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemOpen;
    }
}

