namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeSearchWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductReferenceAttributeSearchWithFilterSearch;
        
        private ProductReferenceAttributeSearchWithFilterDurian durianProductReferenceAttributeSearchWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductReferenceAttributeSearchWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductReferenceAttributeSearchWithFilter = new ProductReferenceAttributeSearchWithFilterDurian();
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
            // buttonProductReferenceAttributeSearchWithFilterSearch
            // 
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Name = "buttonProductReferenceAttributeSearchWithFilterSearch";
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductReferenceAttributeSearchWithFilterSearch.TabIndex = 2;
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Text = "&Search";
            this.buttonProductReferenceAttributeSearchWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductReferenceAttributeSearchWithFilterSearch.Click += new System.EventHandler(this.buttonProductReferenceAttributeSearchWithFilterSearch_Click);
            // 
            // durianProductReferenceAttributeSearchWithFilter
            // 
            this.durianProductReferenceAttributeSearchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductReferenceAttributeSearchWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductReferenceAttributeSearchWithFilter.Name = "durianProductReferenceAttributeSearchWithFilter";
            this.durianProductReferenceAttributeSearchWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductReferenceAttributeSearchWithFilter.TabIndex = 1;
            // 
            // InitProductReferenceAttributeSearchWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductReferenceAttributeSearchWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductReferenceAttributeSearchWithFilter);
            this.Name = "ProductReferenceAttributeSearchWithFilterSearch";
            this.Text = "Product Reference Attribute Search With Filter";
            this.ResumeLayout(false);

        }
    }
}
