using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryCodeSearch : Form {

        public ProductSearchByCategoryCodeSearch() {
            InitializeComponent();
            AcceptButton = buttonProductSearchByCategoryCodeSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductSearchByCategoryCode.RefreshProductSearchByCategoryCode(string.Empty, false);
            base.Show();
        }

        private void buttonProductSearchByCategoryCodeSearch_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryCode.RefreshProductSearchByCategoryCode(string.Empty, false);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
