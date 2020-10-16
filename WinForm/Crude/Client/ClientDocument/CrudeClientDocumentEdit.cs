/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:17 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using SolutionNorSolutionPim.BusinessLogicLayer;
using System;
using System.Windows.Forms;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeClientDocumentEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeClientDocumentContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientDocumentEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientDocumentContract();
                _isNew = true;
                Text += " - Not Savable (Client,User Missing)";
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
                _contract = new CrudeClientDocumentContract();
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

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId) {
            try {
                _contract = new CrudeClientDocumentContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientDocumentTypeRcd = clientDocumentTypeRcd;
                clientDocumentTypeRefCombo.Text = _contract.ClientDocumentTypeRcd != null ? _contract.ClientDocumentTypeRcd : string.Empty;
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
            } catch (Exception ex) {
                if (ex == null) { } else {
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        // shows the form in edit modus
        public void ShowAsEdit(System.Guid clientDocumentId) {
            CrudeClientDocumentServiceClient service = new CrudeClientDocumentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientDocumentId(clientDocumentId);
                clientDocumentTypeRefCombo.Text = _contract.ClientDocumentTypeRcd != null ? _contract.ClientDocumentTypeRcd : string.Empty;
                textBoxDocumentName.Text = _contract.DocumentName;
                dateTimePickerDocumentDateTime.Value = _contract.DocumentDateTime != DateTime.MinValue ? _contract.DocumentDateTime : dateTimePickerDocumentDateTime.MinDate;
                dateTimePickerDocumentDateTime.Checked = _contract.DocumentDateTime != DateTime.MinValue;
                dateTimePickerExpiryDateTime.Value = _contract.ExpiryDateTime != DateTime.MinValue ? _contract.ExpiryDateTime : dateTimePickerExpiryDateTime.MinDate;
                dateTimePickerExpiryDateTime.Checked = _contract.ExpiryDateTime != DateTime.MinValue;
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
            CrudeClientDocumentServiceClient service = new CrudeClientDocumentServiceClient();
            try {
                _contract.ClientDocumentTypeRcd = clientDocumentTypeRefCombo.Text;
                _contract.DocumentName = textBoxDocumentName.Text;
                _contract.DocumentDateTime = dateTimePickerDocumentDateTime.Checked ? Convert.ToDateTime(dateTimePickerDocumentDateTime.Value) : DateTime.MinValue;
                _contract.ExpiryDateTime = dateTimePickerExpiryDateTime.Checked ? Convert.ToDateTime(dateTimePickerExpiryDateTime.Value) : DateTime.MinValue;

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
    }
}
