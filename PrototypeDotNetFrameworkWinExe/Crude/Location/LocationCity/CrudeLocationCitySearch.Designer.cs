namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCitySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeLocationCitySearch;
        
        private System.Windows.Forms.Button buttonCrudeLocationCityAdd;
        
        private System.Windows.Forms.Button buttonCrudeLocationCityEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeLocationCity;
        
        private System.Windows.Forms.TextBox textBoxLocationCityName;
        
        private System.Windows.Forms.Label labelLocationCityName;
        
        private System.Windows.Forms.TextBox textBoxLocationCityCode;
        
        private System.Windows.Forms.Label labelLocationCityCode;
        
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
            this.buttonCrudeLocationCityAdd = new System.Windows.Forms.Button();
            this.buttonCrudeLocationCityEdit = new System.Windows.Forms.Button();
            this.buttonCrudeLocationCitySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeLocationCity = new System.Windows.Forms.DataGridView();
            this.labelLocationCityName = new System.Windows.Forms.Label();
            this.textBoxLocationCityName = new System.Windows.Forms.TextBox();
            this.labelLocationCityCode = new System.Windows.Forms.Label();
            this.textBoxLocationCityCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationCity)).BeginInit();
            this.SuspendLayout();
            //
            // labelLocationCityName
            //
            this.labelLocationCityName.AutoSize = true;
            this.labelLocationCityName.Location = new System.Drawing.Point(11, 13);
            this.labelLocationCityName.Name = "labelLocationCityName";
            this.labelLocationCityName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCityName.TabIndex = 2;
            this.labelLocationCityName.Text = "Location City Name:";
            //
            //textBoxLocationCityName
            //
            this.textBoxLocationCityName.Location = new System.Drawing.Point(140, 13);
            this.textBoxLocationCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCityName.Name = "textBoxLocationCityName";
            this.textBoxLocationCityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCityName.TabIndex = 3;
            //
            // labelLocationCityCode
            //
            this.labelLocationCityCode.AutoSize = true;
            this.labelLocationCityCode.Location = new System.Drawing.Point(11, 36);
            this.labelLocationCityCode.Name = "labelLocationCityCode";
            this.labelLocationCityCode.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCityCode.TabIndex = 4;
            this.labelLocationCityCode.Text = "Location City Code:";
            //
            //textBoxLocationCityCode
            //
            this.textBoxLocationCityCode.Location = new System.Drawing.Point(140, 36);
            this.textBoxLocationCityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCityCode.Name = "textBoxLocationCityCode";
            this.textBoxLocationCityCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCityCode.TabIndex = 5;
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
            // 
            // dataGridViewCrudeLocationCity
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeLocationCity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeLocationCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeLocationCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeLocationCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeLocationCity.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeLocationCity.Name = "dataGridViewCrudeLocationCity";
            this.dataGridViewCrudeLocationCity.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeLocationCity.TabIndex = 0;
            this.dataGridViewCrudeLocationCity.ReadOnly = true;
            this.dataGridViewCrudeLocationCity.DoubleClick += new System.EventHandler(this.dataGridViewCrudeLocationCity_DoubleClick);
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
            // buttonCrudeLocationCitySearch
            // 
            this.buttonCrudeLocationCitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCitySearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeLocationCitySearch.Name = "buttonCrudeLocationCitySearch";
            this.buttonCrudeLocationCitySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCitySearch.TabIndex = 2;
            this.buttonCrudeLocationCitySearch.Text = "&Search";
            this.buttonCrudeLocationCitySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCitySearch.Click += new System.EventHandler(this.buttonCrudeLocationCitySearch_Click);
            // 
            // buttonCrudeLocationCityAdd
            // 
            this.buttonCrudeLocationCityAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCityAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeLocationCityAdd.Name = "buttonCrudeLocationCityAdd";
            this.buttonCrudeLocationCityAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCityAdd.TabIndex = 3;
            this.buttonCrudeLocationCityAdd.Text = "&Add";
            this.buttonCrudeLocationCityAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCityAdd.Click += new System.EventHandler(this.buttonCrudeLocationCityAdd_Click);
            // 
            // buttonCrudeLocationCityEdit
            // 
            this.buttonCrudeLocationCityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCityEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeLocationCityEdit.Name = "buttonCrudeLocationCityEdit";
            this.buttonCrudeLocationCityEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCityEdit.TabIndex = 4;
            this.buttonCrudeLocationCityEdit.Text = "&Edit";
            this.buttonCrudeLocationCityEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCityEdit.Click += new System.EventHandler(this.buttonCrudeLocationCityEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeLocationCitySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeLocationCityAdd);
            this.Controls.Add(this.buttonCrudeLocationCityEdit);
            this.Controls.Add(this.dataGridViewCrudeLocationCity);
            this.Name = "CrudeLocationCitySearch";
            this.Text = "Location City Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationCity)).EndInit();
            this.Controls.Add(this.labelLocationCityName);
            this.Controls.Add(this.textBoxLocationCityName);
            this.Controls.Add(this.labelLocationCityCode);
            this.Controls.Add(this.textBoxLocationCityCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
