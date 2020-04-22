/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:42 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialPaymentSearch : Form {
        
        private string _financialPaymentTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialPaymentAccountingId;
        
        private System.Guid _financialPaymentBankId;
        
        private System.Guid _financialPaymentVoucherId;
        
        private System.Guid _financialPaymentCardId;
        
        private System.Guid _financialPaymentCashId;
        
        private System.Guid _financialPaymentCouponId;
        
        public CrudeFinancialPaymentSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPayment();
            this.AcceptButton = buttonCrudeFinancialPaymentSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialPaymentTypeRcd, System.Guid userId, System.Guid financialPaymentAccountingId, System.Guid financialPaymentBankId, System.Guid financialPaymentVoucherId, System.Guid financialPaymentCardId, System.Guid financialPaymentCashId, System.Guid financialPaymentCouponId) {
            try {
                _financialPaymentTypeRcd = financialPaymentTypeRcd;
                _userId = userId;
                _financialPaymentAccountingId = financialPaymentAccountingId;
                _financialPaymentBankId = financialPaymentBankId;
                _financialPaymentVoucherId = financialPaymentVoucherId;
                _financialPaymentCardId = financialPaymentCardId;
                _financialPaymentCashId = financialPaymentCashId;
                _financialPaymentCouponId = financialPaymentCouponId;
                RefreshCrudeFinancialPayment();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPayment.CurrentRow.Cells["FinancialPaymentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPayment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPayment.CurrentRow.Cells["FinancialPaymentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPayment();
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
        
        public void RefreshCrudeFinancialPayment() {
            var financialPayment = new CrudeFinancialPaymentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPayment.FetchWithFilter(
                             Guid.Empty
                            ,financialPaymentTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPayment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPayment.DataSource = bindingSource;
                dataGridViewCrudeFinancialPayment.AutoResizeColumns();
                dataGridViewCrudeFinancialPayment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPayment.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPayment() {
            try {
                dataGridViewCrudeFinancialPayment.Columns.Clear();
                dataGridViewCrudeFinancialPayment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentTypeRcd","Financial Payment Type");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentTypeRcd"].DataPropertyName = "FinancialPaymentTypeRcd";
                dataGridViewCrudeFinancialPayment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPayment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentId","Financial Payment");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentId"].DataPropertyName = "FinancialPaymentId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentAccountingId","Financial Payment Accounting");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentAccountingId"].DataPropertyName = "FinancialPaymentAccountingId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentAccountingId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentBankId","Financial Payment Bank");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentBankId"].DataPropertyName = "FinancialPaymentBankId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentBankId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentVoucherId","Financial Payment Voucher");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentVoucherId"].DataPropertyName = "FinancialPaymentVoucherId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentVoucherId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCardId","Financial Payment Card");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCardId"].DataPropertyName = "FinancialPaymentCardId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCardId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCashId","Financial Payment Cash");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCashId"].DataPropertyName = "FinancialPaymentCashId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCashId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("FinancialPaymentCouponId","Financial Payment Coupon");
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCouponId"].DataPropertyName = "FinancialPaymentCouponId";
                dataGridViewCrudeFinancialPayment.Columns["FinancialPaymentCouponId"].Visible = false;
                dataGridViewCrudeFinancialPayment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPayment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPayment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
