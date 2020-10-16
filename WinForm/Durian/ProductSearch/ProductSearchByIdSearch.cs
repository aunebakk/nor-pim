using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByIdSearch : Form {

        public ProductSearchByIdSearch() {
            InitializeComponent();
            AcceptButton = buttonProductSearchByIdSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductSearchById.RefreshProductSearchById(Guid.Empty);
            base.Show();
        }

        private void buttonProductSearchByIdSearch_Click(object sender, EventArgs e) {
            durianProductSearchById.RefreshProductSearchById(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
