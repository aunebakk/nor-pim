namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultVersionSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultVersionSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultVersionAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultVersionEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultVersion;

        private System.Windows.Forms.TextBox textBoxFunVersion;

        private System.Windows.Forms.Label labelFunVersion;

        private System.Windows.Forms.TextBox textBoxNumber;

        private System.Windows.Forms.Label labelNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxMajorNumber;

        private System.Windows.Forms.Label labelMajorNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxMinorNumber;

        private System.Windows.Forms.Label labelMinorNumber;

        private System.Windows.Forms.MaskedTextBox maskedTextBoxSequenceNumber;

        private System.Windows.Forms.Label labelSequenceNumber;

        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;

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
            this.buttonCrudeDefaultVersionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultVersionEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultVersionSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultVersion = new System.Windows.Forms.DataGridView();
            this.labelFunVersion = new System.Windows.Forms.Label();
            this.textBoxFunVersion = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelMajorNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxMajorNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelMinorNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxMinorNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelSequenceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxSequenceNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultVersion)).BeginInit();
            this.SuspendLayout();
            //
            // labelFunVersion
            //
            this.labelFunVersion.AutoSize = true;
            this.labelFunVersion.Location = new System.Drawing.Point(11, 13);
            this.labelFunVersion.Name = "labelFunVersion";
            this.labelFunVersion.Size = new System.Drawing.Size(71, 13);
            this.labelFunVersion.TabIndex = 2;
            this.labelFunVersion.Text = "Fun Version:";
            //
            //textBoxFunVersion
            //
            this.textBoxFunVersion.Location = new System.Drawing.Point(140, 13);
            this.textBoxFunVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFunVersion.Name = "textBoxFunVersion";
            this.textBoxFunVersion.Size = new System.Drawing.Size(250, 20);
            this.textBoxFunVersion.TabIndex = 3;
            //
            // labelNumber
            //
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(11, 36);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(71, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Number:";
            //
            //textBoxNumber
            //
            this.textBoxNumber.Location = new System.Drawing.Point(140, 36);
            this.textBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(250, 20);
            this.textBoxNumber.TabIndex = 5;
            //
            // labelMajorNumber
            //
            this.labelMajorNumber.AutoSize = true;
            this.labelMajorNumber.Location = new System.Drawing.Point(11, 59);
            this.labelMajorNumber.Name = "labelMajorNumber";
            this.labelMajorNumber.Size = new System.Drawing.Size(71, 13);
            this.labelMajorNumber.TabIndex = 6;
            this.labelMajorNumber.Text = "Major Number:";
            //
            //maskedTextBoxMajorNumber
            //
            this.maskedTextBoxMajorNumber.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxMajorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMajorNumber.Name = "maskedTextBoxMajorNumber";
            this.maskedTextBoxMajorNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMajorNumber.TabIndex = 7;
            //
            // labelMinorNumber
            //
            this.labelMinorNumber.AutoSize = true;
            this.labelMinorNumber.Location = new System.Drawing.Point(11, 82);
            this.labelMinorNumber.Name = "labelMinorNumber";
            this.labelMinorNumber.Size = new System.Drawing.Size(71, 13);
            this.labelMinorNumber.TabIndex = 8;
            this.labelMinorNumber.Text = "Minor Number:";
            //
            //maskedTextBoxMinorNumber
            //
            this.maskedTextBoxMinorNumber.Location = new System.Drawing.Point(140, 82);
            this.maskedTextBoxMinorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMinorNumber.Name = "maskedTextBoxMinorNumber";
            this.maskedTextBoxMinorNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMinorNumber.TabIndex = 9;
            //
            // labelSequenceNumber
            //
            this.labelSequenceNumber.AutoSize = true;
            this.labelSequenceNumber.Location = new System.Drawing.Point(11, 105);
            this.labelSequenceNumber.Name = "labelSequenceNumber";
            this.labelSequenceNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSequenceNumber.TabIndex = 10;
            this.labelSequenceNumber.Text = "Sequence Number:";
            //
            //maskedTextBoxSequenceNumber
            //
            this.maskedTextBoxSequenceNumber.Location = new System.Drawing.Point(140, 105);
            this.maskedTextBoxSequenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSequenceNumber.Name = "maskedTextBoxSequenceNumber";
            this.maskedTextBoxSequenceNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSequenceNumber.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultVersion
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultVersion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultVersion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultVersion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultVersion.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeDefaultVersion.Name = "dataGridViewCrudeDefaultVersion";
            this.dataGridViewCrudeDefaultVersion.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultVersion.TabIndex = 0;
            this.dataGridViewCrudeDefaultVersion.ReadOnly = true;
            this.dataGridViewCrudeDefaultVersion.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultVersion_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultVersionSearch
            // 
            this.buttonCrudeDefaultVersionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultVersionSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeDefaultVersionSearch.Name = "buttonCrudeDefaultVersionSearch";
            this.buttonCrudeDefaultVersionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultVersionSearch.TabIndex = 2;
            this.buttonCrudeDefaultVersionSearch.Text = "&Search";
            this.buttonCrudeDefaultVersionSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultVersionSearch.Click += new System.EventHandler(this.buttonCrudeDefaultVersionSearch_Click);
            // 
            // buttonCrudeDefaultVersionAdd
            // 
            this.buttonCrudeDefaultVersionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultVersionAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeDefaultVersionAdd.Name = "buttonCrudeDefaultVersionAdd";
            this.buttonCrudeDefaultVersionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultVersionAdd.TabIndex = 3;
            this.buttonCrudeDefaultVersionAdd.Text = "&Add";
            this.buttonCrudeDefaultVersionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultVersionAdd.Click += new System.EventHandler(this.buttonCrudeDefaultVersionAdd_Click);
            // 
            // buttonCrudeDefaultVersionEdit
            // 
            this.buttonCrudeDefaultVersionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultVersionEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeDefaultVersionEdit.Name = "buttonCrudeDefaultVersionEdit";
            this.buttonCrudeDefaultVersionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultVersionEdit.TabIndex = 4;
            this.buttonCrudeDefaultVersionEdit.Text = "&Edit";
            this.buttonCrudeDefaultVersionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultVersionEdit.Click += new System.EventHandler(this.buttonCrudeDefaultVersionEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeDefaultVersionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultVersionAdd);
            this.Controls.Add(this.buttonCrudeDefaultVersionEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultVersion);
            this.Name = "CrudeDefaultVersionSearch";
            this.Text = "Default Version Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultVersion)).EndInit();
            this.Controls.Add(this.labelFunVersion);
            this.Controls.Add(this.textBoxFunVersion);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelMajorNumber);
            this.Controls.Add(this.maskedTextBoxMajorNumber);
            this.Controls.Add(this.labelMinorNumber);
            this.Controls.Add(this.maskedTextBoxMinorNumber);
            this.Controls.Add(this.labelSequenceNumber);
            this.Controls.Add(this.maskedTextBoxSequenceNumber);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
