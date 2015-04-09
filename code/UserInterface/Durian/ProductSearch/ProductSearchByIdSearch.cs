using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ProductSearchByIdSearch : Form {
        
        public ProductSearchByIdSearch() {
           InitializeComponent();
           InitializeGridProductSearchById();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ProductSearchService productSearchById = new ProductSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productSearchById.ProductSearchById(Guid.Empty);
                gridProductSearchById.AutoGenerateColumns = true;
                gridProductSearchById.DataSource = bindingSource;
                gridProductSearchById.AutoResizeColumns();
                gridProductSearchById.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productSearchById.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridProductSearchById() {
            gridProductSearchById.Columns.Clear();
            gridProductSearchById.AutoGenerateColumns = false;
            gridProductSearchById.Columns.Add("ProductName","Product Name");
            gridProductSearchById.Columns.Add("Identifier","Identifier");
            gridProductSearchById.Columns.Add("Value","Value");
            gridProductSearchById.Columns.Add("ProductInfoValue","Product Info Value");
            gridProductSearchById.Columns.Add("ProductImageTypeRcd","Product Image Type");
            gridProductSearchById.Columns.Add("ProductImageTypeName","Product Image Type Name");
            gridProductSearchById.Columns.Add("Image","Image");
            gridProductSearchById.Columns.Add("ExtensionData", "");
            gridProductSearchById.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridProductSearchById.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridProductSearchById.AutoResizeColumns();
        }
    }
}
