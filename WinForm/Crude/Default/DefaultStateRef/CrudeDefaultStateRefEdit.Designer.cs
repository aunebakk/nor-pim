namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultStateRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultState;
        
        private System.Windows.Forms.Label labelDefaultState;
        
        private System.Windows.Forms.TextBox textBoxDefaultStateName;
        
        private System.Windows.Forms.Label labelDefaultStateName;
        
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
            this.labelDefaultState = new System.Windows.Forms.Label();
            this.textBoxDefaultState = new System.Windows.Forms.TextBox();
            this.labelDefaultStateName = new System.Windows.Forms.Label();
            this.textBoxDefaultStateName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultState
            //
            this.labelDefaultState.AutoSize = true;
            this.labelDefaultState.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultState.Name = "labelDefaultState";
            this.labelDefaultState.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultState.TabIndex = 2;
            this.labelDefaultState.Text = "Default State:";
            //
            //textBoxDefaultState
            //
            this.textBoxDefaultState.Location = new System.Drawing.Point(140, 13);
            this.textBoxDefaultState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultState.Name = "textBoxDefaultState";
            this.textBoxDefaultState.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultState.TabIndex = 3;
            //
            // labelDefaultStateName
            //
            this.labelDefaultStateName.AutoSize = true;
            this.labelDefaultStateName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultStateName.Name = "labelDefaultStateName";
            this.labelDefaultStateName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateName.TabIndex = 4;
            this.labelDefaultStateName.Text = "Default State Name:";
            //
            //textBoxDefaultStateName
            //
            this.textBoxDefaultStateName.Location = new System.Drawing.Point(140, 36);
            this.textBoxDefaultStateName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultStateName.Name = "textBoxDefaultStateName";
            this.textBoxDefaultStateName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultStateName.TabIndex = 5;
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
            this.Name = "CrudeDefaultStateRefEdit";
            this.Text = "Default State Ref Edit";
            this.Controls.Add(this.labelDefaultState);
            this.Controls.Add(this.textBoxDefaultState);
            this.Controls.Add(this.labelDefaultStateName);
            this.Controls.Add(this.textBoxDefaultStateName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
