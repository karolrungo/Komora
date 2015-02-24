namespace Komora.Windows
{
    partial class SettingsWindow
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
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageChambers = new System.Windows.Forms.TabPage();
            this.dataGridViewChambers = new System.Windows.Forms.DataGridView();
            this.labelHardwareConfChamberName = new System.Windows.Forms.Label();
            this.btnDeleteChamber = new System.Windows.Forms.Button();
            this.btnEditChamber = new System.Windows.Forms.Button();
            this.btnAddChamber = new System.Windows.Forms.Button();
            this.comboBoxHardwareConfChamberNumber = new System.Windows.Forms.ComboBox();
            this.textBoxHardwareConfSerialPortName = new System.Windows.Forms.TextBox();
            this.textBoxHardwareConfChamberName = new System.Windows.Forms.TextBox();
            this.labelHardwareConfChamberNumber = new System.Windows.Forms.Label();
            this.labelHardwareConfSerialPortName = new System.Windows.Forms.Label();
            this.tabControlSettings.SuspendLayout();
            this.tabPageChambers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageChambers);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(698, 262);
            this.tabControlSettings.TabIndex = 2;
            // 
            // tabPageChambers
            // 
            this.tabPageChambers.Controls.Add(this.btnDeleteChamber);
            this.tabPageChambers.Controls.Add(this.btnEditChamber);
            this.tabPageChambers.Controls.Add(this.btnAddChamber);
            this.tabPageChambers.Controls.Add(this.comboBoxHardwareConfChamberNumber);
            this.tabPageChambers.Controls.Add(this.textBoxHardwareConfSerialPortName);
            this.tabPageChambers.Controls.Add(this.textBoxHardwareConfChamberName);
            this.tabPageChambers.Controls.Add(this.labelHardwareConfChamberNumber);
            this.tabPageChambers.Controls.Add(this.labelHardwareConfSerialPortName);
            this.tabPageChambers.Controls.Add(this.labelHardwareConfChamberName);
            this.tabPageChambers.Controls.Add(this.dataGridViewChambers);
            this.tabPageChambers.Location = new System.Drawing.Point(4, 22);
            this.tabPageChambers.Name = "tabPageChambers";
            this.tabPageChambers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChambers.Size = new System.Drawing.Size(690, 236);
            this.tabPageChambers.TabIndex = 0;
            this.tabPageChambers.Text = "Chambers";
            this.tabPageChambers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChambers
            // 
            this.dataGridViewChambers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChambers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewChambers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewChambers.Name = "dataGridViewChambers";
            this.dataGridViewChambers.Size = new System.Drawing.Size(383, 230);
            this.dataGridViewChambers.TabIndex = 2;
            this.dataGridViewChambers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewChambers_RowHeaderMouseClick);
            // 
            // labelHardwareConfChamberName
            // 
            this.labelHardwareConfChamberName.AutoSize = true;
            this.labelHardwareConfChamberName.Location = new System.Drawing.Point(392, 16);
            this.labelHardwareConfChamberName.Name = "labelHardwareConfChamberName";
            this.labelHardwareConfChamberName.Size = new System.Drawing.Size(80, 13);
            this.labelHardwareConfChamberName.TabIndex = 4;
            this.labelHardwareConfChamberName.Text = "Chamber Name";
            // 
            // btnDeleteChamber
            // 
            this.btnDeleteChamber.Location = new System.Drawing.Point(591, 85);
            this.btnDeleteChamber.Name = "btnDeleteChamber";
            this.btnDeleteChamber.Size = new System.Drawing.Size(91, 36);
            this.btnDeleteChamber.TabIndex = 19;
            this.btnDeleteChamber.Text = "Delete chamber";
            this.btnDeleteChamber.UseVisualStyleBackColor = true;
            // 
            // btnEditChamber
            // 
            this.btnEditChamber.Location = new System.Drawing.Point(497, 85);
            this.btnEditChamber.Name = "btnEditChamber";
            this.btnEditChamber.Size = new System.Drawing.Size(88, 36);
            this.btnEditChamber.TabIndex = 18;
            this.btnEditChamber.Text = "Edit chamber";
            this.btnEditChamber.UseVisualStyleBackColor = true;
            // 
            // btnAddChamber
            // 
            this.btnAddChamber.Location = new System.Drawing.Point(405, 85);
            this.btnAddChamber.Name = "btnAddChamber";
            this.btnAddChamber.Size = new System.Drawing.Size(86, 36);
            this.btnAddChamber.TabIndex = 17;
            this.btnAddChamber.Text = "Add chamber";
            this.btnAddChamber.UseVisualStyleBackColor = true;
            this.btnAddChamber.Click += new System.EventHandler(this.btnAddChamber_Click);
            // 
            // comboBoxHardwareConfChamberNumber
            // 
            this.comboBoxHardwareConfChamberNumber.FormattingEnabled = true;
            this.comboBoxHardwareConfChamberNumber.Location = new System.Drawing.Point(486, 61);
            this.comboBoxHardwareConfChamberNumber.Name = "comboBoxHardwareConfChamberNumber";
            this.comboBoxHardwareConfChamberNumber.Size = new System.Drawing.Size(40, 21);
            this.comboBoxHardwareConfChamberNumber.TabIndex = 16;
            // 
            // textBoxHardwareConfSerialPortName
            // 
            this.textBoxHardwareConfSerialPortName.Location = new System.Drawing.Point(486, 35);
            this.textBoxHardwareConfSerialPortName.Name = "textBoxHardwareConfSerialPortName";
            this.textBoxHardwareConfSerialPortName.Size = new System.Drawing.Size(121, 20);
            this.textBoxHardwareConfSerialPortName.TabIndex = 15;
            // 
            // textBoxHardwareConfChamberName
            // 
            this.textBoxHardwareConfChamberName.Location = new System.Drawing.Point(486, 9);
            this.textBoxHardwareConfChamberName.Name = "textBoxHardwareConfChamberName";
            this.textBoxHardwareConfChamberName.Size = new System.Drawing.Size(121, 20);
            this.textBoxHardwareConfChamberName.TabIndex = 14;
            // 
            // labelHardwareConfChamberNumber
            // 
            this.labelHardwareConfChamberNumber.AutoSize = true;
            this.labelHardwareConfChamberNumber.Location = new System.Drawing.Point(392, 69);
            this.labelHardwareConfChamberNumber.Name = "labelHardwareConfChamberNumber";
            this.labelHardwareConfChamberNumber.Size = new System.Drawing.Size(89, 13);
            this.labelHardwareConfChamberNumber.TabIndex = 13;
            this.labelHardwareConfChamberNumber.Text = "Chamber Number";
            // 
            // labelHardwareConfSerialPortName
            // 
            this.labelHardwareConfSerialPortName.AutoSize = true;
            this.labelHardwareConfSerialPortName.Location = new System.Drawing.Point(392, 42);
            this.labelHardwareConfSerialPortName.Name = "labelHardwareConfSerialPortName";
            this.labelHardwareConfSerialPortName.Size = new System.Drawing.Size(55, 13);
            this.labelHardwareConfSerialPortName.TabIndex = 12;
            this.labelHardwareConfSerialPortName.Text = "Serial Port";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageChambers.ResumeLayout(false);
            this.tabPageChambers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChambers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageChambers;
        private System.Windows.Forms.DataGridView dataGridViewChambers;
        private System.Windows.Forms.Button btnDeleteChamber;
        private System.Windows.Forms.Button btnEditChamber;
        private System.Windows.Forms.Button btnAddChamber;
        private System.Windows.Forms.ComboBox comboBoxHardwareConfChamberNumber;
        private System.Windows.Forms.TextBox textBoxHardwareConfSerialPortName;
        private System.Windows.Forms.TextBox textBoxHardwareConfChamberName;
        private System.Windows.Forms.Label labelHardwareConfChamberNumber;
        private System.Windows.Forms.Label labelHardwareConfSerialPortName;
        private System.Windows.Forms.Label labelHardwareConfChamberName;

    }
}