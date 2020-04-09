namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetClientWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetClientWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetClientWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetClientWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetClientWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetClientWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetClientWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetClientWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetClientWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetClientWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetClientWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetClientWithFilter.Name = "dataGridViewGetClientWithFilter";
            this.dataGridViewGetClientWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetClientWithFilter.Click += new System.EventHandler(this.dataGridViewGetClientWithFilter_Click);
            this.dataGridViewGetClientWithFilter.TabIndex = 1;
            // 
            // GetClientWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetClientWithFilter);
            this.Name = "GetClientWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetClientWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
