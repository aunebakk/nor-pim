using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductMaintenanceIndexSearch : Form {
        
        public ProductMaintenanceIndexSearch() {
           InitializeComponent();
           this.AcceptButton = buttonProductMaintenanceIndexSearch;
           this.CancelButton = buttonClose;
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
