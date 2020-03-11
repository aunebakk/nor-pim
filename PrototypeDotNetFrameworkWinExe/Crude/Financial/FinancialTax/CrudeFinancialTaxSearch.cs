/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 9:02:10 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialTaxSearch : Form {
        
        private string _financialTaxTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialTaxSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialTax();
            this.AcceptButton = buttonCrudeFinancialTaxSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialTaxTypeRcd, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialTaxTypeRcd = financialTaxTypeRcd;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialTax();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialTax.CurrentRow.Cells["FinancialTaxId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialTax_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialTaxEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialTax.CurrentRow.Cells["FinancialTaxId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialTaxSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialTax();
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
        
        public void RefreshCrudeFinancialTax() {
            var financialTax = new CrudeFinancialTaxServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialTax.FetchWithFilter(
                             Guid.Empty
                            ,financialTaxTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            );
                dataGridViewCrudeFinancialTax.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialTax.DataSource = bindingSource;
                dataGridViewCrudeFinancialTax.AutoResizeColumns();
                dataGridViewCrudeFinancialTax.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialTax.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialTax() {
            try {
                dataGridViewCrudeFinancialTax.Columns.Clear();
                dataGridViewCrudeFinancialTax.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialTax.Columns.Add("FinancialTaxTypeRcd","Financial Tax Type");
                dataGridViewCrudeFinancialTax.Columns["FinancialTaxTypeRcd"].DataPropertyName = "FinancialTaxTypeRcd";
                dataGridViewCrudeFinancialTax.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialTax.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialTax.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialTax.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialTax.Columns.Add("FinancialTaxId","Financial Tax");
                dataGridViewCrudeFinancialTax.Columns["FinancialTaxId"].DataPropertyName = "FinancialTaxId";
                dataGridViewCrudeFinancialTax.Columns["FinancialTaxId"].Visible = false;
                dataGridViewCrudeFinancialTax.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialTax.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialTax.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialTax.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialTax.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialTax.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialTax.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
