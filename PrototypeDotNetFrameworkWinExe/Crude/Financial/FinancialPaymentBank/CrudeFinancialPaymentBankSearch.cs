/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:20:16 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentBankSearch : Form {
        
        private string _financialBankAccountNumberTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentBankSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentBank();
            this.AcceptButton = buttonCrudeFinancialPaymentBankSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialBankAccountNumberTypeRcd, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialBankAccountNumberTypeRcd = financialBankAccountNumberTypeRcd;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentBank();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentBankEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentBankEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentBank.CurrentRow.Cells["FinancialPaymentBankId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentBankAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentBankEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentBank_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentBankEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentBank.CurrentRow.Cells["FinancialPaymentBankId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentBankSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentBank();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        public void RefreshCrudeFinancialPaymentBank() {
            var financialPaymentBank = new CrudeFinancialPaymentBankServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentBank.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,textBoxBankName.Text
                            ,textBoxBankAccount.Text
                            ,textBoxBankNumber.Text
                            ,financialBankAccountNumberTypeRefCombo.Text
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentBank.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentBank.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentBank.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentBank.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentBank.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentBank() {
            try {
                dataGridViewCrudeFinancialPaymentBank.Columns.Clear();
                dataGridViewCrudeFinancialPaymentBank.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("BankName","Bank Name");
                dataGridViewCrudeFinancialPaymentBank.Columns["BankName"].DataPropertyName = "BankName";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("BankAccount","Bank Account");
                dataGridViewCrudeFinancialPaymentBank.Columns["BankAccount"].DataPropertyName = "BankAccount";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("BankNumber","Bank Number");
                dataGridViewCrudeFinancialPaymentBank.Columns["BankNumber"].DataPropertyName = "BankNumber";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("FinancialBankAccountNumberTypeRcd","Financial Bank Account Number Type");
                dataGridViewCrudeFinancialPaymentBank.Columns["FinancialBankAccountNumberTypeRcd"].DataPropertyName = "FinancialBankAccountNumberTypeRcd";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentBank.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentBank.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("FinancialPaymentBankId","Financial Payment Bank");
                dataGridViewCrudeFinancialPaymentBank.Columns["FinancialPaymentBankId"].DataPropertyName = "FinancialPaymentBankId";
                dataGridViewCrudeFinancialPaymentBank.Columns["FinancialPaymentBankId"].Visible = false;
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentBank.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentBank.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentBank.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentBank.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentBank.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
