namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCompanySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCompanySearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCompanyAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCompanyEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCompany;
        
        private System.Windows.Forms.TextBox textBoxFinancialCompanyName;
        
        private System.Windows.Forms.Label labelFinancialCompanyName;
        
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
            this.buttonCrudeFinancialCompanyAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCompanyEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCompanySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCompany = new System.Windows.Forms.DataGridView();
            this.labelFinancialCompanyName = new System.Windows.Forms.Label();
            this.textBoxFinancialCompanyName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCompany)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCompanyName
            //
            this.labelFinancialCompanyName.AutoSize = true;
            this.labelFinancialCompanyName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCompanyName.Name = "labelFinancialCompanyName";
            this.labelFinancialCompanyName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCompanyName.TabIndex = 2;
            this.labelFinancialCompanyName.Text = "Financial Company Name:";
            //
            //textBoxFinancialCompanyName
            //
            this.textBoxFinancialCompanyName.Location = new System.Drawing.Point(154, 13);
            this.textBoxFinancialCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCompanyName.Name = "textBoxFinancialCompanyName";
            this.textBoxFinancialCompanyName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCompanyName.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            // 
            // dataGridViewCrudeFinancialCompany
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCompany.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCrudeFinancialCompany.Name = "dataGridViewCrudeFinancialCompany";
            this.dataGridViewCrudeFinancialCompany.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFinancialCompany.TabIndex = 0;
            this.dataGridViewCrudeFinancialCompany.ReadOnly = true;
            this.dataGridViewCrudeFinancialCompany.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCompany_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 172);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCompanySearch
            // 
            this.buttonCrudeFinancialCompanySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCompanySearch.Location = new System.Drawing.Point(212, 172);
            this.buttonCrudeFinancialCompanySearch.Name = "buttonCrudeFinancialCompanySearch";
            this.buttonCrudeFinancialCompanySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCompanySearch.TabIndex = 2;
            this.buttonCrudeFinancialCompanySearch.Text = "&Search";
            this.buttonCrudeFinancialCompanySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCompanySearch.Click += new System.EventHandler(this.buttonCrudeFinancialCompanySearch_Click);
            // 
            // buttonCrudeFinancialCompanyAdd
            // 
            this.buttonCrudeFinancialCompanyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCompanyAdd.Location = new System.Drawing.Point(112, 172);
            this.buttonCrudeFinancialCompanyAdd.Name = "buttonCrudeFinancialCompanyAdd";
            this.buttonCrudeFinancialCompanyAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCompanyAdd.TabIndex = 3;
            this.buttonCrudeFinancialCompanyAdd.Text = "&Add";
            this.buttonCrudeFinancialCompanyAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCompanyAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCompanyAdd_Click);
            // 
            // buttonCrudeFinancialCompanyEdit
            // 
            this.buttonCrudeFinancialCompanyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCompanyEdit.Location = new System.Drawing.Point(12, 172);
            this.buttonCrudeFinancialCompanyEdit.Name = "buttonCrudeFinancialCompanyEdit";
            this.buttonCrudeFinancialCompanyEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCompanyEdit.TabIndex = 4;
            this.buttonCrudeFinancialCompanyEdit.Text = "&Edit";
            this.buttonCrudeFinancialCompanyEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCompanyEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCompanyEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 200);
            this.Controls.Add(this.buttonCrudeFinancialCompanySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCompanyAdd);
            this.Controls.Add(this.buttonCrudeFinancialCompanyEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCompany);
            this.Name = "CrudeFinancialCompanySearch";
            this.Text = "Financial Company Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCompany)).EndInit();
            this.Controls.Add(this.labelFinancialCompanyName);
            this.Controls.Add(this.textBoxFinancialCompanyName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
