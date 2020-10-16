namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateTime;

        private System.Windows.Forms.Label labelStartDateTime;

        private System.Windows.Forms.DateTimePicker dateTimePickerFinishDateTime;

        private System.Windows.Forms.Label labelFinishDateTime;

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
            this.labelStartDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFinishDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFinishDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelStartDateTime
            //
            this.labelStartDateTime.AutoSize = true;
            this.labelStartDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelStartDateTime.Name = "labelStartDateTime";
            this.labelStartDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelStartDateTime.TabIndex = 2;
            this.labelStartDateTime.Text = "Start Date Time:";
            //
            //dateTimePickerStartDateTime
            //
            this.dateTimePickerStartDateTime.Location = new System.Drawing.Point(140, 13);
            this.dateTimePickerStartDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartDateTime.Name = "dateTimePickerStartDateTime";
            this.dateTimePickerStartDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerStartDateTime.TabIndex = 3;
            this.dateTimePickerStartDateTime.Checked = false;
            this.dateTimePickerStartDateTime.ShowCheckBox = true;
            //
            // labelFinishDateTime
            //
            this.labelFinishDateTime.AutoSize = true;
            this.labelFinishDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelFinishDateTime.Name = "labelFinishDateTime";
            this.labelFinishDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFinishDateTime.TabIndex = 4;
            this.labelFinishDateTime.Text = "Finish Date Time:";
            //
            //dateTimePickerFinishDateTime
            //
            this.dateTimePickerFinishDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerFinishDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFinishDateTime.Name = "dateTimePickerFinishDateTime";
            this.dateTimePickerFinishDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFinishDateTime.TabIndex = 5;
            this.dateTimePickerFinishDateTime.Checked = false;
            this.dateTimePickerFinishDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductGatherEdit";
            this.Text = "Product Gather Edit";
            this.Controls.Add(this.labelStartDateTime);
            this.Controls.Add(this.dateTimePickerStartDateTime);
            this.Controls.Add(this.labelFinishDateTime);
            this.Controls.Add(this.dateTimePickerFinishDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
