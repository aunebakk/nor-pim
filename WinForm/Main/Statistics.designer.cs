namespace SolutionNorSolutionPim.UserInterface {


    public partial class Statistics {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView gridDefaultStatisticsTop5;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridDefaultStatisticsTop5 = new System.Windows.Forms.DataGridView();
            this.gridDefaultStatistics = new System.Windows.Forms.DataGridView();
            this.buttonPingTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultStatisticsTop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(422, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(324, 268);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridDefaultStatisticsTop5
            // 
            this.gridDefaultStatisticsTop5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDefaultStatisticsTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDefaultStatisticsTop5.Location = new System.Drawing.Point(12, 12);
            this.gridDefaultStatisticsTop5.Name = "gridDefaultStatisticsTop5";
            this.gridDefaultStatisticsTop5.Size = new System.Drawing.Size(255, 245);
            this.gridDefaultStatisticsTop5.TabIndex = 0;
            // 
            // gridDefaultStatistics
            // 
            this.gridDefaultStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDefaultStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDefaultStatistics.Location = new System.Drawing.Point(273, 12);
            this.gridDefaultStatistics.Name = "gridDefaultStatistics";
            this.gridDefaultStatistics.Size = new System.Drawing.Size(241, 245);
            this.gridDefaultStatistics.TabIndex = 3;
            // 
            // buttonPingTest
            // 
            this.buttonPingTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPingTest.Location = new System.Drawing.Point(226, 268);
            this.buttonPingTest.Name = "buttonPingTest";
            this.buttonPingTest.Size = new System.Drawing.Size(92, 22);
            this.buttonPingTest.TabIndex = 4;
            this.buttonPingTest.Text = "&Ping test";
            this.buttonPingTest.UseVisualStyleBackColor = true;
            this.buttonPingTest.Click += new System.EventHandler(this.buttonPingTest_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonPingTest);
            this.Controls.Add(this.gridDefaultStatistics);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridDefaultStatisticsTop5);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultStatisticsTop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefaultStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView gridDefaultStatistics;
        private System.Windows.Forms.Button buttonPingTest;
    }
}
