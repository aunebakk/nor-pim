/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:41:14 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ProductImageSearch : Form {
        
        private System.Guid _productId;
        
        private string _productImageTypeRcd;
        
        private System.Guid _userId;
        
        public ProductImageSearch() {
            InitializeComponent();
            InitializeGridProductImage();
            this.AcceptButton = buttonProductImageSearch;
            this.CancelButton = buttonClose;
        }
        
        public void Show(System.Guid productId, string productImageTypeRcd, System.Guid userId) {
            _productId = productId;
            _productImageTypeRcd = productImageTypeRcd;
            _userId = userId;
            RefreshProductImage();
            base.Show();
        }
        
        private void buttonProductImageEdit_Click(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        private void buttonProductImageAdd_Click(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        private void dataGridViewProductImage_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewProductImage.CurrentRow.Cells["ProductImageId"].Value);
        }
        
        private void buttonProductImageSearch_Click(object sender, EventArgs e) {
            RefreshProductImage();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshProductImage() {
            var productImage = new ProductMaintenanceSearchService();
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
        
        private void InitializeGridProductImage() {
            dataGridViewProductImage.Columns.Clear();
            dataGridViewProductImage.AutoGenerateColumns = false;
            dataGridViewProductImage.Columns.Add("ProductName","Product Name");
            dataGridViewProductImage.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewProductImage.Columns.Add("StateRcd","State");
            dataGridViewProductImage.Columns["StateRcd"].DataPropertyName = "StateRcd";
            dataGridViewProductImage.Columns.Add("ProductImageTypeName","Product Image Type Name");
            dataGridViewProductImage.Columns["ProductImageTypeName"].DataPropertyName = "ProductImageTypeName";
            dataGridViewProductImage.Columns.Add("ImageFileName","Image File Name");
            dataGridViewProductImage.Columns["ImageFileName"].DataPropertyName = "ImageFileName";
            dataGridViewProductImage.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewProductImage.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
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
