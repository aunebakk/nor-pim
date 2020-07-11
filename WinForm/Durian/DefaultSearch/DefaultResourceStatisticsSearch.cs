using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultResourceStatisticsSearch : Form {
        
        public DefaultResourceStatisticsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultResourceStatisticsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultResourceStatistics.RefreshDefaultResourceStatistics();
            base.Show();
        }
        
        private void buttonDefaultResourceStatisticsSearch_Click(object sender, EventArgs e) {
            durianDefaultResourceStatistics.RefreshDefaultResourceStatistics();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
