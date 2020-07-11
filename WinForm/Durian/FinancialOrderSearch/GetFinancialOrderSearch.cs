using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetFinancialOrderSearch : Form {
        
        public GetFinancialOrderSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetFinancialOrderSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetFinancialOrder.RefreshGetFinancialOrder(Guid.Empty, Guid.Empty, Guid.Empty, String.Empty, Guid.Empty, Guid.Empty);
            base.Show();
        }
        
        private void buttonGetFinancialOrderSearch_Click(object sender, EventArgs e) {
            durianGetFinancialOrder.RefreshGetFinancialOrder(Guid.Empty, Guid.Empty, Guid.Empty, String.Empty, Guid.Empty, Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
