namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryCodeDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductSearchByCategoryCode;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByCategoryCode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByCategoryCode
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByCategoryCode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByCategoryCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByCategoryCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByCategoryCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByCategoryCode.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByCategoryCode.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByCategoryCode.Name = "dataGridViewProductSearchByCategoryCode";
            this.dataGridViewProductSearchByCategoryCode.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByCategoryCode.Click += new System.EventHandler(this.dataGridViewProductSearchByCategoryCode_Click);
            this.dataGridViewProductSearchByCategoryCode.TabIndex = 1;
            // 
            // ProductSearchByCategoryCodeDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByCategoryCode);
            this.Name = "ProductSearchByCategoryCodeDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByCategoryCode)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
