namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserListDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewDefaultUserList;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultUserList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultUserList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultUserList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultUserList.Name = "dataGridViewDefaultUserList";
            this.dataGridViewDefaultUserList.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultUserList.Click += new System.EventHandler(this.dataGridViewDefaultUserList_Click);
            this.dataGridViewDefaultUserList.TabIndex = 1;
            // 
            // DefaultUserListDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultUserList);
            this.Name = "DefaultUserListDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultUserList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
