/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:42:44 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialAdjustmentSearch : Form {
        
        private string _financialAdjustmentTypeRcd;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        public CrudeFinancialAdjustmentSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialAdjustment();
            this.AcceptButton = buttonCrudeFinancialAdjustmentSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialAdjustmentTypeRcd, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _financialAdjustmentTypeRcd = financialAdjustmentTypeRcd;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                RefreshCrudeFinancialAdjustment();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialAdjustment.CurrentRow.Cells["FinancialAdjustmentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialAdjustment_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialAdjustmentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialAdjustment.CurrentRow.Cells["FinancialAdjustmentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialAdjustmentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialAdjustment();
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
        
        public void RefreshCrudeFinancialAdjustment() {
            var financialAdjustment = new CrudeFinancialAdjustmentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialAdjustment.FetchWithFilter(
                             Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,financialAdjustmentTypeRefCombo.Text
                            );
                dataGridViewCrudeFinancialAdjustment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialAdjustment.DataSource = bindingSource;
                dataGridViewCrudeFinancialAdjustment.AutoResizeColumns();
                dataGridViewCrudeFinancialAdjustment.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialAdjustment.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialAdjustment() {
            try {
                dataGridViewCrudeFinancialAdjustment.Columns.Clear();
                dataGridViewCrudeFinancialAdjustment.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialAdjustment.Columns.Add("FinancialAdjustmentTypeRcd","Financial Adjustment Type");
                dataGridViewCrudeFinancialAdjustment.Columns["FinancialAdjustmentTypeRcd"].DataPropertyName = "FinancialAdjustmentTypeRcd";
                dataGridViewCrudeFinancialAdjustment.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialAdjustment.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialAdjustment.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialAdjustment.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialAdjustment.Columns.Add("FinancialAdjustmentId","Financial Adjustment");
                dataGridViewCrudeFinancialAdjustment.Columns["FinancialAdjustmentId"].DataPropertyName = "FinancialAdjustmentId";
                dataGridViewCrudeFinancialAdjustment.Columns["FinancialAdjustmentId"].Visible = false;
                dataGridViewCrudeFinancialAdjustment.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialAdjustment.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialAdjustment.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialAdjustment.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialAdjustment.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialAdjustment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialAdjustment.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
