namespace Komora.Controls
{
    partial class DateAndTimeDifferenceCalculator
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
            this.dateAndTimePickerEnd = new Komora.Controls.DateAndTimePicker();
            this.dateAndTimePickerStart = new Komora.Controls.DateAndTimePicker();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Finish:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start:";
            // 
            // dateAndTimePickerEnd
            // 
            this.dateAndTimePickerEnd.Location = new System.Drawing.Point(51, 51);
            this.dateAndTimePickerEnd.Name = "dateAndTimePickerEnd";
            this.dateAndTimePickerEnd.Size = new System.Drawing.Size(212, 53);
            this.dateAndTimePickerEnd.TabIndex = 5;
            // 
            // dateAndTimePickerStart
            // 
            this.dateAndTimePickerStart.Location = new System.Drawing.Point(51, 3);
            this.dateAndTimePickerStart.Name = "dateAndTimePickerStart";
            this.dateAndTimePickerStart.Size = new System.Drawing.Size(212, 53);
            this.dateAndTimePickerStart.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(48, 107);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "label3";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(84, 145);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(122, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate difference";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // DateAndTimeDifferenceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAndTimePickerEnd);
            this.Controls.Add(this.dateAndTimePickerStart);
            this.Name = "DateAndTimeDifferenceCalculator";
            this.Size = new System.Drawing.Size(274, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DateAndTimePicker dateAndTimePickerEnd;
        private DateAndTimePicker dateAndTimePickerStart;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
    }
}
