/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:25:33 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeFinancialOrderLineSearch : Form {
        
        private string _financialUnitOfMeasurementRcd;
        
        private System.Guid _financialOrderId;
        
        private System.Guid _userId;
        
        private System.Guid _financialCurrencyId;
        
        public CrudeFinancialOrderLineSearch() {
            InitializeComponent();
            InitializeGridCrudeFinancialOrderLine();
            this.AcceptButton = buttonCrudeFinancialOrderLineSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(string financialUnitOfMeasurementRcd, System.Guid financialOrderId, System.Guid userId, System.Guid financialCurrencyId) {
            try {
                _financialUnitOfMeasurementRcd = financialUnitOfMeasurementRcd;
                _financialOrderId = financialOrderId;
                _userId = userId;
                _financialCurrencyId = financialCurrencyId;
                RefreshCrudeFinancialOrderLine();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderLineEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderLineEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderLine.CurrentRow.Cells["FinancialOrderLineId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderLineAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderLineEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeFinancialOrderLine_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFinancialOrderLineEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFinancialOrderLine.CurrentRow.Cells["FinancialOrderLineId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeFinancialOrderLineSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFinancialOrderLine();
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
        
        public void RefreshCrudeFinancialOrderLine() {
            var financialOrderLine = new CrudeFinancialOrderLineServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = financialOrderLine.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,textBoxComment.Text
                            ,maskedTextBoxLineNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxLineNumber.Text)
                            ,financialUnitOfMeasurementRefCombo.Text
                            ,maskedTextBoxQuantityNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxQuantityNumber.Text)
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            );
                dataGridViewCrudeFinancialOrderLine.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderLine.DataSource = bindingSource;
                dataGridViewCrudeFinancialOrderLine.AutoResizeColumns();
                dataGridViewCrudeFinancialOrderLine.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                financialOrderLine.Close();
            }
        }
        
        private void InitializeGridCrudeFinancialOrderLine() {
            try {
                dataGridViewCrudeFinancialOrderLine.Columns.Clear();
                dataGridViewCrudeFinancialOrderLine.AutoGenerateColumns = false;
                dataGridViewCrudeFinancialOrderLine.Columns.Add("Comment","Comment");
                dataGridViewCrudeFinancialOrderLine.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("FinancialUnitOfMeasurementRcd","Financial Unit Of Measurement");
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialUnitOfMeasurementRcd"].DataPropertyName = "FinancialUnitOfMeasurementRcd";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("LineNumber","Line Number");
                dataGridViewCrudeFinancialOrderLine.Columns["LineNumber"].DataPropertyName = "LineNumber";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("QuantityNumber","Quantity Number");
                dataGridViewCrudeFinancialOrderLine.Columns["QuantityNumber"].DataPropertyName = "QuantityNumber";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("Amount","Amount");
                dataGridViewCrudeFinancialOrderLine.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFinancialOrderLine.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFinancialOrderLine.Columns.Add("FinancialOrderLineId","Financial Order Line");
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialOrderLineId"].DataPropertyName = "FinancialOrderLineId";
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialOrderLineId"].Visible = false;
                dataGridViewCrudeFinancialOrderLine.Columns.Add("FinancialOrderId","Financial Order");
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialOrderId"].DataPropertyName = "FinancialOrderId";
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialOrderId"].Visible = false;
                dataGridViewCrudeFinancialOrderLine.Columns.Add("ProductId","Product");
                dataGridViewCrudeFinancialOrderLine.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeFinancialOrderLine.Columns["ProductId"].Visible = false;
                dataGridViewCrudeFinancialOrderLine.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeFinancialOrderLine.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeFinancialOrderLine.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFinancialOrderLine.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFinancialOrderLine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFinancialOrderLine.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
