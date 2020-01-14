/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:44:06 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherSearch : Form {
        
        private string _financialVoucherTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialVoucherSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialVoucher();
            this.AcceptButton = buttonCrudeFinancialVoucherSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialVoucherTypeRcd, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialVoucherTypeRcd = financialVoucherTypeRcd;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialVoucher();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialVoucher.CurrentRow.Cells["FinancialVoucherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialVoucher_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialVoucher.CurrentRow.Cells["FinancialVoucherId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialVoucher();
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
        
        public void RefreshCrudeFinancialVoucher() {
            var financialVoucher = new CrudeFinancialVoucherServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialVoucher.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxValueAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxValueAmount.Text)
                            ,dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,maskedTextBoxVoucherNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxVoucherNumber.Text)
                            ,textBoxVoucherDescription.Text
                            ,financialVoucherTypeRefCombo.Text
                            );
                dataGridViewCrudeFinancialVoucher.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialVoucher.DataSource = bindingSource;
                dataGridViewCrudeFinancialVoucher.AutoResizeColumns();
                dataGridViewCrudeFinancialVoucher.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialVoucher.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialVoucher() {
            try {
                dataGridViewCrudeFinancialVoucher.Columns.Clear();
                dataGridViewCrudeFinancialVoucher.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialVoucher.Columns.Add("VoucherDescription","Voucher Description");
                dataGridViewCrudeFinancialVoucher.Columns["VoucherDescription"].DataPropertyName = "VoucherDescription";
                dataGridViewCrudeFinancialVoucher.Columns.Add("FinancialVoucherTypeRcd","Financial Voucher Type");
                dataGridViewCrudeFinancialVoucher.Columns["FinancialVoucherTypeRcd"].DataPropertyName = "FinancialVoucherTypeRcd";
                dataGridViewCrudeFinancialVoucher.Columns.Add("ValueAmount","Value Amount");
                dataGridViewCrudeFinancialVoucher.Columns["ValueAmount"].DataPropertyName = "ValueAmount";
                dataGridViewCrudeFinancialVoucher.Columns.Add("VoucherNumber","Voucher Number");
                dataGridViewCrudeFinancialVoucher.Columns["VoucherNumber"].DataPropertyName = "VoucherNumber";
                dataGridViewCrudeFinancialVoucher.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialVoucher.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialVoucher.Columns.Add("ValidFromDateTime","Valid From Date Time");
                dataGridViewCrudeFinancialVoucher.Columns["ValidFromDateTime"].DataPropertyName = "ValidFromDateTime";
                dataGridViewCrudeFinancialVoucher.Columns.Add("ValidUntilDateTime","Valid Until Date Time");
                dataGridViewCrudeFinancialVoucher.Columns["ValidUntilDateTime"].DataPropertyName = "ValidUntilDateTime";
                dataGridViewCrudeFinancialVoucher.Columns.Add("FinancialVoucherId","Financial Voucher");
                dataGridViewCrudeFinancialVoucher.Columns["FinancialVoucherId"].DataPropertyName = "FinancialVoucherId";
                dataGridViewCrudeFinancialVoucher.Columns["FinancialVoucherId"].Visible = false;
                dataGridViewCrudeFinancialVoucher.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialVoucher.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialVoucher.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialVoucher.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialVoucher.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialVoucher.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
