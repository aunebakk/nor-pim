using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryCodeSearch : Form {
        
        public ProductSearchByCategoryCodeSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategoryCodeSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategoryCode.RefreshProductSearchByCategoryCode(String.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategoryCodeSearch_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryCode.RefreshProductSearchByCategoryCode(String.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
