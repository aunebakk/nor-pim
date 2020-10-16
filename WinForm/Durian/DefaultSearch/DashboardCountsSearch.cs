using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DashboardCountsSearch : Form {

        public DashboardCountsSearch() {
            InitializeComponent();
            AcceptButton = buttonDashboardCountsSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDashboardCounts.RefreshDashboardCounts(string.Empty);
            base.Show();
        }

        private void buttonDashboardCountsSearch_Click(object sender, EventArgs e) {
            durianDashboardCounts.RefreshDashboardCounts(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
