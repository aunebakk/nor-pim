namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultResourceDatabaseStatisticsDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDefaultResourceDatabaseStatistics;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultResourceDatabaseStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultResourceDatabaseStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultResourceDatabaseStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultResourceDatabaseStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultResourceDatabaseStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultResourceDatabaseStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultResourceDatabaseStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultResourceDatabaseStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultResourceDatabaseStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultResourceDatabaseStatistics.Name = "dataGridViewDefaultResourceDatabaseStatistics";
            this.dataGridViewDefaultResourceDatabaseStatistics.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultResourceDatabaseStatistics.Click += new System.EventHandler(this.dataGridViewDefaultResourceDatabaseStatistics_Click);
            this.dataGridViewDefaultResourceDatabaseStatistics.TabIndex = 1;
            // 
            // DefaultResourceDatabaseStatisticsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultResourceDatabaseStatistics);
            this.Name = "DefaultResourceDatabaseStatisticsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultResourceDatabaseStatistics)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
