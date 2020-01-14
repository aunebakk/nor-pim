/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:58:52 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentAccountingSearch : Form {
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentAccountingSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentAccounting();
            this.AcceptButton = buttonCrudeFinancialPaymentAccountingSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentAccounting();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentAccountingEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentAccountingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentAccounting.CurrentRow.Cells["FinancialPaymentAccountingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentAccountingAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentAccountingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentAccounting_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentAccountingEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentAccounting.CurrentRow.Cells["FinancialPaymentAccountingId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentAccountingSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentAccounting();
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
        
        public void RefreshCrudeFinancialPaymentAccounting() {
            var financialPaymentAccounting = new CrudeFinancialPaymentAccountingServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentAccounting.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentAccounting.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentAccounting.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentAccounting.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentAccounting.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentAccounting.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentAccounting() {
            try {
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Clear();
                dataGridViewCrudeFinancialPaymentAccounting.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentAccounting.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentAccounting.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Add("FinancialPaymentAccountingId","Financial Payment Accounting");
                dataGridViewCrudeFinancialPaymentAccounting.Columns["FinancialPaymentAccountingId"].DataPropertyName = "FinancialPaymentAccountingId";
                dataGridViewCrudeFinancialPaymentAccounting.Columns["FinancialPaymentAccountingId"].Visible = false;
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentAccounting.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentAccounting.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentAccounting.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentAccounting.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentAccounting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentAccounting.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
