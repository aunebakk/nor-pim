using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType1Search : Form {
        
        public ProductSearchByCategoryType1Search() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategoryType1Search;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategoryType1.RefreshProductSearchByCategoryType1(Guid.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategoryType1Search_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryType1.RefreshProductSearchByCategoryType1(Guid.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
