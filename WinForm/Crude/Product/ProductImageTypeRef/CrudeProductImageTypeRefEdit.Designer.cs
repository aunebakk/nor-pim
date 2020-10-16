namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductImageTypeRefEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.TextBox textBoxProductImageType;

        private System.Windows.Forms.Label labelProductImageType;

        private System.Windows.Forms.TextBox textBoxProductImageTypeName;

        private System.Windows.Forms.Label labelProductImageTypeName;

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
            this.labelProductImageType = new System.Windows.Forms.Label();
            this.textBoxProductImageType = new System.Windows.Forms.TextBox();
            this.labelProductImageTypeName = new System.Windows.Forms.Label();
            this.textBoxProductImageTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductImageType
            //
            this.labelProductImageType.AutoSize = true;
            this.labelProductImageType.Location = new System.Drawing.Point(11, 13);
            this.labelProductImageType.Name = "labelProductImageType";
            this.labelProductImageType.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageType.TabIndex = 2;
            this.labelProductImageType.Text = "Product Image Type:";
            //
            //textBoxProductImageType
            //
            this.textBoxProductImageType.Location = new System.Drawing.Point(161, 13);
            this.textBoxProductImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductImageType.Name = "textBoxProductImageType";
            this.textBoxProductImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductImageType.TabIndex = 3;
            //
            // labelProductImageTypeName
            //
            this.labelProductImageTypeName.AutoSize = true;
            this.labelProductImageTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductImageTypeName.Name = "labelProductImageTypeName";
            this.labelProductImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageTypeName.TabIndex = 4;
            this.labelProductImageTypeName.Text = "Product Image Type Name:";
            //
            //textBoxProductImageTypeName
            //
            this.textBoxProductImageTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxProductImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductImageTypeName.Name = "textBoxProductImageTypeName";
            this.textBoxProductImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductImageTypeName.TabIndex = 5;
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
            this.Name = "CrudeProductImageTypeRefEdit";
            this.Text = "Product Image Type Ref Edit";
            this.Controls.Add(this.labelProductImageType);
            this.Controls.Add(this.textBoxProductImageType);
            this.Controls.Add(this.labelProductImageTypeName);
            this.Controls.Add(this.textBoxProductImageTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
