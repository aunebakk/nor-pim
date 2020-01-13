namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderLineSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderLineSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderLineAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderLineEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderLine;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private FinancialUnitOfMeasurementRefCombo financialUnitOfMeasurementRefCombo;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLineNumber;
        
        private System.Windows.Forms.Label labelLineNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantityNumber;
        
        private System.Windows.Forms.Label labelQuantityNumber;
        
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
            this.buttonCrudeFinancialOrderLineAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderLineEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderLineSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderLine = new System.Windows.Forms.DataGridView();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelFinancialUnitOfMeasurementRefCombo = new System.Windows.Forms.Label();
            this.financialUnitOfMeasurementRefCombo = new FinancialUnitOfMeasurementRefCombo();
            this.labelLineNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxLineNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelQuantityNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantityNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderLine)).BeginInit();
            this.SuspendLayout();
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 13);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(203, 13);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 3;
            //
            // labelFinancialUnitOfMeasurementRefCombo
            //
            this.labelFinancialUnitOfMeasurementRefCombo.AutoSize = true;
            this.labelFinancialUnitOfMeasurementRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialUnitOfMeasurementRefCombo.Name = "labelFinancialUnitOfMeasurementRefCombo";
            this.labelFinancialUnitOfMeasurementRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementRefCombo.TabIndex = 4;
            this.labelFinancialUnitOfMeasurementRefCombo.Text = "Financial Unit Of Measurement:";
            //
            //financialUnitOfMeasurementRefCombo
            //
            this.financialUnitOfMeasurementRefCombo.Location = new System.Drawing.Point(203, 36);
            this.financialUnitOfMeasurementRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialUnitOfMeasurementRefCombo.Name = "financialUnitOfMeasurementRefCombo";
            this.financialUnitOfMeasurementRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialUnitOfMeasurementRefCombo.TabIndex = 5;
            //
            // labelLineNumber
            //
            this.labelLineNumber.AutoSize = true;
            this.labelLineNumber.Location = new System.Drawing.Point(11, 59);
            this.labelLineNumber.Name = "labelLineNumber";
            this.labelLineNumber.Size = new System.Drawing.Size(71, 13);
            this.labelLineNumber.TabIndex = 6;
            this.labelLineNumber.Text = "Line Number:";
            //
            //maskedTextBoxLineNumber
            //
            this.maskedTextBoxLineNumber.Location = new System.Drawing.Point(203, 59);
            this.maskedTextBoxLineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLineNumber.Name = "maskedTextBoxLineNumber";
            this.maskedTextBoxLineNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLineNumber.TabIndex = 7;
            //
            // labelQuantityNumber
            //
            this.labelQuantityNumber.AutoSize = true;
            this.labelQuantityNumber.Location = new System.Drawing.Point(11, 82);
            this.labelQuantityNumber.Name = "labelQuantityNumber";
            this.labelQuantityNumber.Size = new System.Drawing.Size(71, 13);
            this.labelQuantityNumber.TabIndex = 8;
            this.labelQuantityNumber.Text = "Quantity Number:";
            //
            //maskedTextBoxQuantityNumber
            //
            this.maskedTextBoxQuantityNumber.Location = new System.Drawing.Point(203, 82);
            this.maskedTextBoxQuantityNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxQuantityNumber.Name = "maskedTextBoxQuantityNumber";
            this.maskedTextBoxQuantityNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxQuantityNumber.TabIndex = 9;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 105);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 10;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(203, 105);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // dataGridViewCrudeFinancialOrderLine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderLine.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFinancialOrderLine.Name = "dataGridViewCrudeFinancialOrderLine";
            this.dataGridViewCrudeFinancialOrderLine.Size = new System.Drawing.Size(441, 96);
            this.dataGridViewCrudeFinancialOrderLine.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderLine.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderLine.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderLine_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderLineSearch
            // 
            this.buttonCrudeFinancialOrderLineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderLineSearch.Location = new System.Drawing.Point(261, 264);
            this.buttonCrudeFinancialOrderLineSearch.Name = "buttonCrudeFinancialOrderLineSearch";
            this.buttonCrudeFinancialOrderLineSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderLineSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderLineSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderLineSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderLineSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderLineSearch_Click);
            // 
            // buttonCrudeFinancialOrderLineAdd
            // 
            this.buttonCrudeFinancialOrderLineAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderLineAdd.Location = new System.Drawing.Point(161, 264);
            this.buttonCrudeFinancialOrderLineAdd.Name = "buttonCrudeFinancialOrderLineAdd";
            this.buttonCrudeFinancialOrderLineAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderLineAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderLineAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderLineAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderLineAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderLineAdd_Click);
            // 
            // buttonCrudeFinancialOrderLineEdit
            // 
            this.buttonCrudeFinancialOrderLineEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderLineEdit.Location = new System.Drawing.Point(61, 264);
            this.buttonCrudeFinancialOrderLineEdit.Name = "buttonCrudeFinancialOrderLineEdit";
            this.buttonCrudeFinancialOrderLineEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderLineEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderLineEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderLineEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderLineEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderLineEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 292);
            this.Controls.Add(this.buttonCrudeFinancialOrderLineSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderLineAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderLineEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderLine);
            this.Name = "CrudeFinancialOrderLineSearch";
            this.Text = "Financial Order Line Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderLine)).EndInit();
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelFinancialUnitOfMeasurementRefCombo);
            this.Controls.Add(this.financialUnitOfMeasurementRefCombo);
            this.Controls.Add(this.labelLineNumber);
            this.Controls.Add(this.maskedTextBoxLineNumber);
            this.Controls.Add(this.labelQuantityNumber);
            this.Controls.Add(this.maskedTextBoxQuantityNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
