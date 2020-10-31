/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:06:25 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeProductExposedSelectionSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productExposeId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposedSelectionSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposedSelection();
            this.AcceptButton = buttonCrudeProductExposedSelectionSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid productExposeId, System.Guid userId) {
            try {
                _productExposeId = productExposeId;
                _userId = userId;

                RefreshCrudeProductExposedSelection();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductExposedSelectionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductExposedSelectionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
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
        private void dataGridViewCrudeProductExposedSelection_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposedSelectionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposedSelection.CurrentRow.Cells["ProductExposedSelectionId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductExposedSelectionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposedSelection();
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
        public void RefreshCrudeProductExposedSelection() {
            var productExposedSelection = new CrudeProductExposedSelectionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposedSelection.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposedSelection.DataSource = bindingSource;
                dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
                dataGridViewCrudeProductExposedSelection.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposedSelection.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductExposedSelection() {
            try {
                dataGridViewCrudeProductExposedSelection.Columns.Clear();
                dataGridViewCrudeProductExposedSelection.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposedSelection.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposedSelectionId","Product Exposed Selection");
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposedSelectionId"].DataPropertyName = "ProductExposedSelectionId";
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposedSelectionId"].Visible = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("ProductExposeId","Product Expose");
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposeId"].DataPropertyName = "ProductExposeId";
                dataGridViewCrudeProductExposedSelection.Columns["ProductExposeId"].Visible = false;
                dataGridViewCrudeProductExposedSelection.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposedSelection.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposedSelection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposedSelection.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
