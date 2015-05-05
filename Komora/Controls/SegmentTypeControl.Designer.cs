namespace Komora.Controls
{
    partial class SegmentTypeControl
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
            this.rBthFinal = new System.Windows.Forms.RadioButton();
            this.rBtnIzothermal = new System.Windows.Forms.RadioButton();
            this.rBtnDynamic = new System.Windows.Forms.RadioButton();
            this.rBtnStart = new System.Windows.Forms.RadioButton();
            this.dynamicSegmentData1 = new Komora.Controls.DynamicSegmentData();
            this.izothermalSegmentData1 = new Komora.Controls.IzothermalSegmentData();
            this.startSegmentData1 = new Komora.Controls.StartSegmentData();
            this.SuspendLayout();
            // 
            // rBthFinal
            // 
            this.rBthFinal.AutoSize = true;
            this.rBthFinal.Location = new System.Drawing.Point(15, 84);
            this.rBthFinal.Name = "rBthFinal";
            this.rBthFinal.Size = new System.Drawing.Size(47, 17);
            this.rBthFinal.TabIndex = 7;
            this.rBthFinal.TabStop = true;
            this.rBthFinal.Text = "Final";
            this.rBthFinal.UseVisualStyleBackColor = true;
            // 
            // rBtnIzothermal
            // 
            this.rBtnIzothermal.AutoSize = true;
            this.rBtnIzothermal.Location = new System.Drawing.Point(15, 61);
            this.rBtnIzothermal.Name = "rBtnIzothermal";
            this.rBtnIzothermal.Size = new System.Drawing.Size(73, 17);
            this.rBtnIzothermal.TabIndex = 6;
            this.rBtnIzothermal.TabStop = true;
            this.rBtnIzothermal.Text = "Izothermal";
            this.rBtnIzothermal.UseVisualStyleBackColor = true;
            // 
            // rBtnDynamic
            // 
            this.rBtnDynamic.AutoSize = true;
            this.rBtnDynamic.Location = new System.Drawing.Point(15, 38);
            this.rBtnDynamic.Name = "rBtnDynamic";
            this.rBtnDynamic.Size = new System.Drawing.Size(66, 17);
            this.rBtnDynamic.TabIndex = 5;
            this.rBtnDynamic.TabStop = true;
            this.rBtnDynamic.Text = "Dynamic";
            this.rBtnDynamic.UseVisualStyleBackColor = true;
            // 
            // rBtnStart
            // 
            this.rBtnStart.AutoSize = true;
            this.rBtnStart.Location = new System.Drawing.Point(15, 15);
            this.rBtnStart.Name = "rBtnStart";
            this.rBtnStart.Size = new System.Drawing.Size(47, 17);
            this.rBtnStart.TabIndex = 4;
            this.rBtnStart.TabStop = true;
            this.rBtnStart.Text = "Start";
            this.rBtnStart.UseVisualStyleBackColor = true;
            // 
            // dynamicSegmentData1
            // 
            this.dynamicSegmentData1.Location = new System.Drawing.Point(117, 15);
            this.dynamicSegmentData1.Name = "dynamicSegmentData1";
            this.dynamicSegmentData1.Size = new System.Drawing.Size(276, 97);
            this.dynamicSegmentData1.TabIndex = 8;
            // 
            // izothermalSegmentData1
            // 
            this.izothermalSegmentData1.Location = new System.Drawing.Point(122, 32);
            this.izothermalSegmentData1.Name = "izothermalSegmentData1";
            this.izothermalSegmentData1.Size = new System.Drawing.Size(271, 69);
            this.izothermalSegmentData1.TabIndex = 9;
            // 
            // startSegmentData1
            // 
            this.startSegmentData1.Location = new System.Drawing.Point(122, 15);
            this.startSegmentData1.Name = "startSegmentData1";
            this.startSegmentData1.Size = new System.Drawing.Size(254, 79);
            this.startSegmentData1.TabIndex = 10;
            // 
            // SegmentTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startSegmentData1);
            this.Controls.Add(this.izothermalSegmentData1);
            this.Controls.Add(this.dynamicSegmentData1);
            this.Controls.Add(this.rBthFinal);
            this.Controls.Add(this.rBtnIzothermal);
            this.Controls.Add(this.rBtnDynamic);
            this.Controls.Add(this.rBtnStart);
            this.Name = "SegmentTypeControl";
            this.Size = new System.Drawing.Size(363, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBthFinal;
        private System.Windows.Forms.RadioButton rBtnIzothermal;
        private System.Windows.Forms.RadioButton rBtnDynamic;
        private System.Windows.Forms.RadioButton rBtnStart;
        private DynamicSegmentData dynamicSegmentData1;
        private IzothermalSegmentData izothermalSegmentData1;
        private StartSegmentData startSegmentData1;
    }
}
