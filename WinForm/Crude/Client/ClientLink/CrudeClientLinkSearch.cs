/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 1:35:30 PM
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
    public partial class CrudeClientLinkSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientLinkTypeRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientLinkSearch() {
            InitializeComponent();
            InitializeGridCrudeClientLink();
            this.AcceptButton = buttonCrudeClientLinkSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientLinkTypeRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientLinkTypeRcd = clientLinkTypeRcd;
                _clientId = clientId;
                _userId = userId;

                RefreshCrudeClientLink();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientLinkEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientLink.CurrentRow.Cells["ClientLinkId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientLinkAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
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
        private void dataGridViewCrudeClientLink_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientLinkEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientLink.CurrentRow.Cells["ClientLinkId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientLinkSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientLink();
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
        public void RefreshCrudeClientLink() {
            var clientLink = new CrudeClientLinkServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientLink.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientLinkTypeRefCombo.Text
                            ,textBoxLinkName.Text
                            ,textBoxLink.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientLink.AutoGenerateColumns = false;
                dataGridViewCrudeClientLink.DataSource = bindingSource;
                dataGridViewCrudeClientLink.AutoResizeColumns();
                dataGridViewCrudeClientLink.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientLink.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientLink() {
            try {
                dataGridViewCrudeClientLink.Columns.Clear();
                dataGridViewCrudeClientLink.AutoGenerateColumns = false;
                dataGridViewCrudeClientLink.Columns.Add("LinkName","Link Name");
                dataGridViewCrudeClientLink.Columns["LinkName"].DataPropertyName = "LinkName";
                dataGridViewCrudeClientLink.Columns.Add("ClientLinkTypeRcd","Client Link Type");
                dataGridViewCrudeClientLink.Columns["ClientLinkTypeRcd"].DataPropertyName = "ClientLinkTypeRcd";
                dataGridViewCrudeClientLink.Columns.Add("Link","Link");
                dataGridViewCrudeClientLink.Columns["Link"].DataPropertyName = "Link";
                dataGridViewCrudeClientLink.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientLink.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientLink.Columns.Add("ClientLinkId","Client Link");
                dataGridViewCrudeClientLink.Columns["ClientLinkId"].DataPropertyName = "ClientLinkId";
                dataGridViewCrudeClientLink.Columns["ClientLinkId"].Visible = false;
                dataGridViewCrudeClientLink.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientLink.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientLink.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientLink.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientLink.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientLink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientLink.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
