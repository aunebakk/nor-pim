namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxLocationAddressType;
        
        private System.Windows.Forms.Label labelLocationAddressType;
        
        private System.Windows.Forms.TextBox textBoxLocationAddressTypeName;
        
        private System.Windows.Forms.Label labelLocationAddressTypeName;
        
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
            this.labelLocationAddressType = new System.Windows.Forms.Label();
            this.textBoxLocationAddressType = new System.Windows.Forms.TextBox();
            this.labelLocationAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxLocationAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLocationAddressType
            //
            this.labelLocationAddressType.AutoSize = true;
            this.labelLocationAddressType.Location = new System.Drawing.Point(11, 13);
            this.labelLocationAddressType.Name = "labelLocationAddressType";
            this.labelLocationAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelLocationAddressType.TabIndex = 2;
            this.labelLocationAddressType.Text = "Location Address Type:";
            //
            //textBoxLocationAddressType
            //
            this.textBoxLocationAddressType.Location = new System.Drawing.Point(182, 13);
            this.textBoxLocationAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationAddressType.Name = "textBoxLocationAddressType";
            this.textBoxLocationAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationAddressType.TabIndex = 3;
            //
            // labelLocationAddressTypeName
            //
            this.labelLocationAddressTypeName.AutoSize = true;
            this.labelLocationAddressTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelLocationAddressTypeName.Name = "labelLocationAddressTypeName";
            this.labelLocationAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationAddressTypeName.TabIndex = 4;
            this.labelLocationAddressTypeName.Text = "Location Address Type Name:";
            //
            //textBoxLocationAddressTypeName
            //
            this.textBoxLocationAddressTypeName.Location = new System.Drawing.Point(182, 36);
            this.textBoxLocationAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationAddressTypeName.Name = "textBoxLocationAddressTypeName";
            this.textBoxLocationAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationAddressTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(240, 82);
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
            this.ClientSize = new System.Drawing.Size(444, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeLocationAddressTypeRefEdit";
            this.Text = "Location Address Type Ref Edit";
            this.Controls.Add(this.labelLocationAddressType);
            this.Controls.Add(this.textBoxLocationAddressType);
            this.Controls.Add(this.labelLocationAddressTypeName);
            this.Controls.Add(this.textBoxLocationAddressTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
