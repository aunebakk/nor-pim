using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByNameSearch : Form {

        public ProductSearchByNameSearch() {
            InitializeComponent();
            AcceptButton = buttonProductSearchByNameSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductSearchByName.RefreshProductSearchByName(string.Empty);
            base.Show();
        }

        private void buttonProductSearchByNameSearch_Click(object sender, EventArgs e) {
            durianProductSearchByName.RefreshProductSearchByName(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
