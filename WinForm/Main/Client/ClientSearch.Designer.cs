namespace SolutionNorSolutionPim.UserInterface {


    public partial class ClientSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeClientSearch;

        private System.Windows.Forms.Button buttonCrudeClientAdd;

        private System.Windows.Forms.Button buttonCrudeClientEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeClient;

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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClient)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1023, 569);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(138, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientAdd
            // 
            this.buttonCrudeClientAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientAdd.Location = new System.Drawing.Point(723, 569);
            this.buttonCrudeClientAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrudeClientAdd.Name = "buttonCrudeClientAdd";
            this.buttonCrudeClientAdd.Size = new System.Drawing.Size(138, 34);
            this.buttonCrudeClientAdd.TabIndex = 3;
            this.buttonCrudeClientAdd.Text = "&Add";
            this.buttonCrudeClientAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAdd.Click += new System.EventHandler(this.buttonCrudeClientAdd_Click);
            // 
            // buttonCrudeClientEdit
            // 
            this.buttonCrudeClientEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEdit.Location = new System.Drawing.Point(573, 569);
            this.buttonCrudeClientEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrudeClientEdit.Name = "buttonCrudeClientEdit";
            this.buttonCrudeClientEdit.Size = new System.Drawing.Size(138, 34);
            this.buttonCrudeClientEdit.TabIndex = 4;
            this.buttonCrudeClientEdit.Text = "&Edit";
            this.buttonCrudeClientEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEdit.Click += new System.EventHandler(this.buttonCrudeClientEdit_Click);
            // 
            // buttonCrudeClientSearch
            // 
            this.buttonCrudeClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientSearch.Location = new System.Drawing.Point(873, 569);
            this.buttonCrudeClientSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrudeClientSearch.Name = "buttonCrudeClientSearch";
            this.buttonCrudeClientSearch.Size = new System.Drawing.Size(138, 34);
            this.buttonCrudeClientSearch.TabIndex = 2;
            this.buttonCrudeClientSearch.Text = "&Search";
            this.buttonCrudeClientSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientSearch.Click += new System.EventHandler(this.buttonCrudeClientSearch_Click);
            // 
            // dataGridViewCrudeClient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClient.Location = new System.Drawing.Point(18, 167);
            this.dataGridViewCrudeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCrudeClient.Name = "dataGridViewCrudeClient";
            this.dataGridViewCrudeClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClient.Size = new System.Drawing.Size(1143, 391);
            this.dataGridViewCrudeClient.TabIndex = 0;
            this.dataGridViewCrudeClient.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClient_DoubleClick);
            // 
            // labelClientTypeRefCombo
            // 
            this.labelClientTypeRefCombo.AutoSize = true;
            this.labelClientTypeRefCombo.Location = new System.Drawing.Point(522, 17);
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
            this.clientTypeRefCombo.Location = new System.Drawing.Point(716, 17);
            this.clientTypeRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientTypeRefCombo.Name = "clientTypeRefCombo";
            this.clientTypeRefCombo.Size = new System.Drawing.Size(445, 31);
            this.clientTypeRefCombo.TabIndex = 3;
            // 
            // labelClientNationalityRefCombo
            // 
            this.labelClientNationalityRefCombo.AutoSize = true;
            this.labelClientNationalityRefCombo.Location = new System.Drawing.Point(522, 52);
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
            this.clientNationalityRefCombo.Location = new System.Drawing.Point(716, 52);
            this.clientNationalityRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientNationalityRefCombo.Name = "clientNationalityRefCombo";
            this.clientNationalityRefCombo.Size = new System.Drawing.Size(445, 31);
            this.clientNationalityRefCombo.TabIndex = 5;
            // 
            // labelClientGenderRefCombo
            // 
            this.labelClientGenderRefCombo.AutoSize = true;
            this.labelClientGenderRefCombo.Location = new System.Drawing.Point(522, 88);
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
            this.clientGenderRefCombo.Location = new System.Drawing.Point(716, 88);
            this.clientGenderRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientGenderRefCombo.Name = "clientGenderRefCombo";
            this.clientGenderRefCombo.Size = new System.Drawing.Size(445, 31);
            this.clientGenderRefCombo.TabIndex = 7;
            // 
            // labelClientTitleRefCombo
            // 
            this.labelClientTitleRefCombo.AutoSize = true;
            this.labelClientTitleRefCombo.Location = new System.Drawing.Point(522, 123);
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
            this.clientTitleRefCombo.Location = new System.Drawing.Point(716, 123);
            this.clientTitleRefCombo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clientTitleRefCombo.Name = "clientTitleRefCombo";
            this.clientTitleRefCombo.Size = new System.Drawing.Size(445, 31);
            this.clientTitleRefCombo.TabIndex = 9;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 17);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 20);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 17);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(305, 26);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(16, 52);
            this.labelMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(105, 20);
            this.labelMiddleName.TabIndex = 12;
            this.labelMiddleName.Text = "Middle Name:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(210, 52);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(305, 26);
            this.textBoxMiddleName.TabIndex = 13;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(16, 87);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 20);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 87);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(305, 26);
            this.textBoxLastName.TabIndex = 15;
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 612);
            this.Controls.Add(this.buttonCrudeClientSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientAdd);
            this.Controls.Add(this.buttonCrudeClientEdit);
            this.Controls.Add(this.dataGridViewCrudeClient);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientSearch";
            this.Text = "Client Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
