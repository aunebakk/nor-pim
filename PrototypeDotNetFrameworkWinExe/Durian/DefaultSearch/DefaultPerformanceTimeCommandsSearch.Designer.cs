namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceTimeCommandsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultPerformanceTimeCommandsSearch;
        
        private DefaultPerformanceTimeCommandsDurian durianDefaultPerformanceTimeCommands;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultPerformanceTimeCommandsSearch = new System.Windows.Forms.Button();
            this.durianDefaultPerformanceTimeCommands = new DefaultPerformanceTimeCommandsDurian();
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
            // buttonDefaultPerformanceTimeCommandsSearch
            // 
            this.buttonDefaultPerformanceTimeCommandsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultPerformanceTimeCommandsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultPerformanceTimeCommandsSearch.Name = "buttonDefaultPerformanceTimeCommandsSearch";
            this.buttonDefaultPerformanceTimeCommandsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultPerformanceTimeCommandsSearch.TabIndex = 2;
            this.buttonDefaultPerformanceTimeCommandsSearch.Text = "&Search";
            this.buttonDefaultPerformanceTimeCommandsSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultPerformanceTimeCommandsSearch.Click += new System.EventHandler(this.buttonDefaultPerformanceTimeCommandsSearch_Click);
            // 
            // durianDefaultPerformanceTimeCommands
            // 
            this.durianDefaultPerformanceTimeCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultPerformanceTimeCommands.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultPerformanceTimeCommands.Name = "durianDefaultPerformanceTimeCommands";
            this.durianDefaultPerformanceTimeCommands.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultPerformanceTimeCommands.TabIndex = 1;
            // 
            // InitDefaultPerformanceTimeCommandsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultPerformanceTimeCommandsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultPerformanceTimeCommands);
            this.Name = "DefaultPerformanceTimeCommandsSearch";
            this.Text = "Default Performance Time Commands";
            this.ResumeLayout(false);

        }
    }
}
