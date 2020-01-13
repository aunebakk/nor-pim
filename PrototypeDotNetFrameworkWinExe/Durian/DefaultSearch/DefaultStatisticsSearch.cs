using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultStatisticsSearch : Form {
        
        public DefaultStatisticsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultStatisticsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultStatistics.RefreshDefaultStatistics();
            base.Show();
        }
        
        private void buttonDefaultStatisticsSearch_Click(object sender, EventArgs e) {
            durianDefaultStatistics.RefreshDefaultStatistics();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
