namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryTreeDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewCategoryTree;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCategoryTree = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryTree)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategoryTree
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCategoryTree.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategoryTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoryTree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategoryTree.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategoryTree.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCategoryTree.Name = "dataGridViewCategoryTree";
            this.dataGridViewCategoryTree.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewCategoryTree.Click += new System.EventHandler(this.dataGridViewCategoryTree_Click);
            this.dataGridViewCategoryTree.TabIndex = 1;
            // 
            // CategoryTreeDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCategoryTree);
            this.Name = "CategoryTreeDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryTree)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
