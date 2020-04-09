using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType2Search : Form {
        
        public ProductSearchByCategoryType2Search() {
           InitializeComponent();
           this.AcceptButton = buttonProductSearchByCategoryType2Search;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductSearchByCategoryType2.RefreshProductSearchByCategoryType2(Guid.Empty, false);
            base.Show();
        }
        
        private void buttonProductSearchByCategoryType2Search_Click(object sender, EventArgs e) {
            durianProductSearchByCategoryType2.RefreshProductSearchByCategoryType2(Guid.Empty, false);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
