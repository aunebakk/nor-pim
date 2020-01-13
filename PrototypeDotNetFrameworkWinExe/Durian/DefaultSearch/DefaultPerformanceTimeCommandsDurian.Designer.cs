namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceTimeCommandsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultPerformanceTimeCommands;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultPerformanceTimeCommands = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceTimeCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultPerformanceTimeCommands
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultPerformanceTimeCommands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultPerformanceTimeCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultPerformanceTimeCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultPerformanceTimeCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultPerformanceTimeCommands.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultPerformanceTimeCommands.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultPerformanceTimeCommands.Name = "dataGridViewDefaultPerformanceTimeCommands";
            this.dataGridViewDefaultPerformanceTimeCommands.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultPerformanceTimeCommands.Click += new System.EventHandler(this.dataGridViewDefaultPerformanceTimeCommands_Click);
            this.dataGridViewDefaultPerformanceTimeCommands.TabIndex = 1;
            // 
            // DefaultPerformanceTimeCommandsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultPerformanceTimeCommands);
            this.Name = "DefaultPerformanceTimeCommandsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultPerformanceTimeCommands)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
