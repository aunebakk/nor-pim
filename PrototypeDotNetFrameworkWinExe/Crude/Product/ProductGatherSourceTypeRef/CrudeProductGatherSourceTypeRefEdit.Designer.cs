namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductGatherSourceType;
        
        private System.Windows.Forms.Label labelProductGatherSourceType;
        
        private System.Windows.Forms.TextBox textBoxProductGatherSourceTypeName;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeName;
        
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
            this.labelProductGatherSourceType = new System.Windows.Forms.Label();
            this.textBoxProductGatherSourceType = new System.Windows.Forms.TextBox();
            this.labelProductGatherSourceTypeName = new System.Windows.Forms.Label();
            this.textBoxProductGatherSourceTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductGatherSourceType
            //
            this.labelProductGatherSourceType.AutoSize = true;
            this.labelProductGatherSourceType.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherSourceType.Name = "labelProductGatherSourceType";
            this.labelProductGatherSourceType.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceType.TabIndex = 2;
            this.labelProductGatherSourceType.Text = "Product Gather Source Type:";
            //
            //textBoxProductGatherSourceType
            //
            this.textBoxProductGatherSourceType.Location = new System.Drawing.Point(217, 13);
            this.textBoxProductGatherSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherSourceType.Name = "textBoxProductGatherSourceType";
            this.textBoxProductGatherSourceType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherSourceType.TabIndex = 3;
            //
            // labelProductGatherSourceTypeName
            //
            this.labelProductGatherSourceTypeName.AutoSize = true;
            this.labelProductGatherSourceTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherSourceTypeName.Name = "labelProductGatherSourceTypeName";
            this.labelProductGatherSourceTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeName.TabIndex = 4;
            this.labelProductGatherSourceTypeName.Text = "Product Gather Source Type Name:";
            //
            //textBoxProductGatherSourceTypeName
            //
            this.textBoxProductGatherSourceTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductGatherSourceTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherSourceTypeName.Name = "textBoxProductGatherSourceTypeName";
            this.textBoxProductGatherSourceTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherSourceTypeName.TabIndex = 5;
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
            this.Name = "CrudeProductGatherSourceTypeRefEdit";
            this.Text = "Product Gather Source Type Ref Edit";
            this.Controls.Add(this.labelProductGatherSourceType);
            this.Controls.Add(this.textBoxProductGatherSourceType);
            this.Controls.Add(this.labelProductGatherSourceTypeName);
            this.Controls.Add(this.textBoxProductGatherSourceTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
