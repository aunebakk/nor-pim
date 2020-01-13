namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserListForDashboardDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultUserListForDashboard;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserListForDashboard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserListForDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserListForDashboard
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserListForDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserListForDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserListForDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserListForDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserListForDashboard.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserListForDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserListForDashboard.Name = "dataGridViewDefaultUserListForDashboard";
            this.dataGridViewDefaultUserListForDashboard.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserListForDashboard.Click += new System.EventHandler(this.dataGridViewDefaultUserListForDashboard_Click);
            this.dataGridViewDefaultUserListForDashboard.TabIndex = 1;
            // 
            // DefaultUserListForDashboardDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserListForDashboard);
            this.Name = "DefaultUserListForDashboardDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserListForDashboard)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
