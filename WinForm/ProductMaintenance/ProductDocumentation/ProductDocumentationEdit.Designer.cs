namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductDocumentationEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ProductDocumentationTypeRefCombo productDocumentationTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductDocumentationTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxDocumentation;
        
        private System.Windows.Forms.Label labelDocumentation;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.Button buttonProductDocumentationSearch;
        
        private System.Windows.Forms.Button buttonProductDocumentationAdd;
        
        private System.Windows.Forms.Button buttonProductDocumentationEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewProductDocumentation;
        
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
            this.buttonProductDocumentationAdd = new System.Windows.Forms.Button();
            this.buttonProductDocumentationEdit = new System.Windows.Forms.Button();
            this.buttonProductDocumentationSearch = new System.Windows.Forms.Button();
            this.dataGridViewProductDocumentation = new System.Windows.Forms.DataGridView();
            this.labelProductDocumentationTypeRefCombo = new System.Windows.Forms.Label();
            this.productDocumentationTypeRefCombo = new ProductDocumentationTypeRefCombo();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.textBoxDocumentation = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDocumentation)).BeginInit();
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
            this.productDocumentationTypeRefCombo.Size = new System.Drawing.Size(350, 20);
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
            this.textBoxDocumentation.Size = new System.Drawing.Size(350, 20);
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
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewProductDocumentation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductDocumentation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductDocumentation.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewProductDocumentation.Name = "dataGridViewProductDocumentation";
            this.dataGridViewProductDocumentation.Size = new System.Drawing.Size(520, 96);
            this.dataGridViewProductDocumentation.TabIndex = 0;
            this.dataGridViewProductDocumentation.DoubleClick += new System.EventHandler(this.dataGridViewProductDocumentation_DoubleClick);
            // 
            // buttonProductDocumentationSearch
            // 
            this.buttonProductDocumentationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductDocumentationSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonProductDocumentationSearch.Name = "buttonProductDocumentationSearch";
            this.buttonProductDocumentationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductDocumentationSearch.TabIndex = 2;
            this.buttonProductDocumentationSearch.Text = "&Search";
            this.buttonProductDocumentationSearch.UseVisualStyleBackColor = true;
            this.buttonProductDocumentationSearch.Click += new System.EventHandler(this.buttonProductDocumentationSearch_Click);
            // 
            // buttonProductDocumentationAdd
            // 
            this.buttonProductDocumentationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductDocumentationAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonProductDocumentationAdd.Name = "buttonProductDocumentationAdd";
            this.buttonProductDocumentationAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductDocumentationAdd.TabIndex = 3;
            this.buttonProductDocumentationAdd.Text = "&Add";
            this.buttonProductDocumentationAdd.UseVisualStyleBackColor = true;
            this.buttonProductDocumentationAdd.Click += new System.EventHandler(this.buttonProductDocumentationAdd_Click);
            // 
            // buttonProductDocumentationEdit
            // 
            this.buttonProductDocumentationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductDocumentationEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonProductDocumentationEdit.Name = "buttonProductDocumentationEdit";
            this.buttonProductDocumentationEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductDocumentationEdit.TabIndex = 4;
            this.buttonProductDocumentationEdit.Text = "&Edit";
            this.buttonProductDocumentationEdit.UseVisualStyleBackColor = true;
            this.buttonProductDocumentationEdit.Click += new System.EventHandler(this.buttonProductDocumentationEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(440, 195);
            
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
            this.buttonSave.Location = new System.Drawing.Point(340, 195);
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
            this.ClientSize = new System.Drawing.Size(544, 223);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductDocumentationSearch);
            this.Controls.Add(this.buttonProductDocumentationAdd);
            this.Controls.Add(this.buttonProductDocumentationEdit);
            this.Controls.Add(this.dataGridViewProductDocumentation);
            this.Name = "ProductDocumentationEdit";
            this.Text = "Product Documentation Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDocumentation)).EndInit();
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
