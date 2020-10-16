using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceInfoIndexWithFilterSearch : Form {

        public ProductMaintenanceInfoIndexWithFilterSearch() {
            InitializeComponent();
            AcceptButton = buttonProductMaintenanceInfoIndexWithFilterSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductMaintenanceInfoIndexWithFilter.RefreshProductMaintenanceInfoIndexWithFilter(Guid.Empty);
            base.Show();
        }

        private void buttonProductMaintenanceInfoIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceInfoIndexWithFilter.RefreshProductMaintenanceInfoIndexWithFilter(Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
