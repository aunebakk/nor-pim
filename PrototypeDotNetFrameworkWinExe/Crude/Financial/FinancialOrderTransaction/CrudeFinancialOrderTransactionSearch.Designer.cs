namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderTransactionEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderTransaction;
        
        private FinancialOrderTransactionTypeRefCombo financialOrderTransactionTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialOrderTransactionTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTransactionNumber;
        
        private System.Windows.Forms.Label labelTransactionNumber;
        
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
            this.buttonCrudeFinancialOrderTransactionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderTransactionEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderTransactionSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderTransaction = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderTransactionTypeRefCombo = new System.Windows.Forms.Label();
            this.financialOrderTransactionTypeRefCombo = new FinancialOrderTransactionTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelTransactionNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxTransactionNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderTransaction)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderTransactionTypeRefCombo
            //
            this.labelFinancialOrderTransactionTypeRefCombo.AutoSize = true;
            this.labelFinancialOrderTransactionTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderTransactionTypeRefCombo.Name = "labelFinancialOrderTransactionTypeRefCombo";
            this.labelFinancialOrderTransactionTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderTransactionTypeRefCombo.TabIndex = 2;
            this.labelFinancialOrderTransactionTypeRefCombo.Text = "Financial Order Transaction Type:";
            //
            //financialOrderTransactionTypeRefCombo
            //
            this.financialOrderTransactionTypeRefCombo.Location = new System.Drawing.Point(224, 13);
            this.financialOrderTransactionTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialOrderTransactionTypeRefCombo.Name = "financialOrderTransactionTypeRefCombo";
            this.financialOrderTransactionTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialOrderTransactionTypeRefCombo.TabIndex = 3;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 36);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(224, 36);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 5;
            //
            // labelTransactionNumber
            //
            this.labelTransactionNumber.AutoSize = true;
            this.labelTransactionNumber.Location = new System.Drawing.Point(11, 59);
            this.labelTransactionNumber.Name = "labelTransactionNumber";
            this.labelTransactionNumber.Size = new System.Drawing.Size(71, 13);
            this.labelTransactionNumber.TabIndex = 6;
            this.labelTransactionNumber.Text = "Transaction Number:";
            //
            //maskedTextBoxTransactionNumber
            //
            this.maskedTextBoxTransactionNumber.Location = new System.Drawing.Point(224, 59);
            this.maskedTextBoxTransactionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTransactionNumber.Name = "maskedTextBoxTransactionNumber";
            this.maskedTextBoxTransactionNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxTransactionNumber.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeFinancialOrderTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderTransaction.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFinancialOrderTransaction.Name = "dataGridViewCrudeFinancialOrderTransaction";
            this.dataGridViewCrudeFinancialOrderTransaction.Size = new System.Drawing.Size(462, 96);
            this.dataGridViewCrudeFinancialOrderTransaction.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderTransaction.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderTransaction.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderTransaction_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderTransactionSearch
            // 
            this.buttonCrudeFinancialOrderTransactionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionSearch.Location = new System.Drawing.Point(282, 218);
            this.buttonCrudeFinancialOrderTransactionSearch.Name = "buttonCrudeFinancialOrderTransactionSearch";
            this.buttonCrudeFinancialOrderTransactionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderTransactionSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderTransactionSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionSearch_Click);
            // 
            // buttonCrudeFinancialOrderTransactionAdd
            // 
            this.buttonCrudeFinancialOrderTransactionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionAdd.Location = new System.Drawing.Point(182, 218);
            this.buttonCrudeFinancialOrderTransactionAdd.Name = "buttonCrudeFinancialOrderTransactionAdd";
            this.buttonCrudeFinancialOrderTransactionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderTransactionAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderTransactionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionAdd_Click);
            // 
            // buttonCrudeFinancialOrderTransactionEdit
            // 
            this.buttonCrudeFinancialOrderTransactionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderTransactionEdit.Location = new System.Drawing.Point(82, 218);
            this.buttonCrudeFinancialOrderTransactionEdit.Name = "buttonCrudeFinancialOrderTransactionEdit";
            this.buttonCrudeFinancialOrderTransactionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderTransactionEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderTransactionEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderTransactionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderTransactionEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderTransactionEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderTransactionEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderTransaction);
            this.Name = "CrudeFinancialOrderTransactionSearch";
            this.Text = "Financial Order Transaction Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderTransaction)).EndInit();
            this.Controls.Add(this.labelFinancialOrderTransactionTypeRefCombo);
            this.Controls.Add(this.financialOrderTransactionTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelTransactionNumber);
            this.Controls.Add(this.maskedTextBoxTransactionNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
