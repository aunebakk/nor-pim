namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductDocumentationTypeRefSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationTypeRefSearch;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationTypeRefAdd;

        private System.Windows.Forms.Button buttonCrudeProductDocumentationTypeRefEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeProductDocumentationTypeRef;

        private System.Windows.Forms.TextBox textBoxProductDocumentationTypeName;

        private System.Windows.Forms.Label labelProductDocumentationTypeName;

        private System.Windows.Forms.TextBox textBoxProductDocumentationType;

        private System.Windows.Forms.Label labelProductDocumentationType;

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
            this.buttonCrudeProductDocumentationTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductDocumentationTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductDocumentationTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductDocumentationTypeRef = new System.Windows.Forms.DataGridView();
            this.labelProductDocumentationTypeName = new System.Windows.Forms.Label();
            this.textBoxProductDocumentationTypeName = new System.Windows.Forms.TextBox();
            this.labelProductDocumentationType = new System.Windows.Forms.Label();
            this.textBoxProductDocumentationType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentationTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductDocumentationTypeName
            //
            this.labelProductDocumentationTypeName.AutoSize = true;
            this.labelProductDocumentationTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelProductDocumentationTypeName.Name = "labelProductDocumentationTypeName";
            this.labelProductDocumentationTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationTypeName.TabIndex = 2;
            this.labelProductDocumentationTypeName.Text = "Product Documentation Type Name:";
            //
            //textBoxProductDocumentationTypeName
            //
            this.textBoxProductDocumentationTypeName.Location = new System.Drawing.Point(217, 13);
            this.textBoxProductDocumentationTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductDocumentationTypeName.Name = "textBoxProductDocumentationTypeName";
            this.textBoxProductDocumentationTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductDocumentationTypeName.TabIndex = 3;
            //
            // labelProductDocumentationType
            //
            this.labelProductDocumentationType.AutoSize = true;
            this.labelProductDocumentationType.Location = new System.Drawing.Point(11, 36);
            this.labelProductDocumentationType.Name = "labelProductDocumentationType";
            this.labelProductDocumentationType.Size = new System.Drawing.Size(71, 13);
            this.labelProductDocumentationType.TabIndex = 4;
            this.labelProductDocumentationType.Text = "Product Documentation Type:";
            //
            //textBoxProductDocumentationType
            //
            this.textBoxProductDocumentationType.Location = new System.Drawing.Point(217, 36);
            this.textBoxProductDocumentationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductDocumentationType.Name = "textBoxProductDocumentationType";
            this.textBoxProductDocumentationType.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductDocumentationType.TabIndex = 5;
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
            // dataGridViewCrudeProductDocumentationTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductDocumentationTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductDocumentationTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductDocumentationTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductDocumentationTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductDocumentationTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductDocumentationTypeRef.Name = "dataGridViewCrudeProductDocumentationTypeRef";
            this.dataGridViewCrudeProductDocumentationTypeRef.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeProductDocumentationTypeRef.TabIndex = 0;
            this.dataGridViewCrudeProductDocumentationTypeRef.ReadOnly = true;
            this.dataGridViewCrudeProductDocumentationTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductDocumentationTypeRef_DoubleClick);
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
            // buttonCrudeProductDocumentationTypeRefSearch
            // 
            this.buttonCrudeProductDocumentationTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationTypeRefSearch.Location = new System.Drawing.Point(275, 195);
            this.buttonCrudeProductDocumentationTypeRefSearch.Name = "buttonCrudeProductDocumentationTypeRefSearch";
            this.buttonCrudeProductDocumentationTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationTypeRefSearch.TabIndex = 2;
            this.buttonCrudeProductDocumentationTypeRefSearch.Text = "&Search";
            this.buttonCrudeProductDocumentationTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeProductDocumentationTypeRefSearch_Click);
            // 
            // buttonCrudeProductDocumentationTypeRefAdd
            // 
            this.buttonCrudeProductDocumentationTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationTypeRefAdd.Location = new System.Drawing.Point(175, 195);
            this.buttonCrudeProductDocumentationTypeRefAdd.Name = "buttonCrudeProductDocumentationTypeRefAdd";
            this.buttonCrudeProductDocumentationTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationTypeRefAdd.TabIndex = 3;
            this.buttonCrudeProductDocumentationTypeRefAdd.Text = "&Add";
            this.buttonCrudeProductDocumentationTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeProductDocumentationTypeRefAdd_Click);
            // 
            // buttonCrudeProductDocumentationTypeRefEdit
            // 
            this.buttonCrudeProductDocumentationTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductDocumentationTypeRefEdit.Location = new System.Drawing.Point(75, 195);
            this.buttonCrudeProductDocumentationTypeRefEdit.Name = "buttonCrudeProductDocumentationTypeRefEdit";
            this.buttonCrudeProductDocumentationTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductDocumentationTypeRefEdit.TabIndex = 4;
            this.buttonCrudeProductDocumentationTypeRefEdit.Text = "&Edit";
            this.buttonCrudeProductDocumentationTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductDocumentationTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeProductDocumentationTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 223);
            this.Controls.Add(this.buttonCrudeProductDocumentationTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductDocumentationTypeRefAdd);
            this.Controls.Add(this.buttonCrudeProductDocumentationTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeProductDocumentationTypeRef);
            this.Name = "CrudeProductDocumentationTypeRefSearch";
            this.Text = "Product Documentation Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductDocumentationTypeRef)).EndInit();
            this.Controls.Add(this.labelProductDocumentationTypeName);
            this.Controls.Add(this.textBoxProductDocumentationTypeName);
            this.Controls.Add(this.labelProductDocumentationType);
            this.Controls.Add(this.textBoxProductDocumentationType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
