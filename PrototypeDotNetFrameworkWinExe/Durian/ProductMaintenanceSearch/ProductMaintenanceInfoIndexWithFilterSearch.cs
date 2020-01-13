using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceInfoIndexWithFilterSearch : Form {
        
        public ProductMaintenanceInfoIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceInfoIndexWithFilterSearch;
           this.CancelButton = buttonClose;
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
