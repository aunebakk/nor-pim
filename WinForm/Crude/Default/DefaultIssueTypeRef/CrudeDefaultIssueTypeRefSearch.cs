/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:34 PM
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
    public partial class CrudeDefaultIssueTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultIssueTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultIssueTypeRef();
            this.AcceptButton = buttonCrudeDefaultIssueTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultIssueTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultIssueTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueTypeRef.CurrentRow.Cells["DefaultIssueTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultIssueTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
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
        private void dataGridViewCrudeDefaultIssueTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultIssueTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultIssueTypeRef.CurrentRow.Cells["DefaultIssueTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultIssueTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultIssueTypeRef();
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
        public void RefreshCrudeDefaultIssueTypeRef() {
            var defaultIssueTypeRef = new CrudeDefaultIssueTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultIssueTypeRef.FetchWithFilter(
                             textBoxDefaultIssueType.Text
                            ,textBoxDefaultIssueTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultIssueTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultIssueTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultIssueTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultIssueTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultIssueTypeRef() {
            try {
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultIssueTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DefaultIssueTypeName","Default Issue Type Name");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DefaultIssueTypeName"].DataPropertyName = "DefaultIssueTypeName";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DefaultIssueTypeRcd","Default Issue Type");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DefaultIssueTypeRcd"].DataPropertyName = "DefaultIssueTypeRcd";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultIssueTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultIssueTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultIssueTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultIssueTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
