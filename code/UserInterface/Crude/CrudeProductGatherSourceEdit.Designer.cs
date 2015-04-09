namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ProductGatherSourceTypeRefCombo productGatherSourceTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeRefCombo;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelProductGatherSourceTypeRefCombo = new System.Windows.Forms.Label();
            this.productGatherSourceTypeRefCombo = new ProductGatherSourceTypeRefCombo();
            this.SuspendLayout();
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 13);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 2;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(182, 13);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 36);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelProductGatherSourceTypeRefCombo
            //
            this.labelProductGatherSourceTypeRefCombo.AutoSize = true;
            this.labelProductGatherSourceTypeRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelProductGatherSourceTypeRefCombo.Name = "labelProductGatherSourceTypeRefCombo";
            this.labelProductGatherSourceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeRefCombo.TabIndex = 6;
            this.labelProductGatherSourceTypeRefCombo.Text = "Product Gather Source Type:";
            //
            //productGatherSourceTypeRefCombo
            //
            this.productGatherSourceTypeRefCombo.Location = new System.Drawing.Point(182, 59);
            this.productGatherSourceTypeRefCombo.Name = "productGatherSourceTypeRefCombo";
            this.productGatherSourceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productGatherSourceTypeRefCombo.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(240, 82);
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
            this.ClientSize = new System.Drawing.Size(454, 105);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductGatherSourceEdit";
            this.Text = "Product Gather Source Edit";
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelProductGatherSourceTypeRefCombo);
            this.Controls.Add(this.productGatherSourceTypeRefCombo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
