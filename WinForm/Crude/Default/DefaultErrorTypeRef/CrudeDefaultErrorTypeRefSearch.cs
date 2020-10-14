/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:48:26 PM
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
    public partial class CrudeDefaultErrorTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultErrorTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultErrorTypeRef();
            this.AcceptButton = buttonCrudeDefaultErrorTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultErrorTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultErrorTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorTypeRef.CurrentRow.Cells["DefaultErrorTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultErrorTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
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
        private void dataGridViewCrudeDefaultErrorTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultErrorTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultErrorTypeRef.CurrentRow.Cells["DefaultErrorTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultErrorTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultErrorTypeRef();
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
        public void RefreshCrudeDefaultErrorTypeRef() {
            var defaultErrorTypeRef = new CrudeDefaultErrorTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultErrorTypeRef.FetchWithFilter(
                             textBoxDefaultErrorType.Text
                            ,textBoxDefaultErrorTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultErrorTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultErrorTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultErrorTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultErrorTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultErrorTypeRef() {
            try {
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultErrorTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DefaultErrorTypeName","Default Error Type Name");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DefaultErrorTypeName"].DataPropertyName = "DefaultErrorTypeName";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DefaultErrorTypeRcd","Default Error Type");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DefaultErrorTypeRcd"].DataPropertyName = "DefaultErrorTypeRcd";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultErrorTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultErrorTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultErrorTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultErrorTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
