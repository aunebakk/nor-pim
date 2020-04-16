namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderIdentifierTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderIdentifierTypeName;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderIdentifierType;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierType;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderIdentifierTypeCode;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierTypeCode;
        
        private System.Windows.Forms.TextBox textBoxStatusCode;
        
        private System.Windows.Forms.Label labelStatusCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortSequenceNumber;
        
        private System.Windows.Forms.Label labelSortSequenceNumber;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxChangeFlag;
        
        private System.Windows.Forms.Label labelChangeFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderIdentifierTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderIdentifierTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderIdentifierType = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderIdentifierType = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderIdentifierTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderIdentifierTypeCode = new System.Windows.Forms.TextBox();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.labelSortSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSortSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelChangeFlag = new System.Windows.Forms.Label();
            this.checkBoxChangeFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderIdentifierTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderIdentifierTypeName
            //
            this.labelFinancialOrderIdentifierTypeName.AutoSize = true;
            this.labelFinancialOrderIdentifierTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderIdentifierTypeName.Name = "labelFinancialOrderIdentifierTypeName";
            this.labelFinancialOrderIdentifierTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierTypeName.TabIndex = 2;
            this.labelFinancialOrderIdentifierTypeName.Text = "Financial Order Identifier Type Name:";
            //
            //textBoxFinancialOrderIdentifierTypeName
            //
            this.textBoxFinancialOrderIdentifierTypeName.Location = new System.Drawing.Point(252, 13);
            this.textBoxFinancialOrderIdentifierTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderIdentifierTypeName.Name = "textBoxFinancialOrderIdentifierTypeName";
            this.textBoxFinancialOrderIdentifierTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderIdentifierTypeName.TabIndex = 3;
            //
            // labelFinancialOrderIdentifierType
            //
            this.labelFinancialOrderIdentifierType.AutoSize = true;
            this.labelFinancialOrderIdentifierType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderIdentifierType.Name = "labelFinancialOrderIdentifierType";
            this.labelFinancialOrderIdentifierType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierType.TabIndex = 4;
            this.labelFinancialOrderIdentifierType.Text = "Financial Order Identifier Type:";
            //
            //textBoxFinancialOrderIdentifierType
            //
            this.textBoxFinancialOrderIdentifierType.Location = new System.Drawing.Point(252, 36);
            this.textBoxFinancialOrderIdentifierType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderIdentifierType.Name = "textBoxFinancialOrderIdentifierType";
            this.textBoxFinancialOrderIdentifierType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderIdentifierType.TabIndex = 5;
            //
            // labelFinancialOrderIdentifierTypeCode
            //
            this.labelFinancialOrderIdentifierTypeCode.AutoSize = true;
            this.labelFinancialOrderIdentifierTypeCode.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialOrderIdentifierTypeCode.Name = "labelFinancialOrderIdentifierTypeCode";
            this.labelFinancialOrderIdentifierTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierTypeCode.TabIndex = 6;
            this.labelFinancialOrderIdentifierTypeCode.Text = "Financial Order Identifier Type Code:";
            //
            //textBoxFinancialOrderIdentifierTypeCode
            //
            this.textBoxFinancialOrderIdentifierTypeCode.Location = new System.Drawing.Point(252, 59);
            this.textBoxFinancialOrderIdentifierTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderIdentifierTypeCode.Name = "textBoxFinancialOrderIdentifierTypeCode";
            this.textBoxFinancialOrderIdentifierTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderIdentifierTypeCode.TabIndex = 7;
            //
            // labelStatusCode
            //
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(11, 82);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(71, 13);
            this.labelStatusCode.TabIndex = 8;
            this.labelStatusCode.Text = "Status Code:";
            //
            //textBoxStatusCode
            //
            this.textBoxStatusCode.Location = new System.Drawing.Point(252, 82);
            this.textBoxStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxStatusCode.TabIndex = 9;
            //
            // labelSortSequenceNumber
            //
            this.labelSortSequenceNumber.AutoSize = true;
            this.labelSortSequenceNumber.Location = new System.Drawing.Point(11, 105);
            this.labelSortSequenceNumber.Name = "labelSortSequenceNumber";
            this.labelSortSequenceNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSortSequenceNumber.TabIndex = 10;
            this.labelSortSequenceNumber.Text = "Sort Sequence Number:";
            //
            //maskedTextBoxSortSequenceNumber
            //
            this.maskedTextBoxSortSequenceNumber.Location = new System.Drawing.Point(252, 105);
            this.maskedTextBoxSortSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortSequenceNumber.Name = "maskedTextBoxSortSequenceNumber";
            this.maskedTextBoxSortSequenceNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortSequenceNumber.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(252, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            //
            // labelChangeFlag
            //
            this.labelChangeFlag.AutoSize = true;
            this.labelChangeFlag.Location = new System.Drawing.Point(11, 151);
            this.labelChangeFlag.Name = "labelChangeFlag";
            this.labelChangeFlag.Size = new System.Drawing.Size(71, 13);
            this.labelChangeFlag.TabIndex = 14;
            this.labelChangeFlag.Text = "Change Flag:";
            //
            //checkBoxChangeFlag
            //
            this.checkBoxChangeFlag.Location = new System.Drawing.Point(252, 151);
            this.checkBoxChangeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChangeFlag.Name = "checkBoxChangeFlag";
            this.checkBoxChangeFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxChangeFlag.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialOrderIdentifierTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.Name = "dataGridViewCrudeFinancialOrderIdentifierTypeRef";
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.Size = new System.Drawing.Size(490, 96);
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderIdentifierTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderIdentifierTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(410, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierTypeRefSearch
            // 
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Location = new System.Drawing.Point(310, 287);
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Name = "buttonCrudeFinancialOrderIdentifierTypeRefSearch";
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierTypeRefAdd
            // 
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Location = new System.Drawing.Point(210, 287);
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Name = "buttonCrudeFinancialOrderIdentifierTypeRefAdd";
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierTypeRefEdit
            // 
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Location = new System.Drawing.Point(110, 287);
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Name = "buttonCrudeFinancialOrderIdentifierTypeRefEdit";
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 315);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderIdentifierTypeRef);
            this.Name = "CrudeFinancialOrderIdentifierTypeRefSearch";
            this.Text = "Financial Order Identifier Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderIdentifierTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialOrderIdentifierTypeName);
            this.Controls.Add(this.textBoxFinancialOrderIdentifierTypeName);
            this.Controls.Add(this.labelFinancialOrderIdentifierType);
            this.Controls.Add(this.textBoxFinancialOrderIdentifierType);
            this.Controls.Add(this.labelFinancialOrderIdentifierTypeCode);
            this.Controls.Add(this.textBoxFinancialOrderIdentifierTypeCode);
            this.Controls.Add(this.labelStatusCode);
            this.Controls.Add(this.textBoxStatusCode);
            this.Controls.Add(this.labelSortSequenceNumber);
            this.Controls.Add(this.maskedTextBoxSortSequenceNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelChangeFlag);
            this.Controls.Add(this.checkBoxChangeFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
