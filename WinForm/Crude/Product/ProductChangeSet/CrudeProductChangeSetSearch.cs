/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:09:21 PM
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
    public partial class CrudeProductChangeSetSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _productId;
        
        private System.Guid _productGatherKeyId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductChangeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductChangeSet();
            this.AcceptButton = buttonCrudeProductChangeSetSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid productId, System.Guid productGatherKeyId, System.Guid userId) {
            try {
                _productId = productId;
                _productGatherKeyId = productGatherKeyId;
                _userId = userId;

                RefreshCrudeProductChangeSet();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductChangeSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductChangeSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
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
        private void dataGridViewCrudeProductChangeSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductChangeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductChangeSet.CurrentRow.Cells["ProductChangeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductChangeSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductChangeSet();
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
        public void RefreshCrudeProductChangeSet() {
            var productChangeSet = new CrudeProductChangeSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productChangeSet.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductChangeSet.DataSource = bindingSource;
                dataGridViewCrudeProductChangeSet.AutoResizeColumns();
                dataGridViewCrudeProductChangeSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productChangeSet.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductChangeSet() {
            try {
                dataGridViewCrudeProductChangeSet.Columns.Clear();
                dataGridViewCrudeProductChangeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductChangeSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductChangeSetId","Product Change Set");
                dataGridViewCrudeProductChangeSet.Columns["ProductChangeSetId"].DataPropertyName = "ProductChangeSetId";
                dataGridViewCrudeProductChangeSet.Columns["ProductChangeSetId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductChangeSet.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductChangeSet.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ProductGatherKeyId","Product Gather Key");
                dataGridViewCrudeProductChangeSet.Columns["ProductGatherKeyId"].DataPropertyName = "ProductGatherKeyId";
                dataGridViewCrudeProductChangeSet.Columns["ProductGatherKeyId"].Visible = false;
                dataGridViewCrudeProductChangeSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductChangeSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductChangeSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductChangeSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
