namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultTestOverviewSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultTestOverviewSearch;
        
        private DefaultTestOverviewDurian durianDefaultTestOverview;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultTestOverviewSearch = new System.Windows.Forms.Button();
            this.durianDefaultTestOverview = new DefaultTestOverviewDurian();
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
            // buttonDefaultTestOverviewSearch
            // 
            this.buttonDefaultTestOverviewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultTestOverviewSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultTestOverviewSearch.Name = "buttonDefaultTestOverviewSearch";
            this.buttonDefaultTestOverviewSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultTestOverviewSearch.TabIndex = 2;
            this.buttonDefaultTestOverviewSearch.Text = "&Search";
            this.buttonDefaultTestOverviewSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultTestOverviewSearch.Click += new System.EventHandler(this.buttonDefaultTestOverviewSearch_Click);
            // 
            // durianDefaultTestOverview
            // 
            this.durianDefaultTestOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultTestOverview.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultTestOverview.Name = "durianDefaultTestOverview";
            this.durianDefaultTestOverview.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultTestOverview.TabIndex = 1;
            // 
            // InitDefaultTestOverviewSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultTestOverviewSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultTestOverview);
            this.Name = "DefaultTestOverviewSearch";
            this.Text = "Default Test Overview";
            this.ResumeLayout(false);

        }
    }
}
