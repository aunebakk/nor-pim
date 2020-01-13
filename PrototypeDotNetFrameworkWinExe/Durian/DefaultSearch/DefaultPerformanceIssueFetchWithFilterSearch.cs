using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceIssueFetchWithFilterSearch : Form {
        
        public DefaultPerformanceIssueFetchWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultPerformanceIssueFetchWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultPerformanceIssueFetchWithFilter.RefreshDefaultPerformanceIssueFetchWithFilter(String.Empty);
            base.Show();
        }
        
        private void buttonDefaultPerformanceIssueFetchWithFilterSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceIssueFetchWithFilter.RefreshDefaultPerformanceIssueFetchWithFilter(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
