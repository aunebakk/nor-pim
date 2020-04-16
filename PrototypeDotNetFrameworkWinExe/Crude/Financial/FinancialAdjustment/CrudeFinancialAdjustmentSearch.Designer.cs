namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialAdjustment;
        
        private FinancialAdjustmentTypeRefCombo financialAdjustmentTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialAdjustmentTypeRefCombo;
        
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
            this.buttonCrudeFinancialAdjustmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialAdjustmentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialAdjustmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialAdjustment = new System.Windows.Forms.DataGridView();
            this.labelFinancialAdjustmentTypeRefCombo = new System.Windows.Forms.Label();
            this.financialAdjustmentTypeRefCombo = new FinancialAdjustmentTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialAdjustment)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialAdjustmentTypeRefCombo
            //
            this.labelFinancialAdjustmentTypeRefCombo.AutoSize = true;
            this.labelFinancialAdjustmentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialAdjustmentTypeRefCombo.Name = "labelFinancialAdjustmentTypeRefCombo";
            this.labelFinancialAdjustmentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialAdjustmentTypeRefCombo.TabIndex = 2;
            this.labelFinancialAdjustmentTypeRefCombo.Text = "Financial Adjustment Type:";
            //
            //financialAdjustmentTypeRefCombo
            //
            this.financialAdjustmentTypeRefCombo.Location = new System.Drawing.Point(175, 13);
            this.financialAdjustmentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialAdjustmentTypeRefCombo.Name = "financialAdjustmentTypeRefCombo";
            this.financialAdjustmentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialAdjustmentTypeRefCombo.TabIndex = 3;
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
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(175, 36);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialAdjustment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialAdjustment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialAdjustment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialAdjustment.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialAdjustment.Name = "dataGridViewCrudeFinancialAdjustment";
            this.dataGridViewCrudeFinancialAdjustment.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeFinancialAdjustment.TabIndex = 0;
            this.dataGridViewCrudeFinancialAdjustment.ReadOnly = true;
            this.dataGridViewCrudeFinancialAdjustment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialAdjustment_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialAdjustmentSearch
            // 
            this.buttonCrudeFinancialAdjustmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentSearch.Location = new System.Drawing.Point(233, 195);
            this.buttonCrudeFinancialAdjustmentSearch.Name = "buttonCrudeFinancialAdjustmentSearch";
            this.buttonCrudeFinancialAdjustmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentSearch.TabIndex = 2;
            this.buttonCrudeFinancialAdjustmentSearch.Text = "&Search";
            this.buttonCrudeFinancialAdjustmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentSearch.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentSearch_Click);
            // 
            // buttonCrudeFinancialAdjustmentAdd
            // 
            this.buttonCrudeFinancialAdjustmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentAdd.Location = new System.Drawing.Point(133, 195);
            this.buttonCrudeFinancialAdjustmentAdd.Name = "buttonCrudeFinancialAdjustmentAdd";
            this.buttonCrudeFinancialAdjustmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentAdd.TabIndex = 3;
            this.buttonCrudeFinancialAdjustmentAdd.Text = "&Add";
            this.buttonCrudeFinancialAdjustmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentAdd.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentAdd_Click);
            // 
            // buttonCrudeFinancialAdjustmentEdit
            // 
            this.buttonCrudeFinancialAdjustmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentEdit.Location = new System.Drawing.Point(33, 195);
            this.buttonCrudeFinancialAdjustmentEdit.Name = "buttonCrudeFinancialAdjustmentEdit";
            this.buttonCrudeFinancialAdjustmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentEdit.TabIndex = 4;
            this.buttonCrudeFinancialAdjustmentEdit.Text = "&Edit";
            this.buttonCrudeFinancialAdjustmentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentEdit.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 223);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentAdd);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialAdjustment);
            this.Name = "CrudeFinancialAdjustmentSearch";
            this.Text = "Financial Adjustment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialAdjustment)).EndInit();
            this.Controls.Add(this.labelFinancialAdjustmentTypeRefCombo);
            this.Controls.Add(this.financialAdjustmentTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
