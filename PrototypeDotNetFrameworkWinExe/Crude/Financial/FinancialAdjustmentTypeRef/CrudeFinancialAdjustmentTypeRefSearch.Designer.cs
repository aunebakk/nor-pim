namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialAdjustmentTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialAdjustmentTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialAdjustmentTypeName;
        
        private System.Windows.Forms.Label labelFinancialAdjustmentTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialAdjustmentType;
        
        private System.Windows.Forms.Label labelFinancialAdjustmentType;
        
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
            this.buttonCrudeFinancialAdjustmentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialAdjustmentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialAdjustmentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialAdjustmentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialAdjustmentTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialAdjustmentTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialAdjustmentType = new System.Windows.Forms.Label();
            this.textBoxFinancialAdjustmentType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialAdjustmentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialAdjustmentTypeName
            //
            this.labelFinancialAdjustmentTypeName.AutoSize = true;
            this.labelFinancialAdjustmentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialAdjustmentTypeName.Name = "labelFinancialAdjustmentTypeName";
            this.labelFinancialAdjustmentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialAdjustmentTypeName.TabIndex = 2;
            this.labelFinancialAdjustmentTypeName.Text = "Financial Adjustment Type Name:";
            //
            //textBoxFinancialAdjustmentTypeName
            //
            this.textBoxFinancialAdjustmentTypeName.Location = new System.Drawing.Point(210, 13);
            this.textBoxFinancialAdjustmentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialAdjustmentTypeName.Name = "textBoxFinancialAdjustmentTypeName";
            this.textBoxFinancialAdjustmentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialAdjustmentTypeName.TabIndex = 3;
            //
            // labelFinancialAdjustmentType
            //
            this.labelFinancialAdjustmentType.AutoSize = true;
            this.labelFinancialAdjustmentType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialAdjustmentType.Name = "labelFinancialAdjustmentType";
            this.labelFinancialAdjustmentType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialAdjustmentType.TabIndex = 4;
            this.labelFinancialAdjustmentType.Text = "Financial Adjustment Type:";
            //
            //textBoxFinancialAdjustmentType
            //
            this.textBoxFinancialAdjustmentType.Location = new System.Drawing.Point(210, 36);
            this.textBoxFinancialAdjustmentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialAdjustmentType.Name = "textBoxFinancialAdjustmentType";
            this.textBoxFinancialAdjustmentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialAdjustmentType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialAdjustmentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.Name = "dataGridViewCrudeFinancialAdjustmentTypeRef";
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialAdjustmentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialAdjustmentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialAdjustmentTypeRefSearch
            // 
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Location = new System.Drawing.Point(268, 195);
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Name = "buttonCrudeFinancialAdjustmentTypeRefSearch";
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialAdjustmentTypeRefAdd
            // 
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Location = new System.Drawing.Point(168, 195);
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Name = "buttonCrudeFinancialAdjustmentTypeRefAdd";
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialAdjustmentTypeRefEdit
            // 
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Location = new System.Drawing.Point(68, 195);
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Name = "buttonCrudeFinancialAdjustmentTypeRefEdit";
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialAdjustmentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialAdjustmentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 223);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialAdjustmentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialAdjustmentTypeRef);
            this.Name = "CrudeFinancialAdjustmentTypeRefSearch";
            this.Text = "Financial Adjustment Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialAdjustmentTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialAdjustmentTypeName);
            this.Controls.Add(this.textBoxFinancialAdjustmentTypeName);
            this.Controls.Add(this.labelFinancialAdjustmentType);
            this.Controls.Add(this.textBoxFinancialAdjustmentType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
