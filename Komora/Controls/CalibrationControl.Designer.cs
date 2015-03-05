namespace Komora.Controls
{
    partial class CalibrationControl
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
            this.labelPt100Coefficients = new System.Windows.Forms.Label();
            this.labelPt100Chambers = new System.Windows.Forms.Label();
            this.dataGridViewPt100Polynomial = new System.Windows.Forms.DataGridView();
            this.dataGridViewPt100Chambers = new System.Windows.Forms.DataGridView();
            this.calibrationPlotPt100 = new ZedGraph.ZedGraphControl();
            this.buttonBeginCalibrationPt100 = new System.Windows.Forms.Button();
            this.buttonBrowseFilePt100 = new System.Windows.Forms.Button();
            this.textBoxFilePt100 = new System.Windows.Forms.TextBox();
            this.labelFilePathPt100 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Polynomial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Chambers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPt100Coefficients
            // 
            this.labelPt100Coefficients.AutoSize = true;
            this.labelPt100Coefficients.Location = new System.Drawing.Point(780, 239);
            this.labelPt100Coefficients.Name = "labelPt100Coefficients";
            this.labelPt100Coefficients.Size = new System.Drawing.Size(65, 13);
            this.labelPt100Coefficients.TabIndex = 22;
            this.labelPt100Coefficients.Text = "Coefficients:";
            // 
            // labelPt100Chambers
            // 
            this.labelPt100Chambers.AutoSize = true;
            this.labelPt100Chambers.Location = new System.Drawing.Point(780, 95);
            this.labelPt100Chambers.Name = "labelPt100Chambers";
            this.labelPt100Chambers.Size = new System.Drawing.Size(57, 13);
            this.labelPt100Chambers.TabIndex = 21;
            this.labelPt100Chambers.Text = "Chambers:";
            // 
            // dataGridViewPt100Polynomial
            // 
            this.dataGridViewPt100Polynomial.AllowUserToAddRows = false;
            this.dataGridViewPt100Polynomial.AllowUserToDeleteRows = false;
            this.dataGridViewPt100Polynomial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPt100Polynomial.Location = new System.Drawing.Point(780, 259);
            this.dataGridViewPt100Polynomial.Name = "dataGridViewPt100Polynomial";
            this.dataGridViewPt100Polynomial.ReadOnly = true;
            this.dataGridViewPt100Polynomial.Size = new System.Drawing.Size(507, 135);
            this.dataGridViewPt100Polynomial.TabIndex = 20;
            // 
            // dataGridViewPt100Chambers
            // 
            this.dataGridViewPt100Chambers.AllowUserToAddRows = false;
            this.dataGridViewPt100Chambers.AllowUserToDeleteRows = false;
            this.dataGridViewPt100Chambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPt100Chambers.Location = new System.Drawing.Point(780, 114);
            this.dataGridViewPt100Chambers.Name = "dataGridViewPt100Chambers";
            this.dataGridViewPt100Chambers.ReadOnly = true;
            this.dataGridViewPt100Chambers.Size = new System.Drawing.Size(507, 118);
            this.dataGridViewPt100Chambers.TabIndex = 19;
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
            this.calibrationPlotPt100.Location = new System.Drawing.Point(7, 67);
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
            this.calibrationPlotPt100.TabIndex = 18;
            this.calibrationPlotPt100.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlotPt100.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.calibrationPlotPt100.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.calibrationPlotPt100.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlotPt100.ZoomStepFraction = 0.1D;
            // 
            // buttonBeginCalibrationPt100
            // 
            this.buttonBeginCalibrationPt100.Location = new System.Drawing.Point(984, 15);
            this.buttonBeginCalibrationPt100.Name = "buttonBeginCalibrationPt100";
            this.buttonBeginCalibrationPt100.Size = new System.Drawing.Size(147, 45);
            this.buttonBeginCalibrationPt100.TabIndex = 17;
            this.buttonBeginCalibrationPt100.Text = "Begin Calibration";
            this.buttonBeginCalibrationPt100.UseVisualStyleBackColor = true;
            this.buttonBeginCalibrationPt100.Click += new System.EventHandler(this.buttonBeginCalibrationPt100_Click);
            // 
            // buttonBrowseFilePt100
            // 
            this.buttonBrowseFilePt100.Location = new System.Drawing.Point(627, 12);
            this.buttonBrowseFilePt100.Name = "buttonBrowseFilePt100";
            this.buttonBrowseFilePt100.Size = new System.Drawing.Size(109, 20);
            this.buttonBrowseFilePt100.TabIndex = 16;
            this.buttonBrowseFilePt100.Text = "Browse file";
            this.buttonBrowseFilePt100.UseVisualStyleBackColor = true;
            this.buttonBrowseFilePt100.Click += new System.EventHandler(this.buttonBrowseFilePt100_Click);
            // 
            // textBoxFilePt100
            // 
            this.textBoxFilePt100.Enabled = false;
            this.textBoxFilePt100.Location = new System.Drawing.Point(88, 12);
            this.textBoxFilePt100.Name = "textBoxFilePt100";
            this.textBoxFilePt100.Size = new System.Drawing.Size(533, 20);
            this.textBoxFilePt100.TabIndex = 15;
            // 
            // labelFilePathPt100
            // 
            this.labelFilePathPt100.AutoSize = true;
            this.labelFilePathPt100.Location = new System.Drawing.Point(11, 15);
            this.labelFilePathPt100.Name = "labelFilePathPt100";
            this.labelFilePathPt100.Size = new System.Drawing.Size(71, 13);
            this.labelFilePathPt100.TabIndex = 14;
            this.labelFilePathPt100.Text = "CSV file path:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CalibrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPt100Coefficients);
            this.Controls.Add(this.labelPt100Chambers);
            this.Controls.Add(this.dataGridViewPt100Polynomial);
            this.Controls.Add(this.dataGridViewPt100Chambers);
            this.Controls.Add(this.calibrationPlotPt100);
            this.Controls.Add(this.buttonBeginCalibrationPt100);
            this.Controls.Add(this.buttonBrowseFilePt100);
            this.Controls.Add(this.textBoxFilePt100);
            this.Controls.Add(this.labelFilePathPt100);
            this.Name = "CalibrationControl";
            this.Size = new System.Drawing.Size(1323, 529);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Polynomial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPt100Chambers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPt100Coefficients;
        private System.Windows.Forms.Label labelPt100Chambers;
        private System.Windows.Forms.DataGridView dataGridViewPt100Polynomial;
        private System.Windows.Forms.DataGridView dataGridViewPt100Chambers;
        private ZedGraph.ZedGraphControl calibrationPlotPt100;
        private System.Windows.Forms.Button buttonBeginCalibrationPt100;
        private System.Windows.Forms.Button buttonBrowseFilePt100;
        private System.Windows.Forms.TextBox textBoxFilePt100;
        private System.Windows.Forms.Label labelFilePathPt100;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}
