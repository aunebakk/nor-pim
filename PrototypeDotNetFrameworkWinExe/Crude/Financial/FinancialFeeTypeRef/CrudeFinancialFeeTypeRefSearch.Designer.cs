namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFeeTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialFeeTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialFeeTypeName;
        
        private System.Windows.Forms.Label labelFinancialFeeTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialFeeType;
        
        private System.Windows.Forms.Label labelFinancialFeeType;
        
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
            this.buttonCrudeFinancialFeeTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFeeTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFeeTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialFeeTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialFeeTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialFeeTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialFeeType = new System.Windows.Forms.Label();
            this.textBoxFinancialFeeType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFeeTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialFeeTypeName
            //
            this.labelFinancialFeeTypeName.AutoSize = true;
            this.labelFinancialFeeTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFeeTypeName.Name = "labelFinancialFeeTypeName";
            this.labelFinancialFeeTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFeeTypeName.TabIndex = 2;
            this.labelFinancialFeeTypeName.Text = "Financial Fee Type Name:";
            //
            //textBoxFinancialFeeTypeName
            //
            this.textBoxFinancialFeeTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxFinancialFeeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFeeTypeName.Name = "textBoxFinancialFeeTypeName";
            this.textBoxFinancialFeeTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFeeTypeName.TabIndex = 3;
            //
            // labelFinancialFeeType
            //
            this.labelFinancialFeeType.AutoSize = true;
            this.labelFinancialFeeType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialFeeType.Name = "labelFinancialFeeType";
            this.labelFinancialFeeType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFeeType.TabIndex = 4;
            this.labelFinancialFeeType.Text = "Financial Fee Type:";
            //
            //textBoxFinancialFeeType
            //
            this.textBoxFinancialFeeType.Location = new System.Drawing.Point(161, 36);
            this.textBoxFinancialFeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFeeType.Name = "textBoxFinancialFeeType";
            this.textBoxFinancialFeeType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFeeType.TabIndex = 5;
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
            // dataGridViewCrudeFinancialFeeTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialFeeTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialFeeTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialFeeTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialFeeTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialFeeTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialFeeTypeRef.Name = "dataGridViewCrudeFinancialFeeTypeRef";
            this.dataGridViewCrudeFinancialFeeTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeFinancialFeeTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialFeeTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialFeeTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialFeeTypeRef_DoubleClick);
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
            // buttonCrudeFinancialFeeTypeRefSearch
            // 
            this.buttonCrudeFinancialFeeTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeFinancialFeeTypeRefSearch.Name = "buttonCrudeFinancialFeeTypeRefSearch";
            this.buttonCrudeFinancialFeeTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialFeeTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialFeeTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialFeeTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialFeeTypeRefAdd
            // 
            this.buttonCrudeFinancialFeeTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeFinancialFeeTypeRefAdd.Name = "buttonCrudeFinancialFeeTypeRefAdd";
            this.buttonCrudeFinancialFeeTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialFeeTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialFeeTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialFeeTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialFeeTypeRefEdit
            // 
            this.buttonCrudeFinancialFeeTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFeeTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeFinancialFeeTypeRefEdit.Name = "buttonCrudeFinancialFeeTypeRefEdit";
            this.buttonCrudeFinancialFeeTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFeeTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialFeeTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialFeeTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFeeTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialFeeTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeFinancialFeeTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialFeeTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialFeeTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialFeeTypeRef);
            this.Name = "CrudeFinancialFeeTypeRefSearch";
            this.Text = "Financial Fee Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFeeTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialFeeTypeName);
            this.Controls.Add(this.textBoxFinancialFeeTypeName);
            this.Controls.Add(this.labelFinancialFeeType);
            this.Controls.Add(this.textBoxFinancialFeeType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
