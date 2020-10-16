using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductWithFilterSearch : Form {

        public GetCartProductWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonGetCartProductWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianGetCartProductWithFilter.RefreshGetCartProductWithFilter();
            base.Show();
        }

        private void buttonGetCartProductWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetCartProductWithFilter.RefreshGetCartProductWithFilter();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
