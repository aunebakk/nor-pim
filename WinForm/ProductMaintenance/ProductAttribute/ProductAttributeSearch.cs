/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:45 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/e652f7b4-5cee-4eaa-8cbf-547f51efd7c6
    public partial class ProductAttributeSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _productId;
        
        private string _productAttributeRcd;
        
        private string _productAttributeUnitRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public ProductAttributeSearch() {
            InitializeComponent();
            InitializeGridProductAttribute();
            this.AcceptButton = buttonProductAttributeSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, System.Guid userId) {
            _productId = productId;
            _productAttributeRcd = productAttributeRcd;
            _productAttributeUnitRcd = productAttributeUnitRcd;
            _userId = userId;
            RefreshProductAttribute();
            base.Show();
        }
        
        // bring up edit form for ProductAttribute
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonProductAttributeEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        // bring up add form for ProductAttribute
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonProductAttributeAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for ProductAttribute
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewProductAttribute_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductAttributeEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductAttribute.CurrentRow.Cells["ProductAttributeId"].Value);
        }
        
        // search ProductAttribute's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonProductAttributeSearch_Click(object sender, EventArgs e) {
            RefreshProductAttribute();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch ProductAttribute's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
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
        
        // initialize grid forProductAttribute's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridProductAttribute() {
            dataGridViewProductAttribute.Columns.Clear();
            dataGridViewProductAttribute.AutoGenerateColumns = false;
            dataGridViewProductAttribute.Columns.Add("ProductName","Product Name");
            dataGridViewProductAttribute.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeName","Product Attribute Name");
            dataGridViewProductAttribute.Columns["ProductAttributeName"].DataPropertyName = "ProductAttributeName";
            dataGridViewProductAttribute.Columns.Add("ProductAttributeUnitName","Product Attribute Unit Name");
            dataGridViewProductAttribute.Columns["ProductAttributeUnitName"].DataPropertyName = "ProductAttributeUnitName";
            dataGridViewProductAttribute.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductAttribute.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductAttribute.Columns.Add("StateRcd","State");
            dataGridViewProductAttribute.Columns["StateRcd"].DataPropertyName = "StateRcd";
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
