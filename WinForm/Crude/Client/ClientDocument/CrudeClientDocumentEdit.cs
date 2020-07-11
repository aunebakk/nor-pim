/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 12:41:38 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientDocumentEdit : Form {
        
        private CrudeClientDocumentContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientDocumentEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
