namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialFee;
        
        private FinancialFeeTypeRefCombo financialFeeTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialFeeTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
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
            this.buttonCrudeFinancialFeeAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFeeEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFeeSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialFee = new System.Windows.Forms.DataGridView();
            this.labelFinancialFeeTypeRefCombo = new System.Windows.Forms.Label();
            this.financialFeeTypeRefCombo = new FinancialFeeTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFee)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialFeeTypeRefCombo
            //
            this.labelFinancialFeeTypeRefCombo.AutoSize = true;
            this.labelFinancialFeeTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFeeTypeRefCombo.Name = "labelFinancialFeeTypeRefCombo";
            this.labelFinancialFeeTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFeeTypeRefCombo.TabIndex = 2;
            this.labelFinancialFeeTypeRefCombo.Text = "Financial Fee Type:";
            //
            //financialFeeTypeRefCombo
            //
            this.financialFeeTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.financialFeeTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialFeeTypeRefCombo.Name = "financialFeeTypeRefCombo";
            this.financialFeeTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialFeeTypeRefCombo.TabIndex = 3;
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
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(140, 36);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialFee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialFee.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialFee.Name = "dataGridViewCrudeFinancialFee";
            this.dataGridViewCrudeFinancialFee.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialFee.TabIndex = 0;
            this.dataGridViewCrudeFinancialFee.ReadOnly = true;
            this.dataGridViewCrudeFinancialFee.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialFee_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialFeeSearch
            // 
            this.buttonCrudeFinancialFeeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeFinancialFeeSearch.Name = "buttonCrudeFinancialFeeSearch";
            this.buttonCrudeFinancialFeeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeSearch.TabIndex = 2;
            this.buttonCrudeFinancialFeeSearch.Text = "&Search";
            this.buttonCrudeFinancialFeeSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeSearch.Click += new System.EventHandler(this.buttonCrudeFinancialFeeSearch_Click);
            // 
            // buttonCrudeFinancialFeeAdd
            // 
            this.buttonCrudeFinancialFeeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeFinancialFeeAdd.Name = "buttonCrudeFinancialFeeAdd";
            this.buttonCrudeFinancialFeeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeAdd.TabIndex = 3;
            this.buttonCrudeFinancialFeeAdd.Text = "&Add";
            this.buttonCrudeFinancialFeeAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeAdd.Click += new System.EventHandler(this.buttonCrudeFinancialFeeAdd_Click);
            // 
            // buttonCrudeFinancialFeeEdit
            // 
            this.buttonCrudeFinancialFeeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeFinancialFeeEdit.Name = "buttonCrudeFinancialFeeEdit";
            this.buttonCrudeFinancialFeeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeEdit.TabIndex = 4;
            this.buttonCrudeFinancialFeeEdit.Text = "&Edit";
            this.buttonCrudeFinancialFeeEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeEdit.Click += new System.EventHandler(this.buttonCrudeFinancialFeeEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeFinancialFeeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialFeeAdd);
            this.Controls.Add(this.buttonCrudeFinancialFeeEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialFee);
            this.Name = "CrudeFinancialFeeSearch";
            this.Text = "Financial Fee Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFee)).EndInit();
            this.Controls.Add(this.labelFinancialFeeTypeRefCombo);
            this.Controls.Add(this.financialFeeTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
