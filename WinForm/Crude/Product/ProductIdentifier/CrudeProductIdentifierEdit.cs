/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:17 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductIdentifierEdit : Form {
        
        private CrudeProductIdentifierContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductIdentifierEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductIdentifierContract();
                _isNew = true;
                this.Text += " - Not Savable (Product,User Missing)";
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
                _contract = new CrudeProductIdentifierContract();
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
        
        public void ShowAsAddByProductAndProductIdentifierAndIdentifier(System.Guid productId, string productIdentifierRcd, string identifier) {
            try {
                _contract = new CrudeProductIdentifierContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;
                _contract.ProductIdentifierRcd = productIdentifierRcd;
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                _contract.Identifier = identifier;
                textBoxIdentifier.Text = _contract.Identifier;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByProduct(System.Guid productId) {
            try {
                _contract = new CrudeProductIdentifierContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductId = productId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId) {
            try {
                _contract = new CrudeProductIdentifierContract();
                _isNew = true;
                _contract.ProductId = productId;
                _contract.ProductIdentifierRcd = productIdentifierRcd;
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                _contract.Identifier = identifier;
                textBoxIdentifier.Text = _contract.Identifier;
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
        
        public void ShowAsEdit(System.Guid productIdentifierId) {
            var service = new CrudeProductIdentifierServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductIdentifierId(productIdentifierId);
                productIdentifierRefCombo.Text = _contract.ProductIdentifierRcd != null ? _contract.ProductIdentifierRcd : String.Empty;
                textBoxIdentifier.Text = _contract.Identifier;
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
            var service = new CrudeProductIdentifierServiceClient();
            try {
                _contract.ProductIdentifierRcd = productIdentifierRefCombo.Text;
                _contract.Identifier = textBoxIdentifier.Text;

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
