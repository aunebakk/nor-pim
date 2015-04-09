namespace norpim.UserInterface {
    
    
    public partial class CrudeUserSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeUser;
        
        private System.Windows.Forms.TextBox textBoxUserCode;
        
        private System.Windows.Forms.Label labelUserCode;
        
        private System.Windows.Forms.TextBox textBoxUserName;
        
        private System.Windows.Forms.Label labelUserName;
        
        private System.Windows.Forms.TextBox textBoxEmail;
        
        private System.Windows.Forms.Label labelEmail;
        
        private System.Windows.Forms.TextBox textBoxPassword;
        
        private System.Windows.Forms.Label labelPassword;
        
        private StateRefCombo stateRefCombo;
        
        private System.Windows.Forms.Label labelStateRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeUser = new System.Windows.Forms.DataGridView();
            this.labelUserCode = new System.Windows.Forms.Label();
            this.textBoxUserCode = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelStateRefCombo = new System.Windows.Forms.Label();
            this.stateRefCombo = new StateRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeUser)).BeginInit();
            this.SuspendLayout();
            //
            // labelUserCode
            //
            this.labelUserCode.AutoSize = true;
            this.labelUserCode.Location = new System.Drawing.Point(11, 13);
            this.labelUserCode.Name = "labelUserCode";
            this.labelUserCode.Size = new System.Drawing.Size(71, 13);
            this.labelUserCode.TabIndex = 2;
            this.labelUserCode.Text = "User Code:";
            //
            //textBoxUserCode
            //
            this.textBoxUserCode.Location = new System.Drawing.Point(70, 13);
            this.textBoxUserCode.Name = "textBoxUserCode";
            this.textBoxUserCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxUserCode.TabIndex = 3;
            //
            // labelUserName
            //
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(11, 36);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(71, 13);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "User Name:";
            //
            //textBoxUserName
            //
            this.textBoxUserName.Location = new System.Drawing.Point(70, 36);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(250, 20);
            this.textBoxUserName.TabIndex = 5;
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
            this.textBoxEmail.Location = new System.Drawing.Point(70, 59);
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
            this.textBoxPassword.Location = new System.Drawing.Point(70, 82);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassword.TabIndex = 9;
            //
            // labelStateRefCombo
            //
            this.labelStateRefCombo.AutoSize = true;
            this.labelStateRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelStateRefCombo.Name = "labelStateRefCombo";
            this.labelStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelStateRefCombo.TabIndex = 10;
            this.labelStateRefCombo.Text = "State:";
            //
            //stateRefCombo
            //
            this.stateRefCombo.Location = new System.Drawing.Point(70, 105);
            this.stateRefCombo.Name = "stateRefCombo";
            this.stateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.stateRefCombo.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(70, 128);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeUser.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeUser.Name = "dataGridViewCrudeUser";
            this.dataGridViewCrudeUser.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeUser.TabIndex = 0;
            this.dataGridViewCrudeUser.DoubleClick += new System.EventHandler(this.dataGridViewCrudeUser_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(335, 264);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(140, 264);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(237, 264);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 287);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeUser);
            this.Name = "CrudeUserSearch";
            this.Text = "User Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeUser)).EndInit();
            this.Controls.Add(this.labelUserCode);
            this.Controls.Add(this.textBoxUserCode);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelStateRefCombo);
            this.Controls.Add(this.stateRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
