namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductFieldSetSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductFieldSetEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductFieldSet;
        
        private System.Windows.Forms.TextBox textBoxProductFieldSetName;
        
        private System.Windows.Forms.Label labelProductFieldSetName;
        
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
            this.buttonCrudeProductFieldSetAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductFieldSetEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductFieldSetSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductFieldSet = new System.Windows.Forms.DataGridView();
            this.labelProductFieldSetName = new System.Windows.Forms.Label();
            this.textBoxProductFieldSetName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductFieldSet)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductFieldSetName
            //
            this.labelProductFieldSetName.AutoSize = true;
            this.labelProductFieldSetName.Location = new System.Drawing.Point(11, 13);
            this.labelProductFieldSetName.Name = "labelProductFieldSetName";
            this.labelProductFieldSetName.Size = new System.Drawing.Size(71, 13);
            this.labelProductFieldSetName.TabIndex = 2;
            this.labelProductFieldSetName.Text = "Product Field Set Name:";
            //
            //textBoxProductFieldSetName
            //
            this.textBoxProductFieldSetName.Location = new System.Drawing.Point(154, 13);
            this.textBoxProductFieldSetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductFieldSetName.Name = "textBoxProductFieldSetName";
            this.textBoxProductFieldSetName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductFieldSetName.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeProductFieldSet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductFieldSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductFieldSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductFieldSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductFieldSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductFieldSet.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeProductFieldSet.Name = "dataGridViewCrudeProductFieldSet";
            this.dataGridViewCrudeProductFieldSet.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeProductFieldSet.TabIndex = 0;
            this.dataGridViewCrudeProductFieldSet.ReadOnly = true;
            this.dataGridViewCrudeProductFieldSet.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductFieldSet_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductFieldSetSearch
            // 
            this.buttonCrudeProductFieldSetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetSearch.Location = new System.Drawing.Point(212, 172);
            this.buttonCrudeProductFieldSetSearch.Name = "buttonCrudeProductFieldSetSearch";
            this.buttonCrudeProductFieldSetSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetSearch.TabIndex = 2;
            this.buttonCrudeProductFieldSetSearch.Text = "&Search";
            this.buttonCrudeProductFieldSetSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetSearch.Click += new System.EventHandler(this.buttonCrudeProductFieldSetSearch_Click);
            // 
            // buttonCrudeProductFieldSetAdd
            // 
            this.buttonCrudeProductFieldSetAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetAdd.Location = new System.Drawing.Point(112, 172);
            this.buttonCrudeProductFieldSetAdd.Name = "buttonCrudeProductFieldSetAdd";
            this.buttonCrudeProductFieldSetAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetAdd.TabIndex = 3;
            this.buttonCrudeProductFieldSetAdd.Text = "&Add";
            this.buttonCrudeProductFieldSetAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetAdd.Click += new System.EventHandler(this.buttonCrudeProductFieldSetAdd_Click);
            // 
            // buttonCrudeProductFieldSetEdit
            // 
            this.buttonCrudeProductFieldSetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductFieldSetEdit.Location = new System.Drawing.Point(12, 172);
            this.buttonCrudeProductFieldSetEdit.Name = "buttonCrudeProductFieldSetEdit";
            this.buttonCrudeProductFieldSetEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductFieldSetEdit.TabIndex = 4;
            this.buttonCrudeProductFieldSetEdit.Text = "&Edit";
            this.buttonCrudeProductFieldSetEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductFieldSetEdit.Click += new System.EventHandler(this.buttonCrudeProductFieldSetEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 200);
            this.Controls.Add(this.buttonCrudeProductFieldSetSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductFieldSetAdd);
            this.Controls.Add(this.buttonCrudeProductFieldSetEdit);
            this.Controls.Add(this.dataGridViewCrudeProductFieldSet);
            this.Name = "CrudeProductFieldSetSearch";
            this.Text = "Product Field Set Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductFieldSet)).EndInit();
            this.Controls.Add(this.labelProductFieldSetName);
            this.Controls.Add(this.textBoxProductFieldSetName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
