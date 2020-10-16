namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeFinancialCurrencyEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxFinancialCurrencyType;

        private System.Windows.Forms.Label labelFinancialCurrencyType;

        private System.Windows.Forms.TextBox textBoxFinancialCurrencyAgainstFinancialCurrencyType;

        private System.Windows.Forms.Label labelFinancialCurrencyAgainstFinancialCurrencyType;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromDateTime;

        private System.Windows.Forms.Label labelValidFromDateTime;

        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilDateTime;

        private System.Windows.Forms.Label labelValidUntilDateTime;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;

        private System.Windows.Forms.Label labelAmount;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxEqualsAmount;

        private System.Windows.Forms.Label labelEqualsAmount;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimalCount;

        private System.Windows.Forms.Label labelDecimalCount;

        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeCode;

        private System.Windows.Forms.Label labelFinancialCurrencyTypeCode;

        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeName;

        private System.Windows.Forms.Label labelFinancialCurrencyTypeName;

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
            this.labelFinancialCurrencyAgainstFinancialCurrencyType = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelValidFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelEqualsAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxEqualsAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDecimalCount = new System.Windows.Forms.Label();
            this.maskedTextBoxDecimalCount = new System.Windows.Forms.MaskedTextBox();
            this.labelFinancialCurrencyTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeCode = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeName = new System.Windows.Forms.TextBox();
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
            this.textBoxFinancialCurrencyType.Location = new System.Drawing.Point(350, 13);
            this.textBoxFinancialCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyType.Name = "textBoxFinancialCurrencyType";
            this.textBoxFinancialCurrencyType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyType.TabIndex = 3;
            //
            // labelFinancialCurrencyAgainstFinancialCurrencyType
            //
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.AutoSize = true;
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.Name = "labelFinancialCurrencyAgainstFinancialCurrencyType";
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.TabIndex = 4;
            this.labelFinancialCurrencyAgainstFinancialCurrencyType.Text = "Financial Currency Against Financial Currency Type:";
            //
            //textBoxFinancialCurrencyAgainstFinancialCurrencyType
            //
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType.Location = new System.Drawing.Point(350, 36);
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType.Name = "textBoxFinancialCurrencyAgainstFinancialCurrencyType";
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyAgainstFinancialCurrencyType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(350, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelValidFromDateTime
            //
            this.labelValidFromDateTime.AutoSize = true;
            this.labelValidFromDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelValidFromDateTime.Name = "labelValidFromDateTime";
            this.labelValidFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromDateTime.TabIndex = 8;
            this.labelValidFromDateTime.Text = "Valid From Date Time:";
            //
            //dateTimePickerValidFromDateTime
            //
            this.dateTimePickerValidFromDateTime.Location = new System.Drawing.Point(350, 82);
            this.dateTimePickerValidFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromDateTime.Name = "dateTimePickerValidFromDateTime";
            this.dateTimePickerValidFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromDateTime.TabIndex = 9;
            this.dateTimePickerValidFromDateTime.Checked = false;
            this.dateTimePickerValidFromDateTime.ShowCheckBox = true;
            //
            // labelValidUntilDateTime
            //
            this.labelValidUntilDateTime.AutoSize = true;
            this.labelValidUntilDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelValidUntilDateTime.Name = "labelValidUntilDateTime";
            this.labelValidUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilDateTime.TabIndex = 10;
            this.labelValidUntilDateTime.Text = "Valid Until Date Time:";
            //
            //dateTimePickerValidUntilDateTime
            //
            this.dateTimePickerValidUntilDateTime.Location = new System.Drawing.Point(350, 105);
            this.dateTimePickerValidUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilDateTime.Name = "dateTimePickerValidUntilDateTime";
            this.dateTimePickerValidUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilDateTime.TabIndex = 11;
            this.dateTimePickerValidUntilDateTime.Checked = false;
            this.dateTimePickerValidUntilDateTime.ShowCheckBox = true;
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
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(350, 128);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 13;
            //
            // labelEqualsAmount
            //
            this.labelEqualsAmount.AutoSize = true;
            this.labelEqualsAmount.Location = new System.Drawing.Point(11, 151);
            this.labelEqualsAmount.Name = "labelEqualsAmount";
            this.labelEqualsAmount.Size = new System.Drawing.Size(71, 13);
            this.labelEqualsAmount.TabIndex = 14;
            this.labelEqualsAmount.Text = "Equals Amount:";
            //
            //maskedTextBoxEqualsAmount
            //
            this.maskedTextBoxEqualsAmount.Location = new System.Drawing.Point(350, 151);
            this.maskedTextBoxEqualsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxEqualsAmount.Name = "maskedTextBoxEqualsAmount";
            this.maskedTextBoxEqualsAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxEqualsAmount.TabIndex = 15;
            //
            // labelDecimalCount
            //
            this.labelDecimalCount.AutoSize = true;
            this.labelDecimalCount.Location = new System.Drawing.Point(11, 174);
            this.labelDecimalCount.Name = "labelDecimalCount";
            this.labelDecimalCount.Size = new System.Drawing.Size(71, 13);
            this.labelDecimalCount.TabIndex = 16;
            this.labelDecimalCount.Text = "Decimal Count:";
            //
            //maskedTextBoxDecimalCount
            //
            this.maskedTextBoxDecimalCount.Location = new System.Drawing.Point(350, 174);
            this.maskedTextBoxDecimalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDecimalCount.Name = "maskedTextBoxDecimalCount";
            this.maskedTextBoxDecimalCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDecimalCount.TabIndex = 17;
            //
            // labelFinancialCurrencyTypeCode
            //
            this.labelFinancialCurrencyTypeCode.AutoSize = true;
            this.labelFinancialCurrencyTypeCode.Location = new System.Drawing.Point(11, 197);
            this.labelFinancialCurrencyTypeCode.Name = "labelFinancialCurrencyTypeCode";
            this.labelFinancialCurrencyTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeCode.TabIndex = 18;
            this.labelFinancialCurrencyTypeCode.Text = "Financial Currency Type Code:";
            //
            //textBoxFinancialCurrencyTypeCode
            //
            this.textBoxFinancialCurrencyTypeCode.Location = new System.Drawing.Point(350, 197);
            this.textBoxFinancialCurrencyTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeCode.Name = "textBoxFinancialCurrencyTypeCode";
            this.textBoxFinancialCurrencyTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeCode.TabIndex = 19;
            //
            // labelFinancialCurrencyTypeName
            //
            this.labelFinancialCurrencyTypeName.AutoSize = true;
            this.labelFinancialCurrencyTypeName.Location = new System.Drawing.Point(11, 220);
            this.labelFinancialCurrencyTypeName.Name = "labelFinancialCurrencyTypeName";
            this.labelFinancialCurrencyTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeName.TabIndex = 20;
            this.labelFinancialCurrencyTypeName.Text = "Financial Currency Type Name:";
            //
            //textBoxFinancialCurrencyTypeName
            //
            this.textBoxFinancialCurrencyTypeName.Location = new System.Drawing.Point(350, 220);
            this.textBoxFinancialCurrencyTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeName.Name = "textBoxFinancialCurrencyTypeName";
            this.textBoxFinancialCurrencyTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeName.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(508, 243);

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
            this.buttonSave.Location = new System.Drawing.Point(408, 243);
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
            this.ClientSize = new System.Drawing.Size(612, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCurrencyEdit";
            this.Text = "Financial Currency Edit";
            this.Controls.Add(this.labelFinancialCurrencyType);
            this.Controls.Add(this.textBoxFinancialCurrencyType);
            this.Controls.Add(this.labelFinancialCurrencyAgainstFinancialCurrencyType);
            this.Controls.Add(this.textBoxFinancialCurrencyAgainstFinancialCurrencyType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelValidFromDateTime);
            this.Controls.Add(this.dateTimePickerValidFromDateTime);
            this.Controls.Add(this.labelValidUntilDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilDateTime);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelEqualsAmount);
            this.Controls.Add(this.maskedTextBoxEqualsAmount);
            this.Controls.Add(this.labelDecimalCount);
            this.Controls.Add(this.maskedTextBoxDecimalCount);
            this.Controls.Add(this.labelFinancialCurrencyTypeCode);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeCode);
            this.Controls.Add(this.labelFinancialCurrencyTypeName);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeName);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
