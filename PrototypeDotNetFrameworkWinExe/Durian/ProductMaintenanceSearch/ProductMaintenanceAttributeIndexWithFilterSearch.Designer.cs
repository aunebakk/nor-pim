namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceAttributeIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductMaintenanceAttributeIndexWithFilterSearch;
        
        private ProductMaintenanceAttributeIndexWithFilterDurian durianProductMaintenanceAttributeIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceAttributeIndexWithFilter = new ProductMaintenanceAttributeIndexWithFilterDurian();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonProductMaintenanceAttributeIndexWithFilterSearch
            // 
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Name = "buttonProductMaintenanceAttributeIndexWithFilterSearch";
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.TabIndex = 2;
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Text = "&Search";
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceAttributeIndexWithFilterSearch.Click += new System.EventHandler(this.buttonProductMaintenanceAttributeIndexWithFilterSearch_Click);
            // 
            // durianProductMaintenanceAttributeIndexWithFilter
            // 
            this.durianProductMaintenanceAttributeIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceAttributeIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceAttributeIndexWithFilter.Name = "durianProductMaintenanceAttributeIndexWithFilter";
            this.durianProductMaintenanceAttributeIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceAttributeIndexWithFilter.TabIndex = 1;
            // 
            // InitProductMaintenanceAttributeIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceAttributeIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceAttributeIndexWithFilter);
            this.Name = "ProductMaintenanceAttributeIndexWithFilterSearch";
            this.Text = "Product Maintenance Attribute Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
