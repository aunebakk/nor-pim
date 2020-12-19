/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:48 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial class CrudeDefaultResourceMeasurementEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultResourceMeasurementContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultResourceMeasurementEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultResourceMeasurementContract();
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
                _contract = new CrudeDefaultResourceMeasurementContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultResourceMeasurementContract();
                _isNew = true;
                _contract.ClientWorkingsetBytes = clientWorkingsetBytes;
                maskedTextBoxClientWorkingsetBytes.Text = _contract.ClientWorkingsetBytes.ToString();
                _contract.BusinessWorkingsetBytes = businessWorkingsetBytes;
                maskedTextBoxBusinessWorkingsetBytes.Text = _contract.BusinessWorkingsetBytes.ToString();
                _contract.DatabaseSizeBytes = databaseSizeBytes;
                maskedTextBoxDatabaseSizeBytes.Text = _contract.DatabaseSizeBytes.ToString();
                _contract.DefaultUserId = defaultUserId;
                _contract.DateTime = dateTime;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid defaultResourceMeasurementId, System.Guid defaultUserId) {
            var service = new CrudeDefaultResourceMeasurementServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId);
                maskedTextBoxClientWorkingsetBytes.Text = _contract.ClientWorkingsetBytes.ToString();
                maskedTextBoxBusinessWorkingsetBytes.Text = _contract.BusinessWorkingsetBytes.ToString();
                maskedTextBoxDatabaseSizeBytes.Text = _contract.DatabaseSizeBytes.ToString();
                _contract.DefaultUserId = defaultUserId;
                dateTimePickerDateTime.Value = _contract.DateTime != DateTime.MinValue ? _contract.DateTime : dateTimePickerDateTime.MinDate;
                dateTimePickerDateTime.Checked = _contract.DateTime != DateTime.MinValue;

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
            var service = new CrudeDefaultResourceMeasurementServiceClient();
            try {
                _contract.ClientWorkingsetBytes = maskedTextBoxClientWorkingsetBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxClientWorkingsetBytes.Text);
                _contract.BusinessWorkingsetBytes = maskedTextBoxBusinessWorkingsetBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxBusinessWorkingsetBytes.Text);
                _contract.DatabaseSizeBytes = maskedTextBoxDatabaseSizeBytes.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDatabaseSizeBytes.Text);
                _contract.DateTime = dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue;

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
