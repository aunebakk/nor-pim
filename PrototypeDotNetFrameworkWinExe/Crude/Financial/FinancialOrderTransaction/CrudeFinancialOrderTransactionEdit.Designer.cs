namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTransactionNumber;
        
        private System.Windows.Forms.Label labelTransactionNumber;
        
        private FinancialOrderTransactionTypeRefCombo financialOrderTransactionTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialOrderTransactionTypeRefCombo;
        
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelTransactionNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxTransactionNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialOrderTransactionTypeRefCombo = new System.Windows.Forms.Label();
            this.financialOrderTransactionTypeRefCombo = new FinancialOrderTransactionTypeRefCombo();
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 36);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(224, 36);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 5;
            //
            // labelTransactionNumber
            //
            this.labelTransactionNumber.AutoSize = true;
            this.labelTransactionNumber.Location = new System.Drawing.Point(11, 59);
            this.labelTransactionNumber.Name = "labelTransactionNumber";
            this.labelTransactionNumber.Size = new System.Drawing.Size(71, 13);
            this.labelTransactionNumber.TabIndex = 6;
            this.labelTransactionNumber.Text = "Transaction Number:";
            //
            //maskedTextBoxTransactionNumber
            //
            this.maskedTextBoxTransactionNumber.Location = new System.Drawing.Point(224, 59);
            this.maskedTextBoxTransactionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTransactionNumber.Name = "maskedTextBoxTransactionNumber";
            this.maskedTextBoxTransactionNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxTransactionNumber.TabIndex = 7;
            //
            // labelFinancialOrderTransactionTypeRefCombo
            //
            this.labelFinancialOrderTransactionTypeRefCombo.AutoSize = true;
            this.labelFinancialOrderTransactionTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialOrderTransactionTypeRefCombo.Name = "labelFinancialOrderTransactionTypeRefCombo";
            this.labelFinancialOrderTransactionTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderTransactionTypeRefCombo.TabIndex = 8;
            this.labelFinancialOrderTransactionTypeRefCombo.Text = "Financial Order Transaction Type:";
            //
            //financialOrderTransactionTypeRefCombo
            //
            this.financialOrderTransactionTypeRefCombo.Location = new System.Drawing.Point(224, 82);
            this.financialOrderTransactionTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialOrderTransactionTypeRefCombo.Name = "financialOrderTransactionTypeRefCombo";
            this.financialOrderTransactionTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialOrderTransactionTypeRefCombo.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(282, 105);
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
            this.ClientSize = new System.Drawing.Size(486, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialOrderTransactionEdit";
            this.Text = "Financial Order Transaction Edit";
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelTransactionNumber);
            this.Controls.Add(this.maskedTextBoxTransactionNumber);
            this.Controls.Add(this.labelFinancialOrderTransactionTypeRefCombo);
            this.Controls.Add(this.financialOrderTransactionTypeRefCombo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
