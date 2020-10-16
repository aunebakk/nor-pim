namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultIssueWithFilterDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDefaultIssueWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultIssueWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultIssueWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultIssueWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultIssueWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultIssueWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultIssueWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultIssueWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultIssueWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultIssueWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultIssueWithFilter.Name = "dataGridViewDefaultIssueWithFilter";
            this.dataGridViewDefaultIssueWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultIssueWithFilter.Click += new System.EventHandler(this.dataGridViewDefaultIssueWithFilter_Click);
            this.dataGridViewDefaultIssueWithFilter.TabIndex = 1;
            // 
            // DefaultIssueWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultIssueWithFilter);
            this.Name = "DefaultIssueWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultIssueWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
