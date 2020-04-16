namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultChangeLogEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeName;
        
        private System.Windows.Forms.Label labelDefaultChangeName;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeDescription;
        
        private System.Windows.Forms.Label labelDefaultChangeDescription;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private DefaultChangeLogTypeRefCombo defaultChangeLogTypeRefCombo;
        
        private System.Windows.Forms.Label labelDefaultChangeLogTypeRefCombo;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultChangeName = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeName = new System.Windows.Forms.TextBox();
            this.labelDefaultChangeDescription = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeDescription = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDefaultChangeLogTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultChangeLogTypeRefCombo = new DefaultChangeLogTypeRefCombo();
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelDefaultChangeLogTypeRefCombo
            //
            this.labelDefaultChangeLogTypeRefCombo.AutoSize = true;
            this.labelDefaultChangeLogTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelDefaultChangeLogTypeRefCombo.Name = "labelDefaultChangeLogTypeRefCombo";
            this.labelDefaultChangeLogTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogTypeRefCombo.TabIndex = 8;
            this.labelDefaultChangeLogTypeRefCombo.Text = "Default Change Log Type:";
            //
            //defaultChangeLogTypeRefCombo
            //
            this.defaultChangeLogTypeRefCombo.Location = new System.Drawing.Point(182, 82);
            this.defaultChangeLogTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultChangeLogTypeRefCombo.Name = "defaultChangeLogTypeRefCombo";
            this.defaultChangeLogTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultChangeLogTypeRefCombo.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(240, 105);
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
            this.ClientSize = new System.Drawing.Size(444, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultChangeLogEdit";
            this.Text = "Default Change Log Edit";
            this.Controls.Add(this.labelDefaultChangeName);
            this.Controls.Add(this.textBoxDefaultChangeName);
            this.Controls.Add(this.labelDefaultChangeDescription);
            this.Controls.Add(this.textBoxDefaultChangeDescription);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelDefaultChangeLogTypeRefCombo);
            this.Controls.Add(this.defaultChangeLogTypeRefCombo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
