using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductSearch : Form {

        public GetCartProductSearch() {
            InitializeComponent();
            AcceptButton = buttonGetCartProductSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianGetCartProduct.RefreshGetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, string.Empty);
            base.Show();
        }

        private void buttonGetCartProductSearch_Click(object sender, EventArgs e) {
            durianGetCartProduct.RefreshGetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
