/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:54 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCurrencyEdit : Form {
        
        private CrudeFinancialCurrencyContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialCurrencyEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
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
        
        public void ShowAsAddByFinancialCurrencyType(string financialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialCurrencyTypeAndFinancialCurrencyAgainstFinancialCurrencyType(string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            try {
                _contract = new CrudeFinancialCurrencyContract();
                _isNew = true;
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRcd;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;
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
        
        public void ShowAsEdit(System.Guid financialCurrencyId) {
            var service = new CrudeFinancialCurrencyServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCurrencyId(financialCurrencyId);
                financialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyTypeRcd : String.Empty;
                financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text = _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd != null ? _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd : String.Empty;
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
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeFinancialCurrencyServiceClient();
            try {
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRefCombo.Text;
                _contract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = financialCurrencyAgainstFinancialCurrencyTypeRefCombo.Text;
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
