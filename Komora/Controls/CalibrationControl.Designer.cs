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
            this.labelCoefficients = new System.Windows.Forms.Label();
            this.labelChambers = new System.Windows.Forms.Label();
            this.dataGridViewPolynomial = new System.Windows.Forms.DataGridView();
            this.dataGridViewChambers = new System.Windows.Forms.DataGridView();
            this.calibrationPlot = new ZedGraph.ZedGraphControl();
            this.buttonBeginCalibration = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFilePathPt100 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonDeleteCoefficients = new System.Windows.Forms.Button();
            this.buttonDeleteAllCoefficients = new System.Windows.Forms.Button();
            this.labelPolynomialOrder = new System.Windows.Forms.Label();
            this.comboBoxPolyOrderLower = new System.Windows.Forms.ComboBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.textBoxResultsLower = new System.Windows.Forms.TextBox();
            this.textBoxResultsHigher = new System.Windows.Forms.TextBox();
            this.comboBoxPolyOrderHigher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentBound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveCoefficients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolynomial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCoefficients
            // 
            this.labelCoefficients.AutoSize = true;
            this.labelCoefficients.Location = new System.Drawing.Point(757, 255);
            this.labelCoefficients.Name = "labelCoefficients";
            this.labelCoefficients.Size = new System.Drawing.Size(65, 13);
            this.labelCoefficients.TabIndex = 22;
            this.labelCoefficients.Text = "Coefficients:";
            // 
            // labelChambers
            // 
            this.labelChambers.AutoSize = true;
            this.labelChambers.Location = new System.Drawing.Point(757, 104);
            this.labelChambers.Name = "labelChambers";
            this.labelChambers.Size = new System.Drawing.Size(57, 13);
            this.labelChambers.TabIndex = 21;
            this.labelChambers.Text = "Chambers:";
            // 
            // dataGridViewPolynomial
            // 
            this.dataGridViewPolynomial.AllowUserToAddRows = false;
            this.dataGridViewPolynomial.AllowUserToDeleteRows = false;
            this.dataGridViewPolynomial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolynomial.Location = new System.Drawing.Point(757, 275);
            this.dataGridViewPolynomial.Name = "dataGridViewPolynomial";
            this.dataGridViewPolynomial.ReadOnly = true;
            this.dataGridViewPolynomial.Size = new System.Drawing.Size(507, 135);
            this.dataGridViewPolynomial.TabIndex = 20;
            // 
            // dataGridViewChambers
            // 
            this.dataGridViewChambers.AllowUserToAddRows = false;
            this.dataGridViewChambers.AllowUserToDeleteRows = false;
            this.dataGridViewChambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChambers.Location = new System.Drawing.Point(757, 130);
            this.dataGridViewChambers.Name = "dataGridViewChambers";
            this.dataGridViewChambers.ReadOnly = true;
            this.dataGridViewChambers.Size = new System.Drawing.Size(507, 118);
            this.dataGridViewChambers.TabIndex = 19;
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
            this.calibrationPlot.Location = new System.Drawing.Point(7, 64);
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
            this.calibrationPlot.Size = new System.Drawing.Size(729, 440);
            this.calibrationPlot.TabIndex = 18;
            this.calibrationPlot.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.calibrationPlot.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.calibrationPlot.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.calibrationPlot.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.calibrationPlot.ZoomStepFraction = 0.1D;
            // 
            // buttonBeginCalibration
            // 
            this.buttonBeginCalibration.Location = new System.Drawing.Point(1061, 15);
            this.buttonBeginCalibration.Name = "buttonBeginCalibration";
            this.buttonBeginCalibration.Size = new System.Drawing.Size(147, 45);
            this.buttonBeginCalibration.TabIndex = 17;
            this.buttonBeginCalibration.Text = "Begin Calibration";
            this.buttonBeginCalibration.UseVisualStyleBackColor = true;
            this.buttonBeginCalibration.Click += new System.EventHandler(this.buttonBeginCalibration_Click);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(627, 12);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(109, 20);
            this.buttonBrowseFile.TabIndex = 16;
            this.buttonBrowseFile.Text = "Browse file";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFilePt100_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Enabled = false;
            this.textBoxFile.Location = new System.Drawing.Point(88, 12);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(533, 20);
            this.textBoxFile.TabIndex = 15;
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
            // buttonDeleteCoefficients
            // 
            this.buttonDeleteCoefficients.Location = new System.Drawing.Point(833, 495);
            this.buttonDeleteCoefficients.Name = "buttonDeleteCoefficients";
            this.buttonDeleteCoefficients.Size = new System.Drawing.Size(105, 38);
            this.buttonDeleteCoefficients.TabIndex = 23;
            this.buttonDeleteCoefficients.Text = "Delete selected coefficients ";
            this.buttonDeleteCoefficients.UseVisualStyleBackColor = true;
            this.buttonDeleteCoefficients.Click += new System.EventHandler(this.buttonDeleteSelectedCoefficients_Click);
            // 
            // buttonDeleteAllCoefficients
            // 
            this.buttonDeleteAllCoefficients.Location = new System.Drawing.Point(957, 495);
            this.buttonDeleteAllCoefficients.Name = "buttonDeleteAllCoefficients";
            this.buttonDeleteAllCoefficients.Size = new System.Drawing.Size(103, 38);
            this.buttonDeleteAllCoefficients.TabIndex = 24;
            this.buttonDeleteAllCoefficients.Text = "Delete all coefficients";
            this.buttonDeleteAllCoefficients.UseVisualStyleBackColor = true;
            this.buttonDeleteAllCoefficients.Click += new System.EventHandler(this.buttonDeleteAllCoefficients_Click);
            // 
            // labelPolynomialOrder
            // 
            this.labelPolynomialOrder.AutoSize = true;
            this.labelPolynomialOrder.Location = new System.Drawing.Point(757, 30);
            this.labelPolynomialOrder.Name = "labelPolynomialOrder";
            this.labelPolynomialOrder.Size = new System.Drawing.Size(87, 13);
            this.labelPolynomialOrder.TabIndex = 27;
            this.labelPolynomialOrder.Text = "Polynomial order:";
            // 
            // comboBoxPolyOrderLower
            // 
            this.comboBoxPolyOrderLower.FormattingEnabled = true;
            this.comboBoxPolyOrderLower.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxPolyOrderLower.Location = new System.Drawing.Point(851, 30);
            this.comboBoxPolyOrderLower.Name = "comboBoxPolyOrderLower";
            this.comboBoxPolyOrderLower.Size = new System.Drawing.Size(37, 21);
            this.comboBoxPolyOrderLower.TabIndex = 28;
            this.comboBoxPolyOrderLower.Text = "2";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(757, 433);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(48, 13);
            this.labelResults.TabIndex = 25;
            this.labelResults.Text = "Results: ";
            // 
            // textBoxResultsLower
            // 
            this.textBoxResultsLower.Enabled = false;
            this.textBoxResultsLower.Location = new System.Drawing.Point(802, 430);
            this.textBoxResultsLower.Name = "textBoxResultsLower";
            this.textBoxResultsLower.Size = new System.Drawing.Size(462, 20);
            this.textBoxResultsLower.TabIndex = 26;
            // 
            // textBoxResultsHigher
            // 
            this.textBoxResultsHigher.Enabled = false;
            this.textBoxResultsHigher.Location = new System.Drawing.Point(802, 456);
            this.textBoxResultsHigher.Name = "textBoxResultsHigher";
            this.textBoxResultsHigher.Size = new System.Drawing.Size(462, 20);
            this.textBoxResultsHigher.TabIndex = 29;
            // 
            // comboBoxPolyOrderHigher
            // 
            this.comboBoxPolyOrderHigher.FormattingEnabled = true;
            this.comboBoxPolyOrderHigher.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxPolyOrderHigher.Location = new System.Drawing.Point(851, 57);
            this.comboBoxPolyOrderHigher.Name = "comboBoxPolyOrderHigher";
            this.comboBoxPolyOrderHigher.Size = new System.Drawing.Size(37, 21);
            this.comboBoxPolyOrderHigher.TabIndex = 30;
            this.comboBoxPolyOrderHigher.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "label2";
            // 
            // textBoxCurrentBound
            // 
            this.textBoxCurrentBound.Location = new System.Drawing.Point(832, 84);
            this.textBoxCurrentBound.Name = "textBoxCurrentBound";
            this.textBoxCurrentBound.Size = new System.Drawing.Size(56, 20);
            this.textBoxCurrentBound.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(895, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Current bound (for LED only)";
            // 
            // buttonSaveCoefficients
            // 
            this.buttonSaveCoefficients.Location = new System.Drawing.Point(1079, 495);
            this.buttonSaveCoefficients.Name = "buttonSaveCoefficients";
            this.buttonSaveCoefficients.Size = new System.Drawing.Size(109, 38);
            this.buttonSaveCoefficients.TabIndex = 35;
            this.buttonSaveCoefficients.Text = "Save coefficients to database";
            this.buttonSaveCoefficients.UseVisualStyleBackColor = true;
            this.buttonSaveCoefficients.Click += new System.EventHandler(this.buttonSaveCoefficients_Click);
            // 
            // CalibrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveCoefficients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCurrentBound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPolyOrderHigher);
            this.Controls.Add(this.textBoxResultsHigher);
            this.Controls.Add(this.comboBoxPolyOrderLower);
            this.Controls.Add(this.labelPolynomialOrder);
            this.Controls.Add(this.textBoxResultsLower);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.buttonDeleteAllCoefficients);
            this.Controls.Add(this.buttonDeleteCoefficients);
            this.Controls.Add(this.labelCoefficients);
            this.Controls.Add(this.labelChambers);
            this.Controls.Add(this.dataGridViewPolynomial);
            this.Controls.Add(this.dataGridViewChambers);
            this.Controls.Add(this.calibrationPlot);
            this.Controls.Add(this.buttonBeginCalibration);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFilePathPt100);
            this.Name = "CalibrationControl";
            this.Size = new System.Drawing.Size(1323, 625);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolynomial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoefficients;
        private System.Windows.Forms.Label labelChambers;
        private System.Windows.Forms.DataGridView dataGridViewPolynomial;
        private System.Windows.Forms.DataGridView dataGridViewChambers;
        private ZedGraph.ZedGraphControl calibrationPlot;
        private System.Windows.Forms.Button buttonBeginCalibration;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFilePathPt100;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonDeleteCoefficients;
        private System.Windows.Forms.Button buttonDeleteAllCoefficients;
        private System.Windows.Forms.Label labelPolynomialOrder;
        private System.Windows.Forms.ComboBox comboBoxPolyOrderLower;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.TextBox textBoxResultsLower;
        private System.Windows.Forms.TextBox textBoxResultsHigher;
        private System.Windows.Forms.ComboBox comboBoxPolyOrderHigher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentBound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveCoefficients;

    }
}
