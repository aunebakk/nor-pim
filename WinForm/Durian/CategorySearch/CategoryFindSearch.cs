using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CategoryFindSearch : Form {

        public CategoryFindSearch() {
            InitializeComponent();
            AcceptButton = buttonCategoryFindSearch;
            CancelButton = buttonClose;
        }

        public new void Show() {
            durianCategoryFind.RefreshCategoryFind(string.Empty);
            base.Show();
        }

        private void buttonCategoryFindSearch_Click(object sender, EventArgs e) {
            durianCategoryFind.RefreshCategoryFind(string.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
