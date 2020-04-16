namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCurrencyTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyType;
        
        private System.Windows.Forms.Label labelFinancialCurrencyType;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeName;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeName;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimalCount;
        
        private System.Windows.Forms.Label labelDecimalCount;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeCode;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFinancialCurrencyType = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyType = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelDecimalCount = new System.Windows.Forms.Label();
            this.maskedTextBoxDecimalCount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCurrencyType
            //
            this.labelFinancialCurrencyType.AutoSize = true;
            this.labelFinancialCurrencyType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCurrencyType.Name = "labelFinancialCurrencyType";
            this.labelFinancialCurrencyType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyType.TabIndex = 2;
            this.labelFinancialCurrencyType.Text = "Financial Currency Type:";
            //
            //textBoxFinancialCurrencyType
            //
            this.textBoxFinancialCurrencyType.Location = new System.Drawing.Point(196, 13);
            this.textBoxFinancialCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyType.Name = "textBoxFinancialCurrencyType";
            this.textBoxFinancialCurrencyType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyType.TabIndex = 3;
            //
            // labelFinancialCurrencyTypeName
            //
            this.labelFinancialCurrencyTypeName.AutoSize = true;
            this.labelFinancialCurrencyTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCurrencyTypeName.Name = "labelFinancialCurrencyTypeName";
            this.labelFinancialCurrencyTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeName.TabIndex = 4;
            this.labelFinancialCurrencyTypeName.Text = "Financial Currency Type Name:";
            //
            //textBoxFinancialCurrencyTypeName
            //
            this.textBoxFinancialCurrencyTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxFinancialCurrencyTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeName.Name = "textBoxFinancialCurrencyTypeName";
            this.textBoxFinancialCurrencyTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelDecimalCount
            //
            this.labelDecimalCount.AutoSize = true;
            this.labelDecimalCount.Location = new System.Drawing.Point(11, 82);
            this.labelDecimalCount.Name = "labelDecimalCount";
            this.labelDecimalCount.Size = new System.Drawing.Size(71, 13);
            this.labelDecimalCount.TabIndex = 8;
            this.labelDecimalCount.Text = "Decimal Count:";
            //
            //maskedTextBoxDecimalCount
            //
            this.maskedTextBoxDecimalCount.Location = new System.Drawing.Point(196, 82);
            this.maskedTextBoxDecimalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDecimalCount.Name = "maskedTextBoxDecimalCount";
            this.maskedTextBoxDecimalCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDecimalCount.TabIndex = 9;
            //
            // labelFinancialCurrencyTypeCode
            //
            this.labelFinancialCurrencyTypeCode.AutoSize = true;
            this.labelFinancialCurrencyTypeCode.Location = new System.Drawing.Point(11, 105);
            this.labelFinancialCurrencyTypeCode.Name = "labelFinancialCurrencyTypeCode";
            this.labelFinancialCurrencyTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeCode.TabIndex = 10;
            this.labelFinancialCurrencyTypeCode.Text = "Financial Currency Type Code:";
            //
            //textBoxFinancialCurrencyTypeCode
            //
            this.textBoxFinancialCurrencyTypeCode.Location = new System.Drawing.Point(196, 105);
            this.textBoxFinancialCurrencyTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeCode.Name = "textBoxFinancialCurrencyTypeCode";
            this.textBoxFinancialCurrencyTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeCode.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 128);
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
            this.ClientSize = new System.Drawing.Size(458, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCurrencyTypeRefEdit";
            this.Text = "Financial Currency Type Ref Edit";
            this.Controls.Add(this.labelFinancialCurrencyType);
            this.Controls.Add(this.textBoxFinancialCurrencyType);
            this.Controls.Add(this.labelFinancialCurrencyTypeName);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelDecimalCount);
            this.Controls.Add(this.maskedTextBoxDecimalCount);
            this.Controls.Add(this.labelFinancialCurrencyTypeCode);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeCode);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
