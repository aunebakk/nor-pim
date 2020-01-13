namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByNameDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewProductSearchByName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductSearchByName = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductSearchByName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductSearchByName.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductSearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductSearchByName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductSearchByName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductSearchByName.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductSearchByName.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductSearchByName.Name = "dataGridViewProductSearchByName";
            this.dataGridViewProductSearchByName.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductSearchByName.Click += new System.EventHandler(this.dataGridViewProductSearchByName_Click);
            this.dataGridViewProductSearchByName.TabIndex = 1;
            // 
            // ProductSearchByNameDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductSearchByName);
            this.Name = "ProductSearchByNameDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductSearchByName)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
