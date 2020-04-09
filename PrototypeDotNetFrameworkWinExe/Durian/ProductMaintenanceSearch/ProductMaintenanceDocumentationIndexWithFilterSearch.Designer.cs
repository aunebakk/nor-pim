namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceDocumentationIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductMaintenanceDocumentationIndexWithFilterSearch;
        
        private ProductMaintenanceDocumentationIndexWithFilterDurian durianProductMaintenanceDocumentationIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceDocumentationIndexWithFilter = new ProductMaintenanceDocumentationIndexWithFilterDurian();
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
            // buttonProductMaintenanceDocumentationIndexWithFilterSearch
            // 
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Name = "buttonProductMaintenanceDocumentationIndexWithFilterSearch";
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.TabIndex = 2;
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Text = "&Search";
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceDocumentationIndexWithFilterSearch.Click += new System.EventHandler(this.buttonProductMaintenanceDocumentationIndexWithFilterSearch_Click);
            // 
            // durianProductMaintenanceDocumentationIndexWithFilter
            // 
            this.durianProductMaintenanceDocumentationIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceDocumentationIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceDocumentationIndexWithFilter.Name = "durianProductMaintenanceDocumentationIndexWithFilter";
            this.durianProductMaintenanceDocumentationIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceDocumentationIndexWithFilter.TabIndex = 1;
            // 
            // InitProductMaintenanceDocumentationIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceDocumentationIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceDocumentationIndexWithFilter);
            this.Name = "ProductMaintenanceDocumentationIndexWithFilterSearch";
            this.Text = "Product Maintenance Documentation Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
