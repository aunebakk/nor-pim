/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:59 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionEdit : Form {
        
        private CrudeFinancialOrderTransactionContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderTransactionEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                this.Text += " - Not Savable (User,FinancialCurrency,FinancialCostcentre,FinancialOrder Missing)";
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
                _contract = new CrudeFinancialOrderTransactionContract();
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
        
        public void ShowAsAddByFinancialOrderTransactionType(string financialOrderTransactionTypeRcd) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderTransactionTypeRcd = financialOrderTransactionTypeRcd;
                financialOrderTransactionTypeRefCombo.Text = _contract.FinancialOrderTransactionTypeRcd != null ? _contract.FinancialOrderTransactionTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialOrder(System.Guid financialOrderId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialOrderId = financialOrderId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialFee(System.Guid financialFeeId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialFeeId = financialFeeId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialTax(System.Guid financialTaxId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialTaxId = financialTaxId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPayment(System.Guid financialPaymentId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentId = financialPaymentId;

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
                _contract = new CrudeFinancialOrderTransactionContract();
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
        
        public void ShowAsAddByFinancialCostcentre(System.Guid financialCostcentreId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialCostcentreId = financialCostcentreId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialAdjustment(System.Guid financialAdjustmentId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialAdjustmentId = financialAdjustmentId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(System.Guid userId, decimal amount, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, int transactionNumber, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, string financialOrderTransactionTypeRcd, System.Guid financialOrderId) {
            try {
                _contract = new CrudeFinancialOrderTransactionContract();
                _isNew = true;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialFeeId = financialFeeId;
                _contract.FinancialTaxId = financialTaxId;
                _contract.FinancialPaymentId = financialPaymentId;
                _contract.FinancialCurrencyId = financialCurrencyId;
                _contract.TransactionNumber = transactionNumber;
                maskedTextBoxTransactionNumber.Text = _contract.TransactionNumber.ToString();
                _contract.FinancialCostcentreId = financialCostcentreId;
                _contract.FinancialAdjustmentId = financialAdjustmentId;
                _contract.FinancialOrderTransactionTypeRcd = financialOrderTransactionTypeRcd;
                financialOrderTransactionTypeRefCombo.Text = _contract.FinancialOrderTransactionTypeRcd != null ? _contract.FinancialOrderTransactionTypeRcd : String.Empty;
                _contract.FinancialOrderId = financialOrderId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialBookingTransactionId) {
            var service = new CrudeFinancialOrderTransactionServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialBookingTransactionId(financialBookingTransactionId);
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                maskedTextBoxTransactionNumber.Text = _contract.TransactionNumber.ToString();
                financialOrderTransactionTypeRefCombo.Text = _contract.FinancialOrderTransactionTypeRcd != null ? _contract.FinancialOrderTransactionTypeRcd : String.Empty;

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
            var service = new CrudeFinancialOrderTransactionServiceClient();
            try {
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.TransactionNumber = maskedTextBoxTransactionNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxTransactionNumber.Text);
                _contract.FinancialOrderTransactionTypeRcd = financialOrderTransactionTypeRefCombo.Text;

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
