/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:57:13 PM
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
    public partial class CrudeProductFieldSetSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductFieldSetSearch() {
            InitializeComponent();
            InitializeGridCrudeProductFieldSet();
            this.AcceptButton = buttonCrudeProductFieldSetSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductFieldSet();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductFieldSetEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductFieldSetAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
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
        private void dataGridViewCrudeProductFieldSet_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductFieldSetEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeProductFieldSet.CurrentRow.Cells["ProductFieldSetId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductFieldSetSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductFieldSet();
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
        public void RefreshCrudeProductFieldSet() {
            var productFieldSet = new CrudeProductFieldSetServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productFieldSet.FetchWithFilter(
                             Guid.Empty
                            ,textBoxProductFieldSetName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSet.DataSource = bindingSource;
                dataGridViewCrudeProductFieldSet.AutoResizeColumns();
                dataGridViewCrudeProductFieldSet.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productFieldSet.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductFieldSet() {
            try {
                dataGridViewCrudeProductFieldSet.Columns.Clear();
                dataGridViewCrudeProductFieldSet.AutoGenerateColumns = false;
                dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetName","Product Field Set Name");
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetName"].DataPropertyName = "ProductFieldSetName";
                dataGridViewCrudeProductFieldSet.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductFieldSet.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductFieldSet.Columns.Add("ProductFieldSetId","Product Field Set");
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetId"].DataPropertyName = "ProductFieldSetId";
                dataGridViewCrudeProductFieldSet.Columns["ProductFieldSetId"].Visible = false;
                dataGridViewCrudeProductFieldSet.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductFieldSet.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductFieldSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductFieldSet.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
