/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:28:31 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientIdentifierEdit : Form {
        
        private CrudeClientIdentifierContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientIdentifierEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientIdentifierContract();
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
                _contract = new CrudeClientIdentifierContract();
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
        
        public void ShowAsAdd(System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId) {
            try {
                _contract = new CrudeClientIdentifierContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientIdentifierTypeRcd = clientIdentifierTypeRcd;
                clientIdentifierTypeRefCombo.Text = _contract.ClientIdentifierTypeRcd != null ? _contract.ClientIdentifierTypeRcd : String.Empty;
                _contract.ClientIdentifierCode = clientIdentifierCode;
                textBoxClientIdentifierCode.Text = _contract.ClientIdentifierCode;
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
        
        public void ShowAsEdit(System.Guid clientIdentifierId) {
            var service = new CrudeClientIdentifierServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientIdentifierId(clientIdentifierId);
                clientIdentifierTypeRefCombo.Text = _contract.ClientIdentifierTypeRcd != null ? _contract.ClientIdentifierTypeRcd : String.Empty;
                textBoxClientIdentifierCode.Text = _contract.ClientIdentifierCode;
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
            var service = new CrudeClientIdentifierServiceClient();
            try {
                _contract.ClientIdentifierTypeRcd = clientIdentifierTypeRefCombo.Text;
                _contract.ClientIdentifierCode = textBoxClientIdentifierCode.Text;

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
