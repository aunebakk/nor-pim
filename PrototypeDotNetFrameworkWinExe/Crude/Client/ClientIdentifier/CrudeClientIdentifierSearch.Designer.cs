namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientIdentifier;
        
        private ClientIdentifierTypeRefCombo clientIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxClientIdentifierCode;
        
        private System.Windows.Forms.Label labelClientIdentifierCode;
        
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
            this.buttonCrudeClientIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientIdentifier = new System.Windows.Forms.DataGridView();
            this.labelClientIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.clientIdentifierTypeRefCombo = new ClientIdentifierTypeRefCombo();
            this.labelClientIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientIdentifierTypeRefCombo
            //
            this.labelClientIdentifierTypeRefCombo.AutoSize = true;
            this.labelClientIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientIdentifierTypeRefCombo.Name = "labelClientIdentifierTypeRefCombo";
            this.labelClientIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierTypeRefCombo.TabIndex = 2;
            this.labelClientIdentifierTypeRefCombo.Text = "Client Identifier Type:";
            //
            //clientIdentifierTypeRefCombo
            //
            this.clientIdentifierTypeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.clientIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientIdentifierTypeRefCombo.Name = "clientIdentifierTypeRefCombo";
            this.clientIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelClientIdentifierCode
            //
            this.labelClientIdentifierCode.AutoSize = true;
            this.labelClientIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelClientIdentifierCode.Name = "labelClientIdentifierCode";
            this.labelClientIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelClientIdentifierCode.TabIndex = 4;
            this.labelClientIdentifierCode.Text = "Client Identifier Code:";
            //
            //textBoxClientIdentifierCode
            //
            this.textBoxClientIdentifierCode.Location = new System.Drawing.Point(154, 36);
            this.textBoxClientIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientIdentifierCode.Name = "textBoxClientIdentifierCode";
            this.textBoxClientIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxClientIdentifierCode.TabIndex = 5;
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
            // dataGridViewCrudeClientIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientIdentifier.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeClientIdentifier.Name = "dataGridViewCrudeClientIdentifier";
            this.dataGridViewCrudeClientIdentifier.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeClientIdentifier.TabIndex = 0;
            this.dataGridViewCrudeClientIdentifier.ReadOnly = true;
            this.dataGridViewCrudeClientIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientIdentifier_DoubleClick);
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
            // buttonCrudeClientIdentifierSearch
            // 
            this.buttonCrudeClientIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierSearch.Location = new System.Drawing.Point(212, 195);
            this.buttonCrudeClientIdentifierSearch.Name = "buttonCrudeClientIdentifierSearch";
            this.buttonCrudeClientIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierSearch.TabIndex = 2;
            this.buttonCrudeClientIdentifierSearch.Text = "&Search";
            this.buttonCrudeClientIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeClientIdentifierSearch_Click);
            // 
            // buttonCrudeClientIdentifierAdd
            // 
            this.buttonCrudeClientIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierAdd.Location = new System.Drawing.Point(112, 195);
            this.buttonCrudeClientIdentifierAdd.Name = "buttonCrudeClientIdentifierAdd";
            this.buttonCrudeClientIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierAdd.TabIndex = 3;
            this.buttonCrudeClientIdentifierAdd.Text = "&Add";
            this.buttonCrudeClientIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeClientIdentifierAdd_Click);
            // 
            // buttonCrudeClientIdentifierEdit
            // 
            this.buttonCrudeClientIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientIdentifierEdit.Location = new System.Drawing.Point(12, 195);
            this.buttonCrudeClientIdentifierEdit.Name = "buttonCrudeClientIdentifierEdit";
            this.buttonCrudeClientIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientIdentifierEdit.TabIndex = 4;
            this.buttonCrudeClientIdentifierEdit.Text = "&Edit";
            this.buttonCrudeClientIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeClientIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.buttonCrudeClientIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientIdentifierAdd);
            this.Controls.Add(this.buttonCrudeClientIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeClientIdentifier);
            this.Name = "CrudeClientIdentifierSearch";
            this.Text = "Client Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientIdentifier)).EndInit();
            this.Controls.Add(this.labelClientIdentifierTypeRefCombo);
            this.Controls.Add(this.clientIdentifierTypeRefCombo);
            this.Controls.Add(this.labelClientIdentifierCode);
            this.Controls.Add(this.textBoxClientIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
