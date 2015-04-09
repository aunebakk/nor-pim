namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryMappingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryMapping;
        
        private ProductCategoryPicker productCategoryPicker;
        
        private System.Windows.Forms.Label labelProductCategoryPicker;
        
        private ProductPicker productPicker;
        
        private System.Windows.Forms.Label labelProductPicker;
        
        private UserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryMapping = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryPicker = new System.Windows.Forms.Label();
            this.productCategoryPicker = new ProductCategoryPicker();
            this.labelProductPicker = new System.Windows.Forms.Label();
            this.productPicker = new ProductPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryMapping)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryPicker
            //
            this.labelProductCategoryPicker.AutoSize = true;
            this.labelProductCategoryPicker.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryPicker.Name = "labelProductCategoryPicker";
            this.labelProductCategoryPicker.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryPicker.TabIndex = 2;
            this.labelProductCategoryPicker.Text = "Product Category :";
            //
            //productCategoryPicker
            //
            this.productCategoryPicker.Location = new System.Drawing.Point(175, 13);
            this.productCategoryPicker.Name = "productCategoryPicker";
            this.productCategoryPicker.Size = new System.Drawing.Size(250, 20);
            this.productCategoryPicker.TabIndex = 3;
            //
            // labelProductPicker
            //
            this.labelProductPicker.AutoSize = true;
            this.labelProductPicker.Location = new System.Drawing.Point(11, 36);
            this.labelProductPicker.Name = "labelProductPicker";
            this.labelProductPicker.Size = new System.Drawing.Size(71, 13);
            this.labelProductPicker.TabIndex = 4;
            this.labelProductPicker.Text = "Product :";
            //
            //productPicker
            //
            this.productPicker.Location = new System.Drawing.Point(175, 36);
            this.productPicker.Name = "productPicker";
            this.productPicker.Size = new System.Drawing.Size(250, 20);
            this.productPicker.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(175, 59);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeProductCategoryMapping
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryMapping.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryMapping.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductCategoryMapping.Name = "dataGridViewCrudeProductCategoryMapping";
            this.dataGridViewCrudeProductCategoryMapping.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductCategoryMapping.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryMapping.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryMapping_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(335, 218);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(140, 218);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(237, 218);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 241);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryMapping);
            this.Name = "CrudeProductCategoryMappingSearch";
            this.Text = "Product Category Mapping Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryMapping)).EndInit();
            this.Controls.Add(this.labelProductCategoryPicker);
            this.Controls.Add(this.productCategoryPicker);
            this.Controls.Add(this.labelProductPicker);
            this.Controls.Add(this.productPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
