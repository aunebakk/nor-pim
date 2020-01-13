using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserListForDashboardSearch : Form {
        
        public DefaultUserListForDashboardSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultUserListForDashboardSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultUserListForDashboard.RefreshDefaultUserListForDashboard();
            base.Show();
        }
        
        private void buttonDefaultUserListForDashboardSearch_Click(object sender, EventArgs e) {
            durianDefaultUserListForDashboard.RefreshDefaultUserListForDashboard();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
