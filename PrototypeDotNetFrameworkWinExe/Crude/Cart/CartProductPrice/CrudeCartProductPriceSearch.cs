/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:39:59 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeCartProductPriceSearch : Form {
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        private System.Guid _productId;
        
        public CrudeCartProductPriceSearch() {
            InitializeComponent();
            InitializeGridCrudeCartProductPrice();
            this.AcceptButton = buttonCrudeCartProductPriceSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid financialCurrencyId, System.Guid userId, System.Guid productId) {
            try {
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                _productId = productId;
                RefreshCrudeCartProductPrice();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductPriceEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductPriceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProductPrice.CurrentRow.Cells["CartProductPriceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductPriceAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductPriceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeCartProductPrice_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductPriceEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProductPrice.CurrentRow.Cells["CartProductPriceId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductPriceSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeCartProductPrice();
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
        
        public void RefreshCrudeCartProductPrice() {
            var cartProductPrice = new CrudeCartProductPriceServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = cartProductPrice.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,textBoxState.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            );
                dataGridViewCrudeCartProductPrice.AutoGenerateColumns = false;
                dataGridViewCrudeCartProductPrice.DataSource = bindingSource;
                dataGridViewCrudeCartProductPrice.AutoResizeColumns();
                dataGridViewCrudeCartProductPrice.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                cartProductPrice.Close();
            }
        }
        
        private void InitializeGridCrudeCartProductPrice() {
            try {
                dataGridViewCrudeCartProductPrice.Columns.Clear();
                dataGridViewCrudeCartProductPrice.AutoGenerateColumns = false;
                dataGridViewCrudeCartProductPrice.Columns.Add("StateRcd","State");
                dataGridViewCrudeCartProductPrice.Columns["StateRcd"].DataPropertyName = "StateRcd";
                dataGridViewCrudeCartProductPrice.Columns.Add("Amount","Amount");
                dataGridViewCrudeCartProductPrice.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeCartProductPrice.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeCartProductPrice.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeCartProductPrice.Columns.Add("CartProductPriceId","Cart Product Price");
                dataGridViewCrudeCartProductPrice.Columns["CartProductPriceId"].DataPropertyName = "CartProductPriceId";
                dataGridViewCrudeCartProductPrice.Columns["CartProductPriceId"].Visible = false;
                dataGridViewCrudeCartProductPrice.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeCartProductPrice.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeCartProductPrice.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeCartProductPrice.Columns.Add("ProductId","Product");
                dataGridViewCrudeCartProductPrice.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeCartProductPrice.Columns["ProductId"].Visible = false;
                dataGridViewCrudeCartProductPrice.Columns.Add("ExtensionData", "");
                dataGridViewCrudeCartProductPrice.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeCartProductPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeCartProductPrice.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
