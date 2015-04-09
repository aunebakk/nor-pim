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
    
    
    public partial class CrudeProductCategoryImageEdit : Form {
        
        private CrudeProductCategoryImageContract _contract;
        
        private Boolean isNew;
        
        private Guid _productCategoryId;
        
        private Guid _userId;
        
        public CrudeProductCategoryImageEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeProductCategoryImageContract();
            isNew = true;
            Show();
        }
        
        public void ShowAsAdd(Guid productCategoryId, Guid userId) {
            _contract = new CrudeProductCategoryImageContract();
            isNew = true;
            _productCategoryId = productCategoryId;
            productCategoryPicker.SelectedValue = productCategoryId;
            _userId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsEdit(System.Guid productCategoryImageId) {
            var service = new CrudeProductCategoryImageService();
            isNew = false;
            try {
                _contract = service.FetchByProductCategoryImageId(productCategoryImageId);
                productCategoryPicker.SelectedValue = _contract.ProductCategoryId;
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd;
                pictureBoxImage.Image = ByteToImage(_contract.Image);
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductCategoryImageService service = new CrudeProductCategoryImageService();
            try {
                _contract.ProductCategoryId = (Guid)(productCategoryPicker.SelectedValue);
                _contract.ProductCategoryImageTypeRcd = (productCategoryImageTypeRefCombo.Text);
                _contract.Image = ImageToByte(pictureBoxImage.Image);
                _contract.UserId = (Guid)(userPicker.SelectedValue);
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);
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
