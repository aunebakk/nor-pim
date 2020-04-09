namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryFindDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewCategoryFind;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCategoryFind = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryFind)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategoryFind
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCategoryFind.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategoryFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategoryFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoryFind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategoryFind.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategoryFind.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCategoryFind.Name = "dataGridViewCategoryFind";
            this.dataGridViewCategoryFind.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewCategoryFind.Click += new System.EventHandler(this.dataGridViewCategoryFind_Click);
            this.dataGridViewCategoryFind.TabIndex = 1;
            // 
            // CategoryFindDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCategoryFind);
            this.Name = "CategoryFindDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryFind)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
