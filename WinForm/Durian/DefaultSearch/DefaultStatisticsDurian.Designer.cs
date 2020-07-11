namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultStatistics.Name = "dataGridViewDefaultStatistics";
            this.dataGridViewDefaultStatistics.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultStatistics.Click += new System.EventHandler(this.dataGridViewDefaultStatistics_Click);
            this.dataGridViewDefaultStatistics.TabIndex = 1;
            // 
            // DefaultStatisticsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultStatistics);
            this.Name = "DefaultStatisticsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatistics)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
