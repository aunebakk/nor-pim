namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeUnitRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeUnit;
        
        private System.Windows.Forms.Label labelProductAttributeUnit;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeUnitName;
        
        private System.Windows.Forms.Label labelProductAttributeUnitName;
        
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
            this.labelProductAttributeUnit = new System.Windows.Forms.Label();
            this.textBoxProductAttributeUnit = new System.Windows.Forms.TextBox();
            this.labelProductAttributeUnitName = new System.Windows.Forms.Label();
            this.textBoxProductAttributeUnitName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductAttributeUnit
            //
            this.labelProductAttributeUnit.AutoSize = true;
            this.labelProductAttributeUnit.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttributeUnit.Name = "labelProductAttributeUnit";
            this.labelProductAttributeUnit.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnit.TabIndex = 2;
            this.labelProductAttributeUnit.Text = "Product Attribute Unit:";
            //
            //textBoxProductAttributeUnit
            //
            this.textBoxProductAttributeUnit.Location = new System.Drawing.Point(189, 13);
            this.textBoxProductAttributeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeUnit.Name = "textBoxProductAttributeUnit";
            this.textBoxProductAttributeUnit.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeUnit.TabIndex = 3;
            //
            // labelProductAttributeUnitName
            //
            this.labelProductAttributeUnitName.AutoSize = true;
            this.labelProductAttributeUnitName.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeUnitName.Name = "labelProductAttributeUnitName";
            this.labelProductAttributeUnitName.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitName.TabIndex = 4;
            this.labelProductAttributeUnitName.Text = "Product Attribute Unit Name:";
            //
            //textBoxProductAttributeUnitName
            //
            this.textBoxProductAttributeUnitName.Location = new System.Drawing.Point(189, 36);
            this.textBoxProductAttributeUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeUnitName.Name = "textBoxProductAttributeUnitName";
            this.textBoxProductAttributeUnitName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeUnitName.TabIndex = 5;
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
            this.Name = "CrudeProductAttributeUnitRefEdit";
            this.Text = "Product Attribute Unit Ref Edit";
            this.Controls.Add(this.labelProductAttributeUnit);
            this.Controls.Add(this.textBoxProductAttributeUnit);
            this.Controls.Add(this.labelProductAttributeUnitName);
            this.Controls.Add(this.textBoxProductAttributeUnitName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
