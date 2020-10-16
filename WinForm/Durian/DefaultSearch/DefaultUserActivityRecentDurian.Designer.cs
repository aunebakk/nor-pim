namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityRecentDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDefaultUserActivityRecent;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserActivityRecent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserActivityRecent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserActivityRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserActivityRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserActivityRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserActivityRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserActivityRecent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserActivityRecent.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserActivityRecent.Name = "dataGridViewDefaultUserActivityRecent";
            this.dataGridViewDefaultUserActivityRecent.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserActivityRecent.Click += new System.EventHandler(this.dataGridViewDefaultUserActivityRecent_Click);
            this.dataGridViewDefaultUserActivityRecent.TabIndex = 1;
            // 
            // DefaultUserActivityRecentDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserActivityRecent);
            this.Name = "DefaultUserActivityRecentDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserActivityRecent)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
