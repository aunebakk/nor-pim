namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestRunResultRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultTestRunResultRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultTestRunResultRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultTestRunResultRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultTestRunResultRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultTestRunResultName;
        
        private System.Windows.Forms.Label labelDefaultTestRunResultName;
        
        private System.Windows.Forms.TextBox textBoxDefaultTestRunResult;
        
        private System.Windows.Forms.Label labelDefaultTestRunResult;
        
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
            this.buttonCrudeDefaultTestRunResultRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultTestRunResultRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultTestRunResultRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultTestRunResultRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultTestRunResultName = new System.Windows.Forms.Label();
            this.textBoxDefaultTestRunResultName = new System.Windows.Forms.TextBox();
            this.labelDefaultTestRunResult = new System.Windows.Forms.Label();
            this.textBoxDefaultTestRunResult = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultTestRunResultRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultTestRunResultName
            //
            this.labelDefaultTestRunResultName.AutoSize = true;
            this.labelDefaultTestRunResultName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultTestRunResultName.Name = "labelDefaultTestRunResultName";
            this.labelDefaultTestRunResultName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultTestRunResultName.TabIndex = 2;
            this.labelDefaultTestRunResultName.Text = "Default Test Run Result Name:";
            //
            //textBoxDefaultTestRunResultName
            //
            this.textBoxDefaultTestRunResultName.Location = new System.Drawing.Point(196, 13);
            this.textBoxDefaultTestRunResultName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultTestRunResultName.Name = "textBoxDefaultTestRunResultName";
            this.textBoxDefaultTestRunResultName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultTestRunResultName.TabIndex = 3;
            //
            // labelDefaultTestRunResult
            //
            this.labelDefaultTestRunResult.AutoSize = true;
            this.labelDefaultTestRunResult.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultTestRunResult.Name = "labelDefaultTestRunResult";
            this.labelDefaultTestRunResult.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultTestRunResult.TabIndex = 4;
            this.labelDefaultTestRunResult.Text = "Default Test Run Result:";
            //
            //textBoxDefaultTestRunResult
            //
            this.textBoxDefaultTestRunResult.Location = new System.Drawing.Point(196, 36);
            this.textBoxDefaultTestRunResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultTestRunResult.Name = "textBoxDefaultTestRunResult";
            this.textBoxDefaultTestRunResult.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultTestRunResult.TabIndex = 5;
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
            // dataGridViewCrudeDefaultTestRunResultRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultTestRunResultRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultTestRunResultRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultTestRunResultRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultTestRunResultRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultTestRunResultRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultTestRunResultRef.Name = "dataGridViewCrudeDefaultTestRunResultRef";
            this.dataGridViewCrudeDefaultTestRunResultRef.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeDefaultTestRunResultRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultTestRunResultRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultTestRunResultRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultTestRunResultRef_DoubleClick);
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
            // buttonCrudeDefaultTestRunResultRefSearch
            // 
            this.buttonCrudeDefaultTestRunResultRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestRunResultRefSearch.Location = new System.Drawing.Point(254, 195);
            this.buttonCrudeDefaultTestRunResultRefSearch.Name = "buttonCrudeDefaultTestRunResultRefSearch";
            this.buttonCrudeDefaultTestRunResultRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestRunResultRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultTestRunResultRefSearch.Text = "&Search";
            this.buttonCrudeDefaultTestRunResultRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestRunResultRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultTestRunResultRefSearch_Click);
            // 
            // buttonCrudeDefaultTestRunResultRefAdd
            // 
            this.buttonCrudeDefaultTestRunResultRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestRunResultRefAdd.Location = new System.Drawing.Point(154, 195);
            this.buttonCrudeDefaultTestRunResultRefAdd.Name = "buttonCrudeDefaultTestRunResultRefAdd";
            this.buttonCrudeDefaultTestRunResultRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestRunResultRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultTestRunResultRefAdd.Text = "&Add";
            this.buttonCrudeDefaultTestRunResultRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestRunResultRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultTestRunResultRefAdd_Click);
            // 
            // buttonCrudeDefaultTestRunResultRefEdit
            // 
            this.buttonCrudeDefaultTestRunResultRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestRunResultRefEdit.Location = new System.Drawing.Point(54, 195);
            this.buttonCrudeDefaultTestRunResultRefEdit.Name = "buttonCrudeDefaultTestRunResultRefEdit";
            this.buttonCrudeDefaultTestRunResultRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestRunResultRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultTestRunResultRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultTestRunResultRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestRunResultRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultTestRunResultRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.buttonCrudeDefaultTestRunResultRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultTestRunResultRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultTestRunResultRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultTestRunResultRef);
            this.Name = "CrudeDefaultTestRunResultRefSearch";
            this.Text = "Default Test Run Result Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultTestRunResultRef)).EndInit();
            this.Controls.Add(this.labelDefaultTestRunResultName);
            this.Controls.Add(this.textBoxDefaultTestRunResultName);
            this.Controls.Add(this.labelDefaultTestRunResult);
            this.Controls.Add(this.textBoxDefaultTestRunResult);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
