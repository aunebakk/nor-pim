namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private FinancialOrderIdentifierTypeRefCombo financialOrderIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderIdentifierCode;
        
        private System.Windows.Forms.Label labelFinancialOrderIdentifierCode;
        
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
            this.labelFinancialOrderIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.financialOrderIdentifierTypeRefCombo = new FinancialOrderIdentifierTypeRefCombo();
            this.labelFinancialOrderIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialOrderIdentifierTypeRefCombo
            //
            this.labelFinancialOrderIdentifierTypeRefCombo.AutoSize = true;
            this.labelFinancialOrderIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderIdentifierTypeRefCombo.Name = "labelFinancialOrderIdentifierTypeRefCombo";
            this.labelFinancialOrderIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierTypeRefCombo.TabIndex = 2;
            this.labelFinancialOrderIdentifierTypeRefCombo.Text = "Financial Order Identifier Type:";
            //
            //financialOrderIdentifierTypeRefCombo
            //
            this.financialOrderIdentifierTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.financialOrderIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialOrderIdentifierTypeRefCombo.Name = "financialOrderIdentifierTypeRefCombo";
            this.financialOrderIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialOrderIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelFinancialOrderIdentifierCode
            //
            this.labelFinancialOrderIdentifierCode.AutoSize = true;
            this.labelFinancialOrderIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderIdentifierCode.Name = "labelFinancialOrderIdentifierCode";
            this.labelFinancialOrderIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderIdentifierCode.TabIndex = 4;
            this.labelFinancialOrderIdentifierCode.Text = "Financial Order Identifier Code:";
            //
            //textBoxFinancialOrderIdentifierCode
            //
            this.textBoxFinancialOrderIdentifierCode.Location = new System.Drawing.Point(217, 36);
            this.textBoxFinancialOrderIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderIdentifierCode.Name = "textBoxFinancialOrderIdentifierCode";
            this.textBoxFinancialOrderIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderIdentifierCode.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(275, 82);
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
            this.ClientSize = new System.Drawing.Size(479, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialOrderIdentifierEdit";
            this.Text = "Financial Order Identifier Edit";
            this.Controls.Add(this.labelFinancialOrderIdentifierTypeRefCombo);
            this.Controls.Add(this.financialOrderIdentifierTypeRefCombo);
            this.Controls.Add(this.labelFinancialOrderIdentifierCode);
            this.Controls.Add(this.textBoxFinancialOrderIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
