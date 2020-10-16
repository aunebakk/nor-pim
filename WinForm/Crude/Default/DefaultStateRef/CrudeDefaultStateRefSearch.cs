/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:18 PM
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
    public partial class CrudeDefaultStateRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultStateRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultStateRef();
            this.AcceptButton = buttonCrudeDefaultStateRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultStateRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultStateRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultStateRef.CurrentRow.Cells["DefaultStateRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultStateRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
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
        private void dataGridViewCrudeDefaultStateRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultStateRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultStateRef.CurrentRow.Cells["DefaultStateRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultStateRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultStateRef();
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
        public void RefreshCrudeDefaultStateRef() {
            var defaultStateRef = new CrudeDefaultStateRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultStateRef.FetchWithFilter(
                             textBoxDefaultState.Text
                            ,textBoxDefaultStateName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultStateRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultStateRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultStateRef.AutoResizeColumns();
                dataGridViewCrudeDefaultStateRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultStateRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultStateRef() {
            try {
                dataGridViewCrudeDefaultStateRef.Columns.Clear();
                dataGridViewCrudeDefaultStateRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultStateRef.Columns.Add("DefaultStateName","Default State Name");
                dataGridViewCrudeDefaultStateRef.Columns["DefaultStateName"].DataPropertyName = "DefaultStateName";
                dataGridViewCrudeDefaultStateRef.Columns.Add("DefaultStateRcd","Default State");
                dataGridViewCrudeDefaultStateRef.Columns["DefaultStateRcd"].DataPropertyName = "DefaultStateRcd";
                dataGridViewCrudeDefaultStateRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultStateRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultStateRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultStateRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultStateRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultStateRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
