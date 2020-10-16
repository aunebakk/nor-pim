using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultIssueWithFilterSearch : Form {

        public DefaultIssueWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultIssueWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultIssueWithFilter.RefreshDefaultIssueWithFilter(string.Empty, string.Empty);
            base.Show();
        }

        private void buttonDefaultIssueWithFilterSearch_Click(object sender, EventArgs e) {
            durianDefaultIssueWithFilter.RefreshDefaultIssueWithFilter(string.Empty, string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
