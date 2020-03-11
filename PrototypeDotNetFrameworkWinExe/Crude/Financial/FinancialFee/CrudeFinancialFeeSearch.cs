/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:29:36 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialFeeSearch : Form {
        
        private string _financialFeeTypeRcd;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialFeeSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialFee();
            this.AcceptButton = buttonCrudeFinancialFeeSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialFeeTypeRcd, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialFeeTypeRcd = financialFeeTypeRcd;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialFee();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialFee.CurrentRow.Cells["FinancialFeeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialFee_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialFeeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialFee.CurrentRow.Cells["FinancialFeeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialFeeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialFee();
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
        
        public void RefreshCrudeFinancialFee() {
            var financialFee = new CrudeFinancialFeeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialFee.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,financialFeeTypeRefCombo.Text
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            );
                dataGridViewCrudeFinancialFee.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialFee.DataSource = bindingSource;
                dataGridViewCrudeFinancialFee.AutoResizeColumns();
                dataGridViewCrudeFinancialFee.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialFee.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialFee() {
            try {
                dataGridViewCrudeFinancialFee.Columns.Clear();
                dataGridViewCrudeFinancialFee.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialFee.Columns.Add("FinancialFeeTypeRcd","Financial Fee Type");
                dataGridViewCrudeFinancialFee.Columns["FinancialFeeTypeRcd"].DataPropertyName = "FinancialFeeTypeRcd";
                dataGridViewCrudeFinancialFee.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialFee.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialFee.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialFee.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialFee.Columns.Add("FinancialFeeId","Financial Fee");
                dataGridViewCrudeFinancialFee.Columns["FinancialFeeId"].DataPropertyName = "FinancialFeeId";
                dataGridViewCrudeFinancialFee.Columns["FinancialFeeId"].Visible = false;
                dataGridViewCrudeFinancialFee.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialFee.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialFee.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialFee.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialFee.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialFee.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
