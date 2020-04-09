namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserListSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultUserListSearch;
        
        private DefaultUserListDurian durianDefaultUserList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultUserListSearch = new System.Windows.Forms.Button();
            this.durianDefaultUserList = new DefaultUserListDurian();
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
            // buttonDefaultUserListSearch
            // 
            this.buttonDefaultUserListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultUserListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultUserListSearch.Name = "buttonDefaultUserListSearch";
            this.buttonDefaultUserListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultUserListSearch.TabIndex = 2;
            this.buttonDefaultUserListSearch.Text = "&Search";
            this.buttonDefaultUserListSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultUserListSearch.Click += new System.EventHandler(this.buttonDefaultUserListSearch_Click);
            // 
            // durianDefaultUserList
            // 
            this.durianDefaultUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultUserList.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultUserList.Name = "durianDefaultUserList";
            this.durianDefaultUserList.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultUserList.TabIndex = 1;
            // 
            // InitDefaultUserListSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultUserListSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultUserList);
            this.Name = "DefaultUserListSearch";
            this.Text = "Default User List";
            this.ResumeLayout(false);

        }
    }
}
