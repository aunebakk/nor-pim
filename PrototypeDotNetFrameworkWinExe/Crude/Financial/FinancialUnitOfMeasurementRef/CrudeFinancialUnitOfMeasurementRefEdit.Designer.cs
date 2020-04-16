namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurement;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurement;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortSequenceNumber;
        
        private System.Windows.Forms.Label labelSortSequenceNumber;
        
        private System.Windows.Forms.CheckBox checkBoxChangeFlag;
        
        private System.Windows.Forms.Label labelChangeFlag;
        
        private System.Windows.Forms.TextBox textBoxStatusCode;
        
        private System.Windows.Forms.Label labelStatusCode;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurementName;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementName;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurementCode;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementCode;
        
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
            this.labelFinancialUnitOfMeasurement = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.labelSortSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSortSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelChangeFlag = new System.Windows.Forms.Label();
            this.checkBoxChangeFlag = new System.Windows.Forms.CheckBox();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.labelFinancialUnitOfMeasurementName = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurementName = new System.Windows.Forms.TextBox();
            this.labelFinancialUnitOfMeasurementCode = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurementCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialUnitOfMeasurement
            //
            this.labelFinancialUnitOfMeasurement.AutoSize = true;
            this.labelFinancialUnitOfMeasurement.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialUnitOfMeasurement.Name = "labelFinancialUnitOfMeasurement";
            this.labelFinancialUnitOfMeasurement.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurement.TabIndex = 2;
            this.labelFinancialUnitOfMeasurement.Text = "Financial Unit Of Measurement:";
            //
            //textBoxFinancialUnitOfMeasurement
            //
            this.textBoxFinancialUnitOfMeasurement.Location = new System.Drawing.Point(238, 13);
            this.textBoxFinancialUnitOfMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurement.Name = "textBoxFinancialUnitOfMeasurement";
            this.textBoxFinancialUnitOfMeasurement.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurement.TabIndex = 3;
            //
            // labelSortSequenceNumber
            //
            this.labelSortSequenceNumber.AutoSize = true;
            this.labelSortSequenceNumber.Location = new System.Drawing.Point(11, 36);
            this.labelSortSequenceNumber.Name = "labelSortSequenceNumber";
            this.labelSortSequenceNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSortSequenceNumber.TabIndex = 4;
            this.labelSortSequenceNumber.Text = "Sort Sequence Number:";
            //
            //maskedTextBoxSortSequenceNumber
            //
            this.maskedTextBoxSortSequenceNumber.Location = new System.Drawing.Point(238, 36);
            this.maskedTextBoxSortSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortSequenceNumber.Name = "maskedTextBoxSortSequenceNumber";
            this.maskedTextBoxSortSequenceNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortSequenceNumber.TabIndex = 5;
            //
            // labelChangeFlag
            //
            this.labelChangeFlag.AutoSize = true;
            this.labelChangeFlag.Location = new System.Drawing.Point(11, 59);
            this.labelChangeFlag.Name = "labelChangeFlag";
            this.labelChangeFlag.Size = new System.Drawing.Size(71, 13);
            this.labelChangeFlag.TabIndex = 6;
            this.labelChangeFlag.Text = "Change Flag:";
            //
            //checkBoxChangeFlag
            //
            this.checkBoxChangeFlag.Location = new System.Drawing.Point(238, 59);
            this.checkBoxChangeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChangeFlag.Name = "checkBoxChangeFlag";
            this.checkBoxChangeFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxChangeFlag.TabIndex = 7;
            //
            // labelStatusCode
            //
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(11, 82);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(71, 13);
            this.labelStatusCode.TabIndex = 8;
            this.labelStatusCode.Text = "Status Code:";
            //
            //textBoxStatusCode
            //
            this.textBoxStatusCode.Location = new System.Drawing.Point(238, 82);
            this.textBoxStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxStatusCode.TabIndex = 9;
            //
            // labelFinancialUnitOfMeasurementName
            //
            this.labelFinancialUnitOfMeasurementName.AutoSize = true;
            this.labelFinancialUnitOfMeasurementName.Location = new System.Drawing.Point(11, 105);
            this.labelFinancialUnitOfMeasurementName.Name = "labelFinancialUnitOfMeasurementName";
            this.labelFinancialUnitOfMeasurementName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementName.TabIndex = 10;
            this.labelFinancialUnitOfMeasurementName.Text = "Financial Unit Of Measurement Name:";
            //
            //textBoxFinancialUnitOfMeasurementName
            //
            this.textBoxFinancialUnitOfMeasurementName.Location = new System.Drawing.Point(238, 105);
            this.textBoxFinancialUnitOfMeasurementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurementName.Name = "textBoxFinancialUnitOfMeasurementName";
            this.textBoxFinancialUnitOfMeasurementName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurementName.TabIndex = 11;
            //
            // labelFinancialUnitOfMeasurementCode
            //
            this.labelFinancialUnitOfMeasurementCode.AutoSize = true;
            this.labelFinancialUnitOfMeasurementCode.Location = new System.Drawing.Point(11, 128);
            this.labelFinancialUnitOfMeasurementCode.Name = "labelFinancialUnitOfMeasurementCode";
            this.labelFinancialUnitOfMeasurementCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementCode.TabIndex = 12;
            this.labelFinancialUnitOfMeasurementCode.Text = "Financial Unit Of Measurement Code:";
            //
            //textBoxFinancialUnitOfMeasurementCode
            //
            this.textBoxFinancialUnitOfMeasurementCode.Location = new System.Drawing.Point(238, 128);
            this.textBoxFinancialUnitOfMeasurementCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurementCode.Name = "textBoxFinancialUnitOfMeasurementCode";
            this.textBoxFinancialUnitOfMeasurementCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurementCode.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 174);
            
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
            this.buttonSave.Location = new System.Drawing.Point(296, 174);
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
            this.ClientSize = new System.Drawing.Size(500, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialUnitOfMeasurementRefEdit";
            this.Text = "Financial Unit Of Measurement Ref Edit";
            this.Controls.Add(this.labelFinancialUnitOfMeasurement);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurement);
            this.Controls.Add(this.labelSortSequenceNumber);
            this.Controls.Add(this.maskedTextBoxSortSequenceNumber);
            this.Controls.Add(this.labelChangeFlag);
            this.Controls.Add(this.checkBoxChangeFlag);
            this.Controls.Add(this.labelStatusCode);
            this.Controls.Add(this.textBoxStatusCode);
            this.Controls.Add(this.labelFinancialUnitOfMeasurementName);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurementName);
            this.Controls.Add(this.labelFinancialUnitOfMeasurementCode);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurementCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
