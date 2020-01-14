/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:19:45 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialVoucherTypeRefSearch : Form {
        
        private System.Guid _userId;
        
        public CrudeFinancialVoucherTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialVoucherTypeRef();
            this.AcceptButton = buttonCrudeFinancialVoucherTypeRefSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                RefreshCrudeFinancialVoucherTypeRef();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialVoucherTypeRef.CurrentRow.Cells["FinancialVoucherTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialVoucherTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialVoucherTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeFinancialVoucherTypeRef.CurrentRow.Cells["FinancialVoucherTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialVoucherTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialVoucherTypeRef();
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
        
        public void RefreshCrudeFinancialVoucherTypeRef() {
            var financialVoucherTypeRef = new CrudeFinancialVoucherTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialVoucherTypeRef.FetchWithFilter(
                             textBoxFinancialVoucherType.Text
                            ,textBoxFinancialVoucherTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFinancialVoucherTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialVoucherTypeRef.DataSource = bindingSource;
                dataGridViewCrudeFinancialVoucherTypeRef.AutoResizeColumns();
                dataGridViewCrudeFinancialVoucherTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialVoucherTypeRef.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialVoucherTypeRef() {
            try {
                dataGridViewCrudeFinancialVoucherTypeRef.Columns.Clear();
                dataGridViewCrudeFinancialVoucherTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialVoucherTypeRef.Columns.Add("FinancialVoucherTypeName","Financial Voucher Type Name");
                dataGridViewCrudeFinancialVoucherTypeRef.Columns["FinancialVoucherTypeName"].DataPropertyName = "FinancialVoucherTypeName";
                dataGridViewCrudeFinancialVoucherTypeRef.Columns.Add("FinancialVoucherTypeRcd","Financial Voucher Type");
                dataGridViewCrudeFinancialVoucherTypeRef.Columns["FinancialVoucherTypeRcd"].DataPropertyName = "FinancialVoucherTypeRcd";
                dataGridViewCrudeFinancialVoucherTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialVoucherTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialVoucherTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialVoucherTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialVoucherTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialVoucherTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
