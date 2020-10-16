namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetFinancialOrderDurian {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewGetFinancialOrder;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetFinancialOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetFinancialOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetFinancialOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetFinancialOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetFinancialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetFinancialOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetFinancialOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetFinancialOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetFinancialOrder.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetFinancialOrder.Name = "dataGridViewGetFinancialOrder";
            this.dataGridViewGetFinancialOrder.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetFinancialOrder.Click += new System.EventHandler(this.dataGridViewGetFinancialOrder_Click);
            this.dataGridViewGetFinancialOrder.TabIndex = 1;
            // 
            // GetFinancialOrderDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetFinancialOrder);
            this.Name = "GetFinancialOrderDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetFinancialOrder)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
