namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetClientWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetClientWithFilterSearch;
        
        private GetClientWithFilterDurian durianGetClientWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetClientWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetClientWithFilter = new GetClientWithFilterDurian();
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
            // buttonGetClientWithFilterSearch
            // 
            this.buttonGetClientWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetClientWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetClientWithFilterSearch.Name = "buttonGetClientWithFilterSearch";
            this.buttonGetClientWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetClientWithFilterSearch.TabIndex = 2;
            this.buttonGetClientWithFilterSearch.Text = "&Search";
            this.buttonGetClientWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetClientWithFilterSearch.Click += new System.EventHandler(this.buttonGetClientWithFilterSearch_Click);
            // 
            // durianGetClientWithFilter
            // 
            this.durianGetClientWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetClientWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetClientWithFilter.Name = "durianGetClientWithFilter";
            this.durianGetClientWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetClientWithFilter.TabIndex = 1;
            // 
            // InitGetClientWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetClientWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetClientWithFilter);
            this.Name = "GetClientWithFilterSearch";
            this.Text = "Get Client With Filter";
            this.ResumeLayout(false);

        }
    }
}
