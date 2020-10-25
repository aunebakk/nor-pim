namespace SolutionNorSolutionPim.UserInterface {

    public partial class CategoryFindSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCategoryFindSearch;
        
        private CategoryFindDurian durianCategoryFind;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCategoryFindSearch = new System.Windows.Forms.Button();
            this.durianCategoryFind = new CategoryFindDurian();
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
            // buttonCategoryFindSearch
            // 
            this.buttonCategoryFindSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategoryFindSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonCategoryFindSearch.Name = "buttonCategoryFindSearch";
            this.buttonCategoryFindSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCategoryFindSearch.TabIndex = 2;
            this.buttonCategoryFindSearch.Text = "&Search";
            this.buttonCategoryFindSearch.UseVisualStyleBackColor = true;
            this.buttonCategoryFindSearch.Click += new System.EventHandler(this.buttonCategoryFindSearch_Click);
            // 
            // durianCategoryFind
            // 
            this.durianCategoryFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianCategoryFind.Location = new System.Drawing.Point(12, 12);
            this.durianCategoryFind.Name = "durianCategoryFind";
            this.durianCategoryFind.Size = new System.Drawing.Size(502, 259);
            this.durianCategoryFind.TabIndex = 1;
            // 
            // InitCategoryFindSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonCategoryFindSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianCategoryFind);
            this.Name = "CategoryFindSearch";
            this.Text = "Category Find";
            this.ResumeLayout(false);

        }
    }
}
