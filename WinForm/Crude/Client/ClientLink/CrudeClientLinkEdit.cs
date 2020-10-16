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
    public partial class CrudeClientLinkEdit : Form {

        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeClientLinkContract _contract;

        private bool _isNew;

        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientLinkEdit() {
            InitializeComponent();
            AcceptButton = buttonSave;
            CancelButton = buttonClose;
        }

        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientLinkContract();
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
                _contract = new CrudeClientLinkContract();
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
        public void ShowAsAdd(System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId) {
            try {
                _contract = new CrudeClientLinkContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientLinkTypeRcd = clientLinkTypeRcd;
                clientLinkTypeRefCombo.Text = _contract.ClientLinkTypeRcd != null ? _contract.ClientLinkTypeRcd : string.Empty;
                _contract.LinkName = linkName;
                textBoxLinkName.Text = _contract.LinkName;
                _contract.Link = link;
                textBoxLink.Text = _contract.Link;
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
        public void ShowAsEdit(System.Guid clientLinkId) {
            CrudeClientLinkServiceClient service = new CrudeClientLinkServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientLinkId(clientLinkId);
                clientLinkTypeRefCombo.Text = _contract.ClientLinkTypeRcd != null ? _contract.ClientLinkTypeRcd : string.Empty;
                textBoxLinkName.Text = _contract.LinkName;
                textBoxLink.Text = _contract.Link;
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
            CrudeClientLinkServiceClient service = new CrudeClientLinkServiceClient();
            try {
                _contract.ClientLinkTypeRcd = clientLinkTypeRefCombo.Text;
                _contract.LinkName = textBoxLinkName.Text;
                _contract.Link = textBoxLink.Text;

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
