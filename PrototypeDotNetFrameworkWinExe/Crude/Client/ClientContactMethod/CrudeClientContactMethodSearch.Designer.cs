namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientContactMethodSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientContactMethod;
        
        private ClientContactMethodRefCombo clientContactMethodRefCombo;
        
        private System.Windows.Forms.Label labelClientContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
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
            this.buttonCrudeClientContactMethodAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientContactMethod = new System.Windows.Forms.DataGridView();
            this.labelClientContactMethodRefCombo = new System.Windows.Forms.Label();
            this.clientContactMethodRefCombo = new ClientContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethod)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientContactMethodRefCombo
            //
            this.labelClientContactMethodRefCombo.AutoSize = true;
            this.labelClientContactMethodRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientContactMethodRefCombo.Name = "labelClientContactMethodRefCombo";
            this.labelClientContactMethodRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodRefCombo.TabIndex = 2;
            this.labelClientContactMethodRefCombo.Text = "Client Contact Method:";
            //
            //clientContactMethodRefCombo
            //
            this.clientContactMethodRefCombo.Location = new System.Drawing.Point(147, 13);
            this.clientContactMethodRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientContactMethodRefCombo.Name = "clientContactMethodRefCombo";
            this.clientContactMethodRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientContactMethodRefCombo.TabIndex = 3;
            //
            // labelContactMethodWay
            //
            this.labelContactMethodWay.AutoSize = true;
            this.labelContactMethodWay.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethodWay.Name = "labelContactMethodWay";
            this.labelContactMethodWay.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodWay.TabIndex = 4;
            this.labelContactMethodWay.Text = "Contact Method Way:";
            //
            //textBoxContactMethodWay
            //
            this.textBoxContactMethodWay.Location = new System.Drawing.Point(147, 36);
            this.textBoxContactMethodWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodWay.Name = "textBoxContactMethodWay";
            this.textBoxContactMethodWay.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodWay.TabIndex = 5;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 59);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(147, 59);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeClientContactMethod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientContactMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientContactMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientContactMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientContactMethod.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeClientContactMethod.Name = "dataGridViewCrudeClientContactMethod";
            this.dataGridViewCrudeClientContactMethod.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeClientContactMethod.TabIndex = 0;
            this.dataGridViewCrudeClientContactMethod.ReadOnly = true;
            this.dataGridViewCrudeClientContactMethod.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientContactMethod_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientContactMethodSearch
            // 
            this.buttonCrudeClientContactMethodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodSearch.Location = new System.Drawing.Point(205, 218);
            this.buttonCrudeClientContactMethodSearch.Name = "buttonCrudeClientContactMethodSearch";
            this.buttonCrudeClientContactMethodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodSearch.TabIndex = 2;
            this.buttonCrudeClientContactMethodSearch.Text = "&Search";
            this.buttonCrudeClientContactMethodSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodSearch.Click += new System.EventHandler(this.buttonCrudeClientContactMethodSearch_Click);
            // 
            // buttonCrudeClientContactMethodAdd
            // 
            this.buttonCrudeClientContactMethodAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodAdd.Location = new System.Drawing.Point(105, 218);
            this.buttonCrudeClientContactMethodAdd.Name = "buttonCrudeClientContactMethodAdd";
            this.buttonCrudeClientContactMethodAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodAdd.TabIndex = 3;
            this.buttonCrudeClientContactMethodAdd.Text = "&Add";
            this.buttonCrudeClientContactMethodAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodAdd.Click += new System.EventHandler(this.buttonCrudeClientContactMethodAdd_Click);
            // 
            // buttonCrudeClientContactMethodEdit
            // 
            this.buttonCrudeClientContactMethodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodEdit.Location = new System.Drawing.Point(5, 218);
            this.buttonCrudeClientContactMethodEdit.Name = "buttonCrudeClientContactMethodEdit";
            this.buttonCrudeClientContactMethodEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodEdit.TabIndex = 4;
            this.buttonCrudeClientContactMethodEdit.Text = "&Edit";
            this.buttonCrudeClientContactMethodEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodEdit.Click += new System.EventHandler(this.buttonCrudeClientContactMethodEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.buttonCrudeClientContactMethodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientContactMethodAdd);
            this.Controls.Add(this.buttonCrudeClientContactMethodEdit);
            this.Controls.Add(this.dataGridViewCrudeClientContactMethod);
            this.Name = "CrudeClientContactMethodSearch";
            this.Text = "Client Contact Method Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethod)).EndInit();
            this.Controls.Add(this.labelClientContactMethodRefCombo);
            this.Controls.Add(this.clientContactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
