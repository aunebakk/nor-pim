namespace SolutionNorSolutionPim.UserInterface {


    public partial class DefaultSystemReferenceTableSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultSystemReferenceTable;

        private System.Windows.Forms.TextBox textBoxSystemReferenceTableName;

        private System.Windows.Forms.Label labelSystemReferenceTableName;

        private System.Windows.Forms.TextBox textBoxSystemReferenceDisplayName;

        private System.Windows.Forms.Label labelSystemReferenceDisplayName;

        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private DefaultUserPicker userPicker;

        private System.Windows.Forms.Label labelUserPicker;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultSystemReferenceTable = new System.Windows.Forms.DataGridView();
            this.labelSystemReferenceTableName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceTableName = new System.Windows.Forms.TextBox();
            this.labelSystemReferenceDisplayName = new System.Windows.Forms.Label();
            this.textBoxSystemReferenceDisplayName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new SolutionNorSolutionPim.UserInterface.DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemReferenceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(433, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(237, 218);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 22);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(334, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewCrudeDefaultSystemReferenceTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultSystemReferenceTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultSystemReferenceTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultSystemReferenceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultSystemReferenceTable.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeDefaultSystemReferenceTable.Name = "dataGridViewCrudeDefaultSystemReferenceTable";
            this.dataGridViewCrudeDefaultSystemReferenceTable.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeDefaultSystemReferenceTable.TabIndex = 0;
            this.dataGridViewCrudeDefaultSystemReferenceTable.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick);
            // 
            // labelSystemReferenceTableName
            // 
            this.labelSystemReferenceTableName.AutoSize = true;
            this.labelSystemReferenceTableName.Location = new System.Drawing.Point(11, 13);
            this.labelSystemReferenceTableName.Name = "labelSystemReferenceTableName";
            this.labelSystemReferenceTableName.Size = new System.Drawing.Size(158, 13);
            this.labelSystemReferenceTableName.TabIndex = 2;
            this.labelSystemReferenceTableName.Text = "System Reference Table Name:";
            // 
            // textBoxSystemReferenceTableName
            // 
            this.textBoxSystemReferenceTableName.Location = new System.Drawing.Point(191, 13);
            this.textBoxSystemReferenceTableName.Name = "textBoxSystemReferenceTableName";
            this.textBoxSystemReferenceTableName.Size = new System.Drawing.Size(332, 20);
            this.textBoxSystemReferenceTableName.TabIndex = 3;
            // 
            // labelSystemReferenceDisplayName
            // 
            this.labelSystemReferenceDisplayName.AutoSize = true;
            this.labelSystemReferenceDisplayName.Location = new System.Drawing.Point(11, 36);
            this.labelSystemReferenceDisplayName.Name = "labelSystemReferenceDisplayName";
            this.labelSystemReferenceDisplayName.Size = new System.Drawing.Size(165, 13);
            this.labelSystemReferenceDisplayName.TabIndex = 4;
            this.labelSystemReferenceDisplayName.Text = "System Reference Display Name:";
            // 
            // textBoxSystemReferenceDisplayName
            // 
            this.textBoxSystemReferenceDisplayName.Location = new System.Drawing.Point(191, 36);
            this.textBoxSystemReferenceDisplayName.Name = "textBoxSystemReferenceDisplayName";
            this.textBoxSystemReferenceDisplayName.Size = new System.Drawing.Size(332, 20);
            this.textBoxSystemReferenceDisplayName.TabIndex = 5;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(59, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(191, 59);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.ShowCheckBox = true;
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(332, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // labelUserPicker
            // 
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(35, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User :";
            // 
            // userPicker
            // 
            this.userPicker.Location = new System.Drawing.Point(191, 82);
            this.userPicker.Name = "userPicker";
            this.userPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.userPicker.Size = new System.Drawing.Size(332, 20);
            this.userPicker.TabIndex = 9;
            // 
            // DefaultSystemReferenceTableSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 241);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultSystemReferenceTable);
            this.Controls.Add(this.labelSystemReferenceTableName);
            this.Controls.Add(this.textBoxSystemReferenceTableName);
            this.Controls.Add(this.labelSystemReferenceDisplayName);
            this.Controls.Add(this.textBoxSystemReferenceDisplayName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Name = "DefaultSystemReferenceTableSearch";
            this.Text = "System Reference Table Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemReferenceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
