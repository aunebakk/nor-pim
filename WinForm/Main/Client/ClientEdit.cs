/// Signature
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class ClientEdit : Form {
        private CrudeClientContract _contract;
        private Boolean _isNew;

        public ClientEdit() {
            InitializeComponent ();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }

        public void ShowAsAdd() {
            try { 
                _contract = new CrudeClientContract ();
                _isNew = true;
                this.Text += " - Not Savable (User Missing?)";
                Show ();
            } catch ( Exception ex ) {
                if (ex != null) { }
            }
        }

        public void ShowAsAddByRules( System.Guid userId ) {
            try {
                _contract = new CrudeClientContract ();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString ();

                Show ();
            } catch ( Exception ex ) {
                if (ex != null) { }
            }
        }

        public void ShowAsAdd( string clientTypeRcd , string clientNationalityRcd , string clientGenderRcd , string clientTitleRcd , System.Guid clientAddressId , string firstName , string middleName , string lastName , byte[] image , string imageBlobFilename , System.Guid userId ) {
            // keep values used to initialize the form for cases where the values are not shown/edited but meant for saving 
            try {
                _contract = new CrudeClientContract ();
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
                if ( _contract.Image != null )
                    pictureBoxImage.Image = ByteToImage ( _contract.Image );
                _contract.ImageBlobFilename = imageBlobFilename;
                textBoxImageBlobFilename.Text = _contract.ImageBlobFilename;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString ();

                Show ();
            } catch ( Exception ex ) {
                if (ex != null) { }
            }
        }

        public void ShowAsEdit( System.Guid clientId ) {
            var service = new CrudeClientServiceClient ();
            _isNew = false;
            try {
                // keep original values from database for cases where the values are not shown/edited but meant for updating
                _contract = service.FetchByClientId ( clientId );

                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;
                clientNationalityRefCombo.Text = _contract.ClientNationalityRcd != null ? _contract.ClientNationalityRcd : String.Empty;
                clientGenderRefCombo.Text = _contract.ClientGenderRcd != null ? _contract.ClientGenderRcd : String.Empty;
                clientTitleRefCombo.Text = _contract.ClientTitleRcd != null ? _contract.ClientTitleRcd : String.Empty;
                textBoxFirstName.Text = _contract.FirstName;
                textBoxMiddleName.Text = _contract.MiddleName;
                textBoxLastName.Text = _contract.LastName;
                if ( _contract.Image != null )
                    pictureBoxImage.Image = ByteToImage ( _contract.Image );
                textBoxImageBlobFilename.Text = _contract.ImageBlobFilename;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString ();

                Show ();
            } catch ( Exception ex ) {
                if ( ex.HResult == 000 )
                    if (ex != null) { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close ();
            }
        }

        private void buttonSave_Click( object sender , EventArgs e ) {
            var service = new CrudeClientServiceClient ();
            try {
                _contract.ClientTypeRcd = clientTypeRefCombo.Text;
                _contract.ClientNationalityRcd = clientNationalityRefCombo.Text;
                _contract.ClientGenderRcd = clientGenderRefCombo.Text;
                _contract.ClientTitleRcd = clientTitleRefCombo.Text;
                _contract.FirstName = textBoxFirstName.Text;
                _contract.MiddleName = textBoxMiddleName.Text;
                _contract.LastName = textBoxLastName.Text;
                _contract.Image = ImageToByte ( pictureBoxImage.Image );
                _contract.ImageBlobFilename = textBoxImageBlobFilename.Text;

                if ( _isNew )
                    service.Insert ( _contract );
                else
                    service.Update ( _contract );
            } catch ( Exception ex ) {
                if ( ex.HResult == -2146233087 ) // {"The remote server returned an unexpected response: (413) Request Entity Too Large."}, 
                    MessageBox.Show ( "Request Entity Too Large" );
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close ();
            }

            Close ();
        }

        private void buttonClose_Click( object sender , EventArgs e ) {
            Close ();
        }

        private byte[] ImageToByte( Image image ) {
            try {
                var converter = new ImageConverter ();

                return ( byte[] ) converter.ConvertTo ( image , typeof ( byte[] ) );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Image object to a Byte Array" , ex );
            }
        }

        private Image ByteToImage( byte[] byteArrayIn ) {
            try {
                if ( byteArrayIn.Length == 0 )
                    return null;

                var ms = new MemoryStream ( byteArrayIn );

                return Image.FromStream ( ms );
            } catch ( Exception ex ) {
                throw new Exception ( "Failed to convert from a Byte Array to an Image object" , ex );
            }
        }

        private void buttonImageLoad_Click( object sender , EventArgs e ) {
            try {
                var file = new OpenFileDialog ();
                file.ShowDialog ( this.Parent );
                if (!string.IsNullOrEmpty( file.FileName ) )
                    pictureBoxImage.Load ( file.FileName );
            } catch ( Exception ex ) {
                if (ex.HResult == -2146233079) // "ImageLocation must be set.", never mid
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
