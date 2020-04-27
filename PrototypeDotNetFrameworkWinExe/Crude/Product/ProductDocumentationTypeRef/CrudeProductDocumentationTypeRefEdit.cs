/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:41 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeProductDocumentationTypeRefEdit : Form {
        
        private CrudeProductDocumentationTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeProductDocumentationTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductDocumentationTypeRefContract();
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
                _contract = new CrudeProductDocumentationTypeRefContract();
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
        
        public void ShowAsAdd(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId) {
            try {
                _contract = new CrudeProductDocumentationTypeRefContract();
                _isNew = true;
                _contract.ProductDocumentationTypeRcd = productDocumentationTypeRcd;
                textBoxProductDocumentationType.Text = _contract.ProductDocumentationTypeRcd;
                _contract.ProductDocumentationTypeName = productDocumentationTypeName;
                textBoxProductDocumentationTypeName.Text = _contract.ProductDocumentationTypeName;
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
        
        public void ShowAsEdit(string productDocumentationTypeRcd, System.Guid userId) {
            var service = new CrudeProductDocumentationTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
                textBoxProductDocumentationType.Text = _contract.ProductDocumentationTypeRcd;
                textBoxProductDocumentationTypeName.Text = _contract.ProductDocumentationTypeName;
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
            var service = new CrudeProductDocumentationTypeRefServiceClient();
            try {
                _contract.ProductDocumentationTypeRcd = textBoxProductDocumentationType.Text;
                _contract.ProductDocumentationTypeName = textBoxProductDocumentationTypeName.Text;

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
