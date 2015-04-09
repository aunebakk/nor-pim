namespace norpim.UserInterface {
    
    
    public partial class CrudeProductDocumentationTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductDocumentationTypeRef;
        
        private ProductDocumentationTypeRefCombo productDocumentationTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductDocumentationTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductDocumentationTypeName;
        
        private System.Windows.Forms.Label labelProductDocumentationTypeName;
        
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
            this.dataGridViewCrudeProductDocumentationTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productDocumentationTypeRefCombo = new ProductDocumentationTypeRefCombo();
            this.labelProductDocumentationTypeName = new System.Windows.Forms.Label();
            this.textBoxProductDocumentationTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentationTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductDocumentationTypeRefCombo
            //
            this.labelProductDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductDocumentationTypeRefCombo.Name = "labelProductDocumentationTypeRefCombo";
            this.labelProductDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeRefCombo.TabIndex = 2;
            this.labelProductDocumentationTypeRefCombo.Text = "Product Documentation Type:";
            //
            //productDocumentationTypeRefCombo
            //
            this.productDocumentationTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.productDocumentationTypeRefCombo.Name = "productDocumentationTypeRefCombo";
            this.productDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productDocumentationTypeRefCombo.TabIndex = 3;
            //
            // labelProductDocumentationTypeName
            //
            this.labelProductDocumentationTypeName.AutoSize = true;
            this.labelProductDocumentationTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductDocumentationTypeName.Name = "labelProductDocumentationTypeName";
            this.labelProductDocumentationTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeName.TabIndex = 4;
            this.labelProductDocumentationTypeName.Text = "Product Documentation Type Name:";
            //
            //textBoxProductDocumentationTypeName
            //
            this.textBoxProductDocumentationTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductDocumentationTypeName.Name = "textBoxProductDocumentationTypeName";
            this.textBoxProductDocumentationTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductDocumentationTypeName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(217, 59);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 82);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeProductDocumentationTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductDocumentationTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductDocumentationTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductDocumentationTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductDocumentationTypeRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductDocumentationTypeRef.Name = "dataGridViewCrudeProductDocumentationTypeRef";
            this.dataGridViewCrudeProductDocumentationTypeRef.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductDocumentationTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductDocumentationTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductDocumentationTypeRef_DoubleClick);
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
            this.Controls.Add(this.dataGridViewCrudeProductDocumentationTypeRef);
            this.Name = "CrudeProductDocumentationTypeRefSearch";
            this.Text = "Product Documentation Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentationTypeRef)).EndInit();
            this.Controls.Add(this.labelProductDocumentationTypeRefCombo);
            this.Controls.Add(this.productDocumentationTypeRefCombo);
            this.Controls.Add(this.labelProductDocumentationTypeName);
            this.Controls.Add(this.textBoxProductDocumentationTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
