namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductInfoSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductInfoSearch;
        
        private System.Windows.Forms.Button buttonProductInfoAdd;
        
        private System.Windows.Forms.Button buttonProductInfoEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewProductInfo;
        
        private ProductInfoRefCombo productInfoRefCombo;
        
        private System.Windows.Forms.Label labelProductInfoRefCombo;
        
        private System.Windows.Forms.TextBox textBoxProductInfoValue;
        
        private System.Windows.Forms.Label labelProductInfoValue;
        
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
            this.buttonProductInfoAdd = new System.Windows.Forms.Button();
            this.buttonProductInfoEdit = new System.Windows.Forms.Button();
            this.buttonProductInfoSearch = new System.Windows.Forms.Button();
            this.dataGridViewProductInfo = new System.Windows.Forms.DataGridView();
            this.labelProductInfoRefCombo = new System.Windows.Forms.Label();
            this.productInfoRefCombo = new ProductInfoRefCombo();
            this.labelProductInfoValue = new System.Windows.Forms.Label();
            this.textBoxProductInfoValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInfo)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductInfoRefCombo
            //
            this.labelProductInfoRefCombo.AutoSize = true;
            this.labelProductInfoRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductInfoRefCombo.Name = "labelProductInfoRefCombo";
            this.labelProductInfoRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoRefCombo.TabIndex = 2;
            this.labelProductInfoRefCombo.Text = "Product Info:";
            //
            //productInfoRefCombo
            //
            this.productInfoRefCombo.Location = new System.Drawing.Point(140, 13);
            this.productInfoRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productInfoRefCombo.Name = "productInfoRefCombo";
            this.productInfoRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productInfoRefCombo.TabIndex = 3;
            //
            // labelProductInfoValue
            //
            this.labelProductInfoValue.AutoSize = true;
            this.labelProductInfoValue.Location = new System.Drawing.Point(11, 36);
            this.labelProductInfoValue.Name = "labelProductInfoValue";
            this.labelProductInfoValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoValue.TabIndex = 4;
            this.labelProductInfoValue.Text = "Product Info Value:";
            //
            //textBoxProductInfoValue
            //
            this.textBoxProductInfoValue.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInfoValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfoValue.Name = "textBoxProductInfoValue";
            this.textBoxProductInfoValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfoValue.TabIndex = 5;
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
            // dataGridViewProductInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductInfo.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewProductInfo.Name = "dataGridViewProductInfo";
            this.dataGridViewProductInfo.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewProductInfo.TabIndex = 0;
            this.dataGridViewProductInfo.DoubleClick += new System.EventHandler(this.dataGridViewProductInfo_DoubleClick);
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
            // buttonProductInfoSearch
            // 
            this.buttonProductInfoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductInfoSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonProductInfoSearch.Name = "buttonProductInfoSearch";
            this.buttonProductInfoSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductInfoSearch.TabIndex = 2;
            this.buttonProductInfoSearch.Text = "&Search";
            this.buttonProductInfoSearch.UseVisualStyleBackColor = true;
            this.buttonProductInfoSearch.Click += new System.EventHandler(this.buttonProductInfoSearch_Click);
            // 
            // buttonProductInfoAdd
            // 
            this.buttonProductInfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductInfoAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonProductInfoAdd.Name = "buttonProductInfoAdd";
            this.buttonProductInfoAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductInfoAdd.TabIndex = 3;
            this.buttonProductInfoAdd.Text = "&Add";
            this.buttonProductInfoAdd.UseVisualStyleBackColor = true;
            this.buttonProductInfoAdd.Click += new System.EventHandler(this.buttonProductInfoAdd_Click);
            // 
            // buttonProductInfoEdit
            // 
            this.buttonProductInfoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductInfoEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonProductInfoEdit.Name = "buttonProductInfoEdit";
            this.buttonProductInfoEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductInfoEdit.TabIndex = 4;
            this.buttonProductInfoEdit.Text = "&Edit";
            this.buttonProductInfoEdit.UseVisualStyleBackColor = true;
            this.buttonProductInfoEdit.Click += new System.EventHandler(this.buttonProductInfoEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonProductInfoSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductInfoAdd);
            this.Controls.Add(this.buttonProductInfoEdit);
            this.Controls.Add(this.dataGridViewProductInfo);
            this.Name = "ProductInfoSearch";
            this.Text = "Product Info Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInfo)).EndInit();
            this.Controls.Add(this.labelProductInfoRefCombo);
            this.Controls.Add(this.productInfoRefCombo);
            this.Controls.Add(this.labelProductInfoValue);
            this.Controls.Add(this.textBoxProductInfoValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
