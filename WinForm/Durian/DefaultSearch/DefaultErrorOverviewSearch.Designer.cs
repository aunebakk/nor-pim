namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultErrorOverviewSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonDefaultErrorOverviewSearch;

        private DefaultErrorOverviewDurian durianDefaultErrorOverview;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultErrorOverviewSearch = new System.Windows.Forms.Button();
            this.durianDefaultErrorOverview = new DefaultErrorOverviewDurian();
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
            // buttonDefaultErrorOverviewSearch
            // 
            this.buttonDefaultErrorOverviewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultErrorOverviewSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultErrorOverviewSearch.Name = "buttonDefaultErrorOverviewSearch";
            this.buttonDefaultErrorOverviewSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultErrorOverviewSearch.TabIndex = 2;
            this.buttonDefaultErrorOverviewSearch.Text = "&Search";
            this.buttonDefaultErrorOverviewSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultErrorOverviewSearch.Click += new System.EventHandler(this.buttonDefaultErrorOverviewSearch_Click);
            // 
            // durianDefaultErrorOverview
            // 
            this.durianDefaultErrorOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultErrorOverview.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultErrorOverview.Name = "durianDefaultErrorOverview";
            this.durianDefaultErrorOverview.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultErrorOverview.TabIndex = 1;
            // 
            // InitDefaultErrorOverviewSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultErrorOverviewSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultErrorOverview);
            this.Name = "DefaultErrorOverviewSearch";
            this.Text = "Default Error Overview";
            this.ResumeLayout(false);

        }
    }
}
