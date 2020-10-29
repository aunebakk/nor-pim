/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:07:24 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeDefaultIssueEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultIssueContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultIssueEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultIssueContract();
                _isNew = true;
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultIssueContract();
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
        
        // shows by foreign keys
        public void ShowAsAddByDefaultError(System.Guid defaultErrorId) {
            try {
                _contract = new CrudeDefaultIssueContract();
                _isNew = true;
                _contract.DefaultErrorId = defaultErrorId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByDefaultUser(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultIssueContract();
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
        
        // shows by foreign keys
        public void ShowAsAddByDefaultIssueType(string defaultIssueTypeRcd) {
            try {
                _contract = new CrudeDefaultIssueContract();
                _isNew = true;
                _contract.DefaultIssueTypeRcd = defaultIssueTypeRcd;
                defaultIssueTypeRefCombo.Text = _contract.DefaultIssueTypeRcd != null ? _contract.DefaultIssueTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByDefaultIssueStatus(string defaultIssueStatusRcd) {
            try {
                _contract = new CrudeDefaultIssueContract();
                _isNew = true;
                _contract.DefaultIssueStatusRcd = defaultIssueStatusRcd;
                defaultIssueStatusRefCombo.Text = _contract.DefaultIssueStatusRcd != null ? _contract.DefaultIssueStatusRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            try {
                _contract = new CrudeDefaultIssueContract();
                _isNew = true;
                _contract.DefaultIssueTypeRcd = defaultIssueTypeRcd;
                defaultIssueTypeRefCombo.Text = _contract.DefaultIssueTypeRcd != null ? _contract.DefaultIssueTypeRcd : String.Empty;
                _contract.DefaultIssueStatusRcd = defaultIssueStatusRcd;
                defaultIssueStatusRefCombo.Text = _contract.DefaultIssueStatusRcd != null ? _contract.DefaultIssueStatusRcd : String.Empty;
                _contract.DefaultErrorId = defaultErrorId;
                _contract.IssueName = issueName;
                textBoxIssueName.Text = _contract.IssueName;
                _contract.IssueDescription = issueDescription;
                textBoxIssueDescription.Text = _contract.IssueDescription;
                _contract.StepsToReproduce = stepsToReproduce;
                textBoxStepsToReproduce.Text = _contract.StepsToReproduce;
                _contract.Link = link;
                textBoxLink.Text = _contract.Link;
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                _contract.FixedNote = fixedNote;
                textBoxFixedNote.Text = _contract.FixedNote;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid defaultIssueId, System.Guid defaultUserId) {
            var service = new CrudeDefaultIssueServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultIssueId(defaultIssueId);
                defaultIssueTypeRefCombo.Text = _contract.DefaultIssueTypeRcd != null ? _contract.DefaultIssueTypeRcd : String.Empty;
                defaultIssueStatusRefCombo.Text = _contract.DefaultIssueStatusRcd != null ? _contract.DefaultIssueStatusRcd : String.Empty;
                textBoxIssueName.Text = _contract.IssueName;
                textBoxIssueDescription.Text = _contract.IssueDescription;
                textBoxStepsToReproduce.Text = _contract.StepsToReproduce;
                textBoxLink.Text = _contract.Link;
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                textBoxFixedNote.Text = _contract.FixedNote;

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
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeDefaultIssueServiceClient();
            try {
                _contract.DefaultIssueTypeRcd = defaultIssueTypeRefCombo.Text;
                _contract.DefaultIssueStatusRcd = defaultIssueStatusRefCombo.Text;
                _contract.IssueName = textBoxIssueName.Text;
                _contract.IssueDescription = textBoxIssueDescription.Text;
                _contract.StepsToReproduce = textBoxStepsToReproduce.Text;
                _contract.Link = textBoxLink.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;
                _contract.FixedNote = textBoxFixedNote.Text;

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
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
