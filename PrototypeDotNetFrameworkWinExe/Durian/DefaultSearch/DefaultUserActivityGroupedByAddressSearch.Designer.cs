namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityGroupedByAddressSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserActivityGroupedByAddressSearch;
        
        private DefaultUserActivityGroupedByAddressDurian durianDefaultUserActivityGroupedByAddress;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserActivityGroupedByAddressSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserActivityGroupedByAddress = new DefaultUserActivityGroupedByAddressDurian();
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
            // buttonDefaultUserActivityGroupedByAddressSearch
            // 
            this.buttonDefaultUserActivityGroupedByAddressSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserActivityGroupedByAddressSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserActivityGroupedByAddressSearch.Name = "buttonDefaultUserActivityGroupedByAddressSearch";
            this.buttonDefaultUserActivityGroupedByAddressSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserActivityGroupedByAddressSearch.TabIndex = 2;
            this.buttonDefaultUserActivityGroupedByAddressSearch.Text = "&Search";
            this.buttonDefaultUserActivityGroupedByAddressSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserActivityGroupedByAddressSearch.Click += new System.EventHandler(this.buttonDefaultUserActivityGroupedByAddressSearch_Click);
            // 
            // durianDefaultUserActivityGroupedByAddress
            // 
            this.durianDefaultUserActivityGroupedByAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserActivityGroupedByAddress.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserActivityGroupedByAddress.Name = "durianDefaultUserActivityGroupedByAddress";
            this.durianDefaultUserActivityGroupedByAddress.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserActivityGroupedByAddress.TabIndex = 1;
            // 
            // InitDefaultUserActivityGroupedByAddressSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserActivityGroupedByAddressSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserActivityGroupedByAddress);
            this.Name = "DefaultUserActivityGroupedByAddressSearch";
            this.Text = "Default User Activity Grouped By Address";
            this.ResumeLayout(false);

        }
    }
}
