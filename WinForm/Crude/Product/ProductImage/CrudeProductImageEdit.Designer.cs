namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductImageEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ProductImageTypeRefCombo productImageTypeRefCombo;

        private System.Windows.Forms.Label labelProductImageTypeRefCombo;

        private System.Windows.Forms.TextBox textBoxImageFileName;

        private System.Windows.Forms.Label labelImageFileName;

        private System.Windows.Forms.PictureBox pictureBoxImage;

        private System.Windows.Forms.Label labelImage;

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
            this.labelProductImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productImageTypeRefCombo = new ProductImageTypeRefCombo();
            this.labelImageFileName = new System.Windows.Forms.Label();
            this.textBoxImageFileName = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductImageTypeRefCombo
            //
            this.labelProductImageTypeRefCombo.AutoSize = true;
            this.labelProductImageTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductImageTypeRefCombo.Name = "labelProductImageTypeRefCombo";
            this.labelProductImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageTypeRefCombo.TabIndex = 2;
            this.labelProductImageTypeRefCombo.Text = "Product Image Type:";
            //
            //productImageTypeRefCombo
            //
            this.productImageTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productImageTypeRefCombo.Name = "productImageTypeRefCombo";
            this.productImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productImageTypeRefCombo.TabIndex = 3;
            //
            // labelImageFileName
            //
            this.labelImageFileName.AutoSize = true;
            this.labelImageFileName.Location = new System.Drawing.Point(11, 36);
            this.labelImageFileName.Name = "labelImageFileName";
            this.labelImageFileName.Size = new System.Drawing.Size(71, 13);
            this.labelImageFileName.TabIndex = 4;
            this.labelImageFileName.Text = "Image File Name:";
            //
            //textBoxImageFileName
            //
            this.textBoxImageFileName.Location = new System.Drawing.Point(140, 36);
            this.textBoxImageFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFileName.Name = "textBoxImageFileName";
            this.textBoxImageFileName.Size = new System.Drawing.Size(250, 20);
            this.textBoxImageFileName.TabIndex = 5;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 59);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(140, 59);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 105);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 105);
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
            this.ClientSize = new System.Drawing.Size(402, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductImageEdit";
            this.Text = "Product Image Edit";
            this.Controls.Add(this.labelProductImageTypeRefCombo);
            this.Controls.Add(this.productImageTypeRefCombo);
            this.Controls.Add(this.labelImageFileName);
            this.Controls.Add(this.textBoxImageFileName);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
