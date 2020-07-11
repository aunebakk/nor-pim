using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType3Search : Form {
        
        public ProductSearchByCategoryType3Search() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategoryType3Search;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategoryType3.RefreshProductSearchByCategoryType3(Guid.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategoryType3Search_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryType3.RefreshProductSearchByCategoryType3(Guid.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
