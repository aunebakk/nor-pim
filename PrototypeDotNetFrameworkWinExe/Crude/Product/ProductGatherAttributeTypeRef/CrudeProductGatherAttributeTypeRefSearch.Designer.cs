namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherAttributeTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherAttributeTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductGatherAttributeTypeName;
        
        private System.Windows.Forms.Label labelProductGatherAttributeTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductGatherAttributeType;
        
        private System.Windows.Forms.Label labelProductGatherAttributeType;
        
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
            this.buttonCrudeProductGatherAttributeTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherAttributeTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherAttributeTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGatherAttributeTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductGatherAttributeTypeName = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeTypeName = new System.Windows.Forms.TextBox();
            this.labelProductGatherAttributeType = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherAttributeTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherAttributeTypeName
            //
            this.labelProductGatherAttributeTypeName.AutoSize = true;
            this.labelProductGatherAttributeTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherAttributeTypeName.Name = "labelProductGatherAttributeTypeName";
            this.labelProductGatherAttributeTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeTypeName.TabIndex = 2;
            this.labelProductGatherAttributeTypeName.Text = "Product Gather Attribute Type Name:";
            //
            //textBoxProductGatherAttributeTypeName
            //
            this.textBoxProductGatherAttributeTypeName.Location = new System.Drawing.Point(238, 13);
            this.textBoxProductGatherAttributeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherAttributeTypeName.Name = "textBoxProductGatherAttributeTypeName";
            this.textBoxProductGatherAttributeTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeTypeName.TabIndex = 3;
            //
            // labelProductGatherAttributeType
            //
            this.labelProductGatherAttributeType.AutoSize = true;
            this.labelProductGatherAttributeType.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherAttributeType.Name = "labelProductGatherAttributeType";
            this.labelProductGatherAttributeType.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeType.TabIndex = 4;
            this.labelProductGatherAttributeType.Text = "Product Gather Attribute Type:";
            //
            //textBoxProductGatherAttributeType
            //
            this.textBoxProductGatherAttributeType.Location = new System.Drawing.Point(238, 36);
            this.textBoxProductGatherAttributeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherAttributeType.Name = "textBoxProductGatherAttributeType";
            this.textBoxProductGatherAttributeType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductGatherAttributeTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherAttributeTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherAttributeTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherAttributeTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherAttributeTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGatherAttributeTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductGatherAttributeTypeRef.Name = "dataGridViewCrudeProductGatherAttributeTypeRef";
            this.dataGridViewCrudeProductGatherAttributeTypeRef.Size = new System.Drawing.Size(476, 96);
            this.dataGridViewCrudeProductGatherAttributeTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductGatherAttributeTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductGatherAttributeTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherAttributeTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductGatherAttributeTypeRefSearch
            // 
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Location = new System.Drawing.Point(296, 195);
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Name = "buttonCrudeProductGatherAttributeTypeRefSearch";
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductGatherAttributeTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeTypeRefSearch_Click);
            // 
            // buttonCrudeProductGatherAttributeTypeRefAdd
            // 
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Location = new System.Drawing.Point(196, 195);
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Name = "buttonCrudeProductGatherAttributeTypeRefAdd";
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductGatherAttributeTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeTypeRefAdd_Click);
            // 
            // buttonCrudeProductGatherAttributeTypeRefEdit
            // 
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Location = new System.Drawing.Point(96, 195);
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Name = "buttonCrudeProductGatherAttributeTypeRefEdit";
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductGatherAttributeTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 223);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGatherAttributeTypeRef);
            this.Name = "CrudeProductGatherAttributeTypeRefSearch";
            this.Text = "Product Gather Attribute Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherAttributeTypeRef)).EndInit();
            this.Controls.Add(this.labelProductGatherAttributeTypeName);
            this.Controls.Add(this.textBoxProductGatherAttributeTypeName);
            this.Controls.Add(this.labelProductGatherAttributeType);
            this.Controls.Add(this.textBoxProductGatherAttributeType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
