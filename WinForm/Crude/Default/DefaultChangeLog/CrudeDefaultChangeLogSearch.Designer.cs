namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultChangeLogSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultChangeLog;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeName;
        
        private System.Windows.Forms.Label labelDefaultChangeName;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeDescription;
        
        private System.Windows.Forms.Label labelDefaultChangeDescription;
        
        private DefaultChangeLogTypeRefCombo defaultChangeLogTypeRefCombo;
        
        private System.Windows.Forms.Label labelDefaultChangeLogTypeRefCombo;
        
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
            this.buttonCrudeDefaultChangeLogAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultChangeLogEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultChangeLogSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultChangeLog = new System.Windows.Forms.DataGridView();
            this.labelDefaultChangeName = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeName = new System.Windows.Forms.TextBox();
            this.labelDefaultChangeDescription = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeDescription = new System.Windows.Forms.TextBox();
            this.labelDefaultChangeLogTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultChangeLogTypeRefCombo = new DefaultChangeLogTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultChangeLog)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultChangeName
            //
            this.labelDefaultChangeName.AutoSize = true;
            this.labelDefaultChangeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultChangeName.Name = "labelDefaultChangeName";
            this.labelDefaultChangeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeName.TabIndex = 2;
            this.labelDefaultChangeName.Text = "Default Change Name:";
            //
            //textBoxDefaultChangeName
            //
            this.textBoxDefaultChangeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxDefaultChangeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeName.Name = "textBoxDefaultChangeName";
            this.textBoxDefaultChangeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeName.TabIndex = 3;
            //
            // labelDefaultChangeDescription
            //
            this.labelDefaultChangeDescription.AutoSize = true;
            this.labelDefaultChangeDescription.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultChangeDescription.Name = "labelDefaultChangeDescription";
            this.labelDefaultChangeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeDescription.TabIndex = 4;
            this.labelDefaultChangeDescription.Text = "Default Change Description:";
            //
            //textBoxDefaultChangeDescription
            //
            this.textBoxDefaultChangeDescription.Location = new System.Drawing.Point(182, 36);
            this.textBoxDefaultChangeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeDescription.Name = "textBoxDefaultChangeDescription";
            this.textBoxDefaultChangeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeDescription.TabIndex = 5;
            //
            // labelDefaultChangeLogTypeRefCombo
            //
            this.labelDefaultChangeLogTypeRefCombo.AutoSize = true;
            this.labelDefaultChangeLogTypeRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelDefaultChangeLogTypeRefCombo.Name = "labelDefaultChangeLogTypeRefCombo";
            this.labelDefaultChangeLogTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogTypeRefCombo.TabIndex = 6;
            this.labelDefaultChangeLogTypeRefCombo.Text = "Default Change Log Type:";
            //
            //defaultChangeLogTypeRefCombo
            //
            this.defaultChangeLogTypeRefCombo.Location = new System.Drawing.Point(182, 59);
            this.defaultChangeLogTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultChangeLogTypeRefCombo.Name = "defaultChangeLogTypeRefCombo";
            this.defaultChangeLogTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultChangeLogTypeRefCombo.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultChangeLog
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultChangeLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultChangeLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultChangeLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultChangeLog.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeDefaultChangeLog.Name = "dataGridViewCrudeDefaultChangeLog";
            this.dataGridViewCrudeDefaultChangeLog.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeDefaultChangeLog.TabIndex = 0;
            this.dataGridViewCrudeDefaultChangeLog.ReadOnly = true;
            this.dataGridViewCrudeDefaultChangeLog.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultChangeLog_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultChangeLogSearch
            // 
            this.buttonCrudeDefaultChangeLogSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogSearch.Location = new System.Drawing.Point(240, 218);
            this.buttonCrudeDefaultChangeLogSearch.Name = "buttonCrudeDefaultChangeLogSearch";
            this.buttonCrudeDefaultChangeLogSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogSearch.TabIndex = 2;
            this.buttonCrudeDefaultChangeLogSearch.Text = "&Search";
            this.buttonCrudeDefaultChangeLogSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogSearch.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogSearch_Click);
            // 
            // buttonCrudeDefaultChangeLogAdd
            // 
            this.buttonCrudeDefaultChangeLogAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogAdd.Location = new System.Drawing.Point(140, 218);
            this.buttonCrudeDefaultChangeLogAdd.Name = "buttonCrudeDefaultChangeLogAdd";
            this.buttonCrudeDefaultChangeLogAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogAdd.TabIndex = 3;
            this.buttonCrudeDefaultChangeLogAdd.Text = "&Add";
            this.buttonCrudeDefaultChangeLogAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogAdd.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogAdd_Click);
            // 
            // buttonCrudeDefaultChangeLogEdit
            // 
            this.buttonCrudeDefaultChangeLogEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogEdit.Location = new System.Drawing.Point(40, 218);
            this.buttonCrudeDefaultChangeLogEdit.Name = "buttonCrudeDefaultChangeLogEdit";
            this.buttonCrudeDefaultChangeLogEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogEdit.TabIndex = 4;
            this.buttonCrudeDefaultChangeLogEdit.Text = "&Edit";
            this.buttonCrudeDefaultChangeLogEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogEdit.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 246);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogAdd);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultChangeLog);
            this.Name = "CrudeDefaultChangeLogSearch";
            this.Text = "Default Change Log Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultChangeLog)).EndInit();
            this.Controls.Add(this.labelDefaultChangeName);
            this.Controls.Add(this.textBoxDefaultChangeName);
            this.Controls.Add(this.labelDefaultChangeDescription);
            this.Controls.Add(this.textBoxDefaultChangeDescription);
            this.Controls.Add(this.labelDefaultChangeLogTypeRefCombo);
            this.Controls.Add(this.defaultChangeLogTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
