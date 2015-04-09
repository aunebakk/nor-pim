using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CategoryTreeSearch : Form {
        
        public CategoryTreeSearch() {
           InitializeComponent();
           InitializeGridCategoryTree();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            CategorySearchService categoryTree = new CategorySearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = categoryTree.CategoryTree();
                gridCategoryTree.AutoGenerateColumns = true;
                gridCategoryTree.DataSource = bindingSource;
                gridCategoryTree.AutoResizeColumns();
                gridCategoryTree.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                categoryTree.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridCategoryTree() {
            gridCategoryTree.Columns.Clear();
            gridCategoryTree.AutoGenerateColumns = false;
            gridCategoryTree.Columns.Add("ProductCategoryId","Product Category Id");
            gridCategoryTree.Columns.Add("ProductCategoryParentId","Product Category Parent Id");
            gridCategoryTree.Columns.Add("ProductCategoryCode","Product Category Code");
            gridCategoryTree.Columns.Add("ProductCategoryName","Product Category Name");
            gridCategoryTree.Columns.Add("ExtensionData", "");
            gridCategoryTree.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridCategoryTree.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridCategoryTree.AutoResizeColumns();
        }
    }
}
