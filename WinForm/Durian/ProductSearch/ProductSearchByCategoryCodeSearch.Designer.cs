namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryCodeSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByCategoryCodeSearch;
        
        private ProductSearchByCategoryCodeDurian durianProductSearchByCategoryCode;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategoryCodeSearch = new System.Windows.Forms.Button();
            this.durianProductSearchByCategoryCode = new ProductSearchByCategoryCodeDurian();
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
            // buttonProductSearchByCategoryCodeSearch
            // 
            this.buttonProductSearchByCategoryCodeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategoryCodeSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategoryCodeSearch.Name = "buttonProductSearchByCategoryCodeSearch";
            this.buttonProductSearchByCategoryCodeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategoryCodeSearch.TabIndex = 2;
            this.buttonProductSearchByCategoryCodeSearch.Text = "&Search";
            this.buttonProductSearchByCategoryCodeSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategoryCodeSearch.Click += new System.EventHandler(this.buttonProductSearchByCategoryCodeSearch_Click);
            // 
            // durianProductSearchByCategoryCode
            // 
            this.durianProductSearchByCategoryCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategoryCode.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategoryCode.Name = "durianProductSearchByCategoryCode";
            this.durianProductSearchByCategoryCode.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategoryCode.TabIndex = 1;
            // 
            // InitProductSearchByCategoryCodeSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategoryCodeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategoryCode);
            this.Name = "ProductSearchByCategoryCodeSearch";
            this.Text = "Product Search By Category Code";
            this.ResumeLayout(false);

        }
    }
}
