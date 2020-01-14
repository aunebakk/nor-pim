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
    
    
    public partial class CrudeFinancialPaymentCouponSearch : Form {
        
        private System.Guid _financialCouponId;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialPaymentCouponSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialPaymentCoupon();
            this.AcceptButton = buttonCrudeFinancialPaymentCouponSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid financialCouponId, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialCouponId = financialCouponId;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialPaymentCoupon();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCouponEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCoupon.CurrentRow.Cells["FinancialPaymentCouponId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCouponAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialPaymentCoupon_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialPaymentCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialPaymentCoupon.CurrentRow.Cells["FinancialPaymentCouponId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialPaymentCouponSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialPaymentCoupon();
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
        
        public void RefreshCrudeFinancialPaymentCoupon() {
            var financialPaymentCoupon = new CrudeFinancialPaymentCouponServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialPaymentCoupon.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            );
                dataGridViewCrudeFinancialPaymentCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCoupon.DataSource = bindingSource;
                dataGridViewCrudeFinancialPaymentCoupon.AutoResizeColumns();
                dataGridViewCrudeFinancialPaymentCoupon.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialPaymentCoupon.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialPaymentCoupon() {
            try {
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Clear();
                dataGridViewCrudeFinancialPaymentCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("FinancialPaymentCouponId","Financial Payment Coupon");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialPaymentCouponId"].DataPropertyName = "FinancialPaymentCouponId";
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialPaymentCouponId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("FinancialCouponId","Financial Coupon");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialCouponId"].DataPropertyName = "FinancialCouponId";
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialCouponId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialPaymentCoupon.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialPaymentCoupon.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialPaymentCoupon.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialPaymentCoupon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialPaymentCoupon.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
