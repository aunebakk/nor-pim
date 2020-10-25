using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CategoryFindSearch : Form {
        
        public CategoryFindSearch() {
           InitializeComponent();
           this.AcceptButton = buttonCategoryFindSearch;
           this.CancelButton = buttonClose;
        }
        
        public new void Show() {
            durianCategoryFind.RefreshCategoryFind(String.Empty);
            base.Show();
        }
        
        private void buttonCategoryFindSearch_Click(object sender, EventArgs e) {
            durianCategoryFind.RefreshCategoryFind(String.Empty);
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
