using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsTop5Search : Form {

        public DefaultStatisticsTop5Search() {
            InitializeComponent();
            AcceptButton = buttonDefaultStatisticsTop5Search;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultStatisticsTop5.RefreshDefaultStatisticsTop5();
            base.Show();
        }

        private void buttonDefaultStatisticsTop5Search_Click(object sender, EventArgs e) {
            durianDefaultStatisticsTop5.RefreshDefaultStatisticsTop5();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
