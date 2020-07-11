namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityRecentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserActivityRecentSearch;
        
        private DefaultUserActivityRecentDurian durianDefaultUserActivityRecent;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserActivityRecentSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserActivityRecent = new DefaultUserActivityRecentDurian();
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
            // buttonDefaultUserActivityRecentSearch
            // 
            this.buttonDefaultUserActivityRecentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserActivityRecentSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserActivityRecentSearch.Name = "buttonDefaultUserActivityRecentSearch";
            this.buttonDefaultUserActivityRecentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserActivityRecentSearch.TabIndex = 2;
            this.buttonDefaultUserActivityRecentSearch.Text = "&Search";
            this.buttonDefaultUserActivityRecentSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserActivityRecentSearch.Click += new System.EventHandler(this.buttonDefaultUserActivityRecentSearch_Click);
            // 
            // durianDefaultUserActivityRecent
            // 
            this.durianDefaultUserActivityRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserActivityRecent.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserActivityRecent.Name = "durianDefaultUserActivityRecent";
            this.durianDefaultUserActivityRecent.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserActivityRecent.TabIndex = 1;
            // 
            // InitDefaultUserActivityRecentSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserActivityRecentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserActivityRecent);
            this.Name = "DefaultUserActivityRecentSearch";
            this.Text = "Default User Activity Recent";
            this.ResumeLayout(false);

        }
    }
}
