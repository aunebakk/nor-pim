namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultSystemSettingEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultSystemSettingRefCombo = new System.Windows.Forms.Label();
            this.defaultSystemSettingRefCombo = new DefaultSystemSettingRefCombo();
            this.labelDefaultSystemSettingValue = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemSettingValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 82);
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
            this.ClientSize = new System.Drawing.Size(458, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultSystemSettingEdit";
            this.Text = "Default System Setting Edit";
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
