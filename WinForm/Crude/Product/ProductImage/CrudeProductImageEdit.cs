/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:20 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductImageEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductImageContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductImageEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                Text += " - Not Savable (Product,User Missing)";
                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProductImageTypeAndImage(string productImageTypeRcd, byte[] image) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductImageTypeRcd = productImageTypeRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : string.Empty;
                _contract.Image = image;
                if (_contract.Image != null) {
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                }

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows by foreign keys
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.ProductId = productId;
                _contract.ProductImageTypeRcd = productImageTypeRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : string.Empty;
                _contract.ImageFileName = imageFileName;
                textBoxImageFileName.Text = _contract.ImageFileName;
                _contract.Image = image;
                if (_contract.Image != null) {
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                }

                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form in edit modus
        public void ShowAsEdit(System.Guid productImageId) {
            CrudeProductImageServiceClient service = new CrudeProductImageServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductImageId(productImageId);
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : string.Empty;
                textBoxImageFileName.Text = _contract.ImageFileName;
                if (_contract.Image != null) {
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                }

                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                service.Close();
            }
        }

        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeProductImageServiceClient service = new CrudeProductImageServiceClient();
            try {
                _contract.ProductImageTypeRcd = productImageTypeRefCombo.Text;
                _contract.ImageFileName = textBoxImageFileName.Text;
                _contract.Image = ImageToByte(pictureBoxImage.Image);

                if (_isNew) {
                    service.Insert(_contract);
                } else {
                    service.Update(_contract);
                }
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            } finally {
                service.Close();
            }

            Close();
        }

        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        // converts the Image type to an Byte array
        private byte[] ImageToByte(Image image) {
            try {
                ImageConverter converter = new ImageConverter();

                return (byte[])converter.ConvertTo(image, typeof(byte[]));
            } catch (Exception ex) {
                throw new Exception("Failed to convert from a Image object to a Byte Array", ex);
            }
        }

        // converts an Byte array to an Image type
        private Image ByteToImage(byte[] byteArrayIn) {
            try {
                if (byteArrayIn.Length == 0) {
                    return null;
                }

                MemoryStream ms = new MemoryStream(byteArrayIn);

                return Image.FromStream(ms);
            } catch (Exception ex) {
                throw new Exception("Failed to convert from a Byte Array to an Image object", ex);
            }
        }

        // load and show an image
        private void buttonImageLoad_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog(Parent);
                if (!string.IsNullOrEmpty(file.FileName)) {
                    pictureBoxImage.Load(file.FileName);
                }
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }
    }
}
