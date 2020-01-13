namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultRuleTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultRuleType;
        
        private System.Windows.Forms.Label labelDefaultRuleType;
        
        private System.Windows.Forms.TextBox textBoxDefaultRuleTypeName;
        
        private System.Windows.Forms.Label labelDefaultRuleTypeName;
        
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
            this.labelDefaultRuleType = new System.Windows.Forms.Label();
            this.textBoxDefaultRuleType = new System.Windows.Forms.TextBox();
            this.labelDefaultRuleTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultRuleTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultRuleType
            //
            this.labelDefaultRuleType.AutoSize = true;
            this.labelDefaultRuleType.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultRuleType.Name = "labelDefaultRuleType";
            this.labelDefaultRuleType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultRuleType.TabIndex = 2;
            this.labelDefaultRuleType.Text = "Default Rule Type:";
            //
            //textBoxDefaultRuleType
            //
            this.textBoxDefaultRuleType.Location = new System.Drawing.Point(154, 13);
            this.textBoxDefaultRuleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultRuleType.Name = "textBoxDefaultRuleType";
            this.textBoxDefaultRuleType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultRuleType.TabIndex = 3;
            //
            // labelDefaultRuleTypeName
            //
            this.labelDefaultRuleTypeName.AutoSize = true;
            this.labelDefaultRuleTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultRuleTypeName.Name = "labelDefaultRuleTypeName";
            this.labelDefaultRuleTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultRuleTypeName.TabIndex = 4;
            this.labelDefaultRuleTypeName.Text = "Default Rule Type Name:";
            //
            //textBoxDefaultRuleTypeName
            //
            this.textBoxDefaultRuleTypeName.Location = new System.Drawing.Point(154, 36);
            this.textBoxDefaultRuleTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultRuleTypeName.Name = "textBoxDefaultRuleTypeName";
            this.textBoxDefaultRuleTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultRuleTypeName.TabIndex = 5;
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
            this.Name = "CrudeDefaultRuleTypeRefEdit";
            this.Text = "Default Rule Type Ref Edit";
            this.Controls.Add(this.labelDefaultRuleType);
            this.Controls.Add(this.textBoxDefaultRuleType);
            this.Controls.Add(this.labelDefaultRuleTypeName);
            this.Controls.Add(this.textBoxDefaultRuleTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
