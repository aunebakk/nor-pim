/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:20:04 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCardEdit : Form {
        
        private CrudeFinancialPaymentCardContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialPaymentCardEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
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
                _contract = new CrudeFinancialPaymentCardContract();
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
        
        public void ShowAsAddByFinancialCardType(string financialCardTypeRcd) {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCardTypeRcd = financialCardTypeRcd;
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;

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
                _contract = new CrudeFinancialPaymentCardContract();
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
        
        public void ShowAsAdd(System.Guid userId, string cardNumber, string nameOnCard, int expiryYear, int expiryMonth, string financialCardTypeRcd, int cardVerificationValue, int issuedMonth, int issuedYear, string addressVerificationCode, decimal amount, System.Guid financialCurrencyId) {
            try {
                _contract = new CrudeFinancialPaymentCardContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.CardNumber = cardNumber;
                textBoxCardNumber.Text = _contract.CardNumber;
                _contract.NameOnCard = nameOnCard;
                textBoxNameOnCard.Text = _contract.NameOnCard;
                _contract.ExpiryYear = expiryYear;
                maskedTextBoxExpiryYear.Text = _contract.ExpiryYear.ToString();
                _contract.ExpiryMonth = expiryMonth;
                maskedTextBoxExpiryMonth.Text = _contract.ExpiryMonth.ToString();
                _contract.FinancialCardTypeRcd = financialCardTypeRcd;
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;
                _contract.CardVerificationValue = cardVerificationValue;
                maskedTextBoxCardVerificationValue.Text = _contract.CardVerificationValue.ToString();
                _contract.IssuedMonth = issuedMonth;
                maskedTextBoxIssuedMonth.Text = _contract.IssuedMonth.ToString();
                _contract.IssuedYear = issuedYear;
                maskedTextBoxIssuedYear.Text = _contract.IssuedYear.ToString();
                _contract.AddressVerificationCode = addressVerificationCode;
                textBoxAddressVerificationCode.Text = _contract.AddressVerificationCode;
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
        
        public void ShowAsEdit(System.Guid financialPaymentCardId) {
            var service = new CrudeFinancialPaymentCardServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialPaymentCardId(financialPaymentCardId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                textBoxCardNumber.Text = _contract.CardNumber;
                textBoxNameOnCard.Text = _contract.NameOnCard;
                maskedTextBoxExpiryYear.Text = _contract.ExpiryYear.ToString();
                maskedTextBoxExpiryMonth.Text = _contract.ExpiryMonth.ToString();
                financialCardTypeRefCombo.Text = _contract.FinancialCardTypeRcd != null ? _contract.FinancialCardTypeRcd : String.Empty;
                maskedTextBoxCardVerificationValue.Text = _contract.CardVerificationValue.ToString();
                maskedTextBoxIssuedMonth.Text = _contract.IssuedMonth.ToString();
                maskedTextBoxIssuedYear.Text = _contract.IssuedYear.ToString();
                textBoxAddressVerificationCode.Text = _contract.AddressVerificationCode;
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
            var service = new CrudeFinancialPaymentCardServiceClient();
            try {
                _contract.CardNumber = textBoxCardNumber.Text;
                _contract.NameOnCard = textBoxNameOnCard.Text;
                _contract.ExpiryYear = maskedTextBoxExpiryYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryYear.Text);
                _contract.ExpiryMonth = maskedTextBoxExpiryMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxExpiryMonth.Text);
                _contract.FinancialCardTypeRcd = financialCardTypeRefCombo.Text;
                _contract.CardVerificationValue = maskedTextBoxCardVerificationValue.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCardVerificationValue.Text);
                _contract.IssuedMonth = maskedTextBoxIssuedMonth.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedMonth.Text);
                _contract.IssuedYear = maskedTextBoxIssuedYear.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxIssuedYear.Text);
                _contract.AddressVerificationCode = textBoxAddressVerificationCode.Text;
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
