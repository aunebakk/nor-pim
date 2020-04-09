namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityGroupedDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultUserActivityGrouped;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserActivityGrouped = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityGrouped)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserActivityGrouped
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserActivityGrouped.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserActivityGrouped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserActivityGrouped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserActivityGrouped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserActivityGrouped.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserActivityGrouped.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserActivityGrouped.Name = "dataGridViewDefaultUserActivityGrouped";
            this.dataGridViewDefaultUserActivityGrouped.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserActivityGrouped.Click += new System.EventHandler(this.dataGridViewDefaultUserActivityGrouped_Click);
            this.dataGridViewDefaultUserActivityGrouped.TabIndex = 1;
            // 
            // DefaultUserActivityGroupedDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserActivityGrouped);
            this.Name = "DefaultUserActivityGroupedDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityGrouped)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
