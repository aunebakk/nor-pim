/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:30 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultChangeLogEdit : Form {
        
        private CrudeDefaultChangeLogContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultChangeLogEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultChangeLogContract();
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
                _contract = new CrudeDefaultChangeLogContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

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
                _contract = new CrudeDefaultChangeLogContract();
                _isNew = true;
                _contract.DefaultUserId = defaultUserId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByDefaultChangeLogType(string defaultChangeLogTypeRcd) {
            try {
                _contract = new CrudeDefaultChangeLogContract();
                _isNew = true;
                _contract.DefaultChangeLogTypeRcd = defaultChangeLogTypeRcd;
                defaultChangeLogTypeRefCombo.Text = _contract.DefaultChangeLogTypeRcd != null ? _contract.DefaultChangeLogTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByDefaultIssue(System.Guid defaultIssueId) {
            try {
                _contract = new CrudeDefaultChangeLogContract();
                _isNew = true;
                _contract.DefaultIssueId = defaultIssueId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            try {
                _contract = new CrudeDefaultChangeLogContract();
                _isNew = true;
                _contract.DefaultChangeName = defaultChangeName;
                textBoxDefaultChangeName.Text = _contract.DefaultChangeName;
                _contract.DefaultChangeDescription = defaultChangeDescription;
                textBoxDefaultChangeDescription.Text = _contract.DefaultChangeDescription;
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                _contract.DefaultChangeLogTypeRcd = defaultChangeLogTypeRcd;
                defaultChangeLogTypeRefCombo.Text = _contract.DefaultChangeLogTypeRcd != null ? _contract.DefaultChangeLogTypeRcd : String.Empty;
                _contract.DefaultIssueId = defaultIssueId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid defaultChangeLogId, System.Guid defaultUserId) {
            var service = new CrudeDefaultChangeLogServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultChangeLogId(defaultChangeLogId);
                textBoxDefaultChangeName.Text = _contract.DefaultChangeName;
                textBoxDefaultChangeDescription.Text = _contract.DefaultChangeDescription;
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                defaultChangeLogTypeRefCombo.Text = _contract.DefaultChangeLogTypeRcd != null ? _contract.DefaultChangeLogTypeRcd : String.Empty;

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
            var service = new CrudeDefaultChangeLogServiceClient();
            try {
                _contract.DefaultChangeName = textBoxDefaultChangeName.Text;
                _contract.DefaultChangeDescription = textBoxDefaultChangeDescription.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;
                _contract.DefaultChangeLogTypeRcd = defaultChangeLogTypeRefCombo.Text;

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
