namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCardTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialCardType;
        
        private System.Windows.Forms.Label labelFinancialCardType;
        
        private System.Windows.Forms.TextBox textBoxFinancialCardTypeName;
        
        private System.Windows.Forms.Label labelFinancialCardTypeName;
        
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
            this.labelFinancialCardType = new System.Windows.Forms.Label();
            this.textBoxFinancialCardType = new System.Windows.Forms.TextBox();
            this.labelFinancialCardTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialCardTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialCardType
            //
            this.labelFinancialCardType.AutoSize = true;
            this.labelFinancialCardType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialCardType.Name = "labelFinancialCardType";
            this.labelFinancialCardType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardType.TabIndex = 2;
            this.labelFinancialCardType.Text = "Financial Card Type:";
            //
            //textBoxFinancialCardType
            //
            this.textBoxFinancialCardType.Location = new System.Drawing.Point(168, 13);
            this.textBoxFinancialCardType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCardType.Name = "textBoxFinancialCardType";
            this.textBoxFinancialCardType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCardType.TabIndex = 3;
            //
            // labelFinancialCardTypeName
            //
            this.labelFinancialCardTypeName.AutoSize = true;
            this.labelFinancialCardTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialCardTypeName.Name = "labelFinancialCardTypeName";
            this.labelFinancialCardTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCardTypeName.TabIndex = 4;
            this.labelFinancialCardTypeName.Text = "Financial Card Type Name:";
            //
            //textBoxFinancialCardTypeName
            //
            this.textBoxFinancialCardTypeName.Location = new System.Drawing.Point(168, 36);
            this.textBoxFinancialCardTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialCardTypeName.Name = "textBoxFinancialCardTypeName";
            this.textBoxFinancialCardTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialCardTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 82);
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
            this.ClientSize = new System.Drawing.Size(430, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialCardTypeRefEdit";
            this.Text = "Financial Card Type Ref Edit";
            this.Controls.Add(this.labelFinancialCardType);
            this.Controls.Add(this.textBoxFinancialCardType);
            this.Controls.Add(this.labelFinancialCardTypeName);
            this.Controls.Add(this.textBoxFinancialCardTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
