/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/25/2020 9:15:07 AM
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
    public partial class CrudeClientEventTypeRefEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeClientEventTypeRefContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientEventTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientEventTypeRefContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeClientEventTypeRefContract();
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
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId) {
            try {
                _contract = new CrudeClientEventTypeRefContract();
                _isNew = true;
                _contract.ClientEventTypeRcd = clientEventTypeRcd;
                textBoxClientEventType.Text = _contract.ClientEventTypeRcd;
                _contract.ClientEventTypeName = clientEventTypeName;
                textBoxClientEventTypeName.Text = _contract.ClientEventTypeName;
                _contract.ClientEventTypeDescription = clientEventTypeDescription;
                textBoxClientEventTypeDescription.Text = _contract.ClientEventTypeDescription;
                _contract.ActiveFlag = activeFlag;
                checkBoxActiveFlag.Checked = _contract.ActiveFlag;
                _contract.SortOrder = sortOrder;
                maskedTextBoxSortOrder.Text = _contract.SortOrder.ToString();
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
        
        // shows the form in edit modus
        public void ShowAsEdit(string clientEventTypeRcd, System.Guid userId) {
            var service = new CrudeClientEventTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientEventTypeRcd(clientEventTypeRcd);
                textBoxClientEventType.Text = _contract.ClientEventTypeRcd;
                textBoxClientEventTypeName.Text = _contract.ClientEventTypeName;
                textBoxClientEventTypeDescription.Text = _contract.ClientEventTypeDescription;
                checkBoxActiveFlag.Checked = _contract.ActiveFlag;
                maskedTextBoxSortOrder.Text = _contract.SortOrder.ToString();
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
        
        // saves the form
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeClientEventTypeRefServiceClient();
            try {
                _contract.ClientEventTypeRcd = textBoxClientEventType.Text;
                _contract.ClientEventTypeName = textBoxClientEventTypeName.Text;
                _contract.ClientEventTypeDescription = textBoxClientEventTypeDescription.Text;
                _contract.ActiveFlag = Convert.ToBoolean(checkBoxActiveFlag.Checked);
                _contract.SortOrder = maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text);

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
