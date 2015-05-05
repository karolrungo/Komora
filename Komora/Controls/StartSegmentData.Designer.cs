namespace Komora.Controls
{
    partial class StartSegmentData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbAcqRate = new System.Windows.Forms.TextBox();
            this.tbEndTemp = new System.Windows.Forms.TextBox();
            this.labelAcquisitionRate = new System.Windows.Forms.Label();
            this.labelEndTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "points / min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "oC";
            // 
            // TbAcqRate
            // 
            this.TbAcqRate.Location = new System.Drawing.Point(108, 38);
            this.TbAcqRate.Name = "TbAcqRate";
            this.TbAcqRate.Size = new System.Drawing.Size(56, 20);
            this.TbAcqRate.TabIndex = 9;
            // 
            // tbEndTemp
            // 
            this.tbEndTemp.Location = new System.Drawing.Point(108, 11);
            this.tbEndTemp.Name = "tbEndTemp";
            this.tbEndTemp.Size = new System.Drawing.Size(56, 20);
            this.tbEndTemp.TabIndex = 8;
            // 
            // labelAcquisitionRate
            // 
            this.labelAcquisitionRate.AutoSize = true;
            this.labelAcquisitionRate.Location = new System.Drawing.Point(19, 45);
            this.labelAcquisitionRate.Name = "labelAcquisitionRate";
            this.labelAcquisitionRate.Size = new System.Drawing.Size(82, 13);
            this.labelAcquisitionRate.TabIndex = 7;
            this.labelAcquisitionRate.Text = "Acquisition rate:";
            // 
            // labelEndTemp
            // 
            this.labelEndTemp.AutoSize = true;
            this.labelEndTemp.Location = new System.Drawing.Point(13, 19);
            this.labelEndTemp.Name = "labelEndTemp";
            this.labelEndTemp.Size = new System.Drawing.Size(88, 13);
            this.labelEndTemp.TabIndex = 6;
            this.labelEndTemp.Text = "End temperature:";
            // 
            // StartSegmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbAcqRate);
            this.Controls.Add(this.tbEndTemp);
            this.Controls.Add(this.labelAcquisitionRate);
            this.Controls.Add(this.labelEndTemp);
            this.Name = "StartSegmentData";
            this.Size = new System.Drawing.Size(254, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbAcqRate;
        private System.Windows.Forms.TextBox tbEndTemp;
        private System.Windows.Forms.Label labelAcquisitionRate;
        private System.Windows.Forms.Label labelEndTemp;
    }
}
