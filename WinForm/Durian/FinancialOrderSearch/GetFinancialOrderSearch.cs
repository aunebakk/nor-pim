using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetFinancialOrderSearch : Form {

        public GetFinancialOrderSearch() {
            InitializeComponent();
            AcceptButton = buttonGetFinancialOrderSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianGetFinancialOrder.RefreshGetFinancialOrder(Guid.Empty, Guid.Empty, Guid.Empty, string.Empty, Guid.Empty, Guid.Empty);
            base.Show();
        }

        private void buttonGetFinancialOrderSearch_Click(object sender, EventArgs e) {
            durianGetFinancialOrder.RefreshGetFinancialOrder(Guid.Empty, Guid.Empty, Guid.Empty, string.Empty, Guid.Empty, Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
