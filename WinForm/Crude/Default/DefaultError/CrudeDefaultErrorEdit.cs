/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:30 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeDefaultErrorEdit : Form {
        
        private CrudeDefaultErrorContract _contract;
        
        private Boolean _isNew;
        
        public CrudeDefaultErrorEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
