namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultUserActivityTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultUserActivityType;
        
        private System.Windows.Forms.Label labelDefaultUserActivityType;
        
        private System.Windows.Forms.TextBox textBoxDefaultUserActivityTypeName;
        
        private System.Windows.Forms.Label labelDefaultUserActivityTypeName;
        
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
            this.labelDefaultUserActivityType = new System.Windows.Forms.Label();
            this.textBoxDefaultUserActivityType = new System.Windows.Forms.TextBox();
            this.labelDefaultUserActivityTypeName = new System.Windows.Forms.Label();
            this.textBoxDefaultUserActivityTypeName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultUserActivityType
            //
            this.labelDefaultUserActivityType.AutoSize = true;
            this.labelDefaultUserActivityType.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultUserActivityType.Name = "labelDefaultUserActivityType";
            this.labelDefaultUserActivityType.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserActivityType.TabIndex = 2;
            this.labelDefaultUserActivityType.Text = "Default User Activity Type:";
            //
            //textBoxDefaultUserActivityType
            //
            this.textBoxDefaultUserActivityType.Location = new System.Drawing.Point(217, 13);
            this.textBoxDefaultUserActivityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserActivityType.Name = "textBoxDefaultUserActivityType";
            this.textBoxDefaultUserActivityType.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserActivityType.TabIndex = 3;
            //
            // labelDefaultUserActivityTypeName
            //
            this.labelDefaultUserActivityTypeName.AutoSize = true;
            this.labelDefaultUserActivityTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultUserActivityTypeName.Name = "labelDefaultUserActivityTypeName";
            this.labelDefaultUserActivityTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultUserActivityTypeName.TabIndex = 4;
            this.labelDefaultUserActivityTypeName.Text = "Default User Activity Type Name:";
            //
            //textBoxDefaultUserActivityTypeName
            //
            this.textBoxDefaultUserActivityTypeName.Location = new System.Drawing.Point(217, 36);
            this.textBoxDefaultUserActivityTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultUserActivityTypeName.Name = "textBoxDefaultUserActivityTypeName";
            this.textBoxDefaultUserActivityTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultUserActivityTypeName.TabIndex = 5;
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
            this.Name = "CrudeDefaultUserActivityTypeRefEdit";
            this.Text = "Default User Activity Type Ref Edit";
            this.Controls.Add(this.labelDefaultUserActivityType);
            this.Controls.Add(this.textBoxDefaultUserActivityType);
            this.Controls.Add(this.labelDefaultUserActivityTypeName);
            this.Controls.Add(this.textBoxDefaultUserActivityTypeName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
