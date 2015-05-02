namespace Komora.Windows
{
    partial class MeasurementConfigurationWindow
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
            this.dgvChambers = new System.Windows.Forms.DataGridView();
            this.btnStartMeasurement = new System.Windows.Forms.Button();
            this.measurementInfoControl = new Komora.Controls.MeasurementInfoControl();
            this.textBoxAvaliblePorts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChambers
            // 
            this.dgvChambers.AllowUserToAddRows = false;
            this.dgvChambers.AllowUserToDeleteRows = false;
            this.dgvChambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambers.Location = new System.Drawing.Point(13, 12);
            this.dgvChambers.Name = "dgvChambers";
            this.dgvChambers.ReadOnly = true;
            this.dgvChambers.Size = new System.Drawing.Size(449, 174);
            this.dgvChambers.TabIndex = 0;
            // 
            // btnStartMeasurement
            // 
            this.btnStartMeasurement.Location = new System.Drawing.Point(483, 122);
            this.btnStartMeasurement.Name = "btnStartMeasurement";
            this.btnStartMeasurement.Size = new System.Drawing.Size(150, 64);
            this.btnStartMeasurement.TabIndex = 1;
            this.btnStartMeasurement.Text = "StartMeasurement";
            this.btnStartMeasurement.UseVisualStyleBackColor = true;
            this.btnStartMeasurement.Click += new System.EventHandler(this.btnStartMeasurement_Click);
            // 
            // measurementInfoControl
            // 
            this.measurementInfoControl.Location = new System.Drawing.Point(13, 192);
            this.measurementInfoControl.Name = "measurementInfoControl";
            this.measurementInfoControl.Size = new System.Drawing.Size(672, 256);
            this.measurementInfoControl.TabIndex = 2;
            // 
            // textBoxAvaliblePorts
            // 
            this.textBoxAvaliblePorts.Location = new System.Drawing.Point(483, 12);
            this.textBoxAvaliblePorts.Multiline = true;
            this.textBoxAvaliblePorts.Name = "textBoxAvaliblePorts";
            this.textBoxAvaliblePorts.ReadOnly = true;
            this.textBoxAvaliblePorts.Size = new System.Drawing.Size(150, 89);
            this.textBoxAvaliblePorts.TabIndex = 21;
            // 
            // MeasurementConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 449);
            this.Controls.Add(this.textBoxAvaliblePorts);
            this.Controls.Add(this.measurementInfoControl);
            this.Controls.Add(this.btnStartMeasurement);
            this.Controls.Add(this.dgvChambers);
            this.Name = "MeasurementConfigurationWindow";
            this.Text = "MeasurementConfigurationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChambers;
        private System.Windows.Forms.Button btnStartMeasurement;
        private Controls.MeasurementInfoControl measurementInfoControl;
        private System.Windows.Forms.TextBox textBoxAvaliblePorts;
    }
}