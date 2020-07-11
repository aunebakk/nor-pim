namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryMappingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryMappingSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryMappingAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductCategoryMappingEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryMapping;
        
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
            this.buttonCrudeProductCategoryMappingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryMappingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryMappingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryMapping = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryMapping)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            // 
            // dataGridViewCrudeProductCategoryMapping
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryMapping.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategoryMapping.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewCrudeProductCategoryMapping.Name = "dataGridViewCrudeProductCategoryMapping";
            this.dataGridViewCrudeProductCategoryMapping.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductCategoryMapping.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryMapping.ReadOnly = true;
            this.dataGridViewCrudeProductCategoryMapping.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryMapping_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 149);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategoryMappingSearch
            // 
            this.buttonCrudeProductCategoryMappingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryMappingSearch.Location = new System.Drawing.Point(198, 149);
            this.buttonCrudeProductCategoryMappingSearch.Name = "buttonCrudeProductCategoryMappingSearch";
            this.buttonCrudeProductCategoryMappingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryMappingSearch.TabIndex = 2;
            this.buttonCrudeProductCategoryMappingSearch.Text = "&Search";
            this.buttonCrudeProductCategoryMappingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryMappingSearch.Click += new System.EventHandler(this.buttonCrudeProductCategoryMappingSearch_Click);
            // 
            // buttonCrudeProductCategoryMappingAdd
            // 
            this.buttonCrudeProductCategoryMappingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryMappingAdd.Location = new System.Drawing.Point(98, 149);
            this.buttonCrudeProductCategoryMappingAdd.Name = "buttonCrudeProductCategoryMappingAdd";
            this.buttonCrudeProductCategoryMappingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryMappingAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryMappingAdd.Text = "&Add";
            this.buttonCrudeProductCategoryMappingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryMappingAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryMappingAdd_Click);
            // 
            // buttonCrudeProductCategoryMappingEdit
            // 
            this.buttonCrudeProductCategoryMappingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryMappingEdit.Location = new System.Drawing.Point(-2, 149);
            this.buttonCrudeProductCategoryMappingEdit.Name = "buttonCrudeProductCategoryMappingEdit";
            this.buttonCrudeProductCategoryMappingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryMappingEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryMappingEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryMappingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryMappingEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryMappingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.buttonCrudeProductCategoryMappingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryMappingAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryMappingEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryMapping);
            this.Name = "CrudeProductCategoryMappingSearch";
            this.Text = "Product Category Mapping Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryMapping)).EndInit();
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
