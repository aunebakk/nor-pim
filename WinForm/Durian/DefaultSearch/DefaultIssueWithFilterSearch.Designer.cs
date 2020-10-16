namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultIssueWithFilterSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonDefaultIssueWithFilterSearch;

        private DefaultIssueWithFilterDurian durianDefaultIssueWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultIssueWithFilterSearch = new System.Windows.Forms.Button();
            this.durianDefaultIssueWithFilter = new DefaultIssueWithFilterDurian();
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
            // buttonDefaultIssueWithFilterSearch
            // 
            this.buttonDefaultIssueWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultIssueWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultIssueWithFilterSearch.Name = "buttonDefaultIssueWithFilterSearch";
            this.buttonDefaultIssueWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultIssueWithFilterSearch.TabIndex = 2;
            this.buttonDefaultIssueWithFilterSearch.Text = "&Search";
            this.buttonDefaultIssueWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultIssueWithFilterSearch.Click += new System.EventHandler(this.buttonDefaultIssueWithFilterSearch_Click);
            // 
            // durianDefaultIssueWithFilter
            // 
            this.durianDefaultIssueWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultIssueWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultIssueWithFilter.Name = "durianDefaultIssueWithFilter";
            this.durianDefaultIssueWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultIssueWithFilter.TabIndex = 1;
            // 
            // InitDefaultIssueWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultIssueWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultIssueWithFilter);
            this.Name = "DefaultIssueWithFilterSearch";
            this.Text = "Default Issue With Filter";
            this.ResumeLayout(false);

        }
    }
}
