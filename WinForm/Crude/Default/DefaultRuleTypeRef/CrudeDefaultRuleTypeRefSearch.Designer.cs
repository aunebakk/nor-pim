namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultRuleTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultRuleTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultRuleTypeRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultRuleTypeName;
        
        private System.Windows.Forms.Label labelDefaultRuleTypeName;
        
        private System.Windows.Forms.TextBox textBoxDefaultRuleType;
        
        private System.Windows.Forms.Label labelDefaultRuleType;
        
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
            this.buttonCrudeDefaultRuleTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultRuleTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultRuleTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultRuleTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultRuleTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultRuleTypeName = new System.Windows.Forms.TextBox();
            this.labelDefaultRuleType = new System.Windows.Forms.Label();
            this.textBoxDefaultRuleType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultRuleTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultRuleTypeName
            //
            this.labelDefaultRuleTypeName.AutoSize = true;
            this.labelDefaultRuleTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultRuleTypeName.Name = "labelDefaultRuleTypeName";
            this.labelDefaultRuleTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultRuleTypeName.TabIndex = 2;
            this.labelDefaultRuleTypeName.Text = "Default Rule Type Name:";
            //
            //textBoxDefaultRuleTypeName
            //
            this.textBoxDefaultRuleTypeName.Location = new System.Drawing.Point(154, 13);
            this.textBoxDefaultRuleTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultRuleTypeName.Name = "textBoxDefaultRuleTypeName";
            this.textBoxDefaultRuleTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultRuleTypeName.TabIndex = 3;
            //
            // labelDefaultRuleType
            //
            this.labelDefaultRuleType.AutoSize = true;
            this.labelDefaultRuleType.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultRuleType.Name = "labelDefaultRuleType";
            this.labelDefaultRuleType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultRuleType.TabIndex = 4;
            this.labelDefaultRuleType.Text = "Default Rule Type:";
            //
            //textBoxDefaultRuleType
            //
            this.textBoxDefaultRuleType.Location = new System.Drawing.Point(154, 36);
            this.textBoxDefaultRuleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultRuleType.Name = "textBoxDefaultRuleType";
            this.textBoxDefaultRuleType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultRuleType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDefaultRuleTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultRuleTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultRuleTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultRuleTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultRuleTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultRuleTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultRuleTypeRef.Name = "dataGridViewCrudeDefaultRuleTypeRef";
            this.dataGridViewCrudeDefaultRuleTypeRef.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeDefaultRuleTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultRuleTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultRuleTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultRuleTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultRuleTypeRefSearch
            // 
            this.buttonCrudeDefaultRuleTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleTypeRefSearch.Location = new System.Drawing.Point(212, 195);
            this.buttonCrudeDefaultRuleTypeRefSearch.Name = "buttonCrudeDefaultRuleTypeRefSearch";
            this.buttonCrudeDefaultRuleTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultRuleTypeRefSearch.Text = "&Search";
            this.buttonCrudeDefaultRuleTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultRuleTypeRefSearch_Click);
            // 
            // buttonCrudeDefaultRuleTypeRefAdd
            // 
            this.buttonCrudeDefaultRuleTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleTypeRefAdd.Location = new System.Drawing.Point(112, 195);
            this.buttonCrudeDefaultRuleTypeRefAdd.Name = "buttonCrudeDefaultRuleTypeRefAdd";
            this.buttonCrudeDefaultRuleTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultRuleTypeRefAdd.Text = "&Add";
            this.buttonCrudeDefaultRuleTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultRuleTypeRefAdd_Click);
            // 
            // buttonCrudeDefaultRuleTypeRefEdit
            // 
            this.buttonCrudeDefaultRuleTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultRuleTypeRefEdit.Location = new System.Drawing.Point(12, 195);
            this.buttonCrudeDefaultRuleTypeRefEdit.Name = "buttonCrudeDefaultRuleTypeRefEdit";
            this.buttonCrudeDefaultRuleTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultRuleTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultRuleTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultRuleTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultRuleTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultRuleTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.buttonCrudeDefaultRuleTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultRuleTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultRuleTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultRuleTypeRef);
            this.Name = "CrudeDefaultRuleTypeRefSearch";
            this.Text = "Default Rule Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultRuleTypeRef)).EndInit();
            this.Controls.Add(this.labelDefaultRuleTypeName);
            this.Controls.Add(this.textBoxDefaultRuleTypeName);
            this.Controls.Add(this.labelDefaultRuleType);
            this.Controls.Add(this.textBoxDefaultRuleType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
