namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientIdentifierTypeRefEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxClientIdentifierType;

        private System.Windows.Forms.Label labelClientIdentifierType;

        private System.Windows.Forms.TextBox textBoxClientIdentifierTypeName;

        private System.Windows.Forms.Label labelClientIdentifierTypeName;

        private System.Windows.Forms.TextBox textBoxClientIdentifierTypeDescription;

        private System.Windows.Forms.Label labelClientIdentifierTypeDescription;

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
            this.labelClientIdentifierType = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierType = new System.Windows.Forms.TextBox();
            this.labelClientIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelClientIdentifierTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierTypeDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientIdentifierType
            //
            this.labelClientIdentifierType.AutoSize = true;
            this.labelClientIdentifierType.Location = new System.Drawing.Point(11, 13);
            this.labelClientIdentifierType.Name = "labelClientIdentifierType";
            this.labelClientIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierType.TabIndex = 2;
            this.labelClientIdentifierType.Text = "Client Identifier Type:";
            //
            //textBoxClientIdentifierType
            //
            this.textBoxClientIdentifierType.Location = new System.Drawing.Point(238, 13);
            this.textBoxClientIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierType.Name = "textBoxClientIdentifierType";
            this.textBoxClientIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierType.TabIndex = 3;
            //
            // labelClientIdentifierTypeName
            //
            this.labelClientIdentifierTypeName.AutoSize = true;
            this.labelClientIdentifierTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelClientIdentifierTypeName.Name = "labelClientIdentifierTypeName";
            this.labelClientIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierTypeName.TabIndex = 4;
            this.labelClientIdentifierTypeName.Text = "Client Identifier Type Name:";
            //
            //textBoxClientIdentifierTypeName
            //
            this.textBoxClientIdentifierTypeName.Location = new System.Drawing.Point(238, 36);
            this.textBoxClientIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierTypeName.Name = "textBoxClientIdentifierTypeName";
            this.textBoxClientIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierTypeName.TabIndex = 5;
            //
            // labelClientIdentifierTypeDescription
            //
            this.labelClientIdentifierTypeDescription.AutoSize = true;
            this.labelClientIdentifierTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientIdentifierTypeDescription.Name = "labelClientIdentifierTypeDescription";
            this.labelClientIdentifierTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierTypeDescription.TabIndex = 6;
            this.labelClientIdentifierTypeDescription.Text = "Client Identifier Type Description:";
            //
            //textBoxClientIdentifierTypeDescription
            //
            this.textBoxClientIdentifierTypeDescription.Location = new System.Drawing.Point(238, 59);
            this.textBoxClientIdentifierTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierTypeDescription.Name = "textBoxClientIdentifierTypeDescription";
            this.textBoxClientIdentifierTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierTypeDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(238, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(238, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 151);

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
            this.buttonSave.Location = new System.Drawing.Point(296, 151);
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
            this.ClientSize = new System.Drawing.Size(500, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientIdentifierTypeRefEdit";
            this.Text = "Client Identifier Type Ref Edit";
            this.Controls.Add(this.labelClientIdentifierType);
            this.Controls.Add(this.textBoxClientIdentifierType);
            this.Controls.Add(this.labelClientIdentifierTypeName);
            this.Controls.Add(this.textBoxClientIdentifierTypeName);
            this.Controls.Add(this.labelClientIdentifierTypeDescription);
            this.Controls.Add(this.textBoxClientIdentifierTypeDescription);
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
