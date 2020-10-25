namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientDocumentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientDocumentSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientDocumentAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientDocumentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientDocument;
        
        private System.Windows.Forms.TextBox textBoxDocumentName;
        
        private System.Windows.Forms.Label labelDocumentName;
        
        private ClientDocumentTypeRefCombo clientDocumentTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientDocumentTypeRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDocumentDateTime;
        
        private System.Windows.Forms.Label labelDocumentDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDateTime;
        
        private System.Windows.Forms.Label labelExpiryDateTime;
        
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
            this.buttonCrudeClientDocumentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientDocumentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientDocumentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientDocument = new System.Windows.Forms.DataGridView();
            this.labelDocumentName = new System.Windows.Forms.Label();
            this.textBoxDocumentName = new System.Windows.Forms.TextBox();
            this.labelClientDocumentTypeRefCombo = new System.Windows.Forms.Label();
            this.clientDocumentTypeRefCombo = new ClientDocumentTypeRefCombo();
            this.labelDocumentDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDocumentDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelExpiryDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientDocument)).BeginInit();
            this.SuspendLayout();
            //
            // labelDocumentName
            //
            this.labelDocumentName.AutoSize = true;
            this.labelDocumentName.Location = new System.Drawing.Point(11, 13);
            this.labelDocumentName.Name = "labelDocumentName";
            this.labelDocumentName.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentName.TabIndex = 2;
            this.labelDocumentName.Text = "Document Name:";
            //
            //textBoxDocumentName
            //
            this.textBoxDocumentName.Location = new System.Drawing.Point(140, 13);
            this.textBoxDocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocumentName.Name = "textBoxDocumentName";
            this.textBoxDocumentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentName.TabIndex = 3;
            //
            // labelClientDocumentTypeRefCombo
            //
            this.labelClientDocumentTypeRefCombo.AutoSize = true;
            this.labelClientDocumentTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelClientDocumentTypeRefCombo.Name = "labelClientDocumentTypeRefCombo";
            this.labelClientDocumentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientDocumentTypeRefCombo.TabIndex = 4;
            this.labelClientDocumentTypeRefCombo.Text = "Client Document Type:";
            //
            //clientDocumentTypeRefCombo
            //
            this.clientDocumentTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.clientDocumentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDocumentTypeRefCombo.Name = "clientDocumentTypeRefCombo";
            this.clientDocumentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientDocumentTypeRefCombo.TabIndex = 5;
            //
            // labelDocumentDateTime
            //
            this.labelDocumentDateTime.AutoSize = true;
            this.labelDocumentDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDocumentDateTime.Name = "labelDocumentDateTime";
            this.labelDocumentDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentDateTime.TabIndex = 6;
            this.labelDocumentDateTime.Text = "Document Date Time:";
            //
            //dateTimePickerDocumentDateTime
            //
            this.dateTimePickerDocumentDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDocumentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDocumentDateTime.Name = "dateTimePickerDocumentDateTime";
            this.dateTimePickerDocumentDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDocumentDateTime.TabIndex = 7;
            this.dateTimePickerDocumentDateTime.Checked = false;
            this.dateTimePickerDocumentDateTime.ShowCheckBox = true;
            //
            // labelExpiryDateTime
            //
            this.labelExpiryDateTime.AutoSize = true;
            this.labelExpiryDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelExpiryDateTime.Name = "labelExpiryDateTime";
            this.labelExpiryDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryDateTime.TabIndex = 8;
            this.labelExpiryDateTime.Text = "Expiry Date Time:";
            //
            //dateTimePickerExpiryDateTime
            //
            this.dateTimePickerExpiryDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerExpiryDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerExpiryDateTime.Name = "dateTimePickerExpiryDateTime";
            this.dateTimePickerExpiryDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerExpiryDateTime.TabIndex = 9;
            this.dateTimePickerExpiryDateTime.Checked = false;
            this.dateTimePickerExpiryDateTime.ShowCheckBox = true;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // dataGridViewCrudeClientDocument
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientDocument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientDocument.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeClientDocument.Name = "dataGridViewCrudeClientDocument";
            this.dataGridViewCrudeClientDocument.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientDocument.TabIndex = 0;
            this.dataGridViewCrudeClientDocument.ReadOnly = true;
            this.dataGridViewCrudeClientDocument.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientDocument_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientDocumentSearch
            // 
            this.buttonCrudeClientDocumentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeClientDocumentSearch.Name = "buttonCrudeClientDocumentSearch";
            this.buttonCrudeClientDocumentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentSearch.TabIndex = 2;
            this.buttonCrudeClientDocumentSearch.Text = "&Search";
            this.buttonCrudeClientDocumentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentSearch.Click += new System.EventHandler(this.buttonCrudeClientDocumentSearch_Click);
            // 
            // buttonCrudeClientDocumentAdd
            // 
            this.buttonCrudeClientDocumentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeClientDocumentAdd.Name = "buttonCrudeClientDocumentAdd";
            this.buttonCrudeClientDocumentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentAdd.TabIndex = 3;
            this.buttonCrudeClientDocumentAdd.Text = "&Add";
            this.buttonCrudeClientDocumentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentAdd.Click += new System.EventHandler(this.buttonCrudeClientDocumentAdd_Click);
            // 
            // buttonCrudeClientDocumentEdit
            // 
            this.buttonCrudeClientDocumentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientDocumentEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeClientDocumentEdit.Name = "buttonCrudeClientDocumentEdit";
            this.buttonCrudeClientDocumentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientDocumentEdit.TabIndex = 4;
            this.buttonCrudeClientDocumentEdit.Text = "&Edit";
            this.buttonCrudeClientDocumentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientDocumentEdit.Click += new System.EventHandler(this.buttonCrudeClientDocumentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeClientDocumentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientDocumentAdd);
            this.Controls.Add(this.buttonCrudeClientDocumentEdit);
            this.Controls.Add(this.dataGridViewCrudeClientDocument);
            this.Name = "CrudeClientDocumentSearch";
            this.Text = "Client Document Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientDocument)).EndInit();
            this.Controls.Add(this.labelDocumentName);
            this.Controls.Add(this.textBoxDocumentName);
            this.Controls.Add(this.labelClientDocumentTypeRefCombo);
            this.Controls.Add(this.clientDocumentTypeRefCombo);
            this.Controls.Add(this.labelDocumentDateTime);
            this.Controls.Add(this.dateTimePickerDocumentDateTime);
            this.Controls.Add(this.labelExpiryDateTime);
            this.Controls.Add(this.dateTimePickerExpiryDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
