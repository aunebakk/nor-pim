namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialCouponType;
        
        private System.Windows.Forms.Label labelFinancialCouponType;
        
        private System.Windows.Forms.TextBox textBoxFinancialCouponTypeName;
        
        private System.Windows.Forms.Label labelFinancialCouponTypeName;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFinancialCouponType = new System.Windows.Forms.Label();
            this.textBoxFinancialCouponType = new System.Windows.Forms.TextBox();
            this.labelFinancialCouponTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCouponTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCouponType
            //
            this.labelFinancialCouponType.AutoSize = true;
            this.labelFinancialCouponType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCouponType.Name = "labelFinancialCouponType";
            this.labelFinancialCouponType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponType.TabIndex = 2;
            this.labelFinancialCouponType.Text = "Financial Coupon Type:";
            //
            //textBoxFinancialCouponType
            //
            this.textBoxFinancialCouponType.Location = new System.Drawing.Point(182, 13);
            this.textBoxFinancialCouponType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCouponType.Name = "textBoxFinancialCouponType";
            this.textBoxFinancialCouponType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCouponType.TabIndex = 3;
            //
            // labelFinancialCouponTypeName
            //
            this.labelFinancialCouponTypeName.AutoSize = true;
            this.labelFinancialCouponTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCouponTypeName.Name = "labelFinancialCouponTypeName";
            this.labelFinancialCouponTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCouponTypeName.TabIndex = 4;
            this.labelFinancialCouponTypeName.Text = "Financial Coupon Type Name:";
            //
            //textBoxFinancialCouponTypeName
            //
            this.textBoxFinancialCouponTypeName.Location = new System.Drawing.Point(182, 36);
            this.textBoxFinancialCouponTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCouponTypeName.Name = "textBoxFinancialCouponTypeName";
            this.textBoxFinancialCouponTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCouponTypeName.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 82);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(240, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCouponTypeRefEdit";
            this.Text = "Financial Coupon Type Ref Edit";
            this.Controls.Add(this.labelFinancialCouponType);
            this.Controls.Add(this.textBoxFinancialCouponType);
            this.Controls.Add(this.labelFinancialCouponTypeName);
            this.Controls.Add(this.textBoxFinancialCouponTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
