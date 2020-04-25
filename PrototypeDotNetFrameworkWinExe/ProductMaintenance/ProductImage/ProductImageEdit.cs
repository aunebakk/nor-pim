/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:53:54 AM
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class ProductImageEdit : Form {
        
        private CrudeProductImageContract _contract;
        
        private Boolean _isNew;
        
        public ProductImageEdit() {
            InitializeComponent();
            InitializeGridProductImage();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductImageContract();
            _isNew = true;
            this.Text += " - Not Savable (Product,User Missing)";
            RefreshProductImage();
            Show();
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeProductImageContract();
            _isNew = true;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductImage();
            Show();
        }
        
        public void ShowAsAddByProductImageTypeAndImage(string productImageTypeRcd, byte[] image) {
            _contract = new CrudeProductImageContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductImageTypeRcd = productImageTypeRcd;
            productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
            _contract.Image = image;
            if (_contract.Image != null)
                pictureBoxImage.Image = ByteToImage(_contract.Image);

            RefreshProductImage();
            Show();
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            _contract = new CrudeProductImageContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ProductId = productId;

            RefreshProductImage();
            Show();
        }
        
        public void ShowAsAdd(System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId) {
            _contract = new CrudeProductImageContract();
            _isNew = true;
            _contract.ProductId = productId;
            _contract.ProductImageTypeRcd = productImageTypeRcd;
            productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
            _contract.ImageFileName = imageFileName;
            textBoxImageFileName.Text = _contract.ImageFileName;
            _contract.Image = image;
            if (_contract.Image != null)
                pictureBoxImage.Image = ByteToImage(_contract.Image);
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshProductImage();
            Show();
        }
        
        public void ShowAsEdit(System.Guid productImageId) {
            var service = new CrudeProductImageServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductImageId(productImageId);
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
                textBoxImageFileName.Text = _contract.ImageFileName;
                if (_contract.Image != null)
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshProductImage();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductImageServiceClient();
            try {
                _contract.ProductImageTypeRcd = productImageTypeRefCombo.Text;
                _contract.ImageFileName = textBoxImageFileName.Text;
                _contract.Image = ImageToByte(pictureBoxImage.Image);

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonProductImageSearch_Click(object sender, EventArgs e) {
            RefreshProductImage();
        }
        
        private void buttonProductImageEdit_Click(object sender, EventArgs e) {
        }
        
        private void buttonProductImageAdd_Click(object sender, EventArgs e) {
            RefreshProductImage();
        }
        
        private void dataGridViewProductImage_DoubleClick(object sender, EventArgs e) {
            var editForm = new ProductImageEdit();
            editForm.MdiParent = this.MdiParent;

        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private byte[] ImageToByte(Image image) {
            var converter = new ImageConverter();
            return (byte[]) converter.ConvertTo(image, typeof(byte[]));
        }
        
        private Image ByteToImage(byte[] byteArrayIn) {
            var ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
        
        public void RefreshProductImage() {

        }
        
        private void InitializeGridProductImage() {
            dataGridViewProductImage.Columns.Clear();
            dataGridViewProductImage.AutoGenerateColumns = false;
            dataGridViewProductImage.Columns.Add("ExtensionData", "");
            dataGridViewProductImage.Columns["ExtensionData"].Visible = false;

            dataGridViewProductImage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductImage.AutoResizeColumns();
        }
    }
}
