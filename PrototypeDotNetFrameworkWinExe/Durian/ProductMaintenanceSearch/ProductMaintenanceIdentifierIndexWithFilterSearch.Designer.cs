namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIdentifierIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductMaintenanceIdentifierIndexWithFilterSearch;
        
        private ProductMaintenanceIdentifierIndexWithFilterDurian durianProductMaintenanceIdentifierIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceIdentifierIndexWithFilter = new ProductMaintenanceIdentifierIndexWithFilterDurian();
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
            // buttonProductMaintenanceIdentifierIndexWithFilterSearch
            // 
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Name = "buttonProductMaintenanceIdentifierIndexWithFilterSearch";
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.TabIndex = 2;
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Text = "&Search";
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceIdentifierIndexWithFilterSearch.Click += new System.EventHandler(this.buttonProductMaintenanceIdentifierIndexWithFilterSearch_Click);
            // 
            // durianProductMaintenanceIdentifierIndexWithFilter
            // 
            this.durianProductMaintenanceIdentifierIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceIdentifierIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceIdentifierIndexWithFilter.Name = "durianProductMaintenanceIdentifierIndexWithFilter";
            this.durianProductMaintenanceIdentifierIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceIdentifierIndexWithFilter.TabIndex = 1;
            // 
            // InitProductMaintenanceIdentifierIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceIdentifierIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceIdentifierIndexWithFilter);
            this.Name = "ProductMaintenanceIdentifierIndexWithFilterSearch";
            this.Text = "Product Maintenance Identifier Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
