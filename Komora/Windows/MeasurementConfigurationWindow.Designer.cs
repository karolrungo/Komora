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
            // MeasurementConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.dgvChambers);
            this.Name = "MeasurementConfigurationWindow";
            this.Text = "MeasurementConfigurationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChambers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChambers;
    }
}