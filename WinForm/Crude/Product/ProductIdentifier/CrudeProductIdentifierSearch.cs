/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:48:28 PM
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
    public partial class CrudeProductIdentifierSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productIdentifierRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeProductIdentifier();
            this.AcceptButton = buttonCrudeProductIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productIdentifierRcd, System.Guid productId, System.Guid userId) {
            try {
                _productIdentifierRcd = productIdentifierRcd;
                _productId = productId;
                _userId = userId;

                RefreshCrudeProductIdentifier();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
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
        private void dataGridViewCrudeProductIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductIdentifier.CurrentRow.Cells["ProductIdentifierId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductIdentifier();
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
        public void RefreshCrudeProductIdentifier() {
            var productIdentifier = new CrudeProductIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,Guid.Empty
                            ,productIdentifierRefCombo.Text
                            ,textBoxIdentifier.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifier.DataSource = bindingSource;
                dataGridViewCrudeProductIdentifier.AutoResizeColumns();
                dataGridViewCrudeProductIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productIdentifier.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductIdentifier() {
            try {
                dataGridViewCrudeProductIdentifier.Columns.Clear();
                dataGridViewCrudeProductIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierRcd","Product Identifier");
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierRcd"].DataPropertyName = "ProductIdentifierRcd";
                dataGridViewCrudeProductIdentifier.Columns.Add("Identifier","Identifier");
                dataGridViewCrudeProductIdentifier.Columns["Identifier"].DataPropertyName = "Identifier";
                dataGridViewCrudeProductIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductIdentifierId","Product Identifier");
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierId"].DataPropertyName = "ProductIdentifierId";
                dataGridViewCrudeProductIdentifier.Columns["ProductIdentifierId"].Visible = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ProductId","Product");
                dataGridViewCrudeProductIdentifier.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeProductIdentifier.Columns["ProductId"].Visible = false;
                dataGridViewCrudeProductIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
