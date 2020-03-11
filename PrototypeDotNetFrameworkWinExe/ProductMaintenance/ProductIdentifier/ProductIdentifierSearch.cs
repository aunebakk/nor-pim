/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:57:29 PM
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductIdentifierSearch : Form {
        
        private System.Guid _productId;
        
        private string _productIdentifierRcd;
        
        private System.Guid _userId;
        
        public ProductIdentifierSearch() {
            InitializeComponent();
            InitializeGridProductIdentifier();
            this.AcceptButton = buttonProductIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productId, string productIdentifierRcd, System.Guid userId) {
            _productId = productId;
            _productIdentifierRcd = productIdentifierRcd;
            _userId = userId;
            RefreshProductIdentifier();
            base.Show();
        }
        
        private void buttonProductIdentifierEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        private void buttonProductIdentifierAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        private void buttonProductIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshProductIdentifier();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductIdentifier() {
            var productIdentifier = new ProductMaintenanceSearchService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productIdentifier.ProductMaintenanceIdentifierIndexWithFilter(_productId);
                dataGridViewProductIdentifier.AutoGenerateColumns = false;
                dataGridViewProductIdentifier.DataSource = bindingSource;
                dataGridViewProductIdentifier.AutoResizeColumns();
                dataGridViewProductIdentifier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productIdentifier.Close();
            }
        }
        
        private void InitializeGridProductIdentifier() {
            dataGridViewProductIdentifier.Columns.Clear();
            dataGridViewProductIdentifier.AutoGenerateColumns = false;
            dataGridViewProductIdentifier.Columns.Add("ProductName","Product Name");
            dataGridViewProductIdentifier.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductIdentifier.Columns.Add("StateRcd","State");
            dataGridViewProductIdentifier.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductIdentifier.Columns.Add("ProductIdentifierName","Product Identifier Name");
            dataGridViewProductIdentifier.Columns["ProductIdentifierName"].DataPropertyName = "ProductIdentifierName";
            dataGridViewProductIdentifier.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductIdentifier.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductIdentifier.Columns.Add("ProductId","Product Id");
            dataGridViewProductIdentifier.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductIdentifier.Columns["ProductId"].Visible = false;
            dataGridViewProductIdentifier.Columns.Add("ProductIdentifierRcd","Product Identifier");
            dataGridViewProductIdentifier.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
            dataGridViewProductIdentifier.Columns.Add("Identifier","Identifier");
            dataGridViewProductIdentifier.Columns["Identifier"].DataPropertyName = "Identifier";
            dataGridViewProductIdentifier.Columns.Add("UserId","User Id");
            dataGridViewProductIdentifier.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductIdentifier.Columns["UserId"].Visible = false;
            dataGridViewProductIdentifier.Columns.Add("DateTime","Date Time");
            dataGridViewProductIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductIdentifier.Columns.Add("ProductIdentifierId","Product Identifier Id");
            dataGridViewProductIdentifier.Columns["ProductIdentifierId"].DataPropertyName = "ProductIdentifierId";
            dataGridViewProductIdentifier.Columns["ProductIdentifierId"].Visible = false;
            dataGridViewProductIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewProductIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductIdentifier.AutoResizeColumns();
        }
    }
}
