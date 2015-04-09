namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemReferenceTableEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxSystemReferenceTableName;
        
        private System.Windows.Forms.Label labelSystemReferenceTableName;
        
        private System.Windows.Forms.TextBox textBoxSystemReferenceDisplayName;
        
        private System.Windows.Forms.Label labelSystemReferenceDisplayName;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSystemReferenceTableName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceTableName = new System.Windows.Forms.TextBox();
            this.labelSystemReferenceDisplayName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceDisplayName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.SuspendLayout();
            //
            // labelSystemReferenceTableName
            //
            this.labelSystemReferenceTableName.AutoSize = true;
            this.labelSystemReferenceTableName.Location = new System.Drawing.Point(11, 13);
            this.labelSystemReferenceTableName.Name = "labelSystemReferenceTableName";
            this.labelSystemReferenceTableName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemReferenceTableName.TabIndex = 2;
            this.labelSystemReferenceTableName.Text = "System Reference Table Name:";
            //
            //textBoxSystemReferenceTableName
            //
            this.textBoxSystemReferenceTableName.Location = new System.Drawing.Point(203, 13);
            this.textBoxSystemReferenceTableName.Name = "textBoxSystemReferenceTableName";
            this.textBoxSystemReferenceTableName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemReferenceTableName.TabIndex = 3;
            //
            // labelSystemReferenceDisplayName
            //
            this.labelSystemReferenceDisplayName.AutoSize = true;
            this.labelSystemReferenceDisplayName.Location = new System.Drawing.Point(11, 36);
            this.labelSystemReferenceDisplayName.Name = "labelSystemReferenceDisplayName";
            this.labelSystemReferenceDisplayName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemReferenceDisplayName.TabIndex = 4;
            this.labelSystemReferenceDisplayName.Text = "System Reference Display Name:";
            //
            //textBoxSystemReferenceDisplayName
            //
            this.textBoxSystemReferenceDisplayName.Location = new System.Drawing.Point(203, 36);
            this.textBoxSystemReferenceDisplayName.Name = "textBoxSystemReferenceDisplayName";
            this.textBoxSystemReferenceDisplayName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemReferenceDisplayName.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 59);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
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
            this.userPicker.Location = new System.Drawing.Point(203, 82);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(261, 105);
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
            this.ClientSize = new System.Drawing.Size(475, 128);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeSystemReferenceTableEdit";
            this.Text = "System Reference Table Edit";
            this.Controls.Add(this.labelSystemReferenceTableName);
            this.Controls.Add(this.textBoxSystemReferenceTableName);
            this.Controls.Add(this.labelSystemReferenceDisplayName);
            this.Controls.Add(this.textBoxSystemReferenceDisplayName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
