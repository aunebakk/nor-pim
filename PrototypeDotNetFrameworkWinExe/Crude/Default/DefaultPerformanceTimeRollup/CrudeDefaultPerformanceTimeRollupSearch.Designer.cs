namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultPerformanceTimeRollupSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeRollupSearch;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeRollupAdd;
        
        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeRollupEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultPerformanceTimeRollup;
        
        private System.Windows.Forms.TextBox textBoxCommandName;
        
        private System.Windows.Forms.Label labelCommandName;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMilliseconds;
        
        private System.Windows.Forms.Label labelMilliseconds;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHits;
        
        private System.Windows.Forms.Label labelHits;
        
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
            this.buttonCrudeDefaultPerformanceTimeRollupAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceTimeRollupEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceTimeRollupSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultPerformanceTimeRollup = new System.Windows.Forms.DataGridView();
            this.labelCommandName = new System.Windows.Forms.Label();
            this.textBoxCommandName = new System.Windows.Forms.TextBox();
            this.labelMilliseconds = new System.Windows.Forms.Label();
            this.maskedTextBoxMilliseconds = new System.Windows.Forms.MaskedTextBox();
            this.labelHits = new System.Windows.Forms.Label();
            this.maskedTextBoxHits = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceTimeRollup)).BeginInit();
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
            // labelMilliseconds
            //
            this.labelMilliseconds.AutoSize = true;
            this.labelMilliseconds.Location = new System.Drawing.Point(11, 36);
            this.labelMilliseconds.Name = "labelMilliseconds";
            this.labelMilliseconds.Size = new System.Drawing.Size(71, 13);
            this.labelMilliseconds.TabIndex = 4;
            this.labelMilliseconds.Text = "Milliseconds:";
            //
            //maskedTextBoxMilliseconds
            //
            this.maskedTextBoxMilliseconds.Location = new System.Drawing.Point(140, 36);
            this.maskedTextBoxMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxMilliseconds.Name = "maskedTextBoxMilliseconds";
            this.maskedTextBoxMilliseconds.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxMilliseconds.TabIndex = 5;
            //
            // labelHits
            //
            this.labelHits.AutoSize = true;
            this.labelHits.Location = new System.Drawing.Point(11, 59);
            this.labelHits.Name = "labelHits";
            this.labelHits.Size = new System.Drawing.Size(71, 13);
            this.labelHits.TabIndex = 6;
            this.labelHits.Text = "Hits:";
            //
            //maskedTextBoxHits
            //
            this.maskedTextBoxHits.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxHits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxHits.Name = "maskedTextBoxHits";
            this.maskedTextBoxHits.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxHits.TabIndex = 7;
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
            // dataGridViewCrudeDefaultPerformanceTimeRollup
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.Name = "dataGridViewCrudeDefaultPerformanceTimeRollup";
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.TabIndex = 0;
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.ReadOnly = true;
            this.dataGridViewCrudeDefaultPerformanceTimeRollup.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultPerformanceTimeRollup_DoubleClick);
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
            // buttonCrudeDefaultPerformanceTimeRollupSearch
            // 
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Name = "buttonCrudeDefaultPerformanceTimeRollupSearch";
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.TabIndex = 2;
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Text = "&Search";
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeRollupSearch.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeRollupSearch_Click);
            // 
            // buttonCrudeDefaultPerformanceTimeRollupAdd
            // 
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Name = "buttonCrudeDefaultPerformanceTimeRollupAdd";
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.TabIndex = 3;
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Text = "&Add";
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeRollupAdd.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeRollupAdd_Click);
            // 
            // buttonCrudeDefaultPerformanceTimeRollupEdit
            // 
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Name = "buttonCrudeDefaultPerformanceTimeRollupEdit";
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.TabIndex = 4;
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Text = "&Edit";
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeRollupEdit.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeRollupEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeRollupSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeRollupAdd);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeRollupEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultPerformanceTimeRollup);
            this.Name = "CrudeDefaultPerformanceTimeRollupSearch";
            this.Text = "Default Performance Time Rollup Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceTimeRollup)).EndInit();
            this.Controls.Add(this.labelCommandName);
            this.Controls.Add(this.textBoxCommandName);
            this.Controls.Add(this.labelMilliseconds);
            this.Controls.Add(this.maskedTextBoxMilliseconds);
            this.Controls.Add(this.labelHits);
            this.Controls.Add(this.maskedTextBoxHits);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
