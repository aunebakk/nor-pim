/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:19:50 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialBankAccountNumberTypeRefEdit : Form {
        
        private CrudeFinancialBankAccountNumberTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialBankAccountNumberTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialBankAccountNumberTypeRefContract();
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
                _contract = new CrudeFinancialBankAccountNumberTypeRefContract();
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
        
        public void ShowAsAdd(string financialBankAccountNumberTypeRcd, string financialBankAccountNumberTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialBankAccountNumberTypeRefContract();
                _isNew = true;
                _contract.FinancialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRcd;
                textBoxFinancialBankAccountNumberType.Text = _contract.FinancialBankAccountNumberTypeRcd;
                _contract.FinancialBankAccountNumberTypeName = financialBankAccountNumberTypeName;
                textBoxFinancialBankAccountNumberTypeName.Text = _contract.FinancialBankAccountNumberTypeName;
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
        
        public void ShowAsEdit(string financialBankAccountNumberTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialBankAccountNumberTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialBankAccountNumberTypeRcd(financialBankAccountNumberTypeRcd);
                textBoxFinancialBankAccountNumberType.Text = _contract.FinancialBankAccountNumberTypeRcd;
                textBoxFinancialBankAccountNumberTypeName.Text = _contract.FinancialBankAccountNumberTypeName;
                _contract.UserId = userId;
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
            var service = new CrudeFinancialBankAccountNumberTypeRefServiceClient();
            try {
                _contract.FinancialBankAccountNumberTypeRcd = textBoxFinancialBankAccountNumberType.Text;
                _contract.FinancialBankAccountNumberTypeName = textBoxFinancialBankAccountNumberTypeName.Text;

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
