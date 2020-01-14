/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:20:06 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentVoucherSearch : Form {
        
        private System.Guid _userId;
        
        private System.Guid _financialVoucherId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentVoucherSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentVoucher();
            this.AcceptButton = buttonCrudeFinancialPaymentVoucherSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId, System.Guid financialVoucherId, System.Guid financialCurrencyId) {
            try {
                _userId = userId;
                _financialVoucherId = financialVoucherId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentVoucher();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentVoucherEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentVoucher.CurrentRow.Cells["FinancialPaymentVoucherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentVoucherAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentVoucher_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentVoucher.CurrentRow.Cells["FinancialPaymentVoucherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentVoucherSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentVoucher();
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
        
        public void RefreshCrudeFinancialPaymentVoucher() {
            var financialPaymentVoucher = new CrudeFinancialPaymentVoucherServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentVoucher.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentVoucher.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentVoucher.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentVoucher.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentVoucher.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentVoucher.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentVoucher() {
            try {
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Clear();
                dataGridViewCrudeFinancialPaymentVoucher.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("FinancialPaymentVoucherId","Financial Payment Voucher");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialPaymentVoucherId"].DataPropertyName = "FinancialPaymentVoucherId";
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialPaymentVoucherId"].Visible = false;
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("FinancialVoucherId","Financial Voucher");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialVoucherId"].DataPropertyName = "FinancialVoucherId";
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialVoucherId"].Visible = false;
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentVoucher.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentVoucher.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentVoucher.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentVoucher.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
