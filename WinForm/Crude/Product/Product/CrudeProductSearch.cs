/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:47:26 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductSearch : Form {
        
        private System.Guid _productBecameId;
        
        private System.Guid _userId;
        
        public CrudeProductSearch() {
            InitializeComponent();
            InitializeGridCrudeProduct();
            this.AcceptButton = buttonCrudeProductSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productBecameId, System.Guid userId) {
            try {
                _productBecameId = productBecameId;
                _userId = userId;
                RefreshCrudeProduct();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProduct.CurrentRow.Cells["ProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProduct_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProduct.CurrentRow.Cells["ProductId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProduct();
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
        
        public void RefreshCrudeProduct() {
            var product = new CrudeProductServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = product.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,textBoxProductName.Text
                            ,textBoxState.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProduct.AutoGenerateColumns = false;
                dataGridViewCrudeProduct.DataSource = bindingSource;
                dataGridViewCrudeProduct.AutoResizeColumns();
                dataGridViewCrudeProduct.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                product.Close();
            }
        }
        
        private void InitializeGridCrudeProduct() {
            try {
                dataGridViewCrudeProduct.Columns.Clear();
                dataGridViewCrudeProduct.AutoGenerateColumns = false;
                dataGridViewCrudeProduct.Columns.Add("ProductName","Product Name");
                dataGridViewCrudeProduct.Columns["ProductName"].DataPropertyName = "ProductName";
                dataGridViewCrudeProduct.Columns.Add("StateRcd","State");
                dataGridViewCrudeProduct.Columns["StateRcd"].DataPropertyName = "StateRcd";
                dataGridViewCrudeProduct.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProduct.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProduct.Columns.Add("ProductId","Product");
                dataGridViewCrudeProduct.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProduct.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProduct.Columns.Add("ProductBecameId","Product Became");
                dataGridViewCrudeProduct.Columns["ProductBecameId"].DataPropertyName = "ProductBecameId";
                dataGridViewCrudeProduct.Columns["ProductBecameId"].Visible = false;
                dataGridViewCrudeProduct.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProduct.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProduct.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
