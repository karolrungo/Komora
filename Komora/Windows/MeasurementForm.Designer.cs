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
            this.measurementInfoControl = new Komora.Controls.MeasurementInfoControl();
            this.plot = new ZedGraph.ZedGraphControl();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.dgvSegmentList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).BeginInit();
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
            // measurementInfoControl
            // 
            this.measurementInfoControl.Location = new System.Drawing.Point(483, 350);
            this.measurementInfoControl.Name = "measurementInfoControl";
            this.measurementInfoControl.Size = new System.Drawing.Size(672, 256);
            this.measurementInfoControl.TabIndex = 2;
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
            this.plot.Size = new System.Drawing.Size(807, 322);
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
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 618);
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
    }
}