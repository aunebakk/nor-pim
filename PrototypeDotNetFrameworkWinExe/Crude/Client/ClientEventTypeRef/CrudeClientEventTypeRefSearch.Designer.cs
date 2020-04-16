namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientEventTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientEventTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientEventTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientEventTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientEventTypeRef;
        
        private System.Windows.Forms.TextBox textBoxClientEventTypeName;
        
        private System.Windows.Forms.Label labelClientEventTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientEventType;
        
        private System.Windows.Forms.Label labelClientEventType;
        
        private System.Windows.Forms.TextBox textBoxClientEventTypeDescription;
        
        private System.Windows.Forms.Label labelClientEventTypeDescription;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientEventTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientEventTypeName = new System.Windows.Forms.Label();
            this.textBoxClientEventTypeName = new System.Windows.Forms.TextBox();
            this.labelClientEventType = new System.Windows.Forms.Label();
            this.textBoxClientEventType = new System.Windows.Forms.TextBox();
            this.labelClientEventTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientEventTypeDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEventTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientEventTypeName
            //
            this.labelClientEventTypeName.AutoSize = true;
            this.labelClientEventTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientEventTypeName.Name = "labelClientEventTypeName";
            this.labelClientEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventTypeName.TabIndex = 2;
            this.labelClientEventTypeName.Text = "Client Event Type Name:";
            //
            //textBoxClientEventTypeName
            //
            this.textBoxClientEventTypeName.Location = new System.Drawing.Point(203, 13);
            this.textBoxClientEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientEventTypeName.Name = "textBoxClientEventTypeName";
            this.textBoxClientEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientEventTypeName.TabIndex = 3;
            //
            // labelClientEventType
            //
            this.labelClientEventType.AutoSize = true;
            this.labelClientEventType.Location = new System.Drawing.Point(11, 36);
            this.labelClientEventType.Name = "labelClientEventType";
            this.labelClientEventType.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventType.TabIndex = 4;
            this.labelClientEventType.Text = "Client Event Type:";
            //
            //textBoxClientEventType
            //
            this.textBoxClientEventType.Location = new System.Drawing.Point(203, 36);
            this.textBoxClientEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientEventType.Name = "textBoxClientEventType";
            this.textBoxClientEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientEventType.TabIndex = 5;
            //
            // labelClientEventTypeDescription
            //
            this.labelClientEventTypeDescription.AutoSize = true;
            this.labelClientEventTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientEventTypeDescription.Name = "labelClientEventTypeDescription";
            this.labelClientEventTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventTypeDescription.TabIndex = 6;
            this.labelClientEventTypeDescription.Text = "Client Event Type Description:";
            //
            //textBoxClientEventTypeDescription
            //
            this.textBoxClientEventTypeDescription.Location = new System.Drawing.Point(203, 59);
            this.textBoxClientEventTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientEventTypeDescription.Name = "textBoxClientEventTypeDescription";
            this.textBoxClientEventTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientEventTypeDescription.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(203, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(203, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 128);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 12;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(203, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientEventTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientEventTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientEventTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientEventTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientEventTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientEventTypeRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientEventTypeRef.Name = "dataGridViewCrudeClientEventTypeRef";
            this.dataGridViewCrudeClientEventTypeRef.Size = new System.Drawing.Size(441, 96);
            this.dataGridViewCrudeClientEventTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientEventTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientEventTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientEventTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(361, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientEventTypeRefSearch
            // 
            this.buttonCrudeClientEventTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventTypeRefSearch.Location = new System.Drawing.Point(261, 264);
            this.buttonCrudeClientEventTypeRefSearch.Name = "buttonCrudeClientEventTypeRefSearch";
            this.buttonCrudeClientEventTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientEventTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientEventTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientEventTypeRefSearch_Click);
            // 
            // buttonCrudeClientEventTypeRefAdd
            // 
            this.buttonCrudeClientEventTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventTypeRefAdd.Location = new System.Drawing.Point(161, 264);
            this.buttonCrudeClientEventTypeRefAdd.Name = "buttonCrudeClientEventTypeRefAdd";
            this.buttonCrudeClientEventTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientEventTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientEventTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientEventTypeRefAdd_Click);
            // 
            // buttonCrudeClientEventTypeRefEdit
            // 
            this.buttonCrudeClientEventTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventTypeRefEdit.Location = new System.Drawing.Point(61, 264);
            this.buttonCrudeClientEventTypeRefEdit.Name = "buttonCrudeClientEventTypeRefEdit";
            this.buttonCrudeClientEventTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientEventTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientEventTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientEventTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 292);
            this.Controls.Add(this.buttonCrudeClientEventTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientEventTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientEventTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientEventTypeRef);
            this.Name = "CrudeClientEventTypeRefSearch";
            this.Text = "Client Event Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEventTypeRef)).EndInit();
            this.Controls.Add(this.labelClientEventTypeName);
            this.Controls.Add(this.textBoxClientEventTypeName);
            this.Controls.Add(this.labelClientEventType);
            this.Controls.Add(this.textBoxClientEventType);
            this.Controls.Add(this.labelClientEventTypeDescription);
            this.Controls.Add(this.textBoxClientEventTypeDescription);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
