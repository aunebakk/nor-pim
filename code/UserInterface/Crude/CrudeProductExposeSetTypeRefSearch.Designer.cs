namespace norpim.UserInterface {
    
    
    public partial class CrudeProductExposeSetTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExposeSetTypeRef;
        
        private ProductExposeSetTypeRefCombo productExposeSetTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetTypeName;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeName;
        
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
            this.dataGridViewCrudeProductExposeSetTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductExposeSetTypeRefCombo = new System.Windows.Forms.Label();
            this.productExposeSetTypeRefCombo = new ProductExposeSetTypeRefCombo();
            this.labelProductExposeSetTypeName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSetTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductExposeSetTypeRefCombo
            //
            this.labelProductExposeSetTypeRefCombo.AutoSize = true;
            this.labelProductExposeSetTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetTypeRefCombo.Name = "labelProductExposeSetTypeRefCombo";
            this.labelProductExposeSetTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeRefCombo.TabIndex = 2;
            this.labelProductExposeSetTypeRefCombo.Text = "Product Expose Set Type:";
            //
            //productExposeSetTypeRefCombo
            //
            this.productExposeSetTypeRefCombo.Location = new System.Drawing.Point(196, 13);
            this.productExposeSetTypeRefCombo.Name = "productExposeSetTypeRefCombo";
            this.productExposeSetTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productExposeSetTypeRefCombo.TabIndex = 3;
            //
            // labelProductExposeSetTypeName
            //
            this.labelProductExposeSetTypeName.AutoSize = true;
            this.labelProductExposeSetTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetTypeName.Name = "labelProductExposeSetTypeName";
            this.labelProductExposeSetTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeName.TabIndex = 4;
            this.labelProductExposeSetTypeName.Text = "Product Expose Set Type Name:";
            //
            //textBoxProductExposeSetTypeName
            //
            this.textBoxProductExposeSetTypeName.Location = new System.Drawing.Point(196, 36);
            this.textBoxProductExposeSetTypeName.Name = "textBoxProductExposeSetTypeName";
            this.textBoxProductExposeSetTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetTypeName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(196, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeProductExposeSetTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExposeSetTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExposeSetTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExposeSetTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExposeSetTypeRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductExposeSetTypeRef.Name = "dataGridViewCrudeProductExposeSetTypeRef";
            this.dataGridViewCrudeProductExposeSetTypeRef.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductExposeSetTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductExposeSetTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExposeSetTypeRef_DoubleClick);
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
            this.Controls.Add(this.dataGridViewCrudeProductExposeSetTypeRef);
            this.Name = "CrudeProductExposeSetTypeRefSearch";
            this.Text = "Product Expose Set Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSetTypeRef)).EndInit();
            this.Controls.Add(this.labelProductExposeSetTypeRefCombo);
            this.Controls.Add(this.productExposeSetTypeRefCombo);
            this.Controls.Add(this.labelProductExposeSetTypeName);
            this.Controls.Add(this.textBoxProductExposeSetTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
