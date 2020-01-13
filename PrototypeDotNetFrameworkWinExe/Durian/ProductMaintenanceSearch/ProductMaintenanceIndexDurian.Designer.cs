namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIndexDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceIndex;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceIndex = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceIndex
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceIndex.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceIndex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceIndex.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceIndex.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceIndex.Name = "dataGridViewProductMaintenanceIndex";
            this.dataGridViewProductMaintenanceIndex.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceIndex.Click += new System.EventHandler(this.dataGridViewProductMaintenanceIndex_Click);
            this.dataGridViewProductMaintenanceIndex.TabIndex = 1;
            // 
            // ProductMaintenanceIndexDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceIndex);
            this.Name = "ProductMaintenanceIndexDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceIndex)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
