/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 9:51:32 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeDefaultUserEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultUserContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultUserEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultUserContract();
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
        public void ShowAsAdd(string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            try {
                _contract = new CrudeDefaultUserContract();
                _isNew = true;
                _contract.DefaultUserCode = defaultUserCode;
                textBoxDefaultUserCode.Text = _contract.DefaultUserCode;
                _contract.DefaultUserName = defaultUserName;
                textBoxDefaultUserName.Text = _contract.DefaultUserName;
                _contract.Email = email;
                textBoxEmail.Text = _contract.Email;
                _contract.Password = password;
                textBoxPassword.Text = _contract.Password;
                _contract.DefaultStateRcd = defaultStateRcd;
                defaultStateRefCombo.Text = _contract.DefaultStateRcd != null ? _contract.DefaultStateRcd : String.Empty;
                _contract.CreatedByDefaultUserId = createdByDefaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                _contract.LastActivityDateTime = lastActivityDateTime;
                dateTimePickerLastActivityDateTime.Value = _contract.LastActivityDateTime != DateTime.MinValue ? _contract.LastActivityDateTime : dateTimePickerLastActivityDateTime.MinDate;
                dateTimePickerLastActivityDateTime.Checked = _contract.LastActivityDateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid defaultUserId) {
            var service = new CrudeDefaultUserServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultUserId(defaultUserId);
                textBoxDefaultUserCode.Text = _contract.DefaultUserCode;
                textBoxDefaultUserName.Text = _contract.DefaultUserName;
                textBoxEmail.Text = _contract.Email;
                textBoxPassword.Text = _contract.Password;
                defaultStateRefCombo.Text = _contract.DefaultStateRcd != null ? _contract.DefaultStateRcd : String.Empty;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;
                dateTimePickerLastActivityDateTime.Value = _contract.LastActivityDateTime != DateTime.MinValue ? _contract.LastActivityDateTime : dateTimePickerLastActivityDateTime.MinDate;
                dateTimePickerLastActivityDateTime.Checked = _contract.LastActivityDateTime != DateTime.MinValue;

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
            var service = new CrudeDefaultUserServiceClient();
            try {
                _contract.DefaultUserCode = textBoxDefaultUserCode.Text;
                _contract.DefaultUserName = textBoxDefaultUserName.Text;
                _contract.Email = textBoxEmail.Text;
                _contract.Password = textBoxPassword.Text;
                _contract.DefaultStateRcd = defaultStateRefCombo.Text;
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;
                _contract.LastActivityDateTime = dateTimePickerLastActivityDateTime.Checked ? Convert.ToDateTime(dateTimePickerLastActivityDateTime.Value): DateTime.MinValue;

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
