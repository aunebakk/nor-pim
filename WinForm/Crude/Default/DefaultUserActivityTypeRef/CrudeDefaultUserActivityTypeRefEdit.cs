/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:55 PM
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
    public partial class CrudeDefaultUserActivityTypeRefEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultUserActivityTypeRefContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultUserActivityTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultUserActivityTypeRefContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultUserActivityTypeRefContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultUserActivityTypeRefContract();
                _isNew = true;
                _contract.DefaultUserActivityTypeRcd = defaultUserActivityTypeRcd;
                textBoxDefaultUserActivityType.Text = _contract.DefaultUserActivityTypeRcd;
                _contract.DefaultUserActivityTypeName = defaultUserActivityTypeName;
                textBoxDefaultUserActivityTypeName.Text = _contract.DefaultUserActivityTypeName;
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
        
        // shows the form in edit modus
        public void ShowAsEdit(string defaultUserActivityTypeRcd, System.Guid defaultUserId) {
            var service = new CrudeDefaultUserActivityTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
                textBoxDefaultUserActivityType.Text = _contract.DefaultUserActivityTypeRcd;
                textBoxDefaultUserActivityTypeName.Text = _contract.DefaultUserActivityTypeName;
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
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeDefaultUserActivityTypeRefServiceClient();
            try {
                _contract.DefaultUserActivityTypeRcd = textBoxDefaultUserActivityType.Text;
                _contract.DefaultUserActivityTypeName = textBoxDefaultUserActivityTypeName.Text;

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
