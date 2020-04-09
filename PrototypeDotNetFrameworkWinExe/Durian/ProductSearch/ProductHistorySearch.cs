using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductHistorySearch : Form {
        
        public ProductHistorySearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductHistorySearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductHistory.RefreshProductHistory(Guid.Empty);
            base.Show();
        }
        
        private void buttonProductHistorySearch_Click(object sender, EventArgs e) {
            durianProductHistory.RefreshProductHistory(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
