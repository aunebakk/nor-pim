namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType3Durian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategoryType3;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategoryType3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategoryType3
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategoryType3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategoryType3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategoryType3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategoryType3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategoryType3.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategoryType3.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategoryType3.Name = "dataGridViewProductSearchByCategoryType3";
            this.dataGridViewProductSearchByCategoryType3.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategoryType3.Click += new System.EventHandler(this.dataGridViewProductSearchByCategoryType3_Click);
            this.dataGridViewProductSearchByCategoryType3.TabIndex = 1;
            // 
            // ProductSearchByCategoryType3Durian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategoryType3);
            this.Name = "ProductSearchByCategoryType3Durian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType3)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
