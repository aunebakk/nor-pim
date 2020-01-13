namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByNameSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductSearchByNameSearch;
        
        private ProductSearchByNameDurian durianProductSearchByName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByNameSearch = new System.Windows.Forms.Button();
            this.durianProductSearchByName = new ProductSearchByNameDurian();
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
            // buttonProductSearchByNameSearch
            // 
            this.buttonProductSearchByNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByNameSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByNameSearch.Name = "buttonProductSearchByNameSearch";
            this.buttonProductSearchByNameSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByNameSearch.TabIndex = 2;
            this.buttonProductSearchByNameSearch.Text = "&Search";
            this.buttonProductSearchByNameSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearchByNameSearch.Click += new System.EventHandler(this.buttonProductSearchByNameSearch_Click);
            // 
            // durianProductSearchByName
            // 
            this.durianProductSearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByName.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByName.Name = "durianProductSearchByName";
            this.durianProductSearchByName.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByName.TabIndex = 1;
            // 
            // InitProductSearchByNameSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByNameSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByName);
            this.Name = "ProductSearchByNameSearch";
            this.Text = "Product Search By Name";
            this.ResumeLayout(false);

        }
    }
}
