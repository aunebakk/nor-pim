namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityOnAddressSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserActivityOnAddressSearch;
        
        private DefaultUserActivityOnAddressDurian durianDefaultUserActivityOnAddress;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserActivityOnAddressSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserActivityOnAddress = new DefaultUserActivityOnAddressDurian();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDefaultUserActivityOnAddressSearch
            // 
            this.buttonDefaultUserActivityOnAddressSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserActivityOnAddressSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserActivityOnAddressSearch.Name = "buttonDefaultUserActivityOnAddressSearch";
            this.buttonDefaultUserActivityOnAddressSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserActivityOnAddressSearch.TabIndex = 2;
            this.buttonDefaultUserActivityOnAddressSearch.Text = "&Search";
            this.buttonDefaultUserActivityOnAddressSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserActivityOnAddressSearch.Click += new System.EventHandler(this.buttonDefaultUserActivityOnAddressSearch_Click);
            // 
            // durianDefaultUserActivityOnAddress
            // 
            this.durianDefaultUserActivityOnAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserActivityOnAddress.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserActivityOnAddress.Name = "durianDefaultUserActivityOnAddress";
            this.durianDefaultUserActivityOnAddress.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserActivityOnAddress.TabIndex = 1;
            // 
            // InitDefaultUserActivityOnAddressSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserActivityOnAddressSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserActivityOnAddress);
            this.Name = "DefaultUserActivityOnAddressSearch";
            this.Text = "Default User Activity On Address";
            this.ResumeLayout(false);

        }
    }
}
