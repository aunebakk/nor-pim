using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultResourceDatabaseStatisticsSearch : Form {
        
        public DefaultResourceDatabaseStatisticsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultResourceDatabaseStatisticsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultResourceDatabaseStatistics.RefreshDefaultResourceDatabaseStatistics();
            base.Show();
        }
        
        private void buttonDefaultResourceDatabaseStatisticsSearch_Click(object sender, EventArgs e) {
            durianDefaultResourceDatabaseStatistics.RefreshDefaultResourceDatabaseStatistics();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
