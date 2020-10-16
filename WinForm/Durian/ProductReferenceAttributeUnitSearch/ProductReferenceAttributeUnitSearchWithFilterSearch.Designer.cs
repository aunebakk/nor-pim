namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeUnitSearchWithFilterSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductReferenceAttributeUnitSearchWithFilterSearch;

        private ProductReferenceAttributeUnitSearchWithFilterDurian durianProductReferenceAttributeUnitSearchWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch = new System.Windows.Forms.Button();
            this.durianProductReferenceAttributeUnitSearchWithFilter = new ProductReferenceAttributeUnitSearchWithFilterDurian();
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
            // buttonProductReferenceAttributeUnitSearchWithFilterSearch
            // 
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Name = "buttonProductReferenceAttributeUnitSearchWithFilterSearch";
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.TabIndex = 2;
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Text = "&Search";
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonProductReferenceAttributeUnitSearchWithFilterSearch.Click += new System.EventHandler(this.buttonProductReferenceAttributeUnitSearchWithFilterSearch_Click);
            // 
            // durianProductReferenceAttributeUnitSearchWithFilter
            // 
            this.durianProductReferenceAttributeUnitSearchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductReferenceAttributeUnitSearchWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianProductReferenceAttributeUnitSearchWithFilter.Name = "durianProductReferenceAttributeUnitSearchWithFilter";
            this.durianProductReferenceAttributeUnitSearchWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianProductReferenceAttributeUnitSearchWithFilter.TabIndex = 1;
            // 
            // InitProductReferenceAttributeUnitSearchWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductReferenceAttributeUnitSearchWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductReferenceAttributeUnitSearchWithFilter);
            this.Name = "ProductReferenceAttributeUnitSearchWithFilterSearch";
            this.Text = "Product Reference Attribute Unit Search With Filter";
            this.ResumeLayout(false);

        }
    }
}
