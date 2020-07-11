namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceDocumentationIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceDocumentationIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceDocumentationIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceDocumentationIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Name = "dataGridViewProductMaintenanceDocumentationIndexWithFilter";
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.Click += new System.EventHandler(this.dataGridViewProductMaintenanceDocumentationIndexWithFilter_Click);
            this.dataGridViewProductMaintenanceDocumentationIndexWithFilter.TabIndex = 1;
            // 
            // ProductMaintenanceDocumentationIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceDocumentationIndexWithFilter);
            this.Name = "ProductMaintenanceDocumentationIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceDocumentationIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
