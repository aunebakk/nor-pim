namespace norpim.UserInterface {
    
    
    public partial class CrudeSystemReferenceTableSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeSystemReferenceTable;
        
        private System.Windows.Forms.TextBox textBoxSystemReferenceTableName;
        
        private System.Windows.Forms.Label labelSystemReferenceTableName;
        
        private System.Windows.Forms.TextBox textBoxSystemReferenceDisplayName;
        
        private System.Windows.Forms.Label labelSystemReferenceDisplayName;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
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
            this.dataGridViewCrudeSystemReferenceTable = new System.Windows.Forms.DataGridView();
            this.labelSystemReferenceTableName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceTableName = new System.Windows.Forms.TextBox();
            this.labelSystemReferenceDisplayName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceDisplayName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeSystemReferenceTable)).BeginInit();
            this.SuspendLayout();
            //
            // labelSystemReferenceTableName
            //
            this.labelSystemReferenceTableName.AutoSize = true;
            this.labelSystemReferenceTableName.Location = new System.Drawing.Point(11, 13);
            this.labelSystemReferenceTableName.Name = "labelSystemReferenceTableName";
            this.labelSystemReferenceTableName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemReferenceTableName.TabIndex = 2;
            this.labelSystemReferenceTableName.Text = "System Reference Table Name:";
            //
            //textBoxSystemReferenceTableName
            //
            this.textBoxSystemReferenceTableName.Location = new System.Drawing.Point(203, 13);
            this.textBoxSystemReferenceTableName.Name = "textBoxSystemReferenceTableName";
            this.textBoxSystemReferenceTableName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemReferenceTableName.TabIndex = 3;
            //
            // labelSystemReferenceDisplayName
            //
            this.labelSystemReferenceDisplayName.AutoSize = true;
            this.labelSystemReferenceDisplayName.Location = new System.Drawing.Point(11, 36);
            this.labelSystemReferenceDisplayName.Name = "labelSystemReferenceDisplayName";
            this.labelSystemReferenceDisplayName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemReferenceDisplayName.TabIndex = 4;
            this.labelSystemReferenceDisplayName.Text = "System Reference Display Name:";
            //
            //textBoxSystemReferenceDisplayName
            //
            this.textBoxSystemReferenceDisplayName.Location = new System.Drawing.Point(203, 36);
            this.textBoxSystemReferenceDisplayName.Name = "textBoxSystemReferenceDisplayName";
            this.textBoxSystemReferenceDisplayName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemReferenceDisplayName.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 59);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(203, 82);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeSystemReferenceTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeSystemReferenceTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeSystemReferenceTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeSystemReferenceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeSystemReferenceTable.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeSystemReferenceTable.Name = "dataGridViewCrudeSystemReferenceTable";
            this.dataGridViewCrudeSystemReferenceTable.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeSystemReferenceTable.TabIndex = 0;
            this.dataGridViewCrudeSystemReferenceTable.DoubleClick += new System.EventHandler(this.dataGridViewCrudeSystemReferenceTable_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 218);
            
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
            this.buttonSearch.Location = new System.Drawing.Point(335, 218);
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
            this.buttonAdd.Location = new System.Drawing.Point(140, 218);
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
            this.buttonEdit.Location = new System.Drawing.Point(237, 218);
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
            this.ClientSize = new System.Drawing.Size(526, 241);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeSystemReferenceTable);
            this.Name = "CrudeSystemReferenceTableSearch";
            this.Text = "System Reference Table Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeSystemReferenceTable)).EndInit();
            this.Controls.Add(this.labelSystemReferenceTableName);
            this.Controls.Add(this.textBoxSystemReferenceTableName);
            this.Controls.Add(this.labelSystemReferenceDisplayName);
            this.Controls.Add(this.textBoxSystemReferenceDisplayName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
