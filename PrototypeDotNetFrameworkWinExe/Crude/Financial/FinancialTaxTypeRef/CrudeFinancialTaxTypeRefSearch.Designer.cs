namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialTaxTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialTaxTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialTaxTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialTaxTypeName;
        
        private System.Windows.Forms.Label labelFinancialTaxTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialTaxType;
        
        private System.Windows.Forms.Label labelFinancialTaxType;
        
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
            this.buttonCrudeFinancialTaxTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialTaxTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialTaxTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialTaxTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialTaxTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialTaxTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialTaxType = new System.Windows.Forms.Label();
            this.textBoxFinancialTaxType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialTaxTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialTaxTypeName
            //
            this.labelFinancialTaxTypeName.AutoSize = true;
            this.labelFinancialTaxTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialTaxTypeName.Name = "labelFinancialTaxTypeName";
            this.labelFinancialTaxTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialTaxTypeName.TabIndex = 2;
            this.labelFinancialTaxTypeName.Text = "Financial Tax Type Name:";
            //
            //textBoxFinancialTaxTypeName
            //
            this.textBoxFinancialTaxTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxFinancialTaxTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialTaxTypeName.Name = "textBoxFinancialTaxTypeName";
            this.textBoxFinancialTaxTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialTaxTypeName.TabIndex = 3;
            //
            // labelFinancialTaxType
            //
            this.labelFinancialTaxType.AutoSize = true;
            this.labelFinancialTaxType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialTaxType.Name = "labelFinancialTaxType";
            this.labelFinancialTaxType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialTaxType.TabIndex = 4;
            this.labelFinancialTaxType.Text = "Financial Tax Type:";
            //
            //textBoxFinancialTaxType
            //
            this.textBoxFinancialTaxType.Location = new System.Drawing.Point(161, 36);
            this.textBoxFinancialTaxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialTaxType.Name = "textBoxFinancialTaxType";
            this.textBoxFinancialTaxType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialTaxType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialTaxTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialTaxTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialTaxTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialTaxTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialTaxTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialTaxTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialTaxTypeRef.Name = "dataGridViewCrudeFinancialTaxTypeRef";
            this.dataGridViewCrudeFinancialTaxTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeFinancialTaxTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialTaxTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialTaxTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialTaxTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialTaxTypeRefSearch
            // 
            this.buttonCrudeFinancialTaxTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeFinancialTaxTypeRefSearch.Name = "buttonCrudeFinancialTaxTypeRefSearch";
            this.buttonCrudeFinancialTaxTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialTaxTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialTaxTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialTaxTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialTaxTypeRefAdd
            // 
            this.buttonCrudeFinancialTaxTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeFinancialTaxTypeRefAdd.Name = "buttonCrudeFinancialTaxTypeRefAdd";
            this.buttonCrudeFinancialTaxTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialTaxTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialTaxTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialTaxTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialTaxTypeRefEdit
            // 
            this.buttonCrudeFinancialTaxTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialTaxTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeFinancialTaxTypeRefEdit.Name = "buttonCrudeFinancialTaxTypeRefEdit";
            this.buttonCrudeFinancialTaxTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialTaxTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialTaxTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialTaxTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialTaxTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialTaxTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeFinancialTaxTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialTaxTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialTaxTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialTaxTypeRef);
            this.Name = "CrudeFinancialTaxTypeRefSearch";
            this.Text = "Financial Tax Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialTaxTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialTaxTypeName);
            this.Controls.Add(this.textBoxFinancialTaxTypeName);
            this.Controls.Add(this.labelFinancialTaxType);
            this.Controls.Add(this.textBoxFinancialTaxType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
