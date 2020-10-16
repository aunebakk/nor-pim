using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityGroupedSearch : Form {

        public DefaultUserActivityGroupedSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultUserActivityGroupedSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultUserActivityGrouped.RefreshDefaultUserActivityGrouped();
            base.Show();
        }

        private void buttonDefaultUserActivityGroupedSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityGrouped.RefreshDefaultUserActivityGrouped();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
