/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:16 PM
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
    public partial class CrudeClientDocumentSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientDocumentTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientDocumentSearch() {
            InitializeComponent();
            InitializeGridCrudeClientDocument();
            this.AcceptButton = buttonCrudeClientDocumentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientDocumentTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientDocumentTypeRcd = clientDocumentTypeRcd;
                _clientId = clientId;
                _userId = userId;

                RefreshCrudeClientDocument();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientDocumentEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientDocument.CurrentRow.Cells["ClientDocumentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientDocumentAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
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
        private void dataGridViewCrudeClientDocument_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientDocumentEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientDocument.CurrentRow.Cells["ClientDocumentId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientDocumentSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientDocument();
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
        public void RefreshCrudeClientDocument() {
            var clientDocument = new CrudeClientDocumentServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientDocument.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientDocumentTypeRefCombo.Text
                            ,textBoxDocumentName.Text
                            ,dateTimePickerDocumentDateTime.Checked ? Convert.ToDateTime(dateTimePickerDocumentDateTime.Value): DateTime.MinValue
                            ,dateTimePickerExpiryDateTime.Checked ? Convert.ToDateTime(dateTimePickerExpiryDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientDocument.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocument.DataSource = bindingSource;
                dataGridViewCrudeClientDocument.AutoResizeColumns();
                dataGridViewCrudeClientDocument.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientDocument.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientDocument() {
            try {
                dataGridViewCrudeClientDocument.Columns.Clear();
                dataGridViewCrudeClientDocument.AutoGenerateColumns = false;
                dataGridViewCrudeClientDocument.Columns.Add("DocumentName","Document Name");
                dataGridViewCrudeClientDocument.Columns["DocumentName"].DataPropertyName = "DocumentName";
                dataGridViewCrudeClientDocument.Columns.Add("ClientDocumentTypeRcd","Client Document Type");
                dataGridViewCrudeClientDocument.Columns["ClientDocumentTypeRcd"].DataPropertyName = "ClientDocumentTypeRcd";
                dataGridViewCrudeClientDocument.Columns.Add("DocumentDateTime","Document Date Time");
                dataGridViewCrudeClientDocument.Columns["DocumentDateTime"].DataPropertyName = "DocumentDateTime";
                dataGridViewCrudeClientDocument.Columns.Add("ExpiryDateTime","Expiry Date Time");
                dataGridViewCrudeClientDocument.Columns["ExpiryDateTime"].DataPropertyName = "ExpiryDateTime";
                dataGridViewCrudeClientDocument.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientDocument.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientDocument.Columns.Add("ClientDocumentId","Client Document");
                dataGridViewCrudeClientDocument.Columns["ClientDocumentId"].DataPropertyName = "ClientDocumentId";
                dataGridViewCrudeClientDocument.Columns["ClientDocumentId"].Visible = false;
                dataGridViewCrudeClientDocument.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientDocument.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientDocument.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientDocument.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientDocument.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientDocument.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
