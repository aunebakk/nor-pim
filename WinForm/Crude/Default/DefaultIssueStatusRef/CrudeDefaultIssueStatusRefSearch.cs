/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:49:01 PM
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
    public partial class CrudeDefaultIssueStatusRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultIssueStatusRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultIssueStatusRef();
            this.AcceptButton = buttonCrudeDefaultIssueStatusRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultIssueStatusRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultIssueStatusRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueStatusRef.CurrentRow.Cells["DefaultIssueStatusRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultIssueStatusRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void dataGridViewCrudeDefaultIssueStatusRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueStatusRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueStatusRef.CurrentRow.Cells["DefaultIssueStatusRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultIssueStatusRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultIssueStatusRef();
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
        public void RefreshCrudeDefaultIssueStatusRef() {
            var defaultIssueStatusRef = new CrudeDefaultIssueStatusRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultIssueStatusRef.FetchWithFilter(
                             textBoxDefaultIssueStatus.Text
                            ,textBoxDefaultIssueStatusName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultIssueStatusRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueStatusRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultIssueStatusRef.AutoResizeColumns();
                dataGridViewCrudeDefaultIssueStatusRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultIssueStatusRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultIssueStatusRef() {
            try {
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Clear();
                dataGridViewCrudeDefaultIssueStatusRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DefaultIssueStatusName","Default Issue Status Name");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DefaultIssueStatusName"].DataPropertyName = "DefaultIssueStatusName";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DefaultIssueStatusRcd","Default Issue Status");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DefaultIssueStatusRcd"].DataPropertyName = "DefaultIssueStatusRcd";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultIssueStatusRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultIssueStatusRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultIssueStatusRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultIssueStatusRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
