namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceIssueFetchWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultPerformanceIssueFetchWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceIssueFetchWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultPerformanceIssueFetchWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Name = "dataGridViewDefaultPerformanceIssueFetchWithFilter";
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.Click += new System.EventHandler(this.dataGridViewDefaultPerformanceIssueFetchWithFilter_Click);
            this.dataGridViewDefaultPerformanceIssueFetchWithFilter.TabIndex = 1;
            // 
            // DefaultPerformanceIssueFetchWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultPerformanceIssueFetchWithFilter);
            this.Name = "DefaultPerformanceIssueFetchWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceIssueFetchWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
