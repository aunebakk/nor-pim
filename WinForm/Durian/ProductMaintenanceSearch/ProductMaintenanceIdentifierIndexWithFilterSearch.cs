using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceIdentifierIndexWithFilterSearch : Form {

        public ProductMaintenanceIdentifierIndexWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonProductMaintenanceIdentifierIndexWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductMaintenanceIdentifierIndexWithFilter.RefreshProductMaintenanceIdentifierIndexWithFilter(Guid.Empty);
            base.Show();
        }

        private void buttonProductMaintenanceIdentifierIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceIdentifierIndexWithFilter.RefreshProductMaintenanceIdentifierIndexWithFilter(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
