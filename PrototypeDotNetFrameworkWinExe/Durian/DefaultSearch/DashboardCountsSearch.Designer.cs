namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DashboardCountsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDashboardCountsSearch;
        
        private DashboardCountsDurian durianDashboardCounts;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDashboardCountsSearch = new System.Windows.Forms.Button();
            this.durianDashboardCounts = new DashboardCountsDurian();
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
            // buttonDashboardCountsSearch
            // 
            this.buttonDashboardCountsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDashboardCountsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDashboardCountsSearch.Name = "buttonDashboardCountsSearch";
            this.buttonDashboardCountsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDashboardCountsSearch.TabIndex = 2;
            this.buttonDashboardCountsSearch.Text = "&Search";
            this.buttonDashboardCountsSearch.UseVisualStyleBackColor = true;
            this.buttonDashboardCountsSearch.Click += new System.EventHandler(this.buttonDashboardCountsSearch_Click);
            // 
            // durianDashboardCounts
            // 
            this.durianDashboardCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDashboardCounts.Location = new System.Drawing.Point(12, 12);
            this.durianDashboardCounts.Name = "durianDashboardCounts";
            this.durianDashboardCounts.Size = new System.Drawing.Size(502, 259);
            this.durianDashboardCounts.TabIndex = 1;
            // 
            // InitDashboardCountsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDashboardCountsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDashboardCounts);
            this.Name = "DashboardCountsSearch";
            this.Text = "Dashboard Counts";
            this.ResumeLayout(false);

        }
    }
}
