namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentVoucherSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentVoucherSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentVoucherAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentVoucherEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentVoucher;
        
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
            this.buttonCrudeFinancialPaymentVoucherAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentVoucherEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentVoucherSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentVoucher = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentVoucher)).BeginInit();
            this.SuspendLayout();
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 13);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(140, 13);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeFinancialPaymentVoucher
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentVoucher.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeFinancialPaymentVoucher.Name = "dataGridViewCrudeFinancialPaymentVoucher";
            this.dataGridViewCrudeFinancialPaymentVoucher.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialPaymentVoucher.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentVoucher.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentVoucher.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentVoucher_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentVoucherSearch
            // 
            this.buttonCrudeFinancialPaymentVoucherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentVoucherSearch.Location = new System.Drawing.Point(198, 172);
            this.buttonCrudeFinancialPaymentVoucherSearch.Name = "buttonCrudeFinancialPaymentVoucherSearch";
            this.buttonCrudeFinancialPaymentVoucherSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentVoucherSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentVoucherSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentVoucherSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentVoucherSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentVoucherSearch_Click);
            // 
            // buttonCrudeFinancialPaymentVoucherAdd
            // 
            this.buttonCrudeFinancialPaymentVoucherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentVoucherAdd.Location = new System.Drawing.Point(98, 172);
            this.buttonCrudeFinancialPaymentVoucherAdd.Name = "buttonCrudeFinancialPaymentVoucherAdd";
            this.buttonCrudeFinancialPaymentVoucherAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentVoucherAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentVoucherAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentVoucherAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentVoucherAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentVoucherAdd_Click);
            // 
            // buttonCrudeFinancialPaymentVoucherEdit
            // 
            this.buttonCrudeFinancialPaymentVoucherEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentVoucherEdit.Location = new System.Drawing.Point(-2, 172);
            this.buttonCrudeFinancialPaymentVoucherEdit.Name = "buttonCrudeFinancialPaymentVoucherEdit";
            this.buttonCrudeFinancialPaymentVoucherEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentVoucherEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentVoucherEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentVoucherEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentVoucherEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentVoucherEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.buttonCrudeFinancialPaymentVoucherSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentVoucherAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentVoucherEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentVoucher);
            this.Name = "CrudeFinancialPaymentVoucherSearch";
            this.Text = "Financial Payment Voucher Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentVoucher)).EndInit();
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
