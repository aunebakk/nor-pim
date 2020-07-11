using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserActivityRecentSearch : Form {
        
        public DefaultUserActivityRecentSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultUserActivityRecentSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultUserActivityRecent.RefreshDefaultUserActivityRecent(Guid.Empty);
            base.Show();
        }
        
        private void buttonDefaultUserActivityRecentSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityRecent.RefreshDefaultUserActivityRecent(Guid.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
