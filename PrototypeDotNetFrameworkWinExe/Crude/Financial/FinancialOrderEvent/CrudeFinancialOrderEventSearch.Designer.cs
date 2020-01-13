namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialOrderEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialOrderEvent;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private FinancialOrderEventTypeRefCombo financialOrderEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialOrderEventTypeRefCombo;
        
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
            this.buttonCrudeFinancialOrderEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialOrderEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialOrderEvent = new System.Windows.Forms.DataGridView();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderEventTypeRefCombo = new System.Windows.Forms.Label();
            this.financialOrderEventTypeRefCombo = new FinancialOrderEventTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderEvent)).BeginInit();
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
            this.textBoxComment.Location = new System.Drawing.Point(182, 13);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 3;
            //
            // labelFinancialOrderEventTypeRefCombo
            //
            this.labelFinancialOrderEventTypeRefCombo.AutoSize = true;
            this.labelFinancialOrderEventTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderEventTypeRefCombo.Name = "labelFinancialOrderEventTypeRefCombo";
            this.labelFinancialOrderEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderEventTypeRefCombo.TabIndex = 4;
            this.labelFinancialOrderEventTypeRefCombo.Text = "Financial Order Event Type:";
            //
            //financialOrderEventTypeRefCombo
            //
            this.financialOrderEventTypeRefCombo.Location = new System.Drawing.Point(182, 36);
            this.financialOrderEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialOrderEventTypeRefCombo.Name = "financialOrderEventTypeRefCombo";
            this.financialOrderEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialOrderEventTypeRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(182, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeFinancialOrderEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialOrderEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialOrderEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialOrderEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialOrderEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialOrderEvent.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeFinancialOrderEvent.Name = "dataGridViewCrudeFinancialOrderEvent";
            this.dataGridViewCrudeFinancialOrderEvent.Size = new System.Drawing.Size(420, 96);
            this.dataGridViewCrudeFinancialOrderEvent.TabIndex = 0;
            this.dataGridViewCrudeFinancialOrderEvent.ReadOnly = true;
            this.dataGridViewCrudeFinancialOrderEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialOrderEvent_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialOrderEventSearch
            // 
            this.buttonCrudeFinancialOrderEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventSearch.Location = new System.Drawing.Point(240, 195);
            this.buttonCrudeFinancialOrderEventSearch.Name = "buttonCrudeFinancialOrderEventSearch";
            this.buttonCrudeFinancialOrderEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventSearch.TabIndex = 2;
            this.buttonCrudeFinancialOrderEventSearch.Text = "&Search";
            this.buttonCrudeFinancialOrderEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventSearch.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventSearch_Click);
            // 
            // buttonCrudeFinancialOrderEventAdd
            // 
            this.buttonCrudeFinancialOrderEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventAdd.Location = new System.Drawing.Point(140, 195);
            this.buttonCrudeFinancialOrderEventAdd.Name = "buttonCrudeFinancialOrderEventAdd";
            this.buttonCrudeFinancialOrderEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventAdd.TabIndex = 3;
            this.buttonCrudeFinancialOrderEventAdd.Text = "&Add";
            this.buttonCrudeFinancialOrderEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventAdd.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventAdd_Click);
            // 
            // buttonCrudeFinancialOrderEventEdit
            // 
            this.buttonCrudeFinancialOrderEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialOrderEventEdit.Location = new System.Drawing.Point(40, 195);
            this.buttonCrudeFinancialOrderEventEdit.Name = "buttonCrudeFinancialOrderEventEdit";
            this.buttonCrudeFinancialOrderEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialOrderEventEdit.TabIndex = 4;
            this.buttonCrudeFinancialOrderEventEdit.Text = "&Edit";
            this.buttonCrudeFinancialOrderEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialOrderEventEdit.Click += new System.EventHandler(this.buttonCrudeFinancialOrderEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventAdd);
            this.Controls.Add(this.buttonCrudeFinancialOrderEventEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialOrderEvent);
            this.Name = "CrudeFinancialOrderEventSearch";
            this.Text = "Financial Order Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialOrderEvent)).EndInit();
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelFinancialOrderEventTypeRefCombo);
            this.Controls.Add(this.financialOrderEventTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
