/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 1:25:45 PM
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
    public partial class CrudeProductExposeSetSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private string _productExposeSetTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductExposeSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductExposeSet();
            this.AcceptButton = buttonCrudeProductExposeSetSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(string productExposeSetTypeRcd, System.Guid userId) {
            try {
                _productExposeSetTypeRcd = productExposeSetTypeRcd;
                _userId = userId;

                RefreshCrudeProductExposeSet();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductExposeSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductExposeSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
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
        private void dataGridViewCrudeProductExposeSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductExposeSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductExposeSet.CurrentRow.Cells["ProductExposeSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductExposeSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductExposeSet();
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
        public void RefreshCrudeProductExposeSet() {
            var productExposeSet = new CrudeProductExposeSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productExposeSet.FetchWithFilter(
                             Guid.Empty
                            ,productExposeSetTypeRefCombo.Text
                            ,textBoxProductExposeSetName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSet.DataSource = bindingSource;
                dataGridViewCrudeProductExposeSet.AutoResizeColumns();
                dataGridViewCrudeProductExposeSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productExposeSet.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductExposeSet() {
            try {
                dataGridViewCrudeProductExposeSet.Columns.Clear();
                dataGridViewCrudeProductExposeSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetName","Product Expose Set Name");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetName"].DataPropertyName = "ProductExposeSetName";
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetTypeRcd","Product Expose Set Type");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetTypeRcd"].DataPropertyName = "ProductExposeSetTypeRcd";
                dataGridViewCrudeProductExposeSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductExposeSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductExposeSet.Columns.Add("ProductExposeSetId","Product Expose Set");
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetId"].DataPropertyName = "ProductExposeSetId";
                dataGridViewCrudeProductExposeSet.Columns["ProductExposeSetId"].Visible = false;
                dataGridViewCrudeProductExposeSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductExposeSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductExposeSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductExposeSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
