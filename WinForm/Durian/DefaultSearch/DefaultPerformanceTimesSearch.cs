using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimesSearch : Form {

        public DefaultPerformanceTimesSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultPerformanceTimesSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultPerformanceTimes.RefreshDefaultPerformanceTimes(string.Empty);
            base.Show();
        }

        private void buttonDefaultPerformanceTimesSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceTimes.RefreshDefaultPerformanceTimes(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
