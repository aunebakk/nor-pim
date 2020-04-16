namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultPerformanceIssueSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceIssueSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceIssueAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceIssueEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultPerformanceIssue;
        
        private System.Windows.Forms.TextBox textBoxCommandName;
        
        private System.Windows.Forms.Label labelCommandName;
        
        private System.Windows.Forms.TextBox textBoxCommandText;
        
        private System.Windows.Forms.Label labelCommandText;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMilliseconds;
        
        private System.Windows.Forms.Label labelMilliseconds;
        
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
            this.buttonCrudeDefaultPerformanceIssueAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceIssueEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceIssueSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultPerformanceIssue = new System.Windows.Forms.DataGridView();
            this.labelCommandName = new System.Windows.Forms.Label();
            this.textBoxCommandName = new System.Windows.Forms.TextBox();
            this.labelCommandText = new System.Windows.Forms.Label();
            this.textBoxCommandText = new System.Windows.Forms.TextBox();
            this.labelMilliseconds = new System.Windows.Forms.Label();
            this.maskedTextBoxMilliseconds = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceIssue)).BeginInit();
            this.SuspendLayout();
            //
            // labelCommandName
            //
            this.labelCommandName.AutoSize = true;
            this.labelCommandName.Location = new System.Drawing.Point(11, 13);
            this.labelCommandName.Name = "labelCommandName";
            this.labelCommandName.Size = new System.Drawing.Size(71, 13);
            this.labelCommandName.TabIndex = 2;
            this.labelCommandName.Text = "Command Name:";
            //
            //textBoxCommandName
            //
            this.textBoxCommandName.Location = new System.Drawing.Point(140, 13);
            this.textBoxCommandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandName.Name = "textBoxCommandName";
            this.textBoxCommandName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCommandName.TabIndex = 3;
            //
            // labelCommandText
            //
            this.labelCommandText.AutoSize = true;
            this.labelCommandText.Location = new System.Drawing.Point(11, 36);
            this.labelCommandText.Name = "labelCommandText";
            this.labelCommandText.Size = new System.Drawing.Size(71, 13);
            this.labelCommandText.TabIndex = 4;
            this.labelCommandText.Text = "Command Text:";
            //
            //textBoxCommandText
            //
            this.textBoxCommandText.Location = new System.Drawing.Point(140, 36);
            this.textBoxCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandText.Name = "textBoxCommandText";
            this.textBoxCommandText.Size = new System.Drawing.Size(250, 20);
            this.textBoxCommandText.TabIndex = 5;
            //
            // labelMilliseconds
            //
            this.labelMilliseconds.AutoSize = true;
            this.labelMilliseconds.Location = new System.Drawing.Point(11, 59);
            this.labelMilliseconds.Name = "labelMilliseconds";
            this.labelMilliseconds.Size = new System.Drawing.Size(71, 13);
            this.labelMilliseconds.TabIndex = 6;
            this.labelMilliseconds.Text = "Milliseconds:";
            //
            //maskedTextBoxMilliseconds
            //
            this.maskedTextBoxMilliseconds.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMilliseconds.Name = "maskedTextBoxMilliseconds";
            this.maskedTextBoxMilliseconds.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMilliseconds.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultPerformanceIssue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultPerformanceIssue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultPerformanceIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultPerformanceIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultPerformanceIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultPerformanceIssue.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeDefaultPerformanceIssue.Name = "dataGridViewCrudeDefaultPerformanceIssue";
            this.dataGridViewCrudeDefaultPerformanceIssue.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultPerformanceIssue.TabIndex = 0;
            this.dataGridViewCrudeDefaultPerformanceIssue.ReadOnly = true;
            this.dataGridViewCrudeDefaultPerformanceIssue.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultPerformanceIssue_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultPerformanceIssueSearch
            // 
            this.buttonCrudeDefaultPerformanceIssueSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceIssueSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeDefaultPerformanceIssueSearch.Name = "buttonCrudeDefaultPerformanceIssueSearch";
            this.buttonCrudeDefaultPerformanceIssueSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceIssueSearch.TabIndex = 2;
            this.buttonCrudeDefaultPerformanceIssueSearch.Text = "&Search";
            this.buttonCrudeDefaultPerformanceIssueSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceIssueSearch.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceIssueSearch_Click);
            // 
            // buttonCrudeDefaultPerformanceIssueAdd
            // 
            this.buttonCrudeDefaultPerformanceIssueAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceIssueAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeDefaultPerformanceIssueAdd.Name = "buttonCrudeDefaultPerformanceIssueAdd";
            this.buttonCrudeDefaultPerformanceIssueAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceIssueAdd.TabIndex = 3;
            this.buttonCrudeDefaultPerformanceIssueAdd.Text = "&Add";
            this.buttonCrudeDefaultPerformanceIssueAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceIssueAdd.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceIssueAdd_Click);
            // 
            // buttonCrudeDefaultPerformanceIssueEdit
            // 
            this.buttonCrudeDefaultPerformanceIssueEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceIssueEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeDefaultPerformanceIssueEdit.Name = "buttonCrudeDefaultPerformanceIssueEdit";
            this.buttonCrudeDefaultPerformanceIssueEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceIssueEdit.TabIndex = 4;
            this.buttonCrudeDefaultPerformanceIssueEdit.Text = "&Edit";
            this.buttonCrudeDefaultPerformanceIssueEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceIssueEdit.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceIssueEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceIssueSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceIssueAdd);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceIssueEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultPerformanceIssue);
            this.Name = "CrudeDefaultPerformanceIssueSearch";
            this.Text = "Default Performance Issue Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceIssue)).EndInit();
            this.Controls.Add(this.labelCommandName);
            this.Controls.Add(this.textBoxCommandName);
            this.Controls.Add(this.labelCommandText);
            this.Controls.Add(this.textBoxCommandText);
            this.Controls.Add(this.labelMilliseconds);
            this.Controls.Add(this.maskedTextBoxMilliseconds);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
