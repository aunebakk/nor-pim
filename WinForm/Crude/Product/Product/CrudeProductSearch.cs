/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:40:20 PM
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
    public partial class CrudeProductSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productBecameId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductSearch() {
            InitializeComponent();
            InitializeGridCrudeProduct();
            this.AcceptButton = buttonCrudeProductSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
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
        
        // shows the detailed version of the selected grid row, in edit modus
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
        
        // shows a form for adding more rows
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
        
        // shows the detailed version of the selected grid row, in edit modus
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
        
        // does a search based on the filter and populates the grid
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
        
        // closes the form
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
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
        
        // initialize the grid, hiding fields like guids and images
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
