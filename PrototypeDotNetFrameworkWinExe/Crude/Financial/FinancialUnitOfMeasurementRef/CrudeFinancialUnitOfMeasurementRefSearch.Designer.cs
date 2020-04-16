namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialUnitOfMeasurementRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialUnitOfMeasurementRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialUnitOfMeasurementRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialUnitOfMeasurementRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialUnitOfMeasurementRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurementName;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementName;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurement;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurement;
        
        private System.Windows.Forms.TextBox textBoxStatusCode;
        
        private System.Windows.Forms.Label labelStatusCode;
        
        private System.Windows.Forms.TextBox textBoxFinancialUnitOfMeasurementCode;
        
        private System.Windows.Forms.Label labelFinancialUnitOfMeasurementCode;
        
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
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialUnitOfMeasurementName = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurementName = new System.Windows.Forms.TextBox();
            this.labelFinancialUnitOfMeasurement = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.textBoxStatusCode = new System.Windows.Forms.TextBox();
            this.labelFinancialUnitOfMeasurementCode = new System.Windows.Forms.Label();
            this.textBoxFinancialUnitOfMeasurementCode = new System.Windows.Forms.TextBox();
            this.labelSortSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSortSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelChangeFlag = new System.Windows.Forms.Label();
            this.checkBoxChangeFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialUnitOfMeasurementRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialUnitOfMeasurementName
            //
            this.labelFinancialUnitOfMeasurementName.AutoSize = true;
            this.labelFinancialUnitOfMeasurementName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialUnitOfMeasurementName.Name = "labelFinancialUnitOfMeasurementName";
            this.labelFinancialUnitOfMeasurementName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementName.TabIndex = 2;
            this.labelFinancialUnitOfMeasurementName.Text = "Financial Unit Of Measurement Name:";
            //
            //textBoxFinancialUnitOfMeasurementName
            //
            this.textBoxFinancialUnitOfMeasurementName.Location = new System.Drawing.Point(238, 13);
            this.textBoxFinancialUnitOfMeasurementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurementName.Name = "textBoxFinancialUnitOfMeasurementName";
            this.textBoxFinancialUnitOfMeasurementName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurementName.TabIndex = 3;
            //
            // labelFinancialUnitOfMeasurement
            //
            this.labelFinancialUnitOfMeasurement.AutoSize = true;
            this.labelFinancialUnitOfMeasurement.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialUnitOfMeasurement.Name = "labelFinancialUnitOfMeasurement";
            this.labelFinancialUnitOfMeasurement.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurement.TabIndex = 4;
            this.labelFinancialUnitOfMeasurement.Text = "Financial Unit Of Measurement:";
            //
            //textBoxFinancialUnitOfMeasurement
            //
            this.textBoxFinancialUnitOfMeasurement.Location = new System.Drawing.Point(238, 36);
            this.textBoxFinancialUnitOfMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurement.Name = "textBoxFinancialUnitOfMeasurement";
            this.textBoxFinancialUnitOfMeasurement.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurement.TabIndex = 5;
            //
            // labelStatusCode
            //
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(11, 59);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(71, 13);
            this.labelStatusCode.TabIndex = 6;
            this.labelStatusCode.Text = "Status Code:";
            //
            //textBoxStatusCode
            //
            this.textBoxStatusCode.Location = new System.Drawing.Point(238, 59);
            this.textBoxStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatusCode.Name = "textBoxStatusCode";
            this.textBoxStatusCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxStatusCode.TabIndex = 7;
            //
            // labelFinancialUnitOfMeasurementCode
            //
            this.labelFinancialUnitOfMeasurementCode.AutoSize = true;
            this.labelFinancialUnitOfMeasurementCode.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialUnitOfMeasurementCode.Name = "labelFinancialUnitOfMeasurementCode";
            this.labelFinancialUnitOfMeasurementCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialUnitOfMeasurementCode.TabIndex = 8;
            this.labelFinancialUnitOfMeasurementCode.Text = "Financial Unit Of Measurement Code:";
            //
            //textBoxFinancialUnitOfMeasurementCode
            //
            this.textBoxFinancialUnitOfMeasurementCode.Location = new System.Drawing.Point(238, 82);
            this.textBoxFinancialUnitOfMeasurementCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialUnitOfMeasurementCode.Name = "textBoxFinancialUnitOfMeasurementCode";
            this.textBoxFinancialUnitOfMeasurementCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialUnitOfMeasurementCode.TabIndex = 9;
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
            this.maskedTextBoxSortSequenceNumber.Location = new System.Drawing.Point(238, 105);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 128);
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
            this.checkBoxChangeFlag.Location = new System.Drawing.Point(238, 151);
            this.checkBoxChangeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChangeFlag.Name = "checkBoxChangeFlag";
            this.checkBoxChangeFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxChangeFlag.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialUnitOfMeasurementRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.Name = "dataGridViewCrudeFinancialUnitOfMeasurementRef";
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.Size = new System.Drawing.Size(476, 96);
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialUnitOfMeasurementRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialUnitOfMeasurementRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialUnitOfMeasurementRefSearch
            // 
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Location = new System.Drawing.Point(296, 287);
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Name = "buttonCrudeFinancialUnitOfMeasurementRefSearch";
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Text = "&Search";
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialUnitOfMeasurementRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialUnitOfMeasurementRefSearch_Click);
            // 
            // buttonCrudeFinancialUnitOfMeasurementRefAdd
            // 
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Location = new System.Drawing.Point(196, 287);
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Name = "buttonCrudeFinancialUnitOfMeasurementRefAdd";
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Text = "&Add";
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialUnitOfMeasurementRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialUnitOfMeasurementRefAdd_Click);
            // 
            // buttonCrudeFinancialUnitOfMeasurementRefEdit
            // 
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Location = new System.Drawing.Point(96, 287);
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Name = "buttonCrudeFinancialUnitOfMeasurementRefEdit";
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialUnitOfMeasurementRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialUnitOfMeasurementRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.buttonCrudeFinancialUnitOfMeasurementRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialUnitOfMeasurementRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialUnitOfMeasurementRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialUnitOfMeasurementRef);
            this.Name = "CrudeFinancialUnitOfMeasurementRefSearch";
            this.Text = "Financial Unit Of Measurement Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialUnitOfMeasurementRef)).EndInit();
            this.Controls.Add(this.labelFinancialUnitOfMeasurementName);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurementName);
            this.Controls.Add(this.labelFinancialUnitOfMeasurement);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurement);
            this.Controls.Add(this.labelStatusCode);
            this.Controls.Add(this.textBoxStatusCode);
            this.Controls.Add(this.labelFinancialUnitOfMeasurementCode);
            this.Controls.Add(this.textBoxFinancialUnitOfMeasurementCode);
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
