namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultResourceDatabaseStatisticsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultResourceDatabaseStatisticsSearch;
        
        private DefaultResourceDatabaseStatisticsDurian durianDefaultResourceDatabaseStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultResourceDatabaseStatisticsSearch = new System.Windows.Forms.Button();
            this.durianDefaultResourceDatabaseStatistics = new DefaultResourceDatabaseStatisticsDurian();
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
            // buttonDefaultResourceDatabaseStatisticsSearch
            // 
            this.buttonDefaultResourceDatabaseStatisticsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultResourceDatabaseStatisticsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultResourceDatabaseStatisticsSearch.Name = "buttonDefaultResourceDatabaseStatisticsSearch";
            this.buttonDefaultResourceDatabaseStatisticsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultResourceDatabaseStatisticsSearch.TabIndex = 2;
            this.buttonDefaultResourceDatabaseStatisticsSearch.Text = "&Search";
            this.buttonDefaultResourceDatabaseStatisticsSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultResourceDatabaseStatisticsSearch.Click += new System.EventHandler(this.buttonDefaultResourceDatabaseStatisticsSearch_Click);
            // 
            // durianDefaultResourceDatabaseStatistics
            // 
            this.durianDefaultResourceDatabaseStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultResourceDatabaseStatistics.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultResourceDatabaseStatistics.Name = "durianDefaultResourceDatabaseStatistics";
            this.durianDefaultResourceDatabaseStatistics.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultResourceDatabaseStatistics.TabIndex = 1;
            // 
            // InitDefaultResourceDatabaseStatisticsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultResourceDatabaseStatisticsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultResourceDatabaseStatistics);
            this.Name = "DefaultResourceDatabaseStatisticsSearch";
            this.Text = "Default Resource Database Statistics";
            this.ResumeLayout(false);

        }
    }
}
