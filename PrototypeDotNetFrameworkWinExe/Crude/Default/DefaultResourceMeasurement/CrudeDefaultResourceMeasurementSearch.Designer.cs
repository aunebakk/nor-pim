namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultResourceMeasurementSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultResourceMeasurementSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultResourceMeasurementAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultResourceMeasurementEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultResourceMeasurement;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientWorkingsetBytes;
        
        private System.Windows.Forms.Label labelClientWorkingsetBytes;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBusinessWorkingsetBytes;
        
        private System.Windows.Forms.Label labelBusinessWorkingsetBytes;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDatabaseSizeBytes;
        
        private System.Windows.Forms.Label labelDatabaseSizeBytes;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.buttonCrudeDefaultResourceMeasurementAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultResourceMeasurementEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultResourceMeasurementSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultResourceMeasurement = new System.Windows.Forms.DataGridView();
            this.labelClientWorkingsetBytes = new System.Windows.Forms.Label();
            this.maskedTextBoxClientWorkingsetBytes = new System.Windows.Forms.MaskedTextBox();
            this.labelBusinessWorkingsetBytes = new System.Windows.Forms.Label();
            this.maskedTextBoxBusinessWorkingsetBytes = new System.Windows.Forms.MaskedTextBox();
            this.labelDatabaseSizeBytes = new System.Windows.Forms.Label();
            this.maskedTextBoxDatabaseSizeBytes = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultResourceMeasurement)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientWorkingsetBytes
            //
            this.labelClientWorkingsetBytes.AutoSize = true;
            this.labelClientWorkingsetBytes.Location = new System.Drawing.Point(11, 13);
            this.labelClientWorkingsetBytes.Name = "labelClientWorkingsetBytes";
            this.labelClientWorkingsetBytes.Size = new System.Drawing.Size(71, 13);
            this.labelClientWorkingsetBytes.TabIndex = 2;
            this.labelClientWorkingsetBytes.Text = "Client Workingset Bytes:";
            //
            //maskedTextBoxClientWorkingsetBytes
            //
            this.maskedTextBoxClientWorkingsetBytes.Location = new System.Drawing.Point(175, 13);
            this.maskedTextBoxClientWorkingsetBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxClientWorkingsetBytes.Name = "maskedTextBoxClientWorkingsetBytes";
            this.maskedTextBoxClientWorkingsetBytes.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxClientWorkingsetBytes.TabIndex = 3;
            //
            // labelBusinessWorkingsetBytes
            //
            this.labelBusinessWorkingsetBytes.AutoSize = true;
            this.labelBusinessWorkingsetBytes.Location = new System.Drawing.Point(11, 36);
            this.labelBusinessWorkingsetBytes.Name = "labelBusinessWorkingsetBytes";
            this.labelBusinessWorkingsetBytes.Size = new System.Drawing.Size(71, 13);
            this.labelBusinessWorkingsetBytes.TabIndex = 4;
            this.labelBusinessWorkingsetBytes.Text = "Business Workingset Bytes:";
            //
            //maskedTextBoxBusinessWorkingsetBytes
            //
            this.maskedTextBoxBusinessWorkingsetBytes.Location = new System.Drawing.Point(175, 36);
            this.maskedTextBoxBusinessWorkingsetBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxBusinessWorkingsetBytes.Name = "maskedTextBoxBusinessWorkingsetBytes";
            this.maskedTextBoxBusinessWorkingsetBytes.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxBusinessWorkingsetBytes.TabIndex = 5;
            //
            // labelDatabaseSizeBytes
            //
            this.labelDatabaseSizeBytes.AutoSize = true;
            this.labelDatabaseSizeBytes.Location = new System.Drawing.Point(11, 59);
            this.labelDatabaseSizeBytes.Name = "labelDatabaseSizeBytes";
            this.labelDatabaseSizeBytes.Size = new System.Drawing.Size(71, 13);
            this.labelDatabaseSizeBytes.TabIndex = 6;
            this.labelDatabaseSizeBytes.Text = "Database Size Bytes:";
            //
            //maskedTextBoxDatabaseSizeBytes
            //
            this.maskedTextBoxDatabaseSizeBytes.Location = new System.Drawing.Point(175, 59);
            this.maskedTextBoxDatabaseSizeBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDatabaseSizeBytes.Name = "maskedTextBoxDatabaseSizeBytes";
            this.maskedTextBoxDatabaseSizeBytes.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDatabaseSizeBytes.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultResourceMeasurement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultResourceMeasurement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultResourceMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultResourceMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultResourceMeasurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultResourceMeasurement.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeDefaultResourceMeasurement.Name = "dataGridViewCrudeDefaultResourceMeasurement";
            this.dataGridViewCrudeDefaultResourceMeasurement.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeDefaultResourceMeasurement.TabIndex = 0;
            this.dataGridViewCrudeDefaultResourceMeasurement.ReadOnly = true;
            this.dataGridViewCrudeDefaultResourceMeasurement.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultResourceMeasurement_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultResourceMeasurementSearch
            // 
            this.buttonCrudeDefaultResourceMeasurementSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultResourceMeasurementSearch.Location = new System.Drawing.Point(233, 218);
            this.buttonCrudeDefaultResourceMeasurementSearch.Name = "buttonCrudeDefaultResourceMeasurementSearch";
            this.buttonCrudeDefaultResourceMeasurementSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultResourceMeasurementSearch.TabIndex = 2;
            this.buttonCrudeDefaultResourceMeasurementSearch.Text = "&Search";
            this.buttonCrudeDefaultResourceMeasurementSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultResourceMeasurementSearch.Click += new System.EventHandler(this.buttonCrudeDefaultResourceMeasurementSearch_Click);
            // 
            // buttonCrudeDefaultResourceMeasurementAdd
            // 
            this.buttonCrudeDefaultResourceMeasurementAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultResourceMeasurementAdd.Location = new System.Drawing.Point(133, 218);
            this.buttonCrudeDefaultResourceMeasurementAdd.Name = "buttonCrudeDefaultResourceMeasurementAdd";
            this.buttonCrudeDefaultResourceMeasurementAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultResourceMeasurementAdd.TabIndex = 3;
            this.buttonCrudeDefaultResourceMeasurementAdd.Text = "&Add";
            this.buttonCrudeDefaultResourceMeasurementAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultResourceMeasurementAdd.Click += new System.EventHandler(this.buttonCrudeDefaultResourceMeasurementAdd_Click);
            // 
            // buttonCrudeDefaultResourceMeasurementEdit
            // 
            this.buttonCrudeDefaultResourceMeasurementEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultResourceMeasurementEdit.Location = new System.Drawing.Point(33, 218);
            this.buttonCrudeDefaultResourceMeasurementEdit.Name = "buttonCrudeDefaultResourceMeasurementEdit";
            this.buttonCrudeDefaultResourceMeasurementEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultResourceMeasurementEdit.TabIndex = 4;
            this.buttonCrudeDefaultResourceMeasurementEdit.Text = "&Edit";
            this.buttonCrudeDefaultResourceMeasurementEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultResourceMeasurementEdit.Click += new System.EventHandler(this.buttonCrudeDefaultResourceMeasurementEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 246);
            this.Controls.Add(this.buttonCrudeDefaultResourceMeasurementSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultResourceMeasurementAdd);
            this.Controls.Add(this.buttonCrudeDefaultResourceMeasurementEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultResourceMeasurement);
            this.Name = "CrudeDefaultResourceMeasurementSearch";
            this.Text = "Default Resource Measurement Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultResourceMeasurement)).EndInit();
            this.Controls.Add(this.labelClientWorkingsetBytes);
            this.Controls.Add(this.maskedTextBoxClientWorkingsetBytes);
            this.Controls.Add(this.labelBusinessWorkingsetBytes);
            this.Controls.Add(this.maskedTextBoxBusinessWorkingsetBytes);
            this.Controls.Add(this.labelDatabaseSizeBytes);
            this.Controls.Add(this.maskedTextBoxDatabaseSizeBytes);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
