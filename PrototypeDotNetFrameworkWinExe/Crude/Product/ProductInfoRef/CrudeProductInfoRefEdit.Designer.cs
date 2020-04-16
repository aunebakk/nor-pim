namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductInfoRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxProductInfo;
        
        private System.Windows.Forms.Label labelProductInfo;
        
        private System.Windows.Forms.TextBox textBoxProductInfoName;
        
        private System.Windows.Forms.Label labelProductInfoName;
        
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
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.textBoxProductInfo = new System.Windows.Forms.TextBox();
            this.labelProductInfoName = new System.Windows.Forms.Label();
            this.textBoxProductInfoName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductInfo
            //
            this.labelProductInfo.AutoSize = true;
            this.labelProductInfo.Location = new System.Drawing.Point(11, 13);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfo.TabIndex = 2;
            this.labelProductInfo.Text = "Product Info:";
            //
            //textBoxProductInfo
            //
            this.textBoxProductInfo.Location = new System.Drawing.Point(140, 13);
            this.textBoxProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfo.Name = "textBoxProductInfo";
            this.textBoxProductInfo.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfo.TabIndex = 3;
            //
            // labelProductInfoName
            //
            this.labelProductInfoName.AutoSize = true;
            this.labelProductInfoName.Location = new System.Drawing.Point(11, 36);
            this.labelProductInfoName.Name = "labelProductInfoName";
            this.labelProductInfoName.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoName.TabIndex = 4;
            this.labelProductInfoName.Text = "Product Info Name:";
            //
            //textBoxProductInfoName
            //
            this.textBoxProductInfoName.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInfoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfoName.Name = "textBoxProductInfoName";
            this.textBoxProductInfoName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfoName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeProductInfoRefEdit";
            this.Text = "Product Info Ref Edit";
            this.Controls.Add(this.labelProductInfo);
            this.Controls.Add(this.textBoxProductInfo);
            this.Controls.Add(this.labelProductInfoName);
            this.Controls.Add(this.textBoxProductInfoName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
