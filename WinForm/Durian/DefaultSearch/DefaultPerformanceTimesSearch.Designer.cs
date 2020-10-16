namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimesSearch {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonDefaultPerformanceTimesSearch;

        private DefaultPerformanceTimesDurian durianDefaultPerformanceTimes;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultPerformanceTimesSearch = new System.Windows.Forms.Button();
            this.durianDefaultPerformanceTimes = new DefaultPerformanceTimesDurian();
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
            // buttonDefaultPerformanceTimesSearch
            // 
            this.buttonDefaultPerformanceTimesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultPerformanceTimesSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultPerformanceTimesSearch.Name = "buttonDefaultPerformanceTimesSearch";
            this.buttonDefaultPerformanceTimesSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultPerformanceTimesSearch.TabIndex = 2;
            this.buttonDefaultPerformanceTimesSearch.Text = "&Search";
            this.buttonDefaultPerformanceTimesSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultPerformanceTimesSearch.Click += new System.EventHandler(this.buttonDefaultPerformanceTimesSearch_Click);
            // 
            // durianDefaultPerformanceTimes
            // 
            this.durianDefaultPerformanceTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultPerformanceTimes.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultPerformanceTimes.Name = "durianDefaultPerformanceTimes";
            this.durianDefaultPerformanceTimes.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultPerformanceTimes.TabIndex = 1;
            // 
            // InitDefaultPerformanceTimesSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultPerformanceTimesSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultPerformanceTimes);
            this.Name = "DefaultPerformanceTimesSearch";
            this.Text = "Default Performance Times";
            this.ResumeLayout(false);

        }
    }
}
