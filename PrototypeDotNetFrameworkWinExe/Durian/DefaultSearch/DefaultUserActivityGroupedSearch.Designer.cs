namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityGroupedSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserActivityGroupedSearch;
        
        private DefaultUserActivityGroupedDurian durianDefaultUserActivityGrouped;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserActivityGroupedSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserActivityGrouped = new DefaultUserActivityGroupedDurian();
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
            // buttonDefaultUserActivityGroupedSearch
            // 
            this.buttonDefaultUserActivityGroupedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserActivityGroupedSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserActivityGroupedSearch.Name = "buttonDefaultUserActivityGroupedSearch";
            this.buttonDefaultUserActivityGroupedSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserActivityGroupedSearch.TabIndex = 2;
            this.buttonDefaultUserActivityGroupedSearch.Text = "&Search";
            this.buttonDefaultUserActivityGroupedSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserActivityGroupedSearch.Click += new System.EventHandler(this.buttonDefaultUserActivityGroupedSearch_Click);
            // 
            // durianDefaultUserActivityGrouped
            // 
            this.durianDefaultUserActivityGrouped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserActivityGrouped.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserActivityGrouped.Name = "durianDefaultUserActivityGrouped";
            this.durianDefaultUserActivityGrouped.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserActivityGrouped.TabIndex = 1;
            // 
            // InitDefaultUserActivityGroupedSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserActivityGroupedSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserActivityGrouped);
            this.Name = "DefaultUserActivityGroupedSearch";
            this.Text = "Default User Activity Grouped";
            this.ResumeLayout(false);

        }
    }
}
