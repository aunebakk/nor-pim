namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityOnAddressDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultUserActivityOnAddress;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserActivityOnAddress = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityOnAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserActivityOnAddress
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserActivityOnAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserActivityOnAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserActivityOnAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserActivityOnAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserActivityOnAddress.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserActivityOnAddress.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserActivityOnAddress.Name = "dataGridViewDefaultUserActivityOnAddress";
            this.dataGridViewDefaultUserActivityOnAddress.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserActivityOnAddress.Click += new System.EventHandler(this.dataGridViewDefaultUserActivityOnAddress_Click);
            this.dataGridViewDefaultUserActivityOnAddress.TabIndex = 1;
            // 
            // DefaultUserActivityOnAddressDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserActivityOnAddress);
            this.Name = "DefaultUserActivityOnAddressDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityOnAddress)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
