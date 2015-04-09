namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryDocumentation;
        
        private ProductCategoryDocumentationTypeRefCombo productCategoryDocumentationTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductCategoryDocumentationTypeRefCombo;
        
        private ProductCategoryPicker productCategoryPicker;
        
        private System.Windows.Forms.Label labelProductCategoryPicker;
        
        private System.Windows.Forms.TextBox textBoxDocumentation;
        
        private System.Windows.Forms.Label labelDocumentation;
        
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
            this.dataGridViewCrudeProductCategoryDocumentation = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryDocumentationTypeRefCombo = new ProductCategoryDocumentationTypeRefCombo();
            this.labelProductCategoryPicker = new System.Windows.Forms.Label();
            this.productCategoryPicker = new ProductCategoryPicker();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.textBoxDocumentation = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentation)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryDocumentationTypeRefCombo
            //
            this.labelProductCategoryDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.Name = "labelProductCategoryDocumentationTypeRefCombo";
            this.labelProductCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryDocumentationTypeRefCombo.Text = "Product Category Documentation Type:";
            //
            //productCategoryDocumentationTypeRefCombo
            //
            this.productCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(245, 13);
            this.productCategoryDocumentationTypeRefCombo.Name = "productCategoryDocumentationTypeRefCombo";
            this.productCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productCategoryDocumentationTypeRefCombo.TabIndex = 3;
            //
            // labelProductCategoryPicker
            //
            this.labelProductCategoryPicker.AutoSize = true;
            this.labelProductCategoryPicker.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryPicker.Name = "labelProductCategoryPicker";
            this.labelProductCategoryPicker.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryPicker.TabIndex = 4;
            this.labelProductCategoryPicker.Text = "Product Category :";
            //
            //productCategoryPicker
            //
            this.productCategoryPicker.Location = new System.Drawing.Point(245, 36);
            this.productCategoryPicker.Name = "productCategoryPicker";
            this.productCategoryPicker.Size = new System.Drawing.Size(250, 20);
            this.productCategoryPicker.TabIndex = 5;
            //
            // labelDocumentation
            //
            this.labelDocumentation.AutoSize = true;
            this.labelDocumentation.Location = new System.Drawing.Point(11, 59);
            this.labelDocumentation.Name = "labelDocumentation";
            this.labelDocumentation.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentation.TabIndex = 6;
            this.labelDocumentation.Text = "Documentation:";
            //
            //textBoxDocumentation
            //
            this.textBoxDocumentation.Location = new System.Drawing.Point(245, 59);
            this.textBoxDocumentation.Name = "textBoxDocumentation";
            this.textBoxDocumentation.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentation.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(245, 82);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(245, 105);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeProductCategoryDocumentation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryDocumentation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryDocumentation.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeProductCategoryDocumentation.Name = "dataGridViewCrudeProductCategoryDocumentation";
            this.dataGridViewCrudeProductCategoryDocumentation.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductCategoryDocumentation.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryDocumentation.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryDocumentation_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 241);
            
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
            this.buttonSearch.Location = new System.Drawing.Point(335, 241);
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
            this.buttonAdd.Location = new System.Drawing.Point(140, 241);
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
            this.buttonEdit.Location = new System.Drawing.Point(237, 241);
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
            this.ClientSize = new System.Drawing.Size(526, 264);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryDocumentation);
            this.Name = "CrudeProductCategoryDocumentationSearch";
            this.Text = "Product Category Documentation Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentation)).EndInit();
            this.Controls.Add(this.labelProductCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.productCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.labelProductCategoryPicker);
            this.Controls.Add(this.productCategoryPicker);
            this.Controls.Add(this.labelDocumentation);
            this.Controls.Add(this.textBoxDocumentation);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
