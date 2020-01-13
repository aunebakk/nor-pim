namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultStatisticsSearch;
        
        private DefaultStatisticsDurian durianDefaultStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultStatisticsSearch = new System.Windows.Forms.Button();
            this.durianDefaultStatistics = new DefaultStatisticsDurian();
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
            // buttonDefaultStatisticsSearch
            // 
            this.buttonDefaultStatisticsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultStatisticsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultStatisticsSearch.Name = "buttonDefaultStatisticsSearch";
            this.buttonDefaultStatisticsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultStatisticsSearch.TabIndex = 2;
            this.buttonDefaultStatisticsSearch.Text = "&Search";
            this.buttonDefaultStatisticsSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultStatisticsSearch.Click += new System.EventHandler(this.buttonDefaultStatisticsSearch_Click);
            // 
            // durianDefaultStatistics
            // 
            this.durianDefaultStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultStatistics.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultStatistics.Name = "durianDefaultStatistics";
            this.durianDefaultStatistics.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultStatistics.TabIndex = 1;
            // 
            // InitDefaultStatisticsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultStatisticsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultStatistics);
            this.Name = "DefaultStatisticsSearch";
            this.Text = "Default Statistics";
            this.ResumeLayout(false);

        }
    }
}
