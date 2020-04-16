namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCountrySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeLocationCountrySearch;
        
        private System.Windows.Forms.Button buttonCrudeLocationCountryAdd;
        
        private System.Windows.Forms.Button buttonCrudeLocationCountryEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeLocationCountry;
        
        private System.Windows.Forms.TextBox textBoxLocationCountryName;
        
        private System.Windows.Forms.Label labelLocationCountryName;
        
        private System.Windows.Forms.TextBox textBoxLocationCountryCode;
        
        private System.Windows.Forms.Label labelLocationCountryCode;
        
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
            this.buttonCrudeLocationCountryAdd = new System.Windows.Forms.Button();
            this.buttonCrudeLocationCountryEdit = new System.Windows.Forms.Button();
            this.buttonCrudeLocationCountrySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeLocationCountry = new System.Windows.Forms.DataGridView();
            this.labelLocationCountryName = new System.Windows.Forms.Label();
            this.textBoxLocationCountryName = new System.Windows.Forms.TextBox();
            this.labelLocationCountryCode = new System.Windows.Forms.Label();
            this.textBoxLocationCountryCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationCountry)).BeginInit();
            this.SuspendLayout();
            //
            // labelLocationCountryName
            //
            this.labelLocationCountryName.AutoSize = true;
            this.labelLocationCountryName.Location = new System.Drawing.Point(11, 13);
            this.labelLocationCountryName.Name = "labelLocationCountryName";
            this.labelLocationCountryName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCountryName.TabIndex = 2;
            this.labelLocationCountryName.Text = "Location Country Name:";
            //
            //textBoxLocationCountryName
            //
            this.textBoxLocationCountryName.Location = new System.Drawing.Point(147, 13);
            this.textBoxLocationCountryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCountryName.Name = "textBoxLocationCountryName";
            this.textBoxLocationCountryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCountryName.TabIndex = 3;
            //
            // labelLocationCountryCode
            //
            this.labelLocationCountryCode.AutoSize = true;
            this.labelLocationCountryCode.Location = new System.Drawing.Point(11, 36);
            this.labelLocationCountryCode.Name = "labelLocationCountryCode";
            this.labelLocationCountryCode.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCountryCode.TabIndex = 4;
            this.labelLocationCountryCode.Text = "Location Country Code:";
            //
            //textBoxLocationCountryCode
            //
            this.textBoxLocationCountryCode.Location = new System.Drawing.Point(147, 36);
            this.textBoxLocationCountryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCountryCode.Name = "textBoxLocationCountryCode";
            this.textBoxLocationCountryCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCountryCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeLocationCountry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeLocationCountry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeLocationCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeLocationCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeLocationCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeLocationCountry.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeLocationCountry.Name = "dataGridViewCrudeLocationCountry";
            this.dataGridViewCrudeLocationCountry.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeLocationCountry.TabIndex = 0;
            this.dataGridViewCrudeLocationCountry.ReadOnly = true;
            this.dataGridViewCrudeLocationCountry.DoubleClick += new System.EventHandler(this.dataGridViewCrudeLocationCountry_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeLocationCountrySearch
            // 
            this.buttonCrudeLocationCountrySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCountrySearch.Location = new System.Drawing.Point(205, 195);
            this.buttonCrudeLocationCountrySearch.Name = "buttonCrudeLocationCountrySearch";
            this.buttonCrudeLocationCountrySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCountrySearch.TabIndex = 2;
            this.buttonCrudeLocationCountrySearch.Text = "&Search";
            this.buttonCrudeLocationCountrySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCountrySearch.Click += new System.EventHandler(this.buttonCrudeLocationCountrySearch_Click);
            // 
            // buttonCrudeLocationCountryAdd
            // 
            this.buttonCrudeLocationCountryAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCountryAdd.Location = new System.Drawing.Point(105, 195);
            this.buttonCrudeLocationCountryAdd.Name = "buttonCrudeLocationCountryAdd";
            this.buttonCrudeLocationCountryAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCountryAdd.TabIndex = 3;
            this.buttonCrudeLocationCountryAdd.Text = "&Add";
            this.buttonCrudeLocationCountryAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCountryAdd.Click += new System.EventHandler(this.buttonCrudeLocationCountryAdd_Click);
            // 
            // buttonCrudeLocationCountryEdit
            // 
            this.buttonCrudeLocationCountryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeLocationCountryEdit.Location = new System.Drawing.Point(5, 195);
            this.buttonCrudeLocationCountryEdit.Name = "buttonCrudeLocationCountryEdit";
            this.buttonCrudeLocationCountryEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeLocationCountryEdit.TabIndex = 4;
            this.buttonCrudeLocationCountryEdit.Text = "&Edit";
            this.buttonCrudeLocationCountryEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeLocationCountryEdit.Click += new System.EventHandler(this.buttonCrudeLocationCountryEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 223);
            this.Controls.Add(this.buttonCrudeLocationCountrySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeLocationCountryAdd);
            this.Controls.Add(this.buttonCrudeLocationCountryEdit);
            this.Controls.Add(this.dataGridViewCrudeLocationCountry);
            this.Name = "CrudeLocationCountrySearch";
            this.Text = "Location Country Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeLocationCountry)).EndInit();
            this.Controls.Add(this.labelLocationCountryName);
            this.Controls.Add(this.textBoxLocationCountryName);
            this.Controls.Add(this.labelLocationCountryCode);
            this.Controls.Add(this.textBoxLocationCountryCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
