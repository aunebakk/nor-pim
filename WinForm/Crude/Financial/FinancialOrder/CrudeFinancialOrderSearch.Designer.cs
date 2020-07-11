namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeFinancialOrderSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrder;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderSource;
        
        private System.Windows.Forms.Label labelFinancialOrderSource;
        
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
            this.buttonCrudeFinancialOrderAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrder = new System.Windows.Forms.DataGridView();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderSource = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderSource = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrder)).BeginInit();
            this.SuspendLayout();
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 13);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(154, 13);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 3;
            //
            // labelFinancialOrderSource
            //
            this.labelFinancialOrderSource.AutoSize = true;
            this.labelFinancialOrderSource.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderSource.Name = "labelFinancialOrderSource";
            this.labelFinancialOrderSource.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderSource.TabIndex = 4;
            this.labelFinancialOrderSource.Text = "Financial Order Source:";
            //
            //textBoxFinancialOrderSource
            //
            this.textBoxFinancialOrderSource.Location = new System.Drawing.Point(154, 36);
            this.textBoxFinancialOrderSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderSource.Name = "textBoxFinancialOrderSource";
            this.textBoxFinancialOrderSource.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderSource.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrder.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialOrder.Name = "dataGridViewCrudeFinancialOrder";
            this.dataGridViewCrudeFinancialOrder.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFinancialOrder.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrder.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrder.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrder_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderSearch
            // 
            this.buttonCrudeFinancialOrderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderSearch.Location = new System.Drawing.Point(212, 195);
            this.buttonCrudeFinancialOrderSearch.Name = "buttonCrudeFinancialOrderSearch";
            this.buttonCrudeFinancialOrderSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderSearch_Click);
            // 
            // buttonCrudeFinancialOrderAdd
            // 
            this.buttonCrudeFinancialOrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderAdd.Location = new System.Drawing.Point(112, 195);
            this.buttonCrudeFinancialOrderAdd.Name = "buttonCrudeFinancialOrderAdd";
            this.buttonCrudeFinancialOrderAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderAdd_Click);
            // 
            // buttonCrudeFinancialOrderEdit
            // 
            this.buttonCrudeFinancialOrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEdit.Location = new System.Drawing.Point(12, 195);
            this.buttonCrudeFinancialOrderEdit.Name = "buttonCrudeFinancialOrderEdit";
            this.buttonCrudeFinancialOrderEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.buttonCrudeFinancialOrderSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrder);
            this.Name = "CrudeFinancialOrderSearch";
            this.Text = "Financial Order Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrder)).EndInit();
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelFinancialOrderSource);
            this.Controls.Add(this.textBoxFinancialOrderSource);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
