/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:44:06 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherEdit : Form {
        
        private CrudeFinancialVoucherContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialVoucherEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialVoucherContract();
                _isNew = true;
                this.Text += " - Not Savable (User,FinancialCurrency Missing)";
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
                _contract = new CrudeFinancialVoucherContract();
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
        
        public void ShowAsAddByFinancialCurrency(System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeFinancialVoucherContract();
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
        
        public void ShowAsAddByFinancialVoucherType(string financialVoucherTypeRcd) {
            try {
                _contract = new CrudeFinancialVoucherContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialVoucherTypeRcd = financialVoucherTypeRcd;
                financialVoucherTypeRefCombo.Text = _contract.FinancialVoucherTypeRcd != null ? _contract.FinancialVoucherTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid userId, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd) {
            try {
                _contract = new CrudeFinancialVoucherContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ValueAmount = valueAmount;
                maskedTextBoxValueAmount.Text = _contract.ValueAmount.ToString();
                _contract.ValidFromDateTime = validFromDateTime;
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                _contract.ValidUntilDateTime = validUntilDateTime;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                _contract.FinancialCurrencyId = financialCurrencyId;
                _contract.VoucherNumber = voucherNumber;
                maskedTextBoxVoucherNumber.Text = _contract.VoucherNumber.ToString();
                _contract.VoucherDescription = voucherDescription;
                textBoxVoucherDescription.Text = _contract.VoucherDescription;
                _contract.FinancialVoucherTypeRcd = financialVoucherTypeRcd;
                financialVoucherTypeRefCombo.Text = _contract.FinancialVoucherTypeRcd != null ? _contract.FinancialVoucherTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialVoucherId) {
            var service = new CrudeFinancialVoucherServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialVoucherId(financialVoucherId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                maskedTextBoxValueAmount.Text = _contract.ValueAmount.ToString();
                dateTimePickerValidFromDateTime.Value = _contract.ValidFromDateTime != DateTime.MinValue ? _contract.ValidFromDateTime : dateTimePickerValidFromDateTime.MinDate;
                dateTimePickerValidFromDateTime.Checked = _contract.ValidFromDateTime != DateTime.MinValue;
                dateTimePickerValidUntilDateTime.Value = _contract.ValidUntilDateTime != DateTime.MinValue ? _contract.ValidUntilDateTime : dateTimePickerValidUntilDateTime.MinDate;
                dateTimePickerValidUntilDateTime.Checked = _contract.ValidUntilDateTime != DateTime.MinValue;
                maskedTextBoxVoucherNumber.Text = _contract.VoucherNumber.ToString();
                textBoxVoucherDescription.Text = _contract.VoucherDescription;
                financialVoucherTypeRefCombo.Text = _contract.FinancialVoucherTypeRcd != null ? _contract.FinancialVoucherTypeRcd : String.Empty;

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
            var service = new CrudeFinancialVoucherServiceClient();
            try {
                _contract.ValueAmount = maskedTextBoxValueAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxValueAmount.Text);
                _contract.ValidFromDateTime = dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue;
                _contract.ValidUntilDateTime = dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue;
                _contract.VoucherNumber = maskedTextBoxVoucherNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxVoucherNumber.Text);
                _contract.VoucherDescription = textBoxVoucherDescription.Text;
                _contract.FinancialVoucherTypeRcd = financialVoucherTypeRefCombo.Text;

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
