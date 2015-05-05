namespace Komora.Controls
{
    partial class IzothermalSegmentData
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
            this.tbAcquisitionrate = new System.Windows.Forms.TextBox();
            this.labelAcqRatePoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIsothermalTime = new System.Windows.Forms.TextBox();
            this.labelIzothermalTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "points / min";
            // 
            // tbAcquisitionrate
            // 
            this.tbAcquisitionrate.Location = new System.Drawing.Point(91, 31);
            this.tbAcquisitionrate.Name = "tbAcquisitionrate";
            this.tbAcquisitionrate.Size = new System.Drawing.Size(100, 20);
            this.tbAcquisitionrate.TabIndex = 19;
            // 
            // labelAcqRatePoints
            // 
            this.labelAcqRatePoints.AutoSize = true;
            this.labelAcqRatePoints.Location = new System.Drawing.Point(3, 38);
            this.labelAcqRatePoints.Name = "labelAcqRatePoints";
            this.labelAcqRatePoints.Size = new System.Drawing.Size(82, 13);
            this.labelAcqRatePoints.TabIndex = 18;
            this.labelAcqRatePoints.Text = "Acquisition rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "hh:mm";
            // 
            // tbIsothermalTime
            // 
            this.tbIsothermalTime.Location = new System.Drawing.Point(91, 5);
            this.tbIsothermalTime.Name = "tbIsothermalTime";
            this.tbIsothermalTime.Size = new System.Drawing.Size(100, 20);
            this.tbIsothermalTime.TabIndex = 16;
            // 
            // labelIzothermalTime
            // 
            this.labelIzothermalTime.AutoSize = true;
            this.labelIzothermalTime.Location = new System.Drawing.Point(3, 12);
            this.labelIzothermalTime.Name = "labelIzothermalTime";
            this.labelIzothermalTime.Size = new System.Drawing.Size(83, 13);
            this.labelIzothermalTime.TabIndex = 15;
            this.labelIzothermalTime.Text = "Isothermal time: ";
            // 
            // IzothermalSegmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAcquisitionrate);
            this.Controls.Add(this.labelAcqRatePoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIsothermalTime);
            this.Controls.Add(this.labelIzothermalTime);
            this.Name = "IzothermalSegmentData";
            this.Size = new System.Drawing.Size(271, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAcquisitionrate;
        private System.Windows.Forms.Label labelAcqRatePoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIsothermalTime;
        private System.Windows.Forms.Label labelIzothermalTime;
    }
}
