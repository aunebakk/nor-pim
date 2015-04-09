namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSetTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductExposeSetTypeRefCombo productExposeSetTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetTypeName;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeName;
        
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
            this.labelProductExposeSetTypeRefCombo = new System.Windows.Forms.Label();
            this.productExposeSetTypeRefCombo = new ProductExposeSetTypeRefCombo();
            this.labelProductExposeSetTypeName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductExposeSetTypeRefCombo
            //
            this.labelProductExposeSetTypeRefCombo.AutoSize = true;
            this.labelProductExposeSetTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetTypeRefCombo.Name = "labelProductExposeSetTypeRefCombo";
            this.labelProductExposeSetTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeRefCombo.TabIndex = 2;
            this.labelProductExposeSetTypeRefCombo.Text = "Product Expose Set Type:";
            //
            //productExposeSetTypeRefCombo
            //
            this.productExposeSetTypeRefCombo.Location = new System.Drawing.Point(196, 13);
            this.productExposeSetTypeRefCombo.Name = "productExposeSetTypeRefCombo";
            this.productExposeSetTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productExposeSetTypeRefCombo.TabIndex = 3;
            //
            // labelProductExposeSetTypeName
            //
            this.labelProductExposeSetTypeName.AutoSize = true;
            this.labelProductExposeSetTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetTypeName.Name = "labelProductExposeSetTypeName";
            this.labelProductExposeSetTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeName.TabIndex = 4;
            this.labelProductExposeSetTypeName.Text = "Product Expose Set Type Name:";
            //
            //textBoxProductExposeSetTypeName
            //
            this.textBoxProductExposeSetTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxProductExposeSetTypeName.Name = "textBoxProductExposeSetTypeName";
            this.textBoxProductExposeSetTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetTypeName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(196, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 105);
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
            this.ClientSize = new System.Drawing.Size(468, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductExposeSetTypeRefEdit";
            this.Text = "Product Expose Set Type Ref Edit";
            this.Controls.Add(this.labelProductExposeSetTypeRefCombo);
            this.Controls.Add(this.productExposeSetTypeRefCombo);
            this.Controls.Add(this.labelProductExposeSetTypeName);
            this.Controls.Add(this.textBoxProductExposeSetTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
