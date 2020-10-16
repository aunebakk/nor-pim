namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonGetCartProductSearch;

        private GetCartProductDurian durianGetCartProduct;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetCartProductSearch = new System.Windows.Forms.Button();
            this.durianGetCartProduct = new GetCartProductDurian();
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
            // buttonGetCartProductSearch
            // 
            this.buttonGetCartProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetCartProductSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetCartProductSearch.Name = "buttonGetCartProductSearch";
            this.buttonGetCartProductSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetCartProductSearch.TabIndex = 2;
            this.buttonGetCartProductSearch.Text = "&Search";
            this.buttonGetCartProductSearch.UseVisualStyleBackColor = true;
            this.buttonGetCartProductSearch.Click += new System.EventHandler(this.buttonGetCartProductSearch_Click);
            // 
            // durianGetCartProduct
            // 
            this.durianGetCartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetCartProduct.Location = new System.Drawing.Point(12, 12);
            this.durianGetCartProduct.Name = "durianGetCartProduct";
            this.durianGetCartProduct.Size = new System.Drawing.Size(502, 259);
            this.durianGetCartProduct.TabIndex = 1;
            // 
            // InitGetCartProductSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetCartProductSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetCartProduct);
            this.Name = "GetCartProductSearch";
            this.Text = "Get Cart Product";
            this.ResumeLayout(false);

        }
    }
}
