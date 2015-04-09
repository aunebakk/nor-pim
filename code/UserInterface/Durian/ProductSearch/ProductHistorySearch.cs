using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductHistorySearch : Form {
        
        public ProductHistorySearch() {
           InitializeComponent();
           InitializeGridProductHistory();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productHistory = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productHistory.ProductHistory(Guid.Empty);
                gridProductHistory.AutoGenerateColumns = true;
                gridProductHistory.DataSource = bindingSource;
                gridProductHistory.AutoResizeColumns();
                gridProductHistory.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productHistory.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductHistory() {
            gridProductHistory.Columns.Clear();
            gridProductHistory.AutoGenerateColumns = false;
            gridProductHistory.Columns.Add("ProductId","Product Id");
            gridProductHistory.Columns.Add("ProductName","Product Name");
            gridProductHistory.Columns.Add("StateName","State Name");
            gridProductHistory.Columns.Add("DateTime","Date Time");
            gridProductHistory.Columns.Add("UserName","User Name");
            gridProductHistory.Columns.Add("ProductBecameId","Product Became Id");
            gridProductHistory.Columns.Add("ExtensionData", "");
            gridProductHistory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductHistory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductHistory.AutoResizeColumns();
        }
    }
}
