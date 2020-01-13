namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeLocationCityEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxLocationCityCode;
        
        private System.Windows.Forms.Label labelLocationCityCode;
        
        private System.Windows.Forms.TextBox textBoxLocationCityName;
        
        private System.Windows.Forms.Label labelLocationCityName;
        
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
            this.labelLocationCityCode = new System.Windows.Forms.Label();
            this.textBoxLocationCityCode = new System.Windows.Forms.TextBox();
            this.labelLocationCityName = new System.Windows.Forms.Label();
            this.textBoxLocationCityName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLocationCityCode
            //
            this.labelLocationCityCode.AutoSize = true;
            this.labelLocationCityCode.Location = new System.Drawing.Point(11, 13);
            this.labelLocationCityCode.Name = "labelLocationCityCode";
            this.labelLocationCityCode.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCityCode.TabIndex = 2;
            this.labelLocationCityCode.Text = "Location City Code:";
            //
            //textBoxLocationCityCode
            //
            this.textBoxLocationCityCode.Location = new System.Drawing.Point(140, 13);
            this.textBoxLocationCityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCityCode.Name = "textBoxLocationCityCode";
            this.textBoxLocationCityCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCityCode.TabIndex = 3;
            //
            // labelLocationCityName
            //
            this.labelLocationCityName.AutoSize = true;
            this.labelLocationCityName.Location = new System.Drawing.Point(11, 36);
            this.labelLocationCityName.Name = "labelLocationCityName";
            this.labelLocationCityName.Size = new System.Drawing.Size(71, 13);
            this.labelLocationCityName.TabIndex = 4;
            this.labelLocationCityName.Text = "Location City Name:";
            //
            //textBoxLocationCityName
            //
            this.textBoxLocationCityName.Location = new System.Drawing.Point(140, 36);
            this.textBoxLocationCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocationCityName.Name = "textBoxLocationCityName";
            this.textBoxLocationCityName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLocationCityName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 82);
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
            this.ClientSize = new System.Drawing.Size(402, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeLocationCityEdit";
            this.Text = "Location City Edit";
            this.Controls.Add(this.labelLocationCityCode);
            this.Controls.Add(this.textBoxLocationCityCode);
            this.Controls.Add(this.labelLocationCityName);
            this.Controls.Add(this.textBoxLocationCityName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
