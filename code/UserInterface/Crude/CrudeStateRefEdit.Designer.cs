namespace norpim.UserInterface {
    
    
    public partial class CrudeStateRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private StateRefCombo stateRefCombo;
        
        private System.Windows.Forms.Label labelStateRefCombo;
        
        private System.Windows.Forms.TextBox textBoxStateName;
        
        private System.Windows.Forms.Label labelStateName;
        
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
            this.labelStateRefCombo = new System.Windows.Forms.Label();
            this.stateRefCombo = new StateRefCombo();
            this.labelStateName = new System.Windows.Forms.Label();
            this.textBoxStateName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelStateRefCombo
            //
            this.labelStateRefCombo.AutoSize = true;
            this.labelStateRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelStateRefCombo.Name = "labelStateRefCombo";
            this.labelStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelStateRefCombo.TabIndex = 2;
            this.labelStateRefCombo.Text = "State:";
            //
            //stateRefCombo
            //
            this.stateRefCombo.Location = new System.Drawing.Point(140, 13);
            this.stateRefCombo.Name = "stateRefCombo";
            this.stateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.stateRefCombo.TabIndex = 3;
            //
            // labelStateName
            //
            this.labelStateName.AutoSize = true;
            this.labelStateName.Location = new System.Drawing.Point(11, 36);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(71, 13);
            this.labelStateName.TabIndex = 4;
            this.labelStateName.Text = "State Name:";
            //
            //textBoxStateName
            //
            this.textBoxStateName.Location = new System.Drawing.Point(140, 36);
            this.textBoxStateName.Name = "textBoxStateName";
            this.textBoxStateName.Size = new System.Drawing.Size(250, 20);
            this.textBoxStateName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
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
            this.ClientSize = new System.Drawing.Size(412, 105);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeStateRefEdit";
            this.Text = "State Ref Edit";
            this.Controls.Add(this.labelStateRefCombo);
            this.Controls.Add(this.stateRefCombo);
            this.Controls.Add(this.labelStateName);
            this.Controls.Add(this.textBoxStateName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
