using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultUserActivityByHourSearch : Form {
        
        public DefaultUserActivityByHourSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultUserActivityByHourSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultUserActivityByHour.RefreshDefaultUserActivityByHour();
            base.Show();
        }
        
        private void buttonDefaultUserActivityByHourSearch_Click(object sender, EventArgs e) {
            durianDefaultUserActivityByHour.RefreshDefaultUserActivityByHour();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
