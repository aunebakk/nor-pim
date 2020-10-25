namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ClientTypeRefCombo clientTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientTypeRefCombo;
        
        private ClientNationalityRefCombo clientNationalityRefCombo;
        
        private System.Windows.Forms.Label labelClientNationalityRefCombo;
        
        private ClientGenderRefCombo clientGenderRefCombo;
        
        private System.Windows.Forms.Label labelClientGenderRefCombo;
        
        private ClientTitleRefCombo clientTitleRefCombo;
        
        private System.Windows.Forms.Label labelClientTitleRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFirstName;
        
        private System.Windows.Forms.Label labelFirstName;
        
        private System.Windows.Forms.TextBox textBoxMiddleName;
        
        private System.Windows.Forms.Label labelMiddleName;
        
        private System.Windows.Forms.TextBox textBoxLastName;
        
        private System.Windows.Forms.Label labelLastName;
        
        private System.Windows.Forms.PictureBox pictureBoxImage;
        
        private System.Windows.Forms.Label labelImage;
        
        private System.Windows.Forms.TextBox textBoxImageBlobFilename;
        
        private System.Windows.Forms.Label labelImageBlobFilename;
        
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
            this.labelClientTypeRefCombo = new System.Windows.Forms.Label();
            this.clientTypeRefCombo = new ClientTypeRefCombo();
            this.labelClientNationalityRefCombo = new System.Windows.Forms.Label();
            this.clientNationalityRefCombo = new ClientNationalityRefCombo();
            this.labelClientGenderRefCombo = new System.Windows.Forms.Label();
            this.clientGenderRefCombo = new ClientGenderRefCombo();
            this.labelClientTitleRefCombo = new System.Windows.Forms.Label();
            this.clientTitleRefCombo = new ClientTitleRefCombo();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelImageBlobFilename = new System.Windows.Forms.Label();
            this.textBoxImageBlobFilename = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientTypeRefCombo
            //
            this.labelClientTypeRefCombo.AutoSize = true;
            this.labelClientTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientTypeRefCombo.Name = "labelClientTypeRefCombo";
            this.labelClientTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeRefCombo.TabIndex = 2;
            this.labelClientTypeRefCombo.Text = "Client Type:";
            //
            //clientTypeRefCombo
            //
            this.clientTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.clientTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTypeRefCombo.Name = "clientTypeRefCombo";
            this.clientTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientTypeRefCombo.TabIndex = 3;
            //
            // labelClientNationalityRefCombo
            //
            this.labelClientNationalityRefCombo.AutoSize = true;
            this.labelClientNationalityRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelClientNationalityRefCombo.Name = "labelClientNationalityRefCombo";
            this.labelClientNationalityRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityRefCombo.TabIndex = 4;
            this.labelClientNationalityRefCombo.Text = "Client Nationality:";
            //
            //clientNationalityRefCombo
            //
            this.clientNationalityRefCombo.Location = new System.Drawing.Point(140, 36);
            this.clientNationalityRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNationalityRefCombo.Name = "clientNationalityRefCombo";
            this.clientNationalityRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientNationalityRefCombo.TabIndex = 5;
            //
            // labelClientGenderRefCombo
            //
            this.labelClientGenderRefCombo.AutoSize = true;
            this.labelClientGenderRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelClientGenderRefCombo.Name = "labelClientGenderRefCombo";
            this.labelClientGenderRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderRefCombo.TabIndex = 6;
            this.labelClientGenderRefCombo.Text = "Client Gender:";
            //
            //clientGenderRefCombo
            //
            this.clientGenderRefCombo.Location = new System.Drawing.Point(140, 59);
            this.clientGenderRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGenderRefCombo.Name = "clientGenderRefCombo";
            this.clientGenderRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientGenderRefCombo.TabIndex = 7;
            //
            // labelClientTitleRefCombo
            //
            this.labelClientTitleRefCombo.AutoSize = true;
            this.labelClientTitleRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelClientTitleRefCombo.Name = "labelClientTitleRefCombo";
            this.labelClientTitleRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleRefCombo.TabIndex = 8;
            this.labelClientTitleRefCombo.Text = "Client Title:";
            //
            //clientTitleRefCombo
            //
            this.clientTitleRefCombo.Location = new System.Drawing.Point(140, 82);
            this.clientTitleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTitleRefCombo.Name = "clientTitleRefCombo";
            this.clientTitleRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientTitleRefCombo.TabIndex = 9;
            //
            // labelFirstName
            //
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 105);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name:";
            //
            //textBoxFirstName
            //
            this.textBoxFirstName.Location = new System.Drawing.Point(140, 105);
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFirstName.TabIndex = 11;
            //
            // labelMiddleName
            //
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(11, 128);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 13);
            this.labelMiddleName.TabIndex = 12;
            this.labelMiddleName.Text = "Middle Name:";
            //
            //textBoxMiddleName
            //
            this.textBoxMiddleName.Location = new System.Drawing.Point(140, 128);
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxMiddleName.TabIndex = 13;
            //
            // labelLastName
            //
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 151);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 13);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Last Name:";
            //
            //textBoxLastName
            //
            this.textBoxLastName.Location = new System.Drawing.Point(140, 151);
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLastName.TabIndex = 15;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 174);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 16;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(140, 174);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 17;
            //
            // labelImageBlobFilename
            //
            this.labelImageBlobFilename.AutoSize = true;
            this.labelImageBlobFilename.Location = new System.Drawing.Point(11, 197);
            this.labelImageBlobFilename.Name = "labelImageBlobFilename";
            this.labelImageBlobFilename.Size = new System.Drawing.Size(71, 13);
            this.labelImageBlobFilename.TabIndex = 18;
            this.labelImageBlobFilename.Text = "Image Blob Filename:";
            //
            //textBoxImageBlobFilename
            //
            this.textBoxImageBlobFilename.Location = new System.Drawing.Point(140, 197);
            this.textBoxImageBlobFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageBlobFilename.Name = "textBoxImageBlobFilename";
            this.textBoxImageBlobFilename.Size = new System.Drawing.Size(250, 20);
            this.textBoxImageBlobFilename.TabIndex = 19;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 220);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 20;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 220);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 243);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 243);
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
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientEdit";
            this.Text = "Client Edit";
            this.Controls.Add(this.labelClientTypeRefCombo);
            this.Controls.Add(this.clientTypeRefCombo);
            this.Controls.Add(this.labelClientNationalityRefCombo);
            this.Controls.Add(this.clientNationalityRefCombo);
            this.Controls.Add(this.labelClientGenderRefCombo);
            this.Controls.Add(this.clientGenderRefCombo);
            this.Controls.Add(this.labelClientTitleRefCombo);
            this.Controls.Add(this.clientTitleRefCombo);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelImageBlobFilename);
            this.Controls.Add(this.textBoxImageBlobFilename);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
