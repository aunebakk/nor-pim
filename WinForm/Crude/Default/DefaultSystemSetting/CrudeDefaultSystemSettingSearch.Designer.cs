namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemSettingSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultSystemSettingEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultSystemSetting;

        private DefaultSystemSettingRefCombo defaultSystemSettingRefCombo;

        private System.Windows.Forms.Label labelDefaultSystemSettingRefCombo;

        private System.Windows.Forms.TextBox textBoxDefaultSystemSettingValue;

        private System.Windows.Forms.Label labelDefaultSystemSettingValue;

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
            this.buttonCrudeDefaultSystemSettingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemSettingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultSystemSettingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultSystemSetting = new System.Windows.Forms.DataGridView();
            this.labelDefaultSystemSettingRefCombo = new System.Windows.Forms.Label();
            this.defaultSystemSettingRefCombo = new DefaultSystemSettingRefCombo();
            this.labelDefaultSystemSettingValue = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSettingValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemSetting)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultSystemSettingRefCombo
            //
            this.labelDefaultSystemSettingRefCombo.AutoSize = true;
            this.labelDefaultSystemSettingRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultSystemSettingRefCombo.Name = "labelDefaultSystemSettingRefCombo";
            this.labelDefaultSystemSettingRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSettingRefCombo.TabIndex = 2;
            this.labelDefaultSystemSettingRefCombo.Text = "Default System Setting:";
            //
            //defaultSystemSettingRefCombo
            //
            this.defaultSystemSettingRefCombo.Location = new System.Drawing.Point(196, 13);
            this.defaultSystemSettingRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultSystemSettingRefCombo.Name = "defaultSystemSettingRefCombo";
            this.defaultSystemSettingRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultSystemSettingRefCombo.TabIndex = 3;
            //
            // labelDefaultSystemSettingValue
            //
            this.labelDefaultSystemSettingValue.AutoSize = true;
            this.labelDefaultSystemSettingValue.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultSystemSettingValue.Name = "labelDefaultSystemSettingValue";
            this.labelDefaultSystemSettingValue.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSettingValue.TabIndex = 4;
            this.labelDefaultSystemSettingValue.Text = "Default System Setting Value:";
            //
            //textBoxDefaultSystemSettingValue
            //
            this.textBoxDefaultSystemSettingValue.Location = new System.Drawing.Point(196, 36);
            this.textBoxDefaultSystemSettingValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemSettingValue.Name = "textBoxDefaultSystemSettingValue";
            this.textBoxDefaultSystemSettingValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemSettingValue.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultSystemSetting
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultSystemSetting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultSystemSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultSystemSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultSystemSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultSystemSetting.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultSystemSetting.Name = "dataGridViewCrudeDefaultSystemSetting";
            this.dataGridViewCrudeDefaultSystemSetting.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeDefaultSystemSetting.TabIndex = 0;
            this.dataGridViewCrudeDefaultSystemSetting.ReadOnly = true;
            this.dataGridViewCrudeDefaultSystemSetting.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultSystemSetting_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultSystemSettingSearch
            // 
            this.buttonCrudeDefaultSystemSettingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeDefaultSystemSettingSearch.Name = "buttonCrudeDefaultSystemSettingSearch";
            this.buttonCrudeDefaultSystemSettingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingSearch.TabIndex = 2;
            this.buttonCrudeDefaultSystemSettingSearch.Text = "&Search";
            this.buttonCrudeDefaultSystemSettingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingSearch.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingSearch_Click);
            // 
            // buttonCrudeDefaultSystemSettingAdd
            // 
            this.buttonCrudeDefaultSystemSettingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeDefaultSystemSettingAdd.Name = "buttonCrudeDefaultSystemSettingAdd";
            this.buttonCrudeDefaultSystemSettingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingAdd.TabIndex = 3;
            this.buttonCrudeDefaultSystemSettingAdd.Text = "&Add";
            this.buttonCrudeDefaultSystemSettingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingAdd.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingAdd_Click);
            // 
            // buttonCrudeDefaultSystemSettingEdit
            // 
            this.buttonCrudeDefaultSystemSettingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultSystemSettingEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeDefaultSystemSettingEdit.Name = "buttonCrudeDefaultSystemSettingEdit";
            this.buttonCrudeDefaultSystemSettingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultSystemSettingEdit.TabIndex = 4;
            this.buttonCrudeDefaultSystemSettingEdit.Text = "&Edit";
            this.buttonCrudeDefaultSystemSettingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultSystemSettingEdit.Click += new System.EventHandler(this.buttonCrudeDefaultSystemSettingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingAdd);
            this.Controls.Add(this.buttonCrudeDefaultSystemSettingEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultSystemSetting);
            this.Name = "CrudeDefaultSystemSettingSearch";
            this.Text = "Default System Setting Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultSystemSetting)).EndInit();
            this.Controls.Add(this.labelDefaultSystemSettingRefCombo);
            this.Controls.Add(this.defaultSystemSettingRefCombo);
            this.Controls.Add(this.labelDefaultSystemSettingValue);
            this.Controls.Add(this.textBoxDefaultSystemSettingValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
