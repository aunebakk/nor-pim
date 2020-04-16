namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialBankAccountNumberTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialBankAccountNumberType;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberType;
        
        private System.Windows.Forms.TextBox textBoxFinancialBankAccountNumberTypeName;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberTypeName;
        
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
            this.labelFinancialBankAccountNumberType = new System.Windows.Forms.Label();
            this.textBoxFinancialBankAccountNumberType = new System.Windows.Forms.TextBox();
            this.labelFinancialBankAccountNumberTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialBankAccountNumberTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialBankAccountNumberType
            //
            this.labelFinancialBankAccountNumberType.AutoSize = true;
            this.labelFinancialBankAccountNumberType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBankAccountNumberType.Name = "labelFinancialBankAccountNumberType";
            this.labelFinancialBankAccountNumberType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberType.TabIndex = 2;
            this.labelFinancialBankAccountNumberType.Text = "Financial Bank Account Number Type:";
            //
            //textBoxFinancialBankAccountNumberType
            //
            this.textBoxFinancialBankAccountNumberType.Location = new System.Drawing.Point(273, 13);
            this.textBoxFinancialBankAccountNumberType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBankAccountNumberType.Name = "textBoxFinancialBankAccountNumberType";
            this.textBoxFinancialBankAccountNumberType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBankAccountNumberType.TabIndex = 3;
            //
            // labelFinancialBankAccountNumberTypeName
            //
            this.labelFinancialBankAccountNumberTypeName.AutoSize = true;
            this.labelFinancialBankAccountNumberTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialBankAccountNumberTypeName.Name = "labelFinancialBankAccountNumberTypeName";
            this.labelFinancialBankAccountNumberTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberTypeName.TabIndex = 4;
            this.labelFinancialBankAccountNumberTypeName.Text = "Financial Bank Account Number Type Name:";
            //
            //textBoxFinancialBankAccountNumberTypeName
            //
            this.textBoxFinancialBankAccountNumberTypeName.Location = new System.Drawing.Point(273, 36);
            this.textBoxFinancialBankAccountNumberTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBankAccountNumberTypeName.Name = "textBoxFinancialBankAccountNumberTypeName";
            this.textBoxFinancialBankAccountNumberTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBankAccountNumberTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(273, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(431, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(331, 82);
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
            this.ClientSize = new System.Drawing.Size(535, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialBankAccountNumberTypeRefEdit";
            this.Text = "Financial Bank Account Number Type Ref Edit";
            this.Controls.Add(this.labelFinancialBankAccountNumberType);
            this.Controls.Add(this.textBoxFinancialBankAccountNumberType);
            this.Controls.Add(this.labelFinancialBankAccountNumberTypeName);
            this.Controls.Add(this.textBoxFinancialBankAccountNumberTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
