using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CategoryFindSearch : Form {
        
        public CategoryFindSearch() {
           InitializeComponent();
           InitializeGridCategoryFind();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            CategorySearchService categoryFind = new CategorySearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = categoryFind.CategoryFind(String.Empty);
                gridCategoryFind.AutoGenerateColumns = true;
                gridCategoryFind.DataSource = bindingSource;
                gridCategoryFind.AutoResizeColumns();
                gridCategoryFind.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                categoryFind.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridCategoryFind() {
            gridCategoryFind.Columns.Clear();
            gridCategoryFind.AutoGenerateColumns = false;
            gridCategoryFind.Columns.Add("ProductCategoryCode","Product Category Code");
            gridCategoryFind.Columns.Add("ProductName","Product Name");
            gridCategoryFind.Columns.Add("ProductCategoryId","Product Category Id");
            gridCategoryFind.Columns.Add("ProductId","Product Id");
            gridCategoryFind.Columns.Add("ExtensionData", "");
            gridCategoryFind.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridCategoryFind.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridCategoryFind.AutoResizeColumns();
        }
    }
}
