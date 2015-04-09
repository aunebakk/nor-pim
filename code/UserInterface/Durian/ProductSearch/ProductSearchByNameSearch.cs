using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByNameSearch : Form {
        
        public ProductSearchByNameSearch() {
           InitializeComponent();
           InitializeGridProductSearchByName();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchByName = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchByName.ProductSearchByName(String.Empty);
                gridProductSearchByName.AutoGenerateColumns = true;
                gridProductSearchByName.DataSource = bindingSource;
                gridProductSearchByName.AutoResizeColumns();
                gridProductSearchByName.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchByName.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchByName() {
            gridProductSearchByName.Columns.Clear();
            gridProductSearchByName.AutoGenerateColumns = false;
            gridProductSearchByName.Columns.Add("ProductId","Product Id");
            gridProductSearchByName.Columns.Add("ProductName","Product Name");
            gridProductSearchByName.Columns.Add("Identifier","Identifier");
            gridProductSearchByName.Columns.Add("Value","Value");
            gridProductSearchByName.Columns.Add("ProductInfoValue","Product Info Value");
            gridProductSearchByName.Columns.Add("ProductImageTypeRcd","Product Image Type");
            gridProductSearchByName.Columns.Add("ProductImageTypeName","Product Image Type Name");
            gridProductSearchByName.Columns.Add("Image","Image");
            gridProductSearchByName.Columns.Add("ExtensionData", "");
            gridProductSearchByName.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchByName.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchByName.AutoResizeColumns();
        }
    }
}
