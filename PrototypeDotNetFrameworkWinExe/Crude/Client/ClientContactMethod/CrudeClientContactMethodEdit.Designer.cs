namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientContactMethodEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ClientContactMethodRefCombo clientContactMethodRefCombo;
        
        private System.Windows.Forms.Label labelClientContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
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
            this.labelClientContactMethodRefCombo = new System.Windows.Forms.Label();
            this.clientContactMethodRefCombo = new ClientContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientContactMethodRefCombo
            //
            this.labelClientContactMethodRefCombo.AutoSize = true;
            this.labelClientContactMethodRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientContactMethodRefCombo.Name = "labelClientContactMethodRefCombo";
            this.labelClientContactMethodRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientContactMethodRefCombo.TabIndex = 2;
            this.labelClientContactMethodRefCombo.Text = "Client Contact Method:";
            //
            //clientContactMethodRefCombo
            //
            this.clientContactMethodRefCombo.Location = new System.Drawing.Point(147, 13);
            this.clientContactMethodRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientContactMethodRefCombo.Name = "clientContactMethodRefCombo";
            this.clientContactMethodRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientContactMethodRefCombo.TabIndex = 3;
            //
            // labelContactMethodWay
            //
            this.labelContactMethodWay.AutoSize = true;
            this.labelContactMethodWay.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethodWay.Name = "labelContactMethodWay";
            this.labelContactMethodWay.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodWay.TabIndex = 4;
            this.labelContactMethodWay.Text = "Contact Method Way:";
            //
            //textBoxContactMethodWay
            //
            this.textBoxContactMethodWay.Location = new System.Drawing.Point(147, 36);
            this.textBoxContactMethodWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodWay.Name = "textBoxContactMethodWay";
            this.textBoxContactMethodWay.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodWay.TabIndex = 5;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 59);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(147, 59);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 105);
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
            this.ClientSize = new System.Drawing.Size(409, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientContactMethodEdit";
            this.Text = "Client Contact Method Edit";
            this.Controls.Add(this.labelClientContactMethodRefCombo);
            this.Controls.Add(this.clientContactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
