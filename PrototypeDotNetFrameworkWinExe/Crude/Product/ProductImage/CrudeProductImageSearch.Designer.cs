namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductImageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductImageSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductImageAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductImageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductImage;
        
        private System.Windows.Forms.TextBox textBoxImageFileName;
        
        private System.Windows.Forms.Label labelImageFileName;
        
        private ProductImageTypeRefCombo productImageTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductImageTypeRefCombo;
        
        private System.Windows.Forms.PictureBox pictureBoxImage;
        
        private System.Windows.Forms.Label labelImage;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeProductImageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductImageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductImageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductImage = new System.Windows.Forms.DataGridView();
            this.labelImageFileName = new System.Windows.Forms.Label();
            this.textBoxImageFileName = new System.Windows.Forms.TextBox();
            this.labelProductImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productImageTypeRefCombo = new ProductImageTypeRefCombo();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductImage)).BeginInit();
            this.SuspendLayout();
            //
            // labelImageFileName
            //
            this.labelImageFileName.AutoSize = true;
            this.labelImageFileName.Location = new System.Drawing.Point(11, 13);
            this.labelImageFileName.Name = "labelImageFileName";
            this.labelImageFileName.Size = new System.Drawing.Size(71, 13);
            this.labelImageFileName.TabIndex = 2;
            this.labelImageFileName.Text = "Image File Name:";
            //
            //textBoxImageFileName
            //
            this.textBoxImageFileName.Location = new System.Drawing.Point(140, 13);
            this.textBoxImageFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFileName.Name = "textBoxImageFileName";
            this.textBoxImageFileName.Size = new System.Drawing.Size(250, 20);
            this.textBoxImageFileName.TabIndex = 3;
            //
            // labelProductImageTypeRefCombo
            //
            this.labelProductImageTypeRefCombo.AutoSize = true;
            this.labelProductImageTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductImageTypeRefCombo.Name = "labelProductImageTypeRefCombo";
            this.labelProductImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageTypeRefCombo.TabIndex = 4;
            this.labelProductImageTypeRefCombo.Text = "Product Image Type:";
            //
            //productImageTypeRefCombo
            //
            this.productImageTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.productImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productImageTypeRefCombo.Name = "productImageTypeRefCombo";
            this.productImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productImageTypeRefCombo.TabIndex = 5;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 59);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(140, 59);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeProductImage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductImage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductImage.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductImage.Name = "dataGridViewCrudeProductImage";
            this.dataGridViewCrudeProductImage.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductImage.TabIndex = 0;
            this.dataGridViewCrudeProductImage.ReadOnly = true;
            this.dataGridViewCrudeProductImage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductImage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductImageSearch
            // 
            this.buttonCrudeProductImageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeProductImageSearch.Name = "buttonCrudeProductImageSearch";
            this.buttonCrudeProductImageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageSearch.TabIndex = 2;
            this.buttonCrudeProductImageSearch.Text = "&Search";
            this.buttonCrudeProductImageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageSearch.Click += new System.EventHandler(this.buttonCrudeProductImageSearch_Click);
            // 
            // buttonCrudeProductImageAdd
            // 
            this.buttonCrudeProductImageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeProductImageAdd.Name = "buttonCrudeProductImageAdd";
            this.buttonCrudeProductImageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageAdd.TabIndex = 3;
            this.buttonCrudeProductImageAdd.Text = "&Add";
            this.buttonCrudeProductImageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageAdd.Click += new System.EventHandler(this.buttonCrudeProductImageAdd_Click);
            // 
            // buttonCrudeProductImageEdit
            // 
            this.buttonCrudeProductImageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeProductImageEdit.Name = "buttonCrudeProductImageEdit";
            this.buttonCrudeProductImageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageEdit.TabIndex = 4;
            this.buttonCrudeProductImageEdit.Text = "&Edit";
            this.buttonCrudeProductImageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageEdit.Click += new System.EventHandler(this.buttonCrudeProductImageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeProductImageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductImageAdd);
            this.Controls.Add(this.buttonCrudeProductImageEdit);
            this.Controls.Add(this.dataGridViewCrudeProductImage);
            this.Name = "CrudeProductImageSearch";
            this.Text = "Product Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductImage)).EndInit();
            this.Controls.Add(this.labelImageFileName);
            this.Controls.Add(this.textBoxImageFileName);
            this.Controls.Add(this.labelProductImageTypeRefCombo);
            this.Controls.Add(this.productImageTypeRefCombo);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
