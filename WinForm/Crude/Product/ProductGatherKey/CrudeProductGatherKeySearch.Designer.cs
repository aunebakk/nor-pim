namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherKeySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherKeySearch;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherKeyAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherKeyEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherKey;
        
        private System.Windows.Forms.TextBox textBoxProductGatherKeyValue;
        
        private System.Windows.Forms.Label labelProductGatherKeyValue;
        
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
            this.buttonCrudeProductGatherKeyAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherKeyEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherKeySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGatherKey = new System.Windows.Forms.DataGridView();
            this.labelProductGatherKeyValue = new System.Windows.Forms.Label();
            this.textBoxProductGatherKeyValue = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherKey)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherKeyValue
            //
            this.labelProductGatherKeyValue.AutoSize = true;
            this.labelProductGatherKeyValue.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherKeyValue.Name = "labelProductGatherKeyValue";
            this.labelProductGatherKeyValue.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherKeyValue.TabIndex = 2;
            this.labelProductGatherKeyValue.Text = "Product Gather Key Value:";
            //
            //textBoxProductGatherKeyValue
            //
            this.textBoxProductGatherKeyValue.Location = new System.Drawing.Point(168, 13);
            this.textBoxProductGatherKeyValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherKeyValue.Name = "textBoxProductGatherKeyValue";
            this.textBoxProductGatherKeyValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherKeyValue.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeProductGatherKey
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherKey.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGatherKey.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeProductGatherKey.Name = "dataGridViewCrudeProductGatherKey";
            this.dataGridViewCrudeProductGatherKey.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeProductGatherKey.TabIndex = 0;
            this.dataGridViewCrudeProductGatherKey.ReadOnly = true;
            this.dataGridViewCrudeProductGatherKey.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherKey_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductGatherKeySearch
            // 
            this.buttonCrudeProductGatherKeySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherKeySearch.Location = new System.Drawing.Point(226, 172);
            this.buttonCrudeProductGatherKeySearch.Name = "buttonCrudeProductGatherKeySearch";
            this.buttonCrudeProductGatherKeySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherKeySearch.TabIndex = 2;
            this.buttonCrudeProductGatherKeySearch.Text = "&Search";
            this.buttonCrudeProductGatherKeySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherKeySearch.Click += new System.EventHandler(this.buttonCrudeProductGatherKeySearch_Click);
            // 
            // buttonCrudeProductGatherKeyAdd
            // 
            this.buttonCrudeProductGatherKeyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherKeyAdd.Location = new System.Drawing.Point(126, 172);
            this.buttonCrudeProductGatherKeyAdd.Name = "buttonCrudeProductGatherKeyAdd";
            this.buttonCrudeProductGatherKeyAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherKeyAdd.TabIndex = 3;
            this.buttonCrudeProductGatherKeyAdd.Text = "&Add";
            this.buttonCrudeProductGatherKeyAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherKeyAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherKeyAdd_Click);
            // 
            // buttonCrudeProductGatherKeyEdit
            // 
            this.buttonCrudeProductGatherKeyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherKeyEdit.Location = new System.Drawing.Point(26, 172);
            this.buttonCrudeProductGatherKeyEdit.Name = "buttonCrudeProductGatherKeyEdit";
            this.buttonCrudeProductGatherKeyEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherKeyEdit.TabIndex = 4;
            this.buttonCrudeProductGatherKeyEdit.Text = "&Edit";
            this.buttonCrudeProductGatherKeyEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherKeyEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherKeyEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 200);
            this.Controls.Add(this.buttonCrudeProductGatherKeySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherKeyAdd);
            this.Controls.Add(this.buttonCrudeProductGatherKeyEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGatherKey);
            this.Name = "CrudeProductGatherKeySearch";
            this.Text = "Product Gather Key Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherKey)).EndInit();
            this.Controls.Add(this.labelProductGatherKeyValue);
            this.Controls.Add(this.textBoxProductGatherKeyValue);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
