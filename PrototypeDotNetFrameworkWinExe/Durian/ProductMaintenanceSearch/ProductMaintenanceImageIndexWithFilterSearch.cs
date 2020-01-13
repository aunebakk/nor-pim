using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceImageIndexWithFilterSearch : Form {
        
        public ProductMaintenanceImageIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceImageIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductMaintenanceImageIndexWithFilter.RefreshProductMaintenanceImageIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonProductMaintenanceImageIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceImageIndexWithFilter.RefreshProductMaintenanceImageIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
