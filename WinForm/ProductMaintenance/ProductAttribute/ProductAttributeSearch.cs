/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:23:58 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductAttributeSearch : Form {
        
        private System.Guid _productId;
        
        private string _productAttributeRcd;
        
        private string _productAttributeUnitRcd;
        
        private System.Guid _userId;
        
        public ProductAttributeSearch() {
            InitializeComponent();
            InitializeGridProductAttribute();
            this.AcceptButton = buttonProductAttributeSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, System.Guid userId) {
            _productId = productId;
            _productAttributeRcd = productAttributeRcd;
            _productAttributeUnitRcd = productAttributeUnitRcd;
            _userId = userId;
            RefreshProductAttribute();
            base.Show();
        }
        
        private void buttonProductAttributeEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        private void buttonProductAttributeAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductAttribute_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        private void buttonProductAttributeSearch_Click(object sender, EventArgs e) {
            RefreshProductAttribute();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductAttribute() {
            var productAttribute = new ProductMaintenanceSearchService();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productAttribute.ProductMaintenanceAttributeIndexWithFilter(_productId);
                dataGridViewProductAttribute.AutoGenerateColumns = false;
                dataGridViewProductAttribute.DataSource = bindingSource;
                dataGridViewProductAttribute.AutoResizeColumns();
                dataGridViewProductAttribute.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productAttribute.Close();
            }
        }
        
        private void InitializeGridProductAttribute() {
            dataGridViewProductAttribute.Columns.Clear();
            dataGridViewProductAttribute.AutoGenerateColumns = false;
            dataGridViewProductAttribute.Columns.Add("ProductName","Product Name");
            dataGridViewProductAttribute.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductAttribute.Columns.Add("StateRcd","State");
            dataGridViewProductAttribute.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeName","Product Attribute Name");
            dataGridViewProductAttribute.Columns["ProductAttributeName"].DataPropertyName = "ProductAttributeName";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
            dataGridViewProductAttribute.Columns["ProductAttributeUnitName"].DataPropertyName = "ProductAttributeUnitName";
            dataGridViewProductAttribute.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductAttribute.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductAttribute.Columns.Add("ProductId","Product Id");
            dataGridViewProductAttribute.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductAttribute.Columns["ProductId"].Visible = false;
            dataGridViewProductAttribute.Columns.Add("ProductAttributeRcd","Product Attribute");
            dataGridViewProductAttribute.Columns["ProductAttributeRcd"].DataPropertyName = "ProductAttributeRcd";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeUnitRcd","Product Attribute Unit");
            dataGridViewProductAttribute.Columns["ProductAttributeUnitRcd"].DataPropertyName = "ProductAttributeUnitRcd";
            dataGridViewProductAttribute.Columns.Add("Value","Value");
            dataGridViewProductAttribute.Columns["Value"].DataPropertyName = "Value";
            dataGridViewProductAttribute.Columns.Add("UserId","User Id");
            dataGridViewProductAttribute.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductAttribute.Columns["UserId"].Visible = false;
            dataGridViewProductAttribute.Columns.Add("DateTime","Date Time");
            dataGridViewProductAttribute.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeId","Product Attribute Id");
            dataGridViewProductAttribute.Columns["ProductAttributeId"].DataPropertyName = "ProductAttributeId";
            dataGridViewProductAttribute.Columns["ProductAttributeId"].Visible = false;
            dataGridViewProductAttribute.Columns.Add("ExtensionData", "");
            dataGridViewProductAttribute.Columns["ExtensionData"].Visible = false;

            dataGridViewProductAttribute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductAttribute.AutoResizeColumns();
        }
    }
}
