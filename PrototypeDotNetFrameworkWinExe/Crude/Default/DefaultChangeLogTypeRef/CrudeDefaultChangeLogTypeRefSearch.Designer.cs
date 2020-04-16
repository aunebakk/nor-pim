namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultChangeLogTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultChangeLogTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultChangeLogTypeRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeLogTypeName;
        
        private System.Windows.Forms.Label labelDefaultChangeLogTypeName;
        
        private System.Windows.Forms.TextBox textBoxDefaultChangeLogType;
        
        private System.Windows.Forms.Label labelDefaultChangeLogType;
        
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
            this.buttonCrudeDefaultChangeLogTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultChangeLogTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultChangeLogTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultChangeLogTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultChangeLogTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeLogTypeName = new System.Windows.Forms.TextBox();
            this.labelDefaultChangeLogType = new System.Windows.Forms.Label();
            this.textBoxDefaultChangeLogType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultChangeLogTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultChangeLogTypeName
            //
            this.labelDefaultChangeLogTypeName.AutoSize = true;
            this.labelDefaultChangeLogTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultChangeLogTypeName.Name = "labelDefaultChangeLogTypeName";
            this.labelDefaultChangeLogTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogTypeName.TabIndex = 2;
            this.labelDefaultChangeLogTypeName.Text = "Default Change Log Type Name:";
            //
            //textBoxDefaultChangeLogTypeName
            //
            this.textBoxDefaultChangeLogTypeName.Location = new System.Drawing.Point(196, 13);
            this.textBoxDefaultChangeLogTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeLogTypeName.Name = "textBoxDefaultChangeLogTypeName";
            this.textBoxDefaultChangeLogTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeLogTypeName.TabIndex = 3;
            //
            // labelDefaultChangeLogType
            //
            this.labelDefaultChangeLogType.AutoSize = true;
            this.labelDefaultChangeLogType.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultChangeLogType.Name = "labelDefaultChangeLogType";
            this.labelDefaultChangeLogType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultChangeLogType.TabIndex = 4;
            this.labelDefaultChangeLogType.Text = "Default Change Log Type:";
            //
            //textBoxDefaultChangeLogType
            //
            this.textBoxDefaultChangeLogType.Location = new System.Drawing.Point(196, 36);
            this.textBoxDefaultChangeLogType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultChangeLogType.Name = "textBoxDefaultChangeLogType";
            this.textBoxDefaultChangeLogType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultChangeLogType.TabIndex = 5;
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
            // dataGridViewCrudeDefaultChangeLogTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultChangeLogTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultChangeLogTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultChangeLogTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultChangeLogTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultChangeLogTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultChangeLogTypeRef.Name = "dataGridViewCrudeDefaultChangeLogTypeRef";
            this.dataGridViewCrudeDefaultChangeLogTypeRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeDefaultChangeLogTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultChangeLogTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultChangeLogTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultChangeLogTypeRef_DoubleClick);
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
            // buttonCrudeDefaultChangeLogTypeRefSearch
            // 
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Name = "buttonCrudeDefaultChangeLogTypeRefSearch";
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Text = "&Search";
            this.buttonCrudeDefaultChangeLogTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogTypeRefSearch_Click);
            // 
            // buttonCrudeDefaultChangeLogTypeRefAdd
            // 
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Name = "buttonCrudeDefaultChangeLogTypeRefAdd";
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Text = "&Add";
            this.buttonCrudeDefaultChangeLogTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogTypeRefAdd_Click);
            // 
            // buttonCrudeDefaultChangeLogTypeRefEdit
            // 
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Name = "buttonCrudeDefaultChangeLogTypeRefEdit";
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultChangeLogTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultChangeLogTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultChangeLogTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultChangeLogTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultChangeLogTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultChangeLogTypeRef);
            this.Name = "CrudeDefaultChangeLogTypeRefSearch";
            this.Text = "Default Change Log Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultChangeLogTypeRef)).EndInit();
            this.Controls.Add(this.labelDefaultChangeLogTypeName);
            this.Controls.Add(this.textBoxDefaultChangeLogTypeName);
            this.Controls.Add(this.labelDefaultChangeLogType);
            this.Controls.Add(this.textBoxDefaultChangeLogType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
