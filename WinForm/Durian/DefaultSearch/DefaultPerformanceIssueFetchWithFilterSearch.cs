using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceIssueFetchWithFilterSearch : Form {

        public DefaultPerformanceIssueFetchWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultPerformanceIssueFetchWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultPerformanceIssueFetchWithFilter.RefreshDefaultPerformanceIssueFetchWithFilter(string.Empty);
            base.Show();
        }

        private void buttonDefaultPerformanceIssueFetchWithFilterSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceIssueFetchWithFilter.RefreshDefaultPerformanceIssueFetchWithFilter(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
