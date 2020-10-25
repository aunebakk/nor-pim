namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSetTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductExposeSetTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExposeSetTypeRef;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetTypeName;
        
        private System.Windows.Forms.Label labelProductExposeSetTypeName;
        
        private System.Windows.Forms.TextBox textBoxProductExposeSetType;
        
        private System.Windows.Forms.Label labelProductExposeSetType;
        
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
            this.buttonCrudeProductExposeSetTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeSetTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposeSetTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductExposeSetTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductExposeSetTypeName = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetTypeName = new System.Windows.Forms.TextBox();
            this.labelProductExposeSetType = new System.Windows.Forms.Label();
            this.textBoxProductExposeSetType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSetTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductExposeSetTypeName
            //
            this.labelProductExposeSetTypeName.AutoSize = true;
            this.labelProductExposeSetTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductExposeSetTypeName.Name = "labelProductExposeSetTypeName";
            this.labelProductExposeSetTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetTypeName.TabIndex = 2;
            this.labelProductExposeSetTypeName.Text = "Product Expose Set Type Name:";
            //
            //textBoxProductExposeSetTypeName
            //
            this.textBoxProductExposeSetTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxProductExposeSetTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductExposeSetTypeName.Name = "textBoxProductExposeSetTypeName";
            this.textBoxProductExposeSetTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetTypeName.TabIndex = 3;
            //
            // labelProductExposeSetType
            //
            this.labelProductExposeSetType.AutoSize = true;
            this.labelProductExposeSetType.Location = new System.Drawing.Point(11, 36);
            this.labelProductExposeSetType.Name = "labelProductExposeSetType";
            this.labelProductExposeSetType.Size = new System.Drawing.Size(71, 13);
            this.labelProductExposeSetType.TabIndex = 4;
            this.labelProductExposeSetType.Text = "Product Expose Set Type:";
            //
            //textBoxProductExposeSetType
            //
            this.textBoxProductExposeSetType.Location = new System.Drawing.Point(196, 36);
            this.textBoxProductExposeSetType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductExposeSetType.Name = "textBoxProductExposeSetType";
            this.textBoxProductExposeSetType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductExposeSetType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeProductExposeSetTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExposeSetTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExposeSetTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExposeSetTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExposeSetTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductExposeSetTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductExposeSetTypeRef.Name = "dataGridViewCrudeProductExposeSetTypeRef";
            this.dataGridViewCrudeProductExposeSetTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeProductExposeSetTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductExposeSetTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductExposeSetTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExposeSetTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductExposeSetTypeRefSearch
            // 
            this.buttonCrudeProductExposeSetTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetTypeRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeProductExposeSetTypeRefSearch.Name = "buttonCrudeProductExposeSetTypeRefSearch";
            this.buttonCrudeProductExposeSetTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductExposeSetTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductExposeSetTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductExposeSetTypeRefSearch_Click);
            // 
            // buttonCrudeProductExposeSetTypeRefAdd
            // 
            this.buttonCrudeProductExposeSetTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetTypeRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeProductExposeSetTypeRefAdd.Name = "buttonCrudeProductExposeSetTypeRefAdd";
            this.buttonCrudeProductExposeSetTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductExposeSetTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductExposeSetTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductExposeSetTypeRefAdd_Click);
            // 
            // buttonCrudeProductExposeSetTypeRefEdit
            // 
            this.buttonCrudeProductExposeSetTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposeSetTypeRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeProductExposeSetTypeRefEdit.Name = "buttonCrudeProductExposeSetTypeRefEdit";
            this.buttonCrudeProductExposeSetTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposeSetTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductExposeSetTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductExposeSetTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposeSetTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductExposeSetTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeProductExposeSetTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductExposeSetTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductExposeSetTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductExposeSetTypeRef);
            this.Name = "CrudeProductExposeSetTypeRefSearch";
            this.Text = "Product Expose Set Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposeSetTypeRef)).EndInit();
            this.Controls.Add(this.labelProductExposeSetTypeName);
            this.Controls.Add(this.textBoxProductExposeSetTypeName);
            this.Controls.Add(this.labelProductExposeSetType);
            this.Controls.Add(this.textBoxProductExposeSetType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
