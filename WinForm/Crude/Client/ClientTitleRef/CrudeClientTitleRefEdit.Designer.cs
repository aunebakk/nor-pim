namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientTitleRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxClientTitle;
        
        private System.Windows.Forms.Label labelClientTitle;
        
        private System.Windows.Forms.TextBox textBoxClientTitleName;
        
        private System.Windows.Forms.Label labelClientTitleName;
        
        private System.Windows.Forms.TextBox textBoxClientTitleDescription;
        
        private System.Windows.Forms.Label labelClientTitleDescription;
        
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
            this.labelClientTitle = new System.Windows.Forms.Label();
            this.textBoxClientTitle = new System.Windows.Forms.TextBox();
            this.labelClientTitleName = new System.Windows.Forms.Label();
            this.textBoxClientTitleName = new System.Windows.Forms.TextBox();
            this.labelClientTitleDescription = new System.Windows.Forms.Label();
            this.textBoxClientTitleDescription = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientTitle
            //
            this.labelClientTitle.AutoSize = true;
            this.labelClientTitle.Location = new System.Drawing.Point(11, 13);
            this.labelClientTitle.Name = "labelClientTitle";
            this.labelClientTitle.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitle.TabIndex = 2;
            this.labelClientTitle.Text = "Client Title:";
            //
            //textBoxClientTitle
            //
            this.textBoxClientTitle.Location = new System.Drawing.Point(168, 13);
            this.textBoxClientTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitle.Name = "textBoxClientTitle";
            this.textBoxClientTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitle.TabIndex = 3;
            //
            // labelClientTitleName
            //
            this.labelClientTitleName.AutoSize = true;
            this.labelClientTitleName.Location = new System.Drawing.Point(11, 36);
            this.labelClientTitleName.Name = "labelClientTitleName";
            this.labelClientTitleName.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleName.TabIndex = 4;
            this.labelClientTitleName.Text = "Client Title Name:";
            //
            //textBoxClientTitleName
            //
            this.textBoxClientTitleName.Location = new System.Drawing.Point(168, 36);
            this.textBoxClientTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitleName.Name = "textBoxClientTitleName";
            this.textBoxClientTitleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitleName.TabIndex = 5;
            //
            // labelClientTitleDescription
            //
            this.labelClientTitleDescription.AutoSize = true;
            this.labelClientTitleDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientTitleDescription.Name = "labelClientTitleDescription";
            this.labelClientTitleDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleDescription.TabIndex = 6;
            this.labelClientTitleDescription.Text = "Client Title Description:";
            //
            //textBoxClientTitleDescription
            //
            this.textBoxClientTitleDescription.Location = new System.Drawing.Point(168, 59);
            this.textBoxClientTitleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitleDescription.Name = "textBoxClientTitleDescription";
            this.textBoxClientTitleDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitleDescription.TabIndex = 7;
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(168, 82);
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(168, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 151);
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
            this.ClientSize = new System.Drawing.Size(430, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientTitleRefEdit";
            this.Text = "Client Title Ref Edit";
            this.Controls.Add(this.labelClientTitle);
            this.Controls.Add(this.textBoxClientTitle);
            this.Controls.Add(this.labelClientTitleName);
            this.Controls.Add(this.textBoxClientTitleName);
            this.Controls.Add(this.labelClientTitleDescription);
            this.Controls.Add(this.textBoxClientTitleDescription);
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
