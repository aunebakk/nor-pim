using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class GatherProductDetailsSearch : Form {
        
        public GatherProductDetailsSearch() {
           InitializeComponent();
           InitializeGridGatherProductDetails();
           this.AcceptButton = btnSearch;
           this.CancelButton = btnClose;
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            GatherSearchService gatherProductDetails = new GatherSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = gatherProductDetails.GatherProductDetails(Guid.Empty);
                gridGatherProductDetails.AutoGenerateColumns = true;
                gridGatherProductDetails.DataSource = bindingSource;
                gridGatherProductDetails.AutoResizeColumns();
                gridGatherProductDetails.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                gatherProductDetails.Close();
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void InitializeGridGatherProductDetails() {
            gridGatherProductDetails.Columns.Clear();
            gridGatherProductDetails.AutoGenerateColumns = false;
            gridGatherProductDetails.Columns.Add("ProductId","Product Id");
            gridGatherProductDetails.Columns.Add("ProductGatherKeyValue","Product Gather Key Value");
            gridGatherProductDetails.Columns.Add("ProductName","Product Name");
            gridGatherProductDetails.Columns.Add("ProductCategoryName","Product Category Name");
            gridGatherProductDetails.Columns.Add("ProductUserName","Product User Name");
            gridGatherProductDetails.Columns.Add("ProductDateTime","Product Date Time");
            gridGatherProductDetails.Columns.Add("ProductStateName","Product State Name");
            gridGatherProductDetails.Columns.Add("ExtensionData", "");
            gridGatherProductDetails.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridGatherProductDetails.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            gridGatherProductDetails.AutoResizeColumns();
        }

        private void buttonProductHistory_Click(object sender, EventArgs e) {
            try { 
                Guid productId = (System.Guid) gridGatherProductDetails.CurrentRow.Cells["ProductId"].Value;
                var history = new ProductHistory(productId);
                history.MdiParent = this.MdiParent;
                Singleton.Instance.CheckForm(history);
                history.Show();
            } catch (Exception ex) {
                Singleton.Instance.Error(ex);
            }
        }
    }
}
