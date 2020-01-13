using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class DefaultPerformanceIndicatorsSearch : Form {
        
        public DefaultPerformanceIndicatorsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultPerformanceIndicatorsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultPerformanceIndicators.RefreshDefaultPerformanceIndicators();
            base.Show();
        }
        
        private void buttonDefaultPerformanceIndicatorsSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceIndicators.RefreshDefaultPerformanceIndicators();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
