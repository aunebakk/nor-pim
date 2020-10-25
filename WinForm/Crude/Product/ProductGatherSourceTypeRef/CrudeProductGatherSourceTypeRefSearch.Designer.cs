namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductGatherSourceTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSourceTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGatherSourceTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductGatherSourceTypeName;
        
        private System.Windows.Forms.Label labelProductGatherSourceTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductGatherSourceType;
        
        private System.Windows.Forms.Label labelProductGatherSourceType;
        
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
            this.buttonCrudeProductGatherSourceTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherSourceTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherSourceTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGatherSourceTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductGatherSourceTypeName = new System.Windows.Forms.Label();
            this.textBoxProductGatherSourceTypeName = new System.Windows.Forms.TextBox();
            this.labelProductGatherSourceType = new System.Windows.Forms.Label();
            this.textBoxProductGatherSourceType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSourceTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductGatherSourceTypeName
            //
            this.labelProductGatherSourceTypeName.AutoSize = true;
            this.labelProductGatherSourceTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductGatherSourceTypeName.Name = "labelProductGatherSourceTypeName";
            this.labelProductGatherSourceTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceTypeName.TabIndex = 2;
            this.labelProductGatherSourceTypeName.Text = "Product Gather Source Type Name:";
            //
            //textBoxProductGatherSourceTypeName
            //
            this.textBoxProductGatherSourceTypeName.Location = new System.Drawing.Point(217, 13);
            this.textBoxProductGatherSourceTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherSourceTypeName.Name = "textBoxProductGatherSourceTypeName";
            this.textBoxProductGatherSourceTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherSourceTypeName.TabIndex = 3;
            //
            // labelProductGatherSourceType
            //
            this.labelProductGatherSourceType.AutoSize = true;
            this.labelProductGatherSourceType.Location = new System.Drawing.Point(11, 36);
            this.labelProductGatherSourceType.Name = "labelProductGatherSourceType";
            this.labelProductGatherSourceType.Size = new System.Drawing.Size(71, 13);
            this.labelProductGatherSourceType.TabIndex = 4;
            this.labelProductGatherSourceType.Text = "Product Gather Source Type:";
            //
            //textBoxProductGatherSourceType
            //
            this.textBoxProductGatherSourceType.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductGatherSourceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductGatherSourceType.Name = "textBoxProductGatherSourceType";
            this.textBoxProductGatherSourceType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductGatherSourceType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductGatherSourceTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGatherSourceTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGatherSourceTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGatherSourceTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGatherSourceTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGatherSourceTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductGatherSourceTypeRef.Name = "dataGridViewCrudeProductGatherSourceTypeRef";
            this.dataGridViewCrudeProductGatherSourceTypeRef.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeProductGatherSourceTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductGatherSourceTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductGatherSourceTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGatherSourceTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductGatherSourceTypeRefSearch
            // 
            this.buttonCrudeProductGatherSourceTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceTypeRefSearch.Location = new System.Drawing.Point(275, 195);
            this.buttonCrudeProductGatherSourceTypeRefSearch.Name = "buttonCrudeProductGatherSourceTypeRefSearch";
            this.buttonCrudeProductGatherSourceTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductGatherSourceTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductGatherSourceTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceTypeRefSearch_Click);
            // 
            // buttonCrudeProductGatherSourceTypeRefAdd
            // 
            this.buttonCrudeProductGatherSourceTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceTypeRefAdd.Location = new System.Drawing.Point(175, 195);
            this.buttonCrudeProductGatherSourceTypeRefAdd.Name = "buttonCrudeProductGatherSourceTypeRefAdd";
            this.buttonCrudeProductGatherSourceTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductGatherSourceTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductGatherSourceTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceTypeRefAdd_Click);
            // 
            // buttonCrudeProductGatherSourceTypeRefEdit
            // 
            this.buttonCrudeProductGatherSourceTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSourceTypeRefEdit.Location = new System.Drawing.Point(75, 195);
            this.buttonCrudeProductGatherSourceTypeRefEdit.Name = "buttonCrudeProductGatherSourceTypeRefEdit";
            this.buttonCrudeProductGatherSourceTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSourceTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductGatherSourceTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductGatherSourceTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSourceTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherSourceTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 223);
            this.Controls.Add(this.buttonCrudeProductGatherSourceTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherSourceTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductGatherSourceTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGatherSourceTypeRef);
            this.Name = "CrudeProductGatherSourceTypeRefSearch";
            this.Text = "Product Gather Source Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGatherSourceTypeRef)).EndInit();
            this.Controls.Add(this.labelProductGatherSourceTypeName);
            this.Controls.Add(this.textBoxProductGatherSourceTypeName);
            this.Controls.Add(this.labelProductGatherSourceType);
            this.Controls.Add(this.textBoxProductGatherSourceType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
