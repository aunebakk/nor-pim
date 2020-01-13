using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetCartProductWithFilterSearch : Form {
        
        public GetCartProductWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetCartProductWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetCartProductWithFilter.RefreshGetCartProductWithFilter();
            base.Show();
        }
        
        private void buttonGetCartProductWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetCartProductWithFilter.RefreshGetCartProductWithFilter();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
