namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCardSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCardSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCardAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCardEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentCard;
        
        private System.Windows.Forms.TextBox textBoxCardNumber;
        
        private System.Windows.Forms.Label labelCardNumber;
        
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        
        private System.Windows.Forms.Label labelNameOnCard;
        
        private FinancialCardTypeRefCombo financialCardTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialCardTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAddressVerificationCode;
        
        private System.Windows.Forms.Label labelAddressVerificationCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryYear;
        
        private System.Windows.Forms.Label labelExpiryYear;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpiryMonth;
        
        private System.Windows.Forms.Label labelExpiryMonth;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCardVerificationValue;
        
        private System.Windows.Forms.Label labelCardVerificationValue;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedMonth;
        
        private System.Windows.Forms.Label labelIssuedMonth;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIssuedYear;
        
        private System.Windows.Forms.Label labelIssuedYear;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCardAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCardEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCardSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentCard = new System.Windows.Forms.DataGridView();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.labelFinancialCardTypeRefCombo = new System.Windows.Forms.Label();
            this.financialCardTypeRefCombo = new FinancialCardTypeRefCombo();
            this.labelAddressVerificationCode = new System.Windows.Forms.Label();
            this.textBoxAddressVerificationCode = new System.Windows.Forms.TextBox();
            this.labelExpiryYear = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryYear = new System.Windows.Forms.MaskedTextBox();
            this.labelExpiryMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxExpiryMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelCardVerificationValue = new System.Windows.Forms.Label();
            this.maskedTextBoxCardVerificationValue = new System.Windows.Forms.MaskedTextBox();
            this.labelIssuedMonth = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedMonth = new System.Windows.Forms.MaskedTextBox();
            this.labelIssuedYear = new System.Windows.Forms.Label();
            this.maskedTextBoxIssuedYear = new System.Windows.Forms.MaskedTextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCard)).BeginInit();
            this.SuspendLayout();
            //
            // labelCardNumber
            //
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(11, 13);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(71, 13);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number:";
            //
            //textBoxCardNumber
            //
            this.textBoxCardNumber.Location = new System.Drawing.Point(175, 13);
            this.textBoxCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxCardNumber.TabIndex = 3;
            //
            // labelNameOnCard
            //
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(11, 36);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(71, 13);
            this.labelNameOnCard.TabIndex = 4;
            this.labelNameOnCard.Text = "Name On Card:";
            //
            //textBoxNameOnCard
            //
            this.textBoxNameOnCard.Location = new System.Drawing.Point(175, 36);
            this.textBoxNameOnCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(250, 20);
            this.textBoxNameOnCard.TabIndex = 5;
            //
            // labelFinancialCardTypeRefCombo
            //
            this.labelFinancialCardTypeRefCombo.AutoSize = true;
            this.labelFinancialCardTypeRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialCardTypeRefCombo.Name = "labelFinancialCardTypeRefCombo";
            this.labelFinancialCardTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardTypeRefCombo.TabIndex = 6;
            this.labelFinancialCardTypeRefCombo.Text = "Financial Card Type:";
            //
            //financialCardTypeRefCombo
            //
            this.financialCardTypeRefCombo.Location = new System.Drawing.Point(175, 59);
            this.financialCardTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCardTypeRefCombo.Name = "financialCardTypeRefCombo";
            this.financialCardTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialCardTypeRefCombo.TabIndex = 7;
            //
            // labelAddressVerificationCode
            //
            this.labelAddressVerificationCode.AutoSize = true;
            this.labelAddressVerificationCode.Location = new System.Drawing.Point(11, 82);
            this.labelAddressVerificationCode.Name = "labelAddressVerificationCode";
            this.labelAddressVerificationCode.Size = new System.Drawing.Size(71, 13);
            this.labelAddressVerificationCode.TabIndex = 8;
            this.labelAddressVerificationCode.Text = "Address Verification Code:";
            //
            //textBoxAddressVerificationCode
            //
            this.textBoxAddressVerificationCode.Location = new System.Drawing.Point(175, 82);
            this.textBoxAddressVerificationCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressVerificationCode.Name = "textBoxAddressVerificationCode";
            this.textBoxAddressVerificationCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressVerificationCode.TabIndex = 9;
            //
            // labelExpiryYear
            //
            this.labelExpiryYear.AutoSize = true;
            this.labelExpiryYear.Location = new System.Drawing.Point(11, 105);
            this.labelExpiryYear.Name = "labelExpiryYear";
            this.labelExpiryYear.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryYear.TabIndex = 10;
            this.labelExpiryYear.Text = "Expiry Year:";
            //
            //maskedTextBoxExpiryYear
            //
            this.maskedTextBoxExpiryYear.Location = new System.Drawing.Point(175, 105);
            this.maskedTextBoxExpiryYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxExpiryYear.Name = "maskedTextBoxExpiryYear";
            this.maskedTextBoxExpiryYear.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxExpiryYear.TabIndex = 11;
            //
            // labelExpiryMonth
            //
            this.labelExpiryMonth.AutoSize = true;
            this.labelExpiryMonth.Location = new System.Drawing.Point(11, 128);
            this.labelExpiryMonth.Name = "labelExpiryMonth";
            this.labelExpiryMonth.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryMonth.TabIndex = 12;
            this.labelExpiryMonth.Text = "Expiry Month:";
            //
            //maskedTextBoxExpiryMonth
            //
            this.maskedTextBoxExpiryMonth.Location = new System.Drawing.Point(175, 128);
            this.maskedTextBoxExpiryMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxExpiryMonth.Name = "maskedTextBoxExpiryMonth";
            this.maskedTextBoxExpiryMonth.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxExpiryMonth.TabIndex = 13;
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
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 220);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 20;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(175, 220);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 21;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 243);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 22;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 243);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 23;
            // 
            // dataGridViewCrudeFinancialPaymentCard
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentCard.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewCrudeFinancialPaymentCard.Name = "dataGridViewCrudeFinancialPaymentCard";
            this.dataGridViewCrudeFinancialPaymentCard.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeFinancialPaymentCard.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentCard.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentCard.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentCard_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 379);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentCardSearch
            // 
            this.buttonCrudeFinancialPaymentCardSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCardSearch.Location = new System.Drawing.Point(233, 379);
            this.buttonCrudeFinancialPaymentCardSearch.Name = "buttonCrudeFinancialPaymentCardSearch";
            this.buttonCrudeFinancialPaymentCardSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCardSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentCardSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentCardSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCardSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCardSearch_Click);
            // 
            // buttonCrudeFinancialPaymentCardAdd
            // 
            this.buttonCrudeFinancialPaymentCardAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCardAdd.Location = new System.Drawing.Point(133, 379);
            this.buttonCrudeFinancialPaymentCardAdd.Name = "buttonCrudeFinancialPaymentCardAdd";
            this.buttonCrudeFinancialPaymentCardAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCardAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentCardAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentCardAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCardAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCardAdd_Click);
            // 
            // buttonCrudeFinancialPaymentCardEdit
            // 
            this.buttonCrudeFinancialPaymentCardEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCardEdit.Location = new System.Drawing.Point(33, 379);
            this.buttonCrudeFinancialPaymentCardEdit.Name = "buttonCrudeFinancialPaymentCardEdit";
            this.buttonCrudeFinancialPaymentCardEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCardEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentCardEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentCardEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCardEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCardEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 407);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCardSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCardAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCardEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentCard);
            this.Name = "CrudeFinancialPaymentCardSearch";
            this.Text = "Financial Payment Card Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCard)).EndInit();
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelNameOnCard);
            this.Controls.Add(this.textBoxNameOnCard);
            this.Controls.Add(this.labelFinancialCardTypeRefCombo);
            this.Controls.Add(this.financialCardTypeRefCombo);
            this.Controls.Add(this.labelAddressVerificationCode);
            this.Controls.Add(this.textBoxAddressVerificationCode);
            this.Controls.Add(this.labelExpiryYear);
            this.Controls.Add(this.maskedTextBoxExpiryYear);
            this.Controls.Add(this.labelExpiryMonth);
            this.Controls.Add(this.maskedTextBoxExpiryMonth);
            this.Controls.Add(this.labelCardVerificationValue);
            this.Controls.Add(this.maskedTextBoxCardVerificationValue);
            this.Controls.Add(this.labelIssuedMonth);
            this.Controls.Add(this.maskedTextBoxIssuedMonth);
            this.Controls.Add(this.labelIssuedYear);
            this.Controls.Add(this.maskedTextBoxIssuedYear);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
