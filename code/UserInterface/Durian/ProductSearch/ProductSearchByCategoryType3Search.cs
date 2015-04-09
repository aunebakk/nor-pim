using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType3Search : Form {
        
        public ProductSearchByCategoryType3Search() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType3();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchByCategoryType3 = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchByCategoryType3.ProductSearchByCategoryType3(Guid.Empty, false);
                gridProductSearchByCategoryType3.AutoGenerateColumns = true;
                gridProductSearchByCategoryType3.DataSource = bindingSource;
                gridProductSearchByCategoryType3.AutoResizeColumns();
                gridProductSearchByCategoryType3.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchByCategoryType3.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchByCategoryType3() {
            gridProductSearchByCategoryType3.Columns.Clear();
            gridProductSearchByCategoryType3.AutoGenerateColumns = false;
            gridProductSearchByCategoryType3.Columns.Add("ProductId","Product Id");
            gridProductSearchByCategoryType3.Columns.Add("ProductName","Product Name");
            gridProductSearchByCategoryType3.Columns.Add("Gtin","Gtin");
            gridProductSearchByCategoryType3.Columns.Add("Hn","Hn");
            gridProductSearchByCategoryType3.Columns.Add("Color","Color");
            gridProductSearchByCategoryType3.Columns.Add("ExtensionData", "");
            gridProductSearchByCategoryType3.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchByCategoryType3.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchByCategoryType3.AutoResizeColumns();
        }
    }
}
