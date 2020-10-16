namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultPerformanceTimeSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeSearch;

        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeAdd;

        private System.Windows.Forms.Button buttonCrudeDefaultPerformanceTimeEdit;

        private System.Windows.Forms.DataGridView dataGridViewCrudeDefaultPerformanceTime;

        private System.Windows.Forms.TextBox textBoxCommandName;

        private System.Windows.Forms.Label labelCommandName;

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
            this.buttonCrudeDefaultPerformanceTimeAdd = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceTimeEdit = new System.Windows.Forms.Button();
            this.buttonCrudeDefaultPerformanceTimeSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeDefaultPerformanceTime = new System.Windows.Forms.DataGridView();
            this.labelCommandName = new System.Windows.Forms.Label();
            this.textBoxCommandName = new System.Windows.Forms.TextBox();
            this.labelMilliseconds = new System.Windows.Forms.Label();
            this.maskedTextBoxMilliseconds = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceTime)).BeginInit();
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // dataGridViewCrudeDefaultPerformanceTime
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeDefaultPerformanceTime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeDefaultPerformanceTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeDefaultPerformanceTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeDefaultPerformanceTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeDefaultPerformanceTime.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeDefaultPerformanceTime.Name = "dataGridViewCrudeDefaultPerformanceTime";
            this.dataGridViewCrudeDefaultPerformanceTime.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeDefaultPerformanceTime.TabIndex = 0;
            this.dataGridViewCrudeDefaultPerformanceTime.ReadOnly = true;
            this.dataGridViewCrudeDefaultPerformanceTime.DoubleClick += new System.EventHandler(this.dataGridViewCrudeDefaultPerformanceTime_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);

            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeDefaultPerformanceTimeSearch
            // 
            this.buttonCrudeDefaultPerformanceTimeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeDefaultPerformanceTimeSearch.Name = "buttonCrudeDefaultPerformanceTimeSearch";
            this.buttonCrudeDefaultPerformanceTimeSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeSearch.TabIndex = 2;
            this.buttonCrudeDefaultPerformanceTimeSearch.Text = "&Search";
            this.buttonCrudeDefaultPerformanceTimeSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeSearch.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeSearch_Click);
            // 
            // buttonCrudeDefaultPerformanceTimeAdd
            // 
            this.buttonCrudeDefaultPerformanceTimeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeDefaultPerformanceTimeAdd.Name = "buttonCrudeDefaultPerformanceTimeAdd";
            this.buttonCrudeDefaultPerformanceTimeAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeAdd.TabIndex = 3;
            this.buttonCrudeDefaultPerformanceTimeAdd.Text = "&Add";
            this.buttonCrudeDefaultPerformanceTimeAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeAdd.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeAdd_Click);
            // 
            // buttonCrudeDefaultPerformanceTimeEdit
            // 
            this.buttonCrudeDefaultPerformanceTimeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeDefaultPerformanceTimeEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeDefaultPerformanceTimeEdit.Name = "buttonCrudeDefaultPerformanceTimeEdit";
            this.buttonCrudeDefaultPerformanceTimeEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeDefaultPerformanceTimeEdit.TabIndex = 4;
            this.buttonCrudeDefaultPerformanceTimeEdit.Text = "&Edit";
            this.buttonCrudeDefaultPerformanceTimeEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeDefaultPerformanceTimeEdit.Click += new System.EventHandler(this.buttonCrudeDefaultPerformanceTimeEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeAdd);
            this.Controls.Add(this.buttonCrudeDefaultPerformanceTimeEdit);
            this.Controls.Add(this.dataGridViewCrudeDefaultPerformanceTime);
            this.Name = "CrudeDefaultPerformanceTimeSearch";
            this.Text = "Default Performance Time Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeDefaultPerformanceTime)).EndInit();
            this.Controls.Add(this.labelCommandName);
            this.Controls.Add(this.textBoxCommandName);
            this.Controls.Add(this.labelMilliseconds);
            this.Controls.Add(this.maskedTextBoxMilliseconds);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
