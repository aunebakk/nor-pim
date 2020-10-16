namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceImageIndexWithFilterSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductMaintenanceImageIndexWithFilterSearch;

        private ProductMaintenanceImageIndexWithFilterDurian durianProductMaintenanceImageIndexWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceImageIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceImageIndexWithFilter = new ProductMaintenanceImageIndexWithFilterDurian();
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
            // buttonProductMaintenanceImageIndexWithFilterSearch
            // 
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Name = "buttonProductMaintenanceImageIndexWithFilterSearch";
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceImageIndexWithFilterSearch.TabIndex = 2;
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Text = "&Search";
            this.buttonProductMaintenanceImageIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceImageIndexWithFilterSearch.Click += new System.EventHandler(this.buttonProductMaintenanceImageIndexWithFilterSearch_Click);
            // 
            // durianProductMaintenanceImageIndexWithFilter
            // 
            this.durianProductMaintenanceImageIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceImageIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceImageIndexWithFilter.Name = "durianProductMaintenanceImageIndexWithFilter";
            this.durianProductMaintenanceImageIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceImageIndexWithFilter.TabIndex = 1;
            // 
            // InitProductMaintenanceImageIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceImageIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceImageIndexWithFilter);
            this.Name = "ProductMaintenanceImageIndexWithFilterSearch";
            this.Text = "Product Maintenance Image Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
