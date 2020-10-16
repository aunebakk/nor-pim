namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceIndexSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductMaintenanceIndexSearch;

        private ProductMaintenanceIndexDurian durianProductMaintenanceIndex;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceIndexSearch = new System.Windows.Forms.Button();
            this.durianProductMaintenanceIndex = new ProductMaintenanceIndexDurian();
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
            // buttonProductMaintenanceIndexSearch
            // 
            this.buttonProductMaintenanceIndexSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceIndexSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductMaintenanceIndexSearch.Name = "buttonProductMaintenanceIndexSearch";
            this.buttonProductMaintenanceIndexSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceIndexSearch.TabIndex = 2;
            this.buttonProductMaintenanceIndexSearch.Text = "&Search";
            this.buttonProductMaintenanceIndexSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceIndexSearch.Click += new System.EventHandler(this.buttonProductMaintenanceIndexSearch_Click);
            // 
            // durianProductMaintenanceIndex
            // 
            this.durianProductMaintenanceIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductMaintenanceIndex.Location = new System.Drawing.Point(12, 12);
            this.durianProductMaintenanceIndex.Name = "durianProductMaintenanceIndex";
            this.durianProductMaintenanceIndex.Size = new System.Drawing.Size(502, 259);
            this.durianProductMaintenanceIndex.TabIndex = 1;
            // 
            // InitProductMaintenanceIndexSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductMaintenanceIndexSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductMaintenanceIndex);
            this.Name = "ProductMaintenanceIndexSearch";
            this.Text = "Product Maintenance Index";
            this.ResumeLayout(false);

        }
    }
}
