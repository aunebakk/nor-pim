namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType4Search {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByCategoryType4Search;
        
        private ProductSearchByCategoryType4Durian durianProductSearchByCategoryType4;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategoryType4Search = new System.Windows.Forms.Button();
            this.durianProductSearchByCategoryType4 = new ProductSearchByCategoryType4Durian();
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
            // buttonProductSearchByCategoryType4Search
            // 
            this.buttonProductSearchByCategoryType4Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategoryType4Search.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategoryType4Search.Name = "buttonProductSearchByCategoryType4Search";
            this.buttonProductSearchByCategoryType4Search.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategoryType4Search.TabIndex = 2;
            this.buttonProductSearchByCategoryType4Search.Text = "&Search";
            this.buttonProductSearchByCategoryType4Search.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategoryType4Search.Click += new System.EventHandler(this.buttonProductSearchByCategoryType4Search_Click);
            // 
            // durianProductSearchByCategoryType4
            // 
            this.durianProductSearchByCategoryType4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategoryType4.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategoryType4.Name = "durianProductSearchByCategoryType4";
            this.durianProductSearchByCategoryType4.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategoryType4.TabIndex = 1;
            // 
            // InitProductSearchByCategoryType4Search
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategoryType4Search);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategoryType4);
            this.Name = "ProductSearchByCategoryType4Search";
            this.Text = "Product Search By Category Type4";
            this.ResumeLayout(false);

        }
    }
}
