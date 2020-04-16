namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonProductMaintenanceSearch;
        
        private System.Windows.Forms.Button buttonProductMaintenanceAdd;
        
        private System.Windows.Forms.Button buttonProductMaintenanceEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewProductMaintenance;
        
        private System.Windows.Forms.TextBox textBoxProductName;
        
        private System.Windows.Forms.Label labelProductName;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.buttonProductMaintenanceAdd = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceEdit = new System.Windows.Forms.Button();
            this.buttonProductMaintenanceSearch = new System.Windows.Forms.Button();
            this.dataGridViewProductMaintenance = new System.Windows.Forms.DataGridView();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenance)).BeginInit();
            this.SuspendLayout();
            //
            // labelProductName
            //
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(11, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(71, 13);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product Name:";
            //
            //textBoxProductName
            //
            this.textBoxProductName.Location = new System.Drawing.Point(140, 13);
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(250, 20);
            this.textBoxProductName.TabIndex = 3;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 36);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(140, 36);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 5;
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
            // dataGridViewProductMaintenance
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProductMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductMaintenance.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewProductMaintenance.Name = "dataGridViewProductMaintenance";
            this.dataGridViewProductMaintenance.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewProductMaintenance.TabIndex = 0;
            this.dataGridViewProductMaintenance.DoubleClick += new System.EventHandler(this.dataGridViewProductMaintenance_DoubleClick);
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
            // buttonProductMaintenanceSearch
            // 
            this.buttonProductMaintenanceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonProductMaintenanceSearch.Name = "buttonProductMaintenanceSearch";
            this.buttonProductMaintenanceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceSearch.TabIndex = 2;
            this.buttonProductMaintenanceSearch.Text = "&Search";
            this.buttonProductMaintenanceSearch.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceSearch.Click += new System.EventHandler(this.buttonProductMaintenanceSearch_Click);
            // 
            // buttonProductMaintenanceAdd
            // 
            this.buttonProductMaintenanceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonProductMaintenanceAdd.Name = "buttonProductMaintenanceAdd";
            this.buttonProductMaintenanceAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceAdd.TabIndex = 3;
            this.buttonProductMaintenanceAdd.Text = "&Add";
            this.buttonProductMaintenanceAdd.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceAdd.Click += new System.EventHandler(this.buttonProductMaintenanceAdd_Click);
            // 
            // buttonProductMaintenanceEdit
            // 
            this.buttonProductMaintenanceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductMaintenanceEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonProductMaintenanceEdit.Name = "buttonProductMaintenanceEdit";
            this.buttonProductMaintenanceEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonProductMaintenanceEdit.TabIndex = 4;
            this.buttonProductMaintenanceEdit.Text = "&Edit";
            this.buttonProductMaintenanceEdit.UseVisualStyleBackColor = true;
            this.buttonProductMaintenanceEdit.Click += new System.EventHandler(this.buttonProductMaintenanceEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonProductMaintenanceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProductMaintenanceAdd);
            this.Controls.Add(this.buttonProductMaintenanceEdit);
            this.Controls.Add(this.dataGridViewProductMaintenance);
            this.Name = "ProductMaintenanceSearch";
            this.Text = "Product Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductMaintenance)).EndInit();
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
