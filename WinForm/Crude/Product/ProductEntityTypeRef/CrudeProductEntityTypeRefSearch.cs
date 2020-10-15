/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:56 PM
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
    public partial class CrudeProductEntityTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductEntityTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductEntityTypeRef();
            this.AcceptButton = buttonCrudeProductEntityTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductEntityTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductEntityTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductEntityTypeRef.CurrentRow.Cells["ProductEntityTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductEntityTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
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
        private void dataGridViewCrudeProductEntityTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductEntityTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductEntityTypeRef.CurrentRow.Cells["ProductEntityTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductEntityTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductEntityTypeRef();
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
        public void RefreshCrudeProductEntityTypeRef() {
            var productEntityTypeRef = new CrudeProductEntityTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productEntityTypeRef.FetchWithFilter(
                             textBoxProductEntityType.Text
                            ,textBoxProductEntityTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductEntityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductEntityTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductEntityTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductEntityTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productEntityTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductEntityTypeRef() {
            try {
                dataGridViewCrudeProductEntityTypeRef.Columns.Clear();
                dataGridViewCrudeProductEntityTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ProductEntityTypeName","Product Entity Type Name");
                dataGridViewCrudeProductEntityTypeRef.Columns["ProductEntityTypeName"].DataPropertyName = "ProductEntityTypeName";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ProductEntityTypeRcd","Product Entity Type");
                dataGridViewCrudeProductEntityTypeRef.Columns["ProductEntityTypeRcd"].DataPropertyName = "ProductEntityTypeRcd";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductEntityTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductEntityTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductEntityTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductEntityTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductEntityTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
