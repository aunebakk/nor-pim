namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DashboardCountsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDashboardCounts;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDashboardCounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboardCounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDashboardCounts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDashboardCounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDashboardCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDashboardCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDashboardCounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDashboardCounts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDashboardCounts.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDashboardCounts.Name = "dataGridViewDashboardCounts";
            this.dataGridViewDashboardCounts.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDashboardCounts.Click += new System.EventHandler(this.dataGridViewDashboardCounts_Click);
            this.dataGridViewDashboardCounts.TabIndex = 1;
            // 
            // DashboardCountsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDashboardCounts);
            this.Name = "DashboardCountsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboardCounts)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
