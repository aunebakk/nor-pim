namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductImageTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductImageTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductImageTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductImageTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductImageTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductImageTypeName;
        
        private System.Windows.Forms.Label labelProductImageTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductImageType;
        
        private System.Windows.Forms.Label labelProductImageType;
        
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
            this.buttonCrudeProductImageTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductImageTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductImageTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductImageTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductImageTypeName = new System.Windows.Forms.Label();
            this.textBoxProductImageTypeName = new System.Windows.Forms.TextBox();
            this.labelProductImageType = new System.Windows.Forms.Label();
            this.textBoxProductImageType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductImageTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductImageTypeName
            //
            this.labelProductImageTypeName.AutoSize = true;
            this.labelProductImageTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductImageTypeName.Name = "labelProductImageTypeName";
            this.labelProductImageTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageTypeName.TabIndex = 2;
            this.labelProductImageTypeName.Text = "Product Image Type Name:";
            //
            //textBoxProductImageTypeName
            //
            this.textBoxProductImageTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxProductImageTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductImageTypeName.Name = "textBoxProductImageTypeName";
            this.textBoxProductImageTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductImageTypeName.TabIndex = 3;
            //
            // labelProductImageType
            //
            this.labelProductImageType.AutoSize = true;
            this.labelProductImageType.Location = new System.Drawing.Point(11, 36);
            this.labelProductImageType.Name = "labelProductImageType";
            this.labelProductImageType.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageType.TabIndex = 4;
            this.labelProductImageType.Text = "Product Image Type:";
            //
            //textBoxProductImageType
            //
            this.textBoxProductImageType.Location = new System.Drawing.Point(161, 36);
            this.textBoxProductImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductImageType.Name = "textBoxProductImageType";
            this.textBoxProductImageType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductImageType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductImageTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductImageTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductImageTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductImageTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductImageTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductImageTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductImageTypeRef.Name = "dataGridViewCrudeProductImageTypeRef";
            this.dataGridViewCrudeProductImageTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeProductImageTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductImageTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductImageTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductImageTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductImageTypeRefSearch
            // 
            this.buttonCrudeProductImageTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeProductImageTypeRefSearch.Name = "buttonCrudeProductImageTypeRefSearch";
            this.buttonCrudeProductImageTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductImageTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductImageTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductImageTypeRefSearch_Click);
            // 
            // buttonCrudeProductImageTypeRefAdd
            // 
            this.buttonCrudeProductImageTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeProductImageTypeRefAdd.Name = "buttonCrudeProductImageTypeRefAdd";
            this.buttonCrudeProductImageTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductImageTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductImageTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductImageTypeRefAdd_Click);
            // 
            // buttonCrudeProductImageTypeRefEdit
            // 
            this.buttonCrudeProductImageTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductImageTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeProductImageTypeRefEdit.Name = "buttonCrudeProductImageTypeRefEdit";
            this.buttonCrudeProductImageTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductImageTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductImageTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductImageTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductImageTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductImageTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeProductImageTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductImageTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductImageTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductImageTypeRef);
            this.Name = "CrudeProductImageTypeRefSearch";
            this.Text = "Product Image Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductImageTypeRef)).EndInit();
            this.Controls.Add(this.labelProductImageTypeName);
            this.Controls.Add(this.textBoxProductImageTypeName);
            this.Controls.Add(this.labelProductImageType);
            this.Controls.Add(this.textBoxProductImageType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
