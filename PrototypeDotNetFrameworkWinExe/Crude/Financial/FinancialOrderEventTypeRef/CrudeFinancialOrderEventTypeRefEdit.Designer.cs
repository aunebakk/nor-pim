namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderEventTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderEventType;
        
        private System.Windows.Forms.Label labelFinancialOrderEventType;
        
        private System.Windows.Forms.TextBox textBoxFinancialOrderEventTypeName;
        
        private System.Windows.Forms.Label labelFinancialOrderEventTypeName;
        
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
            this.labelFinancialOrderEventType = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderEventType = new System.Windows.Forms.TextBox();
            this.labelFinancialOrderEventTypeName = new System.Windows.Forms.Label();
            this.textBoxFinancialOrderEventTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFinancialOrderEventType
            //
            this.labelFinancialOrderEventType.AutoSize = true;
            this.labelFinancialOrderEventType.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialOrderEventType.Name = "labelFinancialOrderEventType";
            this.labelFinancialOrderEventType.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderEventType.TabIndex = 2;
            this.labelFinancialOrderEventType.Text = "Financial Order Event Type:";
            //
            //textBoxFinancialOrderEventType
            //
            this.textBoxFinancialOrderEventType.Location = new System.Drawing.Point(217, 13);
            this.textBoxFinancialOrderEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderEventType.Name = "textBoxFinancialOrderEventType";
            this.textBoxFinancialOrderEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderEventType.TabIndex = 3;
            //
            // labelFinancialOrderEventTypeName
            //
            this.labelFinancialOrderEventTypeName.AutoSize = true;
            this.labelFinancialOrderEventTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFinancialOrderEventTypeName.Name = "labelFinancialOrderEventTypeName";
            this.labelFinancialOrderEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialOrderEventTypeName.TabIndex = 4;
            this.labelFinancialOrderEventTypeName.Text = "Financial Order Event Type Name:";
            //
            //textBoxFinancialOrderEventTypeName
            //
            this.textBoxFinancialOrderEventTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxFinancialOrderEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFinancialOrderEventTypeName.Name = "textBoxFinancialOrderEventTypeName";
            this.textBoxFinancialOrderEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFinancialOrderEventTypeName.TabIndex = 5;
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
            this.Name = "CrudeFinancialOrderEventTypeRefEdit";
            this.Text = "Financial Order Event Type Ref Edit";
            this.Controls.Add(this.labelFinancialOrderEventType);
            this.Controls.Add(this.textBoxFinancialOrderEventType);
            this.Controls.Add(this.labelFinancialOrderEventTypeName);
            this.Controls.Add(this.textBoxFinancialOrderEventTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
