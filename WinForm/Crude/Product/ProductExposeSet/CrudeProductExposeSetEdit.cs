/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:58:18 AM
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
    public partial class CrudeProductExposeSetEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeProductExposeSetContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposeSetEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeProductExposeSetContract();
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
                _contract = new CrudeProductExposeSetContract();
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
        
        // shows by foreign keys
        public void ShowAsAddByProductExposeSetType(string productExposeSetTypeRcd) {
            try {
                _contract = new CrudeProductExposeSetContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRcd;
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId) {
            try {
                _contract = new CrudeProductExposeSetContract();
                _isNew = true;
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRcd;
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;
                _contract.ProductExposeSetName = productExposeSetName;
                textBoxProductExposeSetName.Text = _contract.ProductExposeSetName;
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
        public void ShowAsEdit(System.Guid productExposeSetId) {
            var service = new CrudeProductExposeSetServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByProductExposeSetId(productExposeSetId);
                productExposeSetTypeRefCombo.Text = _contract.ProductExposeSetTypeRcd != null ? _contract.ProductExposeSetTypeRcd : String.Empty;
                textBoxProductExposeSetName.Text = _contract.ProductExposeSetName;
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
            var service = new CrudeProductExposeSetServiceClient();
            try {
                _contract.ProductExposeSetTypeRcd = productExposeSetTypeRefCombo.Text;
                _contract.ProductExposeSetName = textBoxProductExposeSetName.Text;

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
