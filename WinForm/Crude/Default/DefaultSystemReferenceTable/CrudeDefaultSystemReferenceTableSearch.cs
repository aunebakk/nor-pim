/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:14 PM
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
    public partial class CrudeDefaultSystemReferenceTableSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemReferenceTable();
            this.AcceptButton = buttonCrudeDefaultSystemReferenceTableSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultSystemReferenceTable();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultSystemReferenceTableEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemReferenceTable.CurrentRow.Cells["DefaultSystemReferenceTableId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultSystemReferenceTableAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
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
        private void dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultSystemReferenceTableEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeDefaultSystemReferenceTable.CurrentRow.Cells["DefaultSystemReferenceTableId"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultSystemReferenceTableSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultSystemReferenceTable();
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
        public void RefreshCrudeDefaultSystemReferenceTable() {
            var defaultSystemReferenceTable = new CrudeDefaultSystemReferenceTableServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultSystemReferenceTable.FetchWithFilter(
                             Guid.Empty
                            ,textBoxDefaultSystemReferenceTableName.Text
                            ,textBoxDefaultSystemReferenceDisplayName.Text
                            ,Guid.Empty
                            ,dateTimePickerDateTime.Checked ? Convert.ToDateTime(dateTimePickerDateTime.Value): DateTime.MinValue
                            );
                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultSystemReferenceTable.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultSystemReferenceTable() {
            try {
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Clear();
                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableName","Default System Reference Table Name");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableName"].DataPropertyName = "DefaultSystemReferenceTableName";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceDisplayName","Default System Reference Display Name");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceDisplayName"].DataPropertyName = "DefaultSystemReferenceDisplayName";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableId","Default System Reference Table");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableId"].DataPropertyName = "DefaultSystemReferenceTableId";
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceTableId"].Visible = false;
                dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultSystemReferenceTable.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultSystemReferenceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
