/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:36 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//   https://docs.microsoft.com/en-us/dotnet/framework/winforms/: client winform layer
namespace SolutionNorSolutionPim.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    public partial class CrudeProductSupplierSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductSupplierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductSupplier();
            this.AcceptButton = buttonCrudeProductSupplierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
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
        
        // shows the detailed version of the selected grid row, in edit modus
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
        
        // shows a form for adding more rows
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
        
        // shows the detailed version of the selected grid row, in edit modus
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
        
        // does a search based on the filter and populates the grid
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
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
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
        
        // initialize the grid, hiding fields like guids and images
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
