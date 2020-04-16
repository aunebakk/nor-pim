namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultIssueStatusRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultIssueStatusRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultIssueStatusRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultIssueStatusRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultIssueStatusRef;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueStatusName;
        
        private System.Windows.Forms.Label labelDefaultIssueStatusName;
        
        private System.Windows.Forms.TextBox textBoxDefaultIssueStatus;
        
        private System.Windows.Forms.Label labelDefaultIssueStatus;
        
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
            this.buttonCrudeDefaultIssueStatusRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultIssueStatusRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultIssueStatusRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultIssueStatusRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultIssueStatusName = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueStatusName = new System.Windows.Forms.TextBox();
            this.labelDefaultIssueStatus = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueStatus = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultIssueStatusRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultIssueStatusName
            //
            this.labelDefaultIssueStatusName.AutoSize = true;
            this.labelDefaultIssueStatusName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultIssueStatusName.Name = "labelDefaultIssueStatusName";
            this.labelDefaultIssueStatusName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueStatusName.TabIndex = 2;
            this.labelDefaultIssueStatusName.Text = "Default Issue Status Name:";
            //
            //textBoxDefaultIssueStatusName
            //
            this.textBoxDefaultIssueStatusName.Location = new System.Drawing.Point(175, 13);
            this.textBoxDefaultIssueStatusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueStatusName.Name = "textBoxDefaultIssueStatusName";
            this.textBoxDefaultIssueStatusName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueStatusName.TabIndex = 3;
            //
            // labelDefaultIssueStatus
            //
            this.labelDefaultIssueStatus.AutoSize = true;
            this.labelDefaultIssueStatus.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultIssueStatus.Name = "labelDefaultIssueStatus";
            this.labelDefaultIssueStatus.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueStatus.TabIndex = 4;
            this.labelDefaultIssueStatus.Text = "Default Issue Status:";
            //
            //textBoxDefaultIssueStatus
            //
            this.textBoxDefaultIssueStatus.Location = new System.Drawing.Point(175, 36);
            this.textBoxDefaultIssueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueStatus.Name = "textBoxDefaultIssueStatus";
            this.textBoxDefaultIssueStatus.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueStatus.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeDefaultIssueStatusRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultIssueStatusRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultIssueStatusRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultIssueStatusRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultIssueStatusRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultIssueStatusRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultIssueStatusRef.Name = "dataGridViewCrudeDefaultIssueStatusRef";
            this.dataGridViewCrudeDefaultIssueStatusRef.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeDefaultIssueStatusRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultIssueStatusRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultIssueStatusRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultIssueStatusRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultIssueStatusRefSearch
            // 
            this.buttonCrudeDefaultIssueStatusRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueStatusRefSearch.Location = new System.Drawing.Point(233, 195);
            this.buttonCrudeDefaultIssueStatusRefSearch.Name = "buttonCrudeDefaultIssueStatusRefSearch";
            this.buttonCrudeDefaultIssueStatusRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueStatusRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultIssueStatusRefSearch.Text = "&Search";
            this.buttonCrudeDefaultIssueStatusRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueStatusRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultIssueStatusRefSearch_Click);
            // 
            // buttonCrudeDefaultIssueStatusRefAdd
            // 
            this.buttonCrudeDefaultIssueStatusRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueStatusRefAdd.Location = new System.Drawing.Point(133, 195);
            this.buttonCrudeDefaultIssueStatusRefAdd.Name = "buttonCrudeDefaultIssueStatusRefAdd";
            this.buttonCrudeDefaultIssueStatusRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueStatusRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultIssueStatusRefAdd.Text = "&Add";
            this.buttonCrudeDefaultIssueStatusRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueStatusRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultIssueStatusRefAdd_Click);
            // 
            // buttonCrudeDefaultIssueStatusRefEdit
            // 
            this.buttonCrudeDefaultIssueStatusRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueStatusRefEdit.Location = new System.Drawing.Point(33, 195);
            this.buttonCrudeDefaultIssueStatusRefEdit.Name = "buttonCrudeDefaultIssueStatusRefEdit";
            this.buttonCrudeDefaultIssueStatusRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueStatusRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultIssueStatusRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultIssueStatusRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueStatusRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultIssueStatusRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 223);
            this.Controls.Add(this.buttonCrudeDefaultIssueStatusRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultIssueStatusRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultIssueStatusRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultIssueStatusRef);
            this.Name = "CrudeDefaultIssueStatusRefSearch";
            this.Text = "Default Issue Status Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultIssueStatusRef)).EndInit();
            this.Controls.Add(this.labelDefaultIssueStatusName);
            this.Controls.Add(this.textBoxDefaultIssueStatusName);
            this.Controls.Add(this.labelDefaultIssueStatus);
            this.Controls.Add(this.textBoxDefaultIssueStatus);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
