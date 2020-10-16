namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType1Durian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategoryType1;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategoryType1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategoryType1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategoryType1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategoryType1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategoryType1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategoryType1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategoryType1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategoryType1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategoryType1.Name = "dataGridViewProductSearchByCategoryType1";
            this.dataGridViewProductSearchByCategoryType1.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategoryType1.Click += new System.EventHandler(this.dataGridViewProductSearchByCategoryType1_Click);
            this.dataGridViewProductSearchByCategoryType1.TabIndex = 1;
            // 
            // ProductSearchByCategoryType1Durian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategoryType1);
            this.Name = "ProductSearchByCategoryType1Durian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
