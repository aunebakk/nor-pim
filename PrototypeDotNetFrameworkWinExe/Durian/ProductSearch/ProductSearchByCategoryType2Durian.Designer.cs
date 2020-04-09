namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType2Durian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategoryType2;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategoryType2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategoryType2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategoryType2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategoryType2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategoryType2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategoryType2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategoryType2.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategoryType2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategoryType2.Name = "dataGridViewProductSearchByCategoryType2";
            this.dataGridViewProductSearchByCategoryType2.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategoryType2.Click += new System.EventHandler(this.dataGridViewProductSearchByCategoryType2_Click);
            this.dataGridViewProductSearchByCategoryType2.TabIndex = 1;
            // 
            // ProductSearchByCategoryType2Durian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategoryType2);
            this.Name = "ProductSearchByCategoryType2Durian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType2)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
