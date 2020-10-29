/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:57:12 PM
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
    public partial class CrudeFinancialCurrencyEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        private CrudeFinancialCurrencyContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeFinancialCurrencyEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCurrencyContract();
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
                _contract = new CrudeFinancialCurrencyContract();
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
        public void ShowAsAddByFinancialCurrencyType(string financialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        public void ShowAsAddByFinancialCurrencyTypeAndFinancialCurrencyAgainstFinancialCurrencyType(string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                textBoxFinancialCurrencyAgainstFinancialCurrencyType.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        public void ShowAsAdd(string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                textBoxFinancialCurrencyAgainstFinancialCurrencyType.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ValidFromDateTime = validFromDateTime;
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                _contract.ValidUntilDateTime = validUntilDateTime;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.EqualsAmount = equalsAmount;
                maskedTextBoxEqualsAmount.Text = _contract.EqualsAmount.ToString();
                _contract.DecimalCount = decimalCount;
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
                _contract.FinancialCurrencyTypeCode = financialCurrencyTypeCode;
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;
                _contract.FinancialCurrencyTypeName = financialCurrencyTypeName;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        public void ShowAsEdit(System.Guid financialCurrencyId) {
            var service = new CrudeFinancialCurrencyServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCurrencyId(financialCurrencyId);
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;
                textBoxFinancialCurrencyAgainstFinancialCurrencyType.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                maskedTextBoxEqualsAmount.Text = _contract.EqualsAmount.ToString();
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;

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
            var service = new CrudeFinancialCurrencyServiceClient();
            try {
                _contract.FinancialCurrencyTypeRcd = textBoxFinancialCurrencyType.Text;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = textBoxFinancialCurrencyAgainstFinancialCurrencyType.Text;
                _contract.ValidFromDateTime = dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue;
                _contract.ValidUntilDateTime = dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue;
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.EqualsAmount = maskedTextBoxEqualsAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxEqualsAmount.Text);
                _contract.DecimalCount = maskedTextBoxDecimalCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDecimalCount.Text);
                _contract.FinancialCurrencyTypeCode = textBoxFinancialCurrencyTypeCode.Text;
                _contract.FinancialCurrencyTypeName = textBoxFinancialCurrencyTypeName.Text;

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
