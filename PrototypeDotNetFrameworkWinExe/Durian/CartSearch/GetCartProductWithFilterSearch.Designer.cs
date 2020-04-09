namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetCartProductWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetCartProductWithFilterSearch;
        
        private GetCartProductWithFilterDurian durianGetCartProductWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetCartProductWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetCartProductWithFilter = new GetCartProductWithFilterDurian();
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
            // buttonGetCartProductWithFilterSearch
            // 
            this.buttonGetCartProductWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetCartProductWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetCartProductWithFilterSearch.Name = "buttonGetCartProductWithFilterSearch";
            this.buttonGetCartProductWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetCartProductWithFilterSearch.TabIndex = 2;
            this.buttonGetCartProductWithFilterSearch.Text = "&Search";
            this.buttonGetCartProductWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetCartProductWithFilterSearch.Click += new System.EventHandler(this.buttonGetCartProductWithFilterSearch_Click);
            // 
            // durianGetCartProductWithFilter
            // 
            this.durianGetCartProductWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetCartProductWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetCartProductWithFilter.Name = "durianGetCartProductWithFilter";
            this.durianGetCartProductWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetCartProductWithFilter.TabIndex = 1;
            // 
            // InitGetCartProductWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetCartProductWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetCartProductWithFilter);
            this.Name = "GetCartProductWithFilterSearch";
            this.Text = "Get Cart Product With Filter";
            this.ResumeLayout(false);

        }
    }
}
