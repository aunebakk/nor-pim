/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:41:01 AM
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductInfoSearch : Form {
        
        private System.Guid _productId;
        
        private string _productInfoRcd;
        
        private System.Guid _userId;
        
        public ProductInfoSearch() {
            InitializeComponent();
            InitializeGridProductInfo();
            this.AcceptButton = buttonProductInfoSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productId, string productInfoRcd, System.Guid userId) {
            _productId = productId;
            _productInfoRcd = productInfoRcd;
            _userId = userId;
            RefreshProductInfo();
            base.Show();
        }
        
        private void buttonProductInfoEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        private void buttonProductInfoAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductInfo_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        private void buttonProductInfoSearch_Click(object sender, EventArgs e) {
            RefreshProductInfo();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductInfo() {
            var productInfo = new ProductMaintenanceSearchService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productInfo.ProductMaintenanceInfoIndexWithFilter(_productId);
                dataGridViewProductInfo.AutoGenerateColumns = false;
                dataGridViewProductInfo.DataSource = bindingSource;
                dataGridViewProductInfo.AutoResizeColumns();
                dataGridViewProductInfo.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productInfo.Close();
            }
        }
        
        private void InitializeGridProductInfo() {
            dataGridViewProductInfo.Columns.Clear();
            dataGridViewProductInfo.AutoGenerateColumns = false;
            dataGridViewProductInfo.Columns.Add("ProductName","Product Name");
            dataGridViewProductInfo.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductInfo.Columns.Add("StateRcd","State");
            dataGridViewProductInfo.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductInfo.Columns.Add("ProductInfoName","Product Info Name");
            dataGridViewProductInfo.Columns["ProductInfoName"].DataPropertyName = "ProductInfoName";
            dataGridViewProductInfo.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductInfo.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductInfo.Columns.Add("ProductId","Product Id");
            dataGridViewProductInfo.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductInfo.Columns["ProductId"].Visible = false;
            dataGridViewProductInfo.Columns.Add("ProductInfoRcd","Product Info");
            dataGridViewProductInfo.Columns["ProductInfoRcd"].DataPropertyName = "ProductInfoRcd";
            dataGridViewProductInfo.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewProductInfo.Columns["ProductInfoValue"].DataPropertyName = "ProductInfoValue";
            dataGridViewProductInfo.Columns.Add("UserId","User Id");
            dataGridViewProductInfo.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductInfo.Columns["UserId"].Visible = false;
            dataGridViewProductInfo.Columns.Add("DateTime","Date Time");
            dataGridViewProductInfo.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductInfo.Columns.Add("ProductInfoId","Product Info Id");
            dataGridViewProductInfo.Columns["ProductInfoId"].DataPropertyName = "ProductInfoId";
            dataGridViewProductInfo.Columns["ProductInfoId"].Visible = false;
            dataGridViewProductInfo.Columns.Add("ExtensionData", "");
            dataGridViewProductInfo.Columns["ExtensionData"].Visible = false;

            dataGridViewProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductInfo.AutoResizeColumns();
        }
    }
}
