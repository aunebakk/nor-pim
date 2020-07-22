/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:33 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.UserInterface {

    public partial class CrudeProductSupplierSearch : Form {
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        public CrudeProductSupplierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductSupplier();
            this.AcceptButton = buttonCrudeProductSupplierSearch;
            this.CancelButton = buttonClose;

        }
        
        public void Show(System.Guid productId, System.Guid userId) {
            try {
                _productId = productId;
                _userId = userId;
                RefreshCrudeProductSupplier();
                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductSupplierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductSupplierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductSupplierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductSupplierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void dataGridViewCrudeProductSupplier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductSupplierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductSupplier.CurrentRow.Cells["ProductSupplierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        private void buttonCrudeProductSupplierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductSupplier();
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
        
        public void RefreshCrudeProductSupplier() {
            var productSupplier = new CrudeProductSupplierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productSupplier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,textBoxSupplierName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductSupplier.AutoGenerateColumns = false;
                dataGridViewCrudeProductSupplier.DataSource = bindingSource;
                dataGridViewCrudeProductSupplier.AutoResizeColumns();
                dataGridViewCrudeProductSupplier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productSupplier.Close();
            }
        }
        
        private void InitializeGridCrudeProductSupplier() {
            try {
                dataGridViewCrudeProductSupplier.Columns.Clear();
                dataGridViewCrudeProductSupplier.AutoGenerateColumns = false;
                dataGridViewCrudeProductSupplier.Columns.Add("SupplierName","Supplier Name");
                dataGridViewCrudeProductSupplier.Columns["SupplierName"].DataPropertyName = "SupplierName";
                dataGridViewCrudeProductSupplier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductSupplier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductSupplier.Columns.Add("ProductSupplierId","Product Supplier");
                dataGridViewCrudeProductSupplier.Columns["ProductSupplierId"].DataPropertyName = "ProductSupplierId";
                dataGridViewCrudeProductSupplier.Columns["ProductSupplierId"].Visible = false;
                dataGridViewCrudeProductSupplier.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductSupplier.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductSupplier.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductSupplier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductSupplier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductSupplier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
