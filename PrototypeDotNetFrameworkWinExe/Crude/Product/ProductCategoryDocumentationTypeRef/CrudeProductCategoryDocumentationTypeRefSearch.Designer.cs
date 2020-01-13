namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryDocumentationTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryDocumentationTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryDocumentationTypeName;
        
        private System.Windows.Forms.Label labelProductCategoryDocumentationTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryDocumentationType;
        
        private System.Windows.Forms.Label labelProductCategoryDocumentationType;
        
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
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryDocumentationTypeName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryDocumentationTypeName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryDocumentationType = new System.Windows.Forms.Label();
            this.textBoxProductCategoryDocumentationType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentationTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryDocumentationTypeName
            //
            this.labelProductCategoryDocumentationTypeName.AutoSize = true;
            this.labelProductCategoryDocumentationTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryDocumentationTypeName.Name = "labelProductCategoryDocumentationTypeName";
            this.labelProductCategoryDocumentationTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationTypeName.TabIndex = 2;
            this.labelProductCategoryDocumentationTypeName.Text = "Product Category Documentation Type Name:";
            //
            //textBoxProductCategoryDocumentationTypeName
            //
            this.textBoxProductCategoryDocumentationTypeName.Location = new System.Drawing.Point(280, 13);
            this.textBoxProductCategoryDocumentationTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryDocumentationTypeName.Name = "textBoxProductCategoryDocumentationTypeName";
            this.textBoxProductCategoryDocumentationTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryDocumentationTypeName.TabIndex = 3;
            //
            // labelProductCategoryDocumentationType
            //
            this.labelProductCategoryDocumentationType.AutoSize = true;
            this.labelProductCategoryDocumentationType.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryDocumentationType.Name = "labelProductCategoryDocumentationType";
            this.labelProductCategoryDocumentationType.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationType.TabIndex = 4;
            this.labelProductCategoryDocumentationType.Text = "Product Category Documentation Type:";
            //
            //textBoxProductCategoryDocumentationType
            //
            this.textBoxProductCategoryDocumentationType.Location = new System.Drawing.Point(280, 36);
            this.textBoxProductCategoryDocumentationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryDocumentationType.Name = "textBoxProductCategoryDocumentationType";
            this.textBoxProductCategoryDocumentationType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryDocumentationType.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(280, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductCategoryDocumentationTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.Name = "dataGridViewCrudeProductCategoryDocumentationTypeRef";
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.Size = new System.Drawing.Size(518, 96);
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductCategoryDocumentationTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryDocumentationTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(438, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategoryDocumentationTypeRefSearch
            // 
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Location = new System.Drawing.Point(338, 195);
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Name = "buttonCrudeProductCategoryDocumentationTypeRefSearch";
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationTypeRefSearch_Click);
            // 
            // buttonCrudeProductCategoryDocumentationTypeRefAdd
            // 
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Location = new System.Drawing.Point(238, 195);
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Name = "buttonCrudeProductCategoryDocumentationTypeRefAdd";
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationTypeRefAdd_Click);
            // 
            // buttonCrudeProductCategoryDocumentationTypeRefEdit
            // 
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Location = new System.Drawing.Point(138, 195);
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Name = "buttonCrudeProductCategoryDocumentationTypeRefEdit";
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 223);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryDocumentationTypeRef);
            this.Name = "CrudeProductCategoryDocumentationTypeRefSearch";
            this.Text = "Product Category Documentation Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentationTypeRef)).EndInit();
            this.Controls.Add(this.labelProductCategoryDocumentationTypeName);
            this.Controls.Add(this.textBoxProductCategoryDocumentationTypeName);
            this.Controls.Add(this.labelProductCategoryDocumentationType);
            this.Controls.Add(this.textBoxProductCategoryDocumentationType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
