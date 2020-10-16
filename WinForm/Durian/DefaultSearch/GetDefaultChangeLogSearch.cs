using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class GetDefaultChangeLogSearch : Form {

        public GetDefaultChangeLogSearch() {
            InitializeComponent();
            AcceptButton = buttonGetDefaultChangeLogSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianGetDefaultChangeLog.RefreshGetDefaultChangeLog(string.Empty, string.Empty, Guid.Empty, Guid.Empty);
            base.Show();
        }

        private void buttonGetDefaultChangeLogSearch_Click(object sender, EventArgs e) {
            durianGetDefaultChangeLog.RefreshGetDefaultChangeLog(string.Empty, string.Empty, Guid.Empty, Guid.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
