using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceIndexSearch : Form {

        public ProductMaintenanceIndexSearch() {
            InitializeComponent();
            AcceptButton = buttonProductMaintenanceIndexSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianProductMaintenanceIndex.RefreshProductMaintenanceIndex();
            base.Show();
        }

        private void buttonProductMaintenanceIndexSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceIndex.RefreshProductMaintenanceIndex();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
