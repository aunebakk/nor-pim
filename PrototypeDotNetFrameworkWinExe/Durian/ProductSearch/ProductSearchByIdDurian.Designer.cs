namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByIdDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductSearchById;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchById = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchById)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchById
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchById.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchById.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchById.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchById.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchById.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchById.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchById.Name = "dataGridViewProductSearchById";
            this.dataGridViewProductSearchById.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchById.Click += new System.EventHandler(this.dataGridViewProductSearchById_Click);
            this.dataGridViewProductSearchById.TabIndex = 1;
            // 
            // ProductSearchByIdDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchById);
            this.Name = "ProductSearchByIdDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchById)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
