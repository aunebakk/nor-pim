/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:49:00 PM
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
    public partial class CrudeDefaultChangeLogTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _defaultUserId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeDefaultChangeLogTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultChangeLogTypeRef();
            this.AcceptButton = buttonCrudeDefaultChangeLogTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid defaultUserId) {
            try {
                _defaultUserId = defaultUserId;

                RefreshCrudeDefaultChangeLogTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeDefaultChangeLogTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultChangeLogTypeRef.CurrentRow.Cells["DefaultChangeLogTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeDefaultChangeLogTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
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
        private void dataGridViewCrudeDefaultChangeLogTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeDefaultChangeLogTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeDefaultChangeLogTypeRef.CurrentRow.Cells["DefaultChangeLogTypeRcd"].Value,_defaultUserId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeDefaultChangeLogTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeDefaultChangeLogTypeRef();
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
        public void RefreshCrudeDefaultChangeLogTypeRef() {
            var defaultChangeLogTypeRef = new CrudeDefaultChangeLogTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = defaultChangeLogTypeRef.FetchWithFilter(
                             textBoxDefaultChangeLogType.Text
                            ,textBoxDefaultChangeLogTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLogTypeRef.DataSource = bindingSource;
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoResizeColumns();
                dataGridViewCrudeDefaultChangeLogTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                defaultChangeLogTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeDefaultChangeLogTypeRef() {
            try {
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Clear();
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DefaultChangeLogTypeName","Default Change Log Type Name");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DefaultChangeLogTypeName"].DataPropertyName = "DefaultChangeLogTypeName";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DefaultChangeLogTypeRcd","Default Change Log Type");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DefaultChangeLogTypeRcd"].DataPropertyName = "DefaultChangeLogTypeRcd";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeDefaultChangeLogTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeDefaultChangeLogTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeDefaultChangeLogTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
