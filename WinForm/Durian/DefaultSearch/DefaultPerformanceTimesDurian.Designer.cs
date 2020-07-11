namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimesDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultPerformanceTimes;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultPerformanceTimes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultPerformanceTimes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultPerformanceTimes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultPerformanceTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultPerformanceTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultPerformanceTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultPerformanceTimes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultPerformanceTimes.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultPerformanceTimes.Name = "dataGridViewDefaultPerformanceTimes";
            this.dataGridViewDefaultPerformanceTimes.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultPerformanceTimes.Click += new System.EventHandler(this.dataGridViewDefaultPerformanceTimes_Click);
            this.dataGridViewDefaultPerformanceTimes.TabIndex = 1;
            // 
            // DefaultPerformanceTimesDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultPerformanceTimes);
            this.Name = "DefaultPerformanceTimesDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceTimes)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
