namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductChangeSetSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductChangeSetSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductChangeSetAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductChangeSetEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductChangeSet;
        
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
            this.buttonCrudeProductChangeSetAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductChangeSetEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductChangeSetSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductChangeSet = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductChangeSet)).BeginInit();
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
            // dataGridViewCrudeProductChangeSet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductChangeSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductChangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductChangeSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductChangeSet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductChangeSet.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewCrudeProductChangeSet.Name = "dataGridViewCrudeProductChangeSet";
            this.dataGridViewCrudeProductChangeSet.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductChangeSet.TabIndex = 0;
            this.dataGridViewCrudeProductChangeSet.ReadOnly = true;
            this.dataGridViewCrudeProductChangeSet.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductChangeSet_DoubleClick);
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
            // buttonCrudeProductChangeSetSearch
            // 
            this.buttonCrudeProductChangeSetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductChangeSetSearch.Location = new System.Drawing.Point(198, 149);
            this.buttonCrudeProductChangeSetSearch.Name = "buttonCrudeProductChangeSetSearch";
            this.buttonCrudeProductChangeSetSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductChangeSetSearch.TabIndex = 2;
            this.buttonCrudeProductChangeSetSearch.Text = "&Search";
            this.buttonCrudeProductChangeSetSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductChangeSetSearch.Click += new System.EventHandler(this.buttonCrudeProductChangeSetSearch_Click);
            // 
            // buttonCrudeProductChangeSetAdd
            // 
            this.buttonCrudeProductChangeSetAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductChangeSetAdd.Location = new System.Drawing.Point(98, 149);
            this.buttonCrudeProductChangeSetAdd.Name = "buttonCrudeProductChangeSetAdd";
            this.buttonCrudeProductChangeSetAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductChangeSetAdd.TabIndex = 3;
            this.buttonCrudeProductChangeSetAdd.Text = "&Add";
            this.buttonCrudeProductChangeSetAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductChangeSetAdd.Click += new System.EventHandler(this.buttonCrudeProductChangeSetAdd_Click);
            // 
            // buttonCrudeProductChangeSetEdit
            // 
            this.buttonCrudeProductChangeSetEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductChangeSetEdit.Location = new System.Drawing.Point(-2, 149);
            this.buttonCrudeProductChangeSetEdit.Name = "buttonCrudeProductChangeSetEdit";
            this.buttonCrudeProductChangeSetEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductChangeSetEdit.TabIndex = 4;
            this.buttonCrudeProductChangeSetEdit.Text = "&Edit";
            this.buttonCrudeProductChangeSetEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductChangeSetEdit.Click += new System.EventHandler(this.buttonCrudeProductChangeSetEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 177);
            this.Controls.Add(this.buttonCrudeProductChangeSetSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductChangeSetAdd);
            this.Controls.Add(this.buttonCrudeProductChangeSetEdit);
            this.Controls.Add(this.dataGridViewCrudeProductChangeSet);
            this.Name = "CrudeProductChangeSetSearch";
            this.Text = "Product Change Set Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductChangeSet)).EndInit();
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
