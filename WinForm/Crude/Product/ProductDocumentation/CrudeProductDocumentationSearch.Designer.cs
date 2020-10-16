namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductDocumentationSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationSearch;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationAdd;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductDocumentation;

        private ProductDocumentationTypeRefCombo productDocumentationTypeRefCombo;

        private System.Windows.Forms.Label labelProductDocumentationTypeRefCombo;

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
            this.buttonCrudeProductDocumentationAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductDocumentationEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductDocumentationSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductDocumentation = new System.Windows.Forms.DataGridView();
            this.labelProductDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productDocumentationTypeRefCombo = new ProductDocumentationTypeRefCombo();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.textBoxDocumentation = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentation)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductDocumentationTypeRefCombo
            //
            this.labelProductDocumentationTypeRefCombo.AutoSize = true;
            this.labelProductDocumentationTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductDocumentationTypeRefCombo.Name = "labelProductDocumentationTypeRefCombo";
            this.labelProductDocumentationTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeRefCombo.TabIndex = 2;
            this.labelProductDocumentationTypeRefCombo.Text = "Product Documentation Type:";
            //
            //productDocumentationTypeRefCombo
            //
            this.productDocumentationTypeRefCombo.Location = new System.Drawing.Point(182, 13);
            this.productDocumentationTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productDocumentationTypeRefCombo.Name = "productDocumentationTypeRefCombo";
            this.productDocumentationTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productDocumentationTypeRefCombo.TabIndex = 3;
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
            this.textBoxDocumentation.Location = new System.Drawing.Point(182, 36);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductDocumentation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductDocumentation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductDocumentation.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductDocumentation.Name = "dataGridViewCrudeProductDocumentation";
            this.dataGridViewCrudeProductDocumentation.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeProductDocumentation.TabIndex = 0;
            this.dataGridViewCrudeProductDocumentation.ReadOnly = true;
            this.dataGridViewCrudeProductDocumentation.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductDocumentation_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductDocumentationSearch
            // 
            this.buttonCrudeProductDocumentationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeProductDocumentationSearch.Name = "buttonCrudeProductDocumentationSearch";
            this.buttonCrudeProductDocumentationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationSearch.TabIndex = 2;
            this.buttonCrudeProductDocumentationSearch.Text = "&Search";
            this.buttonCrudeProductDocumentationSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationSearch.Click += new System.EventHandler(this.buttonCrudeProductDocumentationSearch_Click);
            // 
            // buttonCrudeProductDocumentationAdd
            // 
            this.buttonCrudeProductDocumentationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeProductDocumentationAdd.Name = "buttonCrudeProductDocumentationAdd";
            this.buttonCrudeProductDocumentationAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationAdd.TabIndex = 3;
            this.buttonCrudeProductDocumentationAdd.Text = "&Add";
            this.buttonCrudeProductDocumentationAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationAdd.Click += new System.EventHandler(this.buttonCrudeProductDocumentationAdd_Click);
            // 
            // buttonCrudeProductDocumentationEdit
            // 
            this.buttonCrudeProductDocumentationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeProductDocumentationEdit.Name = "buttonCrudeProductDocumentationEdit";
            this.buttonCrudeProductDocumentationEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationEdit.TabIndex = 4;
            this.buttonCrudeProductDocumentationEdit.Text = "&Edit";
            this.buttonCrudeProductDocumentationEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationEdit.Click += new System.EventHandler(this.buttonCrudeProductDocumentationEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeProductDocumentationSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductDocumentationAdd);
            this.Controls.Add(this.buttonCrudeProductDocumentationEdit);
            this.Controls.Add(this.dataGridViewCrudeProductDocumentation);
            this.Name = "CrudeProductDocumentationSearch";
            this.Text = "Product Documentation Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentation)).EndInit();
            this.Controls.Add(this.labelProductDocumentationTypeRefCombo);
            this.Controls.Add(this.productDocumentationTypeRefCombo);
            this.Controls.Add(this.labelDocumentation);
            this.Controls.Add(this.textBoxDocumentation);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
