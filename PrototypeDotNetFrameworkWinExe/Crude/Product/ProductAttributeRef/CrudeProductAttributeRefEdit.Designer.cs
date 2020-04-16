namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductAttribute;
        
        private System.Windows.Forms.Label labelProductAttribute;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeName;
        
        private System.Windows.Forms.Label labelProductAttributeName;
        
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
            this.labelProductAttribute = new System.Windows.Forms.Label();
            this.textBoxProductAttribute = new System.Windows.Forms.TextBox();
            this.labelProductAttributeName = new System.Windows.Forms.Label();
            this.textBoxProductAttributeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductAttribute
            //
            this.labelProductAttribute.AutoSize = true;
            this.labelProductAttribute.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttribute.Name = "labelProductAttribute";
            this.labelProductAttribute.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttribute.TabIndex = 2;
            this.labelProductAttribute.Text = "Product Attribute:";
            //
            //textBoxProductAttribute
            //
            this.textBoxProductAttribute.Location = new System.Drawing.Point(154, 13);
            this.textBoxProductAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttribute.Name = "textBoxProductAttribute";
            this.textBoxProductAttribute.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttribute.TabIndex = 3;
            //
            // labelProductAttributeName
            //
            this.labelProductAttributeName.AutoSize = true;
            this.labelProductAttributeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeName.Name = "labelProductAttributeName";
            this.labelProductAttributeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeName.TabIndex = 4;
            this.labelProductAttributeName.Text = "Product Attribute Name:";
            //
            //textBoxProductAttributeName
            //
            this.textBoxProductAttributeName.Location = new System.Drawing.Point(154, 36);
            this.textBoxProductAttributeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeName.Name = "textBoxProductAttributeName";
            this.textBoxProductAttributeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(212, 82);
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
            this.ClientSize = new System.Drawing.Size(416, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductAttributeRefEdit";
            this.Text = "Product Attribute Ref Edit";
            this.Controls.Add(this.labelProductAttribute);
            this.Controls.Add(this.textBoxProductAttribute);
            this.Controls.Add(this.labelProductAttributeName);
            this.Controls.Add(this.textBoxProductAttributeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
