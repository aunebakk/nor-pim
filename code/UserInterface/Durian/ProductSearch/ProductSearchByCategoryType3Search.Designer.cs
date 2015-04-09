namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType3Search {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button btnClose;
        
        private System.Windows.Forms.Button btnSearch;
        
        private System.Windows.Forms.DataGridView gridProductSearchByCategoryType3;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridProductSearchByCategoryType3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSearchByCategoryType3)).BeginInit();
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
            // gridProductSearchByCategoryType3
            // 
            this.gridProductSearchByCategoryType3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductSearchByCategoryType3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductSearchByCategoryType3.Location = new System.Drawing.Point(2, 3);
            this.gridProductSearchByCategoryType3.Name = "gridProductSearchByCategoryType3";
            this.gridProductSearchByCategoryType3.Size = new System.Drawing.Size(523, 268);
            this.gridProductSearchByCategoryType3.TabIndex = 0;
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridProductSearchByCategoryType3);
            this.Name = "GridProductSearchByCategoryType3Form";
            this.Text = "ProductSearchByCategoryType3";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductSearchByCategoryType3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
