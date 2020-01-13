namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType4Durian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategoryType4;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategoryType4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategoryType4
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategoryType4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategoryType4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategoryType4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategoryType4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategoryType4.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategoryType4.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategoryType4.Name = "dataGridViewProductSearchByCategoryType4";
            this.dataGridViewProductSearchByCategoryType4.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategoryType4.Click += new System.EventHandler(this.dataGridViewProductSearchByCategoryType4_Click);
            this.dataGridViewProductSearchByCategoryType4.TabIndex = 1;
            // 
            // ProductSearchByCategoryType4Durian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategoryType4);
            this.Name = "ProductSearchByCategoryType4Durian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryType4)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
