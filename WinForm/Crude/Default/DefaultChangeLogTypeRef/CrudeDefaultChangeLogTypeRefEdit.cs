/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:21 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultChangeLogTypeRefEdit : Form {
        
        private CrudeDefaultChangeLogTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultChangeLogTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultChangeLogTypeRefContract();
                _isNew = true;
                this.Text += " - Not Savable (DefaultUser Missing)";
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
                _contract = new CrudeDefaultChangeLogTypeRefContract();
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
        
        public void ShowAsAddByDefaultUser(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultChangeLogTypeRefContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultChangeLogTypeRefContract();
                _isNew = true;
                _contract.DefaultChangeLogTypeRcd = defaultChangeLogTypeRcd;
                textBoxDefaultChangeLogType.Text = _contract.DefaultChangeLogTypeRcd;
                _contract.DefaultChangeLogTypeName = defaultChangeLogTypeName;
                textBoxDefaultChangeLogTypeName.Text = _contract.DefaultChangeLogTypeName;
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
        
        public void ShowAsEdit(string defaultChangeLogTypeRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultChangeLogTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
                textBoxDefaultChangeLogType.Text = _contract.DefaultChangeLogTypeRcd;
                textBoxDefaultChangeLogTypeName.Text = _contract.DefaultChangeLogTypeName;
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
            var service = new CrudeDefaultChangeLogTypeRefServiceClient();
            try {
                _contract.DefaultChangeLogTypeRcd = textBoxDefaultChangeLogType.Text;
                _contract.DefaultChangeLogTypeName = textBoxDefaultChangeLogTypeName.Text;

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
