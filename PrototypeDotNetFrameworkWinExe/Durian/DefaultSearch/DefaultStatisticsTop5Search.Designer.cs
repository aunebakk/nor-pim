namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsTop5Search {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultStatisticsTop5Search;
        
        private DefaultStatisticsTop5Durian durianDefaultStatisticsTop5;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultStatisticsTop5Search = new System.Windows.Forms.Button();
            this.durianDefaultStatisticsTop5 = new DefaultStatisticsTop5Durian();
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
            // buttonDefaultStatisticsTop5Search
            // 
            this.buttonDefaultStatisticsTop5Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultStatisticsTop5Search.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultStatisticsTop5Search.Name = "buttonDefaultStatisticsTop5Search";
            this.buttonDefaultStatisticsTop5Search.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultStatisticsTop5Search.TabIndex = 2;
            this.buttonDefaultStatisticsTop5Search.Text = "&Search";
            this.buttonDefaultStatisticsTop5Search.UseVisualStyleBackColor = true;
            this.buttonDefaultStatisticsTop5Search.Click += new System.EventHandler(this.buttonDefaultStatisticsTop5Search_Click);
            // 
            // durianDefaultStatisticsTop5
            // 
            this.durianDefaultStatisticsTop5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultStatisticsTop5.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultStatisticsTop5.Name = "durianDefaultStatisticsTop5";
            this.durianDefaultStatisticsTop5.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultStatisticsTop5.TabIndex = 1;
            // 
            // InitDefaultStatisticsTop5Search
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultStatisticsTop5Search);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultStatisticsTop5);
            this.Name = "DefaultStatisticsTop5Search";
            this.Text = "Default Statistics Top5";
            this.ResumeLayout(false);

        }
    }
}
