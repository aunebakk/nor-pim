namespace norpim.UserInterface {
    
    
    public partial class GatherProductDetailsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button btnClose;
        
        private System.Windows.Forms.Button btnSearch;
        
        private System.Windows.Forms.DataGridView gridGatherProductDetails;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridGatherProductDetails = new System.Windows.Forms.DataGridView();
            this.buttonProductHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGatherProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(433, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(335, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridGatherProductDetails
            // 
            this.gridGatherProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGatherProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGatherProductDetails.Location = new System.Drawing.Point(2, 3);
            this.gridGatherProductDetails.Name = "gridGatherProductDetails";
            this.gridGatherProductDetails.Size = new System.Drawing.Size(523, 268);
            this.gridGatherProductDetails.TabIndex = 0;
            // 
            // buttonProductHistory
            // 
            this.buttonProductHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductHistory.Location = new System.Drawing.Point(207, 277);
            this.buttonProductHistory.Name = "buttonProductHistory";
            this.buttonProductHistory.Size = new System.Drawing.Size(92, 22);
            this.buttonProductHistory.TabIndex = 44;
            this.buttonProductHistory.Text = "&Product History";
            this.buttonProductHistory.UseVisualStyleBackColor = true;
            this.buttonProductHistory.Click += new System.EventHandler(this.buttonProductHistory_Click);
            // 
            // GatherProductDetailsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductHistory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridGatherProductDetails);
            this.Name = "GatherProductDetailsSearch";
            this.Text = "Gather Product Details";
            ((System.ComponentModel.ISupportInitialize)(this.gridGatherProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonProductHistory;
    }
}
