namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType2Search {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByCategoryType2Search;
        
        private ProductSearchByCategoryType2Durian durianProductSearchByCategoryType2;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategoryType2Search = new System.Windows.Forms.Button();
            this.durianProductSearchByCategoryType2 = new ProductSearchByCategoryType2Durian();
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
            // buttonProductSearchByCategoryType2Search
            // 
            this.buttonProductSearchByCategoryType2Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategoryType2Search.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategoryType2Search.Name = "buttonProductSearchByCategoryType2Search";
            this.buttonProductSearchByCategoryType2Search.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategoryType2Search.TabIndex = 2;
            this.buttonProductSearchByCategoryType2Search.Text = "&Search";
            this.buttonProductSearchByCategoryType2Search.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategoryType2Search.Click += new System.EventHandler(this.buttonProductSearchByCategoryType2Search_Click);
            // 
            // durianProductSearchByCategoryType2
            // 
            this.durianProductSearchByCategoryType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategoryType2.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategoryType2.Name = "durianProductSearchByCategoryType2";
            this.durianProductSearchByCategoryType2.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategoryType2.TabIndex = 1;
            // 
            // InitProductSearchByCategoryType2Search
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategoryType2Search);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategoryType2);
            this.Name = "ProductSearchByCategoryType2Search";
            this.Text = "Product Search By Category Type2";
            this.ResumeLayout(false);

        }
    }
}
