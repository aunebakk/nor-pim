namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductReferenceAttributeUnitSearchWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductReferenceAttributeUnitSearchWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductReferenceAttributeUnitSearchWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductReferenceAttributeUnitSearchWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Name = "dataGridViewProductReferenceAttributeUnitSearchWithFilter";
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.Click += new System.EventHandler(this.dataGridViewProductReferenceAttributeUnitSearchWithFilter_Click);
            this.dataGridViewProductReferenceAttributeUnitSearchWithFilter.TabIndex = 1;
            // 
            // ProductReferenceAttributeUnitSearchWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductReferenceAttributeUnitSearchWithFilter);
            this.Name = "ProductReferenceAttributeUnitSearchWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductReferenceAttributeUnitSearchWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
