namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByCategorySearch;
        
        private ProductSearchByCategoryDurian durianProductSearchByCategory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategorySearch = new System.Windows.Forms.Button();
            this.durianProductSearchByCategory = new ProductSearchByCategoryDurian();
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
            // buttonProductSearchByCategorySearch
            // 
            this.buttonProductSearchByCategorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategorySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategorySearch.Name = "buttonProductSearchByCategorySearch";
            this.buttonProductSearchByCategorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategorySearch.TabIndex = 2;
            this.buttonProductSearchByCategorySearch.Text = "&Search";
            this.buttonProductSearchByCategorySearch.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategorySearch.Click += new System.EventHandler(this.buttonProductSearchByCategorySearch_Click);
            // 
            // durianProductSearchByCategory
            // 
            this.durianProductSearchByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategory.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategory.Name = "durianProductSearchByCategory";
            this.durianProductSearchByCategory.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategory.TabIndex = 1;
            // 
            // InitProductSearchByCategorySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategory);
            this.Name = "ProductSearchByCategorySearch";
            this.Text = "Product Search By Category";
            this.ResumeLayout(false);

        }
    }
}
