namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultErrorTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultErrorTypeRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorTypeName;
        
        private System.Windows.Forms.Label labelDefaultErrorTypeName;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorType;
        
        private System.Windows.Forms.Label labelDefaultErrorType;
        
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
            this.buttonCrudeDefaultErrorTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultErrorTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultErrorTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultErrorTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorTypeName = new System.Windows.Forms.TextBox();
            this.labelDefaultErrorType = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultErrorTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultErrorTypeName
            //
            this.labelDefaultErrorTypeName.AutoSize = true;
            this.labelDefaultErrorTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultErrorTypeName.Name = "labelDefaultErrorTypeName";
            this.labelDefaultErrorTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorTypeName.TabIndex = 2;
            this.labelDefaultErrorTypeName.Text = "Default Error Type Name:";
            //
            //textBoxDefaultErrorTypeName
            //
            this.textBoxDefaultErrorTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxDefaultErrorTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorTypeName.Name = "textBoxDefaultErrorTypeName";
            this.textBoxDefaultErrorTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorTypeName.TabIndex = 3;
            //
            // labelDefaultErrorType
            //
            this.labelDefaultErrorType.AutoSize = true;
            this.labelDefaultErrorType.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultErrorType.Name = "labelDefaultErrorType";
            this.labelDefaultErrorType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorType.TabIndex = 4;
            this.labelDefaultErrorType.Text = "Default Error Type:";
            //
            //textBoxDefaultErrorType
            //
            this.textBoxDefaultErrorType.Location = new System.Drawing.Point(161, 36);
            this.textBoxDefaultErrorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorType.Name = "textBoxDefaultErrorType";
            this.textBoxDefaultErrorType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorType.TabIndex = 5;
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
            // dataGridViewCrudeDefaultErrorTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultErrorTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultErrorTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultErrorTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultErrorTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultErrorTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultErrorTypeRef.Name = "dataGridViewCrudeDefaultErrorTypeRef";
            this.dataGridViewCrudeDefaultErrorTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeDefaultErrorTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultErrorTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultErrorTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultErrorTypeRef_DoubleClick);
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
            // buttonCrudeDefaultErrorTypeRefSearch
            // 
            this.buttonCrudeDefaultErrorTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeDefaultErrorTypeRefSearch.Name = "buttonCrudeDefaultErrorTypeRefSearch";
            this.buttonCrudeDefaultErrorTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultErrorTypeRefSearch.Text = "&Search";
            this.buttonCrudeDefaultErrorTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultErrorTypeRefSearch_Click);
            // 
            // buttonCrudeDefaultErrorTypeRefAdd
            // 
            this.buttonCrudeDefaultErrorTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeDefaultErrorTypeRefAdd.Name = "buttonCrudeDefaultErrorTypeRefAdd";
            this.buttonCrudeDefaultErrorTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultErrorTypeRefAdd.Text = "&Add";
            this.buttonCrudeDefaultErrorTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultErrorTypeRefAdd_Click);
            // 
            // buttonCrudeDefaultErrorTypeRefEdit
            // 
            this.buttonCrudeDefaultErrorTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultErrorTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeDefaultErrorTypeRefEdit.Name = "buttonCrudeDefaultErrorTypeRefEdit";
            this.buttonCrudeDefaultErrorTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultErrorTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultErrorTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultErrorTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultErrorTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultErrorTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeDefaultErrorTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultErrorTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultErrorTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultErrorTypeRef);
            this.Name = "CrudeDefaultErrorTypeRefSearch";
            this.Text = "Default Error Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultErrorTypeRef)).EndInit();
            this.Controls.Add(this.labelDefaultErrorTypeName);
            this.Controls.Add(this.textBoxDefaultErrorTypeName);
            this.Controls.Add(this.labelDefaultErrorType);
            this.Controls.Add(this.textBoxDefaultErrorType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
