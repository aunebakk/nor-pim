namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueType;
        
        private System.Windows.Forms.Label labelDefaultIssueType;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueTypeName;
        
        private System.Windows.Forms.Label labelDefaultIssueTypeName;
        
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
            this.labelDefaultIssueType = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueType = new System.Windows.Forms.TextBox();
            this.labelDefaultIssueTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultIssueType
            //
            this.labelDefaultIssueType.AutoSize = true;
            this.labelDefaultIssueType.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultIssueType.Name = "labelDefaultIssueType";
            this.labelDefaultIssueType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueType.TabIndex = 2;
            this.labelDefaultIssueType.Text = "Default Issue Type:";
            //
            //textBoxDefaultIssueType
            //
            this.textBoxDefaultIssueType.Location = new System.Drawing.Point(161, 13);
            this.textBoxDefaultIssueType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueType.Name = "textBoxDefaultIssueType";
            this.textBoxDefaultIssueType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueType.TabIndex = 3;
            //
            // labelDefaultIssueTypeName
            //
            this.labelDefaultIssueTypeName.AutoSize = true;
            this.labelDefaultIssueTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultIssueTypeName.Name = "labelDefaultIssueTypeName";
            this.labelDefaultIssueTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueTypeName.TabIndex = 4;
            this.labelDefaultIssueTypeName.Text = "Default Issue Type Name:";
            //
            //textBoxDefaultIssueTypeName
            //
            this.textBoxDefaultIssueTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxDefaultIssueTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueTypeName.Name = "textBoxDefaultIssueTypeName";
            this.textBoxDefaultIssueTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 82);
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
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultIssueTypeRefEdit";
            this.Text = "Default Issue Type Ref Edit";
            this.Controls.Add(this.labelDefaultIssueType);
            this.Controls.Add(this.textBoxDefaultIssueType);
            this.Controls.Add(this.labelDefaultIssueTypeName);
            this.Controls.Add(this.textBoxDefaultIssueTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
