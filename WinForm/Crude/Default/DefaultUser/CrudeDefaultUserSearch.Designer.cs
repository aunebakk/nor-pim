namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultUserSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultUser;
        
        private System.Windows.Forms.TextBox textBoxDefaultUserName;
        
        private System.Windows.Forms.Label labelDefaultUserName;
        
        private System.Windows.Forms.TextBox textBoxDefaultUserCode;
        
        private System.Windows.Forms.Label labelDefaultUserCode;
        
        private System.Windows.Forms.TextBox textBoxEmail;
        
        private System.Windows.Forms.Label labelEmail;
        
        private System.Windows.Forms.TextBox textBoxPassword;
        
        private System.Windows.Forms.Label labelPassword;
        
        private DefaultStateRefCombo defaultStateRefCombo;
        
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerLastActivityDateTime;
        
        private System.Windows.Forms.Label labelLastActivityDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultUser = new System.Windows.Forms.DataGridView();
            this.labelDefaultUserName = new System.Windows.Forms.Label();
            this.textBoxDefaultUserName = new System.Windows.Forms.TextBox();
            this.labelDefaultUserCode = new System.Windows.Forms.Label();
            this.textBoxDefaultUserCode = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new DefaultStateRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelLastActivityDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerLastActivityDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUser)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultUserName
            //
            this.labelDefaultUserName.AutoSize = true;
            this.labelDefaultUserName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultUserName.Name = "labelDefaultUserName";
            this.labelDefaultUserName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserName.TabIndex = 2;
            this.labelDefaultUserName.Text = "Default User Name:";
            //
            //textBoxDefaultUserName
            //
            this.textBoxDefaultUserName.Location = new System.Drawing.Point(161, 13);
            this.textBoxDefaultUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserName.Name = "textBoxDefaultUserName";
            this.textBoxDefaultUserName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserName.TabIndex = 3;
            //
            // labelDefaultUserCode
            //
            this.labelDefaultUserCode.AutoSize = true;
            this.labelDefaultUserCode.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultUserCode.Name = "labelDefaultUserCode";
            this.labelDefaultUserCode.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserCode.TabIndex = 4;
            this.labelDefaultUserCode.Text = "Default User Code:";
            //
            //textBoxDefaultUserCode
            //
            this.textBoxDefaultUserCode.Location = new System.Drawing.Point(161, 36);
            this.textBoxDefaultUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserCode.Name = "textBoxDefaultUserCode";
            this.textBoxDefaultUserCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserCode.TabIndex = 5;
            //
            // labelEmail
            //
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(11, 59);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            //
            //textBoxEmail
            //
            this.textBoxEmail.Location = new System.Drawing.Point(161, 59);
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmail.TabIndex = 7;
            //
            // labelPassword
            //
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 82);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password:";
            //
            //textBoxPassword
            //
            this.textBoxPassword.Location = new System.Drawing.Point(161, 82);
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassword.TabIndex = 9;
            //
            // labelDefaultStateRefCombo
            //
            this.labelDefaultStateRefCombo.AutoSize = true;
            this.labelDefaultStateRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelDefaultStateRefCombo.Name = "labelDefaultStateRefCombo";
            this.labelDefaultStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateRefCombo.TabIndex = 10;
            this.labelDefaultStateRefCombo.Text = "Default State:";
            //
            //defaultStateRefCombo
            //
            this.defaultStateRefCombo.Location = new System.Drawing.Point(161, 105);
            this.defaultStateRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultStateRefCombo.Name = "defaultStateRefCombo";
            this.defaultStateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultStateRefCombo.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelLastActivityDateTime
            //
            this.labelLastActivityDateTime.AutoSize = true;
            this.labelLastActivityDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelLastActivityDateTime.Name = "labelLastActivityDateTime";
            this.labelLastActivityDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelLastActivityDateTime.TabIndex = 14;
            this.labelLastActivityDateTime.Text = "Last Activity Date Time:";
            //
            //dateTimePickerLastActivityDateTime
            //
            this.dateTimePickerLastActivityDateTime.Location = new System.Drawing.Point(161, 151);
            this.dateTimePickerLastActivityDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerLastActivityDateTime.Name = "dateTimePickerLastActivityDateTime";
            this.dateTimePickerLastActivityDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerLastActivityDateTime.TabIndex = 15;
            this.dateTimePickerLastActivityDateTime.Checked = false;
            this.dateTimePickerLastActivityDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultUser.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeDefaultUser.Name = "dataGridViewCrudeDefaultUser";
            this.dataGridViewCrudeDefaultUser.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeDefaultUser.TabIndex = 0;
            this.dataGridViewCrudeDefaultUser.ReadOnly = true;
            this.dataGridViewCrudeDefaultUser.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultUser_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultUserSearch
            // 
            this.buttonCrudeDefaultUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserSearch.Location = new System.Drawing.Point(219, 287);
            this.buttonCrudeDefaultUserSearch.Name = "buttonCrudeDefaultUserSearch";
            this.buttonCrudeDefaultUserSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserSearch.TabIndex = 2;
            this.buttonCrudeDefaultUserSearch.Text = "&Search";
            this.buttonCrudeDefaultUserSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserSearch.Click += new System.EventHandler(this.buttonCrudeDefaultUserSearch_Click);
            // 
            // buttonCrudeDefaultUserAdd
            // 
            this.buttonCrudeDefaultUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserAdd.Location = new System.Drawing.Point(119, 287);
            this.buttonCrudeDefaultUserAdd.Name = "buttonCrudeDefaultUserAdd";
            this.buttonCrudeDefaultUserAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserAdd.TabIndex = 3;
            this.buttonCrudeDefaultUserAdd.Text = "&Add";
            this.buttonCrudeDefaultUserAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserAdd.Click += new System.EventHandler(this.buttonCrudeDefaultUserAdd_Click);
            // 
            // buttonCrudeDefaultUserEdit
            // 
            this.buttonCrudeDefaultUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserEdit.Location = new System.Drawing.Point(19, 287);
            this.buttonCrudeDefaultUserEdit.Name = "buttonCrudeDefaultUserEdit";
            this.buttonCrudeDefaultUserEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserEdit.TabIndex = 4;
            this.buttonCrudeDefaultUserEdit.Text = "&Edit";
            this.buttonCrudeDefaultUserEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserEdit.Click += new System.EventHandler(this.buttonCrudeDefaultUserEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 315);
            this.Controls.Add(this.buttonCrudeDefaultUserSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultUserAdd);
            this.Controls.Add(this.buttonCrudeDefaultUserEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultUser);
            this.Name = "CrudeDefaultUserSearch";
            this.Text = "Default User Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUser)).EndInit();
            this.Controls.Add(this.labelDefaultUserName);
            this.Controls.Add(this.textBoxDefaultUserName);
            this.Controls.Add(this.labelDefaultUserCode);
            this.Controls.Add(this.textBoxDefaultUserCode);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelLastActivityDateTime);
            this.Controls.Add(this.dateTimePickerLastActivityDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
