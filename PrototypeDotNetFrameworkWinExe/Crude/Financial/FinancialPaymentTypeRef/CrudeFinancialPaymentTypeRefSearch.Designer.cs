namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialPaymentTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialPaymentTypeName;
        
        private System.Windows.Forms.Label labelFinancialPaymentTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialPaymentType;
        
        private System.Windows.Forms.Label labelFinancialPaymentType;
        
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
            this.buttonCrudeFinancialPaymentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialPaymentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialPaymentTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialPaymentTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialPaymentType = new System.Windows.Forms.Label();
            this.textBoxFinancialPaymentType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialPaymentTypeName
            //
            this.labelFinancialPaymentTypeName.AutoSize = true;
            this.labelFinancialPaymentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialPaymentTypeName.Name = "labelFinancialPaymentTypeName";
            this.labelFinancialPaymentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialPaymentTypeName.TabIndex = 2;
            this.labelFinancialPaymentTypeName.Text = "Financial Payment Type Name:";
            //
            //textBoxFinancialPaymentTypeName
            //
            this.textBoxFinancialPaymentTypeName.Location = new System.Drawing.Point(189, 13);
            this.textBoxFinancialPaymentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialPaymentTypeName.Name = "textBoxFinancialPaymentTypeName";
            this.textBoxFinancialPaymentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialPaymentTypeName.TabIndex = 3;
            //
            // labelFinancialPaymentType
            //
            this.labelFinancialPaymentType.AutoSize = true;
            this.labelFinancialPaymentType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialPaymentType.Name = "labelFinancialPaymentType";
            this.labelFinancialPaymentType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialPaymentType.TabIndex = 4;
            this.labelFinancialPaymentType.Text = "Financial Payment Type:";
            //
            //textBoxFinancialPaymentType
            //
            this.textBoxFinancialPaymentType.Location = new System.Drawing.Point(189, 36);
            this.textBoxFinancialPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialPaymentType.Name = "textBoxFinancialPaymentType";
            this.textBoxFinancialPaymentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialPaymentType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialPaymentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialPaymentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialPaymentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialPaymentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialPaymentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialPaymentTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialPaymentTypeRef.Name = "dataGridViewCrudeFinancialPaymentTypeRef";
            this.dataGridViewCrudeFinancialPaymentTypeRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeFinancialPaymentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialPaymentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialPaymentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialPaymentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialPaymentTypeRefSearch
            // 
            this.buttonCrudeFinancialPaymentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentTypeRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeFinancialPaymentTypeRefSearch.Name = "buttonCrudeFinancialPaymentTypeRefSearch";
            this.buttonCrudeFinancialPaymentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialPaymentTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialPaymentTypeRefAdd
            // 
            this.buttonCrudeFinancialPaymentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentTypeRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeFinancialPaymentTypeRefAdd.Name = "buttonCrudeFinancialPaymentTypeRefAdd";
            this.buttonCrudeFinancialPaymentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialPaymentTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialPaymentTypeRefEdit
            // 
            this.buttonCrudeFinancialPaymentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentTypeRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeFinancialPaymentTypeRefEdit.Name = "buttonCrudeFinancialPaymentTypeRefEdit";
            this.buttonCrudeFinancialPaymentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialPaymentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeFinancialPaymentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialPaymentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialPaymentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialPaymentTypeRef);
            this.Name = "CrudeFinancialPaymentTypeRefSearch";
            this.Text = "Financial Payment Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialPaymentTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialPaymentTypeName);
            this.Controls.Add(this.textBoxFinancialPaymentTypeName);
            this.Controls.Add(this.labelFinancialPaymentType);
            this.Controls.Add(this.textBoxFinancialPaymentType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
