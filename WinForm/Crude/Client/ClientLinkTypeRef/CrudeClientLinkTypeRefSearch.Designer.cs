namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientLinkTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientLinkTypeRef;
        
        private System.Windows.Forms.TextBox textBoxClientLinkTypeName;
        
        private System.Windows.Forms.Label labelClientLinkTypeName;
        
        private System.Windows.Forms.TextBox textBoxClientLinkType;
        
        private System.Windows.Forms.Label labelClientLinkType;
        
        private System.Windows.Forms.TextBox textBoxClientLinkTypeDescription;
        
        private System.Windows.Forms.Label labelClientLinkTypeDescription;
        
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
            this.buttonCrudeClientLinkTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientLinkTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientLinkTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientLinkTypeRef = new System.Windows.Forms.DataGridView();
            this.labelClientLinkTypeName = new System.Windows.Forms.Label();
            this.textBoxClientLinkTypeName = new System.Windows.Forms.TextBox();
            this.labelClientLinkType = new System.Windows.Forms.Label();
            this.textBoxClientLinkType = new System.Windows.Forms.TextBox();
            this.labelClientLinkTypeDescription = new System.Windows.Forms.Label();
            this.textBoxClientLinkTypeDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientLinkTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientLinkTypeName
            //
            this.labelClientLinkTypeName.AutoSize = true;
            this.labelClientLinkTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelClientLinkTypeName.Name = "labelClientLinkTypeName";
            this.labelClientLinkTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelClientLinkTypeName.TabIndex = 2;
            this.labelClientLinkTypeName.Text = "Client Link Type Name:";
            //
            //textBoxClientLinkTypeName
            //
            this.textBoxClientLinkTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxClientLinkTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientLinkTypeName.Name = "textBoxClientLinkTypeName";
            this.textBoxClientLinkTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientLinkTypeName.TabIndex = 3;
            //
            // labelClientLinkType
            //
            this.labelClientLinkType.AutoSize = true;
            this.labelClientLinkType.Location = new System.Drawing.Point(11, 36);
            this.labelClientLinkType.Name = "labelClientLinkType";
            this.labelClientLinkType.Size = new System.Drawing.Size(71, 13);
            this.labelClientLinkType.TabIndex = 4;
            this.labelClientLinkType.Text = "Client Link Type:";
            //
            //textBoxClientLinkType
            //
            this.textBoxClientLinkType.Location = new System.Drawing.Point(196, 36);
            this.textBoxClientLinkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientLinkType.Name = "textBoxClientLinkType";
            this.textBoxClientLinkType.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientLinkType.TabIndex = 5;
            //
            // labelClientLinkTypeDescription
            //
            this.labelClientLinkTypeDescription.AutoSize = true;
            this.labelClientLinkTypeDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientLinkTypeDescription.Name = "labelClientLinkTypeDescription";
            this.labelClientLinkTypeDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientLinkTypeDescription.TabIndex = 6;
            this.labelClientLinkTypeDescription.Text = "Client Link Type Description:";
            //
            //textBoxClientLinkTypeDescription
            //
            this.textBoxClientLinkTypeDescription.Location = new System.Drawing.Point(196, 59);
            this.textBoxClientLinkTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientLinkTypeDescription.Name = "textBoxClientLinkTypeDescription";
            this.textBoxClientLinkTypeDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientLinkTypeDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(196, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(196, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientLinkTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientLinkTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientLinkTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientLinkTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientLinkTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientLinkTypeRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientLinkTypeRef.Name = "dataGridViewCrudeClientLinkTypeRef";
            this.dataGridViewCrudeClientLinkTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeClientLinkTypeRef.TabIndex = 0;
            this.dataGridViewCrudeClientLinkTypeRef.ReadOnly = true;
            this.dataGridViewCrudeClientLinkTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientLinkTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientLinkTypeRefSearch
            // 
            this.buttonCrudeClientLinkTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkTypeRefSearch.Location = new System.Drawing.Point(254, 264);
            this.buttonCrudeClientLinkTypeRefSearch.Name = "buttonCrudeClientLinkTypeRefSearch";
            this.buttonCrudeClientLinkTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkTypeRefSearch.TabIndex = 2;
            this.buttonCrudeClientLinkTypeRefSearch.Text = "&Search";
            this.buttonCrudeClientLinkTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeClientLinkTypeRefSearch_Click);
            // 
            // buttonCrudeClientLinkTypeRefAdd
            // 
            this.buttonCrudeClientLinkTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkTypeRefAdd.Location = new System.Drawing.Point(154, 264);
            this.buttonCrudeClientLinkTypeRefAdd.Name = "buttonCrudeClientLinkTypeRefAdd";
            this.buttonCrudeClientLinkTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkTypeRefAdd.TabIndex = 3;
            this.buttonCrudeClientLinkTypeRefAdd.Text = "&Add";
            this.buttonCrudeClientLinkTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeClientLinkTypeRefAdd_Click);
            // 
            // buttonCrudeClientLinkTypeRefEdit
            // 
            this.buttonCrudeClientLinkTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkTypeRefEdit.Location = new System.Drawing.Point(54, 264);
            this.buttonCrudeClientLinkTypeRefEdit.Name = "buttonCrudeClientLinkTypeRefEdit";
            this.buttonCrudeClientLinkTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkTypeRefEdit.TabIndex = 4;
            this.buttonCrudeClientLinkTypeRefEdit.Text = "&Edit";
            this.buttonCrudeClientLinkTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeClientLinkTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 292);
            this.Controls.Add(this.buttonCrudeClientLinkTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientLinkTypeRefAdd);
            this.Controls.Add(this.buttonCrudeClientLinkTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientLinkTypeRef);
            this.Name = "CrudeClientLinkTypeRefSearch";
            this.Text = "Client Link Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientLinkTypeRef)).EndInit();
            this.Controls.Add(this.labelClientLinkTypeName);
            this.Controls.Add(this.textBoxClientLinkTypeName);
            this.Controls.Add(this.labelClientLinkType);
            this.Controls.Add(this.textBoxClientLinkType);
            this.Controls.Add(this.labelClientLinkTypeDescription);
            this.Controls.Add(this.textBoxClientLinkTypeDescription);
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
