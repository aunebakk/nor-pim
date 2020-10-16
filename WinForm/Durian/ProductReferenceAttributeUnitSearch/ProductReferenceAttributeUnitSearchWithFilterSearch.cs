using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeUnitSearchWithFilterSearch : Form {

        public ProductReferenceAttributeUnitSearchWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonProductReferenceAttributeUnitSearchWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductReferenceAttributeUnitSearchWithFilter.RefreshProductReferenceAttributeUnitSearchWithFilter();
            base.Show();
        }

        private void buttonProductReferenceAttributeUnitSearchWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductReferenceAttributeUnitSearchWithFilter.RefreshProductReferenceAttributeUnitSearchWithFilter();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
