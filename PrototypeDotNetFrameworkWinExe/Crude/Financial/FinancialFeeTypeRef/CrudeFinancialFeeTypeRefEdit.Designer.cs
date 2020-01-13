namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialFeeType;
        
        private System.Windows.Forms.Label labelFinancialFeeType;
        
        private System.Windows.Forms.TextBox textBoxFinancialFeeTypeName;
        
        private System.Windows.Forms.Label labelFinancialFeeTypeName;
        
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
            this.labelFinancialFeeType = new System.Windows.Forms.Label();
            this.textBoxFinancialFeeType = new System.Windows.Forms.TextBox();
            this.labelFinancialFeeTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialFeeTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialFeeType
            //
            this.labelFinancialFeeType.AutoSize = true;
            this.labelFinancialFeeType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFeeType.Name = "labelFinancialFeeType";
            this.labelFinancialFeeType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFeeType.TabIndex = 2;
            this.labelFinancialFeeType.Text = "Financial Fee Type:";
            //
            //textBoxFinancialFeeType
            //
            this.textBoxFinancialFeeType.Location = new System.Drawing.Point(161, 13);
            this.textBoxFinancialFeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFeeType.Name = "textBoxFinancialFeeType";
            this.textBoxFinancialFeeType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFeeType.TabIndex = 3;
            //
            // labelFinancialFeeTypeName
            //
            this.labelFinancialFeeTypeName.AutoSize = true;
            this.labelFinancialFeeTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialFeeTypeName.Name = "labelFinancialFeeTypeName";
            this.labelFinancialFeeTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFeeTypeName.TabIndex = 4;
            this.labelFinancialFeeTypeName.Text = "Financial Fee Type Name:";
            //
            //textBoxFinancialFeeTypeName
            //
            this.textBoxFinancialFeeTypeName.Location = new System.Drawing.Point(161, 36);
            this.textBoxFinancialFeeTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialFeeTypeName.Name = "textBoxFinancialFeeTypeName";
            this.textBoxFinancialFeeTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialFeeTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(219, 82);
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
            this.ClientSize = new System.Drawing.Size(423, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialFeeTypeRefEdit";
            this.Text = "Financial Fee Type Ref Edit";
            this.Controls.Add(this.labelFinancialFeeType);
            this.Controls.Add(this.textBoxFinancialFeeType);
            this.Controls.Add(this.labelFinancialFeeTypeName);
            this.Controls.Add(this.textBoxFinancialFeeTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
