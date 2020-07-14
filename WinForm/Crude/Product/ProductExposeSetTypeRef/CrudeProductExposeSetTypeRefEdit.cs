/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:57 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductExposeSetTypeRefEdit : Form {
        
        private CrudeProductExposeSetTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductExposeSetTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductExposeSetTypeRefContract();
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
                _contract = new CrudeProductExposeSetTypeRefContract();
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
        
        public void ShowAsAdd(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductExposeSetTypeRefContract();
                _isNew = true;
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRcd;
                textBoxProductExposeSetType.Text = _contract.ProductExposeSetTypeRcd;
                _contract.ProductExposeSetTypeName = productExposeSetTypeName;
                textBoxProductExposeSetTypeName.Text = _contract.ProductExposeSetTypeName;
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
        
        public void ShowAsEdit(string productExposeSetTypeRcd, System.Guid userId) {
            var service = new CrudeProductExposeSetTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
                textBoxProductExposeSetType.Text = _contract.ProductExposeSetTypeRcd;
                textBoxProductExposeSetTypeName.Text = _contract.ProductExposeSetTypeName;
                _contract.UserId = userId;
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
            var service = new CrudeProductExposeSetTypeRefServiceClient();
            try {
                _contract.ProductExposeSetTypeRcd = textBoxProductExposeSetType.Text;
                _contract.ProductExposeSetTypeName = textBoxProductExposeSetTypeName.Text;

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
