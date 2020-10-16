namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherAttributeSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeSearch;

        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeAdd;

        private System.Windows.Forms.Button buttonCrudeProductGatherAttributeEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherAttribute;

        private System.Windows.Forms.TextBox textBoxProductGatherAttributeValue;

        private System.Windows.Forms.Label labelProductGatherAttributeValue;

        private ProductGatherAttributeTypeRefCombo productGatherAttributeTypeRefCombo;

        private System.Windows.Forms.Label labelProductGatherAttributeTypeRefCombo;

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
            this.buttonCrudeProductGatherAttributeAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherAttributeEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherAttributeSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGatherAttribute = new System.Windows.Forms.DataGridView();
            this.labelProductGatherAttributeValue = new System.Windows.Forms.Label();
            this.textBoxProductGatherAttributeValue = new System.Windows.Forms.TextBox();
            this.labelProductGatherAttributeTypeRefCombo = new System.Windows.Forms.Label();
            this.productGatherAttributeTypeRefCombo = new ProductGatherAttributeTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherAttribute)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherAttributeValue
            //
            this.labelProductGatherAttributeValue.AutoSize = true;
            this.labelProductGatherAttributeValue.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherAttributeValue.Name = "labelProductGatherAttributeValue";
            this.labelProductGatherAttributeValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeValue.TabIndex = 2;
            this.labelProductGatherAttributeValue.Text = "Product Gather Attribute Value:";
            //
            //textBoxProductGatherAttributeValue
            //
            this.textBoxProductGatherAttributeValue.Location = new System.Drawing.Point(210, 13);
            this.textBoxProductGatherAttributeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherAttributeValue.Name = "textBoxProductGatherAttributeValue";
            this.textBoxProductGatherAttributeValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherAttributeValue.TabIndex = 3;
            //
            // labelProductGatherAttributeTypeRefCombo
            //
            this.labelProductGatherAttributeTypeRefCombo.AutoSize = true;
            this.labelProductGatherAttributeTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherAttributeTypeRefCombo.Name = "labelProductGatherAttributeTypeRefCombo";
            this.labelProductGatherAttributeTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherAttributeTypeRefCombo.TabIndex = 4;
            this.labelProductGatherAttributeTypeRefCombo.Text = "Product Gather Attribute Type:";
            //
            //productGatherAttributeTypeRefCombo
            //
            this.productGatherAttributeTypeRefCombo.Location = new System.Drawing.Point(210, 36);
            this.productGatherAttributeTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productGatherAttributeTypeRefCombo.Name = "productGatherAttributeTypeRefCombo";
            this.productGatherAttributeTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productGatherAttributeTypeRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductGatherAttribute
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherAttribute.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherAttribute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGatherAttribute.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductGatherAttribute.Name = "dataGridViewCrudeProductGatherAttribute";
            this.dataGridViewCrudeProductGatherAttribute.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeProductGatherAttribute.TabIndex = 0;
            this.dataGridViewCrudeProductGatherAttribute.ReadOnly = true;
            this.dataGridViewCrudeProductGatherAttribute.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherAttribute_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductGatherAttributeSearch
            // 
            this.buttonCrudeProductGatherAttributeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeSearch.Location = new System.Drawing.Point(268, 195);
            this.buttonCrudeProductGatherAttributeSearch.Name = "buttonCrudeProductGatherAttributeSearch";
            this.buttonCrudeProductGatherAttributeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeSearch.TabIndex = 2;
            this.buttonCrudeProductGatherAttributeSearch.Text = "&Search";
            this.buttonCrudeProductGatherAttributeSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeSearch.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeSearch_Click);
            // 
            // buttonCrudeProductGatherAttributeAdd
            // 
            this.buttonCrudeProductGatherAttributeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeAdd.Location = new System.Drawing.Point(168, 195);
            this.buttonCrudeProductGatherAttributeAdd.Name = "buttonCrudeProductGatherAttributeAdd";
            this.buttonCrudeProductGatherAttributeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeAdd.TabIndex = 3;
            this.buttonCrudeProductGatherAttributeAdd.Text = "&Add";
            this.buttonCrudeProductGatherAttributeAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeAdd_Click);
            // 
            // buttonCrudeProductGatherAttributeEdit
            // 
            this.buttonCrudeProductGatherAttributeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAttributeEdit.Location = new System.Drawing.Point(68, 195);
            this.buttonCrudeProductGatherAttributeEdit.Name = "buttonCrudeProductGatherAttributeEdit";
            this.buttonCrudeProductGatherAttributeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAttributeEdit.TabIndex = 4;
            this.buttonCrudeProductGatherAttributeEdit.Text = "&Edit";
            this.buttonCrudeProductGatherAttributeEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAttributeEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherAttributeEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 223);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeAdd);
            this.Controls.Add(this.buttonCrudeProductGatherAttributeEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGatherAttribute);
            this.Name = "CrudeProductGatherAttributeSearch";
            this.Text = "Product Gather Attribute Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherAttribute)).EndInit();
            this.Controls.Add(this.labelProductGatherAttributeValue);
            this.Controls.Add(this.textBoxProductGatherAttributeValue);
            this.Controls.Add(this.labelProductGatherAttributeTypeRefCombo);
            this.Controls.Add(this.productGatherAttributeTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
