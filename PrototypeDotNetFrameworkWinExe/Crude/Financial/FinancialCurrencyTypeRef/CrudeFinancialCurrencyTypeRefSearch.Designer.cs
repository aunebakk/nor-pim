namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCurrencyTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencyTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencyTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCurrencyTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCurrencyTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeName;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyType;
        
        private System.Windows.Forms.Label labelFinancialCurrencyType;
        
        private System.Windows.Forms.TextBox textBoxFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.Label labelFinancialCurrencyTypeCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDecimalCount;
        
        private System.Windows.Forms.Label labelDecimalCount;
        
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
            this.buttonCrudeFinancialCurrencyTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCurrencyTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCurrencyTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCurrencyTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialCurrencyTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyType = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyType = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyTypeCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCurrencyTypeCode = new System.Windows.Forms.TextBox();
            this.labelDecimalCount = new System.Windows.Forms.Label();
            this.maskedTextBoxDecimalCount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCurrencyTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCurrencyTypeName
            //
            this.labelFinancialCurrencyTypeName.AutoSize = true;
            this.labelFinancialCurrencyTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCurrencyTypeName.Name = "labelFinancialCurrencyTypeName";
            this.labelFinancialCurrencyTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeName.TabIndex = 2;
            this.labelFinancialCurrencyTypeName.Text = "Financial Currency Type Name:";
            //
            //textBoxFinancialCurrencyTypeName
            //
            this.textBoxFinancialCurrencyTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxFinancialCurrencyTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeName.Name = "textBoxFinancialCurrencyTypeName";
            this.textBoxFinancialCurrencyTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeName.TabIndex = 3;
            //
            // labelFinancialCurrencyType
            //
            this.labelFinancialCurrencyType.AutoSize = true;
            this.labelFinancialCurrencyType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCurrencyType.Name = "labelFinancialCurrencyType";
            this.labelFinancialCurrencyType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyType.TabIndex = 4;
            this.labelFinancialCurrencyType.Text = "Financial Currency Type:";
            //
            //textBoxFinancialCurrencyType
            //
            this.textBoxFinancialCurrencyType.Location = new System.Drawing.Point(196, 36);
            this.textBoxFinancialCurrencyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyType.Name = "textBoxFinancialCurrencyType";
            this.textBoxFinancialCurrencyType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyType.TabIndex = 5;
            //
            // labelFinancialCurrencyTypeCode
            //
            this.labelFinancialCurrencyTypeCode.AutoSize = true;
            this.labelFinancialCurrencyTypeCode.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialCurrencyTypeCode.Name = "labelFinancialCurrencyTypeCode";
            this.labelFinancialCurrencyTypeCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyTypeCode.TabIndex = 6;
            this.labelFinancialCurrencyTypeCode.Text = "Financial Currency Type Code:";
            //
            //textBoxFinancialCurrencyTypeCode
            //
            this.textBoxFinancialCurrencyTypeCode.Location = new System.Drawing.Point(196, 59);
            this.textBoxFinancialCurrencyTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCurrencyTypeCode.Name = "textBoxFinancialCurrencyTypeCode";
            this.textBoxFinancialCurrencyTypeCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCurrencyTypeCode.TabIndex = 7;
            //
            // labelDecimalCount
            //
            this.labelDecimalCount.AutoSize = true;
            this.labelDecimalCount.Location = new System.Drawing.Point(11, 82);
            this.labelDecimalCount.Name = "labelDecimalCount";
            this.labelDecimalCount.Size = new System.Drawing.Size(71, 13);
            this.labelDecimalCount.TabIndex = 8;
            this.labelDecimalCount.Text = "Decimal Count:";
            //
            //maskedTextBoxDecimalCount
            //
            this.maskedTextBoxDecimalCount.Location = new System.Drawing.Point(196, 82);
            this.maskedTextBoxDecimalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDecimalCount.Name = "maskedTextBoxDecimalCount";
            this.maskedTextBoxDecimalCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDecimalCount.TabIndex = 9;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // dataGridViewCrudeFinancialCurrencyTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCurrencyTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCurrencyTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCurrencyTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCurrencyTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCurrencyTypeRef.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeFinancialCurrencyTypeRef.Name = "dataGridViewCrudeFinancialCurrencyTypeRef";
            this.dataGridViewCrudeFinancialCurrencyTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeFinancialCurrencyTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialCurrencyTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialCurrencyTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCurrencyTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCurrencyTypeRefSearch
            // 
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Location = new System.Drawing.Point(254, 241);
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Name = "buttonCrudeFinancialCurrencyTypeRefSearch";
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencyTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialCurrencyTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencyTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencyTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialCurrencyTypeRefAdd
            // 
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Location = new System.Drawing.Point(154, 241);
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Name = "buttonCrudeFinancialCurrencyTypeRefAdd";
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencyTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialCurrencyTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencyTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencyTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialCurrencyTypeRefEdit
            // 
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Location = new System.Drawing.Point(54, 241);
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Name = "buttonCrudeFinancialCurrencyTypeRefEdit";
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCurrencyTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialCurrencyTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCurrencyTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCurrencyTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 269);
            this.Controls.Add(this.buttonCrudeFinancialCurrencyTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCurrencyTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialCurrencyTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCurrencyTypeRef);
            this.Name = "CrudeFinancialCurrencyTypeRefSearch";
            this.Text = "Financial Currency Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCurrencyTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialCurrencyTypeName);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeName);
            this.Controls.Add(this.labelFinancialCurrencyType);
            this.Controls.Add(this.textBoxFinancialCurrencyType);
            this.Controls.Add(this.labelFinancialCurrencyTypeCode);
            this.Controls.Add(this.textBoxFinancialCurrencyTypeCode);
            this.Controls.Add(this.labelDecimalCount);
            this.Controls.Add(this.maskedTextBoxDecimalCount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
