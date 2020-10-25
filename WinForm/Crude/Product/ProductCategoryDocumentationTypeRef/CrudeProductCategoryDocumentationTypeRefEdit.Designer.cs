namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryDocumentationTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryDocumentationType;
        
        private System.Windows.Forms.Label labelProductCategoryDocumentationType;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryDocumentationTypeName;
        
        private System.Windows.Forms.Label labelProductCategoryDocumentationTypeName;
        
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
            this.labelProductCategoryDocumentationType = new System.Windows.Forms.Label();
            this.textBoxProductCategoryDocumentationType = new System.Windows.Forms.TextBox();
            this.labelProductCategoryDocumentationTypeName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryDocumentationTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductCategoryDocumentationType
            //
            this.labelProductCategoryDocumentationType.AutoSize = true;
            this.labelProductCategoryDocumentationType.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryDocumentationType.Name = "labelProductCategoryDocumentationType";
            this.labelProductCategoryDocumentationType.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationType.TabIndex = 2;
            this.labelProductCategoryDocumentationType.Text = "Product Category Documentation Type:";
            //
            //textBoxProductCategoryDocumentationType
            //
            this.textBoxProductCategoryDocumentationType.Location = new System.Drawing.Point(280, 13);
            this.textBoxProductCategoryDocumentationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryDocumentationType.Name = "textBoxProductCategoryDocumentationType";
            this.textBoxProductCategoryDocumentationType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryDocumentationType.TabIndex = 3;
            //
            // labelProductCategoryDocumentationTypeName
            //
            this.labelProductCategoryDocumentationTypeName.AutoSize = true;
            this.labelProductCategoryDocumentationTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryDocumentationTypeName.Name = "labelProductCategoryDocumentationTypeName";
            this.labelProductCategoryDocumentationTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationTypeName.TabIndex = 4;
            this.labelProductCategoryDocumentationTypeName.Text = "Product Category Documentation Type Name:";
            //
            //textBoxProductCategoryDocumentationTypeName
            //
            this.textBoxProductCategoryDocumentationTypeName.Location = new System.Drawing.Point(280, 36);
            this.textBoxProductCategoryDocumentationTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryDocumentationTypeName.Name = "textBoxProductCategoryDocumentationTypeName";
            this.textBoxProductCategoryDocumentationTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryDocumentationTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(280, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(438, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(338, 82);
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
            this.ClientSize = new System.Drawing.Size(542, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductCategoryDocumentationTypeRefEdit";
            this.Text = "Product Category Documentation Type Ref Edit";
            this.Controls.Add(this.labelProductCategoryDocumentationType);
            this.Controls.Add(this.textBoxProductCategoryDocumentationType);
            this.Controls.Add(this.labelProductCategoryDocumentationTypeName);
            this.Controls.Add(this.textBoxProductCategoryDocumentationTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
