/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 2:15:22 PM
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
    public partial class CrudeProductImageTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        public CrudeProductImageTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeProductImageTypeRef();
            this.AcceptButton = buttonCrudeProductImageTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeProductImageTypeRef();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        private void buttonCrudeProductImageTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        private void buttonCrudeProductImageTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
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
        private void dataGridViewCrudeProductImageTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeProductImageTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeProductImageTypeRef.CurrentRow.Cells["ProductImageTypeRcd"].Value,_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        private void buttonCrudeProductImageTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeProductImageTypeRef();
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
        public void RefreshCrudeProductImageTypeRef() {
            var productImageTypeRef = new CrudeProductImageTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = productImageTypeRef.FetchWithFilter(
                             textBoxProductImageType.Text
                            ,textBoxProductImageTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductImageTypeRef.DataSource = bindingSource;
                dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
                dataGridViewCrudeProductImageTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                productImageTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        private void InitializeGridCrudeProductImageTypeRef() {
            try {
                dataGridViewCrudeProductImageTypeRef.Columns.Clear();
                dataGridViewCrudeProductImageTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeName","Product Image Type Name");
                dataGridViewCrudeProductImageTypeRef.Columns["ProductImageTypeName"].DataPropertyName = "ProductImageTypeName";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ProductImageTypeRcd","Product Image Type");
                dataGridViewCrudeProductImageTypeRef.Columns["ProductImageTypeRcd"].DataPropertyName = "ProductImageTypeRcd";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeProductImageTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeProductImageTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeProductImageTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeProductImageTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeProductImageTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
