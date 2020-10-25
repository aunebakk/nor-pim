namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemSettingRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultSystemSettingRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemSettingName;
        
        private System.Windows.Forms.Label labelDefaultSystemSettingName;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemSetting;
        
        private System.Windows.Forms.Label labelDefaultSystemSetting;
        
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
            this.buttonCrudeDefaultSystemSettingRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemSettingRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemSettingRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultSystemSettingRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultSystemSettingName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSettingName = new System.Windows.Forms.TextBox();
            this.labelDefaultSystemSetting = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSetting = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemSettingRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultSystemSettingName
            //
            this.labelDefaultSystemSettingName.AutoSize = true;
            this.labelDefaultSystemSettingName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultSystemSettingName.Name = "labelDefaultSystemSettingName";
            this.labelDefaultSystemSettingName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSettingName.TabIndex = 2;
            this.labelDefaultSystemSettingName.Text = "Default System Setting Name:";
            //
            //textBoxDefaultSystemSettingName
            //
            this.textBoxDefaultSystemSettingName.Location = new System.Drawing.Point(189, 13);
            this.textBoxDefaultSystemSettingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemSettingName.Name = "textBoxDefaultSystemSettingName";
            this.textBoxDefaultSystemSettingName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemSettingName.TabIndex = 3;
            //
            // labelDefaultSystemSetting
            //
            this.labelDefaultSystemSetting.AutoSize = true;
            this.labelDefaultSystemSetting.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultSystemSetting.Name = "labelDefaultSystemSetting";
            this.labelDefaultSystemSetting.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSetting.TabIndex = 4;
            this.labelDefaultSystemSetting.Text = "Default System Setting:";
            //
            //textBoxDefaultSystemSetting
            //
            this.textBoxDefaultSystemSetting.Location = new System.Drawing.Point(189, 36);
            this.textBoxDefaultSystemSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemSetting.Name = "textBoxDefaultSystemSetting";
            this.textBoxDefaultSystemSetting.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemSetting.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDefaultSystemSettingRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultSystemSettingRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultSystemSettingRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultSystemSettingRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultSystemSettingRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultSystemSettingRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultSystemSettingRef.Name = "dataGridViewCrudeDefaultSystemSettingRef";
            this.dataGridViewCrudeDefaultSystemSettingRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeDefaultSystemSettingRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultSystemSettingRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultSystemSettingRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultSystemSettingRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultSystemSettingRefSearch
            // 
            this.buttonCrudeDefaultSystemSettingRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeDefaultSystemSettingRefSearch.Name = "buttonCrudeDefaultSystemSettingRefSearch";
            this.buttonCrudeDefaultSystemSettingRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultSystemSettingRefSearch.Text = "&Search";
            this.buttonCrudeDefaultSystemSettingRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingRefSearch_Click);
            // 
            // buttonCrudeDefaultSystemSettingRefAdd
            // 
            this.buttonCrudeDefaultSystemSettingRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeDefaultSystemSettingRefAdd.Name = "buttonCrudeDefaultSystemSettingRefAdd";
            this.buttonCrudeDefaultSystemSettingRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultSystemSettingRefAdd.Text = "&Add";
            this.buttonCrudeDefaultSystemSettingRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingRefAdd_Click);
            // 
            // buttonCrudeDefaultSystemSettingRefEdit
            // 
            this.buttonCrudeDefaultSystemSettingRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeDefaultSystemSettingRefEdit.Name = "buttonCrudeDefaultSystemSettingRefEdit";
            this.buttonCrudeDefaultSystemSettingRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultSystemSettingRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultSystemSettingRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultSystemSettingRef);
            this.Name = "CrudeDefaultSystemSettingRefSearch";
            this.Text = "Default System Setting Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemSettingRef)).EndInit();
            this.Controls.Add(this.labelDefaultSystemSettingName);
            this.Controls.Add(this.textBoxDefaultSystemSettingName);
            this.Controls.Add(this.labelDefaultSystemSetting);
            this.Controls.Add(this.textBoxDefaultSystemSetting);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
