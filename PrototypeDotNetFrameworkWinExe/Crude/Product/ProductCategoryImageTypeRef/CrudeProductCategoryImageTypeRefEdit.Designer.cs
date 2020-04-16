namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryImageType;
        
        private System.Windows.Forms.Label labelProductCategoryImageType;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryImageTypeName;
        
        private System.Windows.Forms.Label labelProductCategoryImageTypeName;
        
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
            this.labelProductCategoryImageType = new System.Windows.Forms.Label();
            this.textBoxProductCategoryImageType = new System.Windows.Forms.TextBox();
            this.labelProductCategoryImageTypeName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryImageTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductCategoryImageType
            //
            this.labelProductCategoryImageType.AutoSize = true;
            this.labelProductCategoryImageType.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryImageType.Name = "labelProductCategoryImageType";
            this.labelProductCategoryImageType.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageType.TabIndex = 2;
            this.labelProductCategoryImageType.Text = "Product Category Image Type:";
            //
            //textBoxProductCategoryImageType
            //
            this.textBoxProductCategoryImageType.Location = new System.Drawing.Point(224, 13);
            this.textBoxProductCategoryImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryImageType.Name = "textBoxProductCategoryImageType";
            this.textBoxProductCategoryImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryImageType.TabIndex = 3;
            //
            // labelProductCategoryImageTypeName
            //
            this.labelProductCategoryImageTypeName.AutoSize = true;
            this.labelProductCategoryImageTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryImageTypeName.Name = "labelProductCategoryImageTypeName";
            this.labelProductCategoryImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageTypeName.TabIndex = 4;
            this.labelProductCategoryImageTypeName.Text = "Product Category Image Type Name:";
            //
            //textBoxProductCategoryImageTypeName
            //
            this.textBoxProductCategoryImageTypeName.Location = new System.Drawing.Point(224, 36);
            this.textBoxProductCategoryImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryImageTypeName.Name = "textBoxProductCategoryImageTypeName";
            this.textBoxProductCategoryImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryImageTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(282, 82);
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
            this.ClientSize = new System.Drawing.Size(486, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductCategoryImageTypeRefEdit";
            this.Text = "Product Category Image Type Ref Edit";
            this.Controls.Add(this.labelProductCategoryImageType);
            this.Controls.Add(this.textBoxProductCategoryImageType);
            this.Controls.Add(this.labelProductCategoryImageTypeName);
            this.Controls.Add(this.textBoxProductCategoryImageTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
