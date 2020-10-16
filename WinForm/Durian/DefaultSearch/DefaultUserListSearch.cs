using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class DefaultUserListSearch : Form {

        public DefaultUserListSearch() {
            InitializeComponent();
            AcceptButton = buttonDefaultUserListSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianDefaultUserList.RefreshDefaultUserList();
            base.Show();
        }

        private void buttonDefaultUserListSearch_Click(object sender, EventArgs e) {
            durianDefaultUserList.RefreshDefaultUserList();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
