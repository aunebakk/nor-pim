namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultErrorEdit {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSave;

        private DefaultErrorLayerRefCombo defaultErrorLayerRefCombo;

        private System.Windows.Forms.Label labelDefaultErrorLayerRefCombo;

        private DefaultErrorTypeRefCombo defaultErrorTypeRefCombo;

        private System.Windows.Forms.Label labelDefaultErrorTypeRefCombo;

        private System.Windows.Forms.TextBox textBoxLayerAddress;

        private System.Windows.Forms.Label labelLayerAddress;

        private System.Windows.Forms.TextBox textBoxErrorMessage;

        private System.Windows.Forms.Label labelErrorMessage;

        private System.Windows.Forms.TextBox textBoxStackTrace;

        private System.Windows.Forms.Label labelStackTrace;

        private System.Windows.Forms.TextBox textBoxMethodName;

        private System.Windows.Forms.Label labelMethodName;

        private System.Windows.Forms.TextBox textBoxDomainName;

        private System.Windows.Forms.Label labelDomainName;

        private System.Windows.Forms.TextBox textBoxClassName;

        private System.Windows.Forms.Label labelClassName;

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
            this.labelDefaultErrorLayerRefCombo = new System.Windows.Forms.Label();
            this.defaultErrorLayerRefCombo = new DefaultErrorLayerRefCombo();
            this.labelDefaultErrorTypeRefCombo = new System.Windows.Forms.Label();
            this.defaultErrorTypeRefCombo = new DefaultErrorTypeRefCombo();
            this.labelLayerAddress = new System.Windows.Forms.Label();
            this.textBoxLayerAddress = new System.Windows.Forms.TextBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.textBoxErrorMessage = new System.Windows.Forms.TextBox();
            this.labelStackTrace = new System.Windows.Forms.Label();
            this.textBoxStackTrace = new System.Windows.Forms.TextBox();
            this.labelMethodName = new System.Windows.Forms.Label();
            this.textBoxMethodName = new System.Windows.Forms.TextBox();
            this.labelDomainName = new System.Windows.Forms.Label();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            //
            // labelDefaultErrorLayerRefCombo
            //
            this.labelDefaultErrorLayerRefCombo.AutoSize = true;
            this.labelDefaultErrorLayerRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultErrorLayerRefCombo.Name = "labelDefaultErrorLayerRefCombo";
            this.labelDefaultErrorLayerRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayerRefCombo.TabIndex = 2;
            this.labelDefaultErrorLayerRefCombo.Text = "Default Error Layer:";
            //
            //defaultErrorLayerRefCombo
            //
            this.defaultErrorLayerRefCombo.Location = new System.Drawing.Point(140, 13);
            this.defaultErrorLayerRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultErrorLayerRefCombo.Name = "defaultErrorLayerRefCombo";
            this.defaultErrorLayerRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultErrorLayerRefCombo.TabIndex = 3;
            //
            // labelDefaultErrorTypeRefCombo
            //
            this.labelDefaultErrorTypeRefCombo.AutoSize = true;
            this.labelDefaultErrorTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultErrorTypeRefCombo.Name = "labelDefaultErrorTypeRefCombo";
            this.labelDefaultErrorTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorTypeRefCombo.TabIndex = 4;
            this.labelDefaultErrorTypeRefCombo.Text = "Default Error Type:";
            //
            //defaultErrorTypeRefCombo
            //
            this.defaultErrorTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.defaultErrorTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultErrorTypeRefCombo.Name = "defaultErrorTypeRefCombo";
            this.defaultErrorTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultErrorTypeRefCombo.TabIndex = 5;
            //
            // labelLayerAddress
            //
            this.labelLayerAddress.AutoSize = true;
            this.labelLayerAddress.Location = new System.Drawing.Point(11, 59);
            this.labelLayerAddress.Name = "labelLayerAddress";
            this.labelLayerAddress.Size = new System.Drawing.Size(71, 13);
            this.labelLayerAddress.TabIndex = 6;
            this.labelLayerAddress.Text = "Layer Address:";
            //
            //textBoxLayerAddress
            //
            this.textBoxLayerAddress.Location = new System.Drawing.Point(140, 59);
            this.textBoxLayerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLayerAddress.Name = "textBoxLayerAddress";
            this.textBoxLayerAddress.Size = new System.Drawing.Size(250, 20);
            this.textBoxLayerAddress.TabIndex = 7;
            //
            // labelErrorMessage
            //
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Location = new System.Drawing.Point(11, 82);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(71, 13);
            this.labelErrorMessage.TabIndex = 8;
            this.labelErrorMessage.Text = "Error Message:";
            //
            //textBoxErrorMessage
            //
            this.textBoxErrorMessage.Location = new System.Drawing.Point(140, 82);
            this.textBoxErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrorMessage.Name = "textBoxErrorMessage";
            this.textBoxErrorMessage.Size = new System.Drawing.Size(250, 20);
            this.textBoxErrorMessage.TabIndex = 9;
            //
            // labelStackTrace
            //
            this.labelStackTrace.AutoSize = true;
            this.labelStackTrace.Location = new System.Drawing.Point(11, 105);
            this.labelStackTrace.Name = "labelStackTrace";
            this.labelStackTrace.Size = new System.Drawing.Size(71, 13);
            this.labelStackTrace.TabIndex = 10;
            this.labelStackTrace.Text = "Stack Trace:";
            //
            //textBoxStackTrace
            //
            this.textBoxStackTrace.Location = new System.Drawing.Point(140, 105);
            this.textBoxStackTrace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStackTrace.Name = "textBoxStackTrace";
            this.textBoxStackTrace.Size = new System.Drawing.Size(250, 20);
            this.textBoxStackTrace.TabIndex = 11;
            //
            // labelMethodName
            //
            this.labelMethodName.AutoSize = true;
            this.labelMethodName.Location = new System.Drawing.Point(11, 128);
            this.labelMethodName.Name = "labelMethodName";
            this.labelMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelMethodName.TabIndex = 12;
            this.labelMethodName.Text = "Method Name:";
            //
            //textBoxMethodName
            //
            this.textBoxMethodName.Location = new System.Drawing.Point(140, 128);
            this.textBoxMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMethodName.Name = "textBoxMethodName";
            this.textBoxMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxMethodName.TabIndex = 13;
            //
            // labelDomainName
            //
            this.labelDomainName.AutoSize = true;
            this.labelDomainName.Location = new System.Drawing.Point(11, 151);
            this.labelDomainName.Name = "labelDomainName";
            this.labelDomainName.Size = new System.Drawing.Size(71, 13);
            this.labelDomainName.TabIndex = 14;
            this.labelDomainName.Text = "Domain Name:";
            //
            //textBoxDomainName
            //
            this.textBoxDomainName.Location = new System.Drawing.Point(140, 151);
            this.textBoxDomainName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDomainName.TabIndex = 15;
            //
            // labelClassName
            //
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(11, 174);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(71, 13);
            this.labelClassName.TabIndex = 16;
            this.labelClassName.Text = "Class Name:";
            //
            //textBoxClassName
            //
            this.textBoxClassName.Location = new System.Drawing.Point(140, 174);
            this.textBoxClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(250, 20);
            this.textBoxClassName.TabIndex = 17;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 18;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 197);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 19;
            this.dateTimePickerDateTime.Checked = false;
            this.dateTimePickerDateTime.ShowCheckBox = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 220);

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
            this.buttonSave.Location = new System.Drawing.Point(198, 220);
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
            this.ClientSize = new System.Drawing.Size(402, 248);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultErrorEdit";
            this.Text = "Default Error Edit";
            this.Controls.Add(this.labelDefaultErrorLayerRefCombo);
            this.Controls.Add(this.defaultErrorLayerRefCombo);
            this.Controls.Add(this.labelDefaultErrorTypeRefCombo);
            this.Controls.Add(this.defaultErrorTypeRefCombo);
            this.Controls.Add(this.labelLayerAddress);
            this.Controls.Add(this.textBoxLayerAddress);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.textBoxErrorMessage);
            this.Controls.Add(this.labelStackTrace);
            this.Controls.Add(this.textBoxStackTrace);
            this.Controls.Add(this.labelMethodName);
            this.Controls.Add(this.textBoxMethodName);
            this.Controls.Add(this.labelDomainName);
            this.Controls.Add(this.textBoxDomainName);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
