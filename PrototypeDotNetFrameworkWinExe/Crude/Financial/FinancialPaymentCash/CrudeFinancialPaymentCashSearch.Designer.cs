namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCashSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCashSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCashAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentCashEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentCash;
        
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
            this.buttonCrudeFinancialPaymentCashAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCashEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentCashSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentCash = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCash)).BeginInit();
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
            // dataGridViewCrudeFinancialPaymentCash
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentCash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentCash.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeFinancialPaymentCash.Name = "dataGridViewCrudeFinancialPaymentCash";
            this.dataGridViewCrudeFinancialPaymentCash.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialPaymentCash.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentCash.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentCash.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentCash_DoubleClick);
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
            // buttonCrudeFinancialPaymentCashSearch
            // 
            this.buttonCrudeFinancialPaymentCashSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCashSearch.Location = new System.Drawing.Point(198, 172);
            this.buttonCrudeFinancialPaymentCashSearch.Name = "buttonCrudeFinancialPaymentCashSearch";
            this.buttonCrudeFinancialPaymentCashSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCashSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentCashSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentCashSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCashSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCashSearch_Click);
            // 
            // buttonCrudeFinancialPaymentCashAdd
            // 
            this.buttonCrudeFinancialPaymentCashAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCashAdd.Location = new System.Drawing.Point(98, 172);
            this.buttonCrudeFinancialPaymentCashAdd.Name = "buttonCrudeFinancialPaymentCashAdd";
            this.buttonCrudeFinancialPaymentCashAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCashAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentCashAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentCashAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCashAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCashAdd_Click);
            // 
            // buttonCrudeFinancialPaymentCashEdit
            // 
            this.buttonCrudeFinancialPaymentCashEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentCashEdit.Location = new System.Drawing.Point(-2, 172);
            this.buttonCrudeFinancialPaymentCashEdit.Name = "buttonCrudeFinancialPaymentCashEdit";
            this.buttonCrudeFinancialPaymentCashEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentCashEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentCashEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentCashEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentCashEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentCashEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCashSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCashAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentCashEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentCash);
            this.Name = "CrudeFinancialPaymentCashSearch";
            this.Text = "Financial Payment Cash Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentCash)).EndInit();
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
