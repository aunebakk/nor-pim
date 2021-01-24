/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:26:28 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeProductCategoryImageEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeProductCategoryImageContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeProductCategoryImageEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductCategoryImageContract();
                _isNew = true;
                this.Text += " - Not Savable (ProductCategory,User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/599dcb45-f71b-4672-bb18-46975a4fe9b3
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryImageContract();
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
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByProductCategory(System.Guid productCategoryId) {
            try {
                _contract = new CrudeProductCategoryImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryId = productCategoryId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByProductCategoryImageTypeAndImage(string productCategoryImageTypeRcd, byte[] image) {
            try {
                _contract = new CrudeProductCategoryImageContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductCategoryImageTypeRcd = productCategoryImageTypeRcd;
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd != null ? _contract.ProductCategoryImageTypeRcd : String.Empty;
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
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId) {
            try {
                _contract = new CrudeProductCategoryImageContract();
                _isNew = true;
                _contract.ProductCategoryId = productCategoryId;
                _contract.ProductCategoryImageTypeRcd = productCategoryImageTypeRcd;
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd != null ? _contract.ProductCategoryImageTypeRcd : String.Empty;
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
        
        // shows the form in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/49afd26c-4f21-4992-967b-be190eacef77
        public void ShowAsEdit(System.Guid productCategoryImageId) {
            var service = new CrudeProductCategoryImageServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductCategoryImageId(productCategoryImageId);
                productCategoryImageTypeRefCombo.Text = _contract.ProductCategoryImageTypeRcd != null ? _contract.ProductCategoryImageTypeRcd : String.Empty;
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
        
        // saves the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/c9522930-91f8-4468-a936-8030bb2a6482
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeProductCategoryImageServiceClient();
            try {
                _contract.ProductCategoryImageTypeRcd = productCategoryImageTypeRefCombo.Text;
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
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/876f1492-f546-42ac-aae3-11837d1d842a
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // converts the Image type to an Byte array
        // links:
        //  docLink: http://sql2x.org/documentationLink/ac94f7ee-48d6-4fbe-a6ad-47b2b82ebf3f
        private byte[] ImageToByte(Image image) {
            try {
                var converter = new ImageConverter ();

                return ( byte[] ) converter.ConvertTo ( image , typeof ( byte[] ) );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Image object to a Byte Array" , ex );
            }
        }
        
        // converts an Byte array to an Image type
        // links:
        //  docLink: http://sql2x.org/documentationLink/4f58759f-70d7-4f6b-a580-18b4a2c1b316
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
        
        // load and show an image
        // links:
        //  docLink: http://sql2x.org/documentationLink/57fd259e-063b-4fa2-bc88-94cad231c0d9
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
