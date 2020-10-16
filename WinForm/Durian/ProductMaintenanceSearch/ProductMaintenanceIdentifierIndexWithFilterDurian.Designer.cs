namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceIdentifierIndexWithFilterDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewProductMaintenanceIdentifierIndexWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceIdentifierIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductMaintenanceIdentifierIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Name = "dataGridViewProductMaintenanceIdentifierIndexWithFilter";
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.Click += new System.EventHandler(this.dataGridViewProductMaintenanceIdentifierIndexWithFilter_Click);
            this.dataGridViewProductMaintenanceIdentifierIndexWithFilter.TabIndex = 1;
            // 
            // ProductMaintenanceIdentifierIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProductMaintenanceIdentifierIndexWithFilter);
            this.Name = "ProductMaintenanceIdentifierIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenanceIdentifierIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
