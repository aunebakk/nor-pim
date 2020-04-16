namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorType;
        
        private System.Windows.Forms.Label labelDefaultErrorType;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorTypeName;
        
        private System.Windows.Forms.Label labelDefaultErrorTypeName;
        
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
            this.labelDefaultErrorType = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorType = new System.Windows.Forms.TextBox();
            this.labelDefaultErrorTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultErrorType
            //
            this.labelDefaultErrorType.AutoSize = true;
            this.labelDefaultErrorType.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultErrorType.Name = "labelDefaultErrorType";
            this.labelDefaultErrorType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorType.TabIndex = 2;
            this.labelDefaultErrorType.Text = "Default Error Type:";
            //
            //textBoxDefaultErrorType
            //
            this.textBoxDefaultErrorType.Location = new System.Drawing.Point(161, 13);
            this.textBoxDefaultErrorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorType.Name = "textBoxDefaultErrorType";
            this.textBoxDefaultErrorType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorType.TabIndex = 3;
            //
            // labelDefaultErrorTypeName
            //
            this.labelDefaultErrorTypeName.AutoSize = true;
            this.labelDefaultErrorTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultErrorTypeName.Name = "labelDefaultErrorTypeName";
            this.labelDefaultErrorTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorTypeName.TabIndex = 4;
            this.labelDefaultErrorTypeName.Text = "Default Error Type Name:";
            //
            //textBoxDefaultErrorTypeName
            //
            this.textBoxDefaultErrorTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxDefaultErrorTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorTypeName.Name = "textBoxDefaultErrorTypeName";
            this.textBoxDefaultErrorTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorTypeName.TabIndex = 5;
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
            this.Name = "CrudeDefaultErrorTypeRefEdit";
            this.Text = "Default Error Type Ref Edit";
            this.Controls.Add(this.labelDefaultErrorType);
            this.Controls.Add(this.textBoxDefaultErrorType);
            this.Controls.Add(this.labelDefaultErrorTypeName);
            this.Controls.Add(this.textBoxDefaultErrorTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
