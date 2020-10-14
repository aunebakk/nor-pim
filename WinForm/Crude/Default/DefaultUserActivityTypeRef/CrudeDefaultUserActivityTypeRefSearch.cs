/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:25:07 AM
  From Machine: DESKTOP-517I8BU
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
    public partial class CrudeDefaultUserActivityTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultUserActivityTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultUserActivityTypeRef();
            this.AcceptButton = buttonCrudeDefaultUserActivityTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultUserActivityTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultUserActivityTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultUserActivityTypeRef.CurrentRow.Cells["DefaultUserActivityTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultUserActivityTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
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
        private void dataGridViewCrudeDefaultUserActivityTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultUserActivityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultUserActivityTypeRef.CurrentRow.Cells["DefaultUserActivityTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultUserActivityTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultUserActivityTypeRef();
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
        public void RefreshCrudeDefaultUserActivityTypeRef() {
            var defaultUserActivityTypeRef = new CrudeDefaultUserActivityTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultUserActivityTypeRef.FetchWithFilter(
                             textBoxDefaultUserActivityType.Text
                            ,textBoxDefaultUserActivityTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivityTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultUserActivityTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultUserActivityTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultUserActivityTypeRef() {
            try {
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DefaultUserActivityTypeName","Default User Activity Type Name");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DefaultUserActivityTypeName"].DataPropertyName = "DefaultUserActivityTypeName";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DefaultUserActivityTypeRcd","Default User Activity Type");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DefaultUserActivityTypeRcd"].DataPropertyName = "DefaultUserActivityTypeRcd";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultUserActivityTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultUserActivityTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultUserActivityTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
