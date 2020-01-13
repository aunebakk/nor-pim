namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultResourceStatisticsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultResourceStatisticsSearch;
        
        private DefaultResourceStatisticsDurian durianDefaultResourceStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultResourceStatisticsSearch = new System.Windows.Forms.Button();
            this.durianDefaultResourceStatistics = new DefaultResourceStatisticsDurian();
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
            // buttonDefaultResourceStatisticsSearch
            // 
            this.buttonDefaultResourceStatisticsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultResourceStatisticsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultResourceStatisticsSearch.Name = "buttonDefaultResourceStatisticsSearch";
            this.buttonDefaultResourceStatisticsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultResourceStatisticsSearch.TabIndex = 2;
            this.buttonDefaultResourceStatisticsSearch.Text = "&Search";
            this.buttonDefaultResourceStatisticsSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultResourceStatisticsSearch.Click += new System.EventHandler(this.buttonDefaultResourceStatisticsSearch_Click);
            // 
            // durianDefaultResourceStatistics
            // 
            this.durianDefaultResourceStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultResourceStatistics.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultResourceStatistics.Name = "durianDefaultResourceStatistics";
            this.durianDefaultResourceStatistics.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultResourceStatistics.TabIndex = 1;
            // 
            // InitDefaultResourceStatisticsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultResourceStatisticsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultResourceStatistics);
            this.Name = "DefaultResourceStatisticsSearch";
            this.Text = "Default Resource Statistics";
            this.ResumeLayout(false);

        }
    }
}
