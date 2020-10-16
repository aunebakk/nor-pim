namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByIdSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductSearchByIdSearch;

        private ProductSearchByIdDurian durianProductSearchById;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByIdSearch = new System.Windows.Forms.Button();
            this.durianProductSearchById = new ProductSearchByIdDurian();
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
            // buttonProductSearchByIdSearch
            // 
            this.buttonProductSearchByIdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByIdSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByIdSearch.Name = "buttonProductSearchByIdSearch";
            this.buttonProductSearchByIdSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByIdSearch.TabIndex = 2;
            this.buttonProductSearchByIdSearch.Text = "&Search";
            this.buttonProductSearchByIdSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearchByIdSearch.Click += new System.EventHandler(this.buttonProductSearchByIdSearch_Click);
            // 
            // durianProductSearchById
            // 
            this.durianProductSearchById.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchById.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchById.Name = "durianProductSearchById";
            this.durianProductSearchById.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchById.TabIndex = 1;
            // 
            // InitProductSearchByIdSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByIdSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchById);
            this.Name = "ProductSearchByIdSearch";
            this.Text = "Product Search By Id";
            this.ResumeLayout(false);

        }
    }
}
