namespace norpim.UserInterface {
    
    
    public partial class CrudeUserActivitySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeUserActivity;
        
        private UserActivityTypeRefCombo userActivityTypeRefCombo;
        
        private System.Windows.Forms.Label labelUserActivityTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxUserActivityNote;
        
        private System.Windows.Forms.Label labelUserActivityNote;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.TextBox textBoxOriginatingAddress;
        
        private System.Windows.Forms.Label labelOriginatingAddress;
        
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
            this.dataGridViewCrudeUserActivity = new System.Windows.Forms.DataGridView();
            this.labelUserActivityTypeRefCombo = new System.Windows.Forms.Label();
            this.userActivityTypeRefCombo = new UserActivityTypeRefCombo();
            this.labelUserActivityNote = new System.Windows.Forms.Label();
            this.textBoxUserActivityNote = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelOriginatingAddress = new System.Windows.Forms.Label();
            this.textBoxOriginatingAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeUserActivity)).BeginInit();
            this.SuspendLayout();
            //
            // labelUserActivityTypeRefCombo
            //
            this.labelUserActivityTypeRefCombo.AutoSize = true;
            this.labelUserActivityTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelUserActivityTypeRefCombo.Name = "labelUserActivityTypeRefCombo";
            this.labelUserActivityTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelUserActivityTypeRefCombo.TabIndex = 2;
            this.labelUserActivityTypeRefCombo.Text = "User Activity Type:";
            //
            //userActivityTypeRefCombo
            //
            this.userActivityTypeRefCombo.Location = new System.Drawing.Point(133, 13);
            this.userActivityTypeRefCombo.Name = "userActivityTypeRefCombo";
            this.userActivityTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.userActivityTypeRefCombo.TabIndex = 3;
            //
            // labelUserActivityNote
            //
            this.labelUserActivityNote.AutoSize = true;
            this.labelUserActivityNote.Location = new System.Drawing.Point(11, 36);
            this.labelUserActivityNote.Name = "labelUserActivityNote";
            this.labelUserActivityNote.Size = new System.Drawing.Size(71, 13);
            this.labelUserActivityNote.TabIndex = 4;
            this.labelUserActivityNote.Text = "User Activity Note:";
            //
            //textBoxUserActivityNote
            //
            this.textBoxUserActivityNote.Location = new System.Drawing.Point(133, 36);
            this.textBoxUserActivityNote.Name = "textBoxUserActivityNote";
            this.textBoxUserActivityNote.Size = new System.Drawing.Size(250, 20);
            this.textBoxUserActivityNote.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(133, 59);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(133, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelOriginatingAddress
            //
            this.labelOriginatingAddress.AutoSize = true;
            this.labelOriginatingAddress.Location = new System.Drawing.Point(11, 105);
            this.labelOriginatingAddress.Name = "labelOriginatingAddress";
            this.labelOriginatingAddress.Size = new System.Drawing.Size(71, 13);
            this.labelOriginatingAddress.TabIndex = 10;
            this.labelOriginatingAddress.Text = "Originating Address:";
            //
            //textBoxOriginatingAddress
            //
            this.textBoxOriginatingAddress.Location = new System.Drawing.Point(133, 105);
            this.textBoxOriginatingAddress.Name = "textBoxOriginatingAddress";
            this.textBoxOriginatingAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxOriginatingAddress.TabIndex = 11;
            // 
            // dataGridViewCrudeUserActivity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeUserActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeUserActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeUserActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeUserActivity.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeUserActivity.Name = "dataGridViewCrudeUserActivity";
            this.dataGridViewCrudeUserActivity.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeUserActivity.TabIndex = 0;
            this.dataGridViewCrudeUserActivity.DoubleClick += new System.EventHandler(this.dataGridViewCrudeUserActivity_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 241);
            
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
            this.buttonSearch.Location = new System.Drawing.Point(335, 241);
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
            this.buttonAdd.Location = new System.Drawing.Point(140, 241);
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
            this.buttonEdit.Location = new System.Drawing.Point(237, 241);
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
            this.ClientSize = new System.Drawing.Size(526, 264);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeUserActivity);
            this.Name = "CrudeUserActivitySearch";
            this.Text = "User Activity Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeUserActivity)).EndInit();
            this.Controls.Add(this.labelUserActivityTypeRefCombo);
            this.Controls.Add(this.userActivityTypeRefCombo);
            this.Controls.Add(this.labelUserActivityNote);
            this.Controls.Add(this.textBoxUserActivityNote);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelOriginatingAddress);
            this.Controls.Add(this.textBoxOriginatingAddress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
