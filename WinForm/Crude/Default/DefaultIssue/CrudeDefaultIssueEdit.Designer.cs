namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private DefaultIssueTypeRefCombo defaultIssueTypeRefCombo;

        private System.Windows.Forms.Label labelDefaultIssueTypeRefCombo;

        private DefaultIssueStatusRefCombo defaultIssueStatusRefCombo;

        private System.Windows.Forms.Label labelDefaultIssueStatusRefCombo;

        private System.Windows.Forms.TextBox textBoxIssueName;

        private System.Windows.Forms.Label labelIssueName;

        private System.Windows.Forms.TextBox textBoxIssueDescription;

        private System.Windows.Forms.Label labelIssueDescription;

        private System.Windows.Forms.TextBox textBoxStepsToReproduce;

        private System.Windows.Forms.Label labelStepsToReproduce;

        private System.Windows.Forms.TextBox textBoxLink;

        private System.Windows.Forms.Label labelLink;

        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private System.Windows.Forms.TextBox textBoxFixedNote;

        private System.Windows.Forms.Label labelFixedNote;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDefaultIssueTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultIssueTypeRefCombo = new DefaultIssueTypeRefCombo();
            this.labelDefaultIssueStatusRefCombo = new System.Windows.Forms.Label();
            this.defaultIssueStatusRefCombo = new DefaultIssueStatusRefCombo();
            this.labelIssueName = new System.Windows.Forms.Label();
            this.textBoxIssueName = new System.Windows.Forms.TextBox();
            this.labelIssueDescription = new System.Windows.Forms.Label();
            this.textBoxIssueDescription = new System.Windows.Forms.TextBox();
            this.labelStepsToReproduce = new System.Windows.Forms.Label();
            this.textBoxStepsToReproduce = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFixedNote = new System.Windows.Forms.Label();
            this.textBoxFixedNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultIssueTypeRefCombo
            //
            this.labelDefaultIssueTypeRefCombo.AutoSize = true;
            this.labelDefaultIssueTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultIssueTypeRefCombo.Name = "labelDefaultIssueTypeRefCombo";
            this.labelDefaultIssueTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueTypeRefCombo.TabIndex = 2;
            this.labelDefaultIssueTypeRefCombo.Text = "Default Issue Type:";
            //
            //defaultIssueTypeRefCombo
            //
            this.defaultIssueTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.defaultIssueTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultIssueTypeRefCombo.Name = "defaultIssueTypeRefCombo";
            this.defaultIssueTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultIssueTypeRefCombo.TabIndex = 3;
            //
            // labelDefaultIssueStatusRefCombo
            //
            this.labelDefaultIssueStatusRefCombo.AutoSize = true;
            this.labelDefaultIssueStatusRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultIssueStatusRefCombo.Name = "labelDefaultIssueStatusRefCombo";
            this.labelDefaultIssueStatusRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueStatusRefCombo.TabIndex = 4;
            this.labelDefaultIssueStatusRefCombo.Text = "Default Issue Status:";
            //
            //defaultIssueStatusRefCombo
            //
            this.defaultIssueStatusRefCombo.Location = new System.Drawing.Point(140, 36);
            this.defaultIssueStatusRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultIssueStatusRefCombo.Name = "defaultIssueStatusRefCombo";
            this.defaultIssueStatusRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultIssueStatusRefCombo.TabIndex = 5;
            //
            // labelIssueName
            //
            this.labelIssueName.AutoSize = true;
            this.labelIssueName.Location = new System.Drawing.Point(11, 59);
            this.labelIssueName.Name = "labelIssueName";
            this.labelIssueName.Size = new System.Drawing.Size(71, 13);
            this.labelIssueName.TabIndex = 6;
            this.labelIssueName.Text = "Issue Name:";
            //
            //textBoxIssueName
            //
            this.textBoxIssueName.Location = new System.Drawing.Point(140, 59);
            this.textBoxIssueName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIssueName.Name = "textBoxIssueName";
            this.textBoxIssueName.Size = new System.Drawing.Size(250, 20);
            this.textBoxIssueName.TabIndex = 7;
            //
            // labelIssueDescription
            //
            this.labelIssueDescription.AutoSize = true;
            this.labelIssueDescription.Location = new System.Drawing.Point(11, 82);
            this.labelIssueDescription.Name = "labelIssueDescription";
            this.labelIssueDescription.Size = new System.Drawing.Size(71, 13);
            this.labelIssueDescription.TabIndex = 8;
            this.labelIssueDescription.Text = "Issue Description:";
            //
            //textBoxIssueDescription
            //
            this.textBoxIssueDescription.Location = new System.Drawing.Point(140, 82);
            this.textBoxIssueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIssueDescription.Name = "textBoxIssueDescription";
            this.textBoxIssueDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxIssueDescription.TabIndex = 9;
            //
            // labelStepsToReproduce
            //
            this.labelStepsToReproduce.AutoSize = true;
            this.labelStepsToReproduce.Location = new System.Drawing.Point(11, 105);
            this.labelStepsToReproduce.Name = "labelStepsToReproduce";
            this.labelStepsToReproduce.Size = new System.Drawing.Size(71, 13);
            this.labelStepsToReproduce.TabIndex = 10;
            this.labelStepsToReproduce.Text = "Steps To Reproduce:";
            //
            //textBoxStepsToReproduce
            //
            this.textBoxStepsToReproduce.Location = new System.Drawing.Point(140, 105);
            this.textBoxStepsToReproduce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStepsToReproduce.Name = "textBoxStepsToReproduce";
            this.textBoxStepsToReproduce.Size = new System.Drawing.Size(250, 20);
            this.textBoxStepsToReproduce.TabIndex = 11;
            //
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 128);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 12;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 128);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            //
            // labelFixedNote
            //
            this.labelFixedNote.AutoSize = true;
            this.labelFixedNote.Location = new System.Drawing.Point(11, 174);
            this.labelFixedNote.Name = "labelFixedNote";
            this.labelFixedNote.Size = new System.Drawing.Size(71, 13);
            this.labelFixedNote.TabIndex = 16;
            this.labelFixedNote.Text = "Fixed Note:";
            //
            //textBoxFixedNote
            //
            this.textBoxFixedNote.Location = new System.Drawing.Point(140, 174);
            this.textBoxFixedNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFixedNote.Name = "textBoxFixedNote";
            this.textBoxFixedNote.Size = new System.Drawing.Size(250, 20);
            this.textBoxFixedNote.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 197);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 197);
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
            this.ClientSize = new System.Drawing.Size(402, 225);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultIssueEdit";
            this.Text = "Default Issue Edit";
            this.Controls.Add(this.labelDefaultIssueTypeRefCombo);
            this.Controls.Add(this.defaultIssueTypeRefCombo);
            this.Controls.Add(this.labelDefaultIssueStatusRefCombo);
            this.Controls.Add(this.defaultIssueStatusRefCombo);
            this.Controls.Add(this.labelIssueName);
            this.Controls.Add(this.textBoxIssueName);
            this.Controls.Add(this.labelIssueDescription);
            this.Controls.Add(this.textBoxIssueDescription);
            this.Controls.Add(this.labelStepsToReproduce);
            this.Controls.Add(this.textBoxStepsToReproduce);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelFixedNote);
            this.Controls.Add(this.textBoxFixedNote);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
