/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:26:24 AM
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
    public partial class CrudeClientDocumentEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeClientDocumentContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeClientDocumentEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientDocumentContract();
                _isNew = true;
                this.Text += " - Not Savable (Client,User Missing)";
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
                _contract = new CrudeClientDocumentContract();
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId) {
            try {
                _contract = new CrudeClientDocumentContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientDocumentTypeRcd = clientDocumentTypeRcd;
                clientDocumentTypeRefCombo.Text = _contract.ClientDocumentTypeRcd != null ? _contract.ClientDocumentTypeRcd : String.Empty;
                _contract.DocumentName = documentName;
                textBoxDocumentName.Text = _contract.DocumentName;
                _contract.DocumentDateTime = documentDateTime;
                dateTimePickerDocumentDateTime.Value = _contract.DocumentDateTime != DateTime.MinValue ? _contract.DocumentDateTime : dateTimePickerDocumentDateTime.MinDate;
                dateTimePickerDocumentDateTime.Checked = _contract.DocumentDateTime != DateTime.MinValue;
                _contract.ExpiryDateTime = expiryDateTime;
                dateTimePickerExpiryDateTime.Value = _contract.ExpiryDateTime != DateTime.MinValue ? _contract.ExpiryDateTime : dateTimePickerExpiryDateTime.MinDate;
                dateTimePickerExpiryDateTime.Checked = _contract.ExpiryDateTime != DateTime.MinValue;
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
        public void ShowAsEdit(System.Guid clientDocumentId) {
            var service = new CrudeClientDocumentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientDocumentId(clientDocumentId);
                clientDocumentTypeRefCombo.Text = _contract.ClientDocumentTypeRcd != null ? _contract.ClientDocumentTypeRcd : String.Empty;
                textBoxDocumentName.Text = _contract.DocumentName;
                dateTimePickerDocumentDateTime.Value = _contract.DocumentDateTime != DateTime.MinValue ? _contract.DocumentDateTime : dateTimePickerDocumentDateTime.MinDate;
                dateTimePickerDocumentDateTime.Checked = _contract.DocumentDateTime != DateTime.MinValue;
                dateTimePickerExpiryDateTime.Value = _contract.ExpiryDateTime != DateTime.MinValue ? _contract.ExpiryDateTime : dateTimePickerExpiryDateTime.MinDate;
                dateTimePickerExpiryDateTime.Checked = _contract.ExpiryDateTime != DateTime.MinValue;
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
            var service = new CrudeClientDocumentServiceClient();
            try {
                _contract.ClientDocumentTypeRcd = clientDocumentTypeRefCombo.Text;
                _contract.DocumentName = textBoxDocumentName.Text;
                _contract.DocumentDateTime = dateTimePickerDocumentDateTime.Checked ? Convert.ToDateTime(dateTimePickerDocumentDateTime.Value): DateTime.MinValue;
                _contract.ExpiryDateTime = dateTimePickerExpiryDateTime.Checked ? Convert.ToDateTime(dateTimePickerExpiryDateTime.Value): DateTime.MinValue;

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
    }
}
