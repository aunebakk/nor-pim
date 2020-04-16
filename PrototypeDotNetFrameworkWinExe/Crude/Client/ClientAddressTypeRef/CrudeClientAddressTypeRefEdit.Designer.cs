namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientAddressTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientAddressType;
        
        private System.Windows.Forms.Label labelClientAddressType;
        
        private System.Windows.Forms.TextBox textBoxClientAddressTypeName;
        
        private System.Windows.Forms.Label labelClientAddressTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientAddressTypeDescription;
        
        private System.Windows.Forms.Label labelClientAddressTypeDescription;
        
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
            this.labelClientAddressType = new System.Windows.Forms.Label();
            this.textBoxClientAddressType = new System.Windows.Forms.TextBox();
            this.labelClientAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxClientAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelClientAddressTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientAddressTypeDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientAddressType
            //
            this.labelClientAddressType.AutoSize = true;
            this.labelClientAddressType.Location = new System.Drawing.Point(11, 13);
            this.labelClientAddressType.Name = "labelClientAddressType";
            this.labelClientAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressType.TabIndex = 2;
            this.labelClientAddressType.Text = "Client Address Type:";
            //
            //textBoxClientAddressType
            //
            this.textBoxClientAddressType.Location = new System.Drawing.Point(217, 13);
            this.textBoxClientAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressType.Name = "textBoxClientAddressType";
            this.textBoxClientAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressType.TabIndex = 3;
            //
            // labelClientAddressTypeName
            //
            this.labelClientAddressTypeName.AutoSize = true;
            this.labelClientAddressTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientAddressTypeName.Name = "labelClientAddressTypeName";
            this.labelClientAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressTypeName.TabIndex = 4;
            this.labelClientAddressTypeName.Text = "Client Address Type Name:";
            //
            //textBoxClientAddressTypeName
            //
            this.textBoxClientAddressTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxClientAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressTypeName.Name = "textBoxClientAddressTypeName";
            this.textBoxClientAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressTypeName.TabIndex = 5;
            //
            // labelClientAddressTypeDescription
            //
            this.labelClientAddressTypeDescription.AutoSize = true;
            this.labelClientAddressTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientAddressTypeDescription.Name = "labelClientAddressTypeDescription";
            this.labelClientAddressTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressTypeDescription.TabIndex = 6;
            this.labelClientAddressTypeDescription.Text = "Client Address Type Description:";
            //
            //textBoxClientAddressTypeDescription
            //
            this.textBoxClientAddressTypeDescription.Location = new System.Drawing.Point(217, 59);
            this.textBoxClientAddressTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressTypeDescription.Name = "textBoxClientAddressTypeDescription";
            this.textBoxClientAddressTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressTypeDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(217, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(217, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(275, 151);
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
            this.ClientSize = new System.Drawing.Size(479, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientAddressTypeRefEdit";
            this.Text = "Client Address Type Ref Edit";
            this.Controls.Add(this.labelClientAddressType);
            this.Controls.Add(this.textBoxClientAddressType);
            this.Controls.Add(this.labelClientAddressTypeName);
            this.Controls.Add(this.textBoxClientAddressTypeName);
            this.Controls.Add(this.labelClientAddressTypeDescription);
            this.Controls.Add(this.textBoxClientAddressTypeDescription);
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
