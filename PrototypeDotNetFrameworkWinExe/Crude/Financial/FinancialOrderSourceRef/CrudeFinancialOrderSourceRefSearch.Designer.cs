namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderSourceRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderSourceRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderSourceRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderSourceRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderSourceRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderSourceName;
        
        private System.Windows.Forms.Label labelFinancialOrderSourceName;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderSource;
        
        private System.Windows.Forms.Label labelFinancialOrderSource;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderSourceCode;
        
        private System.Windows.Forms.Label labelFinancialOrderSourceCode;
        
        private System.Windows.Forms.TextBox textBoxStatusCode;
        
        private System.Windows.Forms.Label labelStatusCode;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortSequenceNumber;
        
        private System.Windows.Forms.Label labelSortSequenceNumber;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxChangeFlag;
        
        private System.Windows.Forms.Label labelChangeFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderSourceRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderSourceRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderSourceRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderSourceRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderSourceName = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderSourceName = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderSource = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderSource = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderSourceCode = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderSourceCode = new System.Windows.Forms.TextBox();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.labelSortSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSortSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelChangeFlag = new System.Windows.Forms.Label();
            this.checkBoxChangeFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderSourceRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderSourceName
            //
            this.labelFinancialOrderSourceName.AutoSize = true;
            this.labelFinancialOrderSourceName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderSourceName.Name = "labelFinancialOrderSourceName";
            this.labelFinancialOrderSourceName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderSourceName.TabIndex = 2;
            this.labelFinancialOrderSourceName.Text = "Financial Order Source Name:";
            //
            //textBoxFinancialOrderSourceName
            //
            this.textBoxFinancialOrderSourceName.Location = new System.Drawing.Point(189, 13);
            this.textBoxFinancialOrderSourceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderSourceName.Name = "textBoxFinancialOrderSourceName";
            this.textBoxFinancialOrderSourceName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderSourceName.TabIndex = 3;
            //
            // labelFinancialOrderSource
            //
            this.labelFinancialOrderSource.AutoSize = true;
            this.labelFinancialOrderSource.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderSource.Name = "labelFinancialOrderSource";
            this.labelFinancialOrderSource.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderSource.TabIndex = 4;
            this.labelFinancialOrderSource.Text = "Financial Order Source:";
            //
            //textBoxFinancialOrderSource
            //
            this.textBoxFinancialOrderSource.Location = new System.Drawing.Point(189, 36);
            this.textBoxFinancialOrderSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderSource.Name = "textBoxFinancialOrderSource";
            this.textBoxFinancialOrderSource.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderSource.TabIndex = 5;
            //
            // labelFinancialOrderSourceCode
            //
            this.labelFinancialOrderSourceCode.AutoSize = true;
            this.labelFinancialOrderSourceCode.Location = new System.Drawing.Point(11, 59);
            this.labelFinancialOrderSourceCode.Name = "labelFinancialOrderSourceCode";
            this.labelFinancialOrderSourceCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderSourceCode.TabIndex = 6;
            this.labelFinancialOrderSourceCode.Text = "Financial Order Source Code:";
            //
            //textBoxFinancialOrderSourceCode
            //
            this.textBoxFinancialOrderSourceCode.Location = new System.Drawing.Point(189, 59);
            this.textBoxFinancialOrderSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderSourceCode.Name = "textBoxFinancialOrderSourceCode";
            this.textBoxFinancialOrderSourceCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderSourceCode.TabIndex = 7;
            //
            // labelStatusCode
            //
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(11, 82);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(71, 13);
            this.labelStatusCode.TabIndex = 8;
            this.labelStatusCode.Text = "Status Code:";
            //
            //textBoxStatusCode
            //
            this.textBoxStatusCode.Location = new System.Drawing.Point(189, 82);
            this.textBoxStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxStatusCode.TabIndex = 9;
            //
            // labelSortSequenceNumber
            //
            this.labelSortSequenceNumber.AutoSize = true;
            this.labelSortSequenceNumber.Location = new System.Drawing.Point(11, 105);
            this.labelSortSequenceNumber.Name = "labelSortSequenceNumber";
            this.labelSortSequenceNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSortSequenceNumber.TabIndex = 10;
            this.labelSortSequenceNumber.Text = "Sort Sequence Number:";
            //
            //maskedTextBoxSortSequenceNumber
            //
            this.maskedTextBoxSortSequenceNumber.Location = new System.Drawing.Point(189, 105);
            this.maskedTextBoxSortSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortSequenceNumber.Name = "maskedTextBoxSortSequenceNumber";
            this.maskedTextBoxSortSequenceNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortSequenceNumber.TabIndex = 11;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            //
            // labelChangeFlag
            //
            this.labelChangeFlag.AutoSize = true;
            this.labelChangeFlag.Location = new System.Drawing.Point(11, 151);
            this.labelChangeFlag.Name = "labelChangeFlag";
            this.labelChangeFlag.Size = new System.Drawing.Size(71, 13);
            this.labelChangeFlag.TabIndex = 14;
            this.labelChangeFlag.Text = "Change Flag:";
            //
            //checkBoxChangeFlag
            //
            this.checkBoxChangeFlag.Location = new System.Drawing.Point(189, 151);
            this.checkBoxChangeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChangeFlag.Name = "checkBoxChangeFlag";
            this.checkBoxChangeFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxChangeFlag.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialOrderSourceRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderSourceRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderSourceRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderSourceRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderSourceRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderSourceRef.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialOrderSourceRef.Name = "dataGridViewCrudeFinancialOrderSourceRef";
            this.dataGridViewCrudeFinancialOrderSourceRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeFinancialOrderSourceRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderSourceRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderSourceRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderSourceRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderSourceRefSearch
            // 
            this.buttonCrudeFinancialOrderSourceRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderSourceRefSearch.Location = new System.Drawing.Point(247, 287);
            this.buttonCrudeFinancialOrderSourceRefSearch.Name = "buttonCrudeFinancialOrderSourceRefSearch";
            this.buttonCrudeFinancialOrderSourceRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderSourceRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderSourceRefSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderSourceRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderSourceRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderSourceRefSearch_Click);
            // 
            // buttonCrudeFinancialOrderSourceRefAdd
            // 
            this.buttonCrudeFinancialOrderSourceRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderSourceRefAdd.Location = new System.Drawing.Point(147, 287);
            this.buttonCrudeFinancialOrderSourceRefAdd.Name = "buttonCrudeFinancialOrderSourceRefAdd";
            this.buttonCrudeFinancialOrderSourceRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderSourceRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderSourceRefAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderSourceRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderSourceRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderSourceRefAdd_Click);
            // 
            // buttonCrudeFinancialOrderSourceRefEdit
            // 
            this.buttonCrudeFinancialOrderSourceRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderSourceRefEdit.Location = new System.Drawing.Point(47, 287);
            this.buttonCrudeFinancialOrderSourceRefEdit.Name = "buttonCrudeFinancialOrderSourceRefEdit";
            this.buttonCrudeFinancialOrderSourceRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderSourceRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderSourceRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderSourceRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderSourceRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderSourceRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 315);
            this.Controls.Add(this.buttonCrudeFinancialOrderSourceRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderSourceRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderSourceRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderSourceRef);
            this.Name = "CrudeFinancialOrderSourceRefSearch";
            this.Text = "Financial Order Source Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderSourceRef)).EndInit();
            this.Controls.Add(this.labelFinancialOrderSourceName);
            this.Controls.Add(this.textBoxFinancialOrderSourceName);
            this.Controls.Add(this.labelFinancialOrderSource);
            this.Controls.Add(this.textBoxFinancialOrderSource);
            this.Controls.Add(this.labelFinancialOrderSourceCode);
            this.Controls.Add(this.textBoxFinancialOrderSourceCode);
            this.Controls.Add(this.labelStatusCode);
            this.Controls.Add(this.textBoxStatusCode);
            this.Controls.Add(this.labelSortSequenceNumber);
            this.Controls.Add(this.maskedTextBoxSortSequenceNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelChangeFlag);
            this.Controls.Add(this.checkBoxChangeFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
