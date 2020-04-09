namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsByMonthSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonDefaultStatisticsByMonthSearch;
        
        private DefaultStatisticsByMonthDurian durianDefaultStatisticsByMonth;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDefaultStatisticsByMonthSearch = new System.Windows.Forms.Button();
            this.durianDefaultStatisticsByMonth = new DefaultStatisticsByMonthDurian();
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
            // buttonDefaultStatisticsByMonthSearch
            // 
            this.buttonDefaultStatisticsByMonthSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDefaultStatisticsByMonthSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonDefaultStatisticsByMonthSearch.Name = "buttonDefaultStatisticsByMonthSearch";
            this.buttonDefaultStatisticsByMonthSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonDefaultStatisticsByMonthSearch.TabIndex = 2;
            this.buttonDefaultStatisticsByMonthSearch.Text = "&Search";
            this.buttonDefaultStatisticsByMonthSearch.UseVisualStyleBackColor = true;
            this.buttonDefaultStatisticsByMonthSearch.Click += new System.EventHandler(this.buttonDefaultStatisticsByMonthSearch_Click);
            // 
            // durianDefaultStatisticsByMonth
            // 
            this.durianDefaultStatisticsByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianDefaultStatisticsByMonth.Location = new System.Drawing.Point(12, 12);
            this.durianDefaultStatisticsByMonth.Name = "durianDefaultStatisticsByMonth";
            this.durianDefaultStatisticsByMonth.Size = new System.Drawing.Size(502, 259);
            this.durianDefaultStatisticsByMonth.TabIndex = 1;
            // 
            // InitDefaultStatisticsByMonthSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonDefaultStatisticsByMonthSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianDefaultStatisticsByMonth);
            this.Name = "DefaultStatisticsByMonthSearch";
            this.Text = "Default Statistics By Month";
            this.ResumeLayout(false);

        }
    }
}
