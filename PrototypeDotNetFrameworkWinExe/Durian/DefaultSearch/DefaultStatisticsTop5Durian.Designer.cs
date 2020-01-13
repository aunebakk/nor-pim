namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsTop5Durian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultStatisticsTop5;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultStatisticsTop5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatisticsTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultStatisticsTop5
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultStatisticsTop5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultStatisticsTop5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultStatisticsTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultStatisticsTop5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultStatisticsTop5.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultStatisticsTop5.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultStatisticsTop5.Name = "dataGridViewDefaultStatisticsTop5";
            this.dataGridViewDefaultStatisticsTop5.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultStatisticsTop5.Click += new System.EventHandler(this.dataGridViewDefaultStatisticsTop5_Click);
            this.dataGridViewDefaultStatisticsTop5.TabIndex = 1;
            // 
            // DefaultStatisticsTop5Durian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultStatisticsTop5);
            this.Name = "DefaultStatisticsTop5Durian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatisticsTop5)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
