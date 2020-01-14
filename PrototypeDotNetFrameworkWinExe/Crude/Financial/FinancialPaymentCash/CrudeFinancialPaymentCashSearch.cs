/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:25:38 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentCashSearch : Form {
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentCashSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentCash();
            this.AcceptButton = buttonCrudeFinancialPaymentCashSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentCash();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCashEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCashEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCash.CurrentRow.Cells["FinancialPaymentCashId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCashAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCashEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentCash_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCashEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCash.CurrentRow.Cells["FinancialPaymentCashId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCashSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentCash();
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
        
        public void RefreshCrudeFinancialPaymentCash() {
            var financialPaymentCash = new CrudeFinancialPaymentCashServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentCash.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentCash.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCash.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentCash.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentCash.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentCash.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentCash() {
            try {
                dataGridViewCrudeFinancialPaymentCash.Columns.Clear();
                dataGridViewCrudeFinancialPaymentCash.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCash.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentCash.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentCash.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentCash.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentCash.Columns.Add("FinancialPaymentCashId","Financial Payment Cash");
                dataGridViewCrudeFinancialPaymentCash.Columns["FinancialPaymentCashId"].DataPropertyName = "FinancialPaymentCashId";
                dataGridViewCrudeFinancialPaymentCash.Columns["FinancialPaymentCashId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCash.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentCash.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentCash.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCash.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentCash.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentCash.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentCash.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
