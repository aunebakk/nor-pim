namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueAmount;
        
        private System.Windows.Forms.Label labelValueAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVoucherNumber;
        
        private System.Windows.Forms.Label labelVoucherNumber;
        
        private System.Windows.Forms.TextBox textBoxVoucherDescription;
        
        private System.Windows.Forms.Label labelVoucherDescription;
        
        private FinancialVoucherTypeRefCombo financialVoucherTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialVoucherTypeRefCombo;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelValueAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxValueAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelVoucherNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxVoucherNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelVoucherDescription = new System.Windows.Forms.Label();
            this.textBoxVoucherDescription = new System.Windows.Forms.TextBox();
            this.labelFinancialVoucherTypeRefCombo = new System.Windows.Forms.Label();
            this.financialVoucherTypeRefCombo = new FinancialVoucherTypeRefCombo();
            this.SuspendLayout();
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            //
            // labelValueAmount
            //
            this.labelValueAmount.AutoSize = true;
            this.labelValueAmount.Location = new System.Drawing.Point(11, 36);
            this.labelValueAmount.Name = "labelValueAmount";
            this.labelValueAmount.Size = new System.Drawing.Size(71, 13);
            this.labelValueAmount.TabIndex = 4;
            this.labelValueAmount.Text = "Value Amount:";
            //
            //maskedTextBoxValueAmount
            //
            this.maskedTextBoxValueAmount.Location = new System.Drawing.Point(154, 36);
            this.maskedTextBoxValueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValueAmount.Name = "maskedTextBoxValueAmount";
            this.maskedTextBoxValueAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxValueAmount.TabIndex = 5;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 6;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 7;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 8;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(154, 82);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 9;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
            //
            // labelVoucherNumber
            //
            this.labelVoucherNumber.AutoSize = true;
            this.labelVoucherNumber.Location = new System.Drawing.Point(11, 105);
            this.labelVoucherNumber.Name = "labelVoucherNumber";
            this.labelVoucherNumber.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherNumber.TabIndex = 10;
            this.labelVoucherNumber.Text = "Voucher Number:";
            //
            //maskedTextBoxVoucherNumber
            //
            this.maskedTextBoxVoucherNumber.Location = new System.Drawing.Point(154, 105);
            this.maskedTextBoxVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxVoucherNumber.Name = "maskedTextBoxVoucherNumber";
            this.maskedTextBoxVoucherNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxVoucherNumber.TabIndex = 11;
            //
            // labelVoucherDescription
            //
            this.labelVoucherDescription.AutoSize = true;
            this.labelVoucherDescription.Location = new System.Drawing.Point(11, 128);
            this.labelVoucherDescription.Name = "labelVoucherDescription";
            this.labelVoucherDescription.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherDescription.TabIndex = 12;
            this.labelVoucherDescription.Text = "Voucher Description:";
            //
            //textBoxVoucherDescription
            //
            this.textBoxVoucherDescription.Location = new System.Drawing.Point(154, 128);
            this.textBoxVoucherDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVoucherDescription.Name = "textBoxVoucherDescription";
            this.textBoxVoucherDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxVoucherDescription.TabIndex = 13;
            //
            // labelFinancialVoucherTypeRefCombo
            //
            this.labelFinancialVoucherTypeRefCombo.AutoSize = true;
            this.labelFinancialVoucherTypeRefCombo.Location = new System.Drawing.Point(11, 151);
            this.labelFinancialVoucherTypeRefCombo.Name = "labelFinancialVoucherTypeRefCombo";
            this.labelFinancialVoucherTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherTypeRefCombo.TabIndex = 14;
            this.labelFinancialVoucherTypeRefCombo.Text = "Financial Voucher Type:";
            //
            //financialVoucherTypeRefCombo
            //
            this.financialVoucherTypeRefCombo.Location = new System.Drawing.Point(154, 151);
            this.financialVoucherTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialVoucherTypeRefCombo.Name = "financialVoucherTypeRefCombo";
            this.financialVoucherTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialVoucherTypeRefCombo.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 174);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 174);
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
            this.ClientSize = new System.Drawing.Size(416, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialVoucherEdit";
            this.Text = "Financial Voucher Edit";
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelValueAmount);
            this.Controls.Add(this.maskedTextBoxValueAmount);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelVoucherNumber);
            this.Controls.Add(this.maskedTextBoxVoucherNumber);
            this.Controls.Add(this.labelVoucherDescription);
            this.Controls.Add(this.textBoxVoucherDescription);
            this.Controls.Add(this.labelFinancialVoucherTypeRefCombo);
            this.Controls.Add(this.financialVoucherTypeRefCombo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
