namespace Komora.Windows
{
    partial class MeasurementForm
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
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.plot = new ZedGraph.ZedGraphControl();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.dgvSegmentList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLCD_on_off = new System.Windows.Forms.Button();
            this.labelLcdContr = new System.Windows.Forms.Label();
            this.sliderLcdContr = new System.Windows.Forms.TrackBar();
            this.btnLcdScreenPlus = new System.Windows.Forms.Button();
            this.btnLcdScreenMinus = new System.Windows.Forms.Button();
            this.labelLcdScreen = new System.Windows.Forms.Label();
            this.labelTimeDisplayMode = new System.Windows.Forms.Label();
            this.comboBoxTimeDisplayMode = new System.Windows.Forms.ComboBox();
            this.measurementInfoControl = new Komora.Controls.MeasurementInfoControl();
            this.comboBoxLedBargraph = new System.Windows.Forms.ComboBox();
            this.labelLedBargraphMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLcdContr)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(46, 566);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(270, 20);
            this.tbCommand.TabIndex = 0;
            this.tbCommand.Text = "ATI";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(333, 566);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(101, 23);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "sendCommand";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(21, 22);
            this.plot.Name = "plot";
            this.plot.ScrollGrace = 0D;
            this.plot.ScrollMaxX = 0D;
            this.plot.ScrollMaxY = 0D;
            this.plot.ScrollMaxY2 = 0D;
            this.plot.ScrollMinX = 0D;
            this.plot.ScrollMinY = 0D;
            this.plot.ScrollMinY2 = 0D;
            this.plot.Size = new System.Drawing.Size(441, 322);
            this.plot.TabIndex = 19;
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(865, 22);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(299, 329);
            this.listBoxCommands.TabIndex = 20;
            // 
            // dgvSegmentList
            // 
            this.dgvSegmentList.AllowUserToAddRows = false;
            this.dgvSegmentList.AllowUserToDeleteRows = false;
            this.dgvSegmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegmentList.Location = new System.Drawing.Point(21, 368);
            this.dgvSegmentList.Name = "dgvSegmentList";
            this.dgvSegmentList.ReadOnly = true;
            this.dgvSegmentList.Size = new System.Drawing.Size(456, 176);
            this.dgvSegmentList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // btnLCD_on_off
            // 
            this.btnLCD_on_off.Location = new System.Drawing.Point(549, 78);
            this.btnLCD_on_off.Name = "btnLCD_on_off";
            this.btnLCD_on_off.Size = new System.Drawing.Size(62, 23);
            this.btnLCD_on_off.TabIndex = 30;
            this.btnLCD_on_off.Text = "ON / OFF";
            this.btnLCD_on_off.UseVisualStyleBackColor = true;
            this.btnLCD_on_off.Click += new System.EventHandler(this.btnLCD_on_off_Click);
            // 
            // labelLcdContr
            // 
            this.labelLcdContr.AutoSize = true;
            this.labelLcdContr.Location = new System.Drawing.Point(685, 83);
            this.labelLcdContr.Name = "labelLcdContr";
            this.labelLcdContr.Size = new System.Drawing.Size(70, 13);
            this.labelLcdContr.TabIndex = 29;
            this.labelLcdContr.Text = "LCD Contrast";
            // 
            // sliderLcdContr
            // 
            this.sliderLcdContr.Location = new System.Drawing.Point(671, 51);
            this.sliderLcdContr.Maximum = 17;
            this.sliderLcdContr.Name = "sliderLcdContr";
            this.sliderLcdContr.Size = new System.Drawing.Size(118, 45);
            this.sliderLcdContr.TabIndex = 28;
            this.sliderLcdContr.ValueChanged += new System.EventHandler(this.sliderLcdContr_ValueChanged);
            // 
            // btnLcdScreenPlus
            // 
            this.btnLcdScreenPlus.Location = new System.Drawing.Point(617, 51);
            this.btnLcdScreenPlus.Name = "btnLcdScreenPlus";
            this.btnLcdScreenPlus.Size = new System.Drawing.Size(28, 23);
            this.btnLcdScreenPlus.TabIndex = 27;
            this.btnLcdScreenPlus.Text = ">>";
            this.btnLcdScreenPlus.UseVisualStyleBackColor = true;
            this.btnLcdScreenPlus.Click += new System.EventHandler(this.btnLcdScreenPlus_Click);
            // 
            // btnLcdScreenMinus
            // 
            this.btnLcdScreenMinus.Location = new System.Drawing.Point(512, 51);
            this.btnLcdScreenMinus.Name = "btnLcdScreenMinus";
            this.btnLcdScreenMinus.Size = new System.Drawing.Size(28, 23);
            this.btnLcdScreenMinus.TabIndex = 26;
            this.btnLcdScreenMinus.Text = "<<";
            this.btnLcdScreenMinus.UseVisualStyleBackColor = true;
            this.btnLcdScreenMinus.Click += new System.EventHandler(this.btnLcdScreenMinus_Click);
            // 
            // labelLcdScreen
            // 
            this.labelLcdScreen.AutoSize = true;
            this.labelLcdScreen.Location = new System.Drawing.Point(546, 56);
            this.labelLcdScreen.Name = "labelLcdScreen";
            this.labelLcdScreen.Size = new System.Drawing.Size(65, 13);
            this.labelLcdScreen.TabIndex = 25;
            this.labelLcdScreen.Text = "LDC Screen";
            // 
            // labelTimeDisplayMode
            // 
            this.labelTimeDisplayMode.AutoSize = true;
            this.labelTimeDisplayMode.Location = new System.Drawing.Point(528, 123);
            this.labelTimeDisplayMode.Name = "labelTimeDisplayMode";
            this.labelTimeDisplayMode.Size = new System.Drawing.Size(94, 13);
            this.labelTimeDisplayMode.TabIndex = 31;
            this.labelTimeDisplayMode.Text = "Time display mode";
            // 
            // comboBoxTimeDisplayMode
            // 
            this.comboBoxTimeDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeDisplayMode.FormattingEnabled = true;
            this.comboBoxTimeDisplayMode.Items.AddRange(new object[] {
            "TIME",
            "DATE",
            "WEEKDAY",
            "ERROR"});
            this.comboBoxTimeDisplayMode.Location = new System.Drawing.Point(512, 139);
            this.comboBoxTimeDisplayMode.Name = "comboBoxTimeDisplayMode";
            this.comboBoxTimeDisplayMode.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTimeDisplayMode.TabIndex = 32;
            this.comboBoxTimeDisplayMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeDisplayMode_SelectedIndexChanged);
            // 
            // measurementInfoControl
            // 
            this.measurementInfoControl.Location = new System.Drawing.Point(483, 350);
            this.measurementInfoControl.Name = "measurementInfoControl";
            this.measurementInfoControl.Size = new System.Drawing.Size(672, 256);
            this.measurementInfoControl.TabIndex = 2;
            // 
            // comboBoxLedBargraph
            // 
            this.comboBoxLedBargraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLedBargraph.FormattingEnabled = true;
            this.comboBoxLedBargraph.Items.AddRange(new object[] {
            "OFF",
            "HEATER_CV",
            "DIODE_CV",
            "HEATER_POWER",
            "DIODE_POWER",
            "ERROR"});
            this.comboBoxLedBargraph.Location = new System.Drawing.Point(671, 139);
            this.comboBoxLedBargraph.Name = "comboBoxLedBargraph";
            this.comboBoxLedBargraph.Size = new System.Drawing.Size(133, 21);
            this.comboBoxLedBargraph.TabIndex = 34;
            this.comboBoxLedBargraph.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelLedBargraphMode
            // 
            this.labelLedBargraphMode.AutoSize = true;
            this.labelLedBargraphMode.Location = new System.Drawing.Point(687, 123);
            this.labelLedBargraphMode.Name = "labelLedBargraphMode";
            this.labelLedBargraphMode.Size = new System.Drawing.Size(102, 13);
            this.labelLedBargraphMode.TabIndex = 33;
            this.labelLedBargraphMode.Text = "LED bargraph mode";
            // 
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 618);
            this.Controls.Add(this.comboBoxLedBargraph);
            this.Controls.Add(this.labelLedBargraphMode);
            this.Controls.Add(this.comboBoxTimeDisplayMode);
            this.Controls.Add(this.labelTimeDisplayMode);
            this.Controls.Add(this.btnLCD_on_off);
            this.Controls.Add(this.labelLcdContr);
            this.Controls.Add(this.sliderLcdContr);
            this.Controls.Add(this.btnLcdScreenPlus);
            this.Controls.Add(this.btnLcdScreenMinus);
            this.Controls.Add(this.labelLcdScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSegmentList);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.measurementInfoControl);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.tbCommand);
            this.Name = "MeasurementForm";
            this.Text = "MeasurementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeasurementForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLcdContr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button btnSendCommand;
        private Controls.MeasurementInfoControl measurementInfoControl;
        private ZedGraph.ZedGraphControl plot;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.DataGridView dgvSegmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLCD_on_off;
        private System.Windows.Forms.Label labelLcdContr;
        private System.Windows.Forms.TrackBar sliderLcdContr;
        private System.Windows.Forms.Button btnLcdScreenPlus;
        private System.Windows.Forms.Button btnLcdScreenMinus;
        private System.Windows.Forms.Label labelLcdScreen;
        private System.Windows.Forms.Label labelTimeDisplayMode;
        private System.Windows.Forms.ComboBox comboBoxTimeDisplayMode;
        private System.Windows.Forms.ComboBox comboBoxLedBargraph;
        private System.Windows.Forms.Label labelLedBargraphMode;
    }
}