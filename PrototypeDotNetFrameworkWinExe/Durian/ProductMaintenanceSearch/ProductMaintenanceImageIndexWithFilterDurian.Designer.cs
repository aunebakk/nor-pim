namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceImageIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceImageIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceImageIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceImageIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceImageIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceImageIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceImageIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceImageIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Name = "dataGridViewProductMaintenanceImageIndexWithFilter";
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceImageIndexWithFilter.Click += new System.EventHandler(this.dataGridViewProductMaintenanceImageIndexWithFilter_Click);
            this.dataGridViewProductMaintenanceImageIndexWithFilter.TabIndex = 1;
            // 
            // ProductMaintenanceImageIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceImageIndexWithFilter);
            this.Name = "ProductMaintenanceImageIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceImageIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
