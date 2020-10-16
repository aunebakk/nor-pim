namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultTestRunEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private DefaultTestRunResultRefCombo defaultTestRunResultRefCombo;

        private System.Windows.Forms.Label labelDefaultTestRunResultRefCombo;

        private System.Windows.Forms.TextBox textBoxResult;

        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateTime;

        private System.Windows.Forms.Label labelStartDateTime;

        private System.Windows.Forms.DateTimePicker dateTimePickerEndDateTime;

        private System.Windows.Forms.Label labelEndDateTime;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxElapsedMilliseconds;

        private System.Windows.Forms.Label labelElapsedMilliseconds;

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
            this.labelDefaultTestRunResultRefCombo = new System.Windows.Forms.Label();
            this.defaultTestRunResultRefCombo = new DefaultTestRunResultRefCombo();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelStartDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelEndDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelElapsedMilliseconds = new System.Windows.Forms.Label();
            this.maskedTextBoxElapsedMilliseconds = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelDefaultTestRunResultRefCombo
            //
            this.labelDefaultTestRunResultRefCombo.AutoSize = true;
            this.labelDefaultTestRunResultRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultTestRunResultRefCombo.Name = "labelDefaultTestRunResultRefCombo";
            this.labelDefaultTestRunResultRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultTestRunResultRefCombo.TabIndex = 2;
            this.labelDefaultTestRunResultRefCombo.Text = "Default Test Run Result:";
            //
            //defaultTestRunResultRefCombo
            //
            this.defaultTestRunResultRefCombo.Location = new System.Drawing.Point(161, 13);
            this.defaultTestRunResultRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultTestRunResultRefCombo.Name = "defaultTestRunResultRefCombo";
            this.defaultTestRunResultRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultTestRunResultRefCombo.TabIndex = 3;
            //
            // labelResult
            //
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(11, 36);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(71, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result:";
            //
            //textBoxResult
            //
            this.textBoxResult.Location = new System.Drawing.Point(161, 36);
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(250, 20);
            this.textBoxResult.TabIndex = 5;
            //
            // labelStartDateTime
            //
            this.labelStartDateTime.AutoSize = true;
            this.labelStartDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelStartDateTime.Name = "labelStartDateTime";
            this.labelStartDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelStartDateTime.TabIndex = 6;
            this.labelStartDateTime.Text = "Start Date Time:";
            //
            //dateTimePickerStartDateTime
            //
            this.dateTimePickerStartDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerStartDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartDateTime.Name = "dateTimePickerStartDateTime";
            this.dateTimePickerStartDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerStartDateTime.TabIndex = 7;
            this.dateTimePickerStartDateTime.Checked = false;
            this.dateTimePickerStartDateTime.ShowCheckBox = true;
            //
            // labelEndDateTime
            //
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelEndDateTime.TabIndex = 8;
            this.labelEndDateTime.Text = "End Date Time:";
            //
            //dateTimePickerEndDateTime
            //
            this.dateTimePickerEndDateTime.Location = new System.Drawing.Point(161, 82);
            this.dateTimePickerEndDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEndDateTime.Name = "dateTimePickerEndDateTime";
            this.dateTimePickerEndDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerEndDateTime.TabIndex = 9;
            this.dateTimePickerEndDateTime.Checked = false;
            this.dateTimePickerEndDateTime.ShowCheckBox = true;
            //
            // labelElapsedMilliseconds
            //
            this.labelElapsedMilliseconds.AutoSize = true;
            this.labelElapsedMilliseconds.Location = new System.Drawing.Point(11, 105);
            this.labelElapsedMilliseconds.Name = "labelElapsedMilliseconds";
            this.labelElapsedMilliseconds.Size = new System.Drawing.Size(71, 13);
            this.labelElapsedMilliseconds.TabIndex = 10;
            this.labelElapsedMilliseconds.Text = "Elapsed Milliseconds:";
            //
            //maskedTextBoxElapsedMilliseconds
            //
            this.maskedTextBoxElapsedMilliseconds.Location = new System.Drawing.Point(161, 105);
            this.maskedTextBoxElapsedMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxElapsedMilliseconds.Name = "maskedTextBoxElapsedMilliseconds";
            this.maskedTextBoxElapsedMilliseconds.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxElapsedMilliseconds.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 128);
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
            this.buttonClose.Location = new System.Drawing.Point(319, 151);

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
            this.buttonSave.Location = new System.Drawing.Point(219, 151);
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
            this.ClientSize = new System.Drawing.Size(423, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultTestRunEdit";
            this.Text = "Default Test Run Edit";
            this.Controls.Add(this.labelDefaultTestRunResultRefCombo);
            this.Controls.Add(this.defaultTestRunResultRefCombo);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelStartDateTime);
            this.Controls.Add(this.dateTimePickerStartDateTime);
            this.Controls.Add(this.labelEndDateTime);
            this.Controls.Add(this.dateTimePickerEndDateTime);
            this.Controls.Add(this.labelElapsedMilliseconds);
            this.Controls.Add(this.maskedTextBoxElapsedMilliseconds);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
