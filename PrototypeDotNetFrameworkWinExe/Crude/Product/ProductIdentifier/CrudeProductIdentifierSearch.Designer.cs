namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductIdentifier;
        
        private ProductIdentifierRefCombo productIdentifierRefCombo;
        
        private System.Windows.Forms.Label labelProductIdentifierRefCombo;
        
        private System.Windows.Forms.TextBox textBoxIdentifier;
        
        private System.Windows.Forms.Label labelIdentifier;
        
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
            this.buttonCrudeProductIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductIdentifier = new System.Windows.Forms.DataGridView();
            this.labelProductIdentifierRefCombo = new System.Windows.Forms.Label();
            this.productIdentifierRefCombo = new ProductIdentifierRefCombo();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.textBoxIdentifier = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductIdentifier)).BeginInit();
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
            this.productIdentifierRefCombo.Size = new System.Drawing.Size(250, 20);
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
            this.textBoxIdentifier.Size = new System.Drawing.Size(250, 20);
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
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductIdentifier.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductIdentifier.Name = "dataGridViewCrudeProductIdentifier";
            this.dataGridViewCrudeProductIdentifier.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductIdentifier.TabIndex = 0;
            this.dataGridViewCrudeProductIdentifier.ReadOnly = true;
            this.dataGridViewCrudeProductIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductIdentifierSearch
            // 
            this.buttonCrudeProductIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeProductIdentifierSearch.Name = "buttonCrudeProductIdentifierSearch";
            this.buttonCrudeProductIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierSearch.TabIndex = 2;
            this.buttonCrudeProductIdentifierSearch.Text = "&Search";
            this.buttonCrudeProductIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeProductIdentifierSearch_Click);
            // 
            // buttonCrudeProductIdentifierAdd
            // 
            this.buttonCrudeProductIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeProductIdentifierAdd.Name = "buttonCrudeProductIdentifierAdd";
            this.buttonCrudeProductIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierAdd.TabIndex = 3;
            this.buttonCrudeProductIdentifierAdd.Text = "&Add";
            this.buttonCrudeProductIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeProductIdentifierAdd_Click);
            // 
            // buttonCrudeProductIdentifierEdit
            // 
            this.buttonCrudeProductIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeProductIdentifierEdit.Name = "buttonCrudeProductIdentifierEdit";
            this.buttonCrudeProductIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierEdit.TabIndex = 4;
            this.buttonCrudeProductIdentifierEdit.Text = "&Edit";
            this.buttonCrudeProductIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeProductIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeProductIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductIdentifierAdd);
            this.Controls.Add(this.buttonCrudeProductIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeProductIdentifier);
            this.Name = "CrudeProductIdentifierSearch";
            this.Text = "Product Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductIdentifier)).EndInit();
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
