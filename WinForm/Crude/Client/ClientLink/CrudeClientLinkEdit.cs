/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 6:57:33 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeClientLinkEdit : Form {
        
        private CrudeClientLinkContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientLinkEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientLinkContract();
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
                _contract = new CrudeClientLinkContract();
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
        
        public void ShowAsAdd(System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId) {
            try {
                _contract = new CrudeClientLinkContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientLinkTypeRcd = clientLinkTypeRcd;
                clientLinkTypeRefCombo.Text = _contract.ClientLinkTypeRcd != null ? _contract.ClientLinkTypeRcd : String.Empty;
                _contract.LinkName = linkName;
                textBoxLinkName.Text = _contract.LinkName;
                _contract.Link = link;
                textBoxLink.Text = _contract.Link;
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
        
        public void ShowAsEdit(System.Guid clientLinkId) {
            var service = new CrudeClientLinkServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientLinkId(clientLinkId);
                clientLinkTypeRefCombo.Text = _contract.ClientLinkTypeRcd != null ? _contract.ClientLinkTypeRcd : String.Empty;
                textBoxLinkName.Text = _contract.LinkName;
                textBoxLink.Text = _contract.Link;
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
            var service = new CrudeClientLinkServiceClient();
            try {
                _contract.ClientLinkTypeRcd = clientLinkTypeRefCombo.Text;
                _contract.LinkName = textBoxLinkName.Text;
                _contract.Link = textBoxLink.Text;

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
