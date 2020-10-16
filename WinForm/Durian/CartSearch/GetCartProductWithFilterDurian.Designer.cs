namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductWithFilterDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewGetCartProductWithFilter;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetCartProductWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCartProductWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetCartProductWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetCartProductWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetCartProductWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetCartProductWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetCartProductWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetCartProductWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetCartProductWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetCartProductWithFilter.Name = "dataGridViewGetCartProductWithFilter";
            this.dataGridViewGetCartProductWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetCartProductWithFilter.Click += new System.EventHandler(this.dataGridViewGetCartProductWithFilter_Click);
            this.dataGridViewGetCartProductWithFilter.TabIndex = 1;
            // 
            // GetCartProductWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetCartProductWithFilter);
            this.Name = "GetCartProductWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCartProductWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
