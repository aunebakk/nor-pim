namespace norpim.UserInterface {
    
    
    public partial class CrudeProductAttributeEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductPicker productPicker;
        
        private System.Windows.Forms.Label labelProductPicker;
        
        private ProductAttributeRefCombo productAttributeRefCombo;
        
        private System.Windows.Forms.Label labelProductAttributeRefCombo;
        
        private ProductAttributeUnitRefCombo productAttributeUnitRefCombo;
        
        private System.Windows.Forms.Label labelProductAttributeUnitRefCombo;
        
        private System.Windows.Forms.TextBox textBoxValue;
        
        private System.Windows.Forms.Label labelValue;
        
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
            this.labelProductPicker = new System.Windows.Forms.Label();
            this.productPicker = new ProductPicker();
            this.labelProductAttributeRefCombo = new System.Windows.Forms.Label();
            this.productAttributeRefCombo = new ProductAttributeRefCombo();
            this.labelProductAttributeUnitRefCombo = new System.Windows.Forms.Label();
            this.productAttributeUnitRefCombo = new ProductAttributeUnitRefCombo();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductPicker
            //
            this.labelProductPicker.AutoSize = true;
            this.labelProductPicker.Location = new System.Drawing.Point(11, 13);
            this.labelProductPicker.Name = "labelProductPicker";
            this.labelProductPicker.Size = new System.Drawing.Size(71, 13);
            this.labelProductPicker.TabIndex = 2;
            this.labelProductPicker.Text = "Product :";
            //
            //productPicker
            //
            this.productPicker.Location = new System.Drawing.Point(154, 13);
            this.productPicker.Name = "productPicker";
            this.productPicker.Size = new System.Drawing.Size(250, 20);
            this.productPicker.TabIndex = 3;
            //
            // labelProductAttributeRefCombo
            //
            this.labelProductAttributeRefCombo.AutoSize = true;
            this.labelProductAttributeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeRefCombo.Name = "labelProductAttributeRefCombo";
            this.labelProductAttributeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeRefCombo.TabIndex = 4;
            this.labelProductAttributeRefCombo.Text = "Product Attribute:";
            //
            //productAttributeRefCombo
            //
            this.productAttributeRefCombo.Location = new System.Drawing.Point(154, 36);
            this.productAttributeRefCombo.Name = "productAttributeRefCombo";
            this.productAttributeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productAttributeRefCombo.TabIndex = 5;
            //
            // labelProductAttributeUnitRefCombo
            //
            this.labelProductAttributeUnitRefCombo.AutoSize = true;
            this.labelProductAttributeUnitRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelProductAttributeUnitRefCombo.Name = "labelProductAttributeUnitRefCombo";
            this.labelProductAttributeUnitRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitRefCombo.TabIndex = 6;
            this.labelProductAttributeUnitRefCombo.Text = "Product Attribute Unit:";
            //
            //productAttributeUnitRefCombo
            //
            this.productAttributeUnitRefCombo.Location = new System.Drawing.Point(154, 59);
            this.productAttributeUnitRefCombo.Name = "productAttributeUnitRefCombo";
            this.productAttributeUnitRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productAttributeUnitRefCombo.TabIndex = 7;
            //
            // labelValue
            //
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(11, 82);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(71, 13);
            this.labelValue.TabIndex = 8;
            this.labelValue.Text = "Value:";
            //
            //textBoxValue
            //
            this.textBoxValue.Location = new System.Drawing.Point(154, 82);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxValue.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(154, 105);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 128);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 151);
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
            this.ClientSize = new System.Drawing.Size(426, 174);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductAttributeEdit";
            this.Text = "Product Attribute Edit";
            this.Controls.Add(this.labelProductPicker);
            this.Controls.Add(this.productPicker);
            this.Controls.Add(this.labelProductAttributeRefCombo);
            this.Controls.Add(this.productAttributeRefCombo);
            this.Controls.Add(this.labelProductAttributeUnitRefCombo);
            this.Controls.Add(this.productAttributeUnitRefCombo);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
