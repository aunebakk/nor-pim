namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType3Search {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByCategoryType3Search;
        
        private ProductSearchByCategoryType3Durian durianProductSearchByCategoryType3;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategoryType3Search = new System.Windows.Forms.Button();
            this.durianProductSearchByCategoryType3 = new ProductSearchByCategoryType3Durian();
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
            // buttonProductSearchByCategoryType3Search
            // 
            this.buttonProductSearchByCategoryType3Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategoryType3Search.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategoryType3Search.Name = "buttonProductSearchByCategoryType3Search";
            this.buttonProductSearchByCategoryType3Search.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategoryType3Search.TabIndex = 2;
            this.buttonProductSearchByCategoryType3Search.Text = "&Search";
            this.buttonProductSearchByCategoryType3Search.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategoryType3Search.Click += new System.EventHandler(this.buttonProductSearchByCategoryType3Search_Click);
            // 
            // durianProductSearchByCategoryType3
            // 
            this.durianProductSearchByCategoryType3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategoryType3.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategoryType3.Name = "durianProductSearchByCategoryType3";
            this.durianProductSearchByCategoryType3.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategoryType3.TabIndex = 1;
            // 
            // InitProductSearchByCategoryType3Search
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategoryType3Search);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategoryType3);
            this.Name = "ProductSearchByCategoryType3Search";
            this.Text = "Product Search By Category Type3";
            this.ResumeLayout(false);

        }
    }
}
