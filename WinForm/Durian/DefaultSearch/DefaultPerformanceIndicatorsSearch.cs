using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceIndicatorsSearch : Form {

        public DefaultPerformanceIndicatorsSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultPerformanceIndicatorsSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultPerformanceIndicators.RefreshDefaultPerformanceIndicators();
            base.Show();
        }

        private void buttonDefaultPerformanceIndicatorsSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceIndicators.RefreshDefaultPerformanceIndicators();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
