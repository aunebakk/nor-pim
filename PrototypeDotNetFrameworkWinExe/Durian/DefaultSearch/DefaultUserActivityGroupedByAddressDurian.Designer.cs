namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityGroupedByAddressDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultUserActivityGroupedByAddress;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserActivityGroupedByAddress = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityGroupedByAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserActivityGroupedByAddress
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserActivityGroupedByAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserActivityGroupedByAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserActivityGroupedByAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserActivityGroupedByAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserActivityGroupedByAddress.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserActivityGroupedByAddress.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserActivityGroupedByAddress.Name = "dataGridViewDefaultUserActivityGroupedByAddress";
            this.dataGridViewDefaultUserActivityGroupedByAddress.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserActivityGroupedByAddress.Click += new System.EventHandler(this.dataGridViewDefaultUserActivityGroupedByAddress_Click);
            this.dataGridViewDefaultUserActivityGroupedByAddress.TabIndex = 1;
            // 
            // DefaultUserActivityGroupedByAddressDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserActivityGroupedByAddress);
            this.Name = "DefaultUserActivityGroupedByAddressDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityGroupedByAddress)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
