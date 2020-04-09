using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DashboardCountsSearch : Form {
        
        public DashboardCountsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDashboardCountsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDashboardCounts.RefreshDashboardCounts(String.Empty);
            base.Show();
        }
        
        private void buttonDashboardCountsSearch_Click(object sender, EventArgs e) {
            durianDashboardCounts.RefreshDashboardCounts(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
