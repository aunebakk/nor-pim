namespace norpim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSearch;
        
        private System.Windows.Forms.Button buttonAdd;
        
        private System.Windows.Forms.Button buttonEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherSourceTypeRef;
        
        private ProductGatherSourceTypeRefCombo productGatherSourceTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductGatherSourceTypeName;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeName;
        
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
            this.dataGridViewCrudeProductGatherSourceTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductGatherSourceTypeRefCombo = new System.Windows.Forms.Label();
            this.productGatherSourceTypeRefCombo = new ProductGatherSourceTypeRefCombo();
            this.labelProductGatherSourceTypeName = new System.Windows.Forms.Label();
            this.textBoxProductGatherSourceTypeName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new UserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSourceTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherSourceTypeRefCombo
            //
            this.labelProductGatherSourceTypeRefCombo.AutoSize = true;
            this.labelProductGatherSourceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherSourceTypeRefCombo.Name = "labelProductGatherSourceTypeRefCombo";
            this.labelProductGatherSourceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeRefCombo.TabIndex = 2;
            this.labelProductGatherSourceTypeRefCombo.Text = "Product Gather Source Type:";
            //
            //productGatherSourceTypeRefCombo
            //
            this.productGatherSourceTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.productGatherSourceTypeRefCombo.Name = "productGatherSourceTypeRefCombo";
            this.productGatherSourceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productGatherSourceTypeRefCombo.TabIndex = 3;
            //
            // labelProductGatherSourceTypeName
            //
            this.labelProductGatherSourceTypeName.AutoSize = true;
            this.labelProductGatherSourceTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherSourceTypeName.Name = "labelProductGatherSourceTypeName";
            this.labelProductGatherSourceTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeName.TabIndex = 4;
            this.labelProductGatherSourceTypeName.Text = "Product Gather Source Type Name:";
            //
            //textBoxProductGatherSourceTypeName
            //
            this.textBoxProductGatherSourceTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductGatherSourceTypeName.Name = "textBoxProductGatherSourceTypeName";
            this.textBoxProductGatherSourceTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherSourceTypeName.TabIndex = 5;
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
            // dataGridViewCrudeProductGatherSourceTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherSourceTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherSourceTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherSourceTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherSourceTypeRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductGatherSourceTypeRef.Name = "dataGridViewCrudeProductGatherSourceTypeRef";
            this.dataGridViewCrudeProductGatherSourceTypeRef.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeProductGatherSourceTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductGatherSourceTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherSourceTypeRef_DoubleClick);
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
            this.Controls.Add(this.dataGridViewCrudeProductGatherSourceTypeRef);
            this.Name = "CrudeProductGatherSourceTypeRefSearch";
            this.Text = "Product Gather Source Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSourceTypeRef)).EndInit();
            this.Controls.Add(this.labelProductGatherSourceTypeRefCombo);
            this.Controls.Add(this.productGatherSourceTypeRefCombo);
            this.Controls.Add(this.labelProductGatherSourceTypeName);
            this.Controls.Add(this.textBoxProductGatherSourceTypeName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
