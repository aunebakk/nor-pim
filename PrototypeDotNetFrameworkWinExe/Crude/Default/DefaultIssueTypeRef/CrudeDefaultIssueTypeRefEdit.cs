/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:19 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultIssueTypeRefEdit : Form {
        
        private CrudeDefaultIssueTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultIssueTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultIssueTypeRefContract();
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
                _contract = new CrudeDefaultIssueTypeRefContract();
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
                _contract = new CrudeDefaultIssueTypeRefContract();
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
        
        public void ShowAsAdd(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultIssueTypeRefContract();
                _isNew = true;
                _contract.DefaultIssueTypeRcd = defaultIssueTypeRcd;
                textBoxDefaultIssueType.Text = _contract.DefaultIssueTypeRcd;
                _contract.DefaultIssueTypeName = defaultIssueTypeName;
                textBoxDefaultIssueTypeName.Text = _contract.DefaultIssueTypeName;
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
        
        public void ShowAsEdit(string defaultIssueTypeRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultIssueTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
                textBoxDefaultIssueType.Text = _contract.DefaultIssueTypeRcd;
                textBoxDefaultIssueTypeName.Text = _contract.DefaultIssueTypeName;
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
            var service = new CrudeDefaultIssueTypeRefServiceClient();
            try {
                _contract.DefaultIssueTypeRcd = textBoxDefaultIssueType.Text;
                _contract.DefaultIssueTypeName = textBoxDefaultIssueTypeName.Text;

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
