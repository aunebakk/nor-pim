using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetClientWithFilterSearch : Form {

        public GetClientWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonGetClientWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianGetClientWithFilter.RefreshGetClientWithFilter(string.Empty, string.Empty);
            base.Show();
        }

        private void buttonGetClientWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetClientWithFilter.RefreshGetClientWithFilter(string.Empty, string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
