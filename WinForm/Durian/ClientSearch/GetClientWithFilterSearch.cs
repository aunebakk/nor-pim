using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetClientWithFilterSearch : Form {
        
        public GetClientWithFilterSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetClientWithFilterSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetClientWithFilter.RefreshGetClientWithFilter(String.Empty, String.Empty);
            base.Show();
        }
        
        private void buttonGetClientWithFilterSearch_Click(object sender, EventArgs e) {
            durianGetClientWithFilter.RefreshGetClientWithFilter(String.Empty, String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
