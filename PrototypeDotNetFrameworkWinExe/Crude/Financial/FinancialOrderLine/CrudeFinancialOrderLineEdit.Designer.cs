namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderLineEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLineNumber;
        
        private System.Windows.Forms.Label labelLineNumber;
        
        private FinancialUnitOfMeasurementRefCombo financialUnitOfMeasurementRefCombo;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantityNumber;
        
        private System.Windows.Forms.Label labelQuantityNumber;
        
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
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelLineNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxLineNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialUnitOfMeasurementRefCombo = new System.Windows.Forms.Label();
            this.financialUnitOfMeasurementRefCombo = new FinancialUnitOfMeasurementRefCombo();
            this.labelQuantityNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantityNumber = new System.Windows.Forms.MaskedTextBox();
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 36);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 4;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(203, 36);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 5;
            //
            // labelLineNumber
            //
            this.labelLineNumber.AutoSize = true;
            this.labelLineNumber.Location = new System.Drawing.Point(11, 59);
            this.labelLineNumber.Name = "labelLineNumber";
            this.labelLineNumber.Size = new System.Drawing.Size(71, 13);
            this.labelLineNumber.TabIndex = 6;
            this.labelLineNumber.Text = "Line Number:";
            //
            //maskedTextBoxLineNumber
            //
            this.maskedTextBoxLineNumber.Location = new System.Drawing.Point(203, 59);
            this.maskedTextBoxLineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLineNumber.Name = "maskedTextBoxLineNumber";
            this.maskedTextBoxLineNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLineNumber.TabIndex = 7;
            //
            // labelFinancialUnitOfMeasurementRefCombo
            //
            this.labelFinancialUnitOfMeasurementRefCombo.AutoSize = true;
            this.labelFinancialUnitOfMeasurementRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialUnitOfMeasurementRefCombo.Name = "labelFinancialUnitOfMeasurementRefCombo";
            this.labelFinancialUnitOfMeasurementRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementRefCombo.TabIndex = 8;
            this.labelFinancialUnitOfMeasurementRefCombo.Text = "Financial Unit Of Measurement:";
            //
            //financialUnitOfMeasurementRefCombo
            //
            this.financialUnitOfMeasurementRefCombo.Location = new System.Drawing.Point(203, 82);
            this.financialUnitOfMeasurementRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialUnitOfMeasurementRefCombo.Name = "financialUnitOfMeasurementRefCombo";
            this.financialUnitOfMeasurementRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialUnitOfMeasurementRefCombo.TabIndex = 9;
            //
            // labelQuantityNumber
            //
            this.labelQuantityNumber.AutoSize = true;
            this.labelQuantityNumber.Location = new System.Drawing.Point(11, 105);
            this.labelQuantityNumber.Name = "labelQuantityNumber";
            this.labelQuantityNumber.Size = new System.Drawing.Size(71, 13);
            this.labelQuantityNumber.TabIndex = 10;
            this.labelQuantityNumber.Text = "Quantity Number:";
            //
            //maskedTextBoxQuantityNumber
            //
            this.maskedTextBoxQuantityNumber.Location = new System.Drawing.Point(203, 105);
            this.maskedTextBoxQuantityNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxQuantityNumber.Name = "maskedTextBoxQuantityNumber";
            this.maskedTextBoxQuantityNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxQuantityNumber.TabIndex = 11;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 128);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 12;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(203, 128);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(261, 151);
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
            this.ClientSize = new System.Drawing.Size(465, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialOrderLineEdit";
            this.Text = "Financial Order Line Edit";
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelLineNumber);
            this.Controls.Add(this.maskedTextBoxLineNumber);
            this.Controls.Add(this.labelFinancialUnitOfMeasurementRefCombo);
            this.Controls.Add(this.financialUnitOfMeasurementRefCombo);
            this.Controls.Add(this.labelQuantityNumber);
            this.Controls.Add(this.maskedTextBoxQuantityNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
