namespace norpim.UserInterface {
    
    
    public partial class CrudeProductIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductPicker productPicker;
        
        private System.Windows.Forms.Label labelProductPicker;
        
        private ProductIdentifierRefCombo productIdentifierRefCombo;
        
        private System.Windows.Forms.Label labelProductIdentifierRefCombo;
        
        private System.Windows.Forms.TextBox textBoxIdentifier;
        
        private System.Windows.Forms.Label labelIdentifier;
        
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
            this.labelProductIdentifierRefCombo = new System.Windows.Forms.Label();
            this.productIdentifierRefCombo = new ProductIdentifierRefCombo();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.textBoxIdentifier = new System.Windows.Forms.TextBox();
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
            this.productPicker.Location = new System.Drawing.Point(140, 13);
            this.productPicker.Name = "productPicker";
            this.productPicker.Size = new System.Drawing.Size(250, 20);
            this.productPicker.TabIndex = 3;
            //
            // labelProductIdentifierRefCombo
            //
            this.labelProductIdentifierRefCombo.AutoSize = true;
            this.labelProductIdentifierRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductIdentifierRefCombo.Name = "labelProductIdentifierRefCombo";
            this.labelProductIdentifierRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifierRefCombo.TabIndex = 4;
            this.labelProductIdentifierRefCombo.Text = "Product Identifier:";
            //
            //productIdentifierRefCombo
            //
            this.productIdentifierRefCombo.Location = new System.Drawing.Point(140, 36);
            this.productIdentifierRefCombo.Name = "productIdentifierRefCombo";
            this.productIdentifierRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productIdentifierRefCombo.TabIndex = 5;
            //
            // labelIdentifier
            //
            this.labelIdentifier.AutoSize = true;
            this.labelIdentifier.Location = new System.Drawing.Point(11, 59);
            this.labelIdentifier.Name = "labelIdentifier";
            this.labelIdentifier.Size = new System.Drawing.Size(71, 13);
            this.labelIdentifier.TabIndex = 6;
            this.labelIdentifier.Text = "Identifier:";
            //
            //textBoxIdentifier
            //
            this.textBoxIdentifier.Location = new System.Drawing.Point(140, 59);
            this.textBoxIdentifier.Name = "textBoxIdentifier";
            this.textBoxIdentifier.Size = new System.Drawing.Size(250, 20);
            this.textBoxIdentifier.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 128);
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
            this.ClientSize = new System.Drawing.Size(412, 151);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductIdentifierEdit";
            this.Text = "Product Identifier Edit";
            this.Controls.Add(this.labelProductPicker);
            this.Controls.Add(this.productPicker);
            this.Controls.Add(this.labelProductIdentifierRefCombo);
            this.Controls.Add(this.productIdentifierRefCombo);
            this.Controls.Add(this.labelIdentifier);
            this.Controls.Add(this.textBoxIdentifier);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
