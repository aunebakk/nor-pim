namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultVersionEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxFunVersion;

        private System.Windows.Forms.Label labelFunVersion;

        private System.Windows.Forms.TextBox textBoxNumber;

        private System.Windows.Forms.Label labelNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxMajorNumber;

        private System.Windows.Forms.Label labelMajorNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxMinorNumber;

        private System.Windows.Forms.Label labelMinorNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxSequenceNumber;

        private System.Windows.Forms.Label labelSequenceNumber;

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
            this.labelFunVersion = new System.Windows.Forms.Label();
            this.textBoxFunVersion = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelMajorNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxMajorNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelMinorNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxMinorNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelFunVersion
            //
            this.labelFunVersion.AutoSize = true;
            this.labelFunVersion.Location = new System.Drawing.Point(11, 13);
            this.labelFunVersion.Name = "labelFunVersion";
            this.labelFunVersion.Size = new System.Drawing.Size(71, 13);
            this.labelFunVersion.TabIndex = 2;
            this.labelFunVersion.Text = "Fun Version:";
            //
            //textBoxFunVersion
            //
            this.textBoxFunVersion.Location = new System.Drawing.Point(140, 13);
            this.textBoxFunVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFunVersion.Name = "textBoxFunVersion";
            this.textBoxFunVersion.Size = new System.Drawing.Size(250, 20);
            this.textBoxFunVersion.TabIndex = 3;
            //
            // labelNumber
            //
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(11, 36);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(71, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Number:";
            //
            //textBoxNumber
            //
            this.textBoxNumber.Location = new System.Drawing.Point(140, 36);
            this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxNumber.TabIndex = 5;
            //
            // labelMajorNumber
            //
            this.labelMajorNumber.AutoSize = true;
            this.labelMajorNumber.Location = new System.Drawing.Point(11, 59);
            this.labelMajorNumber.Name = "labelMajorNumber";
            this.labelMajorNumber.Size = new System.Drawing.Size(71, 13);
            this.labelMajorNumber.TabIndex = 6;
            this.labelMajorNumber.Text = "Major Number:";
            //
            //maskedTextBoxMajorNumber
            //
            this.maskedTextBoxMajorNumber.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxMajorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMajorNumber.Name = "maskedTextBoxMajorNumber";
            this.maskedTextBoxMajorNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMajorNumber.TabIndex = 7;
            //
            // labelMinorNumber
            //
            this.labelMinorNumber.AutoSize = true;
            this.labelMinorNumber.Location = new System.Drawing.Point(11, 82);
            this.labelMinorNumber.Name = "labelMinorNumber";
            this.labelMinorNumber.Size = new System.Drawing.Size(71, 13);
            this.labelMinorNumber.TabIndex = 8;
            this.labelMinorNumber.Text = "Minor Number:";
            //
            //maskedTextBoxMinorNumber
            //
            this.maskedTextBoxMinorNumber.Location = new System.Drawing.Point(140, 82);
            this.maskedTextBoxMinorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMinorNumber.Name = "maskedTextBoxMinorNumber";
            this.maskedTextBoxMinorNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMinorNumber.TabIndex = 9;
            //
            // labelSequenceNumber
            //
            this.labelSequenceNumber.AutoSize = true;
            this.labelSequenceNumber.Location = new System.Drawing.Point(11, 105);
            this.labelSequenceNumber.Name = "labelSequenceNumber";
            this.labelSequenceNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSequenceNumber.TabIndex = 10;
            this.labelSequenceNumber.Text = "Sequence Number:";
            //
            //maskedTextBoxSequenceNumber
            //
            this.maskedTextBoxSequenceNumber.Location = new System.Drawing.Point(140, 105);
            this.maskedTextBoxSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSequenceNumber.Name = "maskedTextBoxSequenceNumber";
            this.maskedTextBoxSequenceNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSequenceNumber.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 151);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 151);
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
            this.ClientSize = new System.Drawing.Size(402, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultVersionEdit";
            this.Text = "Default Version Edit";
            this.Controls.Add(this.labelFunVersion);
            this.Controls.Add(this.textBoxFunVersion);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelMajorNumber);
            this.Controls.Add(this.maskedTextBoxMajorNumber);
            this.Controls.Add(this.labelMinorNumber);
            this.Controls.Add(this.maskedTextBoxMinorNumber);
            this.Controls.Add(this.labelSequenceNumber);
            this.Controls.Add(this.maskedTextBoxSequenceNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
