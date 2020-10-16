namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryImageEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ProductCategoryImageTypeRefCombo productCategoryImageTypeRefCombo;

        private System.Windows.Forms.Label labelProductCategoryImageTypeRefCombo;

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
            this.labelProductCategoryImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryImageTypeRefCombo = new ProductCategoryImageTypeRefCombo();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductCategoryImageTypeRefCombo
            //
            this.labelProductCategoryImageTypeRefCombo.AutoSize = true;
            this.labelProductCategoryImageTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryImageTypeRefCombo.Name = "labelProductCategoryImageTypeRefCombo";
            this.labelProductCategoryImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryImageTypeRefCombo.Text = "Product Category Image Type:";
            //
            //productCategoryImageTypeRefCombo
            //
            this.productCategoryImageTypeRefCombo.Location = new System.Drawing.Point(189, 13);
            this.productCategoryImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoryImageTypeRefCombo.Name = "productCategoryImageTypeRefCombo";
            this.productCategoryImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productCategoryImageTypeRefCombo.TabIndex = 3;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 36);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(189, 36);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);

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
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
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
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductCategoryImageEdit";
            this.Text = "Product Category Image Edit";
            this.Controls.Add(this.labelProductCategoryImageTypeRefCombo);
            this.Controls.Add(this.productCategoryImageTypeRefCombo);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
