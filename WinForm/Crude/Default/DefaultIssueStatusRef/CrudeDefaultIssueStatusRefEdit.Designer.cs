namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueStatusRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueStatus;
        
        private System.Windows.Forms.Label labelDefaultIssueStatus;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueStatusName;
        
        private System.Windows.Forms.Label labelDefaultIssueStatusName;
        
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
            this.labelDefaultIssueStatus = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueStatus = new System.Windows.Forms.TextBox();
            this.labelDefaultIssueStatusName = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueStatusName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultIssueStatus
            //
            this.labelDefaultIssueStatus.AutoSize = true;
            this.labelDefaultIssueStatus.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultIssueStatus.Name = "labelDefaultIssueStatus";
            this.labelDefaultIssueStatus.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueStatus.TabIndex = 2;
            this.labelDefaultIssueStatus.Text = "Default Issue Status:";
            //
            //textBoxDefaultIssueStatus
            //
            this.textBoxDefaultIssueStatus.Location = new System.Drawing.Point(175, 13);
            this.textBoxDefaultIssueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueStatus.Name = "textBoxDefaultIssueStatus";
            this.textBoxDefaultIssueStatus.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueStatus.TabIndex = 3;
            //
            // labelDefaultIssueStatusName
            //
            this.labelDefaultIssueStatusName.AutoSize = true;
            this.labelDefaultIssueStatusName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultIssueStatusName.Name = "labelDefaultIssueStatusName";
            this.labelDefaultIssueStatusName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueStatusName.TabIndex = 4;
            this.labelDefaultIssueStatusName.Text = "Default Issue Status Name:";
            //
            //textBoxDefaultIssueStatusName
            //
            this.textBoxDefaultIssueStatusName.Location = new System.Drawing.Point(175, 36);
            this.textBoxDefaultIssueStatusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueStatusName.Name = "textBoxDefaultIssueStatusName";
            this.textBoxDefaultIssueStatusName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueStatusName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(233, 82);
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
            this.ClientSize = new System.Drawing.Size(437, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultIssueStatusRefEdit";
            this.Text = "Default Issue Status Ref Edit";
            this.Controls.Add(this.labelDefaultIssueStatus);
            this.Controls.Add(this.textBoxDefaultIssueStatus);
            this.Controls.Add(this.labelDefaultIssueStatusName);
            this.Controls.Add(this.textBoxDefaultIssueStatusName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
