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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.buttonBeginCalibration = new System.Windows.Forms.Button();
            this.calibrationPlot = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(12, 9);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(71, 13);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "CSV file path:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Enabled = false;
            this.textBoxFile.Location = new System.Drawing.Point(89, 6);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(399, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(494, 6);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(109, 20);
            this.buttonBrowseFile.TabIndex = 2;
            this.buttonBrowseFile.Text = "Browse file";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // buttonBeginCalibration
            // 
            this.buttonBeginCalibration.Location = new System.Drawing.Point(609, 6);
            this.buttonBeginCalibration.Name = "buttonBeginCalibration";
            this.buttonBeginCalibration.Size = new System.Drawing.Size(147, 45);
            this.buttonBeginCalibration.TabIndex = 3;
            this.buttonBeginCalibration.Text = "Begin Calibration";
            this.buttonBeginCalibration.UseVisualStyleBackColor = true;
            this.buttonBeginCalibration.Click += new System.EventHandler(this.buttonBeginCalibration_Click);
            // 
            // calibrationPlot
            // 
            this.calibrationPlot.IsAutoScrollRange = false;
            this.calibrationPlot.IsEnableHPan = true;
            this.calibrationPlot.IsEnableHZoom = true;
            this.calibrationPlot.IsEnableVPan = true;
            this.calibrationPlot.IsEnableVZoom = true;
            this.calibrationPlot.IsScrollY2 = false;
            this.calibrationPlot.IsShowContextMenu = true;
            this.calibrationPlot.IsShowCursorValues = false;
            this.calibrationPlot.IsShowHScrollBar = false;
            this.calibrationPlot.IsShowPointValues = false;
            this.calibrationPlot.IsShowVScrollBar = false;
            this.calibrationPlot.IsZoomOnMouseCenter = false;
            this.calibrationPlot.Location = new System.Drawing.Point(12, 32);
            this.calibrationPlot.Name = "calibrationPlot";
            this.calibrationPlot.PanButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlot.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
            this.calibrationPlot.PanModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlot.PointDateFormat = "g";
            this.calibrationPlot.PointValueFormat = "G";
            this.calibrationPlot.ScrollMaxX = 0D;
            this.calibrationPlot.ScrollMaxY = 0D;
            this.calibrationPlot.ScrollMaxY2 = 0D;
            this.calibrationPlot.ScrollMinX = 0D;
            this.calibrationPlot.ScrollMinY = 0D;
            this.calibrationPlot.ScrollMinY2 = 0D;
            this.calibrationPlot.Size = new System.Drawing.Size(476, 267);
            this.calibrationPlot.TabIndex = 4;
            this.calibrationPlot.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlot.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.calibrationPlot.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.calibrationPlot.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlot.ZoomStepFraction = 0.1D;
            // 
            // CalibrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 327);
            this.Controls.Add(this.calibrationPlot);
            this.Controls.Add(this.buttonBeginCalibration);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFilePath);
            this.Name = "CalibrationWindow";
            this.Text = "CalibrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Button buttonBeginCalibration;
        private ZedGraph.ZedGraphControl calibrationPlot;

    }
}