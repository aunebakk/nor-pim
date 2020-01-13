using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultErrorOverviewSearch : Form {
        
        public DefaultErrorOverviewSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultErrorOverviewSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultErrorOverview.RefreshDefaultErrorOverview();
            base.Show();
        }
        
        private void buttonDefaultErrorOverviewSearch_Click(object sender, EventArgs e) {
            durianDefaultErrorOverview.RefreshDefaultErrorOverview();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
