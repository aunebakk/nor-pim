/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:48 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponSearch : Form {
        
        private string _financialCouponTypeRcd;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        public CrudeFinancialCouponSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCoupon();
            this.AcceptButton = buttonCrudeFinancialCouponSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialCouponTypeRcd, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _financialCouponTypeRcd = financialCouponTypeRcd;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                RefreshCrudeFinancialCoupon();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCoupon.CurrentRow.Cells["FinancialCouponId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCoupon_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialCoupon.CurrentRow.Cells["FinancialCouponId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCoupon();
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
        
        public void RefreshCrudeFinancialCoupon() {
            var financialCoupon = new CrudeFinancialCouponServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCoupon.FetchWithFilter(
                             Guid.Empty
                            ,maskedTextBoxCouponNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCouponNumber.Text)
                            ,maskedTextBoxValueAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxValueAmount.Text)
                            ,dateTimePickerValidFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidFromDateTime.Value): DateTime.MinValue
                            ,dateTimePickerValidUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerValidUntilDateTime.Value): DateTime.MinValue
                            ,textBoxCouponDescription.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,financialCouponTypeRefCombo.Text
                            );
                dataGridViewCrudeFinancialCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCoupon.DataSource = bindingSource;
                dataGridViewCrudeFinancialCoupon.AutoResizeColumns();
                dataGridViewCrudeFinancialCoupon.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCoupon.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCoupon() {
            try {
                dataGridViewCrudeFinancialCoupon.Columns.Clear();
                dataGridViewCrudeFinancialCoupon.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("CouponDescription","Coupon Description");
                dataGridViewCrudeFinancialCoupon.Columns["CouponDescription"].DataPropertyName = "CouponDescription";
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCouponTypeRcd","Financial Coupon Type");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponTypeRcd"].DataPropertyName = "FinancialCouponTypeRcd";
                dataGridViewCrudeFinancialCoupon.Columns.Add("CouponNumber","Coupon Number");
                dataGridViewCrudeFinancialCoupon.Columns["CouponNumber"].DataPropertyName = "CouponNumber";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValueAmount","Value Amount");
                dataGridViewCrudeFinancialCoupon.Columns["ValueAmount"].DataPropertyName = "ValueAmount";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValidFromDateTime","Valid From Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["ValidFromDateTime"].DataPropertyName = "ValidFromDateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("ValidUntilDateTime","Valid Until Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["ValidUntilDateTime"].DataPropertyName = "ValidUntilDateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCoupon.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCouponId","Financial Coupon");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponId"].DataPropertyName = "FinancialCouponId";
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCouponId"].Visible = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialCoupon.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialCoupon.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCoupon.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCoupon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCoupon.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
