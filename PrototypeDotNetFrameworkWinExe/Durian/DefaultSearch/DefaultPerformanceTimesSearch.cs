using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceTimesSearch : Form {
        
        public DefaultPerformanceTimesSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultPerformanceTimesSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultPerformanceTimes.RefreshDefaultPerformanceTimes(String.Empty);
            base.Show();
        }
        
        private void buttonDefaultPerformanceTimesSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceTimes.RefreshDefaultPerformanceTimes(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
