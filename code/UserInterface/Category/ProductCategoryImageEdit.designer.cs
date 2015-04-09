namespace norpim.UserInterface {
    
    
    public partial class ProductCategoryImageEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button btnClose;
        
        private System.Windows.Forms.Button btnSave;
        
        private ProductCategoryImageTypeRefCombo productCategoryImageTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductCategoryImageTypeRefCombo;
        
        private System.Windows.Forms.PictureBox pictureBoxImage;
        
        private System.Windows.Forms.Label labelImage;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelProductCategoryImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryImageTypeRefCombo = new norpim.UserInterface.ProductCategoryImageTypeRefCombo();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(290, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(192, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelProductCategoryImageTypeRefCombo
            // 
            this.labelProductCategoryImageTypeRefCombo.AutoSize = true;
            this.labelProductCategoryImageTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryImageTypeRefCombo.Name = "labelProductCategoryImageTypeRefCombo";
            this.labelProductCategoryImageTypeRefCombo.Size = new System.Drawing.Size(151, 13);
            this.labelProductCategoryImageTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryImageTypeRefCombo.Text = "Product Category Image Type:";
            // 
            // productCategoryImageTypeRefCombo
            // 
            this.productCategoryImageTypeRefCombo.Location = new System.Drawing.Point(182, 13);
            this.productCategoryImageTypeRefCombo.Name = "productCategoryImageTypeRefCombo";
            this.productCategoryImageTypeRefCombo.Size = new System.Drawing.Size(200, 20);
            this.productCategoryImageTypeRefCombo.TabIndex = 3;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 36);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(39, 13);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "Image:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(182, 36);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(200, 167);
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 209);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(59, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 209);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.ShowCheckBox = true;
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 235);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(92, 22);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "&Load image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // ProductCategoryImageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 258);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelProductCategoryImageTypeRefCombo);
            this.Controls.Add(this.productCategoryImageTypeRefCombo);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Name = "ProductCategoryImageEdit";
            this.Text = "Product Category Image Save";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonLoad;
    }
}
