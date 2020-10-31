/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:17:33 AM
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
    public partial class CrudeFinancialOrderEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeFinancialOrderContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeFinancialOrderEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                this.Text += " - Not Savable (User,FinancialCurrency,Client Missing)";
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
                _contract = new CrudeFinancialOrderContract();
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
        public void ShowAsAddByClient(System.Guid clientId) {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ClientId = clientId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByLocationAddress(System.Guid locationAddressId) {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.LocationAddressId = locationAddressId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByFinancialCurrency(System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByFinancialOrderSource(string financialOrderSourceRcd) {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderSourceRcd = financialOrderSourceRcd;
                textBoxFinancialOrderSource.Text = _contract.FinancialOrderSourceRcd;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(System.Guid userId, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            try {
                _contract = new CrudeFinancialOrderContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
                _contract.LocationAddressId = locationAddressId;
                _contract.FinancialCurrencyId = financialCurrencyId;
                _contract.FinancialOrderSourceRcd = financialOrderSourceRcd;
                textBoxFinancialOrderSource.Text = _contract.FinancialOrderSourceRcd;
                _contract.ClientId = clientId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid financialOrderId) {
            var service = new CrudeFinancialOrderServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderId(financialOrderId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                textBoxComment.Text = _contract.Comment;
                textBoxFinancialOrderSource.Text = _contract.FinancialOrderSourceRcd;

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
            var service = new CrudeFinancialOrderServiceClient();
            try {
                _contract.Comment = textBoxComment.Text;
                _contract.FinancialOrderSourceRcd = textBoxFinancialOrderSource.Text;

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
