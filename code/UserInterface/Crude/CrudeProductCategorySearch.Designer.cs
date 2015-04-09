namespace norpim.UserInterface {
    
    
    public partial class CrudeProductCategorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategory;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryCode;
        
        private System.Windows.Forms.Label labelProductCategoryCode;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryName;
        
        private System.Windows.Forms.Label labelProductCategoryName;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProductCategoryPosition;
        
        private System.Windows.Forms.Label labelProductCategoryPosition;
        
        private StateRefCombo stateRefCombo;
        
        private System.Windows.Forms.Label labelStateRefCombo;
        
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
            this.dataGridViewCrudeProductCategory = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryCode = new System.Windows.Forms.Label();
            this.textBoxProductCategoryCode = new System.Windows.Forms.TextBox();
            this.labelProductCategoryName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryPosition = new System.Windows.Forms.Label();
            this.maskedTextBoxProductCategoryPosition = new System.Windows.Forms.MaskedTextBox();
            this.labelStateRefCombo = new System.Windows.Forms.Label();
            this.stateRefCombo = new StateRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategory)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryCode
            //
            this.labelProductCategoryCode.AutoSize = true;
            this.labelProductCategoryCode.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryCode.Name = "labelProductCategoryCode";
            this.labelProductCategoryCode.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryCode.TabIndex = 2;
            this.labelProductCategoryCode.Text = "Product Category Code:";
            //
            //textBoxProductCategoryCode
            //
            this.textBoxProductCategoryCode.Location = new System.Drawing.Point(175, 13);
            this.textBoxProductCategoryCode.Name = "textBoxProductCategoryCode";
            this.textBoxProductCategoryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryCode.TabIndex = 3;
            //
            // labelProductCategoryName
            //
            this.labelProductCategoryName.AutoSize = true;
            this.labelProductCategoryName.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryName.Name = "labelProductCategoryName";
            this.labelProductCategoryName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryName.TabIndex = 4;
            this.labelProductCategoryName.Text = "Product Category Name:";
            //
            //textBoxProductCategoryName
            //
            this.textBoxProductCategoryName.Location = new System.Drawing.Point(175, 36);
            this.textBoxProductCategoryName.Name = "textBoxProductCategoryName";
            this.textBoxProductCategoryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryName.TabIndex = 5;
            //
            // labelProductCategoryPosition
            //
            this.labelProductCategoryPosition.AutoSize = true;
            this.labelProductCategoryPosition.Location = new System.Drawing.Point(11, 59);
            this.labelProductCategoryPosition.Name = "labelProductCategoryPosition";
            this.labelProductCategoryPosition.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryPosition.TabIndex = 6;
            this.labelProductCategoryPosition.Text = "Product Category Position:";
            //
            //maskedTextBoxProductCategoryPosition
            //
            this.maskedTextBoxProductCategoryPosition.Location = new System.Drawing.Point(175, 59);
            this.maskedTextBoxProductCategoryPosition.Name = "maskedTextBoxProductCategoryPosition";
            this.maskedTextBoxProductCategoryPosition.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxProductCategoryPosition.TabIndex = 7;
            //
            // labelStateRefCombo
            //
            this.labelStateRefCombo.AutoSize = true;
            this.labelStateRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelStateRefCombo.Name = "labelStateRefCombo";
            this.labelStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelStateRefCombo.TabIndex = 8;
            this.labelStateRefCombo.Text = "State:";
            //
            //stateRefCombo
            //
            this.stateRefCombo.Location = new System.Drawing.Point(175, 82);
            this.stateRefCombo.Name = "stateRefCombo";
            this.stateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.stateRefCombo.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User :";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(175, 105);
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 128);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeProductCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategory.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeProductCategory.Name = "dataGridViewCrudeProductCategory";
            this.dataGridViewCrudeProductCategory.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductCategory.TabIndex = 0;
            this.dataGridViewCrudeProductCategory.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategory_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(433, 264);
            
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
            this.buttonSearch.Location = new System.Drawing.Point(335, 264);
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
            this.buttonAdd.Location = new System.Drawing.Point(140, 264);
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
            this.buttonEdit.Location = new System.Drawing.Point(237, 264);
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
            this.ClientSize = new System.Drawing.Size(526, 287);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategory);
            this.Name = "CrudeProductCategorySearch";
            this.Text = "Product Category Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategory)).EndInit();
            this.Controls.Add(this.labelProductCategoryCode);
            this.Controls.Add(this.textBoxProductCategoryCode);
            this.Controls.Add(this.labelProductCategoryName);
            this.Controls.Add(this.textBoxProductCategoryName);
            this.Controls.Add(this.labelProductCategoryPosition);
            this.Controls.Add(this.maskedTextBoxProductCategoryPosition);
            this.Controls.Add(this.labelStateRefCombo);
            this.Controls.Add(this.stateRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
