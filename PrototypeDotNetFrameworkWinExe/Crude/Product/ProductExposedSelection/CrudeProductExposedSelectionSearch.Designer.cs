namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductExposedSelectionSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductExposedSelectionSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductExposedSelectionAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductExposedSelectionEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductExposedSelection;
        
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
            this.buttonCrudeProductExposedSelectionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposedSelectionEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductExposedSelectionSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductExposedSelection = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposedSelection)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            // 
            // dataGridViewCrudeProductExposedSelection
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductExposedSelection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductExposedSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductExposedSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductExposedSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductExposedSelection.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewCrudeProductExposedSelection.Name = "dataGridViewCrudeProductExposedSelection";
            this.dataGridViewCrudeProductExposedSelection.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductExposedSelection.TabIndex = 0;
            this.dataGridViewCrudeProductExposedSelection.ReadOnly = true;
            this.dataGridViewCrudeProductExposedSelection.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductExposedSelection_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 149);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeProductExposedSelectionSearch
            // 
            this.buttonCrudeProductExposedSelectionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposedSelectionSearch.Location = new System.Drawing.Point(198, 149);
            this.buttonCrudeProductExposedSelectionSearch.Name = "buttonCrudeProductExposedSelectionSearch";
            this.buttonCrudeProductExposedSelectionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposedSelectionSearch.TabIndex = 2;
            this.buttonCrudeProductExposedSelectionSearch.Text = "&Search";
            this.buttonCrudeProductExposedSelectionSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposedSelectionSearch.Click += new System.EventHandler(this.buttonCrudeProductExposedSelectionSearch_Click);
            // 
            // buttonCrudeProductExposedSelectionAdd
            // 
            this.buttonCrudeProductExposedSelectionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposedSelectionAdd.Location = new System.Drawing.Point(98, 149);
            this.buttonCrudeProductExposedSelectionAdd.Name = "buttonCrudeProductExposedSelectionAdd";
            this.buttonCrudeProductExposedSelectionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposedSelectionAdd.TabIndex = 3;
            this.buttonCrudeProductExposedSelectionAdd.Text = "&Add";
            this.buttonCrudeProductExposedSelectionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposedSelectionAdd.Click += new System.EventHandler(this.buttonCrudeProductExposedSelectionAdd_Click);
            // 
            // buttonCrudeProductExposedSelectionEdit
            // 
            this.buttonCrudeProductExposedSelectionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductExposedSelectionEdit.Location = new System.Drawing.Point(-2, 149);
            this.buttonCrudeProductExposedSelectionEdit.Name = "buttonCrudeProductExposedSelectionEdit";
            this.buttonCrudeProductExposedSelectionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductExposedSelectionEdit.TabIndex = 4;
            this.buttonCrudeProductExposedSelectionEdit.Text = "&Edit";
            this.buttonCrudeProductExposedSelectionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductExposedSelectionEdit.Click += new System.EventHandler(this.buttonCrudeProductExposedSelectionEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.buttonCrudeProductExposedSelectionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductExposedSelectionAdd);
            this.Controls.Add(this.buttonCrudeProductExposedSelectionEdit);
            this.Controls.Add(this.dataGridViewCrudeProductExposedSelection);
            this.Name = "CrudeProductExposedSelectionSearch";
            this.Text = "Product Exposed Selection Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductExposedSelection)).EndInit();
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
