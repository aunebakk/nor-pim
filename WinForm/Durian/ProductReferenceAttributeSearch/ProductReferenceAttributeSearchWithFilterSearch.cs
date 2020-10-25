using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductReferenceAttributeSearchWithFilterSearch : Form {
        
        public ProductReferenceAttributeSearchWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductReferenceAttributeSearchWithFilterSearch;
           this.CancelButton = buttonClose;
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
