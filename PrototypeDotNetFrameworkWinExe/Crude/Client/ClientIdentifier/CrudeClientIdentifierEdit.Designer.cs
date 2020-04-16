namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelClientIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.clientIdentifierTypeRefCombo = new ClientIdentifierTypeRefCombo();
            this.labelClientIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxClientIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 82);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(212, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientIdentifierEdit";
            this.Text = "Client Identifier Edit";
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
