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
            this.measurementInfoControl1 = new Komora.Controls.MeasurementInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChambers
            // 
            this.dgvChambers.AllowUserToAddRows = false;
            this.dgvChambers.AllowUserToDeleteRows = false;
            this.dgvChambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChambers.Location = new System.Drawing.Point(13, 13);
            this.dgvChambers.Name = "dgvChambers";
            this.dgvChambers.ReadOnly = true;
            this.dgvChambers.Size = new System.Drawing.Size(449, 142);
            this.dgvChambers.TabIndex = 0;
            // 
            // btnStartMeasurement
            // 
            this.btnStartMeasurement.Location = new System.Drawing.Point(520, 13);
            this.btnStartMeasurement.Name = "btnStartMeasurement";
            this.btnStartMeasurement.Size = new System.Drawing.Size(150, 64);
            this.btnStartMeasurement.TabIndex = 1;
            this.btnStartMeasurement.Text = "StartMeasurement";
            this.btnStartMeasurement.UseVisualStyleBackColor = true;
            this.btnStartMeasurement.Click += new System.EventHandler(this.btnStartMeasurement_Click);
            // 
            // measurementInfoControl1
            // 
            this.measurementInfoControl1.Location = new System.Drawing.Point(13, 161);
            this.measurementInfoControl1.Name = "measurementInfoControl1";
            this.measurementInfoControl1.Size = new System.Drawing.Size(672, 256);
            this.measurementInfoControl1.TabIndex = 2;
            // 
            // MeasurementConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 421);
            this.Controls.Add(this.measurementInfoControl1);
            this.Controls.Add(this.btnStartMeasurement);
            this.Controls.Add(this.dgvChambers);
            this.Name = "MeasurementConfigurationWindow";
            this.Text = "MeasurementConfigurationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChambers;
        private System.Windows.Forms.Button btnStartMeasurement;
        private Controls.MeasurementInfoControl measurementInfoControl1;
    }
}