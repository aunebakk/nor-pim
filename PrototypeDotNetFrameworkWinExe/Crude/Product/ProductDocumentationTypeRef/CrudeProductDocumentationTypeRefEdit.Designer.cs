namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductDocumentationTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductDocumentationType;
        
        private System.Windows.Forms.Label labelProductDocumentationType;
        
        private System.Windows.Forms.TextBox textBoxProductDocumentationTypeName;
        
        private System.Windows.Forms.Label labelProductDocumentationTypeName;
        
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
            this.labelProductDocumentationType = new System.Windows.Forms.Label();
            this.textBoxProductDocumentationType = new System.Windows.Forms.TextBox();
            this.labelProductDocumentationTypeName = new System.Windows.Forms.Label();
            this.textBoxProductDocumentationTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductDocumentationType
            //
            this.labelProductDocumentationType.AutoSize = true;
            this.labelProductDocumentationType.Location = new System.Drawing.Point(11, 13);
            this.labelProductDocumentationType.Name = "labelProductDocumentationType";
            this.labelProductDocumentationType.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationType.TabIndex = 2;
            this.labelProductDocumentationType.Text = "Product Documentation Type:";
            //
            //textBoxProductDocumentationType
            //
            this.textBoxProductDocumentationType.Location = new System.Drawing.Point(217, 13);
            this.textBoxProductDocumentationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductDocumentationType.Name = "textBoxProductDocumentationType";
            this.textBoxProductDocumentationType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductDocumentationType.TabIndex = 3;
            //
            // labelProductDocumentationTypeName
            //
            this.labelProductDocumentationTypeName.AutoSize = true;
            this.labelProductDocumentationTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductDocumentationTypeName.Name = "labelProductDocumentationTypeName";
            this.labelProductDocumentationTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeName.TabIndex = 4;
            this.labelProductDocumentationTypeName.Text = "Product Documentation Type Name:";
            //
            //textBoxProductDocumentationTypeName
            //
            this.textBoxProductDocumentationTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductDocumentationTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductDocumentationTypeName.Name = "textBoxProductDocumentationTypeName";
            this.textBoxProductDocumentationTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductDocumentationTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(275, 82);
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
            this.ClientSize = new System.Drawing.Size(479, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductDocumentationTypeRefEdit";
            this.Text = "Product Documentation Type Ref Edit";
            this.Controls.Add(this.labelProductDocumentationType);
            this.Controls.Add(this.textBoxProductDocumentationType);
            this.Controls.Add(this.labelProductDocumentationTypeName);
            this.Controls.Add(this.textBoxProductDocumentationTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
