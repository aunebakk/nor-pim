namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductExposeSetTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetType;
        
        private System.Windows.Forms.Label labelProductExposeSetType;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetTypeName;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeName;
        
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
            this.labelProductExposeSetType = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetType = new System.Windows.Forms.TextBox();
            this.labelProductExposeSetTypeName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductExposeSetType
            //
            this.labelProductExposeSetType.AutoSize = true;
            this.labelProductExposeSetType.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetType.Name = "labelProductExposeSetType";
            this.labelProductExposeSetType.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetType.TabIndex = 2;
            this.labelProductExposeSetType.Text = "Product Expose Set Type:";
            //
            //textBoxProductExposeSetType
            //
            this.textBoxProductExposeSetType.Location = new System.Drawing.Point(196, 13);
            this.textBoxProductExposeSetType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductExposeSetType.Name = "textBoxProductExposeSetType";
            this.textBoxProductExposeSetType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetType.TabIndex = 3;
            //
            // labelProductExposeSetTypeName
            //
            this.labelProductExposeSetTypeName.AutoSize = true;
            this.labelProductExposeSetTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetTypeName.Name = "labelProductExposeSetTypeName";
            this.labelProductExposeSetTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeName.TabIndex = 4;
            this.labelProductExposeSetTypeName.Text = "Product Expose Set Type Name:";
            //
            //textBoxProductExposeSetTypeName
            //
            this.textBoxProductExposeSetTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxProductExposeSetTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductExposeSetTypeName.Name = "textBoxProductExposeSetTypeName";
            this.textBoxProductExposeSetTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 82);
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
            this.ClientSize = new System.Drawing.Size(458, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductExposeSetTypeRefEdit";
            this.Text = "Product Expose Set Type Ref Edit";
            this.Controls.Add(this.labelProductExposeSetType);
            this.Controls.Add(this.textBoxProductExposeSetType);
            this.Controls.Add(this.labelProductExposeSetTypeName);
            this.Controls.Add(this.textBoxProductExposeSetTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
