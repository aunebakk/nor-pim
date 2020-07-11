using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductSearchByCategoryType4Search : Form {
        
        public ProductSearchByCategoryType4Search() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategoryType4Search;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategoryType4.RefreshProductSearchByCategoryType4(Guid.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategoryType4Search_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryType4.RefreshProductSearchByCategoryType4(Guid.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
