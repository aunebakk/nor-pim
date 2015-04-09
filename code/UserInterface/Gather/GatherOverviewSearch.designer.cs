namespace norpim.UserInterface {
    
    
    public partial class GatherOverviewSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button btnClose;
        
        private System.Windows.Forms.Button btnSearch;
        
        private System.Windows.Forms.DataGridView gridGatherOverview;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridGatherOverview = new System.Windows.Forms.DataGridView();
            this.buttonChangedProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGatherOverview)).BeginInit();
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
            // gridGatherOverview
            // 
            this.gridGatherOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGatherOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGatherOverview.Location = new System.Drawing.Point(2, 3);
            this.gridGatherOverview.Name = "gridGatherOverview";
            this.gridGatherOverview.Size = new System.Drawing.Size(523, 268);
            this.gridGatherOverview.TabIndex = 0;
            // 
            // buttonChangedProducts
            // 
            this.buttonChangedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangedProducts.Location = new System.Drawing.Point(190, 277);
            this.buttonChangedProducts.Name = "buttonChangedProducts";
            this.buttonChangedProducts.Size = new System.Drawing.Size(112, 22);
            this.buttonChangedProducts.TabIndex = 3;
            this.buttonChangedProducts.Text = "&Changed Products";
            this.buttonChangedProducts.UseVisualStyleBackColor = true;
            this.buttonChangedProducts.Click += new System.EventHandler(this.buttonChangedProducts_Click);
            // 
            // GatherOverviewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonChangedProducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridGatherOverview);
            this.Name = "GatherOverviewSearch";
            this.Text = "Gather Overview";
            ((System.ComponentModel.ISupportInitialize)(this.gridGatherOverview)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonChangedProducts;
    }
}
