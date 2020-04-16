namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestRunResultRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultTestRunResult;
        
        private System.Windows.Forms.Label labelDefaultTestRunResult;
        
        private System.Windows.Forms.TextBox textBoxDefaultTestRunResultName;
        
        private System.Windows.Forms.Label labelDefaultTestRunResultName;
        
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
            this.labelDefaultTestRunResult = new System.Windows.Forms.Label();
            this.textBoxDefaultTestRunResult = new System.Windows.Forms.TextBox();
            this.labelDefaultTestRunResultName = new System.Windows.Forms.Label();
            this.textBoxDefaultTestRunResultName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultTestRunResult
            //
            this.labelDefaultTestRunResult.AutoSize = true;
            this.labelDefaultTestRunResult.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultTestRunResult.Name = "labelDefaultTestRunResult";
            this.labelDefaultTestRunResult.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultTestRunResult.TabIndex = 2;
            this.labelDefaultTestRunResult.Text = "Default Test Run Result:";
            //
            //textBoxDefaultTestRunResult
            //
            this.textBoxDefaultTestRunResult.Location = new System.Drawing.Point(196, 13);
            this.textBoxDefaultTestRunResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultTestRunResult.Name = "textBoxDefaultTestRunResult";
            this.textBoxDefaultTestRunResult.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultTestRunResult.TabIndex = 3;
            //
            // labelDefaultTestRunResultName
            //
            this.labelDefaultTestRunResultName.AutoSize = true;
            this.labelDefaultTestRunResultName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultTestRunResultName.Name = "labelDefaultTestRunResultName";
            this.labelDefaultTestRunResultName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultTestRunResultName.TabIndex = 4;
            this.labelDefaultTestRunResultName.Text = "Default Test Run Result Name:";
            //
            //textBoxDefaultTestRunResultName
            //
            this.textBoxDefaultTestRunResultName.Location = new System.Drawing.Point(196, 36);
            this.textBoxDefaultTestRunResultName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultTestRunResultName.Name = "textBoxDefaultTestRunResultName";
            this.textBoxDefaultTestRunResultName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultTestRunResultName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(254, 82);
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
            this.ClientSize = new System.Drawing.Size(458, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultTestRunResultRefEdit";
            this.Text = "Default Test Run Result Ref Edit";
            this.Controls.Add(this.labelDefaultTestRunResult);
            this.Controls.Add(this.textBoxDefaultTestRunResult);
            this.Controls.Add(this.labelDefaultTestRunResultName);
            this.Controls.Add(this.textBoxDefaultTestRunResultName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
