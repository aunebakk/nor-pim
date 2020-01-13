namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentBankSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentBankSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentBankAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentBankEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentBank;
        
        private System.Windows.Forms.TextBox textBoxBankName;
        
        private System.Windows.Forms.Label labelBankName;
        
        private System.Windows.Forms.TextBox textBoxBankAccount;
        
        private System.Windows.Forms.Label labelBankAccount;
        
        private System.Windows.Forms.TextBox textBoxBankNumber;
        
        private System.Windows.Forms.Label labelBankNumber;
        
        private FinancialBankAccountNumberTypeRefCombo financialBankAccountNumberTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberTypeRefCombo;
        
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
            this.buttonCrudeFinancialPaymentBankAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentBankEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentBankSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentBank = new System.Windows.Forms.DataGridView();
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.labelBankAccount = new System.Windows.Forms.Label();
            this.textBoxBankAccount = new System.Windows.Forms.TextBox();
            this.labelBankNumber = new System.Windows.Forms.Label();
            this.textBoxBankNumber = new System.Windows.Forms.TextBox();
            this.labelFinancialBankAccountNumberTypeRefCombo = new System.Windows.Forms.Label();
            this.financialBankAccountNumberTypeRefCombo = new FinancialBankAccountNumberTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentBank)).BeginInit();
            this.SuspendLayout();
            //
            // labelBankName
            //
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(11, 13);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(71, 13);
            this.labelBankName.TabIndex = 2;
            this.labelBankName.Text = "Bank Name:";
            //
            //textBoxBankName
            //
            this.textBoxBankName.Location = new System.Drawing.Point(238, 13);
            this.textBoxBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankName.TabIndex = 3;
            //
            // labelBankAccount
            //
            this.labelBankAccount.AutoSize = true;
            this.labelBankAccount.Location = new System.Drawing.Point(11, 36);
            this.labelBankAccount.Name = "labelBankAccount";
            this.labelBankAccount.Size = new System.Drawing.Size(71, 13);
            this.labelBankAccount.TabIndex = 4;
            this.labelBankAccount.Text = "Bank Account:";
            //
            //textBoxBankAccount
            //
            this.textBoxBankAccount.Location = new System.Drawing.Point(238, 36);
            this.textBoxBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankAccount.Name = "textBoxBankAccount";
            this.textBoxBankAccount.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankAccount.TabIndex = 5;
            //
            // labelBankNumber
            //
            this.labelBankNumber.AutoSize = true;
            this.labelBankNumber.Location = new System.Drawing.Point(11, 59);
            this.labelBankNumber.Name = "labelBankNumber";
            this.labelBankNumber.Size = new System.Drawing.Size(71, 13);
            this.labelBankNumber.TabIndex = 6;
            this.labelBankNumber.Text = "Bank Number:";
            //
            //textBoxBankNumber
            //
            this.textBoxBankNumber.Location = new System.Drawing.Point(238, 59);
            this.textBoxBankNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBankNumber.Name = "textBoxBankNumber";
            this.textBoxBankNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxBankNumber.TabIndex = 7;
            //
            // labelFinancialBankAccountNumberTypeRefCombo
            //
            this.labelFinancialBankAccountNumberTypeRefCombo.AutoSize = true;
            this.labelFinancialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialBankAccountNumberTypeRefCombo.Name = "labelFinancialBankAccountNumberTypeRefCombo";
            this.labelFinancialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberTypeRefCombo.TabIndex = 8;
            this.labelFinancialBankAccountNumberTypeRefCombo.Text = "Financial Bank Account Number Type:";
            //
            //financialBankAccountNumberTypeRefCombo
            //
            this.financialBankAccountNumberTypeRefCombo.Location = new System.Drawing.Point(238, 82);
            this.financialBankAccountNumberTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialBankAccountNumberTypeRefCombo.Name = "financialBankAccountNumberTypeRefCombo";
            this.financialBankAccountNumberTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialBankAccountNumberTypeRefCombo.TabIndex = 9;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 105);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(238, 105);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // dataGridViewCrudeFinancialPaymentBank
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentBank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentBank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentBank.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFinancialPaymentBank.Name = "dataGridViewCrudeFinancialPaymentBank";
            this.dataGridViewCrudeFinancialPaymentBank.Size = new System.Drawing.Size(476, 96);
            this.dataGridViewCrudeFinancialPaymentBank.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentBank.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentBank.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentBank_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentBankSearch
            // 
            this.buttonCrudeFinancialPaymentBankSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentBankSearch.Location = new System.Drawing.Point(296, 264);
            this.buttonCrudeFinancialPaymentBankSearch.Name = "buttonCrudeFinancialPaymentBankSearch";
            this.buttonCrudeFinancialPaymentBankSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentBankSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentBankSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentBankSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentBankSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentBankSearch_Click);
            // 
            // buttonCrudeFinancialPaymentBankAdd
            // 
            this.buttonCrudeFinancialPaymentBankAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentBankAdd.Location = new System.Drawing.Point(196, 264);
            this.buttonCrudeFinancialPaymentBankAdd.Name = "buttonCrudeFinancialPaymentBankAdd";
            this.buttonCrudeFinancialPaymentBankAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentBankAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentBankAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentBankAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentBankAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentBankAdd_Click);
            // 
            // buttonCrudeFinancialPaymentBankEdit
            // 
            this.buttonCrudeFinancialPaymentBankEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentBankEdit.Location = new System.Drawing.Point(96, 264);
            this.buttonCrudeFinancialPaymentBankEdit.Name = "buttonCrudeFinancialPaymentBankEdit";
            this.buttonCrudeFinancialPaymentBankEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentBankEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentBankEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentBankEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentBankEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentBankEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.buttonCrudeFinancialPaymentBankSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentBankAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentBankEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentBank);
            this.Name = "CrudeFinancialPaymentBankSearch";
            this.Text = "Financial Payment Bank Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentBank)).EndInit();
            this.Controls.Add(this.labelBankName);
            this.Controls.Add(this.textBoxBankName);
            this.Controls.Add(this.labelBankAccount);
            this.Controls.Add(this.textBoxBankAccount);
            this.Controls.Add(this.labelBankNumber);
            this.Controls.Add(this.textBoxBankNumber);
            this.Controls.Add(this.labelFinancialBankAccountNumberTypeRefCombo);
            this.Controls.Add(this.financialBankAccountNumberTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
