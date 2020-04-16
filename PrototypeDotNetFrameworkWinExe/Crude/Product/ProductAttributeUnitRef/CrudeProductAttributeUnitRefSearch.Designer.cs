namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductAttributeUnitRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeUnitRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeUnitRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductAttributeUnitRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductAttributeUnitRef;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeUnitName;
        
        private System.Windows.Forms.Label labelProductAttributeUnitName;
        
        private System.Windows.Forms.TextBox textBoxProductAttributeUnit;
        
        private System.Windows.Forms.Label labelProductAttributeUnit;
        
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
            this.buttonCrudeProductAttributeUnitRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeUnitRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeUnitRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductAttributeUnitRef = new System.Windows.Forms.DataGridView();
            this.labelProductAttributeUnitName = new System.Windows.Forms.Label();
            this.textBoxProductAttributeUnitName = new System.Windows.Forms.TextBox();
            this.labelProductAttributeUnit = new System.Windows.Forms.Label();
            this.textBoxProductAttributeUnit = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttributeUnitRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductAttributeUnitName
            //
            this.labelProductAttributeUnitName.AutoSize = true;
            this.labelProductAttributeUnitName.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttributeUnitName.Name = "labelProductAttributeUnitName";
            this.labelProductAttributeUnitName.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitName.TabIndex = 2;
            this.labelProductAttributeUnitName.Text = "Product Attribute Unit Name:";
            //
            //textBoxProductAttributeUnitName
            //
            this.textBoxProductAttributeUnitName.Location = new System.Drawing.Point(189, 13);
            this.textBoxProductAttributeUnitName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeUnitName.Name = "textBoxProductAttributeUnitName";
            this.textBoxProductAttributeUnitName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeUnitName.TabIndex = 3;
            //
            // labelProductAttributeUnit
            //
            this.labelProductAttributeUnit.AutoSize = true;
            this.labelProductAttributeUnit.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeUnit.Name = "labelProductAttributeUnit";
            this.labelProductAttributeUnit.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnit.TabIndex = 4;
            this.labelProductAttributeUnit.Text = "Product Attribute Unit:";
            //
            //textBoxProductAttributeUnit
            //
            this.textBoxProductAttributeUnit.Location = new System.Drawing.Point(189, 36);
            this.textBoxProductAttributeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductAttributeUnit.Name = "textBoxProductAttributeUnit";
            this.textBoxProductAttributeUnit.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductAttributeUnit.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductAttributeUnitRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductAttributeUnitRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductAttributeUnitRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductAttributeUnitRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductAttributeUnitRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductAttributeUnitRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductAttributeUnitRef.Name = "dataGridViewCrudeProductAttributeUnitRef";
            this.dataGridViewCrudeProductAttributeUnitRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeProductAttributeUnitRef.TabIndex = 0;
            this.dataGridViewCrudeProductAttributeUnitRef.ReadOnly = true;
            this.dataGridViewCrudeProductAttributeUnitRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductAttributeUnitRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductAttributeUnitRefSearch
            // 
            this.buttonCrudeProductAttributeUnitRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeUnitRefSearch.Location = new System.Drawing.Point(247, 195);
            this.buttonCrudeProductAttributeUnitRefSearch.Name = "buttonCrudeProductAttributeUnitRefSearch";
            this.buttonCrudeProductAttributeUnitRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeUnitRefSearch.TabIndex = 2;
            this.buttonCrudeProductAttributeUnitRefSearch.Text = "&Search";
            this.buttonCrudeProductAttributeUnitRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeUnitRefSearch.Click += new System.EventHandler(this.buttonCrudeProductAttributeUnitRefSearch_Click);
            // 
            // buttonCrudeProductAttributeUnitRefAdd
            // 
            this.buttonCrudeProductAttributeUnitRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeUnitRefAdd.Location = new System.Drawing.Point(147, 195);
            this.buttonCrudeProductAttributeUnitRefAdd.Name = "buttonCrudeProductAttributeUnitRefAdd";
            this.buttonCrudeProductAttributeUnitRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeUnitRefAdd.TabIndex = 3;
            this.buttonCrudeProductAttributeUnitRefAdd.Text = "&Add";
            this.buttonCrudeProductAttributeUnitRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeUnitRefAdd.Click += new System.EventHandler(this.buttonCrudeProductAttributeUnitRefAdd_Click);
            // 
            // buttonCrudeProductAttributeUnitRefEdit
            // 
            this.buttonCrudeProductAttributeUnitRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeUnitRefEdit.Location = new System.Drawing.Point(47, 195);
            this.buttonCrudeProductAttributeUnitRefEdit.Name = "buttonCrudeProductAttributeUnitRefEdit";
            this.buttonCrudeProductAttributeUnitRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeUnitRefEdit.TabIndex = 4;
            this.buttonCrudeProductAttributeUnitRefEdit.Text = "&Edit";
            this.buttonCrudeProductAttributeUnitRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeUnitRefEdit.Click += new System.EventHandler(this.buttonCrudeProductAttributeUnitRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 223);
            this.Controls.Add(this.buttonCrudeProductAttributeUnitRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductAttributeUnitRefAdd);
            this.Controls.Add(this.buttonCrudeProductAttributeUnitRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductAttributeUnitRef);
            this.Name = "CrudeProductAttributeUnitRefSearch";
            this.Text = "Product Attribute Unit Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttributeUnitRef)).EndInit();
            this.Controls.Add(this.labelProductAttributeUnitName);
            this.Controls.Add(this.textBoxProductAttributeUnitName);
            this.Controls.Add(this.labelProductAttributeUnit);
            this.Controls.Add(this.textBoxProductAttributeUnit);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
