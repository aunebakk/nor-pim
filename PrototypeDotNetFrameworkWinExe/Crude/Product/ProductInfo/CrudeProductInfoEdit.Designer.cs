namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductInfoEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductInfoRefCombo productInfoRefCombo;
        
        private System.Windows.Forms.Label labelProductInfoRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductInfoValue;
        
        private System.Windows.Forms.Label labelProductInfoValue;
        
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
            this.labelProductInfoRefCombo = new System.Windows.Forms.Label();
            this.productInfoRefCombo = new ProductInfoRefCombo();
            this.labelProductInfoValue = new System.Windows.Forms.Label();
            this.textBoxProductInfoValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelProductInfoRefCombo
            //
            this.labelProductInfoRefCombo.AutoSize = true;
            this.labelProductInfoRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductInfoRefCombo.Name = "labelProductInfoRefCombo";
            this.labelProductInfoRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoRefCombo.TabIndex = 2;
            this.labelProductInfoRefCombo.Text = "Product Info:";
            //
            //productInfoRefCombo
            //
            this.productInfoRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productInfoRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productInfoRefCombo.Name = "productInfoRefCombo";
            this.productInfoRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productInfoRefCombo.TabIndex = 3;
            //
            // labelProductInfoValue
            //
            this.labelProductInfoValue.AutoSize = true;
            this.labelProductInfoValue.Location = new System.Drawing.Point(11, 36);
            this.labelProductInfoValue.Name = "labelProductInfoValue";
            this.labelProductInfoValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoValue.TabIndex = 4;
            this.labelProductInfoValue.Text = "Product Info Value:";
            //
            //textBoxProductInfoValue
            //
            this.textBoxProductInfoValue.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInfoValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfoValue.Name = "textBoxProductInfoValue";
            this.textBoxProductInfoValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfoValue.TabIndex = 5;
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
            this.Name = "CrudeProductInfoEdit";
            this.Text = "Product Info Edit";
            this.Controls.Add(this.labelProductInfoRefCombo);
            this.Controls.Add(this.productInfoRefCombo);
            this.Controls.Add(this.labelProductInfoValue);
            this.Controls.Add(this.textBoxProductInfoValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
