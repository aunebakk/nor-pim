using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductHistorySearch : Form {

        public ProductHistorySearch() {
            InitializeComponent();
            AcceptButton = buttonProductHistorySearch;
            CancelButton = buttonClose;
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
