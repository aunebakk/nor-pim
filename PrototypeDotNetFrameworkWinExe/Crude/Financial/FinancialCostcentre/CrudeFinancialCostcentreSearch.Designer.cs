namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCostcentreSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCostcentreSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCostcentreAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCostcentreEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCostcentre;
        
        private System.Windows.Forms.TextBox textBoxFinancialCostcentreName;
        
        private System.Windows.Forms.Label labelFinancialCostcentreName;
        
        private System.Windows.Forms.TextBox textBoxFinancialCostcentreCode;
        
        private System.Windows.Forms.Label labelFinancialCostcentreCode;
        
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
            this.buttonCrudeFinancialCostcentreAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCostcentreEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCostcentreSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCostcentre = new System.Windows.Forms.DataGridView();
            this.labelFinancialCostcentreName = new System.Windows.Forms.Label();
            this.textBoxFinancialCostcentreName = new System.Windows.Forms.TextBox();
            this.labelFinancialCostcentreCode = new System.Windows.Forms.Label();
            this.textBoxFinancialCostcentreCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCostcentre)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialCostcentreName
            //
            this.labelFinancialCostcentreName.AutoSize = true;
            this.labelFinancialCostcentreName.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCostcentreName.Name = "labelFinancialCostcentreName";
            this.labelFinancialCostcentreName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentreName.TabIndex = 2;
            this.labelFinancialCostcentreName.Text = "Financial Costcentre Name:";
            //
            //textBoxFinancialCostcentreName
            //
            this.textBoxFinancialCostcentreName.Location = new System.Drawing.Point(175, 13);
            this.textBoxFinancialCostcentreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCostcentreName.Name = "textBoxFinancialCostcentreName";
            this.textBoxFinancialCostcentreName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCostcentreName.TabIndex = 3;
            //
            // labelFinancialCostcentreCode
            //
            this.labelFinancialCostcentreCode.AutoSize = true;
            this.labelFinancialCostcentreCode.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCostcentreCode.Name = "labelFinancialCostcentreCode";
            this.labelFinancialCostcentreCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentreCode.TabIndex = 4;
            this.labelFinancialCostcentreCode.Text = "Financial Costcentre Code:";
            //
            //textBoxFinancialCostcentreCode
            //
            this.textBoxFinancialCostcentreCode.Location = new System.Drawing.Point(175, 36);
            this.textBoxFinancialCostcentreCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCostcentreCode.Name = "textBoxFinancialCostcentreCode";
            this.textBoxFinancialCostcentreCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCostcentreCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialCostcentre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCostcentre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCostcentre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCostcentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCostcentre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCostcentre.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialCostcentre.Name = "dataGridViewCrudeFinancialCostcentre";
            this.dataGridViewCrudeFinancialCostcentre.Size = new System.Drawing.Size(413, 96);
            this.dataGridViewCrudeFinancialCostcentre.TabIndex = 0;
            this.dataGridViewCrudeFinancialCostcentre.ReadOnly = true;
            this.dataGridViewCrudeFinancialCostcentre.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCostcentre_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCostcentreSearch
            // 
            this.buttonCrudeFinancialCostcentreSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCostcentreSearch.Location = new System.Drawing.Point(233, 195);
            this.buttonCrudeFinancialCostcentreSearch.Name = "buttonCrudeFinancialCostcentreSearch";
            this.buttonCrudeFinancialCostcentreSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCostcentreSearch.TabIndex = 2;
            this.buttonCrudeFinancialCostcentreSearch.Text = "&Search";
            this.buttonCrudeFinancialCostcentreSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCostcentreSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCostcentreSearch_Click);
            // 
            // buttonCrudeFinancialCostcentreAdd
            // 
            this.buttonCrudeFinancialCostcentreAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCostcentreAdd.Location = new System.Drawing.Point(133, 195);
            this.buttonCrudeFinancialCostcentreAdd.Name = "buttonCrudeFinancialCostcentreAdd";
            this.buttonCrudeFinancialCostcentreAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCostcentreAdd.TabIndex = 3;
            this.buttonCrudeFinancialCostcentreAdd.Text = "&Add";
            this.buttonCrudeFinancialCostcentreAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCostcentreAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCostcentreAdd_Click);
            // 
            // buttonCrudeFinancialCostcentreEdit
            // 
            this.buttonCrudeFinancialCostcentreEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCostcentreEdit.Location = new System.Drawing.Point(33, 195);
            this.buttonCrudeFinancialCostcentreEdit.Name = "buttonCrudeFinancialCostcentreEdit";
            this.buttonCrudeFinancialCostcentreEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCostcentreEdit.TabIndex = 4;
            this.buttonCrudeFinancialCostcentreEdit.Text = "&Edit";
            this.buttonCrudeFinancialCostcentreEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCostcentreEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCostcentreEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 223);
            this.Controls.Add(this.buttonCrudeFinancialCostcentreSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCostcentreAdd);
            this.Controls.Add(this.buttonCrudeFinancialCostcentreEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCostcentre);
            this.Name = "CrudeFinancialCostcentreSearch";
            this.Text = "Financial Costcentre Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCostcentre)).EndInit();
            this.Controls.Add(this.labelFinancialCostcentreName);
            this.Controls.Add(this.textBoxFinancialCostcentreName);
            this.Controls.Add(this.labelFinancialCostcentreCode);
            this.Controls.Add(this.textBoxFinancialCostcentreCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
