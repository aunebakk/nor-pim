namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityByHourSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserActivityByHourSearch;
        
        private DefaultUserActivityByHourDurian durianDefaultUserActivityByHour;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserActivityByHourSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserActivityByHour = new DefaultUserActivityByHourDurian();
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
            // buttonDefaultUserActivityByHourSearch
            // 
            this.buttonDefaultUserActivityByHourSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserActivityByHourSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserActivityByHourSearch.Name = "buttonDefaultUserActivityByHourSearch";
            this.buttonDefaultUserActivityByHourSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserActivityByHourSearch.TabIndex = 2;
            this.buttonDefaultUserActivityByHourSearch.Text = "&Search";
            this.buttonDefaultUserActivityByHourSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserActivityByHourSearch.Click += new System.EventHandler(this.buttonDefaultUserActivityByHourSearch_Click);
            // 
            // durianDefaultUserActivityByHour
            // 
            this.durianDefaultUserActivityByHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserActivityByHour.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserActivityByHour.Name = "durianDefaultUserActivityByHour";
            this.durianDefaultUserActivityByHour.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserActivityByHour.TabIndex = 1;
            // 
            // InitDefaultUserActivityByHourSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserActivityByHourSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserActivityByHour);
            this.Name = "DefaultUserActivityByHourSearch";
            this.Text = "Default User Activity By Hour";
            this.ResumeLayout(false);

        }
    }
}
