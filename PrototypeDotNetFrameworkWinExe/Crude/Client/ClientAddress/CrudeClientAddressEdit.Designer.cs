namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientAddressEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ClientAddressTypeRefCombo clientAddressTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientAddressTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAddressLineOneName;
        
        private System.Windows.Forms.Label labelAddressLineOneName;
        
        private System.Windows.Forms.TextBox textBoxAddressLineTwoName;
        
        private System.Windows.Forms.Label labelAddressLineTwoName;
        
        private System.Windows.Forms.TextBox textBoxAddressLineThreeName;
        
        private System.Windows.Forms.Label labelAddressLineThreeName;
        
        private System.Windows.Forms.TextBox textBoxCityName;
        
        private System.Windows.Forms.Label labelCityName;
        
        private System.Windows.Forms.TextBox textBoxStreetName;
        
        private System.Windows.Forms.Label labelStreetName;
        
        private System.Windows.Forms.TextBox textBoxStateName;
        
        private System.Windows.Forms.Label labelStateName;
        
        private System.Windows.Forms.TextBox textBoxDistrictName;
        
        private System.Windows.Forms.Label labelDistrictName;
        
        private System.Windows.Forms.TextBox textBoxProvinceName;
        
        private System.Windows.Forms.Label labelProvinceName;
        
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
            this.labelClientAddressTypeRefCombo = new System.Windows.Forms.Label();
            this.clientAddressTypeRefCombo = new ClientAddressTypeRefCombo();
            this.labelAddressLineOneName = new System.Windows.Forms.Label();
            this.textBoxAddressLineOneName = new System.Windows.Forms.TextBox();
            this.labelAddressLineTwoName = new System.Windows.Forms.Label();
            this.textBoxAddressLineTwoName = new System.Windows.Forms.TextBox();
            this.labelAddressLineThreeName = new System.Windows.Forms.Label();
            this.textBoxAddressLineThreeName = new System.Windows.Forms.TextBox();
            this.labelCityName = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.labelStreetName = new System.Windows.Forms.Label();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.labelStateName = new System.Windows.Forms.Label();
            this.textBoxStateName = new System.Windows.Forms.TextBox();
            this.labelDistrictName = new System.Windows.Forms.Label();
            this.textBoxDistrictName = new System.Windows.Forms.TextBox();
            this.labelProvinceName = new System.Windows.Forms.Label();
            this.textBoxProvinceName = new System.Windows.Forms.TextBox();
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
            // labelClientAddressTypeRefCombo
            //
            this.labelClientAddressTypeRefCombo.AutoSize = true;
            this.labelClientAddressTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientAddressTypeRefCombo.Name = "labelClientAddressTypeRefCombo";
            this.labelClientAddressTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressTypeRefCombo.TabIndex = 2;
            this.labelClientAddressTypeRefCombo.Text = "Client Address Type:";
            //
            //clientAddressTypeRefCombo
            //
            this.clientAddressTypeRefCombo.Location = new System.Drawing.Point(161, 13);
            this.clientAddressTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientAddressTypeRefCombo.Name = "clientAddressTypeRefCombo";
            this.clientAddressTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientAddressTypeRefCombo.TabIndex = 3;
            //
            // labelAddressLineOneName
            //
            this.labelAddressLineOneName.AutoSize = true;
            this.labelAddressLineOneName.Location = new System.Drawing.Point(11, 36);
            this.labelAddressLineOneName.Name = "labelAddressLineOneName";
            this.labelAddressLineOneName.Size = new System.Drawing.Size(71, 13);
            this.labelAddressLineOneName.TabIndex = 4;
            this.labelAddressLineOneName.Text = "Address Line One Name:";
            //
            //textBoxAddressLineOneName
            //
            this.textBoxAddressLineOneName.Location = new System.Drawing.Point(161, 36);
            this.textBoxAddressLineOneName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressLineOneName.Name = "textBoxAddressLineOneName";
            this.textBoxAddressLineOneName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressLineOneName.TabIndex = 5;
            //
            // labelAddressLineTwoName
            //
            this.labelAddressLineTwoName.AutoSize = true;
            this.labelAddressLineTwoName.Location = new System.Drawing.Point(11, 59);
            this.labelAddressLineTwoName.Name = "labelAddressLineTwoName";
            this.labelAddressLineTwoName.Size = new System.Drawing.Size(71, 13);
            this.labelAddressLineTwoName.TabIndex = 6;
            this.labelAddressLineTwoName.Text = "Address Line Two Name:";
            //
            //textBoxAddressLineTwoName
            //
            this.textBoxAddressLineTwoName.Location = new System.Drawing.Point(161, 59);
            this.textBoxAddressLineTwoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressLineTwoName.Name = "textBoxAddressLineTwoName";
            this.textBoxAddressLineTwoName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressLineTwoName.TabIndex = 7;
            //
            // labelAddressLineThreeName
            //
            this.labelAddressLineThreeName.AutoSize = true;
            this.labelAddressLineThreeName.Location = new System.Drawing.Point(11, 82);
            this.labelAddressLineThreeName.Name = "labelAddressLineThreeName";
            this.labelAddressLineThreeName.Size = new System.Drawing.Size(71, 13);
            this.labelAddressLineThreeName.TabIndex = 8;
            this.labelAddressLineThreeName.Text = "Address Line Three Name:";
            //
            //textBoxAddressLineThreeName
            //
            this.textBoxAddressLineThreeName.Location = new System.Drawing.Point(161, 82);
            this.textBoxAddressLineThreeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressLineThreeName.Name = "textBoxAddressLineThreeName";
            this.textBoxAddressLineThreeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressLineThreeName.TabIndex = 9;
            //
            // labelCityName
            //
            this.labelCityName.AutoSize = true;
            this.labelCityName.Location = new System.Drawing.Point(11, 105);
            this.labelCityName.Name = "labelCityName";
            this.labelCityName.Size = new System.Drawing.Size(71, 13);
            this.labelCityName.TabIndex = 10;
            this.labelCityName.Text = "City Name:";
            //
            //textBoxCityName
            //
            this.textBoxCityName.Location = new System.Drawing.Point(161, 105);
            this.textBoxCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCityName.TabIndex = 11;
            //
            // labelStreetName
            //
            this.labelStreetName.AutoSize = true;
            this.labelStreetName.Location = new System.Drawing.Point(11, 128);
            this.labelStreetName.Name = "labelStreetName";
            this.labelStreetName.Size = new System.Drawing.Size(71, 13);
            this.labelStreetName.TabIndex = 12;
            this.labelStreetName.Text = "Street Name:";
            //
            //textBoxStreetName
            //
            this.textBoxStreetName.Location = new System.Drawing.Point(161, 128);
            this.textBoxStreetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(250, 20);
            this.textBoxStreetName.TabIndex = 13;
            //
            // labelStateName
            //
            this.labelStateName.AutoSize = true;
            this.labelStateName.Location = new System.Drawing.Point(11, 151);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(71, 13);
            this.labelStateName.TabIndex = 14;
            this.labelStateName.Text = "State Name:";
            //
            //textBoxStateName
            //
            this.textBoxStateName.Location = new System.Drawing.Point(161, 151);
            this.textBoxStateName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStateName.Name = "textBoxStateName";
            this.textBoxStateName.Size = new System.Drawing.Size(250, 20);
            this.textBoxStateName.TabIndex = 15;
            //
            // labelDistrictName
            //
            this.labelDistrictName.AutoSize = true;
            this.labelDistrictName.Location = new System.Drawing.Point(11, 174);
            this.labelDistrictName.Name = "labelDistrictName";
            this.labelDistrictName.Size = new System.Drawing.Size(71, 13);
            this.labelDistrictName.TabIndex = 16;
            this.labelDistrictName.Text = "District Name:";
            //
            //textBoxDistrictName
            //
            this.textBoxDistrictName.Location = new System.Drawing.Point(161, 174);
            this.textBoxDistrictName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistrictName.Name = "textBoxDistrictName";
            this.textBoxDistrictName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDistrictName.TabIndex = 17;
            //
            // labelProvinceName
            //
            this.labelProvinceName.AutoSize = true;
            this.labelProvinceName.Location = new System.Drawing.Point(11, 197);
            this.labelProvinceName.Name = "labelProvinceName";
            this.labelProvinceName.Size = new System.Drawing.Size(71, 13);
            this.labelProvinceName.TabIndex = 18;
            this.labelProvinceName.Text = "Province Name:";
            //
            //textBoxProvinceName
            //
            this.textBoxProvinceName.Location = new System.Drawing.Point(161, 197);
            this.textBoxProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProvinceName.Name = "textBoxProvinceName";
            this.textBoxProvinceName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProvinceName.TabIndex = 19;
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
            this.textBoxZipCode.Location = new System.Drawing.Point(161, 220);
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
            this.textBoxPoBox.Location = new System.Drawing.Point(161, 243);
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
            this.textBoxComment.Location = new System.Drawing.Point(161, 266);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 289);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 27;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 312);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 312);
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
            this.ClientSize = new System.Drawing.Size(423, 340);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientAddressEdit";
            this.Text = "Client Address Edit";
            this.Controls.Add(this.labelClientAddressTypeRefCombo);
            this.Controls.Add(this.clientAddressTypeRefCombo);
            this.Controls.Add(this.labelAddressLineOneName);
            this.Controls.Add(this.textBoxAddressLineOneName);
            this.Controls.Add(this.labelAddressLineTwoName);
            this.Controls.Add(this.textBoxAddressLineTwoName);
            this.Controls.Add(this.labelAddressLineThreeName);
            this.Controls.Add(this.textBoxAddressLineThreeName);
            this.Controls.Add(this.labelCityName);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelStreetName);
            this.Controls.Add(this.textBoxStreetName);
            this.Controls.Add(this.labelStateName);
            this.Controls.Add(this.textBoxStateName);
            this.Controls.Add(this.labelDistrictName);
            this.Controls.Add(this.textBoxDistrictName);
            this.Controls.Add(this.labelProvinceName);
            this.Controls.Add(this.textBoxProvinceName);
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
