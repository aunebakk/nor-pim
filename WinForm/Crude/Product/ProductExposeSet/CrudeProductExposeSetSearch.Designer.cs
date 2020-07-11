namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSetSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExposeSet;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetName;
        
        private System.Windows.Forms.Label labelProductExposeSetName;
        
        private ProductExposeSetTypeRefCombo productExposeSetTypeRefCombo;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeRefCombo;
        
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
            this.buttonCrudeProductExposeSetAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeSetEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeSetSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductExposeSet = new System.Windows.Forms.DataGridView();
            this.labelProductExposeSetName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetName = new System.Windows.Forms.TextBox();
            this.labelProductExposeSetTypeRefCombo = new System.Windows.Forms.Label();
            this.productExposeSetTypeRefCombo = new ProductExposeSetTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSet)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductExposeSetName
            //
            this.labelProductExposeSetName.AutoSize = true;
            this.labelProductExposeSetName.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetName.Name = "labelProductExposeSetName";
            this.labelProductExposeSetName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetName.TabIndex = 2;
            this.labelProductExposeSetName.Text = "Product Expose Set Name:";
            //
            //textBoxProductExposeSetName
            //
            this.textBoxProductExposeSetName.Location = new System.Drawing.Point(161, 13);
            this.textBoxProductExposeSetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductExposeSetName.Name = "textBoxProductExposeSetName";
            this.textBoxProductExposeSetName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetName.TabIndex = 3;
            //
            // labelProductExposeSetTypeRefCombo
            //
            this.labelProductExposeSetTypeRefCombo.AutoSize = true;
            this.labelProductExposeSetTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetTypeRefCombo.Name = "labelProductExposeSetTypeRefCombo";
            this.labelProductExposeSetTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeRefCombo.TabIndex = 4;
            this.labelProductExposeSetTypeRefCombo.Text = "Product Expose Set Type:";
            //
            //productExposeSetTypeRefCombo
            //
            this.productExposeSetTypeRefCombo.Location = new System.Drawing.Point(161, 36);
            this.productExposeSetTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productExposeSetTypeRefCombo.Name = "productExposeSetTypeRefCombo";
            this.productExposeSetTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.productExposeSetTypeRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductExposeSet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExposeSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExposeSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExposeSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExposeSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductExposeSet.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductExposeSet.Name = "dataGridViewCrudeProductExposeSet";
            this.dataGridViewCrudeProductExposeSet.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeProductExposeSet.TabIndex = 0;
            this.dataGridViewCrudeProductExposeSet.ReadOnly = true;
            this.dataGridViewCrudeProductExposeSet.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExposeSet_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductExposeSetSearch
            // 
            this.buttonCrudeProductExposeSetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeProductExposeSetSearch.Name = "buttonCrudeProductExposeSetSearch";
            this.buttonCrudeProductExposeSetSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetSearch.TabIndex = 2;
            this.buttonCrudeProductExposeSetSearch.Text = "&Search";
            this.buttonCrudeProductExposeSetSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetSearch.Click += new System.EventHandler(this.buttonCrudeProductExposeSetSearch_Click);
            // 
            // buttonCrudeProductExposeSetAdd
            // 
            this.buttonCrudeProductExposeSetAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeProductExposeSetAdd.Name = "buttonCrudeProductExposeSetAdd";
            this.buttonCrudeProductExposeSetAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetAdd.TabIndex = 3;
            this.buttonCrudeProductExposeSetAdd.Text = "&Add";
            this.buttonCrudeProductExposeSetAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetAdd.Click += new System.EventHandler(this.buttonCrudeProductExposeSetAdd_Click);
            // 
            // buttonCrudeProductExposeSetEdit
            // 
            this.buttonCrudeProductExposeSetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeProductExposeSetEdit.Name = "buttonCrudeProductExposeSetEdit";
            this.buttonCrudeProductExposeSetEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetEdit.TabIndex = 4;
            this.buttonCrudeProductExposeSetEdit.Text = "&Edit";
            this.buttonCrudeProductExposeSetEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetEdit.Click += new System.EventHandler(this.buttonCrudeProductExposeSetEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeProductExposeSetSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductExposeSetAdd);
            this.Controls.Add(this.buttonCrudeProductExposeSetEdit);
            this.Controls.Add(this.dataGridViewCrudeProductExposeSet);
            this.Name = "CrudeProductExposeSetSearch";
            this.Text = "Product Expose Set Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSet)).EndInit();
            this.Controls.Add(this.labelProductExposeSetName);
            this.Controls.Add(this.textBoxProductExposeSetName);
            this.Controls.Add(this.labelProductExposeSetTypeRefCombo);
            this.Controls.Add(this.productExposeSetTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
