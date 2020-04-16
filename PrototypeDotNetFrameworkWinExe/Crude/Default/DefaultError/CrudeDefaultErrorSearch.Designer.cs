namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultError;
        
        private System.Windows.Forms.TextBox textBoxMethodName;
        
        private System.Windows.Forms.Label labelMethodName;
        
        private System.Windows.Forms.TextBox textBoxDomainName;
        
        private System.Windows.Forms.Label labelDomainName;
        
        private System.Windows.Forms.TextBox textBoxClassName;
        
        private System.Windows.Forms.Label labelClassName;
        
        private DefaultErrorLayerRefCombo defaultErrorLayerRefCombo;
        
        private System.Windows.Forms.Label labelDefaultErrorLayerRefCombo;
        
        private DefaultErrorTypeRefCombo defaultErrorTypeRefCombo;
        
        private System.Windows.Forms.Label labelDefaultErrorTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLayerAddress;
        
        private System.Windows.Forms.Label labelLayerAddress;
        
        private System.Windows.Forms.TextBox textBoxErrorMessage;
        
        private System.Windows.Forms.Label labelErrorMessage;
        
        private System.Windows.Forms.TextBox textBoxStackTrace;
        
        private System.Windows.Forms.Label labelStackTrace;
        
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
            this.buttonCrudeDefaultErrorAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultError = new System.Windows.Forms.DataGridView();
            this.labelMethodName = new System.Windows.Forms.Label();
            this.textBoxMethodName = new System.Windows.Forms.TextBox();
            this.labelDomainName = new System.Windows.Forms.Label();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.labelDefaultErrorLayerRefCombo = new System.Windows.Forms.Label();
            this.defaultErrorLayerRefCombo = new DefaultErrorLayerRefCombo();
            this.labelDefaultErrorTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultErrorTypeRefCombo = new DefaultErrorTypeRefCombo();
            this.labelLayerAddress = new System.Windows.Forms.Label();
            this.textBoxLayerAddress = new System.Windows.Forms.TextBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.textBoxErrorMessage = new System.Windows.Forms.TextBox();
            this.labelStackTrace = new System.Windows.Forms.Label();
            this.textBoxStackTrace = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultError)).BeginInit();
            this.SuspendLayout();
            //
            // labelMethodName
            //
            this.labelMethodName.AutoSize = true;
            this.labelMethodName.Location = new System.Drawing.Point(11, 13);
            this.labelMethodName.Name = "labelMethodName";
            this.labelMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelMethodName.TabIndex = 2;
            this.labelMethodName.Text = "Method Name:";
            //
            //textBoxMethodName
            //
            this.textBoxMethodName.Location = new System.Drawing.Point(140, 13);
            this.textBoxMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodName.Name = "textBoxMethodName";
            this.textBoxMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxMethodName.TabIndex = 3;
            //
            // labelDomainName
            //
            this.labelDomainName.AutoSize = true;
            this.labelDomainName.Location = new System.Drawing.Point(11, 36);
            this.labelDomainName.Name = "labelDomainName";
            this.labelDomainName.Size = new System.Drawing.Size(71, 13);
            this.labelDomainName.TabIndex = 4;
            this.labelDomainName.Text = "Domain Name:";
            //
            //textBoxDomainName
            //
            this.textBoxDomainName.Location = new System.Drawing.Point(140, 36);
            this.textBoxDomainName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDomainName.TabIndex = 5;
            //
            // labelClassName
            //
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(11, 59);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(71, 13);
            this.labelClassName.TabIndex = 6;
            this.labelClassName.Text = "Class Name:";
            //
            //textBoxClassName
            //
            this.textBoxClassName.Location = new System.Drawing.Point(140, 59);
            this.textBoxClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClassName.TabIndex = 7;
            //
            // labelDefaultErrorLayerRefCombo
            //
            this.labelDefaultErrorLayerRefCombo.AutoSize = true;
            this.labelDefaultErrorLayerRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelDefaultErrorLayerRefCombo.Name = "labelDefaultErrorLayerRefCombo";
            this.labelDefaultErrorLayerRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayerRefCombo.TabIndex = 8;
            this.labelDefaultErrorLayerRefCombo.Text = "Default Error Layer:";
            //
            //defaultErrorLayerRefCombo
            //
            this.defaultErrorLayerRefCombo.Location = new System.Drawing.Point(140, 82);
            this.defaultErrorLayerRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultErrorLayerRefCombo.Name = "defaultErrorLayerRefCombo";
            this.defaultErrorLayerRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultErrorLayerRefCombo.TabIndex = 9;
            //
            // labelDefaultErrorTypeRefCombo
            //
            this.labelDefaultErrorTypeRefCombo.AutoSize = true;
            this.labelDefaultErrorTypeRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelDefaultErrorTypeRefCombo.Name = "labelDefaultErrorTypeRefCombo";
            this.labelDefaultErrorTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorTypeRefCombo.TabIndex = 10;
            this.labelDefaultErrorTypeRefCombo.Text = "Default Error Type:";
            //
            //defaultErrorTypeRefCombo
            //
            this.defaultErrorTypeRefCombo.Location = new System.Drawing.Point(140, 105);
            this.defaultErrorTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultErrorTypeRefCombo.Name = "defaultErrorTypeRefCombo";
            this.defaultErrorTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultErrorTypeRefCombo.TabIndex = 11;
            //
            // labelLayerAddress
            //
            this.labelLayerAddress.AutoSize = true;
            this.labelLayerAddress.Location = new System.Drawing.Point(11, 128);
            this.labelLayerAddress.Name = "labelLayerAddress";
            this.labelLayerAddress.Size = new System.Drawing.Size(71, 13);
            this.labelLayerAddress.TabIndex = 12;
            this.labelLayerAddress.Text = "Layer Address:";
            //
            //textBoxLayerAddress
            //
            this.textBoxLayerAddress.Location = new System.Drawing.Point(140, 128);
            this.textBoxLayerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLayerAddress.Name = "textBoxLayerAddress";
            this.textBoxLayerAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxLayerAddress.TabIndex = 13;
            //
            // labelErrorMessage
            //
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(11, 151);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(71, 13);
            this.labelErrorMessage.TabIndex = 14;
            this.labelErrorMessage.Text = "Error Message:";
            //
            //textBoxErrorMessage
            //
            this.textBoxErrorMessage.Location = new System.Drawing.Point(140, 151);
            this.textBoxErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrorMessage.Name = "textBoxErrorMessage";
            this.textBoxErrorMessage.Size = new System.Drawing.Size(250, 20);
            this.textBoxErrorMessage.TabIndex = 15;
            //
            // labelStackTrace
            //
            this.labelStackTrace.AutoSize = true;
            this.labelStackTrace.Location = new System.Drawing.Point(11, 174);
            this.labelStackTrace.Name = "labelStackTrace";
            this.labelStackTrace.Size = new System.Drawing.Size(71, 13);
            this.labelStackTrace.TabIndex = 16;
            this.labelStackTrace.Text = "Stack Trace:";
            //
            //textBoxStackTrace
            //
            this.textBoxStackTrace.Location = new System.Drawing.Point(140, 174);
            this.textBoxStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStackTrace.Name = "textBoxStackTrace";
            this.textBoxStackTrace.Size = new System.Drawing.Size(250, 20);
            this.textBoxStackTrace.TabIndex = 17;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 18;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 197);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 19;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultError
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultError.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultError.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCrudeDefaultError.Name = "dataGridViewCrudeDefaultError";
            this.dataGridViewCrudeDefaultError.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultError.TabIndex = 0;
            this.dataGridViewCrudeDefaultError.ReadOnly = true;
            this.dataGridViewCrudeDefaultError.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultError_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 333);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultErrorSearch
            // 
            this.buttonCrudeDefaultErrorSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorSearch.Location = new System.Drawing.Point(198, 333);
            this.buttonCrudeDefaultErrorSearch.Name = "buttonCrudeDefaultErrorSearch";
            this.buttonCrudeDefaultErrorSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorSearch.TabIndex = 2;
            this.buttonCrudeDefaultErrorSearch.Text = "&Search";
            this.buttonCrudeDefaultErrorSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorSearch.Click += new System.EventHandler(this.buttonCrudeDefaultErrorSearch_Click);
            // 
            // buttonCrudeDefaultErrorAdd
            // 
            this.buttonCrudeDefaultErrorAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorAdd.Location = new System.Drawing.Point(98, 333);
            this.buttonCrudeDefaultErrorAdd.Name = "buttonCrudeDefaultErrorAdd";
            this.buttonCrudeDefaultErrorAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorAdd.TabIndex = 3;
            this.buttonCrudeDefaultErrorAdd.Text = "&Add";
            this.buttonCrudeDefaultErrorAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorAdd.Click += new System.EventHandler(this.buttonCrudeDefaultErrorAdd_Click);
            // 
            // buttonCrudeDefaultErrorEdit
            // 
            this.buttonCrudeDefaultErrorEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorEdit.Location = new System.Drawing.Point(-2, 333);
            this.buttonCrudeDefaultErrorEdit.Name = "buttonCrudeDefaultErrorEdit";
            this.buttonCrudeDefaultErrorEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorEdit.TabIndex = 4;
            this.buttonCrudeDefaultErrorEdit.Text = "&Edit";
            this.buttonCrudeDefaultErrorEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorEdit.Click += new System.EventHandler(this.buttonCrudeDefaultErrorEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.Controls.Add(this.buttonCrudeDefaultErrorSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultErrorAdd);
            this.Controls.Add(this.buttonCrudeDefaultErrorEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultError);
            this.Name = "CrudeDefaultErrorSearch";
            this.Text = "Default Error Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultError)).EndInit();
            this.Controls.Add(this.labelMethodName);
            this.Controls.Add(this.textBoxMethodName);
            this.Controls.Add(this.labelDomainName);
            this.Controls.Add(this.textBoxDomainName);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.labelDefaultErrorLayerRefCombo);
            this.Controls.Add(this.defaultErrorLayerRefCombo);
            this.Controls.Add(this.labelDefaultErrorTypeRefCombo);
            this.Controls.Add(this.defaultErrorTypeRefCombo);
            this.Controls.Add(this.labelLayerAddress);
            this.Controls.Add(this.textBoxLayerAddress);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.textBoxErrorMessage);
            this.Controls.Add(this.labelStackTrace);
            this.Controls.Add(this.textBoxStackTrace);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
