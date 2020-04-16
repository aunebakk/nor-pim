namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialVoucherTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialVoucherTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialVoucherTypeName;
        
        private System.Windows.Forms.Label labelFinancialVoucherTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialVoucherType;
        
        private System.Windows.Forms.Label labelFinancialVoucherType;
        
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
            this.buttonCrudeFinancialVoucherTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialVoucherTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialVoucherTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialVoucherTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialVoucherTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialVoucherType = new System.Windows.Forms.Label();
            this.textBoxFinancialVoucherType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucherTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialVoucherTypeName
            //
            this.labelFinancialVoucherTypeName.AutoSize = true;
            this.labelFinancialVoucherTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialVoucherTypeName.Name = "labelFinancialVoucherTypeName";
            this.labelFinancialVoucherTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherTypeName.TabIndex = 2;
            this.labelFinancialVoucherTypeName.Text = "Financial Voucher Type Name:";
            //
            //textBoxFinancialVoucherTypeName
            //
            this.textBoxFinancialVoucherTypeName.Location = new System.Drawing.Point(189, 13);
            this.textBoxFinancialVoucherTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialVoucherTypeName.Name = "textBoxFinancialVoucherTypeName";
            this.textBoxFinancialVoucherTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialVoucherTypeName.TabIndex = 3;
            //
            // labelFinancialVoucherType
            //
            this.labelFinancialVoucherType.AutoSize = true;
            this.labelFinancialVoucherType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialVoucherType.Name = "labelFinancialVoucherType";
            this.labelFinancialVoucherType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialVoucherType.TabIndex = 4;
            this.labelFinancialVoucherType.Text = "Financial Voucher Type:";
            //
            //textBoxFinancialVoucherType
            //
            this.textBoxFinancialVoucherType.Location = new System.Drawing.Point(189, 36);
            this.textBoxFinancialVoucherType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialVoucherType.Name = "textBoxFinancialVoucherType";
            this.textBoxFinancialVoucherType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialVoucherType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialVoucherTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialVoucherTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialVoucherTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialVoucherTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialVoucherTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialVoucherTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialVoucherTypeRef.Name = "dataGridViewCrudeFinancialVoucherTypeRef";
            this.dataGridViewCrudeFinancialVoucherTypeRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeFinancialVoucherTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialVoucherTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialVoucherTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialVoucherTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialVoucherTypeRefSearch
            // 
            this.buttonCrudeFinancialVoucherTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherTypeRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeFinancialVoucherTypeRefSearch.Name = "buttonCrudeFinancialVoucherTypeRefSearch";
            this.buttonCrudeFinancialVoucherTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialVoucherTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialVoucherTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialVoucherTypeRefAdd
            // 
            this.buttonCrudeFinancialVoucherTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherTypeRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeFinancialVoucherTypeRefAdd.Name = "buttonCrudeFinancialVoucherTypeRefAdd";
            this.buttonCrudeFinancialVoucherTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialVoucherTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialVoucherTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialVoucherTypeRefEdit
            // 
            this.buttonCrudeFinancialVoucherTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialVoucherTypeRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeFinancialVoucherTypeRefEdit.Name = "buttonCrudeFinancialVoucherTypeRefEdit";
            this.buttonCrudeFinancialVoucherTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialVoucherTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialVoucherTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialVoucherTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialVoucherTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialVoucherTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeFinancialVoucherTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialVoucherTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialVoucherTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialVoucherTypeRef);
            this.Name = "CrudeFinancialVoucherTypeRefSearch";
            this.Text = "Financial Voucher Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialVoucherTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialVoucherTypeName);
            this.Controls.Add(this.textBoxFinancialVoucherTypeName);
            this.Controls.Add(this.labelFinancialVoucherType);
            this.Controls.Add(this.textBoxFinancialVoucherType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
