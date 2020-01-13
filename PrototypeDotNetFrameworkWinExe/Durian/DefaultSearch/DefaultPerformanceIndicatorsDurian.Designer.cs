namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceIndicatorsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultPerformanceIndicators;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultPerformanceIndicators = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceIndicators)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultPerformanceIndicators
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultPerformanceIndicators.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultPerformanceIndicators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultPerformanceIndicators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultPerformanceIndicators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultPerformanceIndicators.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultPerformanceIndicators.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultPerformanceIndicators.Name = "dataGridViewDefaultPerformanceIndicators";
            this.dataGridViewDefaultPerformanceIndicators.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultPerformanceIndicators.Click += new System.EventHandler(this.dataGridViewDefaultPerformanceIndicators_Click);
            this.dataGridViewDefaultPerformanceIndicators.TabIndex = 1;
            // 
            // DefaultPerformanceIndicatorsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultPerformanceIndicators);
            this.Name = "DefaultPerformanceIndicatorsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceIndicators)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
