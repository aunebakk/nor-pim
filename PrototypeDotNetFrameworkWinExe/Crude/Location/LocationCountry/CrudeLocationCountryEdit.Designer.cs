namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCountryEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxLocationCountryCode;
        
        private System.Windows.Forms.Label labelLocationCountryCode;
        
        private System.Windows.Forms.TextBox textBoxLocationCountryName;
        
        private System.Windows.Forms.Label labelLocationCountryName;
        
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
            this.labelLocationCountryCode = new System.Windows.Forms.Label();
            this.textBoxLocationCountryCode = new System.Windows.Forms.TextBox();
            this.labelLocationCountryName = new System.Windows.Forms.Label();
            this.textBoxLocationCountryName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLocationCountryCode
            //
            this.labelLocationCountryCode.AutoSize = true;
            this.labelLocationCountryCode.Location = new System.Drawing.Point(11, 13);
            this.labelLocationCountryCode.Name = "labelLocationCountryCode";
            this.labelLocationCountryCode.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCountryCode.TabIndex = 2;
            this.labelLocationCountryCode.Text = "Location Country Code:";
            //
            //textBoxLocationCountryCode
            //
            this.textBoxLocationCountryCode.Location = new System.Drawing.Point(147, 13);
            this.textBoxLocationCountryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCountryCode.Name = "textBoxLocationCountryCode";
            this.textBoxLocationCountryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCountryCode.TabIndex = 3;
            //
            // labelLocationCountryName
            //
            this.labelLocationCountryName.AutoSize = true;
            this.labelLocationCountryName.Location = new System.Drawing.Point(11, 36);
            this.labelLocationCountryName.Name = "labelLocationCountryName";
            this.labelLocationCountryName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCountryName.TabIndex = 4;
            this.labelLocationCountryName.Text = "Location Country Name:";
            //
            //textBoxLocationCountryName
            //
            this.textBoxLocationCountryName.Location = new System.Drawing.Point(147, 36);
            this.textBoxLocationCountryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCountryName.Name = "textBoxLocationCountryName";
            this.textBoxLocationCountryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCountryName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 82);
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
            this.ClientSize = new System.Drawing.Size(409, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeLocationCountryEdit";
            this.Text = "Location Country Edit";
            this.Controls.Add(this.labelLocationCountryCode);
            this.Controls.Add(this.textBoxLocationCountryCode);
            this.Controls.Add(this.labelLocationCountryName);
            this.Controls.Add(this.textBoxLocationCountryName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
