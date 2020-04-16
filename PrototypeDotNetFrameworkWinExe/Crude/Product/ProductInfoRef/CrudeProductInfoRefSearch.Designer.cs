namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductInfoRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductInfoRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductInfoRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductInfoRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductInfoRef;
        
        private System.Windows.Forms.TextBox textBoxProductInfoName;
        
        private System.Windows.Forms.Label labelProductInfoName;
        
        private System.Windows.Forms.TextBox textBoxProductInfo;
        
        private System.Windows.Forms.Label labelProductInfo;
        
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
            this.buttonCrudeProductInfoRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductInfoRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductInfoRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductInfoRef = new System.Windows.Forms.DataGridView();
            this.labelProductInfoName = new System.Windows.Forms.Label();
            this.textBoxProductInfoName = new System.Windows.Forms.TextBox();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.textBoxProductInfo = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductInfoRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductInfoName
            //
            this.labelProductInfoName.AutoSize = true;
            this.labelProductInfoName.Location = new System.Drawing.Point(11, 13);
            this.labelProductInfoName.Name = "labelProductInfoName";
            this.labelProductInfoName.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfoName.TabIndex = 2;
            this.labelProductInfoName.Text = "Product Info Name:";
            //
            //textBoxProductInfoName
            //
            this.textBoxProductInfoName.Location = new System.Drawing.Point(140, 13);
            this.textBoxProductInfoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfoName.Name = "textBoxProductInfoName";
            this.textBoxProductInfoName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfoName.TabIndex = 3;
            //
            // labelProductInfo
            //
            this.labelProductInfo.AutoSize = true;
            this.labelProductInfo.Location = new System.Drawing.Point(11, 36);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(71, 13);
            this.labelProductInfo.TabIndex = 4;
            this.labelProductInfo.Text = "Product Info:";
            //
            //textBoxProductInfo
            //
            this.textBoxProductInfo.Location = new System.Drawing.Point(140, 36);
            this.textBoxProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductInfo.Name = "textBoxProductInfo";
            this.textBoxProductInfo.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductInfo.TabIndex = 5;
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
            // dataGridViewCrudeProductInfoRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductInfoRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductInfoRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductInfoRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductInfoRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductInfoRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductInfoRef.Name = "dataGridViewCrudeProductInfoRef";
            this.dataGridViewCrudeProductInfoRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductInfoRef.TabIndex = 0;
            this.dataGridViewCrudeProductInfoRef.ReadOnly = true;
            this.dataGridViewCrudeProductInfoRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductInfoRef_DoubleClick);
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
            // buttonCrudeProductInfoRefSearch
            // 
            this.buttonCrudeProductInfoRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeProductInfoRefSearch.Name = "buttonCrudeProductInfoRefSearch";
            this.buttonCrudeProductInfoRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoRefSearch.TabIndex = 2;
            this.buttonCrudeProductInfoRefSearch.Text = "&Search";
            this.buttonCrudeProductInfoRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoRefSearch.Click += new System.EventHandler(this.buttonCrudeProductInfoRefSearch_Click);
            // 
            // buttonCrudeProductInfoRefAdd
            // 
            this.buttonCrudeProductInfoRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeProductInfoRefAdd.Name = "buttonCrudeProductInfoRefAdd";
            this.buttonCrudeProductInfoRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoRefAdd.TabIndex = 3;
            this.buttonCrudeProductInfoRefAdd.Text = "&Add";
            this.buttonCrudeProductInfoRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoRefAdd.Click += new System.EventHandler(this.buttonCrudeProductInfoRefAdd_Click);
            // 
            // buttonCrudeProductInfoRefEdit
            // 
            this.buttonCrudeProductInfoRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductInfoRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeProductInfoRefEdit.Name = "buttonCrudeProductInfoRefEdit";
            this.buttonCrudeProductInfoRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductInfoRefEdit.TabIndex = 4;
            this.buttonCrudeProductInfoRefEdit.Text = "&Edit";
            this.buttonCrudeProductInfoRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductInfoRefEdit.Click += new System.EventHandler(this.buttonCrudeProductInfoRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeProductInfoRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductInfoRefAdd);
            this.Controls.Add(this.buttonCrudeProductInfoRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductInfoRef);
            this.Name = "CrudeProductInfoRefSearch";
            this.Text = "Product Info Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductInfoRef)).EndInit();
            this.Controls.Add(this.labelProductInfoName);
            this.Controls.Add(this.textBoxProductInfoName);
            this.Controls.Add(this.labelProductInfo);
            this.Controls.Add(this.textBoxProductInfo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
