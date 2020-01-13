namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceAttributeIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceAttributeIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceAttributeIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceAttributeIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Name = "dataGridViewProductMaintenanceAttributeIndexWithFilter";
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.Click += new System.EventHandler(this.dataGridViewProductMaintenanceAttributeIndexWithFilter_Click);
            this.dataGridViewProductMaintenanceAttributeIndexWithFilter.TabIndex = 1;
            // 
            // ProductMaintenanceAttributeIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceAttributeIndexWithFilter);
            this.Name = "ProductMaintenanceAttributeIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceAttributeIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
