namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultSystemReferenceTableEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultSystemReferenceTableName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemReferenceTableName = new System.Windows.Forms.TextBox();
            this.labelDefaultSystemReferenceDisplayName = new System.Windows.Forms.Label();
            this.textBoxDefaultSystemReferenceDisplayName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(417, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(317, 82);
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
            this.ClientSize = new System.Drawing.Size(521, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultSystemReferenceTableEdit";
            this.Text = "Default System Reference Table Edit";
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
