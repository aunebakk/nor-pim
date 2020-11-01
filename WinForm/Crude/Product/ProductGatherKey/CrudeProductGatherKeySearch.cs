/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:17:32 PM
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
    public partial class CrudeProductGatherKeySearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productGatherId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherKeySearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherKey();
            this.AcceptButton = buttonCrudeProductGatherKeySearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid productGatherId, System.Guid userId) {
            try {
                _productGatherId = productGatherId;
                _userId = userId;

                RefreshCrudeProductGatherKey();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductGatherKeyEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductGatherKeyAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
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
        private void dataGridViewCrudeProductGatherKey_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherKeyEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductGatherKey.CurrentRow.Cells["ProductGatherKeyId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductGatherKeySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherKey();
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
        public void RefreshCrudeProductGatherKey() {
            var productGatherKey = new CrudeProductGatherKeyServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherKey.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductGatherKeyValue.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherKey.DataSource = bindingSource;
                dataGridViewCrudeProductGatherKey.AutoResizeColumns();
                dataGridViewCrudeProductGatherKey.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherKey.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductGatherKey() {
            try {
                dataGridViewCrudeProductGatherKey.Columns.Clear();
                dataGridViewCrudeProductGatherKey.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyValue","Product Gather Key Value");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyValue"].DataPropertyName = "ProductGatherKeyValue";
                dataGridViewCrudeProductGatherKey.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherKey.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ProductGatherId","Product Gather");
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherId"].DataPropertyName = "ProductGatherId";
                dataGridViewCrudeProductGatherKey.Columns["ProductGatherId"].Visible = false;
                dataGridViewCrudeProductGatherKey.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherKey.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherKey.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
