/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 12:15:36 PM
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
    public partial class CrudeClientIdentifierSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientIdentifierTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeClientIdentifier();
            this.AcceptButton = buttonCrudeClientIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientIdentifierTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientIdentifierTypeRcd = clientIdentifierTypeRcd;
                _clientId = clientId;
                _userId = userId;

                RefreshCrudeClientIdentifier();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientIdentifier.CurrentRow.Cells["ClientIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
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
        private void dataGridViewCrudeClientIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientIdentifier.CurrentRow.Cells["ClientIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientIdentifier();
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
        public void RefreshCrudeClientIdentifier() {
            var clientIdentifier = new CrudeClientIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientIdentifierTypeRefCombo.Text
                            ,textBoxClientIdentifierCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifier.DataSource = bindingSource;
                dataGridViewCrudeClientIdentifier.AutoResizeColumns();
                dataGridViewCrudeClientIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientIdentifier.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientIdentifier() {
            try {
                dataGridViewCrudeClientIdentifier.Columns.Clear();
                dataGridViewCrudeClientIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierTypeRcd","Client Identifier Type");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierTypeRcd"].DataPropertyName = "ClientIdentifierTypeRcd";
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierCode","Client Identifier Code");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierCode"].DataPropertyName = "ClientIdentifierCode";
                dataGridViewCrudeClientIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientIdentifierId","Client Identifier");
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierId"].DataPropertyName = "ClientIdentifierId";
                dataGridViewCrudeClientIdentifier.Columns["ClientIdentifierId"].Visible = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientIdentifier.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientIdentifier.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
