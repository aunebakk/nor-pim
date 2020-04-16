namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientAddressTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientAddressTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientAddressTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientAddressTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientAddressTypeRef;
        
        private System.Windows.Forms.TextBox textBoxClientAddressTypeName;
        
        private System.Windows.Forms.Label labelClientAddressTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientAddressType;
        
        private System.Windows.Forms.Label labelClientAddressType;
        
        private System.Windows.Forms.TextBox textBoxClientAddressTypeDescription;
        
        private System.Windows.Forms.Label labelClientAddressTypeDescription;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeClientAddressTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientAddressTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientAddressTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientAddressTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxClientAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelClientAddressType = new System.Windows.Forms.Label();
            this.textBoxClientAddressType = new System.Windows.Forms.TextBox();
            this.labelClientAddressTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientAddressTypeDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientAddressTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientAddressTypeName
            //
            this.labelClientAddressTypeName.AutoSize = true;
            this.labelClientAddressTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientAddressTypeName.Name = "labelClientAddressTypeName";
            this.labelClientAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressTypeName.TabIndex = 2;
            this.labelClientAddressTypeName.Text = "Client Address Type Name:";
            //
            //textBoxClientAddressTypeName
            //
            this.textBoxClientAddressTypeName.Location = new System.Drawing.Point(217, 13);
            this.textBoxClientAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressTypeName.Name = "textBoxClientAddressTypeName";
            this.textBoxClientAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressTypeName.TabIndex = 3;
            //
            // labelClientAddressType
            //
            this.labelClientAddressType.AutoSize = true;
            this.labelClientAddressType.Location = new System.Drawing.Point(11, 36);
            this.labelClientAddressType.Name = "labelClientAddressType";
            this.labelClientAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressType.TabIndex = 4;
            this.labelClientAddressType.Text = "Client Address Type:";
            //
            //textBoxClientAddressType
            //
            this.textBoxClientAddressType.Location = new System.Drawing.Point(217, 36);
            this.textBoxClientAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressType.Name = "textBoxClientAddressType";
            this.textBoxClientAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressType.TabIndex = 5;
            //
            // labelClientAddressTypeDescription
            //
            this.labelClientAddressTypeDescription.AutoSize = true;
            this.labelClientAddressTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientAddressTypeDescription.Name = "labelClientAddressTypeDescription";
            this.labelClientAddressTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientAddressTypeDescription.TabIndex = 6;
            this.labelClientAddressTypeDescription.Text = "Client Address Type Description:";
            //
            //textBoxClientAddressTypeDescription
            //
            this.textBoxClientAddressTypeDescription.Location = new System.Drawing.Point(217, 59);
            this.textBoxClientAddressTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientAddressTypeDescription.Name = "textBoxClientAddressTypeDescription";
            this.textBoxClientAddressTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientAddressTypeDescription.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(217, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 128);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 12;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(217, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientAddressTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientAddressTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientAddressTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientAddressTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientAddressTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientAddressTypeRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientAddressTypeRef.Name = "dataGridViewCrudeClientAddressTypeRef";
            this.dataGridViewCrudeClientAddressTypeRef.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeClientAddressTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientAddressTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientAddressTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientAddressTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientAddressTypeRefSearch
            // 
            this.buttonCrudeClientAddressTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientAddressTypeRefSearch.Location = new System.Drawing.Point(275, 264);
            this.buttonCrudeClientAddressTypeRefSearch.Name = "buttonCrudeClientAddressTypeRefSearch";
            this.buttonCrudeClientAddressTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientAddressTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientAddressTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientAddressTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAddressTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientAddressTypeRefSearch_Click);
            // 
            // buttonCrudeClientAddressTypeRefAdd
            // 
            this.buttonCrudeClientAddressTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientAddressTypeRefAdd.Location = new System.Drawing.Point(175, 264);
            this.buttonCrudeClientAddressTypeRefAdd.Name = "buttonCrudeClientAddressTypeRefAdd";
            this.buttonCrudeClientAddressTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientAddressTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientAddressTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientAddressTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAddressTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientAddressTypeRefAdd_Click);
            // 
            // buttonCrudeClientAddressTypeRefEdit
            // 
            this.buttonCrudeClientAddressTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientAddressTypeRefEdit.Location = new System.Drawing.Point(75, 264);
            this.buttonCrudeClientAddressTypeRefEdit.Name = "buttonCrudeClientAddressTypeRefEdit";
            this.buttonCrudeClientAddressTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientAddressTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientAddressTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientAddressTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAddressTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientAddressTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 292);
            this.Controls.Add(this.buttonCrudeClientAddressTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientAddressTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientAddressTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientAddressTypeRef);
            this.Name = "CrudeClientAddressTypeRefSearch";
            this.Text = "Client Address Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientAddressTypeRef)).EndInit();
            this.Controls.Add(this.labelClientAddressTypeName);
            this.Controls.Add(this.textBoxClientAddressTypeName);
            this.Controls.Add(this.labelClientAddressType);
            this.Controls.Add(this.textBoxClientAddressType);
            this.Controls.Add(this.labelClientAddressTypeDescription);
            this.Controls.Add(this.textBoxClientAddressTypeDescription);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
