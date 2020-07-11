/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:26:07 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSetEdit : Form {
        
        private CrudeProductExposeSetContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductExposeSetEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductExposeSetContract();
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
        
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeProductExposeSetContract();
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
        
        public void ShowAsAddByProductExposeSetType(string productExposeSetTypeRcd) {
            try {
                _contract = new CrudeProductExposeSetContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRcd;
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId) {
            try {
                _contract = new CrudeProductExposeSetContract();
                _isNew = true;
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRcd;
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;
                _contract.ProductExposeSetName = productExposeSetName;
                textBoxProductExposeSetName.Text = _contract.ProductExposeSetName;
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
        
        public void ShowAsEdit(System.Guid productExposeSetId) {
            var service = new CrudeProductExposeSetServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductExposeSetId(productExposeSetId);
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;
                textBoxProductExposeSetName.Text = _contract.ProductExposeSetName;
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
            var service = new CrudeProductExposeSetServiceClient();
            try {
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRefCombo.Text;
                _contract.ProductExposeSetName = textBoxProductExposeSetName.Text;

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
