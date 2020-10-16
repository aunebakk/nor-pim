namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientDocumentTypeRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeClientDocumentTypeRefSearch;

        private System.Windows.Forms.Button buttonCrudeClientDocumentTypeRefAdd;

        private System.Windows.Forms.Button buttonCrudeClientDocumentTypeRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeClientDocumentTypeRef;

        private System.Windows.Forms.TextBox textBoxClientDocumentTypeName;

        private System.Windows.Forms.Label labelClientDocumentTypeName;

        private System.Windows.Forms.TextBox textBoxClientDocumentType;

        private System.Windows.Forms.Label labelClientDocumentType;

        private System.Windows.Forms.TextBox textBoxClientDocumentTypeDescription;

        private System.Windows.Forms.Label labelClientDocumentTypeDescription;

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
            this.buttonCrudeClientDocumentTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientDocumentTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientDocumentTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientDocumentTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxClientDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelClientDocumentType = new System.Windows.Forms.Label();
            this.textBoxClientDocumentType = new System.Windows.Forms.TextBox();
            this.labelClientDocumentTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientDocumentTypeDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientDocumentTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientDocumentTypeName
            //
            this.labelClientDocumentTypeName.AutoSize = true;
            this.labelClientDocumentTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientDocumentTypeName.Name = "labelClientDocumentTypeName";
            this.labelClientDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentTypeName.TabIndex = 2;
            this.labelClientDocumentTypeName.Text = "Client Document Type Name:";
            //
            //textBoxClientDocumentTypeName
            //
            this.textBoxClientDocumentTypeName.Location = new System.Drawing.Point(224, 13);
            this.textBoxClientDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentTypeName.Name = "textBoxClientDocumentTypeName";
            this.textBoxClientDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentTypeName.TabIndex = 3;
            //
            // labelClientDocumentType
            //
            this.labelClientDocumentType.AutoSize = true;
            this.labelClientDocumentType.Location = new System.Drawing.Point(11, 36);
            this.labelClientDocumentType.Name = "labelClientDocumentType";
            this.labelClientDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentType.TabIndex = 4;
            this.labelClientDocumentType.Text = "Client Document Type:";
            //
            //textBoxClientDocumentType
            //
            this.textBoxClientDocumentType.Location = new System.Drawing.Point(224, 36);
            this.textBoxClientDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentType.Name = "textBoxClientDocumentType";
            this.textBoxClientDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentType.TabIndex = 5;
            //
            // labelClientDocumentTypeDescription
            //
            this.labelClientDocumentTypeDescription.AutoSize = true;
            this.labelClientDocumentTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientDocumentTypeDescription.Name = "labelClientDocumentTypeDescription";
            this.labelClientDocumentTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentTypeDescription.TabIndex = 6;
            this.labelClientDocumentTypeDescription.Text = "Client Document Type Description:";
            //
            //textBoxClientDocumentTypeDescription
            //
            this.textBoxClientDocumentTypeDescription.Location = new System.Drawing.Point(224, 59);
            this.textBoxClientDocumentTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientDocumentTypeDescription.Name = "textBoxClientDocumentTypeDescription";
            this.textBoxClientDocumentTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientDocumentTypeDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(224, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(224, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientDocumentTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientDocumentTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientDocumentTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientDocumentTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientDocumentTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientDocumentTypeRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientDocumentTypeRef.Name = "dataGridViewCrudeClientDocumentTypeRef";
            this.dataGridViewCrudeClientDocumentTypeRef.Size = new System.Drawing.Size(462, 96);
            this.dataGridViewCrudeClientDocumentTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientDocumentTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientDocumentTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientDocumentTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 264);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientDocumentTypeRefSearch
            // 
            this.buttonCrudeClientDocumentTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentTypeRefSearch.Location = new System.Drawing.Point(282, 264);
            this.buttonCrudeClientDocumentTypeRefSearch.Name = "buttonCrudeClientDocumentTypeRefSearch";
            this.buttonCrudeClientDocumentTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientDocumentTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientDocumentTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientDocumentTypeRefSearch_Click);
            // 
            // buttonCrudeClientDocumentTypeRefAdd
            // 
            this.buttonCrudeClientDocumentTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentTypeRefAdd.Location = new System.Drawing.Point(182, 264);
            this.buttonCrudeClientDocumentTypeRefAdd.Name = "buttonCrudeClientDocumentTypeRefAdd";
            this.buttonCrudeClientDocumentTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientDocumentTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientDocumentTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientDocumentTypeRefAdd_Click);
            // 
            // buttonCrudeClientDocumentTypeRefEdit
            // 
            this.buttonCrudeClientDocumentTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentTypeRefEdit.Location = new System.Drawing.Point(82, 264);
            this.buttonCrudeClientDocumentTypeRefEdit.Name = "buttonCrudeClientDocumentTypeRefEdit";
            this.buttonCrudeClientDocumentTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientDocumentTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientDocumentTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientDocumentTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 292);
            this.Controls.Add(this.buttonCrudeClientDocumentTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientDocumentTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientDocumentTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientDocumentTypeRef);
            this.Name = "CrudeClientDocumentTypeRefSearch";
            this.Text = "Client Document Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientDocumentTypeRef)).EndInit();
            this.Controls.Add(this.labelClientDocumentTypeName);
            this.Controls.Add(this.textBoxClientDocumentTypeName);
            this.Controls.Add(this.labelClientDocumentType);
            this.Controls.Add(this.textBoxClientDocumentType);
            this.Controls.Add(this.labelClientDocumentTypeDescription);
            this.Controls.Add(this.textBoxClientDocumentTypeDescription);
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
