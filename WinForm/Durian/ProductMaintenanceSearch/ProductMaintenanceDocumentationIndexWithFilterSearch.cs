using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceDocumentationIndexWithFilterSearch : Form {
        
        public ProductMaintenanceDocumentationIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceDocumentationIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductMaintenanceDocumentationIndexWithFilter.RefreshProductMaintenanceDocumentationIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonProductMaintenanceDocumentationIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceDocumentationIndexWithFilter.RefreshProductMaintenanceDocumentationIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
