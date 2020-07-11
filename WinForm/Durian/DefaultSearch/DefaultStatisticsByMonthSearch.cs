using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultStatisticsByMonthSearch : Form {
        
        public DefaultStatisticsByMonthSearch() {
           InitializeComponent();
           this.AcceptButton = buttonDefaultStatisticsByMonthSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianDefaultStatisticsByMonth.RefreshDefaultStatisticsByMonth();
            base.Show();
        }
        
        private void buttonDefaultStatisticsByMonthSearch_Click(object sender, EventArgs e) {
            durianDefaultStatisticsByMonth.RefreshDefaultStatisticsByMonth();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
