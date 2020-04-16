namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCardEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.TextBox textBoxCardNumber;
        
        private System.Windows.Forms.Label labelCardNumber;
        
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        
        private System.Windows.Forms.Label labelNameOnCard;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryYear;
        
        private System.Windows.Forms.Label labelExpiryYear;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryMonth;
        
        private System.Windows.Forms.Label labelExpiryMonth;
        
        private FinancialCardTypeRefCombo financialCardTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCardTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCardVerificationValue;
        
        private System.Windows.Forms.Label labelCardVerificationValue;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedMonth;
        
        private System.Windows.Forms.Label labelIssuedMonth;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedYear;
        
        private System.Windows.Forms.Label labelIssuedYear;
        
        private System.Windows.Forms.TextBox textBoxAddressVerificationCode;
        
        private System.Windows.Forms.Label labelAddressVerificationCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
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
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.labelExpiryYear = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryYear = new System.Windows.Forms.MaskedTextBox();
            this.labelExpiryMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCardTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCardTypeRefCombo = new FinancialCardTypeRefCombo();
            this.labelCardVerificationValue = new System.Windows.Forms.Label();
            this.maskedTextBoxCardVerificationValue = new System.Windows.Forms.MaskedTextBox();
            this.labelIssuedMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelIssuedYear = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedYear = new System.Windows.Forms.MaskedTextBox();
            this.labelAddressVerificationCode = new System.Windows.Forms.Label();
            this.textBoxAddressVerificationCode = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            //
            // labelCardNumber
            //
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(11, 36);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCardNumber.TabIndex = 4;
            this.labelCardNumber.Text = "Card Number:";
            //
            //textBoxCardNumber
            //
            this.textBoxCardNumber.Location = new System.Drawing.Point(175, 36);
            this.textBoxCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxCardNumber.TabIndex = 5;
            //
            // labelNameOnCard
            //
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(11, 59);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(71, 13);
            this.labelNameOnCard.TabIndex = 6;
            this.labelNameOnCard.Text = "Name On Card:";
            //
            //textBoxNameOnCard
            //
            this.textBoxNameOnCard.Location = new System.Drawing.Point(175, 59);
            this.textBoxNameOnCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(250, 20);
            this.textBoxNameOnCard.TabIndex = 7;
            //
            // labelExpiryYear
            //
            this.labelExpiryYear.AutoSize = true;
            this.labelExpiryYear.Location = new System.Drawing.Point(11, 82);
            this.labelExpiryYear.Name = "labelExpiryYear";
            this.labelExpiryYear.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryYear.TabIndex = 8;
            this.labelExpiryYear.Text = "Expiry Year:";
            //
            //maskedTextBoxExpiryYear
            //
            this.maskedTextBoxExpiryYear.Location = new System.Drawing.Point(175, 82);
            this.maskedTextBoxExpiryYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxExpiryYear.Name = "maskedTextBoxExpiryYear";
            this.maskedTextBoxExpiryYear.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxExpiryYear.TabIndex = 9;
            //
            // labelExpiryMonth
            //
            this.labelExpiryMonth.AutoSize = true;
            this.labelExpiryMonth.Location = new System.Drawing.Point(11, 105);
            this.labelExpiryMonth.Name = "labelExpiryMonth";
            this.labelExpiryMonth.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryMonth.TabIndex = 10;
            this.labelExpiryMonth.Text = "Expiry Month:";
            //
            //maskedTextBoxExpiryMonth
            //
            this.maskedTextBoxExpiryMonth.Location = new System.Drawing.Point(175, 105);
            this.maskedTextBoxExpiryMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxExpiryMonth.Name = "maskedTextBoxExpiryMonth";
            this.maskedTextBoxExpiryMonth.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxExpiryMonth.TabIndex = 11;
            //
            // labelFinancialCardTypeRefCombo
            //
            this.labelFinancialCardTypeRefCombo.AutoSize = true;
            this.labelFinancialCardTypeRefCombo.Location = new System.Drawing.Point(11, 128);
            this.labelFinancialCardTypeRefCombo.Name = "labelFinancialCardTypeRefCombo";
            this.labelFinancialCardTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardTypeRefCombo.TabIndex = 12;
            this.labelFinancialCardTypeRefCombo.Text = "Financial Card Type:";
            //
            //financialCardTypeRefCombo
            //
            this.financialCardTypeRefCombo.Location = new System.Drawing.Point(175, 128);
            this.financialCardTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCardTypeRefCombo.Name = "financialCardTypeRefCombo";
            this.financialCardTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCardTypeRefCombo.TabIndex = 13;
            //
            // labelCardVerificationValue
            //
            this.labelCardVerificationValue.AutoSize = true;
            this.labelCardVerificationValue.Location = new System.Drawing.Point(11, 151);
            this.labelCardVerificationValue.Name = "labelCardVerificationValue";
            this.labelCardVerificationValue.Size = new System.Drawing.Size(71, 13);
            this.labelCardVerificationValue.TabIndex = 14;
            this.labelCardVerificationValue.Text = "Card Verification Value:";
            //
            //maskedTextBoxCardVerificationValue
            //
            this.maskedTextBoxCardVerificationValue.Location = new System.Drawing.Point(175, 151);
            this.maskedTextBoxCardVerificationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCardVerificationValue.Name = "maskedTextBoxCardVerificationValue";
            this.maskedTextBoxCardVerificationValue.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCardVerificationValue.TabIndex = 15;
            //
            // labelIssuedMonth
            //
            this.labelIssuedMonth.AutoSize = true;
            this.labelIssuedMonth.Location = new System.Drawing.Point(11, 174);
            this.labelIssuedMonth.Name = "labelIssuedMonth";
            this.labelIssuedMonth.Size = new System.Drawing.Size(71, 13);
            this.labelIssuedMonth.TabIndex = 16;
            this.labelIssuedMonth.Text = "Issued Month:";
            //
            //maskedTextBoxIssuedMonth
            //
            this.maskedTextBoxIssuedMonth.Location = new System.Drawing.Point(175, 174);
            this.maskedTextBoxIssuedMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxIssuedMonth.Name = "maskedTextBoxIssuedMonth";
            this.maskedTextBoxIssuedMonth.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxIssuedMonth.TabIndex = 17;
            //
            // labelIssuedYear
            //
            this.labelIssuedYear.AutoSize = true;
            this.labelIssuedYear.Location = new System.Drawing.Point(11, 197);
            this.labelIssuedYear.Name = "labelIssuedYear";
            this.labelIssuedYear.Size = new System.Drawing.Size(71, 13);
            this.labelIssuedYear.TabIndex = 18;
            this.labelIssuedYear.Text = "Issued Year:";
            //
            //maskedTextBoxIssuedYear
            //
            this.maskedTextBoxIssuedYear.Location = new System.Drawing.Point(175, 197);
            this.maskedTextBoxIssuedYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxIssuedYear.Name = "maskedTextBoxIssuedYear";
            this.maskedTextBoxIssuedYear.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxIssuedYear.TabIndex = 19;
            //
            // labelAddressVerificationCode
            //
            this.labelAddressVerificationCode.AutoSize = true;
            this.labelAddressVerificationCode.Location = new System.Drawing.Point(11, 220);
            this.labelAddressVerificationCode.Name = "labelAddressVerificationCode";
            this.labelAddressVerificationCode.Size = new System.Drawing.Size(71, 13);
            this.labelAddressVerificationCode.TabIndex = 20;
            this.labelAddressVerificationCode.Text = "Address Verification Code:";
            //
            //textBoxAddressVerificationCode
            //
            this.textBoxAddressVerificationCode.Location = new System.Drawing.Point(175, 220);
            this.textBoxAddressVerificationCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressVerificationCode.Name = "textBoxAddressVerificationCode";
            this.textBoxAddressVerificationCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressVerificationCode.TabIndex = 21;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 243);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 22;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(175, 243);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 23;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 266);
            
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
            this.buttonSave.Location = new System.Drawing.Point(233, 266);
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
            this.ClientSize = new System.Drawing.Size(437, 294);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialPaymentCardEdit";
            this.Text = "Financial Payment Card Edit";
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelNameOnCard);
            this.Controls.Add(this.textBoxNameOnCard);
            this.Controls.Add(this.labelExpiryYear);
            this.Controls.Add(this.maskedTextBoxExpiryYear);
            this.Controls.Add(this.labelExpiryMonth);
            this.Controls.Add(this.maskedTextBoxExpiryMonth);
            this.Controls.Add(this.labelFinancialCardTypeRefCombo);
            this.Controls.Add(this.financialCardTypeRefCombo);
            this.Controls.Add(this.labelCardVerificationValue);
            this.Controls.Add(this.maskedTextBoxCardVerificationValue);
            this.Controls.Add(this.labelIssuedMonth);
            this.Controls.Add(this.maskedTextBoxIssuedMonth);
            this.Controls.Add(this.labelIssuedYear);
            this.Controls.Add(this.maskedTextBoxIssuedYear);
            this.Controls.Add(this.labelAddressVerificationCode);
            this.Controls.Add(this.textBoxAddressVerificationCode);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
