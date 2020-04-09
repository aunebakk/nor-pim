using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIdentifierIndexWithFilterSearch : Form {
        
        public ProductMaintenanceIdentifierIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceIdentifierIndexWithFilterSearch;
           this.CancelButton = buttonClose;
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
