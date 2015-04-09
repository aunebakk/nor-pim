using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using norpim.BusinessLogicLayer;

namespace norpim.UserInterface {
    
    
    public partial class CrudeProductImageEdit : Form {
        
        private CrudeProductImageContract _contract;
        
        private Boolean isNew;
        
        private Guid _productId;
        
        private Guid _userId;
        
        public CrudeProductImageEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductImageContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productId, Guid userId) {
            _contract = new CrudeProductImageContract();
            isNew = true;
            _productId = productId;
            productPicker.SelectedValue = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productImageId) {
            var service = new CrudeProductImageService();
            isNew = false;
            try {
                _contract = service.FetchByProductImageId(productImageId);
                productPicker.SelectedValue = _contract.ProductId;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd;
                pictureBoxImage.Image = ByteToImage(_contract.Image);
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                textBoxImageFileName.Text = _contract.ImageFileName;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductImageService service = new CrudeProductImageService();
            try {
                _contract.ProductId = (Guid)(productPicker.SelectedValue);
                _contract.ProductImageTypeRcd = (productImageTypeRefCombo.Text);
                _contract.Image = ImageToByte(pictureBoxImage.Image);
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
                _contract.ImageFileName = (textBoxImageFileName.Text);
                if (isNew)
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private byte[] ImageToByte(System.Drawing.Image image) {
            var converter = new ImageConverter();
            return (byte[]) converter.ConvertTo(image, typeof(byte[]));
        }
        
        private System.Drawing.Image ByteToImage(byte[] byteArrayIn) {
            var ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
    }
}
