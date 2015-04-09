using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByCategoryType1Search : Form {
        
        public ProductSearchByCategoryType1Search() {
           InitializeComponent();
           InitializeGridProductSearchByCategoryType1();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchByCategoryType1 = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchByCategoryType1.ProductSearchByCategoryType1(Guid.Empty, false);
                gridProductSearchByCategoryType1.AutoGenerateColumns = true;
                gridProductSearchByCategoryType1.DataSource = bindingSource;
                gridProductSearchByCategoryType1.AutoResizeColumns();
                gridProductSearchByCategoryType1.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchByCategoryType1.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchByCategoryType1() {
            gridProductSearchByCategoryType1.Columns.Clear();
            gridProductSearchByCategoryType1.AutoGenerateColumns = false;
            gridProductSearchByCategoryType1.Columns.Add("ProductId","Product Id");
            gridProductSearchByCategoryType1.Columns.Add("ProductName","Product Name");
            gridProductSearchByCategoryType1.Columns.Add("Gtin","Gtin");
            gridProductSearchByCategoryType1.Columns.Add("Color","Color");
            gridProductSearchByCategoryType1.Columns.Add("ExtensionData", "");
            gridProductSearchByCategoryType1.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchByCategoryType1.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchByCategoryType1.AutoResizeColumns();
        }
    }
}
