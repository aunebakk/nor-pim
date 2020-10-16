namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeClientSearch;

        private System.Windows.Forms.Button buttonCrudeClientAdd;

        private System.Windows.Forms.Button buttonCrudeClientEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeClient;

        private System.Windows.Forms.TextBox textBoxFirstName;

        private System.Windows.Forms.Label labelFirstName;

        private System.Windows.Forms.TextBox textBoxMiddleName;

        private System.Windows.Forms.Label labelMiddleName;

        private System.Windows.Forms.TextBox textBoxLastName;

        private System.Windows.Forms.Label labelLastName;

        private ClientTypeRefCombo clientTypeRefCombo;

        private System.Windows.Forms.Label labelClientTypeRefCombo;

        private ClientNationalityRefCombo clientNationalityRefCombo;

        private System.Windows.Forms.Label labelClientNationalityRefCombo;

        private ClientGenderRefCombo clientGenderRefCombo;

        private System.Windows.Forms.Label labelClientGenderRefCombo;

        private ClientTitleRefCombo clientTitleRefCombo;

        private System.Windows.Forms.Label labelClientTitleRefCombo;

        private System.Windows.Forms.TextBox textBoxImageBlobFilename;

        private System.Windows.Forms.Label labelImageBlobFilename;

        private System.Windows.Forms.PictureBox pictureBoxImage;

        private System.Windows.Forms.Label labelImage;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeClientAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClient = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelClientTypeRefCombo = new System.Windows.Forms.Label();
            this.clientTypeRefCombo = new ClientTypeRefCombo();
            this.labelClientNationalityRefCombo = new System.Windows.Forms.Label();
            this.clientNationalityRefCombo = new ClientNationalityRefCombo();
            this.labelClientGenderRefCombo = new System.Windows.Forms.Label();
            this.clientGenderRefCombo = new ClientGenderRefCombo();
            this.labelClientTitleRefCombo = new System.Windows.Forms.Label();
            this.clientTitleRefCombo = new ClientTitleRefCombo();
            this.labelImageBlobFilename = new System.Windows.Forms.Label();
            this.textBoxImageBlobFilename = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClient)).BeginInit();
            this.SuspendLayout();
            //
            // labelFirstName
            //
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            //
            //textBoxFirstName
            //
            this.textBoxFirstName.Location = new System.Drawing.Point(140, 13);
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFirstName.TabIndex = 3;
            //
            // labelMiddleName
            //
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(11, 36);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 13);
            this.labelMiddleName.TabIndex = 4;
            this.labelMiddleName.Text = "Middle Name:";
            //
            //textBoxMiddleName
            //
            this.textBoxMiddleName.Location = new System.Drawing.Point(140, 36);
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxMiddleName.TabIndex = 5;
            //
            // labelLastName
            //
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name:";
            //
            //textBoxLastName
            //
            this.textBoxLastName.Location = new System.Drawing.Point(140, 59);
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLastName.TabIndex = 7;
            //
            // labelClientTypeRefCombo
            //
            this.labelClientTypeRefCombo.AutoSize = true;
            this.labelClientTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelClientTypeRefCombo.Name = "labelClientTypeRefCombo";
            this.labelClientTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientTypeRefCombo.TabIndex = 8;
            this.labelClientTypeRefCombo.Text = "Client Type:";
            //
            //clientTypeRefCombo
            //
            this.clientTypeRefCombo.Location = new System.Drawing.Point(140, 82);
            this.clientTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTypeRefCombo.Name = "clientTypeRefCombo";
            this.clientTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientTypeRefCombo.TabIndex = 9;
            //
            // labelClientNationalityRefCombo
            //
            this.labelClientNationalityRefCombo.AutoSize = true;
            this.labelClientNationalityRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelClientNationalityRefCombo.Name = "labelClientNationalityRefCombo";
            this.labelClientNationalityRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityRefCombo.TabIndex = 10;
            this.labelClientNationalityRefCombo.Text = "Client Nationality:";
            //
            //clientNationalityRefCombo
            //
            this.clientNationalityRefCombo.Location = new System.Drawing.Point(140, 105);
            this.clientNationalityRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNationalityRefCombo.Name = "clientNationalityRefCombo";
            this.clientNationalityRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientNationalityRefCombo.TabIndex = 11;
            //
            // labelClientGenderRefCombo
            //
            this.labelClientGenderRefCombo.AutoSize = true;
            this.labelClientGenderRefCombo.Location = new System.Drawing.Point(11, 128);
            this.labelClientGenderRefCombo.Name = "labelClientGenderRefCombo";
            this.labelClientGenderRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderRefCombo.TabIndex = 12;
            this.labelClientGenderRefCombo.Text = "Client Gender:";
            //
            //clientGenderRefCombo
            //
            this.clientGenderRefCombo.Location = new System.Drawing.Point(140, 128);
            this.clientGenderRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGenderRefCombo.Name = "clientGenderRefCombo";
            this.clientGenderRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientGenderRefCombo.TabIndex = 13;
            //
            // labelClientTitleRefCombo
            //
            this.labelClientTitleRefCombo.AutoSize = true;
            this.labelClientTitleRefCombo.Location = new System.Drawing.Point(11, 151);
            this.labelClientTitleRefCombo.Name = "labelClientTitleRefCombo";
            this.labelClientTitleRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleRefCombo.TabIndex = 14;
            this.labelClientTitleRefCombo.Text = "Client Title:";
            //
            //clientTitleRefCombo
            //
            this.clientTitleRefCombo.Location = new System.Drawing.Point(140, 151);
            this.clientTitleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientTitleRefCombo.Name = "clientTitleRefCombo";
            this.clientTitleRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientTitleRefCombo.TabIndex = 15;
            //
            // labelImageBlobFilename
            //
            this.labelImageBlobFilename.AutoSize = true;
            this.labelImageBlobFilename.Location = new System.Drawing.Point(11, 174);
            this.labelImageBlobFilename.Name = "labelImageBlobFilename";
            this.labelImageBlobFilename.Size = new System.Drawing.Size(71, 13);
            this.labelImageBlobFilename.TabIndex = 16;
            this.labelImageBlobFilename.Text = "Image Blob Filename:";
            //
            //textBoxImageBlobFilename
            //
            this.textBoxImageBlobFilename.Location = new System.Drawing.Point(140, 174);
            this.textBoxImageBlobFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageBlobFilename.Name = "textBoxImageBlobFilename";
            this.textBoxImageBlobFilename.Size = new System.Drawing.Size(250, 20);
            this.textBoxImageBlobFilename.TabIndex = 17;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 197);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 18;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(140, 197);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 19;
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
            // dataGridViewCrudeClient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClient.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewCrudeClient.Name = "dataGridViewCrudeClient";
            this.dataGridViewCrudeClient.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClient.TabIndex = 0;
            this.dataGridViewCrudeClient.ReadOnly = true;
            this.dataGridViewCrudeClient.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClient_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 356);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientSearch
            // 
            this.buttonCrudeClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientSearch.Location = new System.Drawing.Point(198, 356);
            this.buttonCrudeClientSearch.Name = "buttonCrudeClientSearch";
            this.buttonCrudeClientSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientSearch.TabIndex = 2;
            this.buttonCrudeClientSearch.Text = "&Search";
            this.buttonCrudeClientSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientSearch.Click += new System.EventHandler(this.buttonCrudeClientSearch_Click);
            // 
            // buttonCrudeClientAdd
            // 
            this.buttonCrudeClientAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientAdd.Location = new System.Drawing.Point(98, 356);
            this.buttonCrudeClientAdd.Name = "buttonCrudeClientAdd";
            this.buttonCrudeClientAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientAdd.TabIndex = 3;
            this.buttonCrudeClientAdd.Text = "&Add";
            this.buttonCrudeClientAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAdd.Click += new System.EventHandler(this.buttonCrudeClientAdd_Click);
            // 
            // buttonCrudeClientEdit
            // 
            this.buttonCrudeClientEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEdit.Location = new System.Drawing.Point(-2, 356);
            this.buttonCrudeClientEdit.Name = "buttonCrudeClientEdit";
            this.buttonCrudeClientEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEdit.TabIndex = 4;
            this.buttonCrudeClientEdit.Text = "&Edit";
            this.buttonCrudeClientEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEdit.Click += new System.EventHandler(this.buttonCrudeClientEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 384);
            this.Controls.Add(this.buttonCrudeClientSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientAdd);
            this.Controls.Add(this.buttonCrudeClientEdit);
            this.Controls.Add(this.dataGridViewCrudeClient);
            this.Name = "CrudeClientSearch";
            this.Text = "Client Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClient)).EndInit();
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelClientTypeRefCombo);
            this.Controls.Add(this.clientTypeRefCombo);
            this.Controls.Add(this.labelClientNationalityRefCombo);
            this.Controls.Add(this.clientNationalityRefCombo);
            this.Controls.Add(this.labelClientGenderRefCombo);
            this.Controls.Add(this.clientGenderRefCombo);
            this.Controls.Add(this.labelClientTitleRefCombo);
            this.Controls.Add(this.clientTitleRefCombo);
            this.Controls.Add(this.labelImageBlobFilename);
            this.Controls.Add(this.textBoxImageBlobFilename);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
