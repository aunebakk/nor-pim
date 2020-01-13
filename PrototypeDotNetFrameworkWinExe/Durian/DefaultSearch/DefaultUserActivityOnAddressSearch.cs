using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityOnAddressSearch : Form {
        
        public DefaultUserActivityOnAddressSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultUserActivityOnAddressSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultUserActivityOnAddress.RefreshDefaultUserActivityOnAddress(String.Empty);
            base.Show();
        }
        
        private void buttonDefaultUserActivityOnAddressSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityOnAddress.RefreshDefaultUserActivityOnAddress(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
