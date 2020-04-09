namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsByMonthDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultStatisticsByMonth;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultStatisticsByMonth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatisticsByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultStatisticsByMonth
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultStatisticsByMonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultStatisticsByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultStatisticsByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultStatisticsByMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultStatisticsByMonth.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultStatisticsByMonth.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultStatisticsByMonth.Name = "dataGridViewDefaultStatisticsByMonth";
            this.dataGridViewDefaultStatisticsByMonth.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultStatisticsByMonth.Click += new System.EventHandler(this.dataGridViewDefaultStatisticsByMonth_Click);
            this.dataGridViewDefaultStatisticsByMonth.TabIndex = 1;
            // 
            // DefaultStatisticsByMonthDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultStatisticsByMonth);
            this.Name = "DefaultStatisticsByMonthDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultStatisticsByMonth)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
