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
        
    public partial class ProductCategoryImageEdit : Form {
        
        private CrudeProductCategoryImageContract _contract;
        private Guid _userId;
        
        public ProductCategoryImageEdit() {
           InitializeComponent();
           this.AcceptButton = btnSave;
           this.CancelButton = btnClose;
        }
        
        public void ShowAsAdd(Guid productCategoryId,
                              Guid userId
                              ) {
            _contract = new CrudeProductCategoryImageContract();
            _contract.ProductCategoryId = productCategoryId;                    
            _contract.UserId = userId;
            _userId = userId;
            Show();
        }
        
        public void ShowAsEdit( Guid productCategoryImageId,
                                Guid userId
                                ) {
            var service = new CrudeProductCategoryImageService();
            try {
                _contract = service.FetchByProductCategoryImageId(productCategoryImageId);
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd;
                pictureBoxImage.Image = ByteToImage(_contract.Image);
                dateTimePickerDateTime.Text = _contract.DateTime.ToLongDateString();                
                _userId = userId;
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductCategoryImageService();
            try {
                _contract.ProductCategoryImageTypeRcd = (productCategoryImageTypeRefCombo.Text);
                _contract.Image = ImageToByte(pictureBoxImage.Image);
                _contract.UserId = _userId;
                _contract.DateTime = Convert.ToDateTime(dateTimePickerDateTime.Value);

                if (_contract.ProductCategoryImageId == Guid.Empty)
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
        
        private void btnClose_Click(object sender, EventArgs e) {
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

        private void buttonLoad_Click(object sender, EventArgs e) {
            var file = new OpenFileDialog();
            file.ShowDialog(this.Parent);
            Singleton.Instance.Log(file.FileName);
            //pictureBoxImage.Load(@"C:\Development\norpim\code\UserInterface\Images\iconBack.png");
            pictureBoxImage.Load(file.FileName);
        }
    }
}
