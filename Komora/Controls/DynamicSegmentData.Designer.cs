namespace Komora.Controls
{
    partial class DynamicSegmentData
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbAcquisitionRate = new System.Windows.Forms.TextBox();
            this.labelAcqRatePoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHeatingRate = new System.Windows.Forms.TextBox();
            this.labelHeatingRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEndTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "points / min";
            // 
            // tbAcquisitionRate
            // 
            this.tbAcquisitionRate.Location = new System.Drawing.Point(100, 58);
            this.tbAcquisitionRate.Name = "tbAcquisitionRate";
            this.tbAcquisitionRate.Size = new System.Drawing.Size(100, 20);
            this.tbAcquisitionRate.TabIndex = 16;
            // 
            // labelAcqRatePoints
            // 
            this.labelAcqRatePoints.AutoSize = true;
            this.labelAcqRatePoints.Location = new System.Drawing.Point(12, 65);
            this.labelAcqRatePoints.Name = "labelAcqRatePoints";
            this.labelAcqRatePoints.Size = new System.Drawing.Size(82, 13);
            this.labelAcqRatePoints.TabIndex = 15;
            this.labelAcqRatePoints.Text = "Acquisition rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "K / min";
            // 
            // tbHeatingRate
            // 
            this.tbHeatingRate.Location = new System.Drawing.Point(100, 32);
            this.tbHeatingRate.Name = "tbHeatingRate";
            this.tbHeatingRate.Size = new System.Drawing.Size(100, 20);
            this.tbHeatingRate.TabIndex = 13;
            // 
            // labelHeatingRate
            // 
            this.labelHeatingRate.AutoSize = true;
            this.labelHeatingRate.Location = new System.Drawing.Point(23, 39);
            this.labelHeatingRate.Name = "labelHeatingRate";
            this.labelHeatingRate.Size = new System.Drawing.Size(71, 13);
            this.labelHeatingRate.TabIndex = 12;
            this.labelHeatingRate.Text = "Heating rate: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "oC";
            // 
            // tbEndTemperature
            // 
            this.tbEndTemperature.Location = new System.Drawing.Point(100, 8);
            this.tbEndTemperature.Name = "tbEndTemperature";
            this.tbEndTemperature.Size = new System.Drawing.Size(100, 20);
            this.tbEndTemperature.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "End temperature: ";
            // 
            // DynamicSegmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAcquisitionRate);
            this.Controls.Add(this.labelAcqRatePoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHeatingRate);
            this.Controls.Add(this.labelHeatingRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEndTemperature);
            this.Controls.Add(this.label1);
            this.Name = "DynamicSegmentData";
            this.Size = new System.Drawing.Size(276, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAcquisitionRate;
        private System.Windows.Forms.Label labelAcqRatePoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHeatingRate;
        private System.Windows.Forms.Label labelHeatingRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEndTemperature;
        private System.Windows.Forms.Label label1;
    }
}
