namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityByHourDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultUserActivityByHour;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserActivityByHour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityByHour)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserActivityByHour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserActivityByHour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserActivityByHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserActivityByHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserActivityByHour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserActivityByHour.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserActivityByHour.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserActivityByHour.Name = "dataGridViewDefaultUserActivityByHour";
            this.dataGridViewDefaultUserActivityByHour.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserActivityByHour.Click += new System.EventHandler(this.dataGridViewDefaultUserActivityByHour_Click);
            this.dataGridViewDefaultUserActivityByHour.TabIndex = 1;
            // 
            // DefaultUserActivityByHourDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserActivityByHour);
            this.Name = "DefaultUserActivityByHourDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityByHour)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
