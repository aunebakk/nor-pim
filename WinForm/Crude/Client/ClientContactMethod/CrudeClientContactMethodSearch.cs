/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:09:18 PM
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
    public partial class CrudeClientContactMethodSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _clientContactMethodRcd;
        
        private System.Guid _clientId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientContactMethodSearch() {
            InitializeComponent();
            InitializeGridCrudeClientContactMethod();
            this.AcceptButton = buttonCrudeClientContactMethodSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string clientContactMethodRcd, System.Guid clientId, System.Guid userId) {
            try {
                _clientContactMethodRcd = clientContactMethodRcd;
                _clientId = clientId;
                _userId = userId;

                RefreshCrudeClientContactMethod();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientContactMethodEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientContactMethod.CurrentRow.Cells["ClientContactMethodId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientContactMethodAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
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
        private void dataGridViewCrudeClientContactMethod_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientContactMethodEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeClientContactMethod.CurrentRow.Cells["ClientContactMethodId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientContactMethodSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientContactMethod();
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
        public void RefreshCrudeClientContactMethod() {
            var clientContactMethod = new CrudeClientContactMethodServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientContactMethod.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,clientContactMethodRefCombo.Text
                            ,textBoxContactMethodWay.Text
                            ,textBoxComment.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientContactMethod.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethod.DataSource = bindingSource;
                dataGridViewCrudeClientContactMethod.AutoResizeColumns();
                dataGridViewCrudeClientContactMethod.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientContactMethod.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientContactMethod() {
            try {
                dataGridViewCrudeClientContactMethod.Columns.Clear();
                dataGridViewCrudeClientContactMethod.AutoGenerateColumns = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ClientContactMethodRcd","Client Contact Method");
                dataGridViewCrudeClientContactMethod.Columns["ClientContactMethodRcd"].DataPropertyName = "ClientContactMethodRcd";
                dataGridViewCrudeClientContactMethod.Columns.Add("ContactMethodWay","Contact Method Way");
                dataGridViewCrudeClientContactMethod.Columns["ContactMethodWay"].DataPropertyName = "ContactMethodWay";
                dataGridViewCrudeClientContactMethod.Columns.Add("Comment","Comment");
                dataGridViewCrudeClientContactMethod.Columns["Comment"].DataPropertyName = "Comment";
                dataGridViewCrudeClientContactMethod.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientContactMethod.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientContactMethod.Columns.Add("ClientContactMethodId","Client Contact Method");
                dataGridViewCrudeClientContactMethod.Columns["ClientContactMethodId"].DataPropertyName = "ClientContactMethodId";
                dataGridViewCrudeClientContactMethod.Columns["ClientContactMethodId"].Visible = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ClientId","Client");
                dataGridViewCrudeClientContactMethod.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeClientContactMethod.Columns["ClientId"].Visible = false;
                dataGridViewCrudeClientContactMethod.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientContactMethod.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientContactMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientContactMethod.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
