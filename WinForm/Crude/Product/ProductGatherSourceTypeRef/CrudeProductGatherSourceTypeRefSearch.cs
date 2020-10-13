/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:34:16 PM
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
    public partial class CrudeProductGatherSourceTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductGatherSourceTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductGatherSourceTypeRef();
            this.AcceptButton = buttonCrudeProductGatherSourceTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductGatherSourceTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductGatherSourceTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductGatherSourceTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
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
        private void dataGridViewCrudeProductGatherSourceTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductGatherSourceTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductGatherSourceTypeRef.CurrentRow.Cells["ProductGatherSourceTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductGatherSourceTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductGatherSourceTypeRef();
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
        public void RefreshCrudeProductGatherSourceTypeRef() {
            var productGatherSourceTypeRef = new CrudeProductGatherSourceTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productGatherSourceTypeRef.FetchWithFilter(
                             textBoxProductGatherSourceType.Text
                            ,textBoxProductGatherSourceTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSourceTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductGatherSourceTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productGatherSourceTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductGatherSourceTypeRef() {
            try {
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Clear();
                dataGridViewCrudeProductGatherSourceTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeName","Product Gather Source Type Name");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ProductGatherSourceTypeName"].DataPropertyName = "ProductGatherSourceTypeName";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ProductGatherSourceTypeRcd","Product Gather Source Type");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ProductGatherSourceTypeRcd"].DataPropertyName = "ProductGatherSourceTypeRcd";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductGatherSourceTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductGatherSourceTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductGatherSourceTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductGatherSourceTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
