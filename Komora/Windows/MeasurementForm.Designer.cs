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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePlot = new System.Windows.Forms.TabPage();
            this.plot = new ZedGraph.ZedGraphControl();
            this.tabPageSegment = new System.Windows.Forms.TabPage();
            this.dgvSegmentList = new System.Windows.Forms.DataGridView();
            this.tabPageLCD = new System.Windows.Forms.TabPage();
            this.comboBoxLedBargraph = new System.Windows.Forms.ComboBox();
            this.labelLedBargraphMode = new System.Windows.Forms.Label();
            this.comboBoxTimeDisplayMode = new System.Windows.Forms.ComboBox();
            this.labelTimeDisplayMode = new System.Windows.Forms.Label();
            this.btnLCD_on_off = new System.Windows.Forms.Button();
            this.labelLcdContr = new System.Windows.Forms.Label();
            this.sliderLcdContr = new System.Windows.Forms.TrackBar();
            this.btnLcdScreenPlus = new System.Windows.Forms.Button();
            this.btnLcdScreenMinus = new System.Windows.Forms.Button();
            this.labelLcdScreen = new System.Windows.Forms.Label();
            this.tabPageMeasInfo = new System.Windows.Forms.TabPage();
            this.tabPageATCommand = new System.Windows.Forms.TabPage();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.labelPV = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelERR = new System.Windows.Forms.Label();
            this.measurementInfoControl = new Komora.Controls.MeasurementInfoControl();
            this.tabControl.SuspendLayout();
            this.tabPagePlot.SuspendLayout();
            this.tabPageSegment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).BeginInit();
            this.tabPageLCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLcdContr)).BeginInit();
            this.tabPageMeasInfo.SuspendLayout();
            this.tabPageATCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePlot);
            this.tabControl.Controls.Add(this.tabPageSegment);
            this.tabControl.Controls.Add(this.tabPageLCD);
            this.tabControl.Controls.Add(this.tabPageMeasInfo);
            this.tabControl.Controls.Add(this.tabPageATCommand);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1204, 476);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePlot
            // 
            this.tabPagePlot.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPagePlot.Controls.Add(this.plot);
            this.tabPagePlot.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlot.Name = "tabPagePlot";
            this.tabPagePlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlot.Size = new System.Drawing.Size(1196, 450);
            this.tabPagePlot.TabIndex = 0;
            this.tabPagePlot.Text = "Plot";
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(27, 4);
            this.plot.Name = "plot";
            this.plot.ScrollGrace = 0D;
            this.plot.ScrollMaxX = 0D;
            this.plot.ScrollMaxY = 0D;
            this.plot.ScrollMaxY2 = 0D;
            this.plot.ScrollMinX = 0D;
            this.plot.ScrollMinY = 0D;
            this.plot.ScrollMinY2 = 0D;
            this.plot.Size = new System.Drawing.Size(1148, 434);
            this.plot.TabIndex = 38;
            // 
            // tabPageSegment
            // 
            this.tabPageSegment.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageSegment.Controls.Add(this.dgvSegmentList);
            this.tabPageSegment.Location = new System.Drawing.Point(4, 22);
            this.tabPageSegment.Name = "tabPageSegment";
            this.tabPageSegment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSegment.Size = new System.Drawing.Size(1196, 450);
            this.tabPageSegment.TabIndex = 1;
            this.tabPageSegment.Text = "Segment Info";
            // 
            // dgvSegmentList
            // 
            this.dgvSegmentList.AllowUserToAddRows = false;
            this.dgvSegmentList.AllowUserToDeleteRows = false;
            this.dgvSegmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegmentList.Location = new System.Drawing.Point(288, 56);
            this.dgvSegmentList.Name = "dgvSegmentList";
            this.dgvSegmentList.ReadOnly = true;
            this.dgvSegmentList.Size = new System.Drawing.Size(660, 269);
            this.dgvSegmentList.TabIndex = 64;
            // 
            // tabPageLCD
            // 
            this.tabPageLCD.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageLCD.Controls.Add(this.comboBoxLedBargraph);
            this.tabPageLCD.Controls.Add(this.labelLedBargraphMode);
            this.tabPageLCD.Controls.Add(this.comboBoxTimeDisplayMode);
            this.tabPageLCD.Controls.Add(this.labelTimeDisplayMode);
            this.tabPageLCD.Controls.Add(this.btnLCD_on_off);
            this.tabPageLCD.Controls.Add(this.labelLcdContr);
            this.tabPageLCD.Controls.Add(this.sliderLcdContr);
            this.tabPageLCD.Controls.Add(this.btnLcdScreenPlus);
            this.tabPageLCD.Controls.Add(this.btnLcdScreenMinus);
            this.tabPageLCD.Controls.Add(this.labelLcdScreen);
            this.tabPageLCD.Location = new System.Drawing.Point(4, 22);
            this.tabPageLCD.Name = "tabPageLCD";
            this.tabPageLCD.Size = new System.Drawing.Size(1196, 450);
            this.tabPageLCD.TabIndex = 2;
            this.tabPageLCD.Text = "LCD";
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
            this.comboBoxLedBargraph.Location = new System.Drawing.Point(631, 215);
            this.comboBoxLedBargraph.Name = "comboBoxLedBargraph";
            this.comboBoxLedBargraph.Size = new System.Drawing.Size(133, 21);
            this.comboBoxLedBargraph.TabIndex = 73;
            this.comboBoxLedBargraph.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelLedBargraphMode
            // 
            this.labelLedBargraphMode.AutoSize = true;
            this.labelLedBargraphMode.Location = new System.Drawing.Point(647, 199);
            this.labelLedBargraphMode.Name = "labelLedBargraphMode";
            this.labelLedBargraphMode.Size = new System.Drawing.Size(102, 13);
            this.labelLedBargraphMode.TabIndex = 72;
            this.labelLedBargraphMode.Text = "LED bargraph mode";
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
            this.comboBoxTimeDisplayMode.Location = new System.Drawing.Point(472, 215);
            this.comboBoxTimeDisplayMode.Name = "comboBoxTimeDisplayMode";
            this.comboBoxTimeDisplayMode.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTimeDisplayMode.TabIndex = 71;
            this.comboBoxTimeDisplayMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeDisplayMode_SelectedIndexChanged);
            // 
            // labelTimeDisplayMode
            // 
            this.labelTimeDisplayMode.AutoSize = true;
            this.labelTimeDisplayMode.Location = new System.Drawing.Point(488, 199);
            this.labelTimeDisplayMode.Name = "labelTimeDisplayMode";
            this.labelTimeDisplayMode.Size = new System.Drawing.Size(94, 13);
            this.labelTimeDisplayMode.TabIndex = 70;
            this.labelTimeDisplayMode.Text = "Time display mode";
            // 
            // btnLCD_on_off
            // 
            this.btnLCD_on_off.Location = new System.Drawing.Point(509, 154);
            this.btnLCD_on_off.Name = "btnLCD_on_off";
            this.btnLCD_on_off.Size = new System.Drawing.Size(62, 23);
            this.btnLCD_on_off.TabIndex = 69;
            this.btnLCD_on_off.Text = "ON / OFF";
            this.btnLCD_on_off.UseVisualStyleBackColor = true;
            this.btnLCD_on_off.Click += new System.EventHandler(this.btnLCD_on_off_Click);
            // 
            // labelLcdContr
            // 
            this.labelLcdContr.AutoSize = true;
            this.labelLcdContr.Location = new System.Drawing.Point(645, 159);
            this.labelLcdContr.Name = "labelLcdContr";
            this.labelLcdContr.Size = new System.Drawing.Size(70, 13);
            this.labelLcdContr.TabIndex = 68;
            this.labelLcdContr.Text = "LCD Contrast";
            // 
            // sliderLcdContr
            // 
            this.sliderLcdContr.Location = new System.Drawing.Point(631, 127);
            this.sliderLcdContr.Maximum = 17;
            this.sliderLcdContr.Name = "sliderLcdContr";
            this.sliderLcdContr.Size = new System.Drawing.Size(118, 45);
            this.sliderLcdContr.TabIndex = 67;
            this.sliderLcdContr.ValueChanged += new System.EventHandler(this.sliderLcdContr_ValueChanged);
            // 
            // btnLcdScreenPlus
            // 
            this.btnLcdScreenPlus.Location = new System.Drawing.Point(577, 127);
            this.btnLcdScreenPlus.Name = "btnLcdScreenPlus";
            this.btnLcdScreenPlus.Size = new System.Drawing.Size(28, 23);
            this.btnLcdScreenPlus.TabIndex = 66;
            this.btnLcdScreenPlus.Text = ">>";
            this.btnLcdScreenPlus.UseVisualStyleBackColor = true;
            this.btnLcdScreenPlus.Click += new System.EventHandler(this.btnLcdScreenPlus_Click);
            // 
            // btnLcdScreenMinus
            // 
            this.btnLcdScreenMinus.Location = new System.Drawing.Point(472, 127);
            this.btnLcdScreenMinus.Name = "btnLcdScreenMinus";
            this.btnLcdScreenMinus.Size = new System.Drawing.Size(28, 23);
            this.btnLcdScreenMinus.TabIndex = 65;
            this.btnLcdScreenMinus.Text = "<<";
            this.btnLcdScreenMinus.UseVisualStyleBackColor = true;
            this.btnLcdScreenMinus.Click += new System.EventHandler(this.btnLcdScreenMinus_Click);
            // 
            // labelLcdScreen
            // 
            this.labelLcdScreen.AutoSize = true;
            this.labelLcdScreen.Location = new System.Drawing.Point(506, 132);
            this.labelLcdScreen.Name = "labelLcdScreen";
            this.labelLcdScreen.Size = new System.Drawing.Size(65, 13);
            this.labelLcdScreen.TabIndex = 64;
            this.labelLcdScreen.Text = "LCD Screen";
            // 
            // tabPageMeasInfo
            // 
            this.tabPageMeasInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageMeasInfo.Controls.Add(this.measurementInfoControl);
            this.tabPageMeasInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeasInfo.Name = "tabPageMeasInfo";
            this.tabPageMeasInfo.Size = new System.Drawing.Size(1196, 450);
            this.tabPageMeasInfo.TabIndex = 3;
            this.tabPageMeasInfo.Text = "Measurement info";
            // 
            // tabPageATCommand
            // 
            this.tabPageATCommand.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageATCommand.Controls.Add(this.listBoxCommands);
            this.tabPageATCommand.Controls.Add(this.btnSendCommand);
            this.tabPageATCommand.Controls.Add(this.tbCommand);
            this.tabPageATCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageATCommand.Name = "tabPageATCommand";
            this.tabPageATCommand.Size = new System.Drawing.Size(1196, 450);
            this.tabPageATCommand.TabIndex = 4;
            this.tabPageATCommand.Text = "Command history";
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(3, 3);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(439, 433);
            this.listBoxCommands.TabIndex = 54;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(763, 27);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(101, 23);
            this.btnSendCommand.TabIndex = 38;
            this.btnSendCommand.Text = "sendCommand";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(476, 27);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(270, 20);
            this.tbCommand.TabIndex = 37;
            this.tbCommand.Text = "ATI";
            // 
            // labelPV
            // 
            this.labelPV.AutoSize = true;
            this.labelPV.Location = new System.Drawing.Point(58, 513);
            this.labelPV.Name = "labelPV";
            this.labelPV.Size = new System.Drawing.Size(35, 13);
            this.labelPV.TabIndex = 1;
            this.labelPV.Text = "label1";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(155, 513);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(35, 13);
            this.labelSP.TabIndex = 2;
            this.labelSP.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PV: [oC]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SP: [oC]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ERR: [oC]";
            // 
            // labelERR
            // 
            this.labelERR.AutoSize = true;
            this.labelERR.Location = new System.Drawing.Point(249, 513);
            this.labelERR.Name = "labelERR";
            this.labelERR.Size = new System.Drawing.Size(35, 13);
            this.labelERR.TabIndex = 6;
            this.labelERR.Text = "label4";
            // 
            // measurementInfoControl
            // 
            this.measurementInfoControl.Location = new System.Drawing.Point(219, 77);
            this.measurementInfoControl.Name = "measurementInfoControl";
            this.measurementInfoControl.Size = new System.Drawing.Size(672, 256);
            this.measurementInfoControl.TabIndex = 53;
            // 
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 535);
            this.Controls.Add(this.labelERR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelPV);
            this.Controls.Add(this.tabControl);
            this.Name = "MeasurementForm";
            this.Text = "MeasurementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeasurementForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPagePlot.ResumeLayout(false);
            this.tabPageSegment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).EndInit();
            this.tabPageLCD.ResumeLayout(false);
            this.tabPageLCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLcdContr)).EndInit();
            this.tabPageMeasInfo.ResumeLayout(false);
            this.tabPageATCommand.ResumeLayout(false);
            this.tabPageATCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePlot;
        private ZedGraph.ZedGraphControl plot;
        private System.Windows.Forms.TabPage tabPageSegment;
        private System.Windows.Forms.DataGridView dgvSegmentList;
        private System.Windows.Forms.TabPage tabPageLCD;
        private System.Windows.Forms.ComboBox comboBoxLedBargraph;
        private System.Windows.Forms.Label labelLedBargraphMode;
        private System.Windows.Forms.ComboBox comboBoxTimeDisplayMode;
        private System.Windows.Forms.Label labelTimeDisplayMode;
        private System.Windows.Forms.Button btnLCD_on_off;
        private System.Windows.Forms.Label labelLcdContr;
        private System.Windows.Forms.TrackBar sliderLcdContr;
        private System.Windows.Forms.Button btnLcdScreenPlus;
        private System.Windows.Forms.Button btnLcdScreenMinus;
        private System.Windows.Forms.Label labelLcdScreen;
        private System.Windows.Forms.TabPage tabPageMeasInfo;
        private Controls.MeasurementInfoControl measurementInfoControl;
        private System.Windows.Forms.TabPage tabPageATCommand;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label labelPV;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelERR;

    }
}