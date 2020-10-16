using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityRecentSearch : Form {

        public DefaultUserActivityRecentSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultUserActivityRecentSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultUserActivityRecent.RefreshDefaultUserActivityRecent(Guid.Empty);
            base.Show();
        }

        private void buttonDefaultUserActivityRecentSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityRecent.RefreshDefaultUserActivityRecent(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
