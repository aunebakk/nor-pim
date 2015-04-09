namespace norpim.UserInterface {
    
    
    public partial class CrudeUserActivityTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private UserActivityTypeRefCombo userActivityTypeRefCombo;
        
        private System.Windows.Forms.Label labelUserActivityTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxUserActivityTypeName;
        
        private System.Windows.Forms.Label labelUserActivityTypeName;
        
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
            this.labelUserActivityTypeRefCombo = new System.Windows.Forms.Label();
            this.userActivityTypeRefCombo = new UserActivityTypeRefCombo();
            this.labelUserActivityTypeName = new System.Windows.Forms.Label();
            this.textBoxUserActivityTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelUserActivityTypeRefCombo
            //
            this.labelUserActivityTypeRefCombo.AutoSize = true;
            this.labelUserActivityTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelUserActivityTypeRefCombo.Name = "labelUserActivityTypeRefCombo";
            this.labelUserActivityTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelUserActivityTypeRefCombo.TabIndex = 2;
            this.labelUserActivityTypeRefCombo.Text = "User Activity Type:";
            //
            //userActivityTypeRefCombo
            //
            this.userActivityTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.userActivityTypeRefCombo.Name = "userActivityTypeRefCombo";
            this.userActivityTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.userActivityTypeRefCombo.TabIndex = 3;
            //
            // labelUserActivityTypeName
            //
            this.labelUserActivityTypeName.AutoSize = true;
            this.labelUserActivityTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelUserActivityTypeName.Name = "labelUserActivityTypeName";
            this.labelUserActivityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelUserActivityTypeName.TabIndex = 4;
            this.labelUserActivityTypeName.Text = "User Activity Type Name:";
            //
            //textBoxUserActivityTypeName
            //
            this.textBoxUserActivityTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxUserActivityTypeName.Name = "textBoxUserActivityTypeName";
            this.textBoxUserActivityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxUserActivityTypeName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(161, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 105);
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
            this.ClientSize = new System.Drawing.Size(433, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeUserActivityTypeRefEdit";
            this.Text = "User Activity Type Ref Edit";
            this.Controls.Add(this.labelUserActivityTypeRefCombo);
            this.Controls.Add(this.userActivityTypeRefCombo);
            this.Controls.Add(this.labelUserActivityTypeName);
            this.Controls.Add(this.textBoxUserActivityTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
