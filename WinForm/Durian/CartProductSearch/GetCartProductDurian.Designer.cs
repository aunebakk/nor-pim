namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewGetCartProduct;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetCartProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCartProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetCartProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetCartProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetCartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetCartProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetCartProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetCartProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetCartProduct.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetCartProduct.Name = "dataGridViewGetCartProduct";
            this.dataGridViewGetCartProduct.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetCartProduct.Click += new System.EventHandler(this.dataGridViewGetCartProduct_Click);
            this.dataGridViewGetCartProduct.TabIndex = 1;
            // 
            // GetCartProductDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetCartProduct);
            this.Name = "GetCartProductDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCartProduct)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
