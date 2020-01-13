using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CategoryTreeSearch : Form {
        
        public CategoryTreeSearch() {
           InitializeComponent();
           this.AcceptButton = buttonCategoryTreeSearch;
           this.CancelButton = buttonClose;
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
