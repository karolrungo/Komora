namespace Komora.Controls
{
    partial class SegmentInterfaceControl
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
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnEditSegment = new System.Windows.Forms.Button();
            this.btnDeleteSegment = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSegmentList = new System.Windows.Forms.DataGridView();
            this.segmentTypeControl1 = new Komora.Controls.SegmentTypeControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(451, 300);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(93, 30);
            this.btnClearList.TabIndex = 10;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnEditSegment
            // 
            this.btnEditSegment.Location = new System.Drawing.Point(451, 236);
            this.btnEditSegment.Name = "btnEditSegment";
            this.btnEditSegment.Size = new System.Drawing.Size(93, 30);
            this.btnEditSegment.TabIndex = 9;
            this.btnEditSegment.Text = "Edit Segment";
            this.btnEditSegment.UseVisualStyleBackColor = true;
            this.btnEditSegment.Click += new System.EventHandler(this.btnEditSegment_Click);
            // 
            // btnDeleteSegment
            // 
            this.btnDeleteSegment.Location = new System.Drawing.Point(451, 198);
            this.btnDeleteSegment.Name = "btnDeleteSegment";
            this.btnDeleteSegment.Size = new System.Drawing.Size(93, 30);
            this.btnDeleteSegment.TabIndex = 8;
            this.btnDeleteSegment.Text = "Delete Segment";
            this.btnDeleteSegment.UseVisualStyleBackColor = true;
            this.btnDeleteSegment.Click += new System.EventHandler(this.btnDeleteSegment_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Segment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvSegmentList
            // 
            this.dgvSegmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegmentList.Location = new System.Drawing.Point(3, 3);
            this.dgvSegmentList.Name = "dgvSegmentList";
            this.dgvSegmentList.Size = new System.Drawing.Size(541, 150);
            this.dgvSegmentList.TabIndex = 6;
            // 
            // segmentTypeControl1
            // 
            this.segmentTypeControl1.Location = new System.Drawing.Point(15, 162);
            this.segmentTypeControl1.Name = "segmentTypeControl1";
            this.segmentTypeControl1.Size = new System.Drawing.Size(430, 146);
            this.segmentTypeControl1.TabIndex = 11;
            // 
            // SegmentInterfaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.segmentTypeControl1);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnEditSegment);
            this.Controls.Add(this.btnDeleteSegment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSegmentList);
            this.Name = "SegmentInterfaceControl";
            this.Size = new System.Drawing.Size(559, 349);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnEditSegment;
        private System.Windows.Forms.Button btnDeleteSegment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSegmentList;
        private SegmentTypeControl segmentTypeControl1;
    }
}
