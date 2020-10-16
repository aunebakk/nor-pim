namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategory;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategory.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategory.Name = "dataGridViewProductSearchByCategory";
            this.dataGridViewProductSearchByCategory.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategory.Click += new System.EventHandler(this.dataGridViewProductSearchByCategory_Click);
            this.dataGridViewProductSearchByCategory.TabIndex = 1;
            // 
            // ProductSearchByCategoryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategory);
            this.Name = "ProductSearchByCategoryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategory)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
