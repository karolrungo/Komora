namespace Komora.Windows
{
    partial class MatlabWndow
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonLaunchMatlab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialogResults";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Enabled = false;
            this.textBoxFilename.Location = new System.Drawing.Point(71, 15);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(273, 20);
            this.textBoxFilename.TabIndex = 0;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(13, 18);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 1;
            this.labelFilename.Text = "Filename:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(130, 41);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(133, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonLaunchMatlab
            // 
            this.buttonLaunchMatlab.Location = new System.Drawing.Point(202, 92);
            this.buttonLaunchMatlab.Name = "buttonLaunchMatlab";
            this.buttonLaunchMatlab.Size = new System.Drawing.Size(127, 51);
            this.buttonLaunchMatlab.TabIndex = 3;
            this.buttonLaunchMatlab.Text = "Launch Matlab script";
            this.buttonLaunchMatlab.UseVisualStyleBackColor = true;
            this.buttonLaunchMatlab.Click += new System.EventHandler(this.buttonLaunchMatlab_Click);
            // 
            // MatlabWndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 181);
            this.Controls.Add(this.buttonLaunchMatlab);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.textBoxFilename);
            this.Name = "MatlabWndow";
            this.Text = "MatlabWndow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonLaunchMatlab;
    }
}