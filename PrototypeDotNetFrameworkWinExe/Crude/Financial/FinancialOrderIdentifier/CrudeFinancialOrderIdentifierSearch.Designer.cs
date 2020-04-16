namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderIdentifier;
        
        private FinancialOrderIdentifierTypeRefCombo financialOrderIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderIdentifierCode;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierCode;
        
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
            this.buttonCrudeFinancialOrderIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderIdentifier = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.financialOrderIdentifierTypeRefCombo = new FinancialOrderIdentifierTypeRefCombo();
            this.labelFinancialOrderIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderIdentifierTypeRefCombo
            //
            this.labelFinancialOrderIdentifierTypeRefCombo.AutoSize = true;
            this.labelFinancialOrderIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderIdentifierTypeRefCombo.Name = "labelFinancialOrderIdentifierTypeRefCombo";
            this.labelFinancialOrderIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierTypeRefCombo.TabIndex = 2;
            this.labelFinancialOrderIdentifierTypeRefCombo.Text = "Financial Order Identifier Type:";
            //
            //financialOrderIdentifierTypeRefCombo
            //
            this.financialOrderIdentifierTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.financialOrderIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialOrderIdentifierTypeRefCombo.Name = "financialOrderIdentifierTypeRefCombo";
            this.financialOrderIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialOrderIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelFinancialOrderIdentifierCode
            //
            this.labelFinancialOrderIdentifierCode.AutoSize = true;
            this.labelFinancialOrderIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderIdentifierCode.Name = "labelFinancialOrderIdentifierCode";
            this.labelFinancialOrderIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierCode.TabIndex = 4;
            this.labelFinancialOrderIdentifierCode.Text = "Financial Order Identifier Code:";
            //
            //textBoxFinancialOrderIdentifierCode
            //
            this.textBoxFinancialOrderIdentifierCode.Location = new System.Drawing.Point(217, 36);
            this.textBoxFinancialOrderIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderIdentifierCode.Name = "textBoxFinancialOrderIdentifierCode";
            this.textBoxFinancialOrderIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderIdentifierCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialOrderIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderIdentifier.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialOrderIdentifier.Name = "dataGridViewCrudeFinancialOrderIdentifier";
            this.dataGridViewCrudeFinancialOrderIdentifier.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeFinancialOrderIdentifier.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderIdentifier.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierSearch
            // 
            this.buttonCrudeFinancialOrderIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierSearch.Location = new System.Drawing.Point(275, 195);
            this.buttonCrudeFinancialOrderIdentifierSearch.Name = "buttonCrudeFinancialOrderIdentifierSearch";
            this.buttonCrudeFinancialOrderIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderIdentifierSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierSearch_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierAdd
            // 
            this.buttonCrudeFinancialOrderIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierAdd.Location = new System.Drawing.Point(175, 195);
            this.buttonCrudeFinancialOrderIdentifierAdd.Name = "buttonCrudeFinancialOrderIdentifierAdd";
            this.buttonCrudeFinancialOrderIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderIdentifierAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierAdd_Click);
            // 
            // buttonCrudeFinancialOrderIdentifierEdit
            // 
            this.buttonCrudeFinancialOrderIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderIdentifierEdit.Location = new System.Drawing.Point(75, 195);
            this.buttonCrudeFinancialOrderIdentifierEdit.Name = "buttonCrudeFinancialOrderIdentifierEdit";
            this.buttonCrudeFinancialOrderIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderIdentifierEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderIdentifierEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 223);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderIdentifier);
            this.Name = "CrudeFinancialOrderIdentifierSearch";
            this.Text = "Financial Order Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderIdentifier)).EndInit();
            this.Controls.Add(this.labelFinancialOrderIdentifierTypeRefCombo);
            this.Controls.Add(this.financialOrderIdentifierTypeRefCombo);
            this.Controls.Add(this.labelFinancialOrderIdentifierCode);
            this.Controls.Add(this.textBoxFinancialOrderIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
