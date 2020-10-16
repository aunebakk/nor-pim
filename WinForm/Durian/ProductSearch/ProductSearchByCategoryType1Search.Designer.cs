namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType1Search {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonProductSearchByCategoryType1Search;

        private ProductSearchByCategoryType1Durian durianProductSearchByCategoryType1;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonProductSearchByCategoryType1Search = new System.Windows.Forms.Button();
            this.durianProductSearchByCategoryType1 = new ProductSearchByCategoryType1Durian();
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
            // buttonProductSearchByCategoryType1Search
            // 
            this.buttonProductSearchByCategoryType1Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductSearchByCategoryType1Search.Location = new System.Drawing.Point(324, 277);
            this.buttonProductSearchByCategoryType1Search.Name = "buttonProductSearchByCategoryType1Search";
            this.buttonProductSearchByCategoryType1Search.Size = new System.Drawing.Size(92, 22);
            this.buttonProductSearchByCategoryType1Search.TabIndex = 2;
            this.buttonProductSearchByCategoryType1Search.Text = "&Search";
            this.buttonProductSearchByCategoryType1Search.UseVisualStyleBackColor = true;
            this.buttonProductSearchByCategoryType1Search.Click += new System.EventHandler(this.buttonProductSearchByCategoryType1Search_Click);
            // 
            // durianProductSearchByCategoryType1
            // 
            this.durianProductSearchByCategoryType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianProductSearchByCategoryType1.Location = new System.Drawing.Point(12, 12);
            this.durianProductSearchByCategoryType1.Name = "durianProductSearchByCategoryType1";
            this.durianProductSearchByCategoryType1.Size = new System.Drawing.Size(502, 259);
            this.durianProductSearchByCategoryType1.TabIndex = 1;
            // 
            // InitProductSearchByCategoryType1Search
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonProductSearchByCategoryType1Search);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianProductSearchByCategoryType1);
            this.Name = "ProductSearchByCategoryType1Search";
            this.Text = "Product Search By Category Type1";
            this.ResumeLayout(false);

        }
    }
}
