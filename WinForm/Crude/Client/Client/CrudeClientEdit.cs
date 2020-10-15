/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 1:35:29 PM
  From Machine: DESKTOP-742U247
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
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeClientEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeClientContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                this.Text += " - Not Savable (User Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeClientContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.ClientTypeRcd = clientTypeRcd;
                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;
                _contract.ClientNationalityRcd = clientNationalityRcd;
                clientNationalityRefCombo.Text = _contract.ClientNationalityRcd != null ? _contract.ClientNationalityRcd : String.Empty;
                _contract.ClientGenderRcd = clientGenderRcd;
                clientGenderRefCombo.Text = _contract.ClientGenderRcd != null ? _contract.ClientGenderRcd : String.Empty;
                _contract.ClientTitleRcd = clientTitleRcd;
                clientTitleRefCombo.Text = _contract.ClientTitleRcd != null ? _contract.ClientTitleRcd : String.Empty;
                _contract.ClientAddressId = clientAddressId;
                _contract.FirstName = firstName;
                textBoxFirstName.Text = _contract.FirstName;
                _contract.MiddleName = middleName;
                textBoxMiddleName.Text = _contract.MiddleName;
                _contract.LastName = lastName;
                textBoxLastName.Text = _contract.LastName;
                _contract.Image = image;
                if (_contract.Image != null)
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                _contract.ImageBlobFilename = imageBlobFilename;
                textBoxImageBlobFilename.Text = _contract.ImageBlobFilename;
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
        public void ShowAsEdit(System.Guid clientId) {
            var service = new CrudeClientServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientId(clientId);
                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;
                clientNationalityRefCombo.Text = _contract.ClientNationalityRcd != null ? _contract.ClientNationalityRcd : String.Empty;
                clientGenderRefCombo.Text = _contract.ClientGenderRcd != null ? _contract.ClientGenderRcd : String.Empty;
                clientTitleRefCombo.Text = _contract.ClientTitleRcd != null ? _contract.ClientTitleRcd : String.Empty;
                textBoxFirstName.Text = _contract.FirstName;
                textBoxMiddleName.Text = _contract.MiddleName;
                textBoxLastName.Text = _contract.LastName;
                if (_contract.Image != null)
                    pictureBoxImage.Image = ByteToImage(_contract.Image);
                textBoxImageBlobFilename.Text = _contract.ImageBlobFilename;
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
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeClientServiceClient();
            try {
                _contract.ClientTypeRcd = clientTypeRefCombo.Text;
                _contract.ClientNationalityRcd = clientNationalityRefCombo.Text;
                _contract.ClientGenderRcd = clientGenderRefCombo.Text;
                _contract.ClientTitleRcd = clientTitleRefCombo.Text;
                _contract.FirstName = textBoxFirstName.Text;
                _contract.MiddleName = textBoxMiddleName.Text;
                _contract.LastName = textBoxLastName.Text;
                _contract.Image = ImageToByte(pictureBoxImage.Image);
                _contract.ImageBlobFilename = textBoxImageBlobFilename.Text;

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
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // converts the Image type to an Byte array
        private byte[] ImageToByte(Image image) {
            try {
                var converter = new ImageConverter ();

                return ( byte[] ) converter.ConvertTo ( image , typeof ( byte[] ) );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Image object to a Byte Array" , ex );
            }
        }
        
        // converts an Byte array to an Image type
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
