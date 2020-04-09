/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:21:48 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCurrencyTypeRefEdit : Form {
        
        private CrudeFinancialCurrencyTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialCurrencyTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialCurrencyTypeRefContract();
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
                _contract = new CrudeFinancialCurrencyTypeRefContract();
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
        
        public void ShowAsAdd(string financialCurrencyTypeRcd, string financialCurrencyTypeName, System.Guid userId, int decimalCount, string financialCurrencyTypeCode) {
            try {
                _contract = new CrudeFinancialCurrencyTypeRefContract();
                _isNew = true;
                _contract.FinancialCurrencyTypeRcd = financialCurrencyTypeRcd;
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;
                _contract.FinancialCurrencyTypeName = financialCurrencyTypeName;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.DecimalCount = decimalCount;
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
                _contract.FinancialCurrencyTypeCode = financialCurrencyTypeCode;
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        public void ShowAsEdit(string financialCurrencyTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialCurrencyTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
                textBoxFinancialCurrencyType.Text = _contract.FinancialCurrencyTypeRcd;
                textBoxFinancialCurrencyTypeName.Text = _contract.FinancialCurrencyTypeName;
                _contract.UserId = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                maskedTextBoxDecimalCount.Text = _contract.DecimalCount.ToString();
                textBoxFinancialCurrencyTypeCode.Text = _contract.FinancialCurrencyTypeCode;

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
            var service = new CrudeFinancialCurrencyTypeRefServiceClient();
            try {
                _contract.FinancialCurrencyTypeRcd = textBoxFinancialCurrencyType.Text;
                _contract.FinancialCurrencyTypeName = textBoxFinancialCurrencyTypeName.Text;
                _contract.DecimalCount = maskedTextBoxDecimalCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxDecimalCount.Text);
                _contract.FinancialCurrencyTypeCode = textBoxFinancialCurrencyTypeCode.Text;

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
