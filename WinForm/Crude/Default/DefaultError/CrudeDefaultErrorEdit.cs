/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:02:18 AM
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
    public partial class CrudeDefaultErrorEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeDefaultErrorContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultErrorEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeDefaultErrorContract();
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
                _contract = new CrudeDefaultErrorContract();
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
        public void ShowAsAddByDefaultUser(System.Guid defaultUserId) {
            try {
                _contract = new CrudeDefaultErrorContract();
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
        public void ShowAsAddByDefaultErrorLayer(string defaultErrorLayerRcd) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRcd;
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByDefaultErrorType(string defaultErrorTypeRcd) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRcd;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            try {
                _contract = new CrudeDefaultErrorContract();
                _isNew = true;
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRcd;
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRcd;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;
                _contract.LayerAddress = layerAddress;
                textBoxLayerAddress.Text = _contract.LayerAddress;
                _contract.ErrorMessage = errorMessage;
                textBoxErrorMessage.Text = _contract.ErrorMessage;
                _contract.StackTrace = stackTrace;
                textBoxStackTrace.Text = _contract.StackTrace;
                _contract.MethodName = methodName;
                textBoxMethodName.Text = _contract.MethodName;
                _contract.DomainName = domainName;
                textBoxDomainName.Text = _contract.DomainName;
                _contract.ClassName = className;
                textBoxClassName.Text = _contract.ClassName;
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
        public void ShowAsEdit(System.Guid defaultErrorId, System.Guid defaultUserId) {
            var service = new CrudeDefaultErrorServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByDefaultErrorId(defaultErrorId);
                defaultErrorLayerRefCombo.Text = _contract.DefaultErrorLayerRcd != null ? _contract.DefaultErrorLayerRcd : String.Empty;
                defaultErrorTypeRefCombo.Text = _contract.DefaultErrorTypeRcd != null ? _contract.DefaultErrorTypeRcd : String.Empty;
                textBoxLayerAddress.Text = _contract.LayerAddress;
                textBoxErrorMessage.Text = _contract.ErrorMessage;
                textBoxStackTrace.Text = _contract.StackTrace;
                textBoxMethodName.Text = _contract.MethodName;
                textBoxDomainName.Text = _contract.DomainName;
                textBoxClassName.Text = _contract.ClassName;
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
            var service = new CrudeDefaultErrorServiceClient();
            try {
                _contract.DefaultErrorLayerRcd = defaultErrorLayerRefCombo.Text;
                _contract.DefaultErrorTypeRcd = defaultErrorTypeRefCombo.Text;
                _contract.LayerAddress = textBoxLayerAddress.Text;
                _contract.ErrorMessage = textBoxErrorMessage.Text;
                _contract.StackTrace = textBoxStackTrace.Text;
                _contract.MethodName = textBoxMethodName.Text;
                _contract.DomainName = textBoxDomainName.Text;
                _contract.ClassName = textBoxClassName.Text;
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
