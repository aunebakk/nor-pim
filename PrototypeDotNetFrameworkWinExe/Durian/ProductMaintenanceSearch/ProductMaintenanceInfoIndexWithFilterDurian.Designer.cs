namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceInfoIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceInfoIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceInfoIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceInfoIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceInfoIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Name = "dataGridViewProductMaintenanceInfoIndexWithFilter";
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.Click += new System.EventHandler(this.dataGridViewProductMaintenanceInfoIndexWithFilter_Click);
            this.dataGridViewProductMaintenanceInfoIndexWithFilter.TabIndex = 1;
            // 
            // ProductMaintenanceInfoIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceInfoIndexWithFilter);
            this.Name = "ProductMaintenanceInfoIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceInfoIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
