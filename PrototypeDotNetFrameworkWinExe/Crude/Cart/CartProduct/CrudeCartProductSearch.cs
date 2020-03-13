/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:41:41 AM
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {
    
    
    public partial class CrudeCartProductSearch : Form {
        
        private System.Guid _clientId;
        
        private System.Guid _productId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        public CrudeCartProductSearch() {
            InitializeComponent();
            InitializeGridCrudeCartProduct();
            this.AcceptButton = buttonCrudeCartProductSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId) {
            try {
                _clientId = clientId;
                _productId = productId;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                RefreshCrudeCartProduct();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProduct.CurrentRow.Cells["CartProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeCartProduct_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCartProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCartProduct.CurrentRow.Cells["CartProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeCartProductSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeCartProduct();
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
        
        public void RefreshCrudeCartProduct() {
            var cartProduct = new CrudeCartProductServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = cartProduct.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,maskedTextBoxAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxAmount.Text)
                            ,textBoxState.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeCartProduct.AutoGenerateColumns = false;
                dataGridViewCrudeCartProduct.DataSource = bindingSource;
                dataGridViewCrudeCartProduct.AutoResizeColumns();
                dataGridViewCrudeCartProduct.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                cartProduct.Close();
            }
        }
        
        private void InitializeGridCrudeCartProduct() {
            try {
                dataGridViewCrudeCartProduct.Columns.Clear();
                dataGridViewCrudeCartProduct.AutoGenerateColumns = false;
                dataGridViewCrudeCartProduct.Columns.Add("StateRcd","State");
                dataGridViewCrudeCartProduct.Columns["StateRcd"].DataPropertyName = "StateRcd";
                dataGridViewCrudeCartProduct.Columns.Add("Amount","Amount");
                dataGridViewCrudeCartProduct.Columns["Amount"].DataPropertyName = "Amount";
                dataGridViewCrudeCartProduct.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeCartProduct.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeCartProduct.Columns.Add("CartProductId","Cart Product");
                dataGridViewCrudeCartProduct.Columns["CartProductId"].DataPropertyName = "CartProductId";
                dataGridViewCrudeCartProduct.Columns["CartProductId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ClientId","Client");
                dataGridViewCrudeCartProduct.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeCartProduct.Columns["ClientId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ProductId","Product");
                dataGridViewCrudeCartProduct.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeCartProduct.Columns["ProductId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeCartProduct.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeCartProduct.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeCartProduct.Columns.Add("ExtensionData", "");
                dataGridViewCrudeCartProduct.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeCartProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeCartProduct.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
