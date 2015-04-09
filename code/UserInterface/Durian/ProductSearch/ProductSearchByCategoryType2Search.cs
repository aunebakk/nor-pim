using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType2Search : Form {
        
        public ProductSearchByCategoryType2Search() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType2();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchByCategoryType2 = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchByCategoryType2.ProductSearchByCategoryType2(Guid.Empty, false);
                gridProductSearchByCategoryType2.AutoGenerateColumns = true;
                gridProductSearchByCategoryType2.DataSource = bindingSource;
                gridProductSearchByCategoryType2.AutoResizeColumns();
                gridProductSearchByCategoryType2.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchByCategoryType2.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchByCategoryType2() {
            gridProductSearchByCategoryType2.Columns.Clear();
            gridProductSearchByCategoryType2.AutoGenerateColumns = false;
            gridProductSearchByCategoryType2.Columns.Add("ProductId","Product Id");
            gridProductSearchByCategoryType2.Columns.Add("ProductName","Product Name");
            gridProductSearchByCategoryType2.Columns.Add("Gtin","Gtin");
            gridProductSearchByCategoryType2.Columns.Add("Hn","Hn");
            gridProductSearchByCategoryType2.Columns.Add("Color","Color");
            gridProductSearchByCategoryType2.Columns.Add("ExtensionData", "");
            gridProductSearchByCategoryType2.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchByCategoryType2.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchByCategoryType2.AutoResizeColumns();
        }
    }
}
