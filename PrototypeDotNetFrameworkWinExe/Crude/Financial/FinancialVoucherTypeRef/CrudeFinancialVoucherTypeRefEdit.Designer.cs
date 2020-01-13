namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialVoucherType;
        
        private System.Windows.Forms.Label labelFinancialVoucherType;
        
        private System.Windows.Forms.TextBox textBoxFinancialVoucherTypeName;
        
        private System.Windows.Forms.Label labelFinancialVoucherTypeName;
        
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
            this.labelFinancialVoucherType = new System.Windows.Forms.Label();
            this.textBoxFinancialVoucherType = new System.Windows.Forms.TextBox();
            this.labelFinancialVoucherTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialVoucherTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialVoucherType
            //
            this.labelFinancialVoucherType.AutoSize = true;
            this.labelFinancialVoucherType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialVoucherType.Name = "labelFinancialVoucherType";
            this.labelFinancialVoucherType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherType.TabIndex = 2;
            this.labelFinancialVoucherType.Text = "Financial Voucher Type:";
            //
            //textBoxFinancialVoucherType
            //
            this.textBoxFinancialVoucherType.Location = new System.Drawing.Point(189, 13);
            this.textBoxFinancialVoucherType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialVoucherType.Name = "textBoxFinancialVoucherType";
            this.textBoxFinancialVoucherType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialVoucherType.TabIndex = 3;
            //
            // labelFinancialVoucherTypeName
            //
            this.labelFinancialVoucherTypeName.AutoSize = true;
            this.labelFinancialVoucherTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialVoucherTypeName.Name = "labelFinancialVoucherTypeName";
            this.labelFinancialVoucherTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherTypeName.TabIndex = 4;
            this.labelFinancialVoucherTypeName.Text = "Financial Voucher Type Name:";
            //
            //textBoxFinancialVoucherTypeName
            //
            this.textBoxFinancialVoucherTypeName.Location = new System.Drawing.Point(189, 36);
            this.textBoxFinancialVoucherTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialVoucherTypeName.Name = "textBoxFinancialVoucherTypeName";
            this.textBoxFinancialVoucherTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialVoucherTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
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
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialVoucherTypeRefEdit";
            this.Text = "Financial Voucher Type Ref Edit";
            this.Controls.Add(this.labelFinancialVoucherType);
            this.Controls.Add(this.textBoxFinancialVoucherType);
            this.Controls.Add(this.labelFinancialVoucherTypeName);
            this.Controls.Add(this.textBoxFinancialVoucherTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
