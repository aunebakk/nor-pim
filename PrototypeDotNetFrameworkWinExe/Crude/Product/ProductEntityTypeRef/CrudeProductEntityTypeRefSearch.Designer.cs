namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductEntityTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductEntityTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductEntityTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductEntityTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductEntityTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductEntityTypeName;
        
        private System.Windows.Forms.Label labelProductEntityTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductEntityType;
        
        private System.Windows.Forms.Label labelProductEntityType;
        
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
            this.buttonCrudeProductEntityTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductEntityTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductEntityTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductEntityTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductEntityTypeName = new System.Windows.Forms.Label();
            this.textBoxProductEntityTypeName = new System.Windows.Forms.TextBox();
            this.labelProductEntityType = new System.Windows.Forms.Label();
            this.textBoxProductEntityType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductEntityTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductEntityTypeName
            //
            this.labelProductEntityTypeName.AutoSize = true;
            this.labelProductEntityTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductEntityTypeName.Name = "labelProductEntityTypeName";
            this.labelProductEntityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductEntityTypeName.TabIndex = 2;
            this.labelProductEntityTypeName.Text = "Product Entity Type Name:";
            //
            //textBoxProductEntityTypeName
            //
            this.textBoxProductEntityTypeName.Location = new System.Drawing.Point(168, 13);
            this.textBoxProductEntityTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductEntityTypeName.Name = "textBoxProductEntityTypeName";
            this.textBoxProductEntityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductEntityTypeName.TabIndex = 3;
            //
            // labelProductEntityType
            //
            this.labelProductEntityType.AutoSize = true;
            this.labelProductEntityType.Location = new System.Drawing.Point(11, 36);
            this.labelProductEntityType.Name = "labelProductEntityType";
            this.labelProductEntityType.Size = new System.Drawing.Size(71, 13);
            this.labelProductEntityType.TabIndex = 4;
            this.labelProductEntityType.Text = "Product Entity Type:";
            //
            //textBoxProductEntityType
            //
            this.textBoxProductEntityType.Location = new System.Drawing.Point(168, 36);
            this.textBoxProductEntityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductEntityType.Name = "textBoxProductEntityType";
            this.textBoxProductEntityType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductEntityType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductEntityTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductEntityTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductEntityTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductEntityTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductEntityTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductEntityTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductEntityTypeRef.Name = "dataGridViewCrudeProductEntityTypeRef";
            this.dataGridViewCrudeProductEntityTypeRef.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeProductEntityTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductEntityTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductEntityTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductEntityTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductEntityTypeRefSearch
            // 
            this.buttonCrudeProductEntityTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductEntityTypeRefSearch.Location = new System.Drawing.Point(226, 195);
            this.buttonCrudeProductEntityTypeRefSearch.Name = "buttonCrudeProductEntityTypeRefSearch";
            this.buttonCrudeProductEntityTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductEntityTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductEntityTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductEntityTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductEntityTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductEntityTypeRefSearch_Click);
            // 
            // buttonCrudeProductEntityTypeRefAdd
            // 
            this.buttonCrudeProductEntityTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductEntityTypeRefAdd.Location = new System.Drawing.Point(126, 195);
            this.buttonCrudeProductEntityTypeRefAdd.Name = "buttonCrudeProductEntityTypeRefAdd";
            this.buttonCrudeProductEntityTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductEntityTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductEntityTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductEntityTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductEntityTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductEntityTypeRefAdd_Click);
            // 
            // buttonCrudeProductEntityTypeRefEdit
            // 
            this.buttonCrudeProductEntityTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductEntityTypeRefEdit.Location = new System.Drawing.Point(26, 195);
            this.buttonCrudeProductEntityTypeRefEdit.Name = "buttonCrudeProductEntityTypeRefEdit";
            this.buttonCrudeProductEntityTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductEntityTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductEntityTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductEntityTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductEntityTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductEntityTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 223);
            this.Controls.Add(this.buttonCrudeProductEntityTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductEntityTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductEntityTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductEntityTypeRef);
            this.Name = "CrudeProductEntityTypeRefSearch";
            this.Text = "Product Entity Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductEntityTypeRef)).EndInit();
            this.Controls.Add(this.labelProductEntityTypeName);
            this.Controls.Add(this.textBoxProductEntityTypeName);
            this.Controls.Add(this.labelProductEntityType);
            this.Controls.Add(this.textBoxProductEntityType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
