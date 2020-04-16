namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientNationalityRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientNationalityRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientNationalityRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientNationalityRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientNationalityRef;
        
        private System.Windows.Forms.TextBox textBoxClientNationalityName;
        
        private System.Windows.Forms.Label labelClientNationalityName;
        
        private System.Windows.Forms.TextBox textBoxClientNationality;
        
        private System.Windows.Forms.Label labelClientNationality;
        
        private System.Windows.Forms.TextBox textBoxClientNationalityDescription;
        
        private System.Windows.Forms.Label labelClientNationalityDescription;
        
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
            this.buttonCrudeClientNationalityRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientNationalityRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientNationalityRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientNationalityRef = new System.Windows.Forms.DataGridView();
            this.labelClientNationalityName = new System.Windows.Forms.Label();
            this.textBoxClientNationalityName = new System.Windows.Forms.TextBox();
            this.labelClientNationality = new System.Windows.Forms.Label();
            this.textBoxClientNationality = new System.Windows.Forms.TextBox();
            this.labelClientNationalityDescription = new System.Windows.Forms.Label();
            this.textBoxClientNationalityDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientNationalityRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientNationalityName
            //
            this.labelClientNationalityName.AutoSize = true;
            this.labelClientNationalityName.Location = new System.Drawing.Point(11, 13);
            this.labelClientNationalityName.Name = "labelClientNationalityName";
            this.labelClientNationalityName.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityName.TabIndex = 2;
            this.labelClientNationalityName.Text = "Client Nationality Name:";
            //
            //textBoxClientNationalityName
            //
            this.textBoxClientNationalityName.Location = new System.Drawing.Point(210, 13);
            this.textBoxClientNationalityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationalityName.Name = "textBoxClientNationalityName";
            this.textBoxClientNationalityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationalityName.TabIndex = 3;
            //
            // labelClientNationality
            //
            this.labelClientNationality.AutoSize = true;
            this.labelClientNationality.Location = new System.Drawing.Point(11, 36);
            this.labelClientNationality.Name = "labelClientNationality";
            this.labelClientNationality.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationality.TabIndex = 4;
            this.labelClientNationality.Text = "Client Nationality:";
            //
            //textBoxClientNationality
            //
            this.textBoxClientNationality.Location = new System.Drawing.Point(210, 36);
            this.textBoxClientNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationality.Name = "textBoxClientNationality";
            this.textBoxClientNationality.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationality.TabIndex = 5;
            //
            // labelClientNationalityDescription
            //
            this.labelClientNationalityDescription.AutoSize = true;
            this.labelClientNationalityDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientNationalityDescription.Name = "labelClientNationalityDescription";
            this.labelClientNationalityDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientNationalityDescription.TabIndex = 6;
            this.labelClientNationalityDescription.Text = "Client Nationality Description:";
            //
            //textBoxClientNationalityDescription
            //
            this.textBoxClientNationalityDescription.Location = new System.Drawing.Point(210, 59);
            this.textBoxClientNationalityDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientNationalityDescription.Name = "textBoxClientNationalityDescription";
            this.textBoxClientNationalityDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientNationalityDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(210, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(210, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientNationalityRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientNationalityRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientNationalityRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientNationalityRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientNationalityRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientNationalityRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientNationalityRef.Name = "dataGridViewCrudeClientNationalityRef";
            this.dataGridViewCrudeClientNationalityRef.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeClientNationalityRef.TabIndex = 0;
            this.dataGridViewCrudeClientNationalityRef.ReadOnly = true;
            this.dataGridViewCrudeClientNationalityRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientNationalityRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientNationalityRefSearch
            // 
            this.buttonCrudeClientNationalityRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientNationalityRefSearch.Location = new System.Drawing.Point(268, 264);
            this.buttonCrudeClientNationalityRefSearch.Name = "buttonCrudeClientNationalityRefSearch";
            this.buttonCrudeClientNationalityRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientNationalityRefSearch.TabIndex = 2;
            this.buttonCrudeClientNationalityRefSearch.Text = "&Search";
            this.buttonCrudeClientNationalityRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientNationalityRefSearch.Click += new System.EventHandler(this.buttonCrudeClientNationalityRefSearch_Click);
            // 
            // buttonCrudeClientNationalityRefAdd
            // 
            this.buttonCrudeClientNationalityRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientNationalityRefAdd.Location = new System.Drawing.Point(168, 264);
            this.buttonCrudeClientNationalityRefAdd.Name = "buttonCrudeClientNationalityRefAdd";
            this.buttonCrudeClientNationalityRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientNationalityRefAdd.TabIndex = 3;
            this.buttonCrudeClientNationalityRefAdd.Text = "&Add";
            this.buttonCrudeClientNationalityRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientNationalityRefAdd.Click += new System.EventHandler(this.buttonCrudeClientNationalityRefAdd_Click);
            // 
            // buttonCrudeClientNationalityRefEdit
            // 
            this.buttonCrudeClientNationalityRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientNationalityRefEdit.Location = new System.Drawing.Point(68, 264);
            this.buttonCrudeClientNationalityRefEdit.Name = "buttonCrudeClientNationalityRefEdit";
            this.buttonCrudeClientNationalityRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientNationalityRefEdit.TabIndex = 4;
            this.buttonCrudeClientNationalityRefEdit.Text = "&Edit";
            this.buttonCrudeClientNationalityRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientNationalityRefEdit.Click += new System.EventHandler(this.buttonCrudeClientNationalityRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 292);
            this.Controls.Add(this.buttonCrudeClientNationalityRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientNationalityRefAdd);
            this.Controls.Add(this.buttonCrudeClientNationalityRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientNationalityRef);
            this.Name = "CrudeClientNationalityRefSearch";
            this.Text = "Client Nationality Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientNationalityRef)).EndInit();
            this.Controls.Add(this.labelClientNationalityName);
            this.Controls.Add(this.textBoxClientNationalityName);
            this.Controls.Add(this.labelClientNationality);
            this.Controls.Add(this.textBoxClientNationality);
            this.Controls.Add(this.labelClientNationalityDescription);
            this.Controls.Add(this.textBoxClientNationalityDescription);
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
