using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeSearchWithFilterSearch : Form {

        public ProductReferenceAttributeSearchWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonProductReferenceAttributeSearchWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductReferenceAttributeSearchWithFilter.RefreshProductReferenceAttributeSearchWithFilter();
            base.Show();
        }

        private void buttonProductReferenceAttributeSearchWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductReferenceAttributeSearchWithFilter.RefreshProductReferenceAttributeSearchWithFilter();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
