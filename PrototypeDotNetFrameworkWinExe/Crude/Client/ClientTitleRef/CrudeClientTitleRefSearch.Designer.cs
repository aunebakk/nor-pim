namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientTitleRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientTitleRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientTitleRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientTitleRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientTitleRef;
        
        private System.Windows.Forms.TextBox textBoxClientTitleName;
        
        private System.Windows.Forms.Label labelClientTitleName;
        
        private System.Windows.Forms.TextBox textBoxClientTitle;
        
        private System.Windows.Forms.Label labelClientTitle;
        
        private System.Windows.Forms.TextBox textBoxClientTitleDescription;
        
        private System.Windows.Forms.Label labelClientTitleDescription;
        
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
            this.buttonCrudeClientTitleRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientTitleRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientTitleRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientTitleRef = new System.Windows.Forms.DataGridView();
            this.labelClientTitleName = new System.Windows.Forms.Label();
            this.textBoxClientTitleName = new System.Windows.Forms.TextBox();
            this.labelClientTitle = new System.Windows.Forms.Label();
            this.textBoxClientTitle = new System.Windows.Forms.TextBox();
            this.labelClientTitleDescription = new System.Windows.Forms.Label();
            this.textBoxClientTitleDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientTitleRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientTitleName
            //
            this.labelClientTitleName.AutoSize = true;
            this.labelClientTitleName.Location = new System.Drawing.Point(11, 13);
            this.labelClientTitleName.Name = "labelClientTitleName";
            this.labelClientTitleName.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleName.TabIndex = 2;
            this.labelClientTitleName.Text = "Client Title Name:";
            //
            //textBoxClientTitleName
            //
            this.textBoxClientTitleName.Location = new System.Drawing.Point(168, 13);
            this.textBoxClientTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitleName.Name = "textBoxClientTitleName";
            this.textBoxClientTitleName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitleName.TabIndex = 3;
            //
            // labelClientTitle
            //
            this.labelClientTitle.AutoSize = true;
            this.labelClientTitle.Location = new System.Drawing.Point(11, 36);
            this.labelClientTitle.Name = "labelClientTitle";
            this.labelClientTitle.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitle.TabIndex = 4;
            this.labelClientTitle.Text = "Client Title:";
            //
            //textBoxClientTitle
            //
            this.textBoxClientTitle.Location = new System.Drawing.Point(168, 36);
            this.textBoxClientTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitle.Name = "textBoxClientTitle";
            this.textBoxClientTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitle.TabIndex = 5;
            //
            // labelClientTitleDescription
            //
            this.labelClientTitleDescription.AutoSize = true;
            this.labelClientTitleDescription.Location = new System.Drawing.Point(11, 59);
            this.labelClientTitleDescription.Name = "labelClientTitleDescription";
            this.labelClientTitleDescription.Size = new System.Drawing.Size(71, 13);
            this.labelClientTitleDescription.TabIndex = 6;
            this.labelClientTitleDescription.Text = "Client Title Description:";
            //
            //textBoxClientTitleDescription
            //
            this.textBoxClientTitleDescription.Location = new System.Drawing.Point(168, 59);
            this.textBoxClientTitleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientTitleDescription.Name = "textBoxClientTitleDescription";
            this.textBoxClientTitleDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientTitleDescription.TabIndex = 7;
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
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(168, 82);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 105);
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
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(168, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeClientTitleRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientTitleRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientTitleRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientTitleRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientTitleRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientTitleRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientTitleRef.Name = "dataGridViewCrudeClientTitleRef";
            this.dataGridViewCrudeClientTitleRef.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeClientTitleRef.TabIndex = 0;
            this.dataGridViewCrudeClientTitleRef.ReadOnly = true;
            this.dataGridViewCrudeClientTitleRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientTitleRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientTitleRefSearch
            // 
            this.buttonCrudeClientTitleRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTitleRefSearch.Location = new System.Drawing.Point(226, 264);
            this.buttonCrudeClientTitleRefSearch.Name = "buttonCrudeClientTitleRefSearch";
            this.buttonCrudeClientTitleRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTitleRefSearch.TabIndex = 2;
            this.buttonCrudeClientTitleRefSearch.Text = "&Search";
            this.buttonCrudeClientTitleRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTitleRefSearch.Click += new System.EventHandler(this.buttonCrudeClientTitleRefSearch_Click);
            // 
            // buttonCrudeClientTitleRefAdd
            // 
            this.buttonCrudeClientTitleRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTitleRefAdd.Location = new System.Drawing.Point(126, 264);
            this.buttonCrudeClientTitleRefAdd.Name = "buttonCrudeClientTitleRefAdd";
            this.buttonCrudeClientTitleRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTitleRefAdd.TabIndex = 3;
            this.buttonCrudeClientTitleRefAdd.Text = "&Add";
            this.buttonCrudeClientTitleRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTitleRefAdd.Click += new System.EventHandler(this.buttonCrudeClientTitleRefAdd_Click);
            // 
            // buttonCrudeClientTitleRefEdit
            // 
            this.buttonCrudeClientTitleRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientTitleRefEdit.Location = new System.Drawing.Point(26, 264);
            this.buttonCrudeClientTitleRefEdit.Name = "buttonCrudeClientTitleRefEdit";
            this.buttonCrudeClientTitleRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientTitleRefEdit.TabIndex = 4;
            this.buttonCrudeClientTitleRefEdit.Text = "&Edit";
            this.buttonCrudeClientTitleRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientTitleRefEdit.Click += new System.EventHandler(this.buttonCrudeClientTitleRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 292);
            this.Controls.Add(this.buttonCrudeClientTitleRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientTitleRefAdd);
            this.Controls.Add(this.buttonCrudeClientTitleRefEdit);
            this.Controls.Add(this.dataGridViewCrudeClientTitleRef);
            this.Name = "CrudeClientTitleRefSearch";
            this.Text = "Client Title Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientTitleRef)).EndInit();
            this.Controls.Add(this.labelClientTitleName);
            this.Controls.Add(this.textBoxClientTitleName);
            this.Controls.Add(this.labelClientTitle);
            this.Controls.Add(this.textBoxClientTitle);
            this.Controls.Add(this.labelClientTitleDescription);
            this.Controls.Add(this.textBoxClientTitleDescription);
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
