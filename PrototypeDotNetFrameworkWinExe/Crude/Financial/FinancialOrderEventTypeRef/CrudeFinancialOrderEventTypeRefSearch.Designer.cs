namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderEventTypeRef;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderEventTypeName;
        
        private System.Windows.Forms.Label labelFinancialOrderEventTypeName;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderEventType;
        
        private System.Windows.Forms.Label labelFinancialOrderEventType;
        
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
            this.buttonCrudeFinancialOrderEventTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderEventTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderEventTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderEventTypeRef = new System.Windows.Forms.DataGridView();
            this.labelFinancialOrderEventTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderEventTypeName = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderEventType = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderEventType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderEventTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialOrderEventTypeName
            //
            this.labelFinancialOrderEventTypeName.AutoSize = true;
            this.labelFinancialOrderEventTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderEventTypeName.Name = "labelFinancialOrderEventTypeName";
            this.labelFinancialOrderEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderEventTypeName.TabIndex = 2;
            this.labelFinancialOrderEventTypeName.Text = "Financial Order Event Type Name:";
            //
            //textBoxFinancialOrderEventTypeName
            //
            this.textBoxFinancialOrderEventTypeName.Location = new System.Drawing.Point(217, 13);
            this.textBoxFinancialOrderEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderEventTypeName.Name = "textBoxFinancialOrderEventTypeName";
            this.textBoxFinancialOrderEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderEventTypeName.TabIndex = 3;
            //
            // labelFinancialOrderEventType
            //
            this.labelFinancialOrderEventType.AutoSize = true;
            this.labelFinancialOrderEventType.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderEventType.Name = "labelFinancialOrderEventType";
            this.labelFinancialOrderEventType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderEventType.TabIndex = 4;
            this.labelFinancialOrderEventType.Text = "Financial Order Event Type:";
            //
            //textBoxFinancialOrderEventType
            //
            this.textBoxFinancialOrderEventType.Location = new System.Drawing.Point(217, 36);
            this.textBoxFinancialOrderEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderEventType.Name = "textBoxFinancialOrderEventType";
            this.textBoxFinancialOrderEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderEventType.TabIndex = 5;
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
            // dataGridViewCrudeFinancialOrderEventTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderEventTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderEventTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderEventTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderEventTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderEventTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialOrderEventTypeRef.Name = "dataGridViewCrudeFinancialOrderEventTypeRef";
            this.dataGridViewCrudeFinancialOrderEventTypeRef.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeFinancialOrderEventTypeRef.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderEventTypeRef.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderEventTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderEventTypeRef_DoubleClick);
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
            // buttonCrudeFinancialOrderEventTypeRefSearch
            // 
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Location = new System.Drawing.Point(275, 195);
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Name = "buttonCrudeFinancialOrderEventTypeRefSearch";
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventTypeRefSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderEventTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventTypeRefSearch_Click);
            // 
            // buttonCrudeFinancialOrderEventTypeRefAdd
            // 
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Location = new System.Drawing.Point(175, 195);
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Name = "buttonCrudeFinancialOrderEventTypeRefAdd";
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventTypeRefAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderEventTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventTypeRefAdd_Click);
            // 
            // buttonCrudeFinancialOrderEventTypeRefEdit
            // 
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Location = new System.Drawing.Point(75, 195);
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Name = "buttonCrudeFinancialOrderEventTypeRefEdit";
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventTypeRefEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderEventTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 223);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventTypeRefAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderEventTypeRef);
            this.Name = "CrudeFinancialOrderEventTypeRefSearch";
            this.Text = "Financial Order Event Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderEventTypeRef)).EndInit();
            this.Controls.Add(this.labelFinancialOrderEventTypeName);
            this.Controls.Add(this.textBoxFinancialOrderEventTypeName);
            this.Controls.Add(this.labelFinancialOrderEventType);
            this.Controls.Add(this.textBoxFinancialOrderEventType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
