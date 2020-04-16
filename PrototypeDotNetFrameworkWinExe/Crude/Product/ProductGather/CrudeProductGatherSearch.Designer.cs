namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductGatherSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherSearch;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherAdd;
        
        private System.Windows.Forms.Button buttonCrudeProductGatherEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeProductGather;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateTime;
        
        private System.Windows.Forms.Label labelStartDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishDateTime;
        
        private System.Windows.Forms.Label labelFinishDateTime;
        
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
            this.buttonCrudeProductGatherAdd = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherEdit = new System.Windows.Forms.Button();
            this.buttonCrudeProductGatherSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeProductGather = new System.Windows.Forms.DataGridView();
            this.labelStartDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFinishDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFinishDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGather)).BeginInit();
            this.SuspendLayout();
            //
            // labelStartDateTime
            //
            this.labelStartDateTime.AutoSize = true;
            this.labelStartDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelStartDateTime.Name = "labelStartDateTime";
            this.labelStartDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelStartDateTime.TabIndex = 2;
            this.labelStartDateTime.Text = "Start Date Time:";
            //
            //dateTimePickerStartDateTime
            //
            this.dateTimePickerStartDateTime.Location = new System.Drawing.Point(140, 13);
            this.dateTimePickerStartDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartDateTime.Name = "dateTimePickerStartDateTime";
            this.dateTimePickerStartDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerStartDateTime.TabIndex = 3;
            this.dateTimePickerStartDateTime.Checked = false;
            this.dateTimePickerStartDateTime.ShowCheckBox = true;
            //
            // labelFinishDateTime
            //
            this.labelFinishDateTime.AutoSize = true;
            this.labelFinishDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelFinishDateTime.Name = "labelFinishDateTime";
            this.labelFinishDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFinishDateTime.TabIndex = 4;
            this.labelFinishDateTime.Text = "Finish Date Time:";
            //
            //dateTimePickerFinishDateTime
            //
            this.dateTimePickerFinishDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerFinishDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFinishDateTime.Name = "dateTimePickerFinishDateTime";
            this.dateTimePickerFinishDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFinishDateTime.TabIndex = 5;
            this.dateTimePickerFinishDateTime.Checked = false;
            this.dateTimePickerFinishDateTime.ShowCheckBox = true;
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
            // dataGridViewCrudeProductGather
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeProductGather.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeProductGather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeProductGather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeProductGather.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeProductGather.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeProductGather.Name = "dataGridViewCrudeProductGather";
            this.dataGridViewCrudeProductGather.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeProductGather.TabIndex = 0;
            this.dataGridViewCrudeProductGather.ReadOnly = true;
            this.dataGridViewCrudeProductGather.DoubleClick += new System.EventHandler(this.dataGridViewCrudeProductGather_DoubleClick);
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
            // buttonCrudeProductGatherSearch
            // 
            this.buttonCrudeProductGatherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeProductGatherSearch.Name = "buttonCrudeProductGatherSearch";
            this.buttonCrudeProductGatherSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherSearch.TabIndex = 2;
            this.buttonCrudeProductGatherSearch.Text = "&Search";
            this.buttonCrudeProductGatherSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherSearch.Click += new System.EventHandler(this.buttonCrudeProductGatherSearch_Click);
            // 
            // buttonCrudeProductGatherAdd
            // 
            this.buttonCrudeProductGatherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeProductGatherAdd.Name = "buttonCrudeProductGatherAdd";
            this.buttonCrudeProductGatherAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherAdd.TabIndex = 3;
            this.buttonCrudeProductGatherAdd.Text = "&Add";
            this.buttonCrudeProductGatherAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherAdd.Click += new System.EventHandler(this.buttonCrudeProductGatherAdd_Click);
            // 
            // buttonCrudeProductGatherEdit
            // 
            this.buttonCrudeProductGatherEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeProductGatherEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeProductGatherEdit.Name = "buttonCrudeProductGatherEdit";
            this.buttonCrudeProductGatherEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeProductGatherEdit.TabIndex = 4;
            this.buttonCrudeProductGatherEdit.Text = "&Edit";
            this.buttonCrudeProductGatherEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeProductGatherEdit.Click += new System.EventHandler(this.buttonCrudeProductGatherEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeProductGatherSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeProductGatherAdd);
            this.Controls.Add(this.buttonCrudeProductGatherEdit);
            this.Controls.Add(this.dataGridViewCrudeProductGather);
            this.Name = "CrudeProductGatherSearch";
            this.Text = "Product Gather Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeProductGather)).EndInit();
            this.Controls.Add(this.labelStartDateTime);
            this.Controls.Add(this.dateTimePickerStartDateTime);
            this.Controls.Add(this.labelFinishDateTime);
            this.Controls.Add(this.dateTimePickerFinishDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
