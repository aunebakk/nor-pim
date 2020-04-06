/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:41 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentEdit : Form {
        
        private CrudeFinancialAdjustmentContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialAdjustmentEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialAdjustmentContract();
                _isNew = true;
                this.Text += " - Not Savable (FinancialCurrency,User Missing)";
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
                _contract = new CrudeFinancialAdjustmentContract();
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
                _contract = new CrudeFinancialAdjustmentContract();
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
        
        public void ShowAsAddByFinancialAdjustmentType(string financialAdjustmentTypeRcd) {
            try {
                _contract = new CrudeFinancialAdjustmentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialAdjustmentTypeRcd = financialAdjustmentTypeRcd;
                financialAdjustmentTypeRefCombo.Text = _contract.FinancialAdjustmentTypeRcd != null ? _contract.FinancialAdjustmentTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsAdd(decimal amount, System.Guid financialCurrencyId, System.Guid userId, string financialAdjustmentTypeRcd) {
            try {
                _contract = new CrudeFinancialAdjustmentContract();
                _isNew = true;
                _contract.Amount = amount;
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.FinancialCurrencyId = financialCurrencyId;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FinancialAdjustmentTypeRcd = financialAdjustmentTypeRcd;
                financialAdjustmentTypeRefCombo.Text = _contract.FinancialAdjustmentTypeRcd != null ? _contract.FinancialAdjustmentTypeRcd : String.Empty;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(System.Guid financialAdjustmentId) {
            var service = new CrudeFinancialAdjustmentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialAdjustmentId(financialAdjustmentId);
                maskedTextBoxAmount.Text = _contract.Amount.ToString();
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                financialAdjustmentTypeRefCombo.Text = _contract.FinancialAdjustmentTypeRcd != null ? _contract.FinancialAdjustmentTypeRcd : String.Empty;

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
            var service = new CrudeFinancialAdjustmentServiceClient();
            try {
                _contract.Amount = maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text);
                _contract.FinancialAdjustmentTypeRcd = financialAdjustmentTypeRefCombo.Text;

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
