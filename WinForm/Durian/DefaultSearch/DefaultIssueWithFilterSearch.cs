using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultIssueWithFilterSearch : Form {
        
        public DefaultIssueWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultIssueWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultIssueWithFilter.RefreshDefaultIssueWithFilter(String.Empty, String.Empty);
            base.Show();
        }
        
        private void buttonDefaultIssueWithFilterSearch_Click(object sender, EventArgs e) {
            durianDefaultIssueWithFilter.RefreshDefaultIssueWithFilter(String.Empty, String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
