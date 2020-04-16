namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultSystemSettingRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemSetting;
        
        private System.Windows.Forms.Label labelDefaultSystemSetting;
        
        private System.Windows.Forms.TextBox textBoxDefaultSystemSettingName;
        
        private System.Windows.Forms.Label labelDefaultSystemSettingName;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultSystemSetting = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSetting = new System.Windows.Forms.TextBox();
            this.labelDefaultSystemSettingName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSettingName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultSystemSetting
            //
            this.labelDefaultSystemSetting.AutoSize = true;
            this.labelDefaultSystemSetting.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultSystemSetting.Name = "labelDefaultSystemSetting";
            this.labelDefaultSystemSetting.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSetting.TabIndex = 2;
            this.labelDefaultSystemSetting.Text = "Default System Setting:";
            //
            //textBoxDefaultSystemSetting
            //
            this.textBoxDefaultSystemSetting.Location = new System.Drawing.Point(189, 13);
            this.textBoxDefaultSystemSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemSetting.Name = "textBoxDefaultSystemSetting";
            this.textBoxDefaultSystemSetting.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemSetting.TabIndex = 3;
            //
            // labelDefaultSystemSettingName
            //
            this.labelDefaultSystemSettingName.AutoSize = true;
            this.labelDefaultSystemSettingName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultSystemSettingName.Name = "labelDefaultSystemSettingName";
            this.labelDefaultSystemSettingName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultSystemSettingName.TabIndex = 4;
            this.labelDefaultSystemSettingName.Text = "Default System Setting Name:";
            //
            //textBoxDefaultSystemSettingName
            //
            this.textBoxDefaultSystemSettingName.Location = new System.Drawing.Point(189, 36);
            this.textBoxDefaultSystemSettingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultSystemSettingName.Name = "textBoxDefaultSystemSettingName";
            this.textBoxDefaultSystemSettingName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultSystemSettingName.TabIndex = 5;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultSystemSettingRefEdit";
            this.Text = "Default System Setting Ref Edit";
            this.Controls.Add(this.labelDefaultSystemSetting);
            this.Controls.Add(this.textBoxDefaultSystemSetting);
            this.Controls.Add(this.labelDefaultSystemSettingName);
            this.Controls.Add(this.textBoxDefaultSystemSettingName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
