namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialPaymentType;
        
        private System.Windows.Forms.Label labelFinancialPaymentType;
        
        private System.Windows.Forms.TextBox textBoxFinancialPaymentTypeName;
        
        private System.Windows.Forms.Label labelFinancialPaymentTypeName;
        
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
            this.labelFinancialPaymentType = new System.Windows.Forms.Label();
            this.textBoxFinancialPaymentType = new System.Windows.Forms.TextBox();
            this.labelFinancialPaymentTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialPaymentTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialPaymentType
            //
            this.labelFinancialPaymentType.AutoSize = true;
            this.labelFinancialPaymentType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialPaymentType.Name = "labelFinancialPaymentType";
            this.labelFinancialPaymentType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialPaymentType.TabIndex = 2;
            this.labelFinancialPaymentType.Text = "Financial Payment Type:";
            //
            //textBoxFinancialPaymentType
            //
            this.textBoxFinancialPaymentType.Location = new System.Drawing.Point(189, 13);
            this.textBoxFinancialPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialPaymentType.Name = "textBoxFinancialPaymentType";
            this.textBoxFinancialPaymentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialPaymentType.TabIndex = 3;
            //
            // labelFinancialPaymentTypeName
            //
            this.labelFinancialPaymentTypeName.AutoSize = true;
            this.labelFinancialPaymentTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialPaymentTypeName.Name = "labelFinancialPaymentTypeName";
            this.labelFinancialPaymentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialPaymentTypeName.TabIndex = 4;
            this.labelFinancialPaymentTypeName.Text = "Financial Payment Type Name:";
            //
            //textBoxFinancialPaymentTypeName
            //
            this.textBoxFinancialPaymentTypeName.Location = new System.Drawing.Point(189, 36);
            this.textBoxFinancialPaymentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialPaymentTypeName.Name = "textBoxFinancialPaymentTypeName";
            this.textBoxFinancialPaymentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialPaymentTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(247, 82);
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
            this.ClientSize = new System.Drawing.Size(451, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialPaymentTypeRefEdit";
            this.Text = "Financial Payment Type Ref Edit";
            this.Controls.Add(this.labelFinancialPaymentType);
            this.Controls.Add(this.textBoxFinancialPaymentType);
            this.Controls.Add(this.labelFinancialPaymentTypeName);
            this.Controls.Add(this.textBoxFinancialPaymentTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
