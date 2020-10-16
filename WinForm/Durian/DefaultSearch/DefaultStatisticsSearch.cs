using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsSearch : Form {

        public DefaultStatisticsSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultStatisticsSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultStatistics.RefreshDefaultStatistics();
            base.Show();
        }

        private void buttonDefaultStatisticsSearch_Click(object sender, EventArgs e) {
            durianDefaultStatistics.RefreshDefaultStatistics();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
