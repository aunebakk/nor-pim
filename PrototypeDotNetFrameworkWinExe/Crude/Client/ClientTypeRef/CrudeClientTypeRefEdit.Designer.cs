namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientType;
        
        private System.Windows.Forms.Label labelClientType;
        
        private System.Windows.Forms.TextBox textBoxClientTypeName;
        
        private System.Windows.Forms.Label labelClientTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientTypeDescription;
        
        private System.Windows.Forms.Label labelClientTypeDescription;
        
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
            this.labelClientType = new System.Windows.Forms.Label();
            this.textBoxClientType = new System.Windows.Forms.TextBox();
            this.labelClientTypeName = new System.Windows.Forms.Label();
            this.textBoxClientTypeName = new System.Windows.Forms.TextBox();
            this.labelClientTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientTypeDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientType
            //
            this.labelClientType.AutoSize = true;
            this.labelClientType.Location = new System.Drawing.Point(11, 13);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(71, 13);
            this.labelClientType.TabIndex = 2;
            this.labelClientType.Text = "Client Type:";
            //
            //textBoxClientType
            //
            this.textBoxClientType.Location = new System.Drawing.Point(161, 13);
            this.textBoxClientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientType.Name = "textBoxClientType";
            this.textBoxClientType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientType.TabIndex = 3;
            //
            // labelClientTypeName
            //
            this.labelClientTypeName.AutoSize = true;
            this.labelClientTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientTypeName.Name = "labelClientTypeName";
            this.labelClientTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeName.TabIndex = 4;
            this.labelClientTypeName.Text = "Client Type Name:";
            //
            //textBoxClientTypeName
            //
            this.textBoxClientTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxClientTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTypeName.Name = "textBoxClientTypeName";
            this.textBoxClientTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTypeName.TabIndex = 5;
            //
            // labelClientTypeDescription
            //
            this.labelClientTypeDescription.AutoSize = true;
            this.labelClientTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientTypeDescription.Name = "labelClientTypeDescription";
            this.labelClientTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeDescription.TabIndex = 6;
            this.labelClientTypeDescription.Text = "Client Type Description:";
            //
            //textBoxClientTypeDescription
            //
            this.textBoxClientTypeDescription.Location = new System.Drawing.Point(161, 59);
            this.textBoxClientTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTypeDescription.Name = "textBoxClientTypeDescription";
            this.textBoxClientTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTypeDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(161, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(161, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 151);
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
            this.ClientSize = new System.Drawing.Size(423, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientTypeRefEdit";
            this.Text = "Client Type Ref Edit";
            this.Controls.Add(this.labelClientType);
            this.Controls.Add(this.textBoxClientType);
            this.Controls.Add(this.labelClientTypeName);
            this.Controls.Add(this.textBoxClientTypeName);
            this.Controls.Add(this.labelClientTypeDescription);
            this.Controls.Add(this.textBoxClientTypeDescription);
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
