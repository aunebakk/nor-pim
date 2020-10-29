/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 1:31:34 PM
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
    public partial class CrudeProductIdentifierRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductIdentifierRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifierRef();
            this.AcceptButton = buttonCrudeProductIdentifierRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductIdentifierRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductIdentifierRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductIdentifierRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
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
        private void dataGridViewCrudeProductIdentifierRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductIdentifierRef.CurrentRow.Cells["ProductIdentifierRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductIdentifierRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductIdentifierRef();
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
        public void RefreshCrudeProductIdentifierRef() {
            var productIdentifierRef = new CrudeProductIdentifierRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productIdentifierRef.FetchWithFilter(
                             textBoxProductIdentifier.Text
                            ,textBoxProductIdentifierName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifierRef.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
                dataGridViewCrudeProductIdentifierRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productIdentifierRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductIdentifierRef() {
            try {
                dataGridViewCrudeProductIdentifierRef.Columns.Clear();
                dataGridViewCrudeProductIdentifierRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierName","Product Identifier Name");
                dataGridViewCrudeProductIdentifierRef.Columns["ProductIdentifierName"].DataPropertyName = "ProductIdentifierName";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewCrudeProductIdentifierRef.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductIdentifierRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductIdentifierRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductIdentifierRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductIdentifierRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductIdentifierRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
