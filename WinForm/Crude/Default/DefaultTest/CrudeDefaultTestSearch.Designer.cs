namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultTestSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultTestSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultTestAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultTestEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultTest;

        private System.Windows.Forms.TextBox textBoxSystemName;

        private System.Windows.Forms.Label labelSystemName;

        private System.Windows.Forms.TextBox textBoxTestArea;

        private System.Windows.Forms.Label labelTestArea;

        private System.Windows.Forms.TextBox textBoxTestSubArea;

        private System.Windows.Forms.Label labelTestSubArea;

        private System.Windows.Forms.TextBox textBoxTestAddress;

        private System.Windows.Forms.Label labelTestAddress;

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
            this.buttonCrudeDefaultTestAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultTestEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultTestSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultTest = new System.Windows.Forms.DataGridView();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.textBoxSystemName = new System.Windows.Forms.TextBox();
            this.labelTestArea = new System.Windows.Forms.Label();
            this.textBoxTestArea = new System.Windows.Forms.TextBox();
            this.labelTestSubArea = new System.Windows.Forms.Label();
            this.textBoxTestSubArea = new System.Windows.Forms.TextBox();
            this.labelTestAddress = new System.Windows.Forms.Label();
            this.textBoxTestAddress = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultTest)).BeginInit();
            this.SuspendLayout();
            //
            // labelSystemName
            //
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Location = new System.Drawing.Point(11, 13);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemName.TabIndex = 2;
            this.labelSystemName.Text = "System Name:";
            //
            //textBoxSystemName
            //
            this.textBoxSystemName.Location = new System.Drawing.Point(140, 13);
            this.textBoxSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSystemName.Name = "textBoxSystemName";
            this.textBoxSystemName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemName.TabIndex = 3;
            //
            // labelTestArea
            //
            this.labelTestArea.AutoSize = true;
            this.labelTestArea.Location = new System.Drawing.Point(11, 36);
            this.labelTestArea.Name = "labelTestArea";
            this.labelTestArea.Size = new System.Drawing.Size(71, 13);
            this.labelTestArea.TabIndex = 4;
            this.labelTestArea.Text = "Test Area:";
            //
            //textBoxTestArea
            //
            this.textBoxTestArea.Location = new System.Drawing.Point(140, 36);
            this.textBoxTestArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestArea.Name = "textBoxTestArea";
            this.textBoxTestArea.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestArea.TabIndex = 5;
            //
            // labelTestSubArea
            //
            this.labelTestSubArea.AutoSize = true;
            this.labelTestSubArea.Location = new System.Drawing.Point(11, 59);
            this.labelTestSubArea.Name = "labelTestSubArea";
            this.labelTestSubArea.Size = new System.Drawing.Size(71, 13);
            this.labelTestSubArea.TabIndex = 6;
            this.labelTestSubArea.Text = "Test Sub Area:";
            //
            //textBoxTestSubArea
            //
            this.textBoxTestSubArea.Location = new System.Drawing.Point(140, 59);
            this.textBoxTestSubArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestSubArea.Name = "textBoxTestSubArea";
            this.textBoxTestSubArea.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestSubArea.TabIndex = 7;
            //
            // labelTestAddress
            //
            this.labelTestAddress.AutoSize = true;
            this.labelTestAddress.Location = new System.Drawing.Point(11, 82);
            this.labelTestAddress.Name = "labelTestAddress";
            this.labelTestAddress.Size = new System.Drawing.Size(71, 13);
            this.labelTestAddress.TabIndex = 8;
            this.labelTestAddress.Text = "Test Address:";
            //
            //textBoxTestAddress
            //
            this.textBoxTestAddress.Location = new System.Drawing.Point(140, 82);
            this.textBoxTestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestAddress.Name = "textBoxTestAddress";
            this.textBoxTestAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestAddress.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultTest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultTest.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeDefaultTest.Name = "dataGridViewCrudeDefaultTest";
            this.dataGridViewCrudeDefaultTest.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultTest.TabIndex = 0;
            this.dataGridViewCrudeDefaultTest.ReadOnly = true;
            this.dataGridViewCrudeDefaultTest.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultTest_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultTestSearch
            // 
            this.buttonCrudeDefaultTestSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeDefaultTestSearch.Name = "buttonCrudeDefaultTestSearch";
            this.buttonCrudeDefaultTestSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestSearch.TabIndex = 2;
            this.buttonCrudeDefaultTestSearch.Text = "&Search";
            this.buttonCrudeDefaultTestSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestSearch.Click += new System.EventHandler(this.buttonCrudeDefaultTestSearch_Click);
            // 
            // buttonCrudeDefaultTestAdd
            // 
            this.buttonCrudeDefaultTestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeDefaultTestAdd.Name = "buttonCrudeDefaultTestAdd";
            this.buttonCrudeDefaultTestAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestAdd.TabIndex = 3;
            this.buttonCrudeDefaultTestAdd.Text = "&Add";
            this.buttonCrudeDefaultTestAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestAdd.Click += new System.EventHandler(this.buttonCrudeDefaultTestAdd_Click);
            // 
            // buttonCrudeDefaultTestEdit
            // 
            this.buttonCrudeDefaultTestEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultTestEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeDefaultTestEdit.Name = "buttonCrudeDefaultTestEdit";
            this.buttonCrudeDefaultTestEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultTestEdit.TabIndex = 4;
            this.buttonCrudeDefaultTestEdit.Text = "&Edit";
            this.buttonCrudeDefaultTestEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultTestEdit.Click += new System.EventHandler(this.buttonCrudeDefaultTestEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeDefaultTestSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultTestAdd);
            this.Controls.Add(this.buttonCrudeDefaultTestEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultTest);
            this.Name = "CrudeDefaultTestSearch";
            this.Text = "Default Test Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultTest)).EndInit();
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.textBoxSystemName);
            this.Controls.Add(this.labelTestArea);
            this.Controls.Add(this.textBoxTestArea);
            this.Controls.Add(this.labelTestSubArea);
            this.Controls.Add(this.textBoxTestSubArea);
            this.Controls.Add(this.labelTestAddress);
            this.Controls.Add(this.textBoxTestAddress);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
