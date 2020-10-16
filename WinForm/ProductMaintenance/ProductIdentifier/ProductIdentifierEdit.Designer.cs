namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductIdentifierEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ProductIdentifierRefCombo productIdentifierRefCombo;

        private System.Windows.Forms.Label labelProductIdentifierRefCombo;

        private System.Windows.Forms.TextBox textBoxIdentifier;

        private System.Windows.Forms.Label labelIdentifier;

        private System.Windows.Forms.TextBox dateTimePickerDateTime;

        private System.Windows.Forms.Label labelDateTime;

        private System.Windows.Forms.Button buttonProductIdentifierSearch;

        private System.Windows.Forms.Button buttonProductIdentifierAdd;

        private System.Windows.Forms.Button buttonProductIdentifierEdit;

        private System.Windows.Forms.DataGridView dataGridViewProductIdentifier;

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
            this.buttonProductIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonProductIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonProductIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewProductIdentifier = new System.Windows.Forms.DataGridView();
            this.labelProductIdentifierRefCombo = new System.Windows.Forms.Label();
            this.productIdentifierRefCombo = new ProductIdentifierRefCombo();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.textBoxIdentifier = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIdentifier)).BeginInit();
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
            this.productIdentifierRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productIdentifierRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productIdentifierRefCombo.Name = "productIdentifierRefCombo";
            this.productIdentifierRefCombo.Size = new System.Drawing.Size(350, 20);
            this.productIdentifierRefCombo.TabIndex = 3;
            //
            // labelIdentifier
            //
            this.labelIdentifier.AutoSize = true;
            this.labelIdentifier.Location = new System.Drawing.Point(11, 36);
            this.labelIdentifier.Name = "labelIdentifier";
            this.labelIdentifier.Size = new System.Drawing.Size(71, 13);
            this.labelIdentifier.TabIndex = 4;
            this.labelIdentifier.Text = "Identifier:";
            //
            //textBoxIdentifier
            //
            this.textBoxIdentifier.Location = new System.Drawing.Point(140, 36);
            this.textBoxIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdentifier.Name = "textBoxIdentifier";
            this.textBoxIdentifier.Size = new System.Drawing.Size(350, 20);
            this.textBoxIdentifier.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewProductIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductIdentifier.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewProductIdentifier.Name = "dataGridViewProductIdentifier";
            this.dataGridViewProductIdentifier.Size = new System.Drawing.Size(478, 96);
            this.dataGridViewProductIdentifier.TabIndex = 0;
            this.dataGridViewProductIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewProductIdentifier_DoubleClick);
            // 
            // buttonProductIdentifierSearch
            // 
            this.buttonProductIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductIdentifierSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonProductIdentifierSearch.Name = "buttonProductIdentifierSearch";
            this.buttonProductIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductIdentifierSearch.TabIndex = 2;
            this.buttonProductIdentifierSearch.Text = "&Search";
            this.buttonProductIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonProductIdentifierSearch.Click += new System.EventHandler(this.buttonProductIdentifierSearch_Click);
            // 
            // buttonProductIdentifierAdd
            // 
            this.buttonProductIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductIdentifierAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonProductIdentifierAdd.Name = "buttonProductIdentifierAdd";
            this.buttonProductIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductIdentifierAdd.TabIndex = 3;
            this.buttonProductIdentifierAdd.Text = "&Add";
            this.buttonProductIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonProductIdentifierAdd.Click += new System.EventHandler(this.buttonProductIdentifierAdd_Click);
            // 
            // buttonProductIdentifierEdit
            // 
            this.buttonProductIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductIdentifierEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonProductIdentifierEdit.Name = "buttonProductIdentifierEdit";
            this.buttonProductIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductIdentifierEdit.TabIndex = 4;
            this.buttonProductIdentifierEdit.Text = "&Edit";
            this.buttonProductIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonProductIdentifierEdit.Click += new System.EventHandler(this.buttonProductIdentifierEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(398, 195);

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
            this.buttonSave.Location = new System.Drawing.Point(298, 195);
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
            this.ClientSize = new System.Drawing.Size(502, 223);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductIdentifierSearch);
            this.Controls.Add(this.buttonProductIdentifierAdd);
            this.Controls.Add(this.buttonProductIdentifierEdit);
            this.Controls.Add(this.dataGridViewProductIdentifier);
            this.Name = "ProductIdentifierEdit";
            this.Text = "Product Identifier Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIdentifier)).EndInit();
            this.Controls.Add(this.labelProductIdentifierRefCombo);
            this.Controls.Add(this.productIdentifierRefCombo);
            this.Controls.Add(this.labelIdentifier);
            this.Controls.Add(this.textBoxIdentifier);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
