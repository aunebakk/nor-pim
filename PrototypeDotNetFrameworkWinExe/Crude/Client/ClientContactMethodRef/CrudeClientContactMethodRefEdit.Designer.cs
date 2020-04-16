namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientContactMethodRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientContactMethod;
        
        private System.Windows.Forms.Label labelClientContactMethod;
        
        private System.Windows.Forms.TextBox textBoxClientContactMethodName;
        
        private System.Windows.Forms.Label labelClientContactMethodName;
        
        private System.Windows.Forms.TextBox textBoxClientContactMethodDescription;
        
        private System.Windows.Forms.Label labelClientContactMethodDescription;
        
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
            this.labelClientContactMethod = new System.Windows.Forms.Label();
            this.textBoxClientContactMethod = new System.Windows.Forms.TextBox();
            this.labelClientContactMethodName = new System.Windows.Forms.Label();
            this.textBoxClientContactMethodName = new System.Windows.Forms.TextBox();
            this.labelClientContactMethodDescription = new System.Windows.Forms.Label();
            this.textBoxClientContactMethodDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientContactMethod
            //
            this.labelClientContactMethod.AutoSize = true;
            this.labelClientContactMethod.Location = new System.Drawing.Point(11, 13);
            this.labelClientContactMethod.Name = "labelClientContactMethod";
            this.labelClientContactMethod.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethod.TabIndex = 2;
            this.labelClientContactMethod.Text = "Client Contact Method:";
            //
            //textBoxClientContactMethod
            //
            this.textBoxClientContactMethod.Location = new System.Drawing.Point(231, 13);
            this.textBoxClientContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethod.Name = "textBoxClientContactMethod";
            this.textBoxClientContactMethod.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethod.TabIndex = 3;
            //
            // labelClientContactMethodName
            //
            this.labelClientContactMethodName.AutoSize = true;
            this.labelClientContactMethodName.Location = new System.Drawing.Point(11, 36);
            this.labelClientContactMethodName.Name = "labelClientContactMethodName";
            this.labelClientContactMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodName.TabIndex = 4;
            this.labelClientContactMethodName.Text = "Client Contact Method Name:";
            //
            //textBoxClientContactMethodName
            //
            this.textBoxClientContactMethodName.Location = new System.Drawing.Point(231, 36);
            this.textBoxClientContactMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethodName.Name = "textBoxClientContactMethodName";
            this.textBoxClientContactMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethodName.TabIndex = 5;
            //
            // labelClientContactMethodDescription
            //
            this.labelClientContactMethodDescription.AutoSize = true;
            this.labelClientContactMethodDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientContactMethodDescription.Name = "labelClientContactMethodDescription";
            this.labelClientContactMethodDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodDescription.TabIndex = 6;
            this.labelClientContactMethodDescription.Text = "Client Contact Method Description:";
            //
            //textBoxClientContactMethodDescription
            //
            this.textBoxClientContactMethodDescription.Location = new System.Drawing.Point(231, 59);
            this.textBoxClientContactMethodDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientContactMethodDescription.Name = "textBoxClientContactMethodDescription";
            this.textBoxClientContactMethodDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientContactMethodDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(231, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(231, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(289, 151);
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
            this.ClientSize = new System.Drawing.Size(493, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientContactMethodRefEdit";
            this.Text = "Client Contact Method Ref Edit";
            this.Controls.Add(this.labelClientContactMethod);
            this.Controls.Add(this.textBoxClientContactMethod);
            this.Controls.Add(this.labelClientContactMethodName);
            this.Controls.Add(this.textBoxClientContactMethodName);
            this.Controls.Add(this.labelClientContactMethodDescription);
            this.Controls.Add(this.textBoxClientContactMethodDescription);
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
