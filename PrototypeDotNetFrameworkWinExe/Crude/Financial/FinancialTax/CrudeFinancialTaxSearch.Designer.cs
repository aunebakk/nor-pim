namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialTaxSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialTax;
        
        private FinancialTaxTypeRefCombo financialTaxTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialTaxTypeRefCombo;
        
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
            this.buttonCrudeFinancialTaxAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialTaxEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialTaxSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialTax = new System.Windows.Forms.DataGridView();
            this.labelFinancialTaxTypeRefCombo = new System.Windows.Forms.Label();
            this.financialTaxTypeRefCombo = new FinancialTaxTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialTax)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialTaxTypeRefCombo
            //
            this.labelFinancialTaxTypeRefCombo.AutoSize = true;
            this.labelFinancialTaxTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialTaxTypeRefCombo.Name = "labelFinancialTaxTypeRefCombo";
            this.labelFinancialTaxTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialTaxTypeRefCombo.TabIndex = 2;
            this.labelFinancialTaxTypeRefCombo.Text = "Financial Tax Type:";
            //
            //financialTaxTypeRefCombo
            //
            this.financialTaxTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.financialTaxTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialTaxTypeRefCombo.Name = "financialTaxTypeRefCombo";
            this.financialTaxTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialTaxTypeRefCombo.TabIndex = 3;
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
            // dataGridViewCrudeFinancialTax
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialTax.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialTax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialTax.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialTax.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialTax.Name = "dataGridViewCrudeFinancialTax";
            this.dataGridViewCrudeFinancialTax.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialTax.TabIndex = 0;
            this.dataGridViewCrudeFinancialTax.ReadOnly = true;
            this.dataGridViewCrudeFinancialTax.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialTax_DoubleClick);
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
            // buttonCrudeFinancialTaxSearch
            // 
            this.buttonCrudeFinancialTaxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeFinancialTaxSearch.Name = "buttonCrudeFinancialTaxSearch";
            this.buttonCrudeFinancialTaxSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxSearch.TabIndex = 2;
            this.buttonCrudeFinancialTaxSearch.Text = "&Search";
            this.buttonCrudeFinancialTaxSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxSearch.Click += new System.EventHandler(this.buttonCrudeFinancialTaxSearch_Click);
            // 
            // buttonCrudeFinancialTaxAdd
            // 
            this.buttonCrudeFinancialTaxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeFinancialTaxAdd.Name = "buttonCrudeFinancialTaxAdd";
            this.buttonCrudeFinancialTaxAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxAdd.TabIndex = 3;
            this.buttonCrudeFinancialTaxAdd.Text = "&Add";
            this.buttonCrudeFinancialTaxAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxAdd.Click += new System.EventHandler(this.buttonCrudeFinancialTaxAdd_Click);
            // 
            // buttonCrudeFinancialTaxEdit
            // 
            this.buttonCrudeFinancialTaxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeFinancialTaxEdit.Name = "buttonCrudeFinancialTaxEdit";
            this.buttonCrudeFinancialTaxEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxEdit.TabIndex = 4;
            this.buttonCrudeFinancialTaxEdit.Text = "&Edit";
            this.buttonCrudeFinancialTaxEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxEdit.Click += new System.EventHandler(this.buttonCrudeFinancialTaxEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeFinancialTaxSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialTaxAdd);
            this.Controls.Add(this.buttonCrudeFinancialTaxEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialTax);
            this.Name = "CrudeFinancialTaxSearch";
            this.Text = "Financial Tax Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialTax)).EndInit();
            this.Controls.Add(this.labelFinancialTaxTypeRefCombo);
            this.Controls.Add(this.financialTaxTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
