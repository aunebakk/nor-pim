/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:56 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionTypeRefEdit : Form {
        
        private CrudeFinancialOrderTransactionTypeRefContract _contract;
        
        private Boolean _isNew;
        
        public CrudeFinancialOrderTransactionTypeRefEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFinancialOrderTransactionTypeRefContract();
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
                _contract = new CrudeFinancialOrderTransactionTypeRefContract();
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
        
        public void ShowAsAdd(string financialOrderTransactionTypeRcd, string financialOrderTransactionTypeName, System.Guid userId) {
            try {
                _contract = new CrudeFinancialOrderTransactionTypeRefContract();
                _isNew = true;
                _contract.FinancialOrderTransactionTypeRcd = financialOrderTransactionTypeRcd;
                textBoxFinancialOrderTransactionType.Text = _contract.FinancialOrderTransactionTypeRcd;
                _contract.FinancialOrderTransactionTypeName = financialOrderTransactionTypeName;
                textBoxFinancialOrderTransactionTypeName.Text = _contract.FinancialOrderTransactionTypeName;
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
        
        public void ShowAsEdit(string financialOrderTransactionTypeRcd, System.Guid userId) {
            var service = new CrudeFinancialOrderTransactionTypeRefServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFinancialOrderTransactionTypeRcd(financialOrderTransactionTypeRcd);
                textBoxFinancialOrderTransactionType.Text = _contract.FinancialOrderTransactionTypeRcd;
                textBoxFinancialOrderTransactionTypeName.Text = _contract.FinancialOrderTransactionTypeName;
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
            var service = new CrudeFinancialOrderTransactionTypeRefServiceClient();
            try {
                _contract.FinancialOrderTransactionTypeRcd = textBoxFinancialOrderTransactionType.Text;
                _contract.FinancialOrderTransactionTypeName = textBoxFinancialOrderTransactionTypeName.Text;

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
