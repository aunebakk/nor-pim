namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxClientIdentifierTypeName;
        
        private System.Windows.Forms.Label labelClientIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientIdentifierType;
        
        private System.Windows.Forms.Label labelClientIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxClientIdentifierTypeDescription;
        
        private System.Windows.Forms.Label labelClientIdentifierTypeDescription;
        
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
            this.buttonCrudeClientIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelClientIdentifierType = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierType = new System.Windows.Forms.TextBox();
            this.labelClientIdentifierTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierTypeDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientIdentifierTypeName
            //
            this.labelClientIdentifierTypeName.AutoSize = true;
            this.labelClientIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientIdentifierTypeName.Name = "labelClientIdentifierTypeName";
            this.labelClientIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierTypeName.TabIndex = 2;
            this.labelClientIdentifierTypeName.Text = "Client Identifier Type Name:";
            //
            //textBoxClientIdentifierTypeName
            //
            this.textBoxClientIdentifierTypeName.Location = new System.Drawing.Point(238, 13);
            this.textBoxClientIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierTypeName.Name = "textBoxClientIdentifierTypeName";
            this.textBoxClientIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierTypeName.TabIndex = 3;
            //
            // labelClientIdentifierType
            //
            this.labelClientIdentifierType.AutoSize = true;
            this.labelClientIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelClientIdentifierType.Name = "labelClientIdentifierType";
            this.labelClientIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierType.TabIndex = 4;
            this.labelClientIdentifierType.Text = "Client Identifier Type:";
            //
            //textBoxClientIdentifierType
            //
            this.textBoxClientIdentifierType.Location = new System.Drawing.Point(238, 36);
            this.textBoxClientIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierType.Name = "textBoxClientIdentifierType";
            this.textBoxClientIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierType.TabIndex = 5;
            //
            // labelClientIdentifierTypeDescription
            //
            this.labelClientIdentifierTypeDescription.AutoSize = true;
            this.labelClientIdentifierTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientIdentifierTypeDescription.Name = "labelClientIdentifierTypeDescription";
            this.labelClientIdentifierTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierTypeDescription.TabIndex = 6;
            this.labelClientIdentifierTypeDescription.Text = "Client Identifier Type Description:";
            //
            //textBoxClientIdentifierTypeDescription
            //
            this.textBoxClientIdentifierTypeDescription.Location = new System.Drawing.Point(238, 59);
            this.textBoxClientIdentifierTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierTypeDescription.Name = "textBoxClientIdentifierTypeDescription";
            this.textBoxClientIdentifierTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierTypeDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(238, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(238, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientIdentifierTypeRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientIdentifierTypeRef.Name = "dataGridViewCrudeClientIdentifierTypeRef";
            this.dataGridViewCrudeClientIdentifierTypeRef.Size = new System.Drawing.Size(476, 96);
            this.dataGridViewCrudeClientIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientIdentifierTypeRefSearch
            // 
            this.buttonCrudeClientIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierTypeRefSearch.Location = new System.Drawing.Point(296, 264);
            this.buttonCrudeClientIdentifierTypeRefSearch.Name = "buttonCrudeClientIdentifierTypeRefSearch";
            this.buttonCrudeClientIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeClientIdentifierTypeRefAdd
            // 
            this.buttonCrudeClientIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierTypeRefAdd.Location = new System.Drawing.Point(196, 264);
            this.buttonCrudeClientIdentifierTypeRefAdd.Name = "buttonCrudeClientIdentifierTypeRefAdd";
            this.buttonCrudeClientIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeClientIdentifierTypeRefEdit
            // 
            this.buttonCrudeClientIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierTypeRefEdit.Location = new System.Drawing.Point(96, 264);
            this.buttonCrudeClientIdentifierTypeRefEdit.Name = "buttonCrudeClientIdentifierTypeRefEdit";
            this.buttonCrudeClientIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 292);
            this.Controls.Add(this.buttonCrudeClientIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientIdentifierTypeRef);
            this.Name = "CrudeClientIdentifierTypeRefSearch";
            this.Text = "Client Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelClientIdentifierTypeName);
            this.Controls.Add(this.textBoxClientIdentifierTypeName);
            this.Controls.Add(this.labelClientIdentifierType);
            this.Controls.Add(this.textBoxClientIdentifierType);
            this.Controls.Add(this.labelClientIdentifierTypeDescription);
            this.Controls.Add(this.textBoxClientIdentifierTypeDescription);
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
