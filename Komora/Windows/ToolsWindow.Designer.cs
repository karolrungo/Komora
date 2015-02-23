namespace Komora.Windows
{
    partial class ToolsWindow
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
            this.tabControlTools = new System.Windows.Forms.TabControl();
            this.tabPageDateCalculator = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateAndTimeDifferenceCalculator1 = new Komora.Controls.DateAndTimeDifferenceCalculator();
            this.tabControlTools.SuspendLayout();
            this.tabPageDateCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTools
            // 
            this.tabControlTools.Controls.Add(this.tabPageDateCalculator);
            this.tabControlTools.Controls.Add(this.tabPage2);
            this.tabControlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTools.Location = new System.Drawing.Point(0, 0);
            this.tabControlTools.Name = "tabControlTools";
            this.tabControlTools.SelectedIndex = 0;
            this.tabControlTools.Size = new System.Drawing.Size(284, 262);
            this.tabControlTools.TabIndex = 0;
            // 
            // tabPageDateCalculator
            // 
            this.tabPageDateCalculator.Controls.Add(this.dateAndTimeDifferenceCalculator1);
            this.tabPageDateCalculator.Location = new System.Drawing.Point(4, 22);
            this.tabPageDateCalculator.Name = "tabPageDateCalculator";
            this.tabPageDateCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDateCalculator.Size = new System.Drawing.Size(276, 236);
            this.tabPageDateCalculator.TabIndex = 0;
            this.tabPageDateCalculator.Text = "Date Calculator";
            this.tabPageDateCalculator.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateAndTimeDifferenceCalculator1
            // 
            this.dateAndTimeDifferenceCalculator1.Location = new System.Drawing.Point(9, 7);
            this.dateAndTimeDifferenceCalculator1.Name = "dateAndTimeDifferenceCalculator1";
            this.dateAndTimeDifferenceCalculator1.Size = new System.Drawing.Size(274, 171);
            this.dateAndTimeDifferenceCalculator1.TabIndex = 0;
            // 
            // ToolsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControlTools);
            this.Name = "ToolsWindow";
            this.Text = "Tools";
            this.tabControlTools.ResumeLayout(false);
            this.tabPageDateCalculator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTools;
        private System.Windows.Forms.TabPage tabPageDateCalculator;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.DateAndTimeDifferenceCalculator dateAndTimeDifferenceCalculator1;

    }
}