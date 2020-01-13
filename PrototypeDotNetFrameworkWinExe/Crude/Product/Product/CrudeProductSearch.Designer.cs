namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProduct;
        
        private System.Windows.Forms.TextBox textBoxProductName;
        
        private System.Windows.Forms.Label labelProductName;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.buttonCrudeProductAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProduct = new System.Windows.Forms.DataGridView();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProduct)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductName
            //
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(11, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(71, 13);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product Name:";
            //
            //textBoxProductName
            //
            this.textBoxProductName.Location = new System.Drawing.Point(140, 13);
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductName.TabIndex = 3;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 36);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(140, 36);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 5;
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
            // dataGridViewCrudeProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProduct.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProduct.Name = "dataGridViewCrudeProduct";
            this.dataGridViewCrudeProduct.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProduct.TabIndex = 0;
            this.dataGridViewCrudeProduct.ReadOnly = true;
            this.dataGridViewCrudeProduct.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProduct_DoubleClick);
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
            // buttonCrudeProductSearch
            // 
            this.buttonCrudeProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeProductSearch.Name = "buttonCrudeProductSearch";
            this.buttonCrudeProductSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductSearch.TabIndex = 2;
            this.buttonCrudeProductSearch.Text = "&Search";
            this.buttonCrudeProductSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductSearch.Click += new System.EventHandler(this.buttonCrudeProductSearch_Click);
            // 
            // buttonCrudeProductAdd
            // 
            this.buttonCrudeProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeProductAdd.Name = "buttonCrudeProductAdd";
            this.buttonCrudeProductAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductAdd.TabIndex = 3;
            this.buttonCrudeProductAdd.Text = "&Add";
            this.buttonCrudeProductAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductAdd.Click += new System.EventHandler(this.buttonCrudeProductAdd_Click);
            // 
            // buttonCrudeProductEdit
            // 
            this.buttonCrudeProductEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeProductEdit.Name = "buttonCrudeProductEdit";
            this.buttonCrudeProductEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductEdit.TabIndex = 4;
            this.buttonCrudeProductEdit.Text = "&Edit";
            this.buttonCrudeProductEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductEdit.Click += new System.EventHandler(this.buttonCrudeProductEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeProductSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductAdd);
            this.Controls.Add(this.buttonCrudeProductEdit);
            this.Controls.Add(this.dataGridViewCrudeProduct);
            this.Name = "CrudeProductSearch";
            this.Text = "Product Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProduct)).EndInit();
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
