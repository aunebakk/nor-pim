namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationAddressTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeLocationAddressTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeLocationAddressTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeLocationAddressTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeLocationAddressTypeRef;
        
        private System.Windows.Forms.TextBox textBoxLocationAddressTypeName;
        
        private System.Windows.Forms.Label labelLocationAddressTypeName;
        
        private System.Windows.Forms.TextBox textBoxLocationAddressType;
        
        private System.Windows.Forms.Label labelLocationAddressType;
        
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
            this.buttonCrudeLocationAddressTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeLocationAddressTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeLocationAddressTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeLocationAddressTypeRef = new System.Windows.Forms.DataGridView();
            this.labelLocationAddressTypeName = new System.Windows.Forms.Label();
            this.textBoxLocationAddressTypeName = new System.Windows.Forms.TextBox();
            this.labelLocationAddressType = new System.Windows.Forms.Label();
            this.textBoxLocationAddressType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationAddressTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelLocationAddressTypeName
            //
            this.labelLocationAddressTypeName.AutoSize = true;
            this.labelLocationAddressTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelLocationAddressTypeName.Name = "labelLocationAddressTypeName";
            this.labelLocationAddressTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationAddressTypeName.TabIndex = 2;
            this.labelLocationAddressTypeName.Text = "Location Address Type Name:";
            //
            //textBoxLocationAddressTypeName
            //
            this.textBoxLocationAddressTypeName.Location = new System.Drawing.Point(182, 13);
            this.textBoxLocationAddressTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationAddressTypeName.Name = "textBoxLocationAddressTypeName";
            this.textBoxLocationAddressTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationAddressTypeName.TabIndex = 3;
            //
            // labelLocationAddressType
            //
            this.labelLocationAddressType.AutoSize = true;
            this.labelLocationAddressType.Location = new System.Drawing.Point(11, 36);
            this.labelLocationAddressType.Name = "labelLocationAddressType";
            this.labelLocationAddressType.Size = new System.Drawing.Size(71, 13);
            this.labelLocationAddressType.TabIndex = 4;
            this.labelLocationAddressType.Text = "Location Address Type:";
            //
            //textBoxLocationAddressType
            //
            this.textBoxLocationAddressType.Location = new System.Drawing.Point(182, 36);
            this.textBoxLocationAddressType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationAddressType.Name = "textBoxLocationAddressType";
            this.textBoxLocationAddressType.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationAddressType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeLocationAddressTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeLocationAddressTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeLocationAddressTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeLocationAddressTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeLocationAddressTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeLocationAddressTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeLocationAddressTypeRef.Name = "dataGridViewCrudeLocationAddressTypeRef";
            this.dataGridViewCrudeLocationAddressTypeRef.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeLocationAddressTypeRef.TabIndex = 0;
            this.dataGridViewCrudeLocationAddressTypeRef.ReadOnly = true;
            this.dataGridViewCrudeLocationAddressTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeLocationAddressTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeLocationAddressTypeRefSearch
            // 
            this.buttonCrudeLocationAddressTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationAddressTypeRefSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeLocationAddressTypeRefSearch.Name = "buttonCrudeLocationAddressTypeRefSearch";
            this.buttonCrudeLocationAddressTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationAddressTypeRefSearch.TabIndex = 2;
            this.buttonCrudeLocationAddressTypeRefSearch.Text = "&Search";
            this.buttonCrudeLocationAddressTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationAddressTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeLocationAddressTypeRefSearch_Click);
            // 
            // buttonCrudeLocationAddressTypeRefAdd
            // 
            this.buttonCrudeLocationAddressTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationAddressTypeRefAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeLocationAddressTypeRefAdd.Name = "buttonCrudeLocationAddressTypeRefAdd";
            this.buttonCrudeLocationAddressTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationAddressTypeRefAdd.TabIndex = 3;
            this.buttonCrudeLocationAddressTypeRefAdd.Text = "&Add";
            this.buttonCrudeLocationAddressTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationAddressTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeLocationAddressTypeRefAdd_Click);
            // 
            // buttonCrudeLocationAddressTypeRefEdit
            // 
            this.buttonCrudeLocationAddressTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationAddressTypeRefEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeLocationAddressTypeRefEdit.Name = "buttonCrudeLocationAddressTypeRefEdit";
            this.buttonCrudeLocationAddressTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationAddressTypeRefEdit.TabIndex = 4;
            this.buttonCrudeLocationAddressTypeRefEdit.Text = "&Edit";
            this.buttonCrudeLocationAddressTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationAddressTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeLocationAddressTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeLocationAddressTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeLocationAddressTypeRefAdd);
            this.Controls.Add(this.buttonCrudeLocationAddressTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeLocationAddressTypeRef);
            this.Name = "CrudeLocationAddressTypeRefSearch";
            this.Text = "Location Address Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationAddressTypeRef)).EndInit();
            this.Controls.Add(this.labelLocationAddressTypeName);
            this.Controls.Add(this.textBoxLocationAddressTypeName);
            this.Controls.Add(this.labelLocationAddressType);
            this.Controls.Add(this.textBoxLocationAddressType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
