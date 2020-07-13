using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetCartProductSearch : Form {
        
        public GetCartProductSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetCartProductSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetCartProduct.RefreshGetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, String.Empty);
            base.Show();
        }
        
        private void buttonGetCartProductSearch_Click(object sender, EventArgs e) {
            durianGetCartProduct.RefreshGetCartProduct(Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
