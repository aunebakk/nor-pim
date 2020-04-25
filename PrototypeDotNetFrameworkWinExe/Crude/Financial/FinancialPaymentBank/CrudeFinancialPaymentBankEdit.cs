/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:24 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentBankEdit : Form {
        
        private CrudeFinancialPaymentBankContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialPaymentBankEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialPaymentBankContract();
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
                _contract = new CrudeFinancialPaymentBankContract();
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
        
        public void ShowAsAddByBankAccountAndFinancialBankAccountNumberType(string bankAccount, string financialBankAccountNumberTypeRcd) {
            try {
                _contract = new CrudeFinancialPaymentBankContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.BankAccount = bankAccount;
                textBoxBankAccount.Text = _contract.BankAccount;
                _contract.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRcd;
                financialBankAccountNumberTypeRefCombo.Text = _contract.FinancialBankAccountNumberTypeRcd != null ? _contract.FinancialBankAccountNumberTypeRcd : String.Empty;

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
                _contract = new CrudeFinancialPaymentBankContract();
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
        
        public void ShowAsAdd(System.Guid userId, string bankName, string bankAccount, string bankNumber, string financialBankAccountNumberTypeRcd, decimal amount, System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeFinancialPaymentBankContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.BankName = bankName;
                textBoxBankName.Text = _contract.BankName;
                _contract.BankAccount = bankAccount;
                textBoxBankAccount.Text = _contract.BankAccount;
                _contract.BankNumber = bankNumber;
                textBoxBankNumber.Text = _contract.BankNumber;
                _contract.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRcd;
                financialBankAccountNumberTypeRefCombo.Text = _contract.FinancialBankAccountNumberTypeRcd != null ? _contract.FinancialBankAccountNumberTypeRcd : String.Empty;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialPaymentBankId) {
            var service = new CrudeFinancialPaymentBankServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialPaymentBankId(financialPaymentBankId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                textBoxBankName.Text = _contract.BankName;
                textBoxBankAccount.Text = _contract.BankAccount;
                textBoxBankNumber.Text = _contract.BankNumber;
                financialBankAccountNumberTypeRefCombo.Text = _contract.FinancialBankAccountNumberTypeRcd != null ? _contract.FinancialBankAccountNumberTypeRcd : String.Empty;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();

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
            var service = new CrudeFinancialPaymentBankServiceClient();
            try {
                _contract.BankName = textBoxBankName.Text;
                _contract.BankAccount = textBoxBankAccount.Text;
                _contract.BankNumber = textBoxBankNumber.Text;
                _contract.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRefCombo.Text;
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);

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
