namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductReferenceAttributeSearchWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductReferenceAttributeSearchWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductReferenceAttributeSearchWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductReferenceAttributeSearchWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductReferenceAttributeSearchWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductReferenceAttributeSearchWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductReferenceAttributeSearchWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductReferenceAttributeSearchWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Name = "dataGridViewProductReferenceAttributeSearchWithFilter";
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductReferenceAttributeSearchWithFilter.Click += new System.EventHandler(this.dataGridViewProductReferenceAttributeSearchWithFilter_Click);
            this.dataGridViewProductReferenceAttributeSearchWithFilter.TabIndex = 1;
            // 
            // ProductReferenceAttributeSearchWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductReferenceAttributeSearchWithFilter);
            this.Name = "ProductReferenceAttributeSearchWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductReferenceAttributeSearchWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
