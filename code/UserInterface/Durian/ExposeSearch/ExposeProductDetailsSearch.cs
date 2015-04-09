using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class ExposeProductDetailsSearch : Form {
        
        public ExposeProductDetailsSearch() {
           InitializeComponent();
           InitializeGridExposeProductDetails();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            ExposeSearchService exposeProductDetails = new ExposeSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = exposeProductDetails.ExposeProductDetails(Guid.Empty);
                gridExposeProductDetails.AutoGenerateColumns = true;
                gridExposeProductDetails.DataSource = bindingSource;
                gridExposeProductDetails.AutoResizeColumns();
                gridExposeProductDetails.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                exposeProductDetails.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridExposeProductDetails() {
            gridExposeProductDetails.Columns.Clear();
            gridExposeProductDetails.AutoGenerateColumns = false;
            gridExposeProductDetails.Columns.Add("ExposeProductId","Expose Product Id");
            gridExposeProductDetails.Columns.Add("ProductName","Product Name");
            gridExposeProductDetails.Columns.Add("ProductCategoryName","Product Category Name");
            gridExposeProductDetails.Columns.Add("ProductUserName","Product User Name");
            gridExposeProductDetails.Columns.Add("ProductDateTime","Product Date Time");
            gridExposeProductDetails.Columns.Add("ProductStateName","Product State Name");
            gridExposeProductDetails.Columns.Add("ExtensionData", "");
            gridExposeProductDetails.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridExposeProductDetails.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridExposeProductDetails.AutoResizeColumns();
        }
    }
}
