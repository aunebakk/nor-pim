using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByCategorySearch : Form {
        
        public ProductSearchByCategorySearch() {
           InitializeComponent();
           InitializeGridProductSearchByCategory();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchByCategory = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchByCategory.ProductSearchByCategory(Guid.Empty, false);
                gridProductSearchByCategory.AutoGenerateColumns = true;
                gridProductSearchByCategory.DataSource = bindingSource;
                gridProductSearchByCategory.AutoResizeColumns();
                gridProductSearchByCategory.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchByCategory.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchByCategory() {
            gridProductSearchByCategory.Columns.Clear();
            gridProductSearchByCategory.AutoGenerateColumns = false;
            gridProductSearchByCategory.Columns.Add("ProductId","Product Id");
            gridProductSearchByCategory.Columns.Add("ProductName","Product Name");
            gridProductSearchByCategory.Columns.Add("Identifier","Identifier");
            gridProductSearchByCategory.Columns.Add("Value","Value");
            gridProductSearchByCategory.Columns.Add("ProductInfoValue","Product Info Value");
            gridProductSearchByCategory.Columns.Add("ProductImageTypeRcd","Product Image Type");
            gridProductSearchByCategory.Columns.Add("ProductImageTypeName","Product Image Type Name");
            gridProductSearchByCategory.Columns.Add("Image","Image");
            gridProductSearchByCategory.Columns.Add("ExtensionData", "");
            gridProductSearchByCategory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchByCategory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchByCategory.AutoResizeColumns();
        }
    }
}
