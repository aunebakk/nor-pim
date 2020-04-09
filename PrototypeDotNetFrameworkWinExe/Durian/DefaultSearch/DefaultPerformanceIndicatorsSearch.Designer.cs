namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceIndicatorsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultPerformanceIndicatorsSearch;
        
        private DefaultPerformanceIndicatorsDurian durianDefaultPerformanceIndicators;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultPerformanceIndicatorsSearch = new System.Windows.Forms.Button();
            this.durianDefaultPerformanceIndicators = new DefaultPerformanceIndicatorsDurian();
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
            // buttonDefaultPerformanceIndicatorsSearch
            // 
            this.buttonDefaultPerformanceIndicatorsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultPerformanceIndicatorsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultPerformanceIndicatorsSearch.Name = "buttonDefaultPerformanceIndicatorsSearch";
            this.buttonDefaultPerformanceIndicatorsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultPerformanceIndicatorsSearch.TabIndex = 2;
            this.buttonDefaultPerformanceIndicatorsSearch.Text = "&Search";
            this.buttonDefaultPerformanceIndicatorsSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultPerformanceIndicatorsSearch.Click += new System.EventHandler(this.buttonDefaultPerformanceIndicatorsSearch_Click);
            // 
            // durianDefaultPerformanceIndicators
            // 
            this.durianDefaultPerformanceIndicators.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultPerformanceIndicators.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultPerformanceIndicators.Name = "durianDefaultPerformanceIndicators";
            this.durianDefaultPerformanceIndicators.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultPerformanceIndicators.TabIndex = 1;
            // 
            // InitDefaultPerformanceIndicatorsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultPerformanceIndicatorsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultPerformanceIndicators);
            this.Name = "DefaultPerformanceIndicatorsSearch";
            this.Text = "Default Performance Indicators";
            this.ResumeLayout(false);

        }
    }
}
