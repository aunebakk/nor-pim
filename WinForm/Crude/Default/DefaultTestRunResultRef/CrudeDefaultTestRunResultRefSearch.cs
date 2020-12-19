/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:49 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial class CrudeDefaultTestRunResultRefSearch : Form {
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultTestRunResultRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultTestRunResultRef();
            this.AcceptButton = buttonCrudeDefaultTestRunResultRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public new void Show() {
            try {

                RefreshCrudeDefaultTestRunResultRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultTestRunResultRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultTestRunResultRef.CurrentRow.Cells["DefaultTestRunResultRcd"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultTestRunResultRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAdd();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultTestRunResultRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultTestRunResultRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultTestRunResultRef.CurrentRow.Cells["DefaultTestRunResultRcd"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultTestRunResultRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultTestRunResultRef();
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
        public void RefreshCrudeDefaultTestRunResultRef() {
            var defaultTestRunResultRef = new CrudeDefaultTestRunResultRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultTestRunResultRef.FetchWithFilter(
                             textBoxDefaultTestRunResult.Text
                            ,textBoxDefaultTestRunResultName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultTestRunResultRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRunResultRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultTestRunResultRef.AutoResizeColumns();
                dataGridViewCrudeDefaultTestRunResultRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultTestRunResultRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultTestRunResultRef() {
            try {
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Clear();
                dataGridViewCrudeDefaultTestRunResultRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DefaultTestRunResultName","Default Test Run Result Name");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DefaultTestRunResultName"].DataPropertyName = "DefaultTestRunResultName";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DefaultTestRunResultRcd"].DataPropertyName = "DefaultTestRunResultRcd";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("UserId","User");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["UserId"].DataPropertyName = "UserId";
                dataGridViewCrudeDefaultTestRunResultRef.Columns["UserId"].Visible = false;
                dataGridViewCrudeDefaultTestRunResultRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultTestRunResultRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultTestRunResultRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultTestRunResultRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
