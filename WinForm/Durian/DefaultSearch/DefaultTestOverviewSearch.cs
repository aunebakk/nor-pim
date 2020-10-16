using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultTestOverviewSearch : Form {

        public DefaultTestOverviewSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultTestOverviewSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultTestOverview.RefreshDefaultTestOverview(string.Empty);
            base.Show();
        }

        private void buttonDefaultTestOverviewSearch_Click(object sender, EventArgs e) {
            durianDefaultTestOverview.RefreshDefaultTestOverview(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
