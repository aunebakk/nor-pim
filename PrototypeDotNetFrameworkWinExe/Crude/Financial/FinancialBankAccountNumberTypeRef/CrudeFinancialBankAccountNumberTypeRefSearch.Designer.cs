namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialBankAccountNumberTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBankAccountNumberTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBankAccountNumberTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBankAccountNumberTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialBankAccountNumberTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialBankAccountNumberTypeName;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialBankAccountNumberType;
        
        private System.Windows.Forms.Label labelFinancialBankAccountNumberType;
        
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
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialBankAccountNumberTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialBankAccountNumberTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialBankAccountNumberType = new System.Windows.Forms.Label();
            this.textBoxFinancialBankAccountNumberType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBankAccountNumberTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialBankAccountNumberTypeName
            //
            this.labelFinancialBankAccountNumberTypeName.AutoSize = true;
            this.labelFinancialBankAccountNumberTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBankAccountNumberTypeName.Name = "labelFinancialBankAccountNumberTypeName";
            this.labelFinancialBankAccountNumberTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberTypeName.TabIndex = 2;
            this.labelFinancialBankAccountNumberTypeName.Text = "Financial Bank Account Number Type Name:";
            //
            //textBoxFinancialBankAccountNumberTypeName
            //
            this.textBoxFinancialBankAccountNumberTypeName.Location = new System.Drawing.Point(273, 13);
            this.textBoxFinancialBankAccountNumberTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBankAccountNumberTypeName.Name = "textBoxFinancialBankAccountNumberTypeName";
            this.textBoxFinancialBankAccountNumberTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBankAccountNumberTypeName.TabIndex = 3;
            //
            // labelFinancialBankAccountNumberType
            //
            this.labelFinancialBankAccountNumberType.AutoSize = true;
            this.labelFinancialBankAccountNumberType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialBankAccountNumberType.Name = "labelFinancialBankAccountNumberType";
            this.labelFinancialBankAccountNumberType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBankAccountNumberType.TabIndex = 4;
            this.labelFinancialBankAccountNumberType.Text = "Financial Bank Account Number Type:";
            //
            //textBoxFinancialBankAccountNumberType
            //
            this.textBoxFinancialBankAccountNumberType.Location = new System.Drawing.Point(273, 36);
            this.textBoxFinancialBankAccountNumberType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialBankAccountNumberType.Name = "textBoxFinancialBankAccountNumberType";
            this.textBoxFinancialBankAccountNumberType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialBankAccountNumberType.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(273, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialBankAccountNumberTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.Name = "dataGridViewCrudeFinancialBankAccountNumberTypeRef";
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.Size = new System.Drawing.Size(511, 96);
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialBankAccountNumberTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialBankAccountNumberTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(431, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialBankAccountNumberTypeRefSearch
            // 
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Location = new System.Drawing.Point(331, 195);
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Name = "buttonCrudeFinancialBankAccountNumberTypeRefSearch";
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBankAccountNumberTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialBankAccountNumberTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialBankAccountNumberTypeRefAdd
            // 
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Location = new System.Drawing.Point(231, 195);
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Name = "buttonCrudeFinancialBankAccountNumberTypeRefAdd";
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBankAccountNumberTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialBankAccountNumberTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialBankAccountNumberTypeRefEdit
            // 
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Location = new System.Drawing.Point(131, 195);
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Name = "buttonCrudeFinancialBankAccountNumberTypeRefEdit";
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBankAccountNumberTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialBankAccountNumberTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 223);
            this.Controls.Add(this.buttonCrudeFinancialBankAccountNumberTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialBankAccountNumberTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialBankAccountNumberTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialBankAccountNumberTypeRef);
            this.Name = "CrudeFinancialBankAccountNumberTypeRefSearch";
            this.Text = "Financial Bank Account Number Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBankAccountNumberTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialBankAccountNumberTypeName);
            this.Controls.Add(this.textBoxFinancialBankAccountNumberTypeName);
            this.Controls.Add(this.labelFinancialBankAccountNumberType);
            this.Controls.Add(this.textBoxFinancialBankAccountNumberType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
