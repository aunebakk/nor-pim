/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:55:03 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductEntityTypeRefEdit : Form {
        
        private CrudeProductEntityTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductEntityTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductEntityTypeRefContract();
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
                _contract = new CrudeProductEntityTypeRefContract();
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
        
        public void ShowAsAdd(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductEntityTypeRefContract();
                _isNew = true;
                _contract.ProductEntityTypeRcd = productEntityTypeRcd;
                textBoxProductEntityType.Text = _contract.ProductEntityTypeRcd;
                _contract.ProductEntityTypeName = productEntityTypeName;
                textBoxProductEntityTypeName.Text = _contract.ProductEntityTypeName;
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
        
        public void ShowAsEdit(string productEntityTypeRcd, System.Guid userId) {
            var service = new CrudeProductEntityTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductEntityTypeRcd(productEntityTypeRcd);
                textBoxProductEntityType.Text = _contract.ProductEntityTypeRcd;
                textBoxProductEntityTypeName.Text = _contract.ProductEntityTypeName;
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
            var service = new CrudeProductEntityTypeRefServiceClient();
            try {
                _contract.ProductEntityTypeRcd = textBoxProductEntityType.Text;
                _contract.ProductEntityTypeName = textBoxProductEntityTypeName.Text;

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
