using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class GetDefaultChangeLogSearch : Form {
        
        public GetDefaultChangeLogSearch() {
           InitializeComponent();
           this.AcceptButton = buttonGetDefaultChangeLogSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianGetDefaultChangeLog.RefreshGetDefaultChangeLog(String.Empty, String.Empty, Guid.Empty, Guid.Empty);
            base.Show();
        }
        
        private void buttonGetDefaultChangeLogSearch_Click(object sender, EventArgs e) {
            durianGetDefaultChangeLog.RefreshGetDefaultChangeLog(String.Empty, String.Empty, Guid.Empty, Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
