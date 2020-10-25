using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultPerformanceTimeCommandsSearch : Form {
        
        public DefaultPerformanceTimeCommandsSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultPerformanceTimeCommandsSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultPerformanceTimeCommands.RefreshDefaultPerformanceTimeCommands();
            base.Show();
        }
        
        private void buttonDefaultPerformanceTimeCommandsSearch_Click(object sender, EventArgs e) {
            durianDefaultPerformanceTimeCommands.RefreshDefaultPerformanceTimeCommands();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
