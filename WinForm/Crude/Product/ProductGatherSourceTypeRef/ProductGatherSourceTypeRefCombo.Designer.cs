namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductGatherSourceTypeRefCombo {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cboRef;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.cboRef = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboRef
            // 
            this.cboRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRef.FormattingEnabled = true;
            this.cboRef.Location = new System.Drawing.Point(0, 0);
            this.cboRef.Name = "cboRef";
            this.cboRef.Size = new System.Drawing.Size(150, 20);
            this.cboRef.Click += new System.EventHandler(this.cboRef_Click);
            this.cboRef.SelectedIndexChanged += new System.EventHandler(this.cboRef_SelectedIndexChanged);
            this.cboRef.TabIndex = 0;
            // 
            // ProductGatherSourceTypeRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboRef);
            this.Name = "ProductGatherSourceTypeRef";
            this.Size = new System.Drawing.Size(150, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
