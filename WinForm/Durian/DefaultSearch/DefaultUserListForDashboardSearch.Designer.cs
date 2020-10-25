namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserListForDashboardSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserListForDashboardSearch;
        
        private DefaultUserListForDashboardDurian durianDefaultUserListForDashboard;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserListForDashboardSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserListForDashboard = new DefaultUserListForDashboardDurian();
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
            // buttonDefaultUserListForDashboardSearch
            // 
            this.buttonDefaultUserListForDashboardSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserListForDashboardSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserListForDashboardSearch.Name = "buttonDefaultUserListForDashboardSearch";
            this.buttonDefaultUserListForDashboardSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserListForDashboardSearch.TabIndex = 2;
            this.buttonDefaultUserListForDashboardSearch.Text = "&Search";
            this.buttonDefaultUserListForDashboardSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserListForDashboardSearch.Click += new System.EventHandler(this.buttonDefaultUserListForDashboardSearch_Click);
            // 
            // durianDefaultUserListForDashboard
            // 
            this.durianDefaultUserListForDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserListForDashboard.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserListForDashboard.Name = "durianDefaultUserListForDashboard";
            this.durianDefaultUserListForDashboard.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserListForDashboard.TabIndex = 1;
            // 
            // InitDefaultUserListForDashboardSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserListForDashboardSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserListForDashboard);
            this.Name = "DefaultUserListForDashboardSearch";
            this.Text = "Default User List For Dashboard";
            this.ResumeLayout(false);

        }
    }
}
