using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityGroupedByAddressSearch : Form {

        public DefaultUserActivityGroupedByAddressSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultUserActivityGroupedByAddressSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultUserActivityGroupedByAddress.RefreshDefaultUserActivityGroupedByAddress();
            base.Show();
        }

        private void buttonDefaultUserActivityGroupedByAddressSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityGroupedByAddress.RefreshDefaultUserActivityGroupedByAddress();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
