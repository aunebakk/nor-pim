/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 1:25:42 PM
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
    public partial class CrudeClientEventSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientEventTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientEventSearch() {
            InitializeComponent();
            InitializeGridCrudeClientEvent();
            this.AcceptButton = buttonCrudeClientEventSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientEventTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientEventTypeRcd = clientEventTypeRcd;
                _clientId = clientId;
                _userId = userId;

                RefreshCrudeClientEvent();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientEventEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientEvent.CurrentRow.Cells["ClientEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientEventAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
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
        private void dataGridViewCrudeClientEvent_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientEventEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientEvent.CurrentRow.Cells["ClientEventId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientEventSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientEvent();
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
        public void RefreshCrudeClientEvent() {
            var clientEvent = new CrudeClientEventServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientEvent.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientEventTypeRefCombo.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientEvent.AutoGenerateColumns = false;
                dataGridViewCrudeClientEvent.DataSource = bindingSource;
                dataGridViewCrudeClientEvent.AutoResizeColumns();
                dataGridViewCrudeClientEvent.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientEvent.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientEvent() {
            try {
                dataGridViewCrudeClientEvent.Columns.Clear();
                dataGridViewCrudeClientEvent.AutoGenerateColumns = false;
                dataGridViewCrudeClientEvent.Columns.Add("ClientEventTypeRcd","Client Event Type");
                dataGridViewCrudeClientEvent.Columns["ClientEventTypeRcd"].DataPropertyName = "ClientEventTypeRcd";
                dataGridViewCrudeClientEvent.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientEvent.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientEvent.Columns.Add("ClientEventId","Client Event");
                dataGridViewCrudeClientEvent.Columns["ClientEventId"].DataPropertyName = "ClientEventId";
                dataGridViewCrudeClientEvent.Columns["ClientEventId"].Visible = false;
                dataGridViewCrudeClientEvent.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientEvent.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientEvent.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientEvent.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientEvent.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientEvent.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
