namespace norpim.UserInterface {
    
    
    public partial class ProductCategoryPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtProductCategoryCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtProductCategoryName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtProductCategoryCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtProductCategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtProductCategoryCode
            //
            this.txtProductCategoryCode.Location = new System.Drawing.Point(0, 1);
            this.txtProductCategoryCode.Name = "txtProductCategoryCode";
            this.txtProductCategoryCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCategoryCode.TabIndex = 1;
            this.txtProductCategoryCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductCategoryCode_Validating);
            //
            // lblColon
            //
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(101, 2);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 2;
            this.lblColon.Text = ":";
            //
            // txtProductCategoryName
            //
            this.txtProductCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCategoryName.Location = new System.Drawing.Point(111, 1);
            this.txtProductCategoryName.Name = "txtProductCategoryName";
            this.txtProductCategoryName.Size = new System.Drawing.Size(199, 20);
            this.txtProductCategoryName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProductCategoryName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtProductCategoryCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
