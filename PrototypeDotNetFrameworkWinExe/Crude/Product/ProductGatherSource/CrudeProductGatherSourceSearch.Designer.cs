namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSourceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherSource;
        
        private ProductGatherSourceTypeRefCombo productGatherSourceTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeRefCombo;
        
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
            this.buttonCrudeProductGatherSourceAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherSourceEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherSourceSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGatherSource = new System.Windows.Forms.DataGridView();
            this.labelProductGatherSourceTypeRefCombo = new System.Windows.Forms.Label();
            this.productGatherSourceTypeRefCombo = new ProductGatherSourceTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSource)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherSourceTypeRefCombo
            //
            this.labelProductGatherSourceTypeRefCombo.AutoSize = true;
            this.labelProductGatherSourceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherSourceTypeRefCombo.Name = "labelProductGatherSourceTypeRefCombo";
            this.labelProductGatherSourceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeRefCombo.TabIndex = 2;
            this.labelProductGatherSourceTypeRefCombo.Text = "Product Gather Source Type:";
            //
            //productGatherSourceTypeRefCombo
            //
            this.productGatherSourceTypeRefCombo.Location = new System.Drawing.Point(182, 13);
            this.productGatherSourceTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productGatherSourceTypeRefCombo.Name = "productGatherSourceTypeRefCombo";
            this.productGatherSourceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productGatherSourceTypeRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeProductGatherSource
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGatherSource.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeProductGatherSource.Name = "dataGridViewCrudeProductGatherSource";
            this.dataGridViewCrudeProductGatherSource.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeProductGatherSource.TabIndex = 0;
            this.dataGridViewCrudeProductGatherSource.ReadOnly = true;
            this.dataGridViewCrudeProductGatherSource.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherSource_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductGatherSourceSearch
            // 
            this.buttonCrudeProductGatherSourceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceSearch.Location = new System.Drawing.Point(240, 172);
            this.buttonCrudeProductGatherSourceSearch.Name = "buttonCrudeProductGatherSourceSearch";
            this.buttonCrudeProductGatherSourceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceSearch.TabIndex = 2;
            this.buttonCrudeProductGatherSourceSearch.Text = "&Search";
            this.buttonCrudeProductGatherSourceSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceSearch.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceSearch_Click);
            // 
            // buttonCrudeProductGatherSourceAdd
            // 
            this.buttonCrudeProductGatherSourceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceAdd.Location = new System.Drawing.Point(140, 172);
            this.buttonCrudeProductGatherSourceAdd.Name = "buttonCrudeProductGatherSourceAdd";
            this.buttonCrudeProductGatherSourceAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceAdd.TabIndex = 3;
            this.buttonCrudeProductGatherSourceAdd.Text = "&Add";
            this.buttonCrudeProductGatherSourceAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceAdd_Click);
            // 
            // buttonCrudeProductGatherSourceEdit
            // 
            this.buttonCrudeProductGatherSourceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceEdit.Location = new System.Drawing.Point(40, 172);
            this.buttonCrudeProductGatherSourceEdit.Name = "buttonCrudeProductGatherSourceEdit";
            this.buttonCrudeProductGatherSourceEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceEdit.TabIndex = 4;
            this.buttonCrudeProductGatherSourceEdit.Text = "&Edit";
            this.buttonCrudeProductGatherSourceEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 200);
            this.Controls.Add(this.buttonCrudeProductGatherSourceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherSourceAdd);
            this.Controls.Add(this.buttonCrudeProductGatherSourceEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGatherSource);
            this.Name = "CrudeProductGatherSourceSearch";
            this.Text = "Product Gather Source Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSource)).EndInit();
            this.Controls.Add(this.labelProductGatherSourceTypeRefCombo);
            this.Controls.Add(this.productGatherSourceTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
