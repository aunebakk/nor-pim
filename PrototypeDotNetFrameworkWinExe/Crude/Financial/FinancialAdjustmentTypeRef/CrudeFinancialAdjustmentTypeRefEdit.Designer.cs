namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialAdjustmentType;
        
        private System.Windows.Forms.Label labelFinancialAdjustmentType;
        
        private System.Windows.Forms.TextBox textBoxFinancialAdjustmentTypeName;
        
        private System.Windows.Forms.Label labelFinancialAdjustmentTypeName;
        
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
            this.labelFinancialAdjustmentType = new System.Windows.Forms.Label();
            this.textBoxFinancialAdjustmentType = new System.Windows.Forms.TextBox();
            this.labelFinancialAdjustmentTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialAdjustmentTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialAdjustmentType
            //
            this.labelFinancialAdjustmentType.AutoSize = true;
            this.labelFinancialAdjustmentType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialAdjustmentType.Name = "labelFinancialAdjustmentType";
            this.labelFinancialAdjustmentType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialAdjustmentType.TabIndex = 2;
            this.labelFinancialAdjustmentType.Text = "Financial Adjustment Type:";
            //
            //textBoxFinancialAdjustmentType
            //
            this.textBoxFinancialAdjustmentType.Location = new System.Drawing.Point(210, 13);
            this.textBoxFinancialAdjustmentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialAdjustmentType.Name = "textBoxFinancialAdjustmentType";
            this.textBoxFinancialAdjustmentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialAdjustmentType.TabIndex = 3;
            //
            // labelFinancialAdjustmentTypeName
            //
            this.labelFinancialAdjustmentTypeName.AutoSize = true;
            this.labelFinancialAdjustmentTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialAdjustmentTypeName.Name = "labelFinancialAdjustmentTypeName";
            this.labelFinancialAdjustmentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialAdjustmentTypeName.TabIndex = 4;
            this.labelFinancialAdjustmentTypeName.Text = "Financial Adjustment Type Name:";
            //
            //textBoxFinancialAdjustmentTypeName
            //
            this.textBoxFinancialAdjustmentTypeName.Location = new System.Drawing.Point(210, 36);
            this.textBoxFinancialAdjustmentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialAdjustmentTypeName.Name = "textBoxFinancialAdjustmentTypeName";
            this.textBoxFinancialAdjustmentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialAdjustmentTypeName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(268, 82);
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
            this.ClientSize = new System.Drawing.Size(472, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFinancialAdjustmentTypeRefEdit";
            this.Text = "Financial Adjustment Type Ref Edit";
            this.Controls.Add(this.labelFinancialAdjustmentType);
            this.Controls.Add(this.textBoxFinancialAdjustmentType);
            this.Controls.Add(this.labelFinancialAdjustmentTypeName);
            this.Controls.Add(this.textBoxFinancialAdjustmentTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
