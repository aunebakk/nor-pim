/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 9:31:41 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductMaintenanceSearch : Form {
        
        private System.Guid _productBecameId;
        
        private System.Guid _userId;
        
        public ProductMaintenanceSearch() {
            InitializeComponent();
            InitializeGridProductMaintenance();
            this.AcceptButton = buttonProductMaintenanceSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productBecameId, System.Guid userId) {
            _productBecameId = productBecameId;
            _userId = userId;
            RefreshProductMaintenance();
            base.Show();
        }
        
        private void buttonProductMaintenanceEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductMaintenanceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductMaintenance.CurrentRow.Cells["ProductId"].Value);
        }
        
        private void buttonProductMaintenanceAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductMaintenanceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductMaintenance_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductMaintenanceEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductMaintenance.CurrentRow.Cells["ProductId"].Value);
        }
        
        private void buttonProductMaintenanceSearch_Click(object sender, EventArgs e) {
            RefreshProductMaintenance();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductMaintenance() {
            var product = new ProductMaintenanceSearchService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = product.ProductMaintenanceIndex();
                dataGridViewProductMaintenance.AutoGenerateColumns = false;
                dataGridViewProductMaintenance.DataSource = bindingSource;
                dataGridViewProductMaintenance.AutoResizeColumns();
                dataGridViewProductMaintenance.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                product.Close();
            }
        }
        
        private void InitializeGridProductMaintenance() {
            dataGridViewProductMaintenance.Columns.Clear();
            dataGridViewProductMaintenance.AutoGenerateColumns = false;
            dataGridViewProductMaintenance.Columns.Add("ProductName","Product Name");
            dataGridViewProductMaintenance.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductMaintenance.Columns.Add("StateRcd","State");
            dataGridViewProductMaintenance.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductMaintenance.Columns.Add("UserId","User Id");
            dataGridViewProductMaintenance.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductMaintenance.Columns["UserId"].Visible = false;
            dataGridViewProductMaintenance.Columns.Add("DateTime","Date Time");
            dataGridViewProductMaintenance.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductMaintenance.Columns.Add("ProductId","Product Id");
            dataGridViewProductMaintenance.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductMaintenance.Columns["ProductId"].Visible = false;
            dataGridViewProductMaintenance.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductMaintenance.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductMaintenance.Columns.Add("ExtensionData", "");
            dataGridViewProductMaintenance.Columns["ExtensionData"].Visible = false;

            dataGridViewProductMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductMaintenance.AutoResizeColumns();
        }
    }
}
