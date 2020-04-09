namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetDefaultChangeLogSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetDefaultChangeLogSearch;
        
        private GetDefaultChangeLogDurian durianGetDefaultChangeLog;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetDefaultChangeLogSearch = new System.Windows.Forms.Button();
            this.durianGetDefaultChangeLog = new GetDefaultChangeLogDurian();
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
            // buttonGetDefaultChangeLogSearch
            // 
            this.buttonGetDefaultChangeLogSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetDefaultChangeLogSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetDefaultChangeLogSearch.Name = "buttonGetDefaultChangeLogSearch";
            this.buttonGetDefaultChangeLogSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetDefaultChangeLogSearch.TabIndex = 2;
            this.buttonGetDefaultChangeLogSearch.Text = "&Search";
            this.buttonGetDefaultChangeLogSearch.UseVisualStyleBackColor = true;
            this.buttonGetDefaultChangeLogSearch.Click += new System.EventHandler(this.buttonGetDefaultChangeLogSearch_Click);
            // 
            // durianGetDefaultChangeLog
            // 
            this.durianGetDefaultChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetDefaultChangeLog.Location = new System.Drawing.Point(12, 12);
            this.durianGetDefaultChangeLog.Name = "durianGetDefaultChangeLog";
            this.durianGetDefaultChangeLog.Size = new System.Drawing.Size(502, 259);
            this.durianGetDefaultChangeLog.TabIndex = 1;
            // 
            // InitGetDefaultChangeLogSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetDefaultChangeLogSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetDefaultChangeLog);
            this.Name = "GetDefaultChangeLogSearch";
            this.Text = "Get Default Change Log";
            this.ResumeLayout(false);

        }
    }
}
