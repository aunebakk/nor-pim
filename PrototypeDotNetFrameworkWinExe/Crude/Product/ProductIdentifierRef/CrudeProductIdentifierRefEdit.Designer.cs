namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductIdentifierRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductIdentifier;
        
        private System.Windows.Forms.Label labelProductIdentifier;
        
        private System.Windows.Forms.TextBox textBoxProductIdentifierName;
        
        private System.Windows.Forms.Label labelProductIdentifierName;
        
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
            this.labelProductIdentifier = new System.Windows.Forms.Label();
            this.textBoxProductIdentifier = new System.Windows.Forms.TextBox();
            this.labelProductIdentifierName = new System.Windows.Forms.Label();
            this.textBoxProductIdentifierName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductIdentifier
            //
            this.labelProductIdentifier.AutoSize = true;
            this.labelProductIdentifier.Location = new System.Drawing.Point(11, 13);
            this.labelProductIdentifier.Name = "labelProductIdentifier";
            this.labelProductIdentifier.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifier.TabIndex = 2;
            this.labelProductIdentifier.Text = "Product Identifier:";
            //
            //textBoxProductIdentifier
            //
            this.textBoxProductIdentifier.Location = new System.Drawing.Point(161, 13);
            this.textBoxProductIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductIdentifier.Name = "textBoxProductIdentifier";
            this.textBoxProductIdentifier.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductIdentifier.TabIndex = 3;
            //
            // labelProductIdentifierName
            //
            this.labelProductIdentifierName.AutoSize = true;
            this.labelProductIdentifierName.Location = new System.Drawing.Point(11, 36);
            this.labelProductIdentifierName.Name = "labelProductIdentifierName";
            this.labelProductIdentifierName.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifierName.TabIndex = 4;
            this.labelProductIdentifierName.Text = "Product Identifier Name:";
            //
            //textBoxProductIdentifierName
            //
            this.textBoxProductIdentifierName.Location = new System.Drawing.Point(161, 36);
            this.textBoxProductIdentifierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductIdentifierName.Name = "textBoxProductIdentifierName";
            this.textBoxProductIdentifierName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductIdentifierName.TabIndex = 5;
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
            this.Name = "CrudeProductIdentifierRefEdit";
            this.Text = "Product Identifier Ref Edit";
            this.Controls.Add(this.labelProductIdentifier);
            this.Controls.Add(this.textBoxProductIdentifier);
            this.Controls.Add(this.labelProductIdentifierName);
            this.Controls.Add(this.textBoxProductIdentifierName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
