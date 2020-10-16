namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductCategoryDocumentationSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationSearch;

        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationAdd;

        private System.Windows.Forms.Button buttonCrudeProductCategoryDocumentationEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductCategoryDocumentation;

        private ProductCategoryDocumentationTypeRefCombo productCategoryDocumentationTypeRefCombo;

        private System.Windows.Forms.Label labelProductCategoryDocumentationTypeRefCombo;

        private System.Windows.Forms.TextBox textBoxDocumentation;

        private System.Windows.Forms.Label labelDocumentation;

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
            this.buttonCrudeProductCategoryDocumentationAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryDocumentationEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductCategoryDocumentationSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductCategoryDocumentation = new System.Windows.Forms.DataGridView();
            this.labelProductCategoryDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productCategoryDocumentationTypeRefCombo = new ProductCategoryDocumentationTypeRefCombo();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.textBoxDocumentation = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentation)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductCategoryDocumentationTypeRefCombo
            //
            this.labelProductCategoryDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.Name = "labelProductCategoryDocumentationTypeRefCombo";
            this.labelProductCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductCategoryDocumentationTypeRefCombo.TabIndex = 2;
            this.labelProductCategoryDocumentationTypeRefCombo.Text = "Product Category Documentation Type:";
            //
            //productCategoryDocumentationTypeRefCombo
            //
            this.productCategoryDocumentationTypeRefCombo.Location = new System.Drawing.Point(245, 13);
            this.productCategoryDocumentationTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoryDocumentationTypeRefCombo.Name = "productCategoryDocumentationTypeRefCombo";
            this.productCategoryDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productCategoryDocumentationTypeRefCombo.TabIndex = 3;
            //
            // labelDocumentation
            //
            this.labelDocumentation.AutoSize = true;
            this.labelDocumentation.Location = new System.Drawing.Point(11, 36);
            this.labelDocumentation.Name = "labelDocumentation";
            this.labelDocumentation.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentation.TabIndex = 4;
            this.labelDocumentation.Text = "Documentation:";
            //
            //textBoxDocumentation
            //
            this.textBoxDocumentation.Location = new System.Drawing.Point(245, 36);
            this.textBoxDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocumentation.Name = "textBoxDocumentation";
            this.textBoxDocumentation.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentation.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(245, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductCategoryDocumentation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductCategoryDocumentation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductCategoryDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductCategoryDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductCategoryDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductCategoryDocumentation.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductCategoryDocumentation.Name = "dataGridViewCrudeProductCategoryDocumentation";
            this.dataGridViewCrudeProductCategoryDocumentation.Size = new System.Drawing.Size(483, 96);
            this.dataGridViewCrudeProductCategoryDocumentation.TabIndex = 0;
            this.dataGridViewCrudeProductCategoryDocumentation.ReadOnly = true;
            this.dataGridViewCrudeProductCategoryDocumentation.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductCategoryDocumentation_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(403, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductCategoryDocumentationSearch
            // 
            this.buttonCrudeProductCategoryDocumentationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationSearch.Location = new System.Drawing.Point(303, 195);
            this.buttonCrudeProductCategoryDocumentationSearch.Name = "buttonCrudeProductCategoryDocumentationSearch";
            this.buttonCrudeProductCategoryDocumentationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationSearch.TabIndex = 2;
            this.buttonCrudeProductCategoryDocumentationSearch.Text = "&Search";
            this.buttonCrudeProductCategoryDocumentationSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationSearch.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationSearch_Click);
            // 
            // buttonCrudeProductCategoryDocumentationAdd
            // 
            this.buttonCrudeProductCategoryDocumentationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationAdd.Location = new System.Drawing.Point(203, 195);
            this.buttonCrudeProductCategoryDocumentationAdd.Name = "buttonCrudeProductCategoryDocumentationAdd";
            this.buttonCrudeProductCategoryDocumentationAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationAdd.TabIndex = 3;
            this.buttonCrudeProductCategoryDocumentationAdd.Text = "&Add";
            this.buttonCrudeProductCategoryDocumentationAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationAdd.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationAdd_Click);
            // 
            // buttonCrudeProductCategoryDocumentationEdit
            // 
            this.buttonCrudeProductCategoryDocumentationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductCategoryDocumentationEdit.Location = new System.Drawing.Point(103, 195);
            this.buttonCrudeProductCategoryDocumentationEdit.Name = "buttonCrudeProductCategoryDocumentationEdit";
            this.buttonCrudeProductCategoryDocumentationEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductCategoryDocumentationEdit.TabIndex = 4;
            this.buttonCrudeProductCategoryDocumentationEdit.Text = "&Edit";
            this.buttonCrudeProductCategoryDocumentationEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductCategoryDocumentationEdit.Click += new System.EventHandler(this.buttonCrudeProductCategoryDocumentationEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 223);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationAdd);
            this.Controls.Add(this.buttonCrudeProductCategoryDocumentationEdit);
            this.Controls.Add(this.dataGridViewCrudeProductCategoryDocumentation);
            this.Name = "CrudeProductCategoryDocumentationSearch";
            this.Text = "Product Category Documentation Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductCategoryDocumentation)).EndInit();
            this.Controls.Add(this.labelProductCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.productCategoryDocumentationTypeRefCombo);
            this.Controls.Add(this.labelDocumentation);
            this.Controls.Add(this.textBoxDocumentation);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
