namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryTreeSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCategoryTreeSearch;
        
        private CategoryTreeDurian durianCategoryTree;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCategoryTreeSearch = new System.Windows.Forms.Button();
            this.durianCategoryTree = new CategoryTreeDurian();
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
            // buttonCategoryTreeSearch
            // 
            this.buttonCategoryTreeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategoryTreeSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonCategoryTreeSearch.Name = "buttonCategoryTreeSearch";
            this.buttonCategoryTreeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCategoryTreeSearch.TabIndex = 2;
            this.buttonCategoryTreeSearch.Text = "&Search";
            this.buttonCategoryTreeSearch.UseVisualStyleBackColor = true;
            this.buttonCategoryTreeSearch.Click += new System.EventHandler(this.buttonCategoryTreeSearch_Click);
            // 
            // durianCategoryTree
            // 
            this.durianCategoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianCategoryTree.Location = new System.Drawing.Point(12, 12);
            this.durianCategoryTree.Name = "durianCategoryTree";
            this.durianCategoryTree.Size = new System.Drawing.Size(502, 259);
            this.durianCategoryTree.TabIndex = 1;
            // 
            // InitCategoryTreeSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonCategoryTreeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianCategoryTree);
            this.Name = "CategoryTreeSearch";
            this.Text = "Category Tree";
            this.ResumeLayout(false);

        }
    }
}
