namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductFieldSetMappingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetMappingSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetMappingAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetMappingEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductFieldSetMapping;
        
        private ProductIdentifierRefCombo productIdentifierRefCombo;
        
        private System.Windows.Forms.Label labelProductIdentifierRefCombo;
        
        private ProductAttributeRefCombo productAttributeRefCombo;
        
        private System.Windows.Forms.Label labelProductAttributeRefCombo;
        
        private ProductInfoRefCombo productInfoRefCombo;
        
        private System.Windows.Forms.Label labelProductInfoRefCombo;
        
        private ProductImageTypeRefCombo productImageTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductImageTypeRefCombo;
        
        private ProductDocumentationTypeRefCombo productDocumentationTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductDocumentationTypeRefCombo;
        
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
            this.buttonCrudeProductFieldSetMappingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductFieldSetMappingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductFieldSetMappingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductFieldSetMapping = new System.Windows.Forms.DataGridView();
            this.labelProductIdentifierRefCombo = new System.Windows.Forms.Label();
            this.productIdentifierRefCombo = new ProductIdentifierRefCombo();
            this.labelProductAttributeRefCombo = new System.Windows.Forms.Label();
            this.productAttributeRefCombo = new ProductAttributeRefCombo();
            this.labelProductInfoRefCombo = new System.Windows.Forms.Label();
            this.productInfoRefCombo = new ProductInfoRefCombo();
            this.labelProductImageTypeRefCombo = new System.Windows.Forms.Label();
            this.productImageTypeRefCombo = new ProductImageTypeRefCombo();
            this.labelProductDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productDocumentationTypeRefCombo = new ProductDocumentationTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductFieldSetMapping)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductIdentifierRefCombo
            //
            this.labelProductIdentifierRefCombo.AutoSize = true;
            this.labelProductIdentifierRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductIdentifierRefCombo.Name = "labelProductIdentifierRefCombo";
            this.labelProductIdentifierRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifierRefCombo.TabIndex = 2;
            this.labelProductIdentifierRefCombo.Text = "Product Identifier:";
            //
            //productIdentifierRefCombo
            //
            this.productIdentifierRefCombo.Location = new System.Drawing.Point(182, 13);
            this.productIdentifierRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productIdentifierRefCombo.Name = "productIdentifierRefCombo";
            this.productIdentifierRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productIdentifierRefCombo.TabIndex = 3;
            //
            // labelProductAttributeRefCombo
            //
            this.labelProductAttributeRefCombo.AutoSize = true;
            this.labelProductAttributeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeRefCombo.Name = "labelProductAttributeRefCombo";
            this.labelProductAttributeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeRefCombo.TabIndex = 4;
            this.labelProductAttributeRefCombo.Text = "Product Attribute:";
            //
            //productAttributeRefCombo
            //
            this.productAttributeRefCombo.Location = new System.Drawing.Point(182, 36);
            this.productAttributeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productAttributeRefCombo.Name = "productAttributeRefCombo";
            this.productAttributeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productAttributeRefCombo.TabIndex = 5;
            //
            // labelProductInfoRefCombo
            //
            this.labelProductInfoRefCombo.AutoSize = true;
            this.labelProductInfoRefCombo.Location = new System.Drawing.Point(11, 59);
            this.labelProductInfoRefCombo.Name = "labelProductInfoRefCombo";
            this.labelProductInfoRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoRefCombo.TabIndex = 6;
            this.labelProductInfoRefCombo.Text = "Product Info:";
            //
            //productInfoRefCombo
            //
            this.productInfoRefCombo.Location = new System.Drawing.Point(182, 59);
            this.productInfoRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productInfoRefCombo.Name = "productInfoRefCombo";
            this.productInfoRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productInfoRefCombo.TabIndex = 7;
            //
            // labelProductImageTypeRefCombo
            //
            this.labelProductImageTypeRefCombo.AutoSize = true;
            this.labelProductImageTypeRefCombo.Location = new System.Drawing.Point(11, 82);
            this.labelProductImageTypeRefCombo.Name = "labelProductImageTypeRefCombo";
            this.labelProductImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductImageTypeRefCombo.TabIndex = 8;
            this.labelProductImageTypeRefCombo.Text = "Product Image Type:";
            //
            //productImageTypeRefCombo
            //
            this.productImageTypeRefCombo.Location = new System.Drawing.Point(182, 82);
            this.productImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productImageTypeRefCombo.Name = "productImageTypeRefCombo";
            this.productImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productImageTypeRefCombo.TabIndex = 9;
            //
            // labelProductDocumentationTypeRefCombo
            //
            this.labelProductDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelProductDocumentationTypeRefCombo.Name = "labelProductDocumentationTypeRefCombo";
            this.labelProductDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeRefCombo.TabIndex = 10;
            this.labelProductDocumentationTypeRefCombo.Text = "Product Documentation Type:";
            //
            //productDocumentationTypeRefCombo
            //
            this.productDocumentationTypeRefCombo.Location = new System.Drawing.Point(182, 105);
            this.productDocumentationTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productDocumentationTypeRefCombo.Name = "productDocumentationTypeRefCombo";
            this.productDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productDocumentationTypeRefCombo.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // dataGridViewCrudeProductFieldSetMapping
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductFieldSetMapping.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductFieldSetMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductFieldSetMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductFieldSetMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductFieldSetMapping.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeProductFieldSetMapping.Name = "dataGridViewCrudeProductFieldSetMapping";
            this.dataGridViewCrudeProductFieldSetMapping.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeProductFieldSetMapping.TabIndex = 0;
            this.dataGridViewCrudeProductFieldSetMapping.ReadOnly = true;
            this.dataGridViewCrudeProductFieldSetMapping.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductFieldSetMapping_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductFieldSetMappingSearch
            // 
            this.buttonCrudeProductFieldSetMappingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetMappingSearch.Location = new System.Drawing.Point(240, 264);
            this.buttonCrudeProductFieldSetMappingSearch.Name = "buttonCrudeProductFieldSetMappingSearch";
            this.buttonCrudeProductFieldSetMappingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetMappingSearch.TabIndex = 2;
            this.buttonCrudeProductFieldSetMappingSearch.Text = "&Search";
            this.buttonCrudeProductFieldSetMappingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetMappingSearch.Click += new System.EventHandler(this.buttonCrudeProductFieldSetMappingSearch_Click);
            // 
            // buttonCrudeProductFieldSetMappingAdd
            // 
            this.buttonCrudeProductFieldSetMappingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetMappingAdd.Location = new System.Drawing.Point(140, 264);
            this.buttonCrudeProductFieldSetMappingAdd.Name = "buttonCrudeProductFieldSetMappingAdd";
            this.buttonCrudeProductFieldSetMappingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetMappingAdd.TabIndex = 3;
            this.buttonCrudeProductFieldSetMappingAdd.Text = "&Add";
            this.buttonCrudeProductFieldSetMappingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetMappingAdd.Click += new System.EventHandler(this.buttonCrudeProductFieldSetMappingAdd_Click);
            // 
            // buttonCrudeProductFieldSetMappingEdit
            // 
            this.buttonCrudeProductFieldSetMappingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetMappingEdit.Location = new System.Drawing.Point(40, 264);
            this.buttonCrudeProductFieldSetMappingEdit.Name = "buttonCrudeProductFieldSetMappingEdit";
            this.buttonCrudeProductFieldSetMappingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetMappingEdit.TabIndex = 4;
            this.buttonCrudeProductFieldSetMappingEdit.Text = "&Edit";
            this.buttonCrudeProductFieldSetMappingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetMappingEdit.Click += new System.EventHandler(this.buttonCrudeProductFieldSetMappingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 292);
            this.Controls.Add(this.buttonCrudeProductFieldSetMappingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductFieldSetMappingAdd);
            this.Controls.Add(this.buttonCrudeProductFieldSetMappingEdit);
            this.Controls.Add(this.dataGridViewCrudeProductFieldSetMapping);
            this.Name = "CrudeProductFieldSetMappingSearch";
            this.Text = "Product Field Set Mapping Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductFieldSetMapping)).EndInit();
            this.Controls.Add(this.labelProductIdentifierRefCombo);
            this.Controls.Add(this.productIdentifierRefCombo);
            this.Controls.Add(this.labelProductAttributeRefCombo);
            this.Controls.Add(this.productAttributeRefCombo);
            this.Controls.Add(this.labelProductInfoRefCombo);
            this.Controls.Add(this.productInfoRefCombo);
            this.Controls.Add(this.labelProductImageTypeRefCombo);
            this.Controls.Add(this.productImageTypeRefCombo);
            this.Controls.Add(this.labelProductDocumentationTypeRefCombo);
            this.Controls.Add(this.productDocumentationTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
