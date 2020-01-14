/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:39 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentEdit : Form {
        
        private CrudeFinancialPaymentContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialPaymentEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialPaymentContract();
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
                _contract = new CrudeFinancialPaymentContract();
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
        
        public void ShowAsAddByFinancialPaymentType(string financialPaymentTypeRcd) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentTypeRcd = financialPaymentTypeRcd;
                financialPaymentTypeRefCombo.Text = _contract.FinancialPaymentTypeRcd != null ? _contract.FinancialPaymentTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentAccounting(System.Guid financialPaymentAccountingId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentAccountingId = financialPaymentAccountingId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentBank(System.Guid financialPaymentBankId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentBankId = financialPaymentBankId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentVoucher(System.Guid financialPaymentVoucherId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentVoucherId = financialPaymentVoucherId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentCard(System.Guid financialPaymentCardId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentCardId = financialPaymentCardId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentCash(System.Guid financialPaymentCashId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentCashId = financialPaymentCashId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAddByFinancialPaymentCoupon(System.Guid financialPaymentCouponId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentCouponId = financialPaymentCouponId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(string financialPaymentTypeRcd, System.Guid userId, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            try {
                _contract = new CrudeFinancialPaymentContract();
                _isNew = true;
                _contract.FinancialPaymentTypeRcd = financialPaymentTypeRcd;
                financialPaymentTypeRefCombo.Text = _contract.FinancialPaymentTypeRcd != null ? _contract.FinancialPaymentTypeRcd : String.Empty;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialPaymentAccountingId = financialPaymentAccountingId;
                _contract.FinancialPaymentBankId = financialPaymentBankId;
                _contract.FinancialPaymentVoucherId = financialPaymentVoucherId;
                _contract.FinancialPaymentCardId = financialPaymentCardId;
                _contract.FinancialPaymentCashId = financialPaymentCashId;
                _contract.FinancialPaymentCouponId = financialPaymentCouponId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialPaymentId) {
            var service = new CrudeFinancialPaymentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialPaymentId(financialPaymentId);
                financialPaymentTypeRefCombo.Text = _contract.FinancialPaymentTypeRcd != null ? _contract.FinancialPaymentTypeRcd : String.Empty;
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
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeFinancialPaymentServiceClient();
            try {
                _contract.FinancialPaymentTypeRcd = financialPaymentTypeRefCombo.Text;

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
