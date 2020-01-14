/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:20:01 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderTransactionSearch : Form {
        
        private string _financialOrderTransactionTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialFeeId;
        
        private System.Guid _financialTaxId;
        
        private System.Guid _financialPaymentId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _financialCostcentreId;
        
        private System.Guid _financialAdjustmentId;
        
        private System.Guid _financialOrderId;
        
        public CrudeFinancialOrderTransactionSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderTransaction();
            this.AcceptButton = buttonCrudeFinancialOrderTransactionSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialOrderTransactionTypeRcd, System.Guid userId, System.Guid financialFeeId, System.Guid financialTaxId, System.Guid financialPaymentId, System.Guid financialCurrencyId, System.Guid financialCostcentreId, System.Guid financialAdjustmentId, System.Guid financialOrderId) {
            try {
                _financialOrderTransactionTypeRcd = financialOrderTransactionTypeRcd;
                _userId = userId;
                _financialFeeId = financialFeeId;
                _financialTaxId = financialTaxId;
                _financialPaymentId = financialPaymentId;
                _financialCurrencyId = financialCurrencyId;
                _financialCostcentreId = financialCostcentreId;
                _financialAdjustmentId = financialAdjustmentId;
                _financialOrderId = financialOrderId;
                RefreshCrudeFinancialOrderTransaction();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderTransaction.CurrentRow.Cells["FinancialBookingTransactionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderTransaction_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderTransactionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderTransaction.CurrentRow.Cells["FinancialBookingTransactionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderTransactionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderTransaction();
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
        
        public void RefreshCrudeFinancialOrderTransaction() {
            var financialOrderTransaction = new CrudeFinancialOrderTransactionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderTransaction.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,maskedTextBoxTransactionNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxTransactionNumber.Text)
                            ,Guid.Empty
                            ,Guid.Empty
                            ,financialOrderTransactionTypeRefCombo.Text
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialOrderTransaction.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderTransaction.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderTransaction.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderTransaction.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderTransaction.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderTransaction() {
            try {
                dataGridViewCrudeFinancialOrderTransaction.Columns.Clear();
                dataGridViewCrudeFinancialOrderTransaction.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialOrderTransactionTypeRcd","Financial Order Transaction Type");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialOrderTransactionTypeRcd"].DataPropertyName = "FinancialOrderTransactionTypeRcd";
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialOrderTransaction.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("TransactionNumber","Transaction Number");
                dataGridViewCrudeFinancialOrderTransaction.Columns["TransactionNumber"].DataPropertyName = "TransactionNumber";
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderTransaction.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialBookingTransactionId","Financial Booking Transaction");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialBookingTransactionId"].DataPropertyName = "FinancialBookingTransactionId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialBookingTransactionId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialFeeId","Financial Fee");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialFeeId"].DataPropertyName = "FinancialFeeId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialFeeId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialTaxId","Financial Tax");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialTaxId"].DataPropertyName = "FinancialTaxId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialTaxId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialPaymentId","Financial Payment");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialPaymentId"].DataPropertyName = "FinancialPaymentId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialPaymentId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialCostcentreId","Financial Costcentre");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialCostcentreId"].DataPropertyName = "FinancialCostcentreId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialCostcentreId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialAdjustmentId","Financial Adjustment");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialAdjustmentId"].DataPropertyName = "FinancialAdjustmentId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialAdjustmentId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("FinancialOrderId","Financial Order");
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialOrderId"].DataPropertyName = "FinancialOrderId";
                dataGridViewCrudeFinancialOrderTransaction.Columns["FinancialOrderId"].Visible = false;
                dataGridViewCrudeFinancialOrderTransaction.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderTransaction.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderTransaction.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
