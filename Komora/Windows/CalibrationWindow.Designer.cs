namespace Komora.Windows
{
    partial class CalibrationWindow
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlCalibration = new System.Windows.Forms.TabControl();
            this.tabPagePt100 = new System.Windows.Forms.TabPage();
            this.calibrationControlPt100 = new Komora.Controls.CalibrationControl();
            this.tabPageLED = new System.Windows.Forms.TabPage();
            this.tabControlCalibration.SuspendLayout();
            this.tabPagePt100.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // tabControlCalibration
            // 
            this.tabControlCalibration.Controls.Add(this.tabPagePt100);
            this.tabControlCalibration.Controls.Add(this.tabPageLED);
            this.tabControlCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCalibration.Location = new System.Drawing.Point(0, 0);
            this.tabControlCalibration.Name = "tabControlCalibration";
            this.tabControlCalibration.SelectedIndex = 0;
            this.tabControlCalibration.Size = new System.Drawing.Size(1354, 559);
            this.tabControlCalibration.TabIndex = 0;
            // 
            // tabPagePt100
            // 
            this.tabPagePt100.Controls.Add(this.calibrationControlPt100);
            this.tabPagePt100.Location = new System.Drawing.Point(4, 22);
            this.tabPagePt100.Name = "tabPagePt100";
            this.tabPagePt100.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePt100.Size = new System.Drawing.Size(1346, 533);
            this.tabPagePt100.TabIndex = 0;
            this.tabPagePt100.Text = "Pt100";
            this.tabPagePt100.UseVisualStyleBackColor = true;
            // 
            // calibrationControlPt100
            // 
            this.calibrationControlPt100.Location = new System.Drawing.Point(6, 6);
            this.calibrationControlPt100.Name = "calibrationControlPt100";
            this.calibrationControlPt100.Size = new System.Drawing.Size(1323, 529);
            this.calibrationControlPt100.TabIndex = 0;
            // 
            // tabPageLED
            // 
            this.tabPageLED.Location = new System.Drawing.Point(4, 22);
            this.tabPageLED.Name = "tabPageLED";
            this.tabPageLED.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLED.Size = new System.Drawing.Size(1346, 533);
            this.tabPageLED.TabIndex = 1;
            this.tabPageLED.Text = "LED";
            this.tabPageLED.UseVisualStyleBackColor = true;
            // 
            // CalibrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 559);
            this.Controls.Add(this.tabControlCalibration);
            this.Name = "CalibrationWindow";
            this.Text = "CalibrationWindow";
            this.tabControlCalibration.ResumeLayout(false);
            this.tabPagePt100.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TabControl tabControlCalibration;
        private System.Windows.Forms.TabPage tabPagePt100;
        private System.Windows.Forms.TabPage tabPageLED;
        private Controls.CalibrationControl calibrationControlPt100;

    }
}