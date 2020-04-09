/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:46:20 PM
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductDocumentationSearch : Form {
        
        private System.Guid _productId;
        
        private string _productDocumentationTypeRcd;
        
        private System.Guid _userId;
        
        public ProductDocumentationSearch() {
            InitializeComponent();
            InitializeGridProductDocumentation();
            this.AcceptButton = buttonProductDocumentationSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productId, string productDocumentationTypeRcd, System.Guid userId) {
            _productId = productId;
            _productDocumentationTypeRcd = productDocumentationTypeRcd;
            _userId = userId;
            RefreshProductDocumentation();
            base.Show();
        }
        
        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        private void buttonProductDocumentationSearch_Click(object sender, EventArgs e) {
            RefreshProductDocumentation();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductDocumentation() {
            var productDocumentation = new ProductMaintenanceSearchService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productDocumentation.ProductMaintenanceDocumentationIndexWithFilter(_productId);
                dataGridViewProductDocumentation.AutoGenerateColumns = false;
                dataGridViewProductDocumentation.DataSource = bindingSource;
                dataGridViewProductDocumentation.AutoResizeColumns();
                dataGridViewProductDocumentation.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productDocumentation.Close();
            }
        }
        
        private void InitializeGridProductDocumentation() {
            dataGridViewProductDocumentation.Columns.Clear();
            dataGridViewProductDocumentation.AutoGenerateColumns = false;
            dataGridViewProductDocumentation.Columns.Add("ProductName","Product Name");
            dataGridViewProductDocumentation.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductDocumentation.Columns.Add("StateRcd","State");
            dataGridViewProductDocumentation.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductDocumentation.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
            dataGridViewProductDocumentation.Columns["ProductDocumentationTypeName"].DataPropertyName = "ProductDocumentationTypeName";
            dataGridViewProductDocumentation.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductDocumentation.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductDocumentation.Columns.Add("ProductId","Product Id");
            dataGridViewProductDocumentation.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductDocumentation.Columns["ProductId"].Visible = false;
            dataGridViewProductDocumentation.Columns.Add("ProductDocumentationTypeRcd","Product Documentation Type");
            dataGridViewProductDocumentation.Columns["ProductDocumentationTypeRcd"].DataPropertyName = "ProductDocumentationTypeRcd";
            dataGridViewProductDocumentation.Columns.Add("Documentation","Documentation");
            dataGridViewProductDocumentation.Columns["Documentation"].DataPropertyName = "Documentation";
            dataGridViewProductDocumentation.Columns.Add("UserId","User Id");
            dataGridViewProductDocumentation.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductDocumentation.Columns["UserId"].Visible = false;
            dataGridViewProductDocumentation.Columns.Add("DateTime","Date Time");
            dataGridViewProductDocumentation.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductDocumentation.Columns.Add("ProductDocumentationId","Product Documentation Id");
            dataGridViewProductDocumentation.Columns["ProductDocumentationId"].DataPropertyName = "ProductDocumentationId";
            dataGridViewProductDocumentation.Columns["ProductDocumentationId"].Visible = false;
            dataGridViewProductDocumentation.Columns.Add("ExtensionData", "");
            dataGridViewProductDocumentation.Columns["ExtensionData"].Visible = false;

            dataGridViewProductDocumentation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductDocumentation.AutoResizeColumns();
        }
    }
}
