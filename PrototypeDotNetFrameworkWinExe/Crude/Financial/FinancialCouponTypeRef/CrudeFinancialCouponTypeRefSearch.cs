/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:30 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialCouponTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialCouponTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialCouponTypeRef();
            this.AcceptButton = buttonCrudeFinancialCouponTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialCouponTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCouponTypeRef.CurrentRow.Cells["FinancialCouponTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialCouponTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialCouponTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialCouponTypeRef.CurrentRow.Cells["FinancialCouponTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialCouponTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialCouponTypeRef();
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
        
        public void RefreshCrudeFinancialCouponTypeRef() {
            var financialCouponTypeRef = new CrudeFinancialCouponTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialCouponTypeRef.FetchWithFilter(
                             textBoxFinancialCouponType.Text
                            ,textBoxFinancialCouponTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialCouponTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCouponTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialCouponTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialCouponTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialCouponTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialCouponTypeRef() {
            try {
                dataGridViewCrudeFinancialCouponTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialCouponTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialCouponTypeRef.Columns.Add("FinancialCouponTypeName","Financial Coupon Type Name");
                dataGridViewCrudeFinancialCouponTypeRef.Columns["FinancialCouponTypeName"].DataPropertyName = "FinancialCouponTypeName";
                dataGridViewCrudeFinancialCouponTypeRef.Columns.Add("FinancialCouponTypeRcd","Financial Coupon Type");
                dataGridViewCrudeFinancialCouponTypeRef.Columns["FinancialCouponTypeRcd"].DataPropertyName = "FinancialCouponTypeRcd";
                dataGridViewCrudeFinancialCouponTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialCouponTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialCouponTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialCouponTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialCouponTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialCouponTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
