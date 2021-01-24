/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:48 AM
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
    public partial class ProductInfoSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _productId;
        
        private string _productInfoRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public ProductInfoSearch() {
            InitializeComponent();
            InitializeGridProductInfo();
            this.AcceptButton = buttonProductInfoSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid productId, string productInfoRcd, System.Guid userId) {
            _productId = productId;
            _productInfoRcd = productInfoRcd;
            _userId = userId;
            RefreshProductInfo();
            base.Show();
        }
        
        // bring up edit form for ProductInfo
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonProductInfoEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        // bring up add form for ProductInfo
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonProductInfoAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for ProductInfo
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewProductInfo_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductInfoEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductInfo.CurrentRow.Cells["ProductInfoId"].Value);
        }
        
        // search ProductInfo's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonProductInfoSearch_Click(object sender, EventArgs e) {
            RefreshProductInfo();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch ProductInfo's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshProductInfo() {
            var productInfo = new ProductMaintenanceSearchServiceClient();
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
        
        // initialize grid forProductInfo's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridProductInfo() {
            dataGridViewProductInfo.Columns.Clear();
            dataGridViewProductInfo.AutoGenerateColumns = false;
            dataGridViewProductInfo.Columns.Add("ProductName","Product Name");
            dataGridViewProductInfo.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductInfo.Columns.Add("ProductInfoName","Product Info Name");
            dataGridViewProductInfo.Columns["ProductInfoName"].DataPropertyName = "ProductInfoName";
            dataGridViewProductInfo.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductInfo.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductInfo.Columns.Add("StateRcd","State");
            dataGridViewProductInfo.Columns["StateRcd"].DataPropertyName = "StateRcd";
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
