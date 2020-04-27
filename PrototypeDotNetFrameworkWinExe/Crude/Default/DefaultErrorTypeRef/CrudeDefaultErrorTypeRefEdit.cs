/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:37 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultErrorTypeRefEdit : Form {
        
        private CrudeDefaultErrorTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultErrorTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultErrorTypeRefContract();
                _isNew = true;
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultErrorTypeRefContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;
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
        
        public void ShowAsAdd(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultErrorTypeRefContract();
                _isNew = true;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRcd;
                textBoxDefaultErrorType.Text = _contract.DefaultErrorTypeRcd;
                _contract.DefaultErrorTypeName = defaultErrorTypeName;
                textBoxDefaultErrorTypeName.Text = _contract.DefaultErrorTypeName;
                _contract.DefaultUserId = defaultUserId;
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
        
        public void ShowAsEdit(string defaultErrorTypeRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultErrorTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
                textBoxDefaultErrorType.Text = _contract.DefaultErrorTypeRcd;
                textBoxDefaultErrorTypeName.Text = _contract.DefaultErrorTypeName;
                _contract.DefaultUserId = defaultUserId;
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
            var service = new CrudeDefaultErrorTypeRefServiceClient();
            try {
                _contract.DefaultErrorTypeRcd = textBoxDefaultErrorType.Text;
                _contract.DefaultErrorTypeName = textBoxDefaultErrorTypeName.Text;

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
