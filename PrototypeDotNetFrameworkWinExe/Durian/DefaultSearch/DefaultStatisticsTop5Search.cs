using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsTop5Search : Form {
        
        public DefaultStatisticsTop5Search() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultStatisticsTop5Search;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultStatisticsTop5.RefreshDefaultStatisticsTop5();
            base.Show();
        }
        
        private void buttonDefaultStatisticsTop5Search_Click(object sender, EventArgs e) {
            durianDefaultStatisticsTop5.RefreshDefaultStatisticsTop5();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
