namespace SolutionNorSolutionPim.UserInterface {


    public partial class ClientEdit {

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
            this.clientTypeRefCombo = new SolutionNorSolutionPim.UserInterface.ClientTypeRefCombo();
            this.labelClientNationalityRefCombo = new System.Windows.Forms.Label();
            this.clientNationalityRefCombo = new SolutionNorSolutionPim.UserInterface.ClientNationalityRefCombo();
            this.labelClientGenderRefCombo = new System.Windows.Forms.Label();
            this.clientGenderRefCombo = new SolutionNorSolutionPim.UserInterface.ClientGenderRefCombo();
            this.labelClientTitleRefCombo = new System.Windows.Forms.Label();
            this.clientTitleRefCombo = new SolutionNorSolutionPim.UserInterface.ClientTitleRefCombo();
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
            this.buttonImageLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1012, 588);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(138, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(862, 588);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelClientTypeRefCombo
            // 
            this.labelClientTypeRefCombo.AutoSize = true;
            this.labelClientTypeRefCombo.Location = new System.Drawing.Point(661, 9);
            this.labelClientTypeRefCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientTypeRefCombo.Name = "labelClientTypeRefCombo";
            this.labelClientTypeRefCombo.Size = new System.Drawing.Size(91, 20);
            this.labelClientTypeRefCombo.TabIndex = 2;
            this.labelClientTypeRefCombo.Text = "Client Type:";
            // 
            // clientTypeRefCombo
            // 
            this.clientTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTypeRefCombo.Location = new System.Drawing.Point(855, 9);
            this.clientTypeRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientTypeRefCombo.Name = "clientTypeRefCombo";
            this.clientTypeRefCombo.Size = new System.Drawing.Size(292, 31);
            this.clientTypeRefCombo.TabIndex = 3;
            // 
            // labelClientNationalityRefCombo
            // 
            this.labelClientNationalityRefCombo.AutoSize = true;
            this.labelClientNationalityRefCombo.Location = new System.Drawing.Point(661, 44);
            this.labelClientNationalityRefCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientNationalityRefCombo.Name = "labelClientNationalityRefCombo";
            this.labelClientNationalityRefCombo.Size = new System.Drawing.Size(130, 20);
            this.labelClientNationalityRefCombo.TabIndex = 4;
            this.labelClientNationalityRefCombo.Text = "Client Nationality:";
            // 
            // clientNationalityRefCombo
            // 
            this.clientNationalityRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNationalityRefCombo.Location = new System.Drawing.Point(855, 44);
            this.clientNationalityRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientNationalityRefCombo.Name = "clientNationalityRefCombo";
            this.clientNationalityRefCombo.Size = new System.Drawing.Size(292, 31);
            this.clientNationalityRefCombo.TabIndex = 5;
            // 
            // labelClientGenderRefCombo
            // 
            this.labelClientGenderRefCombo.AutoSize = true;
            this.labelClientGenderRefCombo.Location = new System.Drawing.Point(661, 80);
            this.labelClientGenderRefCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientGenderRefCombo.Name = "labelClientGenderRefCombo";
            this.labelClientGenderRefCombo.Size = new System.Drawing.Size(111, 20);
            this.labelClientGenderRefCombo.TabIndex = 6;
            this.labelClientGenderRefCombo.Text = "Client Gender:";
            // 
            // clientGenderRefCombo
            // 
            this.clientGenderRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGenderRefCombo.Location = new System.Drawing.Point(855, 80);
            this.clientGenderRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientGenderRefCombo.Name = "clientGenderRefCombo";
            this.clientGenderRefCombo.Size = new System.Drawing.Size(292, 31);
            this.clientGenderRefCombo.TabIndex = 7;
            // 
            // labelClientTitleRefCombo
            // 
            this.labelClientTitleRefCombo.AutoSize = true;
            this.labelClientTitleRefCombo.Location = new System.Drawing.Point(661, 115);
            this.labelClientTitleRefCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientTitleRefCombo.Name = "labelClientTitleRefCombo";
            this.labelClientTitleRefCombo.Size = new System.Drawing.Size(86, 20);
            this.labelClientTitleRefCombo.TabIndex = 8;
            this.labelClientTitleRefCombo.Text = "Client Title:";
            // 
            // clientTitleRefCombo
            // 
            this.clientTitleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTitleRefCombo.Location = new System.Drawing.Point(855, 115);
            this.clientTitleRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientTitleRefCombo.Name = "clientTitleRefCombo";
            this.clientTitleRefCombo.Size = new System.Drawing.Size(292, 31);
            this.clientTitleRefCombo.TabIndex = 9;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 9);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 20);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 9);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(442, 26);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(16, 44);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(105, 20);
            this.labelMiddleName.TabIndex = 12;
            this.labelMiddleName.Text = "Middle Name:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(210, 44);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(442, 26);
            this.textBoxMiddleName.TabIndex = 13;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 79);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 20);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 79);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(442, 26);
            this.textBoxLastName.TabIndex = 15;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(16, 184);
            this.labelImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(58, 20);
            this.labelImage.TabIndex = 16;
            this.labelImage.Text = "Image:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Location = new System.Drawing.Point(210, 187);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(937, 389);
            this.pictureBoxImage.TabIndex = 17;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelImageBlobFilename
            // 
            this.labelImageBlobFilename.AutoSize = true;
            this.labelImageBlobFilename.Location = new System.Drawing.Point(16, 149);
            this.labelImageBlobFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImageBlobFilename.Name = "labelImageBlobFilename";
            this.labelImageBlobFilename.Size = new System.Drawing.Size(163, 20);
            this.labelImageBlobFilename.TabIndex = 18;
            this.labelImageBlobFilename.Text = "Image Blob Filename:";
            // 
            // textBoxImageBlobFilename
            // 
            this.textBoxImageBlobFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageBlobFilename.Location = new System.Drawing.Point(209, 151);
            this.textBoxImageBlobFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImageBlobFilename.Name = "textBoxImageBlobFilename";
            this.textBoxImageBlobFilename.Size = new System.Drawing.Size(938, 26);
            this.textBoxImageBlobFilename.TabIndex = 19;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(16, 114);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(86, 20);
            this.labelDateTime.TabIndex = 20;
            this.labelDateTime.Text = "Date Time:";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 115);
            this.dateTimePickerDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(443, 26);
            this.dateTimePickerDateTime.TabIndex = 21;
            // 
            // buttonImageLoad
            // 
            this.buttonImageLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImageLoad.Location = new System.Drawing.Point(716, 588);
            this.buttonImageLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImageLoad.Name = "buttonImageLoad";
            this.buttonImageLoad.Size = new System.Drawing.Size(138, 34);
            this.buttonImageLoad.TabIndex = 22;
            this.buttonImageLoad.Text = "&Load Image";
            this.buttonImageLoad.UseVisualStyleBackColor = true;
            this.buttonImageLoad.Click += new System.EventHandler(this.buttonImageLoad_Click);
            // 
            // ClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 631);
            this.Controls.Add(this.buttonImageLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientEdit";
            this.Text = "Client Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonImageLoad;
    }
}
