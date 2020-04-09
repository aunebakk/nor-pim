/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:21:06 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeClientContactMethodEdit : Form {
        
        private CrudeClientContactMethodContract _contract;
        
        private Boolean _isNew;
        
        public CrudeClientContactMethodEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientContactMethodContract();
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
                _contract = new CrudeClientContactMethodContract();
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
        
        public void ShowAsAdd(System.Guid clientId, string clientContactMethodRcd, string contactMethodWay, string comment, System.Guid userId) {
            try {
                _contract = new CrudeClientContactMethodContract();
                _isNew = true;
                _contract.ClientId = clientId;
                _contract.ClientContactMethodRcd = clientContactMethodRcd;
                clientContactMethodRefCombo.Text = _contract.ClientContactMethodRcd != null ? _contract.ClientContactMethodRcd : String.Empty;
                _contract.ContactMethodWay = contactMethodWay;
                textBoxContactMethodWay.Text = _contract.ContactMethodWay;
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
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
        
        public void ShowAsEdit(System.Guid clientContactMethodId) {
            var service = new CrudeClientContactMethodServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientContactMethodId(clientContactMethodId);
                clientContactMethodRefCombo.Text = _contract.ClientContactMethodRcd != null ? _contract.ClientContactMethodRcd : String.Empty;
                textBoxContactMethodWay.Text = _contract.ContactMethodWay;
                textBoxComment.Text = _contract.Comment;
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
            var service = new CrudeClientContactMethodServiceClient();
            try {
                _contract.ClientContactMethodRcd = clientContactMethodRefCombo.Text;
                _contract.ContactMethodWay = textBoxContactMethodWay.Text;
                _contract.Comment = textBoxComment.Text;

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
