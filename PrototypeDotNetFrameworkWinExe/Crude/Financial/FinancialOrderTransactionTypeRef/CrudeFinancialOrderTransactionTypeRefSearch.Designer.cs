namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderTransactionTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderTransactionTypeName;
        
        private System.Windows.Forms.Label labelFinancialOrderTransactionTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderTransactionType;
        
        private System.Windows.Forms.Label labelFinancialOrderTransactionType;
        
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
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderTransactionTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderTransactionTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderTransactionType = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderTransactionType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderTransactionTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderTransactionTypeName
            //
            this.labelFinancialOrderTransactionTypeName.AutoSize = true;
            this.labelFinancialOrderTransactionTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderTransactionTypeName.Name = "labelFinancialOrderTransactionTypeName";
            this.labelFinancialOrderTransactionTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderTransactionTypeName.TabIndex = 2;
            this.labelFinancialOrderTransactionTypeName.Text = "Financial Order Transaction Type Name:";
            //
            //textBoxFinancialOrderTransactionTypeName
            //
            this.textBoxFinancialOrderTransactionTypeName.Location = new System.Drawing.Point(259, 13);
            this.textBoxFinancialOrderTransactionTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderTransactionTypeName.Name = "textBoxFinancialOrderTransactionTypeName";
            this.textBoxFinancialOrderTransactionTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderTransactionTypeName.TabIndex = 3;
            //
            // labelFinancialOrderTransactionType
            //
            this.labelFinancialOrderTransactionType.AutoSize = true;
            this.labelFinancialOrderTransactionType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderTransactionType.Name = "labelFinancialOrderTransactionType";
            this.labelFinancialOrderTransactionType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderTransactionType.TabIndex = 4;
            this.labelFinancialOrderTransactionType.Text = "Financial Order Transaction Type:";
            //
            //textBoxFinancialOrderTransactionType
            //
            this.textBoxFinancialOrderTransactionType.Location = new System.Drawing.Point(259, 36);
            this.textBoxFinancialOrderTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderTransactionType.Name = "textBoxFinancialOrderTransactionType";
            this.textBoxFinancialOrderTransactionType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderTransactionType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(259, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialOrderTransactionTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.Name = "dataGridViewCrudeFinancialOrderTransactionTypeRef";
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.Size = new System.Drawing.Size(497, 96);
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderTransactionTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderTransactionTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(417, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderTransactionTypeRefSearch
            // 
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Location = new System.Drawing.Point(317, 195);
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Name = "buttonCrudeFinancialOrderTransactionTypeRefSearch";
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialOrderTransactionTypeRefAdd
            // 
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Location = new System.Drawing.Point(217, 195);
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Name = "buttonCrudeFinancialOrderTransactionTypeRefAdd";
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialOrderTransactionTypeRefEdit
            // 
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Location = new System.Drawing.Point(117, 195);
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Name = "buttonCrudeFinancialOrderTransactionTypeRefEdit";
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 223);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderTransactionTypeRef);
            this.Name = "CrudeFinancialOrderTransactionTypeRefSearch";
            this.Text = "Financial Order Transaction Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderTransactionTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialOrderTransactionTypeName);
            this.Controls.Add(this.textBoxFinancialOrderTransactionTypeName);
            this.Controls.Add(this.labelFinancialOrderTransactionType);
            this.Controls.Add(this.textBoxFinancialOrderTransactionType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
