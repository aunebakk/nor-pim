/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:23 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductImageEdit : Form {
        
        private CrudeProductImageContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductImageEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                this.Text += " - Not Savable (Product,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProductImageTypeAndImage(string productImageTypeRcd, byte[] image) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductImageTypeRcd = productImageTypeRcd;
                productImageTypeRefCombo.Text = _contract.ProductImageTypeRcd != null ? _contract.ProductImageTypeRcd : String.Empty;
                _contract.Image = image;
                if (_contract.Image != null)
                    pictureBoxImage.Image = ByteToImage(_contract.Image);

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeProductImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId) {
            try {
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

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
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

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
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
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        private byte[] ImageToByte(Image image) {
            try {
                var converter = new ImageConverter ();

                return ( byte[] ) converter.ConvertTo ( image , typeof ( byte[] ) );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Image object to a Byte Array" , ex );
            }
        }
        
        private Image ByteToImage(byte[] byteArrayIn) {
            try {
                if ( byteArrayIn.Length == 0 )
                    return null;

                var ms = new MemoryStream ( byteArrayIn );

                return Image.FromStream ( ms );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Byte Array to an Image object" , ex );
            }
        }
        
        private void buttonImageLoad_Click(object sender, EventArgs e) {
            try {
                var file = new OpenFileDialog ();
                file.ShowDialog ( this.Parent );
                if (!string.IsNullOrEmpty( file.FileName ) )
                    pictureBoxImage.Load ( file.FileName );
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
