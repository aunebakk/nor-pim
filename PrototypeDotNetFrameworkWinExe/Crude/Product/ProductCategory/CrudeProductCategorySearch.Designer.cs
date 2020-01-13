namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductCategorySearch;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategory;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryName;
        
        private System.Windows.Forms.Label labelProductCategoryName;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryCode;
        
        private System.Windows.Forms.Label labelProductCategoryCode;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProductCategoryPosition;
        
        private System.Windows.Forms.Label labelProductCategoryPosition;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
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
            this.buttonCrudeProductCategoryAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategorySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategory = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryCode = new System.Windows.Forms.Label();
            this.textBoxProductCategoryCode = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelProductCategoryPosition = new System.Windows.Forms.Label();
            this.maskedTextBoxProductCategoryPosition = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategory)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryName
            //
            this.labelProductCategoryName.AutoSize = true;
            this.labelProductCategoryName.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryName.Name = "labelProductCategoryName";
            this.labelProductCategoryName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryName.TabIndex = 2;
            this.labelProductCategoryName.Text = "Product Category Name:";
            //
            //textBoxProductCategoryName
            //
            this.textBoxProductCategoryName.Location = new System.Drawing.Point(175, 13);
            this.textBoxProductCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryName.Name = "textBoxProductCategoryName";
            this.textBoxProductCategoryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryName.TabIndex = 3;
            //
            // labelProductCategoryCode
            //
            this.labelProductCategoryCode.AutoSize = true;
            this.labelProductCategoryCode.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryCode.Name = "labelProductCategoryCode";
            this.labelProductCategoryCode.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryCode.TabIndex = 4;
            this.labelProductCategoryCode.Text = "Product Category Code:";
            //
            //textBoxProductCategoryCode
            //
            this.textBoxProductCategoryCode.Location = new System.Drawing.Point(175, 36);
            this.textBoxProductCategoryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryCode.Name = "textBoxProductCategoryCode";
            this.textBoxProductCategoryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryCode.TabIndex = 5;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 59);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(175, 59);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 7;
            //
            // labelProductCategoryPosition
            //
            this.labelProductCategoryPosition.AutoSize = true;
            this.labelProductCategoryPosition.Location = new System.Drawing.Point(11, 82);
            this.labelProductCategoryPosition.Name = "labelProductCategoryPosition";
            this.labelProductCategoryPosition.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryPosition.TabIndex = 8;
            this.labelProductCategoryPosition.Text = "Product Category Position:";
            //
            //maskedTextBoxProductCategoryPosition
            //
            this.maskedTextBoxProductCategoryPosition.Location = new System.Drawing.Point(175, 82);
            this.maskedTextBoxProductCategoryPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxProductCategoryPosition.Name = "maskedTextBoxProductCategoryPosition";
            this.maskedTextBoxProductCategoryPosition.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxProductCategoryPosition.TabIndex = 9;
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
            // dataGridViewCrudeProductCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategory.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeProductCategory.Name = "dataGridViewCrudeProductCategory";
            this.dataGridViewCrudeProductCategory.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeProductCategory.TabIndex = 0;
            this.dataGridViewCrudeProductCategory.ReadOnly = true;
            this.dataGridViewCrudeProductCategory.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategory_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategorySearch
            // 
            this.buttonCrudeProductCategorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategorySearch.Location = new System.Drawing.Point(233, 241);
            this.buttonCrudeProductCategorySearch.Name = "buttonCrudeProductCategorySearch";
            this.buttonCrudeProductCategorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategorySearch.TabIndex = 2;
            this.buttonCrudeProductCategorySearch.Text = "&Search";
            this.buttonCrudeProductCategorySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategorySearch.Click += new System.EventHandler(this.buttonCrudeProductCategorySearch_Click);
            // 
            // buttonCrudeProductCategoryAdd
            // 
            this.buttonCrudeProductCategoryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryAdd.Location = new System.Drawing.Point(133, 241);
            this.buttonCrudeProductCategoryAdd.Name = "buttonCrudeProductCategoryAdd";
            this.buttonCrudeProductCategoryAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryAdd.Text = "&Add";
            this.buttonCrudeProductCategoryAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryAdd_Click);
            // 
            // buttonCrudeProductCategoryEdit
            // 
            this.buttonCrudeProductCategoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryEdit.Location = new System.Drawing.Point(33, 241);
            this.buttonCrudeProductCategoryEdit.Name = "buttonCrudeProductCategoryEdit";
            this.buttonCrudeProductCategoryEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 269);
            this.Controls.Add(this.buttonCrudeProductCategorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategory);
            this.Name = "CrudeProductCategorySearch";
            this.Text = "Product Category Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategory)).EndInit();
            this.Controls.Add(this.labelProductCategoryName);
            this.Controls.Add(this.textBoxProductCategoryName);
            this.Controls.Add(this.labelProductCategoryCode);
            this.Controls.Add(this.textBoxProductCategoryCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelProductCategoryPosition);
            this.Controls.Add(this.maskedTextBoxProductCategoryPosition);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
