namespace norpim.UserInterface {
    
    
    public partial class CrudeProductInformationSourceTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductInformationSourceTypeRefCombo productInformationSourceTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductInformationSourceTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductInformationSourceTypeName;
        
        private System.Windows.Forms.Label labelProductInformationSourceTypeName;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.labelProductInformationSourceTypeRefCombo = new System.Windows.Forms.Label();
            this.productInformationSourceTypeRefCombo = new ProductInformationSourceTypeRefCombo();
            this.labelProductInformationSourceTypeName = new System.Windows.Forms.Label();
            this.textBoxProductInformationSourceTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductInformationSourceTypeRefCombo
            //
            this.labelProductInformationSourceTypeRefCombo.AutoSize = true;
            this.labelProductInformationSourceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductInformationSourceTypeRefCombo.Name = "labelProductInformationSourceTypeRefCombo";
            this.labelProductInformationSourceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInformationSourceTypeRefCombo.TabIndex = 2;
            this.labelProductInformationSourceTypeRefCombo.Text = "Product Information Source Type:";
            //
            //productInformationSourceTypeRefCombo
            //
            this.productInformationSourceTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productInformationSourceTypeRefCombo.Name = "productInformationSourceTypeRefCombo";
            this.productInformationSourceTypeRefCombo.Size = new System.Drawing.Size(200, 20);
            this.productInformationSourceTypeRefCombo.TabIndex = 3;
            //
            // labelProductInformationSourceTypeName
            //
            this.labelProductInformationSourceTypeName.AutoSize = true;
            this.labelProductInformationSourceTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductInformationSourceTypeName.Name = "labelProductInformationSourceTypeName";
            this.labelProductInformationSourceTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductInformationSourceTypeName.TabIndex = 4;
            this.labelProductInformationSourceTypeName.Text = "Product Information Source Type Name:";
            //
            //textBoxProductInformationSourceTypeName
            //
            this.textBoxProductInformationSourceTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInformationSourceTypeName.Name = "textBoxProductInformationSourceTypeName";
            this.textBoxProductInformationSourceTypeName.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductInformationSourceTypeName.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 59);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(200, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(248, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(150, 105);
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
            this.ClientSize = new System.Drawing.Size(345, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductInformationSourceTypeRefEdit";
            this.Text = "Product Information Source Type Ref Edit";
            this.Controls.Add(this.labelProductInformationSourceTypeRefCombo);
            this.Controls.Add(this.productInformationSourceTypeRefCombo);
            this.Controls.Add(this.labelProductInformationSourceTypeName);
            this.Controls.Add(this.textBoxProductInformationSourceTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
