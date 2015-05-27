namespace Komora.Windows
{
    partial class MainMenuForm
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
            this.btnMatlab = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.btnMeasurementConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatlab
            // 
            this.btnMatlab.Location = new System.Drawing.Point(91, 12);
            this.btnMatlab.Name = "btnMatlab";
            this.btnMatlab.Size = new System.Drawing.Size(101, 54);
            this.btnMatlab.TabIndex = 0;
            this.btnMatlab.Text = "Regulation Quality Indicators";
            this.btnMatlab.UseVisualStyleBackColor = true;
            this.btnMatlab.Click += new System.EventHandler(this.btnMatlab_Click);
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(91, 88);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(101, 43);
            this.btnTools.TabIndex = 1;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.Location = new System.Drawing.Point(91, 150);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(101, 39);
            this.buttonCalibration.TabIndex = 2;
            this.buttonCalibration.Text = "Calibration";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(209, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(111, 48);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // btnMeasurementConfiguration
            // 
            this.btnMeasurementConfiguration.Location = new System.Drawing.Point(209, 88);
            this.btnMeasurementConfiguration.Name = "btnMeasurementConfiguration";
            this.btnMeasurementConfiguration.Size = new System.Drawing.Size(111, 43);
            this.btnMeasurementConfiguration.TabIndex = 4;
            this.btnMeasurementConfiguration.Text = "Measurement configuration";
            this.btnMeasurementConfiguration.UseVisualStyleBackColor = true;
            this.btnMeasurementConfiguration.Click += new System.EventHandler(this.btnMeasurementConfiguration_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(this.btnMeasurementConfiguration);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonCalibration);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.btnMatlab);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatlab;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button btnMeasurementConfiguration;
    }
}