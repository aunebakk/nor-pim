namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultErrorOverviewDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultErrorOverview;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultErrorOverview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultErrorOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultErrorOverview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultErrorOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultErrorOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultErrorOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultErrorOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultErrorOverview.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultErrorOverview.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultErrorOverview.Name = "dataGridViewDefaultErrorOverview";
            this.dataGridViewDefaultErrorOverview.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultErrorOverview.Click += new System.EventHandler(this.dataGridViewDefaultErrorOverview_Click);
            this.dataGridViewDefaultErrorOverview.TabIndex = 1;
            // 
            // DefaultErrorOverviewDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultErrorOverview);
            this.Name = "DefaultErrorOverviewDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultErrorOverview)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
