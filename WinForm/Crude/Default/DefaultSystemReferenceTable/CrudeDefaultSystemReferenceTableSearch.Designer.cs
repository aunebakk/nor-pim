namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemReferenceTableSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemReferenceTableSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemReferenceTableAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemReferenceTableEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultSystemReferenceTable;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemReferenceTableName;
        
        private System.Windows.Forms.Label labelDefaultSystemReferenceTableName;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemReferenceDisplayName;
        
        private System.Windows.Forms.Label labelDefaultSystemReferenceDisplayName;
        
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
            this.buttonCrudeDefaultSystemReferenceTableAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemReferenceTableEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemReferenceTableSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultSystemReferenceTable = new System.Windows.Forms.DataGridView();
            this.labelDefaultSystemReferenceTableName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemReferenceTableName = new System.Windows.Forms.TextBox();
            this.labelDefaultSystemReferenceDisplayName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemReferenceDisplayName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemReferenceTable)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultSystemReferenceTableName
            //
            this.labelDefaultSystemReferenceTableName.AutoSize = true;
            this.labelDefaultSystemReferenceTableName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultSystemReferenceTableName.Name = "labelDefaultSystemReferenceTableName";
            this.labelDefaultSystemReferenceTableName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemReferenceTableName.TabIndex = 2;
            this.labelDefaultSystemReferenceTableName.Text = "Default System Reference Table Name:";
            //
            //textBoxDefaultSystemReferenceTableName
            //
            this.textBoxDefaultSystemReferenceTableName.Location = new System.Drawing.Point(259, 13);
            this.textBoxDefaultSystemReferenceTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemReferenceTableName.Name = "textBoxDefaultSystemReferenceTableName";
            this.textBoxDefaultSystemReferenceTableName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemReferenceTableName.TabIndex = 3;
            //
            // labelDefaultSystemReferenceDisplayName
            //
            this.labelDefaultSystemReferenceDisplayName.AutoSize = true;
            this.labelDefaultSystemReferenceDisplayName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultSystemReferenceDisplayName.Name = "labelDefaultSystemReferenceDisplayName";
            this.labelDefaultSystemReferenceDisplayName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemReferenceDisplayName.TabIndex = 4;
            this.labelDefaultSystemReferenceDisplayName.Text = "Default System Reference Display Name:";
            //
            //textBoxDefaultSystemReferenceDisplayName
            //
            this.textBoxDefaultSystemReferenceDisplayName.Location = new System.Drawing.Point(259, 36);
            this.textBoxDefaultSystemReferenceDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemReferenceDisplayName.Name = "textBoxDefaultSystemReferenceDisplayName";
            this.textBoxDefaultSystemReferenceDisplayName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemReferenceDisplayName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(259, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultSystemReferenceTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultSystemReferenceTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultSystemReferenceTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultSystemReferenceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultSystemReferenceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultSystemReferenceTable.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultSystemReferenceTable.Name = "dataGridViewCrudeDefaultSystemReferenceTable";
            this.dataGridViewCrudeDefaultSystemReferenceTable.Size = new System.Drawing.Size(497, 96);
            this.dataGridViewCrudeDefaultSystemReferenceTable.TabIndex = 0;
            this.dataGridViewCrudeDefaultSystemReferenceTable.ReadOnly = true;
            this.dataGridViewCrudeDefaultSystemReferenceTable.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(417, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultSystemReferenceTableSearch
            // 
            this.buttonCrudeDefaultSystemReferenceTableSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemReferenceTableSearch.Location = new System.Drawing.Point(317, 195);
            this.buttonCrudeDefaultSystemReferenceTableSearch.Name = "buttonCrudeDefaultSystemReferenceTableSearch";
            this.buttonCrudeDefaultSystemReferenceTableSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemReferenceTableSearch.TabIndex = 2;
            this.buttonCrudeDefaultSystemReferenceTableSearch.Text = "&Search";
            this.buttonCrudeDefaultSystemReferenceTableSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemReferenceTableSearch.Click += new System.EventHandler(this.buttonCrudeDefaultSystemReferenceTableSearch_Click);
            // 
            // buttonCrudeDefaultSystemReferenceTableAdd
            // 
            this.buttonCrudeDefaultSystemReferenceTableAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemReferenceTableAdd.Location = new System.Drawing.Point(217, 195);
            this.buttonCrudeDefaultSystemReferenceTableAdd.Name = "buttonCrudeDefaultSystemReferenceTableAdd";
            this.buttonCrudeDefaultSystemReferenceTableAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemReferenceTableAdd.TabIndex = 3;
            this.buttonCrudeDefaultSystemReferenceTableAdd.Text = "&Add";
            this.buttonCrudeDefaultSystemReferenceTableAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemReferenceTableAdd.Click += new System.EventHandler(this.buttonCrudeDefaultSystemReferenceTableAdd_Click);
            // 
            // buttonCrudeDefaultSystemReferenceTableEdit
            // 
            this.buttonCrudeDefaultSystemReferenceTableEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemReferenceTableEdit.Location = new System.Drawing.Point(117, 195);
            this.buttonCrudeDefaultSystemReferenceTableEdit.Name = "buttonCrudeDefaultSystemReferenceTableEdit";
            this.buttonCrudeDefaultSystemReferenceTableEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemReferenceTableEdit.TabIndex = 4;
            this.buttonCrudeDefaultSystemReferenceTableEdit.Text = "&Edit";
            this.buttonCrudeDefaultSystemReferenceTableEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemReferenceTableEdit.Click += new System.EventHandler(this.buttonCrudeDefaultSystemReferenceTableEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 223);
            this.Controls.Add(this.buttonCrudeDefaultSystemReferenceTableSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultSystemReferenceTableAdd);
            this.Controls.Add(this.buttonCrudeDefaultSystemReferenceTableEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultSystemReferenceTable);
            this.Name = "CrudeDefaultSystemReferenceTableSearch";
            this.Text = "Default System Reference Table Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemReferenceTable)).EndInit();
            this.Controls.Add(this.labelDefaultSystemReferenceTableName);
            this.Controls.Add(this.textBoxDefaultSystemReferenceTableName);
            this.Controls.Add(this.labelDefaultSystemReferenceDisplayName);
            this.Controls.Add(this.textBoxDefaultSystemReferenceDisplayName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
