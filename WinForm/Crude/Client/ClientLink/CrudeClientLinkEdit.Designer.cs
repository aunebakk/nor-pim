namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientLinkEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private ClientLinkTypeRefCombo clientLinkTypeRefCombo;

        private System.Windows.Forms.Label labelClientLinkTypeRefCombo;

        private System.Windows.Forms.TextBox textBoxLinkName;

        private System.Windows.Forms.Label labelLinkName;

        private System.Windows.Forms.TextBox textBoxLink;

        private System.Windows.Forms.Label labelLink;

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
            this.labelClientLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.clientLinkTypeRefCombo = new ClientLinkTypeRefCombo();
            this.labelLinkName = new System.Windows.Forms.Label();
            this.textBoxLinkName = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientLinkTypeRefCombo
            //
            this.labelClientLinkTypeRefCombo.AutoSize = true;
            this.labelClientLinkTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientLinkTypeRefCombo.Name = "labelClientLinkTypeRefCombo";
            this.labelClientLinkTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientLinkTypeRefCombo.TabIndex = 2;
            this.labelClientLinkTypeRefCombo.Text = "Client Link Type:";
            //
            //clientLinkTypeRefCombo
            //
            this.clientLinkTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.clientLinkTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLinkTypeRefCombo.Name = "clientLinkTypeRefCombo";
            this.clientLinkTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientLinkTypeRefCombo.TabIndex = 3;
            //
            // labelLinkName
            //
            this.labelLinkName.AutoSize = true;
            this.labelLinkName.Location = new System.Drawing.Point(11, 36);
            this.labelLinkName.Name = "labelLinkName";
            this.labelLinkName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkName.TabIndex = 4;
            this.labelLinkName.Text = "Link Name:";
            //
            //textBoxLinkName
            //
            this.textBoxLinkName.Location = new System.Drawing.Point(140, 36);
            this.textBoxLinkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkName.Name = "textBoxLinkName";
            this.textBoxLinkName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkName.TabIndex = 5;
            //
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 59);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 6;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 59);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 105);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 105);
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
            this.ClientSize = new System.Drawing.Size(402, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientLinkEdit";
            this.Text = "Client Link Edit";
            this.Controls.Add(this.labelClientLinkTypeRefCombo);
            this.Controls.Add(this.clientLinkTypeRefCombo);
            this.Controls.Add(this.labelLinkName);
            this.Controls.Add(this.textBoxLinkName);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
