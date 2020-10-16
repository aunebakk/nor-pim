namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryDocumentationEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ProductCategoryDocumentationTypeRefCombo productCategoryDocumentationTypeRefCombo;

        private System.Windows.Forms.Label labelProductCategoryDocumentationTypeRefCombo;

        private System.Windows.Forms.TextBox textBoxDocumentation;

        private System.Windows.Forms.Label labelDocumentation;

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
            this.labelProductCategoryDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryDocumentationTypeRefCombo = new ProductCategoryDocumentationTypeRefCombo();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.textBoxDocumentation = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductCategoryDocumentationTypeRefCombo
            //
            this.labelProductCategoryDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.Name = "labelProductCategoryDocumentationTypeRefCombo";
            this.labelProductCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryDocumentationTypeRefCombo.Text = "Product Category Documentation Type:";
            //
            //productCategoryDocumentationTypeRefCombo
            //
            this.productCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(245, 13);
            this.productCategoryDocumentationTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoryDocumentationTypeRefCombo.Name = "productCategoryDocumentationTypeRefCombo";
            this.productCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productCategoryDocumentationTypeRefCombo.TabIndex = 3;
            //
            // labelDocumentation
            //
            this.labelDocumentation.AutoSize = true;
            this.labelDocumentation.Location = new System.Drawing.Point(11, 36);
            this.labelDocumentation.Name = "labelDocumentation";
            this.labelDocumentation.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentation.TabIndex = 4;
            this.labelDocumentation.Text = "Documentation:";
            //
            //textBoxDocumentation
            //
            this.textBoxDocumentation.Location = new System.Drawing.Point(245, 36);
            this.textBoxDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocumentation.Name = "textBoxDocumentation";
            this.textBoxDocumentation.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentation.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(245, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(403, 82);

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
            this.buttonSave.Location = new System.Drawing.Point(303, 82);
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
            this.ClientSize = new System.Drawing.Size(507, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductCategoryDocumentationEdit";
            this.Text = "Product Category Documentation Edit";
            this.Controls.Add(this.labelProductCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.productCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.labelDocumentation);
            this.Controls.Add(this.textBoxDocumentation);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
