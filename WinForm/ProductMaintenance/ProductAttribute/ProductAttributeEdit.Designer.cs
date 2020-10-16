namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductAttributeEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ProductAttributeRefCombo productAttributeRefCombo;

        private System.Windows.Forms.Label labelProductAttributeRefCombo;

        private ProductAttributeUnitRefCombo productAttributeUnitRefCombo;

        private System.Windows.Forms.Label labelProductAttributeUnitRefCombo;

        private System.Windows.Forms.TextBox textBoxValue;

        private System.Windows.Forms.Label labelValue;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private System.Windows.Forms.Button buttonProductAttributeSearch;

        private System.Windows.Forms.Button buttonProductAttributeAdd;

        private System.Windows.Forms.Button buttonProductAttributeEdit;

        private System.Windows.Forms.DataGridView dataGridViewProductAttribute;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonProductAttributeAdd = new System.Windows.Forms.Button();
            this.buttonProductAttributeEdit = new System.Windows.Forms.Button();
            this.buttonProductAttributeSearch = new System.Windows.Forms.Button();
            this.dataGridViewProductAttribute = new System.Windows.Forms.DataGridView();
            this.labelProductAttributeRefCombo = new System.Windows.Forms.Label();
            this.productAttributeRefCombo = new ProductAttributeRefCombo();
            this.labelProductAttributeUnitRefCombo = new System.Windows.Forms.Label();
            this.productAttributeUnitRefCombo = new ProductAttributeUnitRefCombo();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAttribute)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductAttributeRefCombo
            //
            this.labelProductAttributeRefCombo.AutoSize = true;
            this.labelProductAttributeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductAttributeRefCombo.Name = "labelProductAttributeRefCombo";
            this.labelProductAttributeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeRefCombo.TabIndex = 2;
            this.labelProductAttributeRefCombo.Text = "Product Attribute:";
            //
            //productAttributeRefCombo
            //
            this.productAttributeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.productAttributeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productAttributeRefCombo.Name = "productAttributeRefCombo";
            this.productAttributeRefCombo.Size = new System.Drawing.Size(350, 20);
            this.productAttributeRefCombo.TabIndex = 3;
            //
            // labelProductAttributeUnitRefCombo
            //
            this.labelProductAttributeUnitRefCombo.AutoSize = true;
            this.labelProductAttributeUnitRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductAttributeUnitRefCombo.Name = "labelProductAttributeUnitRefCombo";
            this.labelProductAttributeUnitRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductAttributeUnitRefCombo.TabIndex = 4;
            this.labelProductAttributeUnitRefCombo.Text = "Product Attribute Unit:";
            //
            //productAttributeUnitRefCombo
            //
            this.productAttributeUnitRefCombo.Location = new System.Drawing.Point(154, 36);
            this.productAttributeUnitRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productAttributeUnitRefCombo.Name = "productAttributeUnitRefCombo";
            this.productAttributeUnitRefCombo.Size = new System.Drawing.Size(350, 20);
            this.productAttributeUnitRefCombo.TabIndex = 5;
            //
            // labelValue
            //
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(11, 59);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(71, 13);
            this.labelValue.TabIndex = 6;
            this.labelValue.Text = "Value:";
            //
            //textBoxValue
            //
            this.textBoxValue.Location = new System.Drawing.Point(154, 59);
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(350, 20);
            this.textBoxValue.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewProductAttribute
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductAttribute.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductAttribute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductAttribute.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewProductAttribute.Name = "dataGridViewProductAttribute";
            this.dataGridViewProductAttribute.Size = new System.Drawing.Size(492, 96);
            this.dataGridViewProductAttribute.TabIndex = 0;
            this.dataGridViewProductAttribute.DoubleClick += new System.EventHandler(this.dataGridViewProductAttribute_DoubleClick);
            // 
            // buttonProductAttributeSearch
            // 
            this.buttonProductAttributeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductAttributeSearch.Location = new System.Drawing.Point(212, 218);
            this.buttonProductAttributeSearch.Name = "buttonProductAttributeSearch";
            this.buttonProductAttributeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductAttributeSearch.TabIndex = 2;
            this.buttonProductAttributeSearch.Text = "&Search";
            this.buttonProductAttributeSearch.UseVisualStyleBackColor = true;
            this.buttonProductAttributeSearch.Click += new System.EventHandler(this.buttonProductAttributeSearch_Click);
            // 
            // buttonProductAttributeAdd
            // 
            this.buttonProductAttributeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductAttributeAdd.Location = new System.Drawing.Point(112, 218);
            this.buttonProductAttributeAdd.Name = "buttonProductAttributeAdd";
            this.buttonProductAttributeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductAttributeAdd.TabIndex = 3;
            this.buttonProductAttributeAdd.Text = "&Add";
            this.buttonProductAttributeAdd.UseVisualStyleBackColor = true;
            this.buttonProductAttributeAdd.Click += new System.EventHandler(this.buttonProductAttributeAdd_Click);
            // 
            // buttonProductAttributeEdit
            // 
            this.buttonProductAttributeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductAttributeEdit.Location = new System.Drawing.Point(12, 218);
            this.buttonProductAttributeEdit.Name = "buttonProductAttributeEdit";
            this.buttonProductAttributeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductAttributeEdit.TabIndex = 4;
            this.buttonProductAttributeEdit.Text = "&Edit";
            this.buttonProductAttributeEdit.UseVisualStyleBackColor = true;
            this.buttonProductAttributeEdit.Click += new System.EventHandler(this.buttonProductAttributeEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(412, 218);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(312, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 246);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductAttributeSearch);
            this.Controls.Add(this.buttonProductAttributeAdd);
            this.Controls.Add(this.buttonProductAttributeEdit);
            this.Controls.Add(this.dataGridViewProductAttribute);
            this.Name = "ProductAttributeEdit";
            this.Text = "Product Attribute Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAttribute)).EndInit();
            this.Controls.Add(this.labelProductAttributeRefCombo);
            this.Controls.Add(this.productAttributeRefCombo);
            this.Controls.Add(this.labelProductAttributeUnitRefCombo);
            this.Controls.Add(this.productAttributeUnitRefCombo);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
