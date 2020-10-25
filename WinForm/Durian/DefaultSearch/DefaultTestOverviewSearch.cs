using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultTestOverviewSearch : Form {
        
        public DefaultTestOverviewSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultTestOverviewSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultTestOverview.RefreshDefaultTestOverview(String.Empty);
            base.Show();
        }
        
        private void buttonDefaultTestOverviewSearch_Click(object sender, EventArgs e) {
            durianDefaultTestOverview.RefreshDefaultTestOverview(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
