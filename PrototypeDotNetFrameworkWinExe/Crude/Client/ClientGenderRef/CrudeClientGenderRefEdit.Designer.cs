namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientGenderRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientGender;
        
        private System.Windows.Forms.Label labelClientGender;
        
        private System.Windows.Forms.TextBox textBoxClientGenderName;
        
        private System.Windows.Forms.Label labelClientGenderName;
        
        private System.Windows.Forms.TextBox textBoxClientGenderDescription;
        
        private System.Windows.Forms.Label labelClientGenderDescription;
        
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
            this.labelClientGender = new System.Windows.Forms.Label();
            this.textBoxClientGender = new System.Windows.Forms.TextBox();
            this.labelClientGenderName = new System.Windows.Forms.Label();
            this.textBoxClientGenderName = new System.Windows.Forms.TextBox();
            this.labelClientGenderDescription = new System.Windows.Forms.Label();
            this.textBoxClientGenderDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientGender
            //
            this.labelClientGender.AutoSize = true;
            this.labelClientGender.Location = new System.Drawing.Point(11, 13);
            this.labelClientGender.Name = "labelClientGender";
            this.labelClientGender.Size = new System.Drawing.Size(71, 13);
            this.labelClientGender.TabIndex = 2;
            this.labelClientGender.Text = "Client Gender:";
            //
            //textBoxClientGender
            //
            this.textBoxClientGender.Location = new System.Drawing.Point(175, 13);
            this.textBoxClientGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGender.Name = "textBoxClientGender";
            this.textBoxClientGender.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGender.TabIndex = 3;
            //
            // labelClientGenderName
            //
            this.labelClientGenderName.AutoSize = true;
            this.labelClientGenderName.Location = new System.Drawing.Point(11, 36);
            this.labelClientGenderName.Name = "labelClientGenderName";
            this.labelClientGenderName.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderName.TabIndex = 4;
            this.labelClientGenderName.Text = "Client Gender Name:";
            //
            //textBoxClientGenderName
            //
            this.textBoxClientGenderName.Location = new System.Drawing.Point(175, 36);
            this.textBoxClientGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGenderName.Name = "textBoxClientGenderName";
            this.textBoxClientGenderName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGenderName.TabIndex = 5;
            //
            // labelClientGenderDescription
            //
            this.labelClientGenderDescription.AutoSize = true;
            this.labelClientGenderDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientGenderDescription.Name = "labelClientGenderDescription";
            this.labelClientGenderDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderDescription.TabIndex = 6;
            this.labelClientGenderDescription.Text = "Client Gender Description:";
            //
            //textBoxClientGenderDescription
            //
            this.textBoxClientGenderDescription.Location = new System.Drawing.Point(175, 59);
            this.textBoxClientGenderDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGenderDescription.Name = "textBoxClientGenderDescription";
            this.textBoxClientGenderDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGenderDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(175, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(175, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(233, 151);
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
            this.ClientSize = new System.Drawing.Size(437, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientGenderRefEdit";
            this.Text = "Client Gender Ref Edit";
            this.Controls.Add(this.labelClientGender);
            this.Controls.Add(this.textBoxClientGender);
            this.Controls.Add(this.labelClientGenderName);
            this.Controls.Add(this.textBoxClientGenderName);
            this.Controls.Add(this.labelClientGenderDescription);
            this.Controls.Add(this.textBoxClientGenderDescription);
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
