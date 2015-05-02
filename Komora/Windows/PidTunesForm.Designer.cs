namespace Komora.Windows
{
    partial class PidTunesForm
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
            this.btnLoadTunes = new System.Windows.Forms.Button();
            this.tbDiodeScal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeaterScal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbDiodeKD = new System.Windows.Forms.TextBox();
            this.tbDiodeKI = new System.Windows.Forms.TextBox();
            this.tbDiodeKP = new System.Windows.Forms.TextBox();
            this.tbHeaterKD = new System.Windows.Forms.TextBox();
            this.tbHeaterKI = new System.Windows.Forms.TextBox();
            this.tbHeaterKP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDiode = new System.Windows.Forms.Label();
            this.labelHeater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadTunes
            // 
            this.btnLoadTunes.Location = new System.Drawing.Point(96, 12);
            this.btnLoadTunes.Name = "btnLoadTunes";
            this.btnLoadTunes.Size = new System.Drawing.Size(86, 35);
            this.btnLoadTunes.TabIndex = 40;
            this.btnLoadTunes.Text = "Read tunes from device";
            this.btnLoadTunes.UseVisualStyleBackColor = true;
            this.btnLoadTunes.Click += new System.EventHandler(this.btnLoadTunes_Click);
            // 
            // tbDiodeScal
            // 
            this.tbDiodeScal.Location = new System.Drawing.Point(176, 257);
            this.tbDiodeScal.Name = "tbDiodeScal";
            this.tbDiodeScal.Size = new System.Drawing.Size(100, 20);
            this.tbDiodeScal.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Scal:";
            // 
            // tbHeaterScal
            // 
            this.tbHeaterScal.Location = new System.Drawing.Point(176, 112);
            this.tbHeaterScal.Name = "tbHeaterScal";
            this.tbHeaterScal.Size = new System.Drawing.Size(100, 20);
            this.tbHeaterScal.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Scal:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 35);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Submit changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDiodeKD
            // 
            this.tbDiodeKD.Location = new System.Drawing.Point(56, 283);
            this.tbDiodeKD.Name = "tbDiodeKD";
            this.tbDiodeKD.Size = new System.Drawing.Size(100, 20);
            this.tbDiodeKD.TabIndex = 34;
            // 
            // tbDiodeKI
            // 
            this.tbDiodeKI.Location = new System.Drawing.Point(56, 253);
            this.tbDiodeKI.Name = "tbDiodeKI";
            this.tbDiodeKI.Size = new System.Drawing.Size(100, 20);
            this.tbDiodeKI.TabIndex = 33;
            // 
            // tbDiodeKP
            // 
            this.tbDiodeKP.Location = new System.Drawing.Point(56, 221);
            this.tbDiodeKP.Name = "tbDiodeKP";
            this.tbDiodeKP.Size = new System.Drawing.Size(100, 20);
            this.tbDiodeKP.TabIndex = 32;
            // 
            // tbHeaterKD
            // 
            this.tbHeaterKD.Location = new System.Drawing.Point(56, 147);
            this.tbHeaterKD.Name = "tbHeaterKD";
            this.tbHeaterKD.Size = new System.Drawing.Size(100, 20);
            this.tbHeaterKD.TabIndex = 31;
            // 
            // tbHeaterKI
            // 
            this.tbHeaterKI.Location = new System.Drawing.Point(56, 112);
            this.tbHeaterKI.Name = "tbHeaterKI";
            this.tbHeaterKI.Size = new System.Drawing.Size(100, 20);
            this.tbHeaterKI.TabIndex = 30;
            // 
            // tbHeaterKP
            // 
            this.tbHeaterKP.Location = new System.Drawing.Point(56, 84);
            this.tbHeaterKP.Name = "tbHeaterKP";
            this.tbHeaterKP.Size = new System.Drawing.Size(100, 20);
            this.tbHeaterKP.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Kp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ki:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kd:";
            // 
            // labelDiode
            // 
            this.labelDiode.AutoSize = true;
            this.labelDiode.Location = new System.Drawing.Point(16, 190);
            this.labelDiode.Name = "labelDiode";
            this.labelDiode.Size = new System.Drawing.Size(41, 13);
            this.labelDiode.TabIndex = 22;
            this.labelDiode.Text = "DIODE";
            // 
            // labelHeater
            // 
            this.labelHeater.AutoSize = true;
            this.labelHeater.Location = new System.Drawing.Point(16, 59);
            this.labelHeater.Name = "labelHeater";
            this.labelHeater.Size = new System.Drawing.Size(51, 13);
            this.labelHeater.TabIndex = 21;
            this.labelHeater.Text = "HEATER";
            // 
            // PidTunesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 376);
            this.Controls.Add(this.btnLoadTunes);
            this.Controls.Add(this.tbDiodeScal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbHeaterScal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDiodeKD);
            this.Controls.Add(this.tbDiodeKI);
            this.Controls.Add(this.tbDiodeKP);
            this.Controls.Add(this.tbHeaterKD);
            this.Controls.Add(this.tbHeaterKI);
            this.Controls.Add(this.tbHeaterKP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDiode);
            this.Controls.Add(this.labelHeater);
            this.Name = "PidTunesForm";
            this.Text = "PidTunesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PidTunesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTunes;
        private System.Windows.Forms.TextBox tbDiodeScal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHeaterScal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDiodeKD;
        private System.Windows.Forms.TextBox tbDiodeKI;
        private System.Windows.Forms.TextBox tbDiodeKP;
        private System.Windows.Forms.TextBox tbHeaterKD;
        private System.Windows.Forms.TextBox tbHeaterKI;
        private System.Windows.Forms.TextBox tbHeaterKP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDiode;
        private System.Windows.Forms.Label labelHeater;
    }
}