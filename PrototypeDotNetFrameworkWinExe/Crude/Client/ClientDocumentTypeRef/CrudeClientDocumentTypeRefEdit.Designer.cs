namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientDocumentTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientDocumentType;
        
        private System.Windows.Forms.Label labelClientDocumentType;
        
        private System.Windows.Forms.TextBox textBoxClientDocumentTypeName;
        
        private System.Windows.Forms.Label labelClientDocumentTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientDocumentTypeDescription;
        
        private System.Windows.Forms.Label labelClientDocumentTypeDescription;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
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
            this.labelClientDocumentType = new System.Windows.Forms.Label();
            this.textBoxClientDocumentType = new System.Windows.Forms.TextBox();
            this.labelClientDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxClientDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelClientDocumentTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientDocumentTypeDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientDocumentType
            //
            this.labelClientDocumentType.AutoSize = true;
            this.labelClientDocumentType.Location = new System.Drawing.Point(11, 13);
            this.labelClientDocumentType.Name = "labelClientDocumentType";
            this.labelClientDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentType.TabIndex = 2;
            this.labelClientDocumentType.Text = "Client Document Type:";
            //
            //textBoxClientDocumentType
            //
            this.textBoxClientDocumentType.Location = new System.Drawing.Point(224, 13);
            this.textBoxClientDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentType.Name = "textBoxClientDocumentType";
            this.textBoxClientDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentType.TabIndex = 3;
            //
            // labelClientDocumentTypeName
            //
            this.labelClientDocumentTypeName.AutoSize = true;
            this.labelClientDocumentTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientDocumentTypeName.Name = "labelClientDocumentTypeName";
            this.labelClientDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentTypeName.TabIndex = 4;
            this.labelClientDocumentTypeName.Text = "Client Document Type Name:";
            //
            //textBoxClientDocumentTypeName
            //
            this.textBoxClientDocumentTypeName.Location = new System.Drawing.Point(224, 36);
            this.textBoxClientDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentTypeName.Name = "textBoxClientDocumentTypeName";
            this.textBoxClientDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentTypeName.TabIndex = 5;
            //
            // labelClientDocumentTypeDescription
            //
            this.labelClientDocumentTypeDescription.AutoSize = true;
            this.labelClientDocumentTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientDocumentTypeDescription.Name = "labelClientDocumentTypeDescription";
            this.labelClientDocumentTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentTypeDescription.TabIndex = 6;
            this.labelClientDocumentTypeDescription.Text = "Client Document Type Description:";
            //
            //textBoxClientDocumentTypeDescription
            //
            this.textBoxClientDocumentTypeDescription.Location = new System.Drawing.Point(224, 59);
            this.textBoxClientDocumentTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentTypeDescription.Name = "textBoxClientDocumentTypeDescription";
            this.textBoxClientDocumentTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentTypeDescription.TabIndex = 7;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 82);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 8;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(224, 82);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 9;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 105);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 10;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(224, 105);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(282, 151);
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
            this.ClientSize = new System.Drawing.Size(486, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientDocumentTypeRefEdit";
            this.Text = "Client Document Type Ref Edit";
            this.Controls.Add(this.labelClientDocumentType);
            this.Controls.Add(this.textBoxClientDocumentType);
            this.Controls.Add(this.labelClientDocumentTypeName);
            this.Controls.Add(this.textBoxClientDocumentTypeName);
            this.Controls.Add(this.labelClientDocumentTypeDescription);
            this.Controls.Add(this.textBoxClientDocumentTypeDescription);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
