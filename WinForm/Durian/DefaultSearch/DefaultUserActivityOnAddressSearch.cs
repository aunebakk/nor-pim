using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityOnAddressSearch : Form {

        public DefaultUserActivityOnAddressSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultUserActivityOnAddressSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultUserActivityOnAddress.RefreshDefaultUserActivityOnAddress(string.Empty);
            base.Show();
        }

        private void buttonDefaultUserActivityOnAddressSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityOnAddress.RefreshDefaultUserActivityOnAddress(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
