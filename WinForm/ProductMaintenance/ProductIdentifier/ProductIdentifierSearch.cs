/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:29 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/c4e2b5ff-4b03-4e33-b63a-7c9899829434
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/e652f7b4-5cee-4eaa-8cbf-547f51efd7c6
    public partial class ProductIdentifierSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _productId;
        
        private string _productIdentifierRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public ProductIdentifierSearch() {
            InitializeComponent();
            InitializeGridProductIdentifier();
            this.AcceptButton = buttonProductIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid productId, string productIdentifierRcd, System.Guid userId) {
            _productId = productId;
            _productIdentifierRcd = productIdentifierRcd;
            _userId = userId;
            RefreshProductIdentifier();
            base.Show();
        }
        
        // bring up edit form for ProductIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonProductIdentifierEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        // bring up add form for ProductIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonProductIdentifierAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for ProductIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewProductIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
        }
        
        // search ProductIdentifier's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonProductIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshProductIdentifier();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch ProductIdentifier's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshProductIdentifier() {
            var productIdentifier = new ProductMaintenanceSearchServiceClient();
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
        
        // initialize grid forProductIdentifier's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridProductIdentifier() {
            dataGridViewProductIdentifier.Columns.Clear();
            dataGridViewProductIdentifier.AutoGenerateColumns = false;
            dataGridViewProductIdentifier.Columns.Add("ProductName","Product Name");
            dataGridViewProductIdentifier.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductIdentifier.Columns.Add("ProductIdentifierName","Product Identifier Name");
            dataGridViewProductIdentifier.Columns["ProductIdentifierName"].DataPropertyName = "ProductIdentifierName";
            dataGridViewProductIdentifier.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductIdentifier.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductIdentifier.Columns.Add("StateRcd","State");
            dataGridViewProductIdentifier.Columns["StateRcd"].DataPropertyName = "StateRcd";
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
