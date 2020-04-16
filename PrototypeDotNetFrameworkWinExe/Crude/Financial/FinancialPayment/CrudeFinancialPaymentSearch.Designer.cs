namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPayment;
        
        private FinancialPaymentTypeRefCombo financialPaymentTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialPaymentTypeRefCombo;
        
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
            this.buttonCrudeFinancialPaymentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPayment = new System.Windows.Forms.DataGridView();
            this.labelFinancialPaymentTypeRefCombo = new System.Windows.Forms.Label();
            this.financialPaymentTypeRefCombo = new FinancialPaymentTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPayment)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialPaymentTypeRefCombo
            //
            this.labelFinancialPaymentTypeRefCombo.AutoSize = true;
            this.labelFinancialPaymentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialPaymentTypeRefCombo.Name = "labelFinancialPaymentTypeRefCombo";
            this.labelFinancialPaymentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialPaymentTypeRefCombo.TabIndex = 2;
            this.labelFinancialPaymentTypeRefCombo.Text = "Financial Payment Type:";
            //
            //financialPaymentTypeRefCombo
            //
            this.financialPaymentTypeRefCombo.Location = new System.Drawing.Point(196, 13);
            this.financialPaymentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialPaymentTypeRefCombo.Name = "financialPaymentTypeRefCombo";
            this.financialPaymentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialPaymentTypeRefCombo.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeFinancialPayment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPayment.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeFinancialPayment.Name = "dataGridViewCrudeFinancialPayment";
            this.dataGridViewCrudeFinancialPayment.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeFinancialPayment.TabIndex = 0;
            this.dataGridViewCrudeFinancialPayment.ReadOnly = true;
            this.dataGridViewCrudeFinancialPayment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPayment_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentSearch
            // 
            this.buttonCrudeFinancialPaymentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentSearch.Location = new System.Drawing.Point(254, 172);
            this.buttonCrudeFinancialPaymentSearch.Name = "buttonCrudeFinancialPaymentSearch";
            this.buttonCrudeFinancialPaymentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentSearch_Click);
            // 
            // buttonCrudeFinancialPaymentAdd
            // 
            this.buttonCrudeFinancialPaymentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentAdd.Location = new System.Drawing.Point(154, 172);
            this.buttonCrudeFinancialPaymentAdd.Name = "buttonCrudeFinancialPaymentAdd";
            this.buttonCrudeFinancialPaymentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentAdd_Click);
            // 
            // buttonCrudeFinancialPaymentEdit
            // 
            this.buttonCrudeFinancialPaymentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentEdit.Location = new System.Drawing.Point(54, 172);
            this.buttonCrudeFinancialPaymentEdit.Name = "buttonCrudeFinancialPaymentEdit";
            this.buttonCrudeFinancialPaymentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 200);
            this.Controls.Add(this.buttonCrudeFinancialPaymentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPayment);
            this.Name = "CrudeFinancialPaymentSearch";
            this.Text = "Financial Payment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPayment)).EndInit();
            this.Controls.Add(this.labelFinancialPaymentTypeRefCombo);
            this.Controls.Add(this.financialPaymentTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
