namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultTestOverviewDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultTestOverview;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultTestOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultTestOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultTestOverview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultTestOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultTestOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultTestOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultTestOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultTestOverview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultTestOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultTestOverview.Name = "dataGridViewDefaultTestOverview";
            this.dataGridViewDefaultTestOverview.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultTestOverview.Click += new System.EventHandler(this.dataGridViewDefaultTestOverview_Click);
            this.dataGridViewDefaultTestOverview.TabIndex = 1;
            // 
            // DefaultTestOverviewDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultTestOverview);
            this.Name = "DefaultTestOverviewDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultTestOverview)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
