namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductAttributeSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductAttributeSearch;

        private System.Windows.Forms.Button buttonCrudeProductAttributeAdd;

        private System.Windows.Forms.Button buttonCrudeProductAttributeEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductAttribute;

        private ProductAttributeRefCombo productAttributeRefCombo;

        private System.Windows.Forms.Label labelProductAttributeRefCombo;

        private ProductAttributeUnitRefCombo productAttributeUnitRefCombo;

        private System.Windows.Forms.Label labelProductAttributeUnitRefCombo;

        private System.Windows.Forms.TextBox textBoxValue;

        private System.Windows.Forms.Label labelValue;

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
            this.buttonCrudeProductAttributeAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductAttributeSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductAttribute = new System.Windows.Forms.DataGridView();
            this.labelProductAttributeRefCombo = new System.Windows.Forms.Label();
            this.productAttributeRefCombo = new ProductAttributeRefCombo();
            this.labelProductAttributeUnitRefCombo = new System.Windows.Forms.Label();
            this.productAttributeUnitRefCombo = new ProductAttributeUnitRefCombo();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttribute)).BeginInit();
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
            this.productAttributeRefCombo.Size = new System.Drawing.Size(250, 20);
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
            this.productAttributeUnitRefCombo.Size = new System.Drawing.Size(250, 20);
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
            this.textBoxValue.Size = new System.Drawing.Size(250, 20);
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
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeProductAttribute
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductAttribute.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductAttribute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductAttribute.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeProductAttribute.Name = "dataGridViewCrudeProductAttribute";
            this.dataGridViewCrudeProductAttribute.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeProductAttribute.TabIndex = 0;
            this.dataGridViewCrudeProductAttribute.ReadOnly = true;
            this.dataGridViewCrudeProductAttribute.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductAttribute_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 218);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductAttributeSearch
            // 
            this.buttonCrudeProductAttributeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeSearch.Location = new System.Drawing.Point(212, 218);
            this.buttonCrudeProductAttributeSearch.Name = "buttonCrudeProductAttributeSearch";
            this.buttonCrudeProductAttributeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeSearch.TabIndex = 2;
            this.buttonCrudeProductAttributeSearch.Text = "&Search";
            this.buttonCrudeProductAttributeSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeSearch.Click += new System.EventHandler(this.buttonCrudeProductAttributeSearch_Click);
            // 
            // buttonCrudeProductAttributeAdd
            // 
            this.buttonCrudeProductAttributeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeAdd.Location = new System.Drawing.Point(112, 218);
            this.buttonCrudeProductAttributeAdd.Name = "buttonCrudeProductAttributeAdd";
            this.buttonCrudeProductAttributeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeAdd.TabIndex = 3;
            this.buttonCrudeProductAttributeAdd.Text = "&Add";
            this.buttonCrudeProductAttributeAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeAdd.Click += new System.EventHandler(this.buttonCrudeProductAttributeAdd_Click);
            // 
            // buttonCrudeProductAttributeEdit
            // 
            this.buttonCrudeProductAttributeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAttributeEdit.Location = new System.Drawing.Point(12, 218);
            this.buttonCrudeProductAttributeEdit.Name = "buttonCrudeProductAttributeEdit";
            this.buttonCrudeProductAttributeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAttributeEdit.TabIndex = 4;
            this.buttonCrudeProductAttributeEdit.Text = "&Edit";
            this.buttonCrudeProductAttributeEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAttributeEdit.Click += new System.EventHandler(this.buttonCrudeProductAttributeEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 246);
            this.Controls.Add(this.buttonCrudeProductAttributeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductAttributeAdd);
            this.Controls.Add(this.buttonCrudeProductAttributeEdit);
            this.Controls.Add(this.dataGridViewCrudeProductAttribute);
            this.Name = "CrudeProductAttributeSearch";
            this.Text = "Product Attribute Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductAttribute)).EndInit();
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
