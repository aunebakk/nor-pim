namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceInfoIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductMaintenanceInfoIndexWithFilterSearch;
        
        private ProductMaintenanceInfoIndexWithFilterDurian durianProductMaintenanceInfoIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceInfoIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceInfoIndexWithFilter = new ProductMaintenanceInfoIndexWithFilterDurian();
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
            // buttonProductMaintenanceInfoIndexWithFilterSearch
            // 
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Name = "buttonProductMaintenanceInfoIndexWithFilterSearch";
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.TabIndex = 2;
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Text = "&Search";
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceInfoIndexWithFilterSearch.Click += new System.EventHandler(this.buttonProductMaintenanceInfoIndexWithFilterSearch_Click);
            // 
            // durianProductMaintenanceInfoIndexWithFilter
            // 
            this.durianProductMaintenanceInfoIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceInfoIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceInfoIndexWithFilter.Name = "durianProductMaintenanceInfoIndexWithFilter";
            this.durianProductMaintenanceInfoIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceInfoIndexWithFilter.TabIndex = 1;
            // 
            // InitProductMaintenanceInfoIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceInfoIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceInfoIndexWithFilter);
            this.Name = "ProductMaintenanceInfoIndexWithFilterSearch";
            this.Text = "Product Maintenance Info Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
