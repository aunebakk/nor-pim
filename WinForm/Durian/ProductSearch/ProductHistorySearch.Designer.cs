namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductHistorySearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductHistorySearch;

        private ProductHistoryDurian durianProductHistory;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductHistorySearch = new System.Windows.Forms.Button();
            this.durianProductHistory = new ProductHistoryDurian();
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
            // buttonProductHistorySearch
            // 
            this.buttonProductHistorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductHistorySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductHistorySearch.Name = "buttonProductHistorySearch";
            this.buttonProductHistorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductHistorySearch.TabIndex = 2;
            this.buttonProductHistorySearch.Text = "&Search";
            this.buttonProductHistorySearch.UseVisualStyleBackColor = true;
            this.buttonProductHistorySearch.Click += new System.EventHandler(this.buttonProductHistorySearch_Click);
            // 
            // durianProductHistory
            // 
            this.durianProductHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductHistory.Location = new System.Drawing.Point(12, 12);
            this.durianProductHistory.Name = "durianProductHistory";
            this.durianProductHistory.Size = new System.Drawing.Size(502, 259);
            this.durianProductHistory.TabIndex = 1;
            // 
            // InitProductHistorySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductHistorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductHistory);
            this.Name = "ProductHistorySearch";
            this.Text = "Product History";
            this.ResumeLayout(false);

        }
    }
}
