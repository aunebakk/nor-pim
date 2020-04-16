namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductAttributeRef;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeName;
        
        private System.Windows.Forms.Label labelProductAttributeName;
        
        private System.Windows.Forms.TextBox textBoxProductAttribute;
        
        private System.Windows.Forms.Label labelProductAttribute;
        
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
            this.buttonCrudeProductAttributeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductAttributeRef = new System.Windows.Forms.DataGridView();
            this.labelProductAttributeName = new System.Windows.Forms.Label();
            this.textBoxProductAttributeName = new System.Windows.Forms.TextBox();
            this.labelProductAttribute = new System.Windows.Forms.Label();
            this.textBoxProductAttribute = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttributeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductAttributeName
            //
            this.labelProductAttributeName.AutoSize = true;
            this.labelProductAttributeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttributeName.Name = "labelProductAttributeName";
            this.labelProductAttributeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeName.TabIndex = 2;
            this.labelProductAttributeName.Text = "Product Attribute Name:";
            //
            //textBoxProductAttributeName
            //
            this.textBoxProductAttributeName.Location = new System.Drawing.Point(154, 13);
            this.textBoxProductAttributeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeName.Name = "textBoxProductAttributeName";
            this.textBoxProductAttributeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeName.TabIndex = 3;
            //
            // labelProductAttribute
            //
            this.labelProductAttribute.AutoSize = true;
            this.labelProductAttribute.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttribute.Name = "labelProductAttribute";
            this.labelProductAttribute.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttribute.TabIndex = 4;
            this.labelProductAttribute.Text = "Product Attribute:";
            //
            //textBoxProductAttribute
            //
            this.textBoxProductAttribute.Location = new System.Drawing.Point(154, 36);
            this.textBoxProductAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttribute.Name = "textBoxProductAttribute";
            this.textBoxProductAttribute.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttribute.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductAttributeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductAttributeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductAttributeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductAttributeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductAttributeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductAttributeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductAttributeRef.Name = "dataGridViewCrudeProductAttributeRef";
            this.dataGridViewCrudeProductAttributeRef.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeProductAttributeRef.TabIndex = 0;
            this.dataGridViewCrudeProductAttributeRef.ReadOnly = true;
            this.dataGridViewCrudeProductAttributeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductAttributeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductAttributeRefSearch
            // 
            this.buttonCrudeProductAttributeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeRefSearch.Location = new System.Drawing.Point(212, 195);
            this.buttonCrudeProductAttributeRefSearch.Name = "buttonCrudeProductAttributeRefSearch";
            this.buttonCrudeProductAttributeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeRefSearch.TabIndex = 2;
            this.buttonCrudeProductAttributeRefSearch.Text = "&Search";
            this.buttonCrudeProductAttributeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductAttributeRefSearch_Click);
            // 
            // buttonCrudeProductAttributeRefAdd
            // 
            this.buttonCrudeProductAttributeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeRefAdd.Location = new System.Drawing.Point(112, 195);
            this.buttonCrudeProductAttributeRefAdd.Name = "buttonCrudeProductAttributeRefAdd";
            this.buttonCrudeProductAttributeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeRefAdd.TabIndex = 3;
            this.buttonCrudeProductAttributeRefAdd.Text = "&Add";
            this.buttonCrudeProductAttributeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductAttributeRefAdd_Click);
            // 
            // buttonCrudeProductAttributeRefEdit
            // 
            this.buttonCrudeProductAttributeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeRefEdit.Location = new System.Drawing.Point(12, 195);
            this.buttonCrudeProductAttributeRefEdit.Name = "buttonCrudeProductAttributeRefEdit";
            this.buttonCrudeProductAttributeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeRefEdit.TabIndex = 4;
            this.buttonCrudeProductAttributeRefEdit.Text = "&Edit";
            this.buttonCrudeProductAttributeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductAttributeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.buttonCrudeProductAttributeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductAttributeRefAdd);
            this.Controls.Add(this.buttonCrudeProductAttributeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductAttributeRef);
            this.Name = "CrudeProductAttributeRefSearch";
            this.Text = "Product Attribute Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttributeRef)).EndInit();
            this.Controls.Add(this.labelProductAttributeName);
            this.Controls.Add(this.textBoxProductAttributeName);
            this.Controls.Add(this.labelProductAttribute);
            this.Controls.Add(this.textBoxProductAttribute);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
