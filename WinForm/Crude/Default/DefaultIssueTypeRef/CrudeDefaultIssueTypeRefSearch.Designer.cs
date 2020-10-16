namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultIssueTypeRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultIssueTypeRefSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultIssueTypeRefAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultIssueTypeRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultIssueTypeRef;

        private System.Windows.Forms.TextBox textBoxDefaultIssueTypeName;

        private System.Windows.Forms.Label labelDefaultIssueTypeName;

        private System.Windows.Forms.TextBox textBoxDefaultIssueType;

        private System.Windows.Forms.Label labelDefaultIssueType;

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
            this.buttonCrudeDefaultIssueTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultIssueTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultIssueTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultIssueTypeRef = new System.Windows.Forms.DataGridView();
            this.labelDefaultIssueTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueTypeName = new System.Windows.Forms.TextBox();
            this.labelDefaultIssueType = new System.Windows.Forms.Label();
            this.textBoxDefaultIssueType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultIssueTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultIssueTypeName
            //
            this.labelDefaultIssueTypeName.AutoSize = true;
            this.labelDefaultIssueTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultIssueTypeName.Name = "labelDefaultIssueTypeName";
            this.labelDefaultIssueTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueTypeName.TabIndex = 2;
            this.labelDefaultIssueTypeName.Text = "Default Issue Type Name:";
            //
            //textBoxDefaultIssueTypeName
            //
            this.textBoxDefaultIssueTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxDefaultIssueTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueTypeName.Name = "textBoxDefaultIssueTypeName";
            this.textBoxDefaultIssueTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueTypeName.TabIndex = 3;
            //
            // labelDefaultIssueType
            //
            this.labelDefaultIssueType.AutoSize = true;
            this.labelDefaultIssueType.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultIssueType.Name = "labelDefaultIssueType";
            this.labelDefaultIssueType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultIssueType.TabIndex = 4;
            this.labelDefaultIssueType.Text = "Default Issue Type:";
            //
            //textBoxDefaultIssueType
            //
            this.textBoxDefaultIssueType.Location = new System.Drawing.Point(161, 36);
            this.textBoxDefaultIssueType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultIssueType.Name = "textBoxDefaultIssueType";
            this.textBoxDefaultIssueType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultIssueType.TabIndex = 5;
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
            // dataGridViewCrudeDefaultIssueTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultIssueTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultIssueTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultIssueTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultIssueTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultIssueTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultIssueTypeRef.Name = "dataGridViewCrudeDefaultIssueTypeRef";
            this.dataGridViewCrudeDefaultIssueTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeDefaultIssueTypeRef.TabIndex = 0;
            this.dataGridViewCrudeDefaultIssueTypeRef.ReadOnly = true;
            this.dataGridViewCrudeDefaultIssueTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultIssueTypeRef_DoubleClick);
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
            // buttonCrudeDefaultIssueTypeRefSearch
            // 
            this.buttonCrudeDefaultIssueTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeDefaultIssueTypeRefSearch.Name = "buttonCrudeDefaultIssueTypeRefSearch";
            this.buttonCrudeDefaultIssueTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueTypeRefSearch.TabIndex = 2;
            this.buttonCrudeDefaultIssueTypeRefSearch.Text = "&Search";
            this.buttonCrudeDefaultIssueTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeDefaultIssueTypeRefSearch_Click);
            // 
            // buttonCrudeDefaultIssueTypeRefAdd
            // 
            this.buttonCrudeDefaultIssueTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeDefaultIssueTypeRefAdd.Name = "buttonCrudeDefaultIssueTypeRefAdd";
            this.buttonCrudeDefaultIssueTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueTypeRefAdd.TabIndex = 3;
            this.buttonCrudeDefaultIssueTypeRefAdd.Text = "&Add";
            this.buttonCrudeDefaultIssueTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeDefaultIssueTypeRefAdd_Click);
            // 
            // buttonCrudeDefaultIssueTypeRefEdit
            // 
            this.buttonCrudeDefaultIssueTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultIssueTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeDefaultIssueTypeRefEdit.Name = "buttonCrudeDefaultIssueTypeRefEdit";
            this.buttonCrudeDefaultIssueTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultIssueTypeRefEdit.TabIndex = 4;
            this.buttonCrudeDefaultIssueTypeRefEdit.Text = "&Edit";
            this.buttonCrudeDefaultIssueTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultIssueTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeDefaultIssueTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeDefaultIssueTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultIssueTypeRefAdd);
            this.Controls.Add(this.buttonCrudeDefaultIssueTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultIssueTypeRef);
            this.Name = "CrudeDefaultIssueTypeRefSearch";
            this.Text = "Default Issue Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultIssueTypeRef)).EndInit();
            this.Controls.Add(this.labelDefaultIssueTypeName);
            this.Controls.Add(this.textBoxDefaultIssueTypeName);
            this.Controls.Add(this.labelDefaultIssueType);
            this.Controls.Add(this.textBoxDefaultIssueType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
