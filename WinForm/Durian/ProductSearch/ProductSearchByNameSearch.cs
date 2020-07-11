using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByNameSearch : Form {
        
        public ProductSearchByNameSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByNameSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByName.RefreshProductSearchByName(String.Empty);
            base.Show();
        }
        
        private void buttonProductSearchByNameSearch_Click(object sender, EventArgs e) {
            durianProductSearchByName.RefreshProductSearchByName(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
