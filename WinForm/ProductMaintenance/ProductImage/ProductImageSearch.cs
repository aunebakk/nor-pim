/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:54:38 AM
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
    public partial class ProductImageSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _productId;
        
        private string _productImageTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public ProductImageSearch() {
            InitializeComponent();
            InitializeGridProductImage();
            this.AcceptButton = buttonProductImageSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid productId, string productImageTypeRcd, System.Guid userId) {
            _productId = productId;
            _productImageTypeRcd = productImageTypeRcd;
            _userId = userId;
            RefreshProductImage();
            base.Show();
        }
        
        // bring up edit form for ProductImage
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonProductImageEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        // bring up add form for ProductImage
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonProductImageAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for ProductImage
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewProductImage_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        // search ProductImage's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonProductImageSearch_Click(object sender, EventArgs e) {
            RefreshProductImage();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch ProductImage's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshProductImage() {
            var productImage = new ProductMaintenanceSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = productImage.ProductMaintenanceImageIndexWithFilter(_productId);
                dataGridViewProductImage.AutoGenerateColumns = false;
                dataGridViewProductImage.DataSource = bindingSource;
                dataGridViewProductImage.AutoResizeColumns();
                dataGridViewProductImage.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                productImage.Close();
            }
        }
        
        // initialize grid forProductImage's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridProductImage() {
            dataGridViewProductImage.Columns.Clear();
            dataGridViewProductImage.AutoGenerateColumns = false;
            dataGridViewProductImage.Columns.Add("ProductName","Product Name");
            dataGridViewProductImage.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductImage.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductImage.Columns["ProductImageTypeName"].DataPropertyName = "ProductImageTypeName";
            dataGridViewProductImage.Columns.Add("ImageFileName","Image File Name");
            dataGridViewProductImage.Columns["ImageFileName"].DataPropertyName = "ImageFileName";
            dataGridViewProductImage.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductImage.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewProductImage.Columns.Add("StateRcd","State");
            dataGridViewProductImage.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductImage.Columns.Add("ProductId","Product Id");
            dataGridViewProductImage.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewProductImage.Columns["ProductId"].Visible = false;
            dataGridViewProductImage.Columns.Add("ProductImageTypeRcd","Product Image Type");
            dataGridViewProductImage.Columns["ProductImageTypeRcd"].DataPropertyName = "ProductImageTypeRcd";
            dataGridViewProductImage.Columns.Add("Image","Image");
            dataGridViewProductImage.Columns["Image"].DataPropertyName = "Image";
            dataGridViewProductImage.Columns.Add("UserId","User Id");
            dataGridViewProductImage.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewProductImage.Columns["UserId"].Visible = false;
            dataGridViewProductImage.Columns.Add("DateTime","Date Time");
            dataGridViewProductImage.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewProductImage.Columns.Add("ProductImageId","Product Image Id");
            dataGridViewProductImage.Columns["ProductImageId"].DataPropertyName = "ProductImageId";
            dataGridViewProductImage.Columns["ProductImageId"].Visible = false;
            dataGridViewProductImage.Columns.Add("ExtensionData", "");
            dataGridViewProductImage.Columns["ExtensionData"].Visible = false;

            dataGridViewProductImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductImage.AutoResizeColumns();
        }
    }
}
