namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductIdentifierRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductIdentifierRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductIdentifierRef;
        
        private System.Windows.Forms.TextBox textBoxProductIdentifierName;
        
        private System.Windows.Forms.Label labelProductIdentifierName;
        
        private System.Windows.Forms.TextBox textBoxProductIdentifier;
        
        private System.Windows.Forms.Label labelProductIdentifier;
        
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
            this.buttonCrudeProductIdentifierRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductIdentifierRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductIdentifierRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductIdentifierRef = new System.Windows.Forms.DataGridView();
            this.labelProductIdentifierName = new System.Windows.Forms.Label();
            this.textBoxProductIdentifierName = new System.Windows.Forms.TextBox();
            this.labelProductIdentifier = new System.Windows.Forms.Label();
            this.textBoxProductIdentifier = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductIdentifierRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductIdentifierName
            //
            this.labelProductIdentifierName.AutoSize = true;
            this.labelProductIdentifierName.Location = new System.Drawing.Point(11, 13);
            this.labelProductIdentifierName.Name = "labelProductIdentifierName";
            this.labelProductIdentifierName.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifierName.TabIndex = 2;
            this.labelProductIdentifierName.Text = "Product Identifier Name:";
            //
            //textBoxProductIdentifierName
            //
            this.textBoxProductIdentifierName.Location = new System.Drawing.Point(161, 13);
            this.textBoxProductIdentifierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductIdentifierName.Name = "textBoxProductIdentifierName";
            this.textBoxProductIdentifierName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductIdentifierName.TabIndex = 3;
            //
            // labelProductIdentifier
            //
            this.labelProductIdentifier.AutoSize = true;
            this.labelProductIdentifier.Location = new System.Drawing.Point(11, 36);
            this.labelProductIdentifier.Name = "labelProductIdentifier";
            this.labelProductIdentifier.Size = new System.Drawing.Size(71, 13);
            this.labelProductIdentifier.TabIndex = 4;
            this.labelProductIdentifier.Text = "Product Identifier:";
            //
            //textBoxProductIdentifier
            //
            this.textBoxProductIdentifier.Location = new System.Drawing.Point(161, 36);
            this.textBoxProductIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductIdentifier.Name = "textBoxProductIdentifier";
            this.textBoxProductIdentifier.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductIdentifier.TabIndex = 5;
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
            // dataGridViewCrudeProductIdentifierRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductIdentifierRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductIdentifierRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductIdentifierRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductIdentifierRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductIdentifierRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductIdentifierRef.Name = "dataGridViewCrudeProductIdentifierRef";
            this.dataGridViewCrudeProductIdentifierRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeProductIdentifierRef.TabIndex = 0;
            this.dataGridViewCrudeProductIdentifierRef.ReadOnly = true;
            this.dataGridViewCrudeProductIdentifierRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductIdentifierRef_DoubleClick);
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
            // buttonCrudeProductIdentifierRefSearch
            // 
            this.buttonCrudeProductIdentifierRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeProductIdentifierRefSearch.Name = "buttonCrudeProductIdentifierRefSearch";
            this.buttonCrudeProductIdentifierRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierRefSearch.TabIndex = 2;
            this.buttonCrudeProductIdentifierRefSearch.Text = "&Search";
            this.buttonCrudeProductIdentifierRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierRefSearch.Click += new System.EventHandler(this.buttonCrudeProductIdentifierRefSearch_Click);
            // 
            // buttonCrudeProductIdentifierRefAdd
            // 
            this.buttonCrudeProductIdentifierRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeProductIdentifierRefAdd.Name = "buttonCrudeProductIdentifierRefAdd";
            this.buttonCrudeProductIdentifierRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierRefAdd.TabIndex = 3;
            this.buttonCrudeProductIdentifierRefAdd.Text = "&Add";
            this.buttonCrudeProductIdentifierRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierRefAdd.Click += new System.EventHandler(this.buttonCrudeProductIdentifierRefAdd_Click);
            // 
            // buttonCrudeProductIdentifierRefEdit
            // 
            this.buttonCrudeProductIdentifierRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductIdentifierRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeProductIdentifierRefEdit.Name = "buttonCrudeProductIdentifierRefEdit";
            this.buttonCrudeProductIdentifierRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductIdentifierRefEdit.TabIndex = 4;
            this.buttonCrudeProductIdentifierRefEdit.Text = "&Edit";
            this.buttonCrudeProductIdentifierRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductIdentifierRefEdit.Click += new System.EventHandler(this.buttonCrudeProductIdentifierRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeProductIdentifierRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductIdentifierRefAdd);
            this.Controls.Add(this.buttonCrudeProductIdentifierRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductIdentifierRef);
            this.Name = "CrudeProductIdentifierRefSearch";
            this.Text = "Product Identifier Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductIdentifierRef)).EndInit();
            this.Controls.Add(this.labelProductIdentifierName);
            this.Controls.Add(this.textBoxProductIdentifierName);
            this.Controls.Add(this.labelProductIdentifier);
            this.Controls.Add(this.textBoxProductIdentifier);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
