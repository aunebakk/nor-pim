namespace norpim.UserInterface {
    
    
    public partial class CrudeProductAttributeUnitRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductAttributeUnitRefCombo productAttributeUnitRefCombo;
        
        private System.Windows.Forms.Label labelProductAttributeUnitRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeUnitName;
        
        private System.Windows.Forms.Label labelProductAttributeUnitName;
        
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
            this.labelProductAttributeUnitRefCombo = new System.Windows.Forms.Label();
            this.productAttributeUnitRefCombo = new ProductAttributeUnitRefCombo();
            this.labelProductAttributeUnitName = new System.Windows.Forms.Label();
            this.textBoxProductAttributeUnitName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductAttributeUnitRefCombo
            //
            this.labelProductAttributeUnitRefCombo.AutoSize = true;
            this.labelProductAttributeUnitRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttributeUnitRefCombo.Name = "labelProductAttributeUnitRefCombo";
            this.labelProductAttributeUnitRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitRefCombo.TabIndex = 2;
            this.labelProductAttributeUnitRefCombo.Text = "Product Attribute Unit:";
            //
            //productAttributeUnitRefCombo
            //
            this.productAttributeUnitRefCombo.Location = new System.Drawing.Point(189, 13);
            this.productAttributeUnitRefCombo.Name = "productAttributeUnitRefCombo";
            this.productAttributeUnitRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productAttributeUnitRefCombo.TabIndex = 3;
            //
            // labelProductAttributeUnitName
            //
            this.labelProductAttributeUnitName.AutoSize = true;
            this.labelProductAttributeUnitName.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeUnitName.Name = "labelProductAttributeUnitName";
            this.labelProductAttributeUnitName.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitName.TabIndex = 4;
            this.labelProductAttributeUnitName.Text = "Product Attribute Unit Name:";
            //
            //textBoxProductAttributeUnitName
            //
            this.textBoxProductAttributeUnitName.Location = new System.Drawing.Point(189, 36);
            this.textBoxProductAttributeUnitName.Name = "textBoxProductAttributeUnitName";
            this.textBoxProductAttributeUnitName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeUnitName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(189, 59);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 105);
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
            this.ClientSize = new System.Drawing.Size(461, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductAttributeUnitRefEdit";
            this.Text = "Product Attribute Unit Ref Edit";
            this.Controls.Add(this.labelProductAttributeUnitRefCombo);
            this.Controls.Add(this.productAttributeUnitRefCombo);
            this.Controls.Add(this.labelProductAttributeUnitName);
            this.Controls.Add(this.textBoxProductAttributeUnitName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
