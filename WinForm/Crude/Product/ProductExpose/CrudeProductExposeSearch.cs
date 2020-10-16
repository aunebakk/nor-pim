/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:19 PM
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
    public partial class CrudeProductExposeSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _exposeProductId;
        
        private System.Guid _exposeBasedOnProductId;
        
        private System.Guid _productExposeSetId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposeSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExpose();
            this.AcceptButton = buttonCrudeProductExposeSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId) {
            try {
                _exposeProductId = exposeProductId;
                _exposeBasedOnProductId = exposeBasedOnProductId;
                _productExposeSetId = productExposeSetId;
                _userId = userId;

                RefreshCrudeProductExpose();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductExposeEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExpose.CurrentRow.Cells["ProductExposeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductExposeAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeEdit();
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
        private void dataGridViewCrudeProductExpose_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExpose.CurrentRow.Cells["ProductExposeId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductExposeSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExpose();
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
        public void RefreshCrudeProductExpose() {
            var productExpose = new CrudeProductExposeServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExpose.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExpose.AutoGenerateColumns = false;
                dataGridViewCrudeProductExpose.DataSource = bindingSource;
                dataGridViewCrudeProductExpose.AutoResizeColumns();
                dataGridViewCrudeProductExpose.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExpose.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductExpose() {
            try {
                dataGridViewCrudeProductExpose.Columns.Clear();
                dataGridViewCrudeProductExpose.AutoGenerateColumns = false;
                dataGridViewCrudeProductExpose.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExpose.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExpose.Columns.Add("ProductExposeId","Product Expose");
                dataGridViewCrudeProductExpose.Columns["ProductExposeId"].DataPropertyName = "ProductExposeId";
                dataGridViewCrudeProductExpose.Columns["ProductExposeId"].Visible = false;
                dataGridViewCrudeProductExpose.Columns.Add("ExposeProductId","Expose Product");
                dataGridViewCrudeProductExpose.Columns["ExposeProductId"].DataPropertyName = "ExposeProductId";
                dataGridViewCrudeProductExpose.Columns["ExposeProductId"].Visible = false;
                dataGridViewCrudeProductExpose.Columns.Add("ExposeBasedOnProductId","Expose Based On Product");
                dataGridViewCrudeProductExpose.Columns["ExposeBasedOnProductId"].DataPropertyName = "ExposeBasedOnProductId";
                dataGridViewCrudeProductExpose.Columns["ExposeBasedOnProductId"].Visible = false;
                dataGridViewCrudeProductExpose.Columns.Add("ProductExposeSetId","Product Expose Set");
                dataGridViewCrudeProductExpose.Columns["ProductExposeSetId"].DataPropertyName = "ProductExposeSetId";
                dataGridViewCrudeProductExpose.Columns["ProductExposeSetId"].Visible = false;
                dataGridViewCrudeProductExpose.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExpose.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExpose.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExpose.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
