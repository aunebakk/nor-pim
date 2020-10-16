namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientNationalityRefEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxClientNationality;

        private System.Windows.Forms.Label labelClientNationality;

        private System.Windows.Forms.TextBox textBoxClientNationalityName;

        private System.Windows.Forms.Label labelClientNationalityName;

        private System.Windows.Forms.TextBox textBoxClientNationalityDescription;

        private System.Windows.Forms.Label labelClientNationalityDescription;

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
            this.labelClientNationality = new System.Windows.Forms.Label();
            this.textBoxClientNationality = new System.Windows.Forms.TextBox();
            this.labelClientNationalityName = new System.Windows.Forms.Label();
            this.textBoxClientNationalityName = new System.Windows.Forms.TextBox();
            this.labelClientNationalityDescription = new System.Windows.Forms.Label();
            this.textBoxClientNationalityDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientNationality
            //
            this.labelClientNationality.AutoSize = true;
            this.labelClientNationality.Location = new System.Drawing.Point(11, 13);
            this.labelClientNationality.Name = "labelClientNationality";
            this.labelClientNationality.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationality.TabIndex = 2;
            this.labelClientNationality.Text = "Client Nationality:";
            //
            //textBoxClientNationality
            //
            this.textBoxClientNationality.Location = new System.Drawing.Point(210, 13);
            this.textBoxClientNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationality.Name = "textBoxClientNationality";
            this.textBoxClientNationality.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationality.TabIndex = 3;
            //
            // labelClientNationalityName
            //
            this.labelClientNationalityName.AutoSize = true;
            this.labelClientNationalityName.Location = new System.Drawing.Point(11, 36);
            this.labelClientNationalityName.Name = "labelClientNationalityName";
            this.labelClientNationalityName.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityName.TabIndex = 4;
            this.labelClientNationalityName.Text = "Client Nationality Name:";
            //
            //textBoxClientNationalityName
            //
            this.textBoxClientNationalityName.Location = new System.Drawing.Point(210, 36);
            this.textBoxClientNationalityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationalityName.Name = "textBoxClientNationalityName";
            this.textBoxClientNationalityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationalityName.TabIndex = 5;
            //
            // labelClientNationalityDescription
            //
            this.labelClientNationalityDescription.AutoSize = true;
            this.labelClientNationalityDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientNationalityDescription.Name = "labelClientNationalityDescription";
            this.labelClientNationalityDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityDescription.TabIndex = 6;
            this.labelClientNationalityDescription.Text = "Client Nationality Description:";
            //
            //textBoxClientNationalityDescription
            //
            this.textBoxClientNationalityDescription.Location = new System.Drawing.Point(210, 59);
            this.textBoxClientNationalityDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationalityDescription.Name = "textBoxClientNationalityDescription";
            this.textBoxClientNationalityDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationalityDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(210, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(210, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 151);

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
            this.buttonSave.Location = new System.Drawing.Point(268, 151);
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
            this.ClientSize = new System.Drawing.Size(472, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientNationalityRefEdit";
            this.Text = "Client Nationality Ref Edit";
            this.Controls.Add(this.labelClientNationality);
            this.Controls.Add(this.textBoxClientNationality);
            this.Controls.Add(this.labelClientNationalityName);
            this.Controls.Add(this.textBoxClientNationalityName);
            this.Controls.Add(this.labelClientNationalityDescription);
            this.Controls.Add(this.textBoxClientNationalityDescription);
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
