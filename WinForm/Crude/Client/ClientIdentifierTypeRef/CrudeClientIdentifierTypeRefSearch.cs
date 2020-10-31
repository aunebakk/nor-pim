/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:06:22 AM
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
    public partial class CrudeClientIdentifierTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeClientIdentifierTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeClientIdentifierTypeRef();
            this.AcceptButton = buttonCrudeClientIdentifierTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeClientIdentifierTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeClientIdentifierTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientIdentifierTypeRef.CurrentRow.Cells["ClientIdentifierTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeClientIdentifierTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierTypeRefEdit();
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
        private void dataGridViewCrudeClientIdentifierTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeClientIdentifierTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeClientIdentifierTypeRef.CurrentRow.Cells["ClientIdentifierTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeClientIdentifierTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeClientIdentifierTypeRef();
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
        public void RefreshCrudeClientIdentifierTypeRef() {
            var clientIdentifierTypeRef = new CrudeClientIdentifierTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = clientIdentifierTypeRef.FetchWithFilter(
                             textBoxClientIdentifierType.Text
                            ,textBoxClientIdentifierTypeName.Text
                            ,textBoxClientIdentifierTypeDescription.Text
                            ,Convert.ToBoolean(checkBoxActiveFlag.Checked)
                            ,maskedTextBoxSortOrder.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxSortOrder.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeClientIdentifierTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifierTypeRef.DataSource = bindingSource;
                dataGridViewCrudeClientIdentifierTypeRef.AutoResizeColumns();
                dataGridViewCrudeClientIdentifierTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                clientIdentifierTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeClientIdentifierTypeRef() {
            try {
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Clear();
                dataGridViewCrudeClientIdentifierTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("ClientIdentifierTypeName","Client Identifier Type Name");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["ClientIdentifierTypeName"].DataPropertyName = "ClientIdentifierTypeName";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("ClientIdentifierTypeRcd","Client Identifier Type");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["ClientIdentifierTypeRcd"].DataPropertyName = "ClientIdentifierTypeRcd";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("ClientIdentifierTypeDescription","Client Identifier Type Description");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["ClientIdentifierTypeDescription"].DataPropertyName = "ClientIdentifierTypeDescription";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("SortOrder","Sort Order");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["SortOrder"].DataPropertyName = "SortOrder";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("ActiveFlag","Active Flag");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["ActiveFlag"].DataPropertyName = "ActiveFlag";
                dataGridViewCrudeClientIdentifierTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeClientIdentifierTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeClientIdentifierTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeClientIdentifierTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
