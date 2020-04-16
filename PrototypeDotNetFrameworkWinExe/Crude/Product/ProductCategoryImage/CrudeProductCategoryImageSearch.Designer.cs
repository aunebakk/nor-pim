namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryImage;
        
        private ProductCategoryImageTypeRefCombo productCategoryImageTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductCategoryImageTypeRefCombo;
        
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
            this.buttonCrudeProductCategoryImageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryImageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryImageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryImage = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryImageTypeRefCombo = new ProductCategoryImageTypeRefCombo();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryImage)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryImageTypeRefCombo
            //
            this.labelProductCategoryImageTypeRefCombo.AutoSize = true;
            this.labelProductCategoryImageTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryImageTypeRefCombo.Name = "labelProductCategoryImageTypeRefCombo";
            this.labelProductCategoryImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryImageTypeRefCombo.Text = "Product Category Image Type:";
            //
            //productCategoryImageTypeRefCombo
            //
            this.productCategoryImageTypeRefCombo.Location = new System.Drawing.Point(189, 13);
            this.productCategoryImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoryImageTypeRefCombo.Name = "productCategoryImageTypeRefCombo";
            this.productCategoryImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productCategoryImageTypeRefCombo.TabIndex = 3;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 36);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 4;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(189, 36);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductCategoryImage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryImage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategoryImage.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductCategoryImage.Name = "dataGridViewCrudeProductCategoryImage";
            this.dataGridViewCrudeProductCategoryImage.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeProductCategoryImage.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryImage.ReadOnly = true;
            this.dataGridViewCrudeProductCategoryImage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryImage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategoryImageSearch
            // 
            this.buttonCrudeProductCategoryImageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeProductCategoryImageSearch.Name = "buttonCrudeProductCategoryImageSearch";
            this.buttonCrudeProductCategoryImageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageSearch.TabIndex = 2;
            this.buttonCrudeProductCategoryImageSearch.Text = "&Search";
            this.buttonCrudeProductCategoryImageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageSearch.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageSearch_Click);
            // 
            // buttonCrudeProductCategoryImageAdd
            // 
            this.buttonCrudeProductCategoryImageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeProductCategoryImageAdd.Name = "buttonCrudeProductCategoryImageAdd";
            this.buttonCrudeProductCategoryImageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryImageAdd.Text = "&Add";
            this.buttonCrudeProductCategoryImageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageAdd_Click);
            // 
            // buttonCrudeProductCategoryImageEdit
            // 
            this.buttonCrudeProductCategoryImageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeProductCategoryImageEdit.Name = "buttonCrudeProductCategoryImageEdit";
            this.buttonCrudeProductCategoryImageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryImageEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryImageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeProductCategoryImageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryImageAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryImageEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryImage);
            this.Name = "CrudeProductCategoryImageSearch";
            this.Text = "Product Category Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryImage)).EndInit();
            this.Controls.Add(this.labelProductCategoryImageTypeRefCombo);
            this.Controls.Add(this.productCategoryImageTypeRefCombo);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
