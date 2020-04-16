namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultUserActivitySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserActivitySearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserActivityAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultUserActivityEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultUserActivity;
        
        private DefaultUserActivityTypeRefCombo defaultUserActivityTypeRefCombo;
        
        private System.Windows.Forms.Label labelDefaultUserActivityTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxUserActivityNote;
        
        private System.Windows.Forms.Label labelUserActivityNote;
        
        private System.Windows.Forms.TextBox textBoxOriginatingAddress;
        
        private System.Windows.Forms.Label labelOriginatingAddress;
        
        private System.Windows.Forms.TextBox textBoxReferrer;
        
        private System.Windows.Forms.Label labelReferrer;
        
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
            this.buttonCrudeDefaultUserActivityAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserActivityEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultUserActivitySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultUserActivity = new System.Windows.Forms.DataGridView();
            this.labelDefaultUserActivityTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultUserActivityTypeRefCombo = new DefaultUserActivityTypeRefCombo();
            this.labelUserActivityNote = new System.Windows.Forms.Label();
            this.textBoxUserActivityNote = new System.Windows.Forms.TextBox();
            this.labelOriginatingAddress = new System.Windows.Forms.Label();
            this.textBoxOriginatingAddress = new System.Windows.Forms.TextBox();
            this.labelReferrer = new System.Windows.Forms.Label();
            this.textBoxReferrer = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUserActivity)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultUserActivityTypeRefCombo
            //
            this.labelDefaultUserActivityTypeRefCombo.AutoSize = true;
            this.labelDefaultUserActivityTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultUserActivityTypeRefCombo.Name = "labelDefaultUserActivityTypeRefCombo";
            this.labelDefaultUserActivityTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserActivityTypeRefCombo.TabIndex = 2;
            this.labelDefaultUserActivityTypeRefCombo.Text = "Default User Activity Type:";
            //
            //defaultUserActivityTypeRefCombo
            //
            this.defaultUserActivityTypeRefCombo.Location = new System.Drawing.Point(182, 13);
            this.defaultUserActivityTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultUserActivityTypeRefCombo.Name = "defaultUserActivityTypeRefCombo";
            this.defaultUserActivityTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultUserActivityTypeRefCombo.TabIndex = 3;
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
            this.textBoxUserActivityNote.Location = new System.Drawing.Point(182, 36);
            this.textBoxUserActivityNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserActivityNote.Name = "textBoxUserActivityNote";
            this.textBoxUserActivityNote.Size = new System.Drawing.Size(250, 20);
            this.textBoxUserActivityNote.TabIndex = 5;
            //
            // labelOriginatingAddress
            //
            this.labelOriginatingAddress.AutoSize = true;
            this.labelOriginatingAddress.Location = new System.Drawing.Point(11, 59);
            this.labelOriginatingAddress.Name = "labelOriginatingAddress";
            this.labelOriginatingAddress.Size = new System.Drawing.Size(71, 13);
            this.labelOriginatingAddress.TabIndex = 6;
            this.labelOriginatingAddress.Text = "Originating Address:";
            //
            //textBoxOriginatingAddress
            //
            this.textBoxOriginatingAddress.Location = new System.Drawing.Point(182, 59);
            this.textBoxOriginatingAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginatingAddress.Name = "textBoxOriginatingAddress";
            this.textBoxOriginatingAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxOriginatingAddress.TabIndex = 7;
            //
            // labelReferrer
            //
            this.labelReferrer.AutoSize = true;
            this.labelReferrer.Location = new System.Drawing.Point(11, 82);
            this.labelReferrer.Name = "labelReferrer";
            this.labelReferrer.Size = new System.Drawing.Size(71, 13);
            this.labelReferrer.TabIndex = 8;
            this.labelReferrer.Text = "Referrer:";
            //
            //textBoxReferrer
            //
            this.textBoxReferrer.Location = new System.Drawing.Point(182, 82);
            this.textBoxReferrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReferrer.Name = "textBoxReferrer";
            this.textBoxReferrer.Size = new System.Drawing.Size(250, 20);
            this.textBoxReferrer.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultUserActivity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultUserActivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultUserActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultUserActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultUserActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultUserActivity.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeDefaultUserActivity.Name = "dataGridViewCrudeDefaultUserActivity";
            this.dataGridViewCrudeDefaultUserActivity.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeDefaultUserActivity.TabIndex = 0;
            this.dataGridViewCrudeDefaultUserActivity.ReadOnly = true;
            this.dataGridViewCrudeDefaultUserActivity.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultUserActivity_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultUserActivitySearch
            // 
            this.buttonCrudeDefaultUserActivitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivitySearch.Location = new System.Drawing.Point(240, 241);
            this.buttonCrudeDefaultUserActivitySearch.Name = "buttonCrudeDefaultUserActivitySearch";
            this.buttonCrudeDefaultUserActivitySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivitySearch.TabIndex = 2;
            this.buttonCrudeDefaultUserActivitySearch.Text = "&Search";
            this.buttonCrudeDefaultUserActivitySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivitySearch.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivitySearch_Click);
            // 
            // buttonCrudeDefaultUserActivityAdd
            // 
            this.buttonCrudeDefaultUserActivityAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivityAdd.Location = new System.Drawing.Point(140, 241);
            this.buttonCrudeDefaultUserActivityAdd.Name = "buttonCrudeDefaultUserActivityAdd";
            this.buttonCrudeDefaultUserActivityAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivityAdd.TabIndex = 3;
            this.buttonCrudeDefaultUserActivityAdd.Text = "&Add";
            this.buttonCrudeDefaultUserActivityAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivityAdd.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivityAdd_Click);
            // 
            // buttonCrudeDefaultUserActivityEdit
            // 
            this.buttonCrudeDefaultUserActivityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultUserActivityEdit.Location = new System.Drawing.Point(40, 241);
            this.buttonCrudeDefaultUserActivityEdit.Name = "buttonCrudeDefaultUserActivityEdit";
            this.buttonCrudeDefaultUserActivityEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultUserActivityEdit.TabIndex = 4;
            this.buttonCrudeDefaultUserActivityEdit.Text = "&Edit";
            this.buttonCrudeDefaultUserActivityEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultUserActivityEdit.Click += new System.EventHandler(this.buttonCrudeDefaultUserActivityEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 269);
            this.Controls.Add(this.buttonCrudeDefaultUserActivitySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultUserActivityAdd);
            this.Controls.Add(this.buttonCrudeDefaultUserActivityEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultUserActivity);
            this.Name = "CrudeDefaultUserActivitySearch";
            this.Text = "Default User Activity Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultUserActivity)).EndInit();
            this.Controls.Add(this.labelDefaultUserActivityTypeRefCombo);
            this.Controls.Add(this.defaultUserActivityTypeRefCombo);
            this.Controls.Add(this.labelUserActivityNote);
            this.Controls.Add(this.textBoxUserActivityNote);
            this.Controls.Add(this.labelOriginatingAddress);
            this.Controls.Add(this.textBoxOriginatingAddress);
            this.Controls.Add(this.labelReferrer);
            this.Controls.Add(this.textBoxReferrer);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
