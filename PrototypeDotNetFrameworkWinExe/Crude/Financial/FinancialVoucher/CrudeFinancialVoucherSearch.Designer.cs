namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialVoucher;
        
        private System.Windows.Forms.TextBox textBoxVoucherDescription;
        
        private System.Windows.Forms.Label labelVoucherDescription;
        
        private FinancialVoucherTypeRefCombo financialVoucherTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialVoucherTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValueAmount;
        
        private System.Windows.Forms.Label labelValueAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVoucherNumber;
        
        private System.Windows.Forms.Label labelVoucherNumber;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;
        
        private System.Windows.Forms.Label labelValidFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;
        
        private System.Windows.Forms.Label labelValidUntilDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialVoucher = new System.Windows.Forms.DataGridView();
            this.labelVoucherDescription = new System.Windows.Forms.Label();
            this.textBoxVoucherDescription = new System.Windows.Forms.TextBox();
            this.labelFinancialVoucherTypeRefCombo = new System.Windows.Forms.Label();
            this.financialVoucherTypeRefCombo = new FinancialVoucherTypeRefCombo();
            this.labelValueAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxValueAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelVoucherNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxVoucherNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucher)).BeginInit();
            this.SuspendLayout();
            //
            // labelVoucherDescription
            //
            this.labelVoucherDescription.AutoSize = true;
            this.labelVoucherDescription.Location = new System.Drawing.Point(11, 13);
            this.labelVoucherDescription.Name = "labelVoucherDescription";
            this.labelVoucherDescription.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherDescription.TabIndex = 2;
            this.labelVoucherDescription.Text = "Voucher Description:";
            //
            //textBoxVoucherDescription
            //
            this.textBoxVoucherDescription.Location = new System.Drawing.Point(154, 13);
            this.textBoxVoucherDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVoucherDescription.Name = "textBoxVoucherDescription";
            this.textBoxVoucherDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxVoucherDescription.TabIndex = 3;
            //
            // labelFinancialVoucherTypeRefCombo
            //
            this.labelFinancialVoucherTypeRefCombo.AutoSize = true;
            this.labelFinancialVoucherTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialVoucherTypeRefCombo.Name = "labelFinancialVoucherTypeRefCombo";
            this.labelFinancialVoucherTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherTypeRefCombo.TabIndex = 4;
            this.labelFinancialVoucherTypeRefCombo.Text = "Financial Voucher Type:";
            //
            //financialVoucherTypeRefCombo
            //
            this.financialVoucherTypeRefCombo.Location = new System.Drawing.Point(154, 36);
            this.financialVoucherTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialVoucherTypeRefCombo.Name = "financialVoucherTypeRefCombo";
            this.financialVoucherTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialVoucherTypeRefCombo.TabIndex = 5;
            //
            // labelValueAmount
            //
            this.labelValueAmount.AutoSize = true;
            this.labelValueAmount.Location = new System.Drawing.Point(11, 59);
            this.labelValueAmount.Name = "labelValueAmount";
            this.labelValueAmount.Size = new System.Drawing.Size(71, 13);
            this.labelValueAmount.TabIndex = 6;
            this.labelValueAmount.Text = "Value Amount:";
            //
            //maskedTextBoxValueAmount
            //
            this.maskedTextBoxValueAmount.Location = new System.Drawing.Point(154, 59);
            this.maskedTextBoxValueAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValueAmount.Name = "maskedTextBoxValueAmount";
            this.maskedTextBoxValueAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxValueAmount.TabIndex = 7;
            //
            // labelVoucherNumber
            //
            this.labelVoucherNumber.AutoSize = true;
            this.labelVoucherNumber.Location = new System.Drawing.Point(11, 82);
            this.labelVoucherNumber.Name = "labelVoucherNumber";
            this.labelVoucherNumber.Size = new System.Drawing.Size(71, 13);
            this.labelVoucherNumber.TabIndex = 8;
            this.labelVoucherNumber.Text = "Voucher Number:";
            //
            //maskedTextBoxVoucherNumber
            //
            this.maskedTextBoxVoucherNumber.Location = new System.Drawing.Point(154, 82);
            this.maskedTextBoxVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxVoucherNumber.Name = "maskedTextBoxVoucherNumber";
            this.maskedTextBoxVoucherNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxVoucherNumber.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 12;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(154, 128);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 13;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 14;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(154, 151);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 15;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeFinancialVoucher
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialVoucher.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialVoucher.Name = "dataGridViewCrudeFinancialVoucher";
            this.dataGridViewCrudeFinancialVoucher.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFinancialVoucher.TabIndex = 0;
            this.dataGridViewCrudeFinancialVoucher.ReadOnly = true;
            this.dataGridViewCrudeFinancialVoucher.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialVoucher_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialVoucherSearch
            // 
            this.buttonCrudeFinancialVoucherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherSearch.Location = new System.Drawing.Point(212, 287);
            this.buttonCrudeFinancialVoucherSearch.Name = "buttonCrudeFinancialVoucherSearch";
            this.buttonCrudeFinancialVoucherSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherSearch.TabIndex = 2;
            this.buttonCrudeFinancialVoucherSearch.Text = "&Search";
            this.buttonCrudeFinancialVoucherSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherSearch.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherSearch_Click);
            // 
            // buttonCrudeFinancialVoucherAdd
            // 
            this.buttonCrudeFinancialVoucherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherAdd.Location = new System.Drawing.Point(112, 287);
            this.buttonCrudeFinancialVoucherAdd.Name = "buttonCrudeFinancialVoucherAdd";
            this.buttonCrudeFinancialVoucherAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherAdd.TabIndex = 3;
            this.buttonCrudeFinancialVoucherAdd.Text = "&Add";
            this.buttonCrudeFinancialVoucherAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherAdd.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherAdd_Click);
            // 
            // buttonCrudeFinancialVoucherEdit
            // 
            this.buttonCrudeFinancialVoucherEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherEdit.Location = new System.Drawing.Point(12, 287);
            this.buttonCrudeFinancialVoucherEdit.Name = "buttonCrudeFinancialVoucherEdit";
            this.buttonCrudeFinancialVoucherEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherEdit.TabIndex = 4;
            this.buttonCrudeFinancialVoucherEdit.Text = "&Edit";
            this.buttonCrudeFinancialVoucherEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherEdit.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 315);
            this.Controls.Add(this.buttonCrudeFinancialVoucherSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialVoucherAdd);
            this.Controls.Add(this.buttonCrudeFinancialVoucherEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialVoucher);
            this.Name = "CrudeFinancialVoucherSearch";
            this.Text = "Financial Voucher Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucher)).EndInit();
            this.Controls.Add(this.labelVoucherDescription);
            this.Controls.Add(this.textBoxVoucherDescription);
            this.Controls.Add(this.labelFinancialVoucherTypeRefCombo);
            this.Controls.Add(this.financialVoucherTypeRefCombo);
            this.Controls.Add(this.labelValueAmount);
            this.Controls.Add(this.maskedTextBoxValueAmount);
            this.Controls.Add(this.labelVoucherNumber);
            this.Controls.Add(this.maskedTextBoxVoucherNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
