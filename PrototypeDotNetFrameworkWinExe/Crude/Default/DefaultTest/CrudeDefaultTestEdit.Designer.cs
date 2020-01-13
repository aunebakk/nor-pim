namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultTestEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxSystemName;
        
        private System.Windows.Forms.Label labelSystemName;
        
        private System.Windows.Forms.TextBox textBoxTestArea;
        
        private System.Windows.Forms.Label labelTestArea;
        
        private System.Windows.Forms.TextBox textBoxTestSubArea;
        
        private System.Windows.Forms.Label labelTestSubArea;
        
        private System.Windows.Forms.TextBox textBoxTestAddress;
        
        private System.Windows.Forms.Label labelTestAddress;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTime;
        
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
            this.labelSystemName = new System.Windows.Forms.Label();
            this.textBoxSystemName = new System.Windows.Forms.TextBox();
            this.labelTestArea = new System.Windows.Forms.Label();
            this.textBoxTestArea = new System.Windows.Forms.TextBox();
            this.labelTestSubArea = new System.Windows.Forms.Label();
            this.textBoxTestSubArea = new System.Windows.Forms.TextBox();
            this.labelTestAddress = new System.Windows.Forms.Label();
            this.textBoxTestAddress = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelSystemName
            //
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Location = new System.Drawing.Point(11, 13);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(71, 13);
            this.labelSystemName.TabIndex = 2;
            this.labelSystemName.Text = "System Name:";
            //
            //textBoxSystemName
            //
            this.textBoxSystemName.Location = new System.Drawing.Point(140, 13);
            this.textBoxSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSystemName.Name = "textBoxSystemName";
            this.textBoxSystemName.Size = new System.Drawing.Size(250, 20);
            this.textBoxSystemName.TabIndex = 3;
            //
            // labelTestArea
            //
            this.labelTestArea.AutoSize = true;
            this.labelTestArea.Location = new System.Drawing.Point(11, 36);
            this.labelTestArea.Name = "labelTestArea";
            this.labelTestArea.Size = new System.Drawing.Size(71, 13);
            this.labelTestArea.TabIndex = 4;
            this.labelTestArea.Text = "Test Area:";
            //
            //textBoxTestArea
            //
            this.textBoxTestArea.Location = new System.Drawing.Point(140, 36);
            this.textBoxTestArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestArea.Name = "textBoxTestArea";
            this.textBoxTestArea.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestArea.TabIndex = 5;
            //
            // labelTestSubArea
            //
            this.labelTestSubArea.AutoSize = true;
            this.labelTestSubArea.Location = new System.Drawing.Point(11, 59);
            this.labelTestSubArea.Name = "labelTestSubArea";
            this.labelTestSubArea.Size = new System.Drawing.Size(71, 13);
            this.labelTestSubArea.TabIndex = 6;
            this.labelTestSubArea.Text = "Test Sub Area:";
            //
            //textBoxTestSubArea
            //
            this.textBoxTestSubArea.Location = new System.Drawing.Point(140, 59);
            this.textBoxTestSubArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestSubArea.Name = "textBoxTestSubArea";
            this.textBoxTestSubArea.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestSubArea.TabIndex = 7;
            //
            // labelTestAddress
            //
            this.labelTestAddress.AutoSize = true;
            this.labelTestAddress.Location = new System.Drawing.Point(11, 82);
            this.labelTestAddress.Name = "labelTestAddress";
            this.labelTestAddress.Size = new System.Drawing.Size(71, 13);
            this.labelTestAddress.TabIndex = 8;
            this.labelTestAddress.Text = "Test Address:";
            //
            //textBoxTestAddress
            //
            this.textBoxTestAddress.Location = new System.Drawing.Point(140, 82);
            this.textBoxTestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestAddress.Name = "textBoxTestAddress";
            this.textBoxTestAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxTestAddress.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 128);
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
            this.ClientSize = new System.Drawing.Size(402, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultTestEdit";
            this.Text = "Default Test Edit";
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.textBoxSystemName);
            this.Controls.Add(this.labelTestArea);
            this.Controls.Add(this.textBoxTestArea);
            this.Controls.Add(this.labelTestSubArea);
            this.Controls.Add(this.textBoxTestSubArea);
            this.Controls.Add(this.labelTestAddress);
            this.Controls.Add(this.textBoxTestAddress);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
