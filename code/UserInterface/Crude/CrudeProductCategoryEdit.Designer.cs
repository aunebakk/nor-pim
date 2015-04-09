namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryCode;
        
        private System.Windows.Forms.Label labelProductCategoryCode;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryName;
        
        private System.Windows.Forms.Label labelProductCategoryName;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProductCategoryPosition;
        
        private System.Windows.Forms.Label labelProductCategoryPosition;
        
        private StateRefCombo stateRefCombo;
        
        private System.Windows.Forms.Label labelStateRefCombo;
        
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
            this.labelProductCategoryCode = new System.Windows.Forms.Label();
            this.textBoxProductCategoryCode = new System.Windows.Forms.TextBox();
            this.labelProductCategoryName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryPosition = new System.Windows.Forms.Label();
            this.maskedTextBoxProductCategoryPosition = new System.Windows.Forms.MaskedTextBox();
            this.labelStateRefCombo = new System.Windows.Forms.Label();
            this.stateRefCombo = new StateRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelProductCategoryCode
            //
            this.labelProductCategoryCode.AutoSize = true;
            this.labelProductCategoryCode.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryCode.Name = "labelProductCategoryCode";
            this.labelProductCategoryCode.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryCode.TabIndex = 2;
            this.labelProductCategoryCode.Text = "Product Category Code:";
            //
            //textBoxProductCategoryCode
            //
            this.textBoxProductCategoryCode.Location = new System.Drawing.Point(175, 13);
            this.textBoxProductCategoryCode.Name = "textBoxProductCategoryCode";
            this.textBoxProductCategoryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryCode.TabIndex = 3;
            //
            // labelProductCategoryName
            //
            this.labelProductCategoryName.AutoSize = true;
            this.labelProductCategoryName.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryName.Name = "labelProductCategoryName";
            this.labelProductCategoryName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryName.TabIndex = 4;
            this.labelProductCategoryName.Text = "Product Category Name:";
            //
            //textBoxProductCategoryName
            //
            this.textBoxProductCategoryName.Location = new System.Drawing.Point(175, 36);
            this.textBoxProductCategoryName.Name = "textBoxProductCategoryName";
            this.textBoxProductCategoryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryName.TabIndex = 5;
            //
            // labelProductCategoryPosition
            //
            this.labelProductCategoryPosition.AutoSize = true;
            this.labelProductCategoryPosition.Location = new System.Drawing.Point(11, 59);
            this.labelProductCategoryPosition.Name = "labelProductCategoryPosition";
            this.labelProductCategoryPosition.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryPosition.TabIndex = 6;
            this.labelProductCategoryPosition.Text = "Product Category Position:";
            //
            //maskedTextBoxProductCategoryPosition
            //
            this.maskedTextBoxProductCategoryPosition.Location = new System.Drawing.Point(175, 59);
            this.maskedTextBoxProductCategoryPosition.Name = "maskedTextBoxProductCategoryPosition";
            this.maskedTextBoxProductCategoryPosition.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxProductCategoryPosition.TabIndex = 7;
            //
            // labelStateRefCombo
            //
            this.labelStateRefCombo.AutoSize = true;
            this.labelStateRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelStateRefCombo.Name = "labelStateRefCombo";
            this.labelStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelStateRefCombo.TabIndex = 8;
            this.labelStateRefCombo.Text = "State:";
            //
            //stateRefCombo
            //
            this.stateRefCombo.Location = new System.Drawing.Point(175, 82);
            this.stateRefCombo.Name = "stateRefCombo";
            this.stateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.stateRefCombo.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(175, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 128);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
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
            this.ClientSize = new System.Drawing.Size(447, 174);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductCategoryEdit";
            this.Text = "Product Category Edit";
            this.Controls.Add(this.labelProductCategoryCode);
            this.Controls.Add(this.textBoxProductCategoryCode);
            this.Controls.Add(this.labelProductCategoryName);
            this.Controls.Add(this.textBoxProductCategoryName);
            this.Controls.Add(this.labelProductCategoryPosition);
            this.Controls.Add(this.maskedTextBoxProductCategoryPosition);
            this.Controls.Add(this.labelStateRefCombo);
            this.Controls.Add(this.stateRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
