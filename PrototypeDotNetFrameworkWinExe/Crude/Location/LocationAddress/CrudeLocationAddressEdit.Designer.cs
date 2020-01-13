namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private LocationAddressTypeRefCombo locationAddressTypeRefCombo;
        
        private System.Windows.Forms.Label labelLocationAddressTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAddressOne;
        
        private System.Windows.Forms.Label labelAddressOne;
        
        private System.Windows.Forms.TextBox textBoxAddressTwo;
        
        private System.Windows.Forms.Label labelAddressTwo;
        
        private System.Windows.Forms.TextBox textBoxAddressThree;
        
        private System.Windows.Forms.Label labelAddressThree;
        
        private System.Windows.Forms.TextBox textBoxCity;
        
        private System.Windows.Forms.Label labelCity;
        
        private System.Windows.Forms.TextBox textBoxStreet;
        
        private System.Windows.Forms.Label labelStreet;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
        private System.Windows.Forms.TextBox textBoxDistrict;
        
        private System.Windows.Forms.Label labelDistrict;
        
        private System.Windows.Forms.TextBox textBoxProvince;
        
        private System.Windows.Forms.Label labelProvince;
        
        private System.Windows.Forms.TextBox textBoxZipCode;
        
        private System.Windows.Forms.Label labelZipCode;
        
        private System.Windows.Forms.TextBox textBoxPoBox;
        
        private System.Windows.Forms.Label labelPoBox;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
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
            this.labelLocationAddressTypeRefCombo = new System.Windows.Forms.Label();
            this.locationAddressTypeRefCombo = new LocationAddressTypeRefCombo();
            this.labelAddressOne = new System.Windows.Forms.Label();
            this.textBoxAddressOne = new System.Windows.Forms.TextBox();
            this.labelAddressTwo = new System.Windows.Forms.Label();
            this.textBoxAddressTwo = new System.Windows.Forms.TextBox();
            this.labelAddressThree = new System.Windows.Forms.Label();
            this.textBoxAddressThree = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelPoBox = new System.Windows.Forms.Label();
            this.textBoxPoBox = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLocationAddressTypeRefCombo
            //
            this.labelLocationAddressTypeRefCombo.AutoSize = true;
            this.labelLocationAddressTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelLocationAddressTypeRefCombo.Name = "labelLocationAddressTypeRefCombo";
            this.labelLocationAddressTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLocationAddressTypeRefCombo.TabIndex = 2;
            this.labelLocationAddressTypeRefCombo.Text = "Location Address Type:";
            //
            //locationAddressTypeRefCombo
            //
            this.locationAddressTypeRefCombo.Location = new System.Drawing.Point(147, 13);
            this.locationAddressTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.locationAddressTypeRefCombo.Name = "locationAddressTypeRefCombo";
            this.locationAddressTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.locationAddressTypeRefCombo.TabIndex = 3;
            //
            // labelAddressOne
            //
            this.labelAddressOne.AutoSize = true;
            this.labelAddressOne.Location = new System.Drawing.Point(11, 36);
            this.labelAddressOne.Name = "labelAddressOne";
            this.labelAddressOne.Size = new System.Drawing.Size(71, 13);
            this.labelAddressOne.TabIndex = 4;
            this.labelAddressOne.Text = "Address One:";
            //
            //textBoxAddressOne
            //
            this.textBoxAddressOne.Location = new System.Drawing.Point(147, 36);
            this.textBoxAddressOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressOne.Name = "textBoxAddressOne";
            this.textBoxAddressOne.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressOne.TabIndex = 5;
            //
            // labelAddressTwo
            //
            this.labelAddressTwo.AutoSize = true;
            this.labelAddressTwo.Location = new System.Drawing.Point(11, 59);
            this.labelAddressTwo.Name = "labelAddressTwo";
            this.labelAddressTwo.Size = new System.Drawing.Size(71, 13);
            this.labelAddressTwo.TabIndex = 6;
            this.labelAddressTwo.Text = "Address Two:";
            //
            //textBoxAddressTwo
            //
            this.textBoxAddressTwo.Location = new System.Drawing.Point(147, 59);
            this.textBoxAddressTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressTwo.Name = "textBoxAddressTwo";
            this.textBoxAddressTwo.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressTwo.TabIndex = 7;
            //
            // labelAddressThree
            //
            this.labelAddressThree.AutoSize = true;
            this.labelAddressThree.Location = new System.Drawing.Point(11, 82);
            this.labelAddressThree.Name = "labelAddressThree";
            this.labelAddressThree.Size = new System.Drawing.Size(71, 13);
            this.labelAddressThree.TabIndex = 8;
            this.labelAddressThree.Text = "Address Three:";
            //
            //textBoxAddressThree
            //
            this.textBoxAddressThree.Location = new System.Drawing.Point(147, 82);
            this.textBoxAddressThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressThree.Name = "textBoxAddressThree";
            this.textBoxAddressThree.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressThree.TabIndex = 9;
            //
            // labelCity
            //
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(11, 105);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(71, 13);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "City:";
            //
            //textBoxCity
            //
            this.textBoxCity.Location = new System.Drawing.Point(147, 105);
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(250, 20);
            this.textBoxCity.TabIndex = 11;
            //
            // labelStreet
            //
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(11, 128);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(71, 13);
            this.labelStreet.TabIndex = 12;
            this.labelStreet.Text = "Street:";
            //
            //textBoxStreet
            //
            this.textBoxStreet.Location = new System.Drawing.Point(147, 128);
            this.textBoxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(250, 20);
            this.textBoxStreet.TabIndex = 13;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 151);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 14;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(147, 151);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 15;
            //
            // labelDistrict
            //
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(11, 174);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(71, 13);
            this.labelDistrict.TabIndex = 16;
            this.labelDistrict.Text = "District:";
            //
            //textBoxDistrict
            //
            this.textBoxDistrict.Location = new System.Drawing.Point(147, 174);
            this.textBoxDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(250, 20);
            this.textBoxDistrict.TabIndex = 17;
            //
            // labelProvince
            //
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(11, 197);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(71, 13);
            this.labelProvince.TabIndex = 18;
            this.labelProvince.Text = "Province:";
            //
            //textBoxProvince
            //
            this.textBoxProvince.Location = new System.Drawing.Point(147, 197);
            this.textBoxProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(250, 20);
            this.textBoxProvince.TabIndex = 19;
            //
            // labelZipCode
            //
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(11, 220);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(71, 13);
            this.labelZipCode.TabIndex = 20;
            this.labelZipCode.Text = "Zip Code:";
            //
            //textBoxZipCode
            //
            this.textBoxZipCode.Location = new System.Drawing.Point(147, 220);
            this.textBoxZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxZipCode.TabIndex = 21;
            //
            // labelPoBox
            //
            this.labelPoBox.AutoSize = true;
            this.labelPoBox.Location = new System.Drawing.Point(11, 243);
            this.labelPoBox.Name = "labelPoBox";
            this.labelPoBox.Size = new System.Drawing.Size(71, 13);
            this.labelPoBox.TabIndex = 22;
            this.labelPoBox.Text = "Po Box:";
            //
            //textBoxPoBox
            //
            this.textBoxPoBox.Location = new System.Drawing.Point(147, 243);
            this.textBoxPoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoBox.Name = "textBoxPoBox";
            this.textBoxPoBox.Size = new System.Drawing.Size(250, 20);
            this.textBoxPoBox.TabIndex = 23;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 266);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 24;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(147, 266);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 25;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 289);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 26;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 289);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 27;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 312);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 312);
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
            this.ClientSize = new System.Drawing.Size(409, 340);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeLocationAddressEdit";
            this.Text = "Location Address Edit";
            this.Controls.Add(this.labelLocationAddressTypeRefCombo);
            this.Controls.Add(this.locationAddressTypeRefCombo);
            this.Controls.Add(this.labelAddressOne);
            this.Controls.Add(this.textBoxAddressOne);
            this.Controls.Add(this.labelAddressTwo);
            this.Controls.Add(this.textBoxAddressTwo);
            this.Controls.Add(this.labelAddressThree);
            this.Controls.Add(this.textBoxAddressThree);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDistrict);
            this.Controls.Add(this.textBoxDistrict);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.labelPoBox);
            this.Controls.Add(this.textBoxPoBox);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
