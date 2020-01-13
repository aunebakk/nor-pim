using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategorySearch : Form {
        
        public ProductSearchByCategorySearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategorySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategory.RefreshProductSearchByCategory(Guid.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategorySearch_Click(object sender, EventArgs e) {
            durianProductSearchByCategory.RefreshProductSearchByCategory(Guid.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
