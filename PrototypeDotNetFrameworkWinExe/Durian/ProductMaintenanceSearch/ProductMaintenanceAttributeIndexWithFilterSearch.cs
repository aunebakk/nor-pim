using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceAttributeIndexWithFilterSearch : Form {
        
        public ProductMaintenanceAttributeIndexWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceAttributeIndexWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianProductMaintenanceAttributeIndexWithFilter.RefreshProductMaintenanceAttributeIndexWithFilter(Guid.Empty);
            base.Show();
        }
        
        private void buttonProductMaintenanceAttributeIndexWithFilterSearch_Click(object sender, EventArgs e) {
            durianProductMaintenanceAttributeIndexWithFilter.RefreshProductMaintenanceAttributeIndexWithFilter(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
