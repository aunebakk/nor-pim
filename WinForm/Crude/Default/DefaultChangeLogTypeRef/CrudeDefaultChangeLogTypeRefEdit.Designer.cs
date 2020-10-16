namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultChangeLogTypeRefEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxDefaultChangeLogType;

        private System.Windows.Forms.Label labelDefaultChangeLogType;

        private System.Windows.Forms.TextBox textBoxDefaultChangeLogTypeName;

        private System.Windows.Forms.Label labelDefaultChangeLogTypeName;

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
            this.labelDefaultChangeLogType = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeLogType = new System.Windows.Forms.TextBox();
            this.labelDefaultChangeLogTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeLogTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultChangeLogType
            //
            this.labelDefaultChangeLogType.AutoSize = true;
            this.labelDefaultChangeLogType.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultChangeLogType.Name = "labelDefaultChangeLogType";
            this.labelDefaultChangeLogType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogType.TabIndex = 2;
            this.labelDefaultChangeLogType.Text = "Default Change Log Type:";
            //
            //textBoxDefaultChangeLogType
            //
            this.textBoxDefaultChangeLogType.Location = new System.Drawing.Point(196, 13);
            this.textBoxDefaultChangeLogType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeLogType.Name = "textBoxDefaultChangeLogType";
            this.textBoxDefaultChangeLogType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeLogType.TabIndex = 3;
            //
            // labelDefaultChangeLogTypeName
            //
            this.labelDefaultChangeLogTypeName.AutoSize = true;
            this.labelDefaultChangeLogTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultChangeLogTypeName.Name = "labelDefaultChangeLogTypeName";
            this.labelDefaultChangeLogTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogTypeName.TabIndex = 4;
            this.labelDefaultChangeLogTypeName.Text = "Default Change Log Type Name:";
            //
            //textBoxDefaultChangeLogTypeName
            //
            this.textBoxDefaultChangeLogTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxDefaultChangeLogTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeLogTypeName.Name = "textBoxDefaultChangeLogTypeName";
            this.textBoxDefaultChangeLogTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeLogTypeName.TabIndex = 5;
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
            this.Name = "CrudeDefaultChangeLogTypeRefEdit";
            this.Text = "Default Change Log Type Ref Edit";
            this.Controls.Add(this.labelDefaultChangeLogType);
            this.Controls.Add(this.textBoxDefaultChangeLogType);
            this.Controls.Add(this.labelDefaultChangeLogTypeName);
            this.Controls.Add(this.textBoxDefaultChangeLogTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
