/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:15 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeDefaultIssueStatusRefEdit : Form {
        
        private CrudeDefaultIssueStatusRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultIssueStatusRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultIssueStatusRefContract();
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
                _contract = new CrudeDefaultIssueStatusRefContract();
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
                _contract = new CrudeDefaultIssueStatusRefContract();
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
        
        public void ShowAsAdd(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultIssueStatusRefContract();
                _isNew = true;
                _contract.DefaultIssueStatusRcd = defaultIssueStatusRcd;
                textBoxDefaultIssueStatus.Text = _contract.DefaultIssueStatusRcd;
                _contract.DefaultIssueStatusName = defaultIssueStatusName;
                textBoxDefaultIssueStatusName.Text = _contract.DefaultIssueStatusName;
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
        
        public void ShowAsEdit(string defaultIssueStatusRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultIssueStatusRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultIssueStatusRcd(defaultIssueStatusRcd);
                textBoxDefaultIssueStatus.Text = _contract.DefaultIssueStatusRcd;
                textBoxDefaultIssueStatusName.Text = _contract.DefaultIssueStatusName;
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
            var service = new CrudeDefaultIssueStatusRefServiceClient();
            try {
                _contract.DefaultIssueStatusRcd = textBoxDefaultIssueStatus.Text;
                _contract.DefaultIssueStatusName = textBoxDefaultIssueStatusName.Text;

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
