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
            this.calibrationPlotPt100 = new ZedGraph.ZedGraphControl();
            this.buttonBeginCalibrationPt100 = new System.Windows.Forms.Button();
            this.buttonBrowseFilePt100 = new System.Windows.Forms.Button();
            this.textBoxFilePt100 = new System.Windows.Forms.TextBox();
            this.labelFilePathPt100 = new System.Windows.Forms.Label();
            this.tabPageLED = new System.Windows.Forms.TabPage();
            this.dataGridViewPt100Chambers = new System.Windows.Forms.DataGridView();
            this.dataGridViewPt100Polynomial = new System.Windows.Forms.DataGridView();
            this.labelPt100Chambers = new System.Windows.Forms.Label();
            this.labelPt100Coefficients = new System.Windows.Forms.Label();
            this.tabControlCalibration.SuspendLayout();
            this.tabPagePt100.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Chambers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Polynomial)).BeginInit();
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
            this.tabControlCalibration.Size = new System.Drawing.Size(1313, 529);
            this.tabControlCalibration.TabIndex = 0;
            // 
            // tabPagePt100
            // 
            this.tabPagePt100.Controls.Add(this.labelPt100Coefficients);
            this.tabPagePt100.Controls.Add(this.labelPt100Chambers);
            this.tabPagePt100.Controls.Add(this.dataGridViewPt100Polynomial);
            this.tabPagePt100.Controls.Add(this.dataGridViewPt100Chambers);
            this.tabPagePt100.Controls.Add(this.calibrationPlotPt100);
            this.tabPagePt100.Controls.Add(this.buttonBeginCalibrationPt100);
            this.tabPagePt100.Controls.Add(this.buttonBrowseFilePt100);
            this.tabPagePt100.Controls.Add(this.textBoxFilePt100);
            this.tabPagePt100.Controls.Add(this.labelFilePathPt100);
            this.tabPagePt100.Location = new System.Drawing.Point(4, 22);
            this.tabPagePt100.Name = "tabPagePt100";
            this.tabPagePt100.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePt100.Size = new System.Drawing.Size(1305, 503);
            this.tabPagePt100.TabIndex = 0;
            this.tabPagePt100.Text = "Pt100";
            this.tabPagePt100.UseVisualStyleBackColor = true;
            // 
            // calibrationPlotPt100
            // 
            this.calibrationPlotPt100.IsAutoScrollRange = false;
            this.calibrationPlotPt100.IsEnableHPan = true;
            this.calibrationPlotPt100.IsEnableHZoom = true;
            this.calibrationPlotPt100.IsEnableVPan = true;
            this.calibrationPlotPt100.IsEnableVZoom = true;
            this.calibrationPlotPt100.IsScrollY2 = false;
            this.calibrationPlotPt100.IsShowContextMenu = true;
            this.calibrationPlotPt100.IsShowCursorValues = false;
            this.calibrationPlotPt100.IsShowHScrollBar = false;
            this.calibrationPlotPt100.IsShowPointValues = false;
            this.calibrationPlotPt100.IsShowVScrollBar = false;
            this.calibrationPlotPt100.IsZoomOnMouseCenter = false;
            this.calibrationPlotPt100.Location = new System.Drawing.Point(8, 61);
            this.calibrationPlotPt100.Name = "calibrationPlotPt100";
            this.calibrationPlotPt100.PanButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlotPt100.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
            this.calibrationPlotPt100.PanModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlotPt100.PointDateFormat = "g";
            this.calibrationPlotPt100.PointValueFormat = "G";
            this.calibrationPlotPt100.ScrollMaxX = 0D;
            this.calibrationPlotPt100.ScrollMaxY = 0D;
            this.calibrationPlotPt100.ScrollMaxY2 = 0D;
            this.calibrationPlotPt100.ScrollMinX = 0D;
            this.calibrationPlotPt100.ScrollMinY = 0D;
            this.calibrationPlotPt100.ScrollMinY2 = 0D;
            this.calibrationPlotPt100.Size = new System.Drawing.Size(729, 419);
            this.calibrationPlotPt100.TabIndex = 9;
            this.calibrationPlotPt100.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlotPt100.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.calibrationPlotPt100.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.calibrationPlotPt100.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlotPt100.ZoomStepFraction = 0.1D;
            // 
            // buttonBeginCalibrationPt100
            // 
            this.buttonBeginCalibrationPt100.Location = new System.Drawing.Point(985, 9);
            this.buttonBeginCalibrationPt100.Name = "buttonBeginCalibrationPt100";
            this.buttonBeginCalibrationPt100.Size = new System.Drawing.Size(147, 45);
            this.buttonBeginCalibrationPt100.TabIndex = 8;
            this.buttonBeginCalibrationPt100.Text = "Begin Calibration";
            this.buttonBeginCalibrationPt100.UseVisualStyleBackColor = true;
            this.buttonBeginCalibrationPt100.Click += new System.EventHandler(this.buttonBeginCalibrationPt100_Click);
            // 
            // buttonBrowseFilePt100
            // 
            this.buttonBrowseFilePt100.Location = new System.Drawing.Point(628, 6);
            this.buttonBrowseFilePt100.Name = "buttonBrowseFilePt100";
            this.buttonBrowseFilePt100.Size = new System.Drawing.Size(109, 20);
            this.buttonBrowseFilePt100.TabIndex = 7;
            this.buttonBrowseFilePt100.Text = "Browse file";
            this.buttonBrowseFilePt100.UseVisualStyleBackColor = true;
            this.buttonBrowseFilePt100.Click += new System.EventHandler(this.buttonBrowseFilePt100_Click);
            // 
            // textBoxFilePt100
            // 
            this.textBoxFilePt100.Enabled = false;
            this.textBoxFilePt100.Location = new System.Drawing.Point(89, 6);
            this.textBoxFilePt100.Name = "textBoxFilePt100";
            this.textBoxFilePt100.Size = new System.Drawing.Size(533, 20);
            this.textBoxFilePt100.TabIndex = 6;
            // 
            // labelFilePathPt100
            // 
            this.labelFilePathPt100.AutoSize = true;
            this.labelFilePathPt100.Location = new System.Drawing.Point(12, 9);
            this.labelFilePathPt100.Name = "labelFilePathPt100";
            this.labelFilePathPt100.Size = new System.Drawing.Size(71, 13);
            this.labelFilePathPt100.TabIndex = 5;
            this.labelFilePathPt100.Text = "CSV file path:";
            // 
            // tabPageLED
            // 
            this.tabPageLED.Location = new System.Drawing.Point(4, 22);
            this.tabPageLED.Name = "tabPageLED";
            this.tabPageLED.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLED.Size = new System.Drawing.Size(1021, 503);
            this.tabPageLED.TabIndex = 1;
            this.tabPageLED.Text = "LED";
            this.tabPageLED.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPt100Chambers
            // 
            this.dataGridViewPt100Chambers.AllowUserToAddRows = false;
            this.dataGridViewPt100Chambers.AllowUserToDeleteRows = false;
            this.dataGridViewPt100Chambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPt100Chambers.Location = new System.Drawing.Point(781, 108);
            this.dataGridViewPt100Chambers.Name = "dataGridViewPt100Chambers";
            this.dataGridViewPt100Chambers.ReadOnly = true;
            this.dataGridViewPt100Chambers.Size = new System.Drawing.Size(507, 118);
            this.dataGridViewPt100Chambers.TabIndex = 10;
            // 
            // dataGridViewPt100Polynomial
            // 
            this.dataGridViewPt100Polynomial.AllowUserToAddRows = false;
            this.dataGridViewPt100Polynomial.AllowUserToDeleteRows = false;
            this.dataGridViewPt100Polynomial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPt100Polynomial.Location = new System.Drawing.Point(781, 253);
            this.dataGridViewPt100Polynomial.Name = "dataGridViewPt100Polynomial";
            this.dataGridViewPt100Polynomial.ReadOnly = true;
            this.dataGridViewPt100Polynomial.Size = new System.Drawing.Size(507, 135);
            this.dataGridViewPt100Polynomial.TabIndex = 11;
            // 
            // labelPt100Chambers
            // 
            this.labelPt100Chambers.AutoSize = true;
            this.labelPt100Chambers.Location = new System.Drawing.Point(781, 89);
            this.labelPt100Chambers.Name = "labelPt100Chambers";
            this.labelPt100Chambers.Size = new System.Drawing.Size(57, 13);
            this.labelPt100Chambers.TabIndex = 12;
            this.labelPt100Chambers.Text = "Chambers:";
            // 
            // labelPt100Coefficients
            // 
            this.labelPt100Coefficients.AutoSize = true;
            this.labelPt100Coefficients.Location = new System.Drawing.Point(781, 233);
            this.labelPt100Coefficients.Name = "labelPt100Coefficients";
            this.labelPt100Coefficients.Size = new System.Drawing.Size(65, 13);
            this.labelPt100Coefficients.TabIndex = 13;
            this.labelPt100Coefficients.Text = "Coefficients:";
            // 
            // CalibrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 529);
            this.Controls.Add(this.tabControlCalibration);
            this.Name = "CalibrationWindow";
            this.Text = "CalibrationWindow";
            this.tabControlCalibration.ResumeLayout(false);
            this.tabPagePt100.ResumeLayout(false);
            this.tabPagePt100.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Chambers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Polynomial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TabControl tabControlCalibration;
        private System.Windows.Forms.TabPage tabPagePt100;
        private System.Windows.Forms.TabPage tabPageLED;
        private ZedGraph.ZedGraphControl calibrationPlotPt100;
        private System.Windows.Forms.Button buttonBeginCalibrationPt100;
        private System.Windows.Forms.Button buttonBrowseFilePt100;
        private System.Windows.Forms.TextBox textBoxFilePt100;
        private System.Windows.Forms.Label labelFilePathPt100;
        private System.Windows.Forms.DataGridView dataGridViewPt100Chambers;
        private System.Windows.Forms.DataGridView dataGridViewPt100Polynomial;
        private System.Windows.Forms.Label labelPt100Coefficients;
        private System.Windows.Forms.Label labelPt100Chambers;

    }
}