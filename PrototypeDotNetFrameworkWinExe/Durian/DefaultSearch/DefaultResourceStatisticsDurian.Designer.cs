namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultResourceStatisticsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultResourceStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultResourceStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultResourceStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultResourceStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultResourceStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultResourceStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultResourceStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultResourceStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultResourceStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultResourceStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultResourceStatistics.Name = "dataGridViewDefaultResourceStatistics";
            this.dataGridViewDefaultResourceStatistics.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultResourceStatistics.Click += new System.EventHandler(this.dataGridViewDefaultResourceStatistics_Click);
            this.dataGridViewDefaultResourceStatistics.TabIndex = 1;
            // 
            // DefaultResourceStatisticsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultResourceStatistics);
            this.Name = "DefaultResourceStatisticsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultResourceStatistics)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
