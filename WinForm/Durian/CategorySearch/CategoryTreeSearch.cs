using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CategoryTreeSearch : Form {

        public CategoryTreeSearch() {
            InitializeComponent();
            AcceptButton = buttonCategoryTreeSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianCategoryTree.RefreshCategoryTree();
            base.Show();
        }

        private void buttonCategoryTreeSearch_Click(object sender, EventArgs e) {
            durianCategoryTree.RefreshCategoryTree();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
