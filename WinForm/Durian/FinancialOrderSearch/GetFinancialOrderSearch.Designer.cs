namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetFinancialOrderSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonGetFinancialOrderSearch;

        private GetFinancialOrderDurian durianGetFinancialOrder;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetFinancialOrderSearch = new System.Windows.Forms.Button();
            this.durianGetFinancialOrder = new GetFinancialOrderDurian();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(422, 277);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGetFinancialOrderSearch
            // 
            this.buttonGetFinancialOrderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetFinancialOrderSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetFinancialOrderSearch.Name = "buttonGetFinancialOrderSearch";
            this.buttonGetFinancialOrderSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetFinancialOrderSearch.TabIndex = 2;
            this.buttonGetFinancialOrderSearch.Text = "&Search";
            this.buttonGetFinancialOrderSearch.UseVisualStyleBackColor = true;
            this.buttonGetFinancialOrderSearch.Click += new System.EventHandler(this.buttonGetFinancialOrderSearch_Click);
            // 
            // durianGetFinancialOrder
            // 
            this.durianGetFinancialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetFinancialOrder.Location = new System.Drawing.Point(12, 12);
            this.durianGetFinancialOrder.Name = "durianGetFinancialOrder";
            this.durianGetFinancialOrder.Size = new System.Drawing.Size(502, 259);
            this.durianGetFinancialOrder.TabIndex = 1;
            // 
            // InitGetFinancialOrderSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetFinancialOrderSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetFinancialOrder);
            this.Name = "GetFinancialOrderSearch";
            this.Text = "Get Financial Order";
            this.ResumeLayout(false);

        }
    }
}
