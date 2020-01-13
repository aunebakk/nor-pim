namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientGenderRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientGenderRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientGenderRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientGenderRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientGenderRef;
        
        private System.Windows.Forms.TextBox textBoxClientGenderName;
        
        private System.Windows.Forms.Label labelClientGenderName;
        
        private System.Windows.Forms.TextBox textBoxClientGender;
        
        private System.Windows.Forms.Label labelClientGender;
        
        private System.Windows.Forms.TextBox textBoxClientGenderDescription;
        
        private System.Windows.Forms.Label labelClientGenderDescription;
        
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
            this.buttonCrudeClientGenderRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientGenderRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientGenderRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientGenderRef = new System.Windows.Forms.DataGridView();
            this.labelClientGenderName = new System.Windows.Forms.Label();
            this.textBoxClientGenderName = new System.Windows.Forms.TextBox();
            this.labelClientGender = new System.Windows.Forms.Label();
            this.textBoxClientGender = new System.Windows.Forms.TextBox();
            this.labelClientGenderDescription = new System.Windows.Forms.Label();
            this.textBoxClientGenderDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientGenderRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientGenderName
            //
            this.labelClientGenderName.AutoSize = true;
            this.labelClientGenderName.Location = new System.Drawing.Point(11, 13);
            this.labelClientGenderName.Name = "labelClientGenderName";
            this.labelClientGenderName.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderName.TabIndex = 2;
            this.labelClientGenderName.Text = "Client Gender Name:";
            //
            //textBoxClientGenderName
            //
            this.textBoxClientGenderName.Location = new System.Drawing.Point(175, 13);
            this.textBoxClientGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGenderName.Name = "textBoxClientGenderName";
            this.textBoxClientGenderName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGenderName.TabIndex = 3;
            //
            // labelClientGender
            //
            this.labelClientGender.AutoSize = true;
            this.labelClientGender.Location = new System.Drawing.Point(11, 36);
            this.labelClientGender.Name = "labelClientGender";
            this.labelClientGender.Size = new System.Drawing.Size(71, 13);
            this.labelClientGender.TabIndex = 4;
            this.labelClientGender.Text = "Client Gender:";
            //
            //textBoxClientGender
            //
            this.textBoxClientGender.Location = new System.Drawing.Point(175, 36);
            this.textBoxClientGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGender.Name = "textBoxClientGender";
            this.textBoxClientGender.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGender.TabIndex = 5;
            //
            // labelClientGenderDescription
            //
            this.labelClientGenderDescription.AutoSize = true;
            this.labelClientGenderDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientGenderDescription.Name = "labelClientGenderDescription";
            this.labelClientGenderDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientGenderDescription.TabIndex = 6;
            this.labelClientGenderDescription.Text = "Client Gender Description:";
            //
            //textBoxClientGenderDescription
            //
            this.textBoxClientGenderDescription.Location = new System.Drawing.Point(175, 59);
            this.textBoxClientGenderDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientGenderDescription.Name = "textBoxClientGenderDescription";
            this.textBoxClientGenderDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientGenderDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(175, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(175, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientGenderRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientGenderRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientGenderRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientGenderRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientGenderRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientGenderRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientGenderRef.Name = "dataGridViewCrudeClientGenderRef";
            this.dataGridViewCrudeClientGenderRef.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeClientGenderRef.TabIndex = 0;
            this.dataGridViewCrudeClientGenderRef.ReadOnly = true;
            this.dataGridViewCrudeClientGenderRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientGenderRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientGenderRefSearch
            // 
            this.buttonCrudeClientGenderRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientGenderRefSearch.Location = new System.Drawing.Point(233, 264);
            this.buttonCrudeClientGenderRefSearch.Name = "buttonCrudeClientGenderRefSearch";
            this.buttonCrudeClientGenderRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientGenderRefSearch.TabIndex = 2;
            this.buttonCrudeClientGenderRefSearch.Text = "&Search";
            this.buttonCrudeClientGenderRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientGenderRefSearch.Click += new System.EventHandler(this.buttonCrudeClientGenderRefSearch_Click);
            // 
            // buttonCrudeClientGenderRefAdd
            // 
            this.buttonCrudeClientGenderRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientGenderRefAdd.Location = new System.Drawing.Point(133, 264);
            this.buttonCrudeClientGenderRefAdd.Name = "buttonCrudeClientGenderRefAdd";
            this.buttonCrudeClientGenderRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientGenderRefAdd.TabIndex = 3;
            this.buttonCrudeClientGenderRefAdd.Text = "&Add";
            this.buttonCrudeClientGenderRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientGenderRefAdd.Click += new System.EventHandler(this.buttonCrudeClientGenderRefAdd_Click);
            // 
            // buttonCrudeClientGenderRefEdit
            // 
            this.buttonCrudeClientGenderRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientGenderRefEdit.Location = new System.Drawing.Point(33, 264);
            this.buttonCrudeClientGenderRefEdit.Name = "buttonCrudeClientGenderRefEdit";
            this.buttonCrudeClientGenderRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientGenderRefEdit.TabIndex = 4;
            this.buttonCrudeClientGenderRefEdit.Text = "&Edit";
            this.buttonCrudeClientGenderRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientGenderRefEdit.Click += new System.EventHandler(this.buttonCrudeClientGenderRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 292);
            this.Controls.Add(this.buttonCrudeClientGenderRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientGenderRefAdd);
            this.Controls.Add(this.buttonCrudeClientGenderRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientGenderRef);
            this.Name = "CrudeClientGenderRefSearch";
            this.Text = "Client Gender Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientGenderRef)).EndInit();
            this.Controls.Add(this.labelClientGenderName);
            this.Controls.Add(this.textBoxClientGenderName);
            this.Controls.Add(this.labelClientGender);
            this.Controls.Add(this.textBoxClientGender);
            this.Controls.Add(this.labelClientGenderDescription);
            this.Controls.Add(this.textBoxClientGenderDescription);
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
