namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceIssueFetchWithFilterSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonDefaultPerformanceIssueFetchWithFilterSearch;

        private DefaultPerformanceIssueFetchWithFilterDurian durianDefaultPerformanceIssueFetchWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch = new System.Windows.Forms.Button();
            this.durianDefaultPerformanceIssueFetchWithFilter = new DefaultPerformanceIssueFetchWithFilterDurian();
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
            // buttonDefaultPerformanceIssueFetchWithFilterSearch
            // 
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Name = "buttonDefaultPerformanceIssueFetchWithFilterSearch";
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.TabIndex = 2;
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Text = "&Search";
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultPerformanceIssueFetchWithFilterSearch.Click += new System.EventHandler(this.buttonDefaultPerformanceIssueFetchWithFilterSearch_Click);
            // 
            // durianDefaultPerformanceIssueFetchWithFilter
            // 
            this.durianDefaultPerformanceIssueFetchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultPerformanceIssueFetchWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultPerformanceIssueFetchWithFilter.Name = "durianDefaultPerformanceIssueFetchWithFilter";
            this.durianDefaultPerformanceIssueFetchWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultPerformanceIssueFetchWithFilter.TabIndex = 1;
            // 
            // InitDefaultPerformanceIssueFetchWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultPerformanceIssueFetchWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultPerformanceIssueFetchWithFilter);
            this.Name = "DefaultPerformanceIssueFetchWithFilterSearch";
            this.Text = "Default Performance Issue Fetch With Filter";
            this.ResumeLayout(false);

        }
    }
}
