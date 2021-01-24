/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:19 AM
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
    public partial class ProductDocumentationSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _productId;
        
        private string _productDocumentationTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public ProductDocumentationSearch() {
            InitializeComponent();
            InitializeGridProductDocumentation();
            this.AcceptButton = buttonProductDocumentationSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid productId, string productDocumentationTypeRcd, System.Guid userId) {
            _productId = productId;
            _productDocumentationTypeRcd = productDocumentationTypeRcd;
            _userId = userId;
            RefreshProductDocumentation();
            base.Show();
        }
        
        // bring up edit form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonProductDocumentationEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        // bring up add form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonProductDocumentationAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for ProductDocumentation
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewProductDocumentation_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductDocumentationEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductDocumentation.CurrentRow.Cells["ProductDocumentationId"].Value);
        }
        
        // search ProductDocumentation's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonProductDocumentationSearch_Click(object sender, EventArgs e) {
            RefreshProductDocumentation();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch ProductDocumentation's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshProductDocumentation() {
            var productDocumentation = new ProductMaintenanceSearchServiceClient();
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
        
        // initialize grid forProductDocumentation's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridProductDocumentation() {
            dataGridViewProductDocumentation.Columns.Clear();
            dataGridViewProductDocumentation.AutoGenerateColumns = false;
            dataGridViewProductDocumentation.Columns.Add("ProductName","Product Name");
            dataGridViewProductDocumentation.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductDocumentation.Columns.Add("ProductDocumentationTypeName","Product Documentation Type Name");
            dataGridViewProductDocumentation.Columns["ProductDocumentationTypeName"].DataPropertyName = "ProductDocumentationTypeName";
            dataGridViewProductDocumentation.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductDocumentation.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductDocumentation.Columns.Add("StateRcd","State");
            dataGridViewProductDocumentation.Columns["StateRcd"].DataPropertyName = "StateRcd";
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
