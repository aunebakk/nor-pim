namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorLayerRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorLayer;
        
        private System.Windows.Forms.Label labelDefaultErrorLayer;
        
        private System.Windows.Forms.TextBox textBoxDefaultErrorLayerName;
        
        private System.Windows.Forms.Label labelDefaultErrorLayerName;
        
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
            this.labelDefaultErrorLayer = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorLayer = new System.Windows.Forms.TextBox();
            this.labelDefaultErrorLayerName = new System.Windows.Forms.Label();
            this.textBoxDefaultErrorLayerName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelDefaultErrorLayer
            //
            this.labelDefaultErrorLayer.AutoSize = true;
            this.labelDefaultErrorLayer.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultErrorLayer.Name = "labelDefaultErrorLayer";
            this.labelDefaultErrorLayer.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayer.TabIndex = 2;
            this.labelDefaultErrorLayer.Text = "Default Error Layer:";
            //
            //textBoxDefaultErrorLayer
            //
            this.textBoxDefaultErrorLayer.Location = new System.Drawing.Point(168, 13);
            this.textBoxDefaultErrorLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorLayer.Name = "textBoxDefaultErrorLayer";
            this.textBoxDefaultErrorLayer.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorLayer.TabIndex = 3;
            //
            // labelDefaultErrorLayerName
            //
            this.labelDefaultErrorLayerName.AutoSize = true;
            this.labelDefaultErrorLayerName.Location = new System.Drawing.Point(11, 36);
            this.labelDefaultErrorLayerName.Name = "labelDefaultErrorLayerName";
            this.labelDefaultErrorLayerName.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultErrorLayerName.TabIndex = 4;
            this.labelDefaultErrorLayerName.Text = "Default Error Layer Name:";
            //
            //textBoxDefaultErrorLayerName
            //
            this.textBoxDefaultErrorLayerName.Location = new System.Drawing.Point(168, 36);
            this.textBoxDefaultErrorLayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDefaultErrorLayerName.Name = "textBoxDefaultErrorLayerName";
            this.textBoxDefaultErrorLayerName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDefaultErrorLayerName.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 82);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 82);
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
            this.ClientSize = new System.Drawing.Size(430, 110);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeDefaultErrorLayerRefEdit";
            this.Text = "Default Error Layer Ref Edit";
            this.Controls.Add(this.labelDefaultErrorLayer);
            this.Controls.Add(this.textBoxDefaultErrorLayer);
            this.Controls.Add(this.labelDefaultErrorLayerName);
            this.Controls.Add(this.textBoxDefaultErrorLayerName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
