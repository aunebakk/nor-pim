namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCardTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCardTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCardTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCardTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCardTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialCardTypeName;
        
        private System.Windows.Forms.Label labelFinancialCardTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialCardType;
        
        private System.Windows.Forms.Label labelFinancialCardType;
        
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
            this.buttonCrudeFinancialCardTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCardTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCardTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCardTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialCardTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCardTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialCardType = new System.Windows.Forms.Label();
            this.textBoxFinancialCardType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCardTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCardTypeName
            //
            this.labelFinancialCardTypeName.AutoSize = true;
            this.labelFinancialCardTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCardTypeName.Name = "labelFinancialCardTypeName";
            this.labelFinancialCardTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardTypeName.TabIndex = 2;
            this.labelFinancialCardTypeName.Text = "Financial Card Type Name:";
            //
            //textBoxFinancialCardTypeName
            //
            this.textBoxFinancialCardTypeName.Location = new System.Drawing.Point(168, 13);
            this.textBoxFinancialCardTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCardTypeName.Name = "textBoxFinancialCardTypeName";
            this.textBoxFinancialCardTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCardTypeName.TabIndex = 3;
            //
            // labelFinancialCardType
            //
            this.labelFinancialCardType.AutoSize = true;
            this.labelFinancialCardType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCardType.Name = "labelFinancialCardType";
            this.labelFinancialCardType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardType.TabIndex = 4;
            this.labelFinancialCardType.Text = "Financial Card Type:";
            //
            //textBoxFinancialCardType
            //
            this.textBoxFinancialCardType.Location = new System.Drawing.Point(168, 36);
            this.textBoxFinancialCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCardType.Name = "textBoxFinancialCardType";
            this.textBoxFinancialCardType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCardType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialCardTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCardTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCardTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCardTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCardTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCardTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialCardTypeRef.Name = "dataGridViewCrudeFinancialCardTypeRef";
            this.dataGridViewCrudeFinancialCardTypeRef.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeFinancialCardTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialCardTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialCardTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCardTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCardTypeRefSearch
            // 
            this.buttonCrudeFinancialCardTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCardTypeRefSearch.Location = new System.Drawing.Point(226, 195);
            this.buttonCrudeFinancialCardTypeRefSearch.Name = "buttonCrudeFinancialCardTypeRefSearch";
            this.buttonCrudeFinancialCardTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCardTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialCardTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialCardTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCardTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCardTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialCardTypeRefAdd
            // 
            this.buttonCrudeFinancialCardTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCardTypeRefAdd.Location = new System.Drawing.Point(126, 195);
            this.buttonCrudeFinancialCardTypeRefAdd.Name = "buttonCrudeFinancialCardTypeRefAdd";
            this.buttonCrudeFinancialCardTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCardTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialCardTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialCardTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCardTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCardTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialCardTypeRefEdit
            // 
            this.buttonCrudeFinancialCardTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCardTypeRefEdit.Location = new System.Drawing.Point(26, 195);
            this.buttonCrudeFinancialCardTypeRefEdit.Name = "buttonCrudeFinancialCardTypeRefEdit";
            this.buttonCrudeFinancialCardTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCardTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialCardTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialCardTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCardTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCardTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.buttonCrudeFinancialCardTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCardTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialCardTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCardTypeRef);
            this.Name = "CrudeFinancialCardTypeRefSearch";
            this.Text = "Financial Card Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCardTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialCardTypeName);
            this.Controls.Add(this.textBoxFinancialCardTypeName);
            this.Controls.Add(this.labelFinancialCardType);
            this.Controls.Add(this.textBoxFinancialCardType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
