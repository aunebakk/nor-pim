using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer.Other;

namespace norpim.UserInterface {
    
    
    public partial class ProductHistory : Form {
        Guid _productId = Guid.Empty;

        public ProductHistory(Guid productId) {
           InitializeComponent();
           InitializeGrid();
           _productId = productId;
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductServiceClient productHistory = new ProductServiceClient();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productHistory.ProductHistory(_productId);
                grid.AutoGenerateColumns = true;
                grid.DataSource = bindingSource;
                grid.AutoResizeColumns();
                grid.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productHistory.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();

        }
        
        private void InitializeGrid() {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;
            grid.Columns.Add("ProductId","Product Id");
            grid.Columns.Add("ProductName","Product Name");
            grid.Columns.Add("StateName","State");
            grid.Columns.Add("DateTime","Date Time");
            grid.Columns.Add("UserName","User Name");
            grid.Columns.Add("ProductBecameId","Product Became Id");
            grid.Columns.Add("ExtensionData", "");
            grid.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in grid.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            grid.AutoResizeColumns();

        }

        private void buttonHistory_Click(object sender, EventArgs e) {
            if (grid.CurrentRow.Cells["ProductId"].Value == null) 
                return;

            Guid productId = (System.Guid) grid.CurrentRow.Cells["ProductId"].Value;
            var history = new ProductHistory(productId);
            history.MdiParent = this.MdiParent;
            Singleton.Instance.CheckForm(history);
            history.Show();
        }
    }
}
