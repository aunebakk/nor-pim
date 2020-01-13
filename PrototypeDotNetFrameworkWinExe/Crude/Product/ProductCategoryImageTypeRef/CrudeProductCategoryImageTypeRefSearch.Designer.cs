namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductCategoryImageTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryImageTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryImageTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryImageTypeName;
        
        private System.Windows.Forms.Label labelProductCategoryImageTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductCategoryImageType;
        
        private System.Windows.Forms.Label labelProductCategoryImageType;
        
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
            this.buttonCrudeProductCategoryImageTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryImageTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryImageTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryImageTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryImageTypeName = new System.Windows.Forms.Label();
            this.textBoxProductCategoryImageTypeName = new System.Windows.Forms.TextBox();
            this.labelProductCategoryImageType = new System.Windows.Forms.Label();
            this.textBoxProductCategoryImageType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryImageTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryImageTypeName
            //
            this.labelProductCategoryImageTypeName.AutoSize = true;
            this.labelProductCategoryImageTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryImageTypeName.Name = "labelProductCategoryImageTypeName";
            this.labelProductCategoryImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageTypeName.TabIndex = 2;
            this.labelProductCategoryImageTypeName.Text = "Product Category Image Type Name:";
            //
            //textBoxProductCategoryImageTypeName
            //
            this.textBoxProductCategoryImageTypeName.Location = new System.Drawing.Point(224, 13);
            this.textBoxProductCategoryImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryImageTypeName.Name = "textBoxProductCategoryImageTypeName";
            this.textBoxProductCategoryImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryImageTypeName.TabIndex = 3;
            //
            // labelProductCategoryImageType
            //
            this.labelProductCategoryImageType.AutoSize = true;
            this.labelProductCategoryImageType.Location = new System.Drawing.Point(11, 36);
            this.labelProductCategoryImageType.Name = "labelProductCategoryImageType";
            this.labelProductCategoryImageType.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryImageType.TabIndex = 4;
            this.labelProductCategoryImageType.Text = "Product Category Image Type:";
            //
            //textBoxProductCategoryImageType
            //
            this.textBoxProductCategoryImageType.Location = new System.Drawing.Point(224, 36);
            this.textBoxProductCategoryImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductCategoryImageType.Name = "textBoxProductCategoryImageType";
            this.textBoxProductCategoryImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductCategoryImageType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductCategoryImageTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryImageTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryImageTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryImageTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryImageTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategoryImageTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductCategoryImageTypeRef.Name = "dataGridViewCrudeProductCategoryImageTypeRef";
            this.dataGridViewCrudeProductCategoryImageTypeRef.Size = new System.Drawing.Size(462, 96);
            this.dataGridViewCrudeProductCategoryImageTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryImageTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductCategoryImageTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryImageTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategoryImageTypeRefSearch
            // 
            this.buttonCrudeProductCategoryImageTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageTypeRefSearch.Location = new System.Drawing.Point(282, 195);
            this.buttonCrudeProductCategoryImageTypeRefSearch.Name = "buttonCrudeProductCategoryImageTypeRefSearch";
            this.buttonCrudeProductCategoryImageTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductCategoryImageTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductCategoryImageTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageTypeRefSearch_Click);
            // 
            // buttonCrudeProductCategoryImageTypeRefAdd
            // 
            this.buttonCrudeProductCategoryImageTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageTypeRefAdd.Location = new System.Drawing.Point(182, 195);
            this.buttonCrudeProductCategoryImageTypeRefAdd.Name = "buttonCrudeProductCategoryImageTypeRefAdd";
            this.buttonCrudeProductCategoryImageTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryImageTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductCategoryImageTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageTypeRefAdd_Click);
            // 
            // buttonCrudeProductCategoryImageTypeRefEdit
            // 
            this.buttonCrudeProductCategoryImageTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryImageTypeRefEdit.Location = new System.Drawing.Point(82, 195);
            this.buttonCrudeProductCategoryImageTypeRefEdit.Name = "buttonCrudeProductCategoryImageTypeRefEdit";
            this.buttonCrudeProductCategoryImageTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryImageTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryImageTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryImageTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryImageTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryImageTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 223);
            this.Controls.Add(this.buttonCrudeProductCategoryImageTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryImageTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryImageTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryImageTypeRef);
            this.Name = "CrudeProductCategoryImageTypeRefSearch";
            this.Text = "Product Category Image Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryImageTypeRef)).EndInit();
            this.Controls.Add(this.labelProductCategoryImageTypeName);
            this.Controls.Add(this.textBoxProductCategoryImageTypeName);
            this.Controls.Add(this.labelProductCategoryImageType);
            this.Controls.Add(this.textBoxProductCategoryImageType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
