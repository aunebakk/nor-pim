namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientLink;
        
        private System.Windows.Forms.TextBox textBoxLinkName;
        
        private System.Windows.Forms.Label labelLinkName;
        
        private ClientLinkTypeRefCombo clientLinkTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLink;
        
        private System.Windows.Forms.Label labelLink;
        
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
            this.buttonCrudeClientLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientLink = new System.Windows.Forms.DataGridView();
            this.labelLinkName = new System.Windows.Forms.Label();
            this.textBoxLinkName = new System.Windows.Forms.TextBox();
            this.labelClientLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.clientLinkTypeRefCombo = new ClientLinkTypeRefCombo();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientLink)).BeginInit();
            this.SuspendLayout();
            //
            // labelLinkName
            //
            this.labelLinkName.AutoSize = true;
            this.labelLinkName.Location = new System.Drawing.Point(11, 13);
            this.labelLinkName.Name = "labelLinkName";
            this.labelLinkName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkName.TabIndex = 2;
            this.labelLinkName.Text = "Link Name:";
            //
            //textBoxLinkName
            //
            this.textBoxLinkName.Location = new System.Drawing.Point(140, 13);
            this.textBoxLinkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkName.Name = "textBoxLinkName";
            this.textBoxLinkName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkName.TabIndex = 3;
            //
            // labelClientLinkTypeRefCombo
            //
            this.labelClientLinkTypeRefCombo.AutoSize = true;
            this.labelClientLinkTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelClientLinkTypeRefCombo.Name = "labelClientLinkTypeRefCombo";
            this.labelClientLinkTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientLinkTypeRefCombo.TabIndex = 4;
            this.labelClientLinkTypeRefCombo.Text = "Client Link Type:";
            //
            //clientLinkTypeRefCombo
            //
            this.clientLinkTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.clientLinkTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLinkTypeRefCombo.Name = "clientLinkTypeRefCombo";
            this.clientLinkTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientLinkTypeRefCombo.TabIndex = 5;
            //
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 59);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 6;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 59);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeClientLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientLink.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeClientLink.Name = "dataGridViewCrudeClientLink";
            this.dataGridViewCrudeClientLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientLink.TabIndex = 0;
            this.dataGridViewCrudeClientLink.ReadOnly = true;
            this.dataGridViewCrudeClientLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientLink_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientLinkSearch
            // 
            this.buttonCrudeClientLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeClientLinkSearch.Name = "buttonCrudeClientLinkSearch";
            this.buttonCrudeClientLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkSearch.TabIndex = 2;
            this.buttonCrudeClientLinkSearch.Text = "&Search";
            this.buttonCrudeClientLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkSearch.Click += new System.EventHandler(this.buttonCrudeClientLinkSearch_Click);
            // 
            // buttonCrudeClientLinkAdd
            // 
            this.buttonCrudeClientLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeClientLinkAdd.Name = "buttonCrudeClientLinkAdd";
            this.buttonCrudeClientLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkAdd.TabIndex = 3;
            this.buttonCrudeClientLinkAdd.Text = "&Add";
            this.buttonCrudeClientLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkAdd.Click += new System.EventHandler(this.buttonCrudeClientLinkAdd_Click);
            // 
            // buttonCrudeClientLinkEdit
            // 
            this.buttonCrudeClientLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientLinkEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeClientLinkEdit.Name = "buttonCrudeClientLinkEdit";
            this.buttonCrudeClientLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientLinkEdit.TabIndex = 4;
            this.buttonCrudeClientLinkEdit.Text = "&Edit";
            this.buttonCrudeClientLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientLinkEdit.Click += new System.EventHandler(this.buttonCrudeClientLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeClientLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientLinkAdd);
            this.Controls.Add(this.buttonCrudeClientLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeClientLink);
            this.Name = "CrudeClientLinkSearch";
            this.Text = "Client Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientLink)).EndInit();
            this.Controls.Add(this.labelLinkName);
            this.Controls.Add(this.textBoxLinkName);
            this.Controls.Add(this.labelClientLinkTypeRefCombo);
            this.Controls.Add(this.clientLinkTypeRefCombo);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
