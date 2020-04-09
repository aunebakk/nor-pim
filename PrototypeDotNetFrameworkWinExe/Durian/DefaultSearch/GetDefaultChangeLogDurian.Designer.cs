namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetDefaultChangeLogDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetDefaultChangeLog;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetDefaultChangeLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetDefaultChangeLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetDefaultChangeLog
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetDefaultChangeLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetDefaultChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetDefaultChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetDefaultChangeLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetDefaultChangeLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetDefaultChangeLog.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetDefaultChangeLog.Name = "dataGridViewGetDefaultChangeLog";
            this.dataGridViewGetDefaultChangeLog.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetDefaultChangeLog.Click += new System.EventHandler(this.dataGridViewGetDefaultChangeLog_Click);
            this.dataGridViewGetDefaultChangeLog.TabIndex = 1;
            // 
            // GetDefaultChangeLogDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetDefaultChangeLog);
            this.Name = "GetDefaultChangeLogDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetDefaultChangeLog)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
